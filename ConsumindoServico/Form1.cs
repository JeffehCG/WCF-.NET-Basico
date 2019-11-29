using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConsumindoServico.ServiceReference1;

namespace ConsumindoServico
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            string cpf = txtCpf.Text;

            try
            {
                //Efetuando cadastro pelo serviço
                Cliente clienteCadastro = new Cliente();
                clienteCadastro.Nome = nome;
                clienteCadastro.Cpf = cpf;

                ClienteServiceClient servico = new ClienteServiceClient();
                servico.Add(clienteCadastro);

                MessageBox.Show("Cliente cadastrado com sucesso");
            }
            catch (Exception ex)
            {
                //Salvaria um log
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;

            try
            {
                //Buscando dado
                ClienteServiceClient servico = new ClienteServiceClient();
                Cliente resultado = servico.Buscar(nome);

                txtCpf.Text = resultado.Cpf;
            }
            catch (Exception ex)
            {
                //Salvaria um log
            }
        }
    }
}
