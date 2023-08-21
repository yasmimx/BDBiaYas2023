using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AppBanco
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MySqlConnection Conexao = new MySqlConnection(@"Server = Localhost;database = dbAppBanco;user = root;password = 12345678");
            Conexao.Open();

            string strInsert = "insert into tbusuario(NomeUsu, Cargo, DataNasc) values ('Yasmim', 'Aluno', '2005/08/05')";
            MySqlCommand ObjCommandI = new MySqlCommand(strInsert, Conexao);
            ObjCommandI.ExecuteNonQuery();

            string strUpdate = "update from tbusuario set";
            MySqlCommand ObjCommandUp = new MySqlCommand(strUpdate, Conexao);
            ObjCommandUp.ExecuteNonQuery();

            

            

            string strSelect = "SELECT * FROM tbusuario;";
            MySqlCommand ObjCommandS = new MySqlCommand(strSelect, Conexao);


            MySqlDataReader leitor = ObjCommandI.ExecuteReader();

            while (leitor.Read())
            {
                Console.WriteLine("Código = {0} | Nome = {1}  | Cargo = {2}  | Nascimento = {3}",
                                   leitor["IdUsu"], leitor["NomeUsu"], leitor["Cargo"], leitor["DataNasc"]);
            }
            leitor.Close();


            Console.ReadLine();
        }
    }
}
 