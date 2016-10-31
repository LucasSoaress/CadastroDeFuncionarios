namespace CadastroDeFuncionarios
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.inputNomeFuncionario = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.inputEndereco = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnCadastrar = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnAbrirArquivo = new MaterialSkin.Controls.MaterialFlatButton();
            this.inputEmail = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.inputProfissao = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.inputSalario = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.inputTelefone = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.inputTelefoneEmergencia = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.inputNumeroEndereco = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnMostrarFuncionarios = new MaterialSkin.Controls.MaterialFlatButton();
            this.SuspendLayout();
            // 
            // inputNomeFuncionario
            // 
            this.inputNomeFuncionario.BackColor = System.Drawing.Color.White;
            this.inputNomeFuncionario.Depth = 0;
            this.inputNomeFuncionario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.inputNomeFuncionario.Hint = "Nome funcionário";
            this.inputNomeFuncionario.Location = new System.Drawing.Point(12, 124);
            this.inputNomeFuncionario.MouseState = MaterialSkin.MouseState.HOVER;
            this.inputNomeFuncionario.Name = "inputNomeFuncionario";
            this.inputNomeFuncionario.PasswordChar = '\0';
            this.inputNomeFuncionario.SelectedText = "";
            this.inputNomeFuncionario.SelectionLength = 0;
            this.inputNomeFuncionario.SelectionStart = 0;
            this.inputNomeFuncionario.Size = new System.Drawing.Size(373, 23);
            this.inputNomeFuncionario.TabIndex = 6;
            this.inputNomeFuncionario.UseSystemPasswordChar = false;
            // 
            // inputEndereco
            // 
            this.inputEndereco.BackColor = System.Drawing.Color.White;
            this.inputEndereco.Depth = 0;
            this.inputEndereco.Hint = "Digite o endereço";
            this.inputEndereco.Location = new System.Drawing.Point(12, 160);
            this.inputEndereco.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.inputEndereco.MouseState = MaterialSkin.MouseState.HOVER;
            this.inputEndereco.Name = "inputEndereco";
            this.inputEndereco.PasswordChar = '\0';
            this.inputEndereco.SelectedText = "";
            this.inputEndereco.SelectionLength = 0;
            this.inputEndereco.SelectionStart = 0;
            this.inputEndereco.Size = new System.Drawing.Size(244, 23);
            this.inputEndereco.TabIndex = 7;
            this.inputEndereco.UseSystemPasswordChar = false;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCadastrar.AutoSize = true;
            this.btnCadastrar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCadastrar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnCadastrar.Depth = 0;
            this.btnCadastrar.Location = new System.Drawing.Point(764, 325);
            this.btnCadastrar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCadastrar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Primary = false;
            this.btnCadastrar.Size = new System.Drawing.Size(91, 36);
            this.btnCadastrar.TabIndex = 1;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnAbrirArquivo
            // 
            this.btnAbrirArquivo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAbrirArquivo.AutoSize = true;
            this.btnAbrirArquivo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAbrirArquivo.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnAbrirArquivo.Depth = 0;
            this.btnAbrirArquivo.Location = new System.Drawing.Point(643, 325);
            this.btnAbrirArquivo.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAbrirArquivo.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAbrirArquivo.Name = "btnAbrirArquivo";
            this.btnAbrirArquivo.Primary = false;
            this.btnAbrirArquivo.Size = new System.Drawing.Size(113, 36);
            this.btnAbrirArquivo.TabIndex = 3;
            this.btnAbrirArquivo.Text = "ABRIR ARQUIVO";
            this.btnAbrirArquivo.UseVisualStyleBackColor = false;
            this.btnAbrirArquivo.Click += new System.EventHandler(this.btnAbrirArquivo_Click);
            // 
            // inputEmail
            // 
            this.inputEmail.BackColor = System.Drawing.Color.White;
            this.inputEmail.Depth = 0;
            this.inputEmail.Hint = "Digite o e-mail";
            this.inputEmail.Location = new System.Drawing.Point(12, 196);
            this.inputEmail.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.inputEmail.MouseState = MaterialSkin.MouseState.HOVER;
            this.inputEmail.Name = "inputEmail";
            this.inputEmail.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.inputEmail.PasswordChar = '\0';
            this.inputEmail.SelectedText = "";
            this.inputEmail.SelectionLength = 0;
            this.inputEmail.SelectionStart = 0;
            this.inputEmail.Size = new System.Drawing.Size(373, 23);
            this.inputEmail.TabIndex = 16;
            this.inputEmail.UseSystemPasswordChar = false;
            // 
            // inputProfissao
            // 
            this.inputProfissao.BackColor = System.Drawing.Color.White;
            this.inputProfissao.Depth = 0;
            this.inputProfissao.Hint = "Profissão";
            this.inputProfissao.Location = new System.Drawing.Point(12, 232);
            this.inputProfissao.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.inputProfissao.MouseState = MaterialSkin.MouseState.HOVER;
            this.inputProfissao.Name = "inputProfissao";
            this.inputProfissao.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.inputProfissao.PasswordChar = '\0';
            this.inputProfissao.SelectedText = "";
            this.inputProfissao.SelectionLength = 0;
            this.inputProfissao.SelectionStart = 0;
            this.inputProfissao.Size = new System.Drawing.Size(181, 23);
            this.inputProfissao.TabIndex = 17;
            this.inputProfissao.UseSystemPasswordChar = false;
            // 
            // inputSalario
            // 
            this.inputSalario.BackColor = System.Drawing.Color.White;
            this.inputSalario.Depth = 0;
            this.inputSalario.Hint = "Salário";
            this.inputSalario.Location = new System.Drawing.Point(273, 232);
            this.inputSalario.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.inputSalario.MouseState = MaterialSkin.MouseState.HOVER;
            this.inputSalario.Name = "inputSalario";
            this.inputSalario.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.inputSalario.PasswordChar = '\0';
            this.inputSalario.SelectedText = "";
            this.inputSalario.SelectionLength = 0;
            this.inputSalario.SelectionStart = 0;
            this.inputSalario.Size = new System.Drawing.Size(112, 23);
            this.inputSalario.TabIndex = 18;
            this.inputSalario.UseSystemPasswordChar = false;
            this.inputSalario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inputNumeroEndereco_KeyPress);
            // 
            // inputTelefone
            // 
            this.inputTelefone.BackColor = System.Drawing.Color.White;
            this.inputTelefone.Depth = 0;
            this.inputTelefone.Hint = "Digite o telefone";
            this.inputTelefone.Location = new System.Drawing.Point(12, 268);
            this.inputTelefone.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.inputTelefone.MouseState = MaterialSkin.MouseState.HOVER;
            this.inputTelefone.Name = "inputTelefone";
            this.inputTelefone.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.inputTelefone.PasswordChar = '\0';
            this.inputTelefone.SelectedText = "";
            this.inputTelefone.SelectionLength = 0;
            this.inputTelefone.SelectionStart = 0;
            this.inputTelefone.Size = new System.Drawing.Size(124, 23);
            this.inputTelefone.TabIndex = 19;
            this.inputTelefone.UseSystemPasswordChar = false;
            this.inputTelefone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inputNumeroEndereco_KeyPress);
            // 
            // inputTelefoneEmergencia
            // 
            this.inputTelefoneEmergencia.BackColor = System.Drawing.Color.White;
            this.inputTelefoneEmergencia.Depth = 0;
            this.inputTelefoneEmergencia.Hint = "Telefone Emergência";
            this.inputTelefoneEmergencia.Location = new System.Drawing.Point(235, 268);
            this.inputTelefoneEmergencia.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.inputTelefoneEmergencia.MouseState = MaterialSkin.MouseState.HOVER;
            this.inputTelefoneEmergencia.Name = "inputTelefoneEmergencia";
            this.inputTelefoneEmergencia.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.inputTelefoneEmergencia.PasswordChar = '\0';
            this.inputTelefoneEmergencia.SelectedText = "";
            this.inputTelefoneEmergencia.SelectionLength = 0;
            this.inputTelefoneEmergencia.SelectionStart = 0;
            this.inputTelefoneEmergencia.Size = new System.Drawing.Size(150, 23);
            this.inputTelefoneEmergencia.TabIndex = 23;
            this.inputTelefoneEmergencia.UseSystemPasswordChar = false;
            this.inputTelefoneEmergencia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inputNumeroEndereco_KeyPress);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(114, 82);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(177, 19);
            this.materialLabel2.TabIndex = 25;
            this.materialLabel2.Text = "Cadastre seu funcionário";
            // 
            // inputNumeroEndereco
            // 
            this.inputNumeroEndereco.BackColor = System.Drawing.Color.White;
            this.inputNumeroEndereco.Depth = 0;
            this.inputNumeroEndereco.Hint = "Número";
            this.inputNumeroEndereco.Location = new System.Drawing.Point(262, 160);
            this.inputNumeroEndereco.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.inputNumeroEndereco.MouseState = MaterialSkin.MouseState.HOVER;
            this.inputNumeroEndereco.Name = "inputNumeroEndereco";
            this.inputNumeroEndereco.PasswordChar = '\0';
            this.inputNumeroEndereco.SelectedText = "";
            this.inputNumeroEndereco.SelectionLength = 0;
            this.inputNumeroEndereco.SelectionStart = 0;
            this.inputNumeroEndereco.Size = new System.Drawing.Size(123, 23);
            this.inputNumeroEndereco.TabIndex = 26;
            this.inputNumeroEndereco.UseSystemPasswordChar = false;
            this.inputNumeroEndereco.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inputNumeroEndereco_KeyPress);
            // 
            // btnMostrarFuncionarios
            // 
            this.btnMostrarFuncionarios.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMostrarFuncionarios.AutoSize = true;
            this.btnMostrarFuncionarios.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnMostrarFuncionarios.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnMostrarFuncionarios.Depth = 0;
            this.btnMostrarFuncionarios.Location = new System.Drawing.Point(458, 325);
            this.btnMostrarFuncionarios.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnMostrarFuncionarios.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnMostrarFuncionarios.Name = "btnMostrarFuncionarios";
            this.btnMostrarFuncionarios.Primary = false;
            this.btnMostrarFuncionarios.Size = new System.Drawing.Size(177, 36);
            this.btnMostrarFuncionarios.TabIndex = 28;
            this.btnMostrarFuncionarios.Text = "MOSTRAR FUNCIONARIOS";
            this.btnMostrarFuncionarios.UseVisualStyleBackColor = false;
            this.btnMostrarFuncionarios.Click += new System.EventHandler(this.btnMostrarFuncionarios_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(868, 376);
            this.Controls.Add(this.btnMostrarFuncionarios);
            this.Controls.Add(this.inputNumeroEndereco);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.inputTelefoneEmergencia);
            this.Controls.Add(this.inputTelefone);
            this.Controls.Add(this.inputSalario);
            this.Controls.Add(this.inputProfissao);
            this.Controls.Add(this.inputEmail);
            this.Controls.Add(this.inputEndereco);
            this.Controls.Add(this.inputNomeFuncionario);
            this.Controls.Add(this.btnAbrirArquivo);
            this.Controls.Add(this.btnCadastrar);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Funcionários";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialSingleLineTextField inputNomeFuncionario;
        private MaterialSkin.Controls.MaterialSingleLineTextField inputEndereco;
        private MaterialSkin.Controls.MaterialFlatButton btnCadastrar;
        private MaterialSkin.Controls.MaterialFlatButton btnAbrirArquivo;
        private MaterialSkin.Controls.MaterialSingleLineTextField inputEmail;
        private MaterialSkin.Controls.MaterialSingleLineTextField inputProfissao;
        private MaterialSkin.Controls.MaterialSingleLineTextField inputSalario;
        private MaterialSkin.Controls.MaterialSingleLineTextField inputTelefone;
        private MaterialSkin.Controls.MaterialSingleLineTextField inputTelefoneEmergencia;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialSingleLineTextField inputNumeroEndereco;
        private MaterialSkin.Controls.MaterialFlatButton btnMostrarFuncionarios;
    }
}

