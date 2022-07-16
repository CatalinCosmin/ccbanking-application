using System.Collections.Generic;
using System.Media;
using CCBANKING.Forms;
using Npgsql;

namespace CCBANKING.Entities
{
    public class User
    {
        public User(int user_id, string username, string password, string email)
        {
            this.id = user_id;
            this.username = username;
            this.password = password;
            this.email = email;
        }
        public string username { get; }
        public int id { get; }
        public string password { get; }
        public string email { get; }
    }

    public class Card
    {
        public Card(int card_id, int user_id, string number, string pin, string ccv, string created_on, int balance)
        {
            this.card_id = card_id;
            this.user_id = user_id;
            this.number = number;
            this.pin = pin;
            this.ccv = ccv;
            this.created_on = created_on;
            this.balance = balance;
        }

        public int card_id { get; }
        public int user_id { get; }
        public string number { get; }
        public string pin { get; }
        public string ccv { get; }
        public string created_on { get; }
        public int balance { get; set; }
    }
    public static class UserData
    {
        public static readonly string db = "Host=tai.db.elephantsql.com;Username=snmzecak;Password=1R_9bwKmZOJ8S9MNJLclXrdjZWThB7Sp;Database=snmzecak"; // database to connect to
        public static User user; // user data
        public static List<Card> cards;
        public static Card SelectedCard;
        public static NpgsqlConnection connection = new NpgsqlConnection(db);
        public static bool GetData(string username, string password)
        {
            bool found = false;
            if (connection.State != System.Data.ConnectionState.Open)
            {
                connection.Close();
                connection.Open();
            }// connect to the db database
            {
                var sqlcmd = $"SELECT * FROM view_account WHERE username = '{username.ToLower()}'"; // query VIEW from given username
                using (var cmd = new NpgsqlCommand(sqlcmd, connection))
                {
                    using (NpgsqlDataReader reader = cmd.ExecuteReader()) // execute the 'sqlcmd' query
                    {
                        if (reader.HasRows)
                        {
                            reader.Read(); // get the first row of the query
                            user = new User(reader.GetInt32(0), reader["username"].ToString(), reader["password"].ToString(), reader["email"].ToString()); // create the user data
                            if (password == reader["password"].ToString()) found = true;
                        }
                    }
                }
                if(found) GetCards(connection);
            }
            return found;
        }

        public static void GetCards(NpgsqlConnection connection)
         {
            string sqlcmd;
            cards = new List<Card>();
            sqlcmd = $"SELECT * FROM view_cards WHERE user_id = {user.id}";
            using (var cmd = new NpgsqlCommand(sqlcmd, connection))
            {
                using (NpgsqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            cards.Add(new Card(
                                reader.GetInt32(0),
                                reader.GetInt32(1),
                                reader["number"].ToString(),
                                reader["pin"].ToString(),
                                reader["ccv"].ToString(),
                                reader["created_on"].ToString(),
                                reader.GetInt32(6)));
                        }
                    }
                }
            }
        }

        public static bool AddCard(string number, string pin, string ccv)
        {
            bool ok = false;
            int id=0;
            {

                var sqlcmd = $"SELECT * FROM view_cards WHERE number = '{number}' AND user_id = 0";
                using (var cmd = new NpgsqlCommand(sqlcmd, connection))
                {
                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            reader.Read();
                            if (reader["ccv"].ToString() == ccv && reader["pin"].ToString() == pin)
                            {
                                var card = new Card(
                                reader.GetInt32(0),
                                user.id,
                                reader["number"].ToString(),
                                reader["pin"].ToString(),
                                reader["ccv"].ToString(),
                                reader["created_on"].ToString(),
                                reader.GetInt32(6));
                                cards.Add(card);
                                ok = true;
                                id = card.card_id;
                            }
                        }
                        else ok = false;
                    }
                }

                if (ok == true)
                {
                    sqlcmd = $"UPDATE card SET user_id = {user.id} WHERE card_id = {id}";
                    using(var cmd = new NpgsqlCommand(sqlcmd, connection))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            return ok;
        }
        public static void RemoveCard(RemoveCardForm form, int index)
        {
            {
                var sqlcmd = $"UPDATE card SET user_id = 0 WHERE card_id = {form.card.card_id}";
                using (var cmd = new NpgsqlCommand(sqlcmd, connection))
                {
                    cmd.ExecuteNonQuery();
                }
            }
            cards.RemoveAt(index);
        }

        public static void UpdateCardBalance(int card_id)
        {
            SelectedCard.balance -= TransferAmountForm.AmountToTransfer;
            foreach(var card in cards)
            {
                if (card.card_id == card_id)
                    card.balance += TransferAmountForm.AmountToTransfer;
            }
        }
    }
}
