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

namespace CadastroDeFuncionarios
{
    public partial class Form1 : MaterialForm
    {
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
        /// Método de clique do botão cadastrar funcionario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Funcionario funcionarioClass = new Funcionario();
        }
    }
}
