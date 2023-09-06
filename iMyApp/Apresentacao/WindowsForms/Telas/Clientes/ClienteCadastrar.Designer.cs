namespace WindowsForms.Telas.Clientes
{
    partial class ClienteCadastrar
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
            lblNomeCompleto = new Label();
            lblCPF = new Label();
            lblNascimento = new Label();
            txtNomeCompleto = new TextBox();
            txtCPF = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            lblTelefone = new Label();
            lblEmail = new Label();
            pbFotoDePerfil = new PictureBox();
            mtbTelefone = new MaskedTextBox();
            txtEmail = new TextBox();
            lblBolsaDeEstudos = new Label();
            cmbBolsaDeEstudos = new ComboBox();
            cbClienteResponsavel = new CheckBox();
            btnSalvar = new Button();
            ((System.ComponentModel.ISupportInitialize)pbFotoDePerfil).BeginInit();
            SuspendLayout();
            // 
            // lblNomeCompleto
            // 
            lblNomeCompleto.AutoSize = true;
            lblNomeCompleto.Location = new Point(125, 19);
            lblNomeCompleto.Name = "lblNomeCompleto";
            lblNomeCompleto.Size = new Size(96, 15);
            lblNomeCompleto.TabIndex = 0;
            lblNomeCompleto.Text = "Nome Completo";
            // 
            // lblCPF
            // 
            lblCPF.AutoSize = true;
            lblCPF.Location = new Point(460, 19);
            lblCPF.Name = "lblCPF";
            lblCPF.Size = new Size(28, 15);
            lblCPF.TabIndex = 1;
            lblCPF.Text = "CPF";
            // 
            // lblNascimento
            // 
            lblNascimento.AutoSize = true;
            lblNascimento.Location = new Point(125, 82);
            lblNascimento.Name = "lblNascimento";
            lblNascimento.Size = new Size(114, 15);
            lblNascimento.TabIndex = 2;
            lblNascimento.Text = "Data de Nascimento";
            // 
            // txtNomeCompleto
            // 
            txtNomeCompleto.Location = new Point(460, 47);
            txtNomeCompleto.Name = "txtNomeCompleto";
            txtNomeCompleto.Size = new Size(145, 23);
            txtNomeCompleto.TabIndex = 3;
            // 
            // txtCPF
            // 
            txtCPF.Location = new Point(125, 47);
            txtCPF.Name = "txtCPF";
            txtCPF.Size = new Size(314, 23);
            txtCPF.TabIndex = 5;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(125, 100);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(96, 23);
            dateTimePicker1.TabIndex = 6;
            // 
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.Location = new Point(259, 82);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(51, 15);
            lblTelefone.TabIndex = 7;
            lblTelefone.Text = "Telefone";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(391, 82);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(41, 15);
            lblEmail.TabIndex = 8;
            lblEmail.Text = "E-mail";
            // 
            // pbFotoDePerfil
            // 
            pbFotoDePerfil.BackgroundImage = Properties.Resources.pbFotoDePerfilBackGround;
            pbFotoDePerfil.Image = Properties.Resources.pbFotoDePerfilBackGround;
            pbFotoDePerfil.Location = new Point(39, 19);
            pbFotoDePerfil.Name = "pbFotoDePerfil";
            pbFotoDePerfil.Size = new Size(77, 68);
            pbFotoDePerfil.SizeMode = PictureBoxSizeMode.Zoom;
            pbFotoDePerfil.TabIndex = 9;
            pbFotoDePerfil.TabStop = false;
            // 
            // mtbTelefone
            // 
            mtbTelefone.Location = new Point(259, 100);
            mtbTelefone.Mask = "(99) 000-0000";
            mtbTelefone.Name = "mtbTelefone";
            mtbTelefone.Size = new Size(100, 23);
            mtbTelefone.TabIndex = 11;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(391, 100);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(269, 23);
            txtEmail.TabIndex = 12;
            // 
            // lblBolsaDeEstudos
            // 
            lblBolsaDeEstudos.AutoSize = true;
            lblBolsaDeEstudos.Location = new Point(125, 145);
            lblBolsaDeEstudos.Name = "lblBolsaDeEstudos";
            lblBolsaDeEstudos.Size = new Size(95, 15);
            lblBolsaDeEstudos.TabIndex = 13;
            lblBolsaDeEstudos.Text = "Bolsa de Estudos";
            // 
            // cmbBolsaDeEstudos
            // 
            cmbBolsaDeEstudos.FormattingEnabled = true;
            cmbBolsaDeEstudos.Location = new Point(125, 163);
            cmbBolsaDeEstudos.Name = "cmbBolsaDeEstudos";
            cmbBolsaDeEstudos.Size = new Size(121, 23);
            cmbBolsaDeEstudos.TabIndex = 14;
            // 
            // cbClienteResponsavel
            // 
            cbClienteResponsavel.AutoSize = true;
            cbClienteResponsavel.Location = new Point(125, 192);
            cbClienteResponsavel.Name = "cbClienteResponsavel";
            cbClienteResponsavel.Size = new Size(180, 19);
            cbClienteResponsavel.TabIndex = 15;
            cbClienteResponsavel.Text = "Cliente é o responsável legal?";
            cbClienteResponsavel.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(391, 163);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(87, 27);
            btnSalvar.TabIndex = 16;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // ClienteCadastrar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSalvar);
            Controls.Add(cbClienteResponsavel);
            Controls.Add(cmbBolsaDeEstudos);
            Controls.Add(lblBolsaDeEstudos);
            Controls.Add(txtEmail);
            Controls.Add(mtbTelefone);
            Controls.Add(pbFotoDePerfil);
            Controls.Add(lblEmail);
            Controls.Add(lblTelefone);
            Controls.Add(dateTimePicker1);
            Controls.Add(txtCPF);
            Controls.Add(txtNomeCompleto);
            Controls.Add(lblNascimento);
            Controls.Add(lblCPF);
            Controls.Add(lblNomeCompleto);
            Name = "ClienteCadastrar";
            Text = "ClienteCadastrar";
            ((System.ComponentModel.ISupportInitialize)pbFotoDePerfil).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNomeCompleto;
        private Label lblCPF;
        private Label lblNascimento;
        private TextBox txtNomeCompleto;
        private TextBox txtCPF;
        private DateTimePicker dateTimePicker1;
        private Label lblTelefone;
        private Label lblEmail;
        private PictureBox pbFotoDePerfil;
        private MaskedTextBox mtbTelefone;
        private TextBox txtEmail;
        private Label lblBolsaDeEstudos;
        private ComboBox cmbBolsaDeEstudos;
        private CheckBox cbClienteResponsavel;
        private Button btnSalvar;
    }
}