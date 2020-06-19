using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Unijobs.bll;
using Unijobs.modal;


namespace Unijobs.Dao
{
    public class CandidatoDAO : ClassConecxao
    {
        MySqlCommand command = null;
        public void Salvar(Candidato candidato)
        {
            try
            {
                AbrirConecxao();
                command = new MySqlCommand("INSERT INTO `testandoconexao`(nome,CPF,celular,email) VALUES(@nome,@cpf,@celular,@email)", conecxao);
                //command = new MySqlCommand("INSERT INTO `testandoconexao`(`nome`, `CPF', `datadenascimento`, 'estadocivil', 'telefone', 'email', 'celular', 'cep', 'rua', 'bairro', 'cidade', 'filhos', 'fumante', 'escolaridade', 'pretensaosalarial', 'estado',) VALUES(@nome, @CPF, @datadenascimento, @estadocivil, @telefone, @email, @celular, @cep, @rua, @bairro, @cidade, @filhos, @fumante, @escolaridade, @pretensaosalarial, @estado,)", conecxao);
                command.Parameters.AddWithValue("@nome", candidato.nome);
                command.Parameters.AddWithValue("@CPF", candidato.cpf);
                command.Parameters.AddWithValue("@datadenascimento", candidato.datadenascimento);
                command.Parameters.AddWithValue("@estadocivil", candidato.estadocivil);
                command.Parameters.AddWithValue("@telefone", candidato.telefone);
                command.Parameters.AddWithValue("@email", candidato.email);
                command.Parameters.AddWithValue("@celular", candidato.celular);
                command.Parameters.AddWithValue("@cep", candidato.cep);
                command.Parameters.AddWithValue("@rua", candidato.rua);
                command.Parameters.AddWithValue("@bairro", candidato.bairro);
                command.Parameters.AddWithValue("@cidade", candidato.cidade);
                command.Parameters.AddWithValue("@filhos", candidato.filhos);
                command.Parameters.AddWithValue("@fumante", candidato.fumante);
                command.Parameters.AddWithValue("@escolaridade", candidato.escolaridade);
                command.Parameters.AddWithValue("@pretensaosalarial", candidato.pretensaosalarial);
                command.Parameters.AddWithValue("@estado", candidato.estado);

                command.ExecuteNonQuery();
            }

            catch (Exception erro)
            {
                throw erro;
            }

            finally
            {
                FecharConecxao();
            }
        }

        //EXCLUIR
        public void excluir(Candidato candidato)
        {
            try
            {
                AbrirConecxao();
                command = new MySqlCommand("DELETE FROM testandoconexao WHERE cpf = @cpf", conecxao);

                command.Parameters.AddWithValue("@cpf", candidato.cpf);

                command.ExecuteNonQuery();
            }
            catch (Exception erro)
            {

                throw erro;
            }

            finally
            {
                FecharConecxao();
            }

        }



        private DataTable listar()
        {

            try
            {
                AbrirConecxao();


                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter();

                command = new MySqlCommand("SELECT * FROM testandoconecxao ORDER BY nome", conecxao);

                da.SelectCommand = command;

                da.Fill(dt);

                return dt;
            }

            catch (Exception erro)
            {
                throw erro;
            }

            finally
            {
                FecharConecxao();
            }

            

        }

       


    }

}
   
