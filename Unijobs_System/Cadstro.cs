using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unijobs.bll;
using Unijobs.modal;
using Unijobs.Dao;
using Unijobs.Properties;
namespace Unijobs
{
    public partial class Cadstro : Form
    {
        public Cadstro()
        {
            InitializeComponent();
            
        }

        private void lblEstCivil_Click(object sender, EventArgs e)
        {

        }

        private void cbxEstCivil_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblEscol_Click(object sender, EventArgs e)
        {

        }

        private void Cadstro_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.FixedDialog;
            
        }

        private void salvar(Candidato candidato)
        {
            CandidatoBLL candidatoBLL = new CandidatoBLL();

            candidato.nome = txtNome.Text;
            candidato.cpf = txtCpf.Text;
            candidato.datadenascimento = mskData.Text;
            candidato.estadocivil = cbxEstCivil.Text;
            candidato.telefone = mskTel.Text;
            candidato.email = txtEmail.Text;
            candidato.celular = mskCel.Text;
            candidato.cep = mskCep.Text;
            candidato.rua = txtRua.Text;
            candidato.bairro = txtBairro.Text;
            candidato.cidade = cbCidade.Text;
            candidato.filhos = cbxFilhos.Text;
            candidato.fumante = cbxFum.Text;
            candidato.escolaridade = cbxEsc.Text;
            candidato.pretensaosalarial= txtPretSal.Text;
            candidato.estado = cbUf.Text;

            candidatoBLL.salvar(candidato);

            MessageBox.Show("Candidato Salvo com Sucesso!");

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Candidato candidato = new Candidato();

            salvar(candidato);
        }


        //listar pessoas do DB
        private void listar()
        {
            CandidatoBLL candidatoBLL = new CandidatoBLL();

            //dgDados.DataSource = candidatoBLL.listar();
            
        }
        
        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {




        }

        private void txtCpf_TextChanged(object sender, EventArgs e)
        {

        }
    }
}




