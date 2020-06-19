using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unijobs.modal;
using Unijobs.bll;
using System.Drawing.Text;
using Unijobs.Dao;


namespace Unijobs
{
    public partial class Menu : Form
    {
        private object txtEmail;

        public Menu()
        {
            InitializeComponent();
        }

        private void btnExibir_Click(object sender, EventArgs e)
        {
            ClassBLL bll = new ClassBLL();

            try
            {
                dgDados.DataSource = bll.ExibirDadosdal();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao Exibir dados" + erro);
            }

        }

        private void babaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadstro Cad = new Cadstro();
            Cad.Show();
        }

        private void domesticaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadstro Cad = new Cadstro();
            Cad.Show();
        }

        private void outrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadstro Cad = new Cadstro();
            Cad.Show();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {

        }

        private void dgDados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Menu_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.FixedDialog;

            
        }

        

        public void excluir(Candidato candidato, object txtCpf)
        {
            CandidatoBLL candidatoBLL = new CandidatoBLL();

           //candidato.cpf = txtCpf.Text;

            candidatoBLL.excluir(candidato);

            MessageBox.Show("Pessoa Excluida !");

        }
        
        public void btnExcluir_Click(object sender, EventArgs e)
        {
            Candidato candidato = new Candidato();
            //Excluir(candidato);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {                               
            ClassBLL bll = new ClassBLL();

            try
            {
                dgDados.DataSource = bll.ExibirDadosdal();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao Exibir dados" + erro);
            }
        }

        private void dgDados_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
        }
    }
}
