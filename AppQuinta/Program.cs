//using MySql.Data.MySqlClient;
using System;

namespace AppQuinta
{

    class Program

    {
        static void Main(string[] args)

        {

          //  Banco db = new Banco();
            UsuarioDao ObjDao = new UsuarioDao();


          //  db.Open();



            Console.WriteLine("Informe o Id para identificação: ");
            string IdUsu = Console.ReadLine();
           //string strSelectId = "SELECT NomeUsu FROM tbusuario Where IdUsu=" + IdUsu + ";";
            string strDado = ObjDao.SelectDado(IdUsu);
            Console.WriteLine("Ola senhor(a)" + strDado);

            Console.WriteLine("Digite o Nome: ");

            string strNomeUsu = Console.ReadLine();
            Console.WriteLine("Digite o Cargo: ");
            string strCargo = Console.ReadLine();

            Console.WriteLine("Digite a data de nascimento:");
            string strDataNasc = Console.ReadLine();

             ObjDao.Insert(strNomeUsu, strCargo, strDataNasc);


            //  db.Close();
            Console.ReadLine();


        ObjDao.Select();
          



            Console.ReadLine();


            //string strInsert = string.Format("insert into tbUsuario(NomeUsu, Cargo, dataNasc)" + "values('{0}','{1}', STR_TO_DATE('{2}', '%d/%m/%Y'));", strNomeUsu, strCargo, strDataNasc);

            //     db.ExecuteNowdSql(strInsert);
            //    string strDelete = "delete from tbusuario where idUsu=3; ";

            //    db.ExecuteNowdSql(strDelete);
            ////    string strUpdate = "update tbusuario set nomeusu = 'João' where IdUsu = 1;";

            //    ObjDao.Insert(strNomeUsu, strCargo, strDataNasc);
            //    string strUpdate = "update tbusuario set nomeusu = 'João' where IdUsu = 1;";

            //    db.ExecuteNowdSql(strUpdate);

            // string strSelect = "SELECT * FROM tbUsuario;";

            //    MySqlDataReader reader = db.ExecuteReadSql(strSelect);

            //    while (reader.Read())
            //    {

            //        Console.WriteLine("Código = {0} |   Nome = {1}  | Cargo = {2}   | Nascimento = {3}",

            //            reader["IdUsu"], reader["NomeUsu"], reader["Cargo"], reader["DataNasc"]);

            //    }
            //   reader.Close();


            //    Console.WriteLine("Informe o Id para identificação: ");
            //    string IdUsu = Console.ReadLine();
            //    string strSelectId = "SELECT NomeUsu FROM tbusuario Where IdUsu=" + IdUsu + ";";
            //    string strDado = db.ExecuteScalar(strSelectId);
            //    Console.WriteLine("Ola senhor(a)" + strDado);

            //    db.Close();
            //    Console.ReadLine();

            //    //Console.WriteLine("Banco conectado!");

        }

    }

}
