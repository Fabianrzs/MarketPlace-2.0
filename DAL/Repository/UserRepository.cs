using DAL.Interface;
using Entity;
using Entity.enums;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Base
{
    public class UserRepository: IUserRepository
    {
        private readonly SqlConnection _connection;
        public UserRepository(IConnectionManager connectionManager)
        {
            _connection = (SqlConnection)connectionManager.Connection;
        }

        public User GetUser(string userName)
        {
            using (var command = _connection.CreateCommand())
            {
                command.Parameters.Add("@UserName", SqlDbType.VarChar).Value = userName;
                command.Parameters.Add("@State", SqlDbType.Int).Value = (int)EntitiesState.ACTIVE;

                command.CommandText = "SELECT Id, UserName, Password, Role, State " +
                    "FROM Users WHERE UserName = @UserName AND State = @State";
                var dataReader = command.ExecuteReader();
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        return MappingUsers(dataReader);
                    }
                }
            }
            throw new Exception("Usuario no encontrado");
        }

        public ICollection<User> GetUsers()
        {
            var users = new List<User>();

            using (var command = _connection.CreateCommand())
            {
                command.Parameters.Add("@State", SqlDbType.Int).Value = (int)EntitiesState.ACTIVE;

                command.CommandText = "SELECT Id, UserName, Password, Role, State FROM Users WHERE State = @State;";
                var dataReader = command.ExecuteReader();
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        users.Add(MappingUsers(dataReader));
                    }
                }
            }
            return users;
        }

        public bool IsActive(string userName)
        {
            using (var command = _connection.CreateCommand())
            {
                command.Parameters.Add("@State", SqlDbType.Int).Value = (int)EntitiesState.ACTIVE;

                command.CommandText = "SELECT Id, UserName, Password, Role, State " +
                    "FROM Users WHERE State = @State";
                var dataReader = command.ExecuteReader();
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        return MappingUsers(dataReader) == null ? false : true;
                    }
                }
            }

            throw new Exception("Usuario no activo");
        }

        public User Login(string userName, string password)
        {
            using (var command = _connection.CreateCommand())
            {
                command.Parameters.Add("@UserName", SqlDbType.VarChar).Value = userName;
                command.Parameters.Add("@Password", SqlDbType.VarChar).Value = password;
                command.Parameters.Add("@State", SqlDbType.Int).Value = (int)EntitiesState.ACTIVE;

                command.CommandText = "SELECT Id, UserName, Password, Role, State " +
                    "FROM Users WHERE UserName = @UserName AND Password = @Password AND State = @State";
                var dataReader = command.ExecuteReader();
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        return MappingUsers(dataReader);
                    }
                }
            }
            throw new Exception("Credenciales incorrectas");
        }

        public int Register(User users)
        {
            using (var command = _connection.CreateCommand())
            {

                command.CommandText = "INSERT INTO Users (UserName, Password, Role, State)" +
                    " Values (@UserName, @Password, @Role, @State)";

                command.Parameters.Add("@UserName", SqlDbType.VarChar).Value = users.UserName;
                command.Parameters.Add("@Password", SqlDbType.VarChar).Value = users.Password;
                command.Parameters.Add("@Role", SqlDbType.Int).Value = users.Role;
                command.Parameters.Add("@State", SqlDbType.Int).Value = users.State;

                return command.ExecuteNonQuery();
            }
        }

        private User MappingUsers(SqlDataReader dataReader)
        {
            if (!dataReader.HasRows) throw new Exception("No se pudo realizar la consulta"); ;
            var user = new User()
            {
                UniqueID = (int)dataReader["Id"],
                Password = (string)dataReader["Password"],
                Role = (int)dataReader["Role"],
                UserName = (string)dataReader["UserName"],
                State = (int)dataReader["State"],
            };

            return user;
        }
    }
}
