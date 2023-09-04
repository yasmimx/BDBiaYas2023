using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBanco
{
    internal class UsuarioDAO
    {
        Banco db = new Banco();

        public void Insert(string strNomeUsu, string strCargo, string strDataNasc)
        {
            string strInsert = string.Format("insert into tbUsuario(NomeUsu,Cargo,DataNasc)" +
                "values('{0}', '{1}', STR_TO_DATE('{2}', '%d/%m/%Y'))", strNomeUsu, strCargo, strDataNasc);
            db.Open();
            db.ExecuteNowdSql(strInsert);
            db.Close();
        }

        public void Update(string strIdUsu, string strNomeUsu, string strCargo, string strDataNasc)
        {
            string strUpdate = string.Format("update tbUsuario set NomeUsu = '{0}',Cargo = '{1}',DataNasc = STR_TO_DATE('{2}', '%d/%m/%Y' %H:%i:%s') " +
                "where IdUsu = {3};", strNomeUsu, strCargo, strDataNasc);
            db.Open();
            db.ExecuteNowdSql(strUpdate);
            db.Close();
        }

        public void Delete(string strIdUsu, string strNomeUsu, string strCargo, string strDataNasc)
        {
            string strDelete = string.Format("delete from tbUsuario where IdUsu = {0};", strIdUsu);
            db.Open();
            db.ExecuteNowdSql(strDelete);
            db.Close();
        }

        public void SelectDado(string strIdUsu, string strNomeUsu, string strCargo, string strDataNasc)
        {
            string strDado =  "selec NomeUsu from tbUsuario where IdUsu = " + strIdUsu + ";";
            db.Open();
            db.ExecuteNowdSql(strDado);
            db.Close();
        }
    }
}
