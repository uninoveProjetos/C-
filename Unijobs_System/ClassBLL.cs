using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace Unijobs
{
    class ClassBLL
    {
        ClassConect dal = null;
        public DataTable ExibirDadosdal()
        {

            try
            {
                DataTable DataT = new DataTable();
                dal = new ClassConect();

                DataT = dal.ExibirDados();
                return DataT;
            }

            catch (Exception erro)
            {
                throw erro;
            }



        }

    }
}
