using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;


namespace Unijobs
{
    class ClassConect 
    {
        private readonly MySqlConnection conecxao;
        string conectaBanco = "SERVER=localhost; DATABASE=test; UID=root; PWD=";

        MySqlConnection conexao = null;
        MySqlCommand comando;

        public DataTable ExibirDados()
        {
            try
            {
                MySqlCommand command = new MySqlCommand("INSERT INTO `testandoconexao`(`nome`, `CPF`,'celular','email') VALUES (@nome,@cpf,@celular,@email)", conecxao);
                conexao = new MySqlConnection(conectaBanco);
                comando = new MySqlCommand("SELECT * FROM testandoconexao", conexao);

                MySqlDataAdapter Da = new MySqlDataAdapter();
                Da.SelectCommand = comando;

                DataTable DT = new DataTable();

                Da.Fill(DT);
                return DT;

            }
            catch (Exception erro)
            {
                throw erro;
            }


        }





    }
  

}

