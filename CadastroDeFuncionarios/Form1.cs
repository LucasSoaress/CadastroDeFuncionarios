using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MaterialSkin;
using System.Diagnostics;

namespace CadastroDeFuncionarios
{
    public partial class Form1 : MaterialForm 
    {

        /// <summary>
        /// Método de carregamento, utilizando a Framework MaterialSkin e assim passando alguns parametros para customização do Form
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            var skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.DARK;
            skinManager.ColorScheme = new ColorScheme(Primary.Grey900, Primary.Grey700, Primary.Indigo100, Accent.Amber700, TextShade.WHITE);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        /// <summary>
        /// Método para não aceitar letras
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void inputNumeroEndereco_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                 (e.KeyChar != ',' && e.KeyChar != '-'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Método de clique do botão cadastrar funcionario, passando os dados do funcionário por parametro para o construtor da classe Funcionário
        /// para que eles sejam manipulados na classe Funcionario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (inputNomeFuncionario.Text == "" | inputEmail.Text == "")
            {
                MessageBox.Show("Coloque pelo menos nome e email");
            }
            else
            {
                try
                {
                    Funcionario f = new Funcionario(inputNomeFuncionario.Text, inputTelefone.Text, inputTelefoneEmergencia.Text, inputProfissao.Text, inputEmail.Text, inputSalario.Text, inputEndereco.Text, inputNumeroEndereco.Text);
                    MessageBox.Show("Cadastro realizado com sucesso");
                    f.fazerCadastro();
                }
                catch (Exception)
                {
                    MessageBox.Show("Houve um erro na hora de fazer o cadastro do funcionário", "Teste");
                }
            }
        }

        /// <summary>
        /// Método do evento de clique no botão para abrir o arquivo txt
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAbrirArquivo_Click(object sender, EventArgs e)
        {
            Process.Start("dados.txt");
        }

        /// <summary>
        /// Método do clique do botão para mostrar todos os funcionários
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMostrarFuncionarios_Click(object sender, EventArgs e)
        {
            List<Funcionario> funcionarios = Funcionario.exibirDadosDoFuncionario();
            foreach(Funcionario funcionario in funcionarios)
            {
                try
                {
                    inputNomeFuncionario.Text = funcionario.Nome;
                    inputNumeroEndereco.Text = funcionario.NumeroEndereco;
                    inputProfissao.Text = funcionario.Profissao;
                    inputEmail.Text = funcionario.Email;
                    inputTelefone.Text = funcionario.TelefoneNormal;
                    inputTelefoneEmergencia.Text = funcionario.TelefoneEmergencia;
                    inputSalario.Text = funcionario.Salario;
                }
                catch(Exception)
                {
                    MessageBox.Show("Ocorreu um problema para exibir o funcionario");
                } 
            }
        }
    }
}
