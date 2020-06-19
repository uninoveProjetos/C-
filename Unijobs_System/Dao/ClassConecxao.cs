using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Unijobs
{
    public class ClassConecxao
    {

        string conecta = "SERVER=localhost; DATABASE=test; UID=root; PWD=";

        protected MySqlConnection conecxao = null;
        

        //Metodo para conectar no DB
        public void AbrirConecxao()
        {
            try
            {
                conecxao = new MySqlConnection(conecta);
                conecxao.Open();
            }
            catch (Exception erro)
            {
                throw erro;
            }
            
        }

        //Metodo para fechar conecxao com DB

        public void FecharConecxao()
        {

            try
            {
                conecxao = new MySqlConnection(conecta);
                conecxao.Close();
            }

            catch (Exception erro)
            {
                throw erro;
            }

            
        
        }


    }
}
