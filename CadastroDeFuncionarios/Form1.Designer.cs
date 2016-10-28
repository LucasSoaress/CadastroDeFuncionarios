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
            this.materialFlatButton2 = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnApagar = new MaterialSkin.Controls.MaterialFlatButton();
            this.inputEmail = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.inputProfissao = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.inputSalario = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.inputTelefone = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.radioSolteiro = new MaterialSkin.Controls.MaterialRadioButton();
            this.radioCasado = new MaterialSkin.Controls.MaterialRadioButton();
            this.radioNoivo = new MaterialSkin.Controls.MaterialRadioButton();
            this.inputTelefoneEmergencia = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.inputNumeroEndereco = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.radioViuvo = new MaterialSkin.Controls.MaterialRadioButton();
            this.SuspendLayout();
            // 
            // inputNomeFuncionario
            // 
            this.inputNomeFuncionario.BackColor = System.Drawing.Color.White;
            this.inputNomeFuncionario.Depth = 0;
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
            this.btnCadastrar.Location = new System.Drawing.Point(1075, 479);
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
            // materialFlatButton2
            // 
            this.materialFlatButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.materialFlatButton2.AutoSize = true;
            this.materialFlatButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton2.BackColor = System.Drawing.SystemColors.Control;
            this.materialFlatButton2.Depth = 0;
            this.materialFlatButton2.Location = new System.Drawing.Point(950, 479);
            this.materialFlatButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton2.Name = "materialFlatButton2";
            this.materialFlatButton2.Primary = false;
            this.materialFlatButton2.Size = new System.Drawing.Size(117, 36);
            this.materialFlatButton2.TabIndex = 2;
            this.materialFlatButton2.Text = "Novo registro";
            this.materialFlatButton2.UseVisualStyleBackColor = false;
            // 
            // btnApagar
            // 
            this.btnApagar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnApagar.AutoSize = true;
            this.btnApagar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnApagar.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnApagar.Depth = 0;
            this.btnApagar.Location = new System.Drawing.Point(876, 479);
            this.btnApagar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnApagar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Primary = false;
            this.btnApagar.Size = new System.Drawing.Size(66, 36);
            this.btnApagar.TabIndex = 3;
            this.btnApagar.Text = "APAGAR";
            this.btnApagar.UseVisualStyleBackColor = false;
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
            // radioSolteiro
            // 
            this.radioSolteiro.AutoSize = true;
            this.radioSolteiro.BackColor = System.Drawing.Color.White;
            this.radioSolteiro.Depth = 0;
            this.radioSolteiro.Font = new System.Drawing.Font("Roboto", 10F);
            this.radioSolteiro.Location = new System.Drawing.Point(9, 335);
            this.radioSolteiro.Margin = new System.Windows.Forms.Padding(0);
            this.radioSolteiro.MouseLocation = new System.Drawing.Point(-1, -1);
            this.radioSolteiro.MouseState = MaterialSkin.MouseState.HOVER;
            this.radioSolteiro.Name = "radioSolteiro";
            this.radioSolteiro.Ripple = true;
            this.radioSolteiro.Size = new System.Drawing.Size(77, 30);
            this.radioSolteiro.TabIndex = 20;
            this.radioSolteiro.TabStop = true;
            this.radioSolteiro.Text = "Solteiro";
            this.radioSolteiro.UseVisualStyleBackColor = false;
            // 
            // radioCasado
            // 
            this.radioCasado.AutoSize = true;
            this.radioCasado.BackColor = System.Drawing.Color.White;
            this.radioCasado.Depth = 0;
            this.radioCasado.Font = new System.Drawing.Font("Roboto", 10F);
            this.radioCasado.Location = new System.Drawing.Point(98, 335);
            this.radioCasado.Margin = new System.Windows.Forms.Padding(0);
            this.radioCasado.MouseLocation = new System.Drawing.Point(-1, -1);
            this.radioCasado.MouseState = MaterialSkin.MouseState.HOVER;
            this.radioCasado.Name = "radioCasado";
            this.radioCasado.Ripple = true;
            this.radioCasado.Size = new System.Drawing.Size(75, 30);
            this.radioCasado.TabIndex = 21;
            this.radioCasado.TabStop = true;
            this.radioCasado.Text = "Casado";
            this.radioCasado.UseVisualStyleBackColor = false;
            // 
            // radioNoivo
            // 
            this.radioNoivo.AutoSize = true;
            this.radioNoivo.BackColor = System.Drawing.Color.White;
            this.radioNoivo.Depth = 0;
            this.radioNoivo.Font = new System.Drawing.Font("Roboto", 10F);
            this.radioNoivo.Location = new System.Drawing.Point(193, 335);
            this.radioNoivo.Margin = new System.Windows.Forms.Padding(0);
            this.radioNoivo.MouseLocation = new System.Drawing.Point(-1, -1);
            this.radioNoivo.MouseState = MaterialSkin.MouseState.HOVER;
            this.radioNoivo.Name = "radioNoivo";
            this.radioNoivo.Ripple = true;
            this.radioNoivo.Size = new System.Drawing.Size(65, 30);
            this.radioNoivo.TabIndex = 22;
            this.radioNoivo.TabStop = true;
            this.radioNoivo.Text = "Noivo";
            this.radioNoivo.UseVisualStyleBackColor = false;
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
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(126, 305);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(118, 19);
            this.materialLabel1.TabIndex = 24;
            this.materialLabel1.Text = "Relacionamento";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(81, 91);
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
            // radioViuvo
            // 
            this.radioViuvo.AutoSize = true;
            this.radioViuvo.BackColor = System.Drawing.Color.White;
            this.radioViuvo.Depth = 0;
            this.radioViuvo.Font = new System.Drawing.Font("Roboto", 10F);
            this.radioViuvo.Location = new System.Drawing.Point(283, 335);
            this.radioViuvo.Margin = new System.Windows.Forms.Padding(0);
            this.radioViuvo.MouseLocation = new System.Drawing.Point(-1, -1);
            this.radioViuvo.MouseState = MaterialSkin.MouseState.HOVER;
            this.radioViuvo.Name = "radioViuvo";
            this.radioViuvo.Ripple = true;
            this.radioViuvo.Size = new System.Drawing.Size(64, 30);
            this.radioViuvo.TabIndex = 27;
            this.radioViuvo.TabStop = true;
            this.radioViuvo.Text = "Viuvo";
            this.radioViuvo.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1179, 530);
            this.Controls.Add(this.radioViuvo);
            this.Controls.Add(this.inputNumeroEndereco);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.inputTelefoneEmergencia);
            this.Controls.Add(this.radioNoivo);
            this.Controls.Add(this.radioCasado);
            this.Controls.Add(this.radioSolteiro);
            this.Controls.Add(this.inputTelefone);
            this.Controls.Add(this.inputSalario);
            this.Controls.Add(this.inputProfissao);
            this.Controls.Add(this.inputEmail);
            this.Controls.Add(this.inputEndereco);
            this.Controls.Add(this.inputNomeFuncionario);
            this.Controls.Add(this.btnApagar);
            this.Controls.Add(this.materialFlatButton2);
            this.Controls.Add(this.btnCadastrar);
            this.Name = "Form1";
            this.Text = "Cadastro de Funcionários";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialSingleLineTextField inputNomeFuncionario;
        private MaterialSkin.Controls.MaterialSingleLineTextField inputEndereco;
        private MaterialSkin.Controls.MaterialFlatButton btnCadastrar;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton2;
        private MaterialSkin.Controls.MaterialFlatButton btnApagar;
        private MaterialSkin.Controls.MaterialSingleLineTextField inputEmail;
        private MaterialSkin.Controls.MaterialSingleLineTextField inputProfissao;
        private MaterialSkin.Controls.MaterialSingleLineTextField inputSalario;
        private MaterialSkin.Controls.MaterialSingleLineTextField inputTelefone;
        private MaterialSkin.Controls.MaterialRadioButton radioSolteiro;
        private MaterialSkin.Controls.MaterialRadioButton radioCasado;
        private MaterialSkin.Controls.MaterialRadioButton radioNoivo;
        private MaterialSkin.Controls.MaterialSingleLineTextField inputTelefoneEmergencia;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialSingleLineTextField inputNumeroEndereco;
        private MaterialSkin.Controls.MaterialRadioButton radioViuvo;
    }
}

