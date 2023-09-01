﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace AppBanco
{
    internal class Banco
    {
        private readonly MySqlConnection conexao = new MySqlConnection(@"Server = Localhost; database = dbAppBanco; user = root; password = 12345678");
        private readonly MySqlCommand cmd = new MySqlCommand();

        public void Open(){
            if (conexao.State == System.Data.ConnectionState.Closed)
                conexao.Open();
        }
        public void Close()
        {
            if (conexao.State == System.Data.ConnectionState.Open)
                conexao.Close();

        }
        public MySqlDataReader ExecuteReadSql(string strQuery)
        {
            cmd.CommandText = strQuery;
            cmd.Connection = conexao;
            MySqlDataReader Leitor = cmd.ExecuteReader();
            return Leitor;
        }
}
}

