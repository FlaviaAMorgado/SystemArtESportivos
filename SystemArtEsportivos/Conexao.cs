using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace SystemArtEsportivos
{
    internal class Conexao
    {
            MySqlConnection con = new MySqlConnection("Server=localhost;Database=dbEsportes;User ID=root;Password=12345678;SslMode=none;");
            public static string msg;

            public MySqlConnection ConnectarBD()
            {
                try
                {
                    con.Open();

                }
                catch (Exception erro)
                {

                    msg = "Ocorreu um erro ao se conectar" + erro.Message;
                }
                return con;
            }

            public MySqlConnection DesConnectarBD()
            {
                try
                {
                    con.Close();

                }
                catch (Exception erro)
                {

                    msg = "Ocorreu um erro ao se conectar" + erro.Message;
                }
                return con;
            }

        }
    }

