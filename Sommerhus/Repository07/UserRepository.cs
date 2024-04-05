using Sommerhus.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sommerhus.Repository07
{
    public class UserRepository
    {


        public User Add(User user)
        {
            SqlConnection connection = new SqlConnection(Secret.GetConnectionString);
            connection.Open();

            string insertSql = "INSERT INTO User (Name, Mobile, Team, Price) VALUES (@Name, @Mobile, @Team, @Price)";

            SqlCommand cmd = new SqlCommand(insertSql, connection);
            cmd.Parameters.AddWithValue("@Name", user.Name);
            cmd.Parameters.AddWithValue("@Mobile", user.Mobile);
            cmd.Parameters.AddWithValue("@Team", user.Team);
            cmd.Parameters.AddWithValue("@Price", user.Price);

            int rowsAffected = cmd.ExecuteNonQuery();
            Console.WriteLine("Rows affected: " + rowsAffected);

            connection.Close();
            return user;
        }


        public User Delete(int id)
        {
            SqlConnection connection = new SqlConnection(Secret.GetConnectionString);
            connection.Open();

            string deleteSql = "DELETE FROM User WHERE Id = @Id";

            SqlCommand cmd = new SqlCommand(deleteSql, connection);
            cmd.Parameters.AddWithValue("@Id", id);

            int rowsAffected = cmd.ExecuteNonQuery();
            Console.WriteLine("Rows affected: " + rowsAffected);

            connection.Close();


            return null;
        }



        public List<User> GetAll()
        {
            List<User> list = new List<User>();

            SqlConnection connection = new SqlConnection(Secret.GetConnectionString);
            connection.Open();

            string sql = "SELECT * FROM User";
            SqlCommand cmd = new SqlCommand(sql, connection);

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                User user = ReadUser(reader);
                list.Add(user);
            }


            connection.Close();
            return list;


        }

        private User ReadUser(SqlDataReader reader)
        {
            User user = new User();

            user.Id = reader.GetInt32(0);
            user.Name = reader.GetString(1);
            user.Mobile = reader.GetString(2);
            user.Team = reader.GetString(3);

            user.Price = reader.GetDecimal(4);

            return user;
        }



        public User GetById(int id)
        {
            SqlConnection connection = new SqlConnection(Secret.GetConnectionString);
            connection.Open();

            string selectSql = "SELECT * FROM User WHERE Id = @Id";

            SqlCommand cmd = new SqlCommand(selectSql, connection);
            cmd.Parameters.AddWithValue("@Id", id);

            SqlDataReader reader = cmd.ExecuteReader();

            User user = null;

            if (reader.Read())
            {
                user = new User
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    Name = reader["Name"].ToString(),
                    Mobile = reader["Mobile"].ToString(),
                    Team = reader["Team"].ToString(),
                    Price = Convert.ToDouble(reader["Price"])
                };
            }

            reader.Close();
            connection.Close();

            return user;
        }


        public User Update(int id, User user)
        {
            SqlConnection connection = new SqlConnection(Secret.GetConnectionString);
            connection.Open();

            string updateSql = "UPDATE User SET Name = @Name, Mobile = @Mobile, Team = @Team, Price = @Price WHERE Id = @Id";

            SqlCommand cmd = new SqlCommand(updateSql, connection);
            cmd.Parameters.AddWithValue("@FirstName", user.FirstName);
            cmd.Parameters.AddWithValue("@LastName", user.LastName);
            cmd.Parameters.AddWithValue("@Phone", user.Phone);
            cmd.Parameters.AddWithValue("@Email", user.Email);
            cmd.Parameters.AddWithValue("@Password", user.Password);
            cmd.Parameters.AddWithValue("@StreetName", user.StreetName);
            cmd.Parameters.AddWithValue("@HouseNumber", user.HouseNumber);
            cmd.Parameters.AddWithValue("@Floor", user.Floor);
            cmd.Parameters.AddWithValue("@City", user.City);
            cmd.Parameters.AddWithValue("@Postalcode", user.PostalCode);
            cmd.Parameters.AddWithValue("@Floor", user.Floor);
            cmd.Parameters.AddWithValue("@IsLandlord", user.IsLandlord);
            cmd.Parameters.AddWithValue("@Id", id);

            int rowsAffected = cmd.ExecuteNonQuery();
            Console.WriteLine("Rows affected: " + rowsAffected);

            connection.Close();

            if (rowsAffected > 0)
            {
                return GetById(id);
            }
            return null;
        }
    }
}
