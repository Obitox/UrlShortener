using System;
using System.Threading.Tasks;
using Domain.Model;
using Domain.Repository;
using MySqlConnector;

namespace DAL.MySQL.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly MySqlConnection _mySqlConnection;

        public UserRepository(MySqlConnection mySqlConnection)
        {
            if (mySqlConnection == null)
                throw new NotImplementedException("MySQL connection failed to initialize");
            
            _mySqlConnection = mySqlConnection;
        }

        public async Task<User> GetUserByUsername(string username)
        {
            using var connection = _mySqlConnection;
            
            await connection.OpenAsync();

            string sql = "SELECT * FROM user WHERE Username=@Username";
            using var command = new MySqlCommand(sql, connection);
            command.Parameters.AddWithValue("@Username", username);
            
            using var reader = await command.ExecuteReaderAsync();
            var user = new User();
            while (await reader.ReadAsync())
            {
                // var value = reader.GetValue(0);
                user.UserId = reader.GetInt64(0);
                user.FirstName = reader.GetString(1);
                user.LastName = reader.GetString(2);
                user.Password = reader.GetString(3);
                user.Username = reader.GetString(4);
            }

            return user;
        }
    }
}