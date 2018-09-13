using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MtWebApi.Model;
using Pomelo.Data.MySql;

namespace MtWebApi.Connector
{

    public class Conn
    {
        private string connstring;
        public Conn()
        {
            connstring = @"server=localhost;userid=root;password=pdaodq;database=Hospital"; //Connection string burada
        }

        public List<User> UserList()
        {

            List<User> allUser = new List<User>();


            using (MySqlConnection connMysql = new MySqlConnection(connstring))
            {

                using (MySqlCommand cmdd = connMysql.CreateCommand())
                {


                    cmdd.CommandText = "Select * from userlist"; //Dönmesini istediğimiz veriler için Sql sorgumuzu buraya yazıyoruz.
                    cmdd.CommandType = System.Data.CommandType.Text;

                    cmdd.Connection = connMysql;

                    connMysql.Open();

                    using (MySqlDataReader reader = cmdd.ExecuteReader())
                    {

                        while (reader.Read())
                        {
                            allUser.Add(new User
                            {
                                id = reader.GetInt32(reader.GetOrdinal("id")) //veritabanından hangi alanları çekeceksek bu alanları ayarlıyoruz
                                                                        ,
                                name = reader.GetString(reader.GetOrdinal("name"))
                                                                       ,
                                pass = reader.GetString(reader.GetOrdinal("pass"))
                            });
                        }
                    }
                }

                connMysql.Close();
            }



            return allUser;
        }
    }
}
