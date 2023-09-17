using MySql.Data.MySqlClient;
using System.Data;
using System;
using System.Configuration;

namespace AppQuinta
{
    class Banco
    {

        private readonly MySqlConnection conexao = new MySqlConnection(ConfigurationManager.ConnectionStrings["conexao"].ConnectionString);
        private readonly MySqlCommand cmd = new MySqlCommand();

        public void Open()
        {
            if (conexao.State == ConnectionState.Closed)
                conexao.Open();
        }

        public MySqlDataReader ExecuteReadSql(string strQuery)
        {
            cmd.CommandText = strQuery;
            cmd.Connection = conexao;
            MySqlDataReader Reader = cmd.ExecuteReader();
            return Reader;
        }

        public string ExecuteScalar(string strQuery)
        {
            cmd.CommandText = strQuery;
            cmd.Connection = conexao;
            string strRetorno = Convert.ToString(cmd.ExecuteScalar());
            return strRetorno;
        }

        public void ExecuteNowdSql(string strQuery)
        {
            cmd.CommandText = strQuery;
            cmd.Connection = conexao;
            cmd.ExecuteNonQuery();
        }

        public void Close()
        {
            if (conexao.State == ConnectionState.Open)
                conexao.Close();
        }
    }
}
