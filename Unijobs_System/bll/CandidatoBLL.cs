using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unijobs.modal;
using Unijobs.Dao;
using System.Data;

namespace Unijobs.bll
{
    public class CandidatoBLL
    {
        //Salvar
        CandidatoDAO candidatoDAO = new CandidatoDAO();

        public void salvar(Candidato candidato)
        {
            try
            {
                candidatoDAO.Salvar(candidato);
            }
            catch (Exception erro)
            {
                throw erro;
            }

        }

        //listar
        private DataTable listar()
        {

            try
            {
                DataTable dt = new DataTable();

                //dt = candidatoDAO.listar();


                return dt;
                     
            }
            catch (Exception erro)
            {
                throw erro;
            }
            
        }

        // metodo exclusao
        public void excluir(Candidato candidato)
        {
            try
            {
                candidatoDAO.excluir(candidato);
            }
            catch (Exception erro)
            {

                throw erro;
            }


        }
       
    }
}
