namespace WindowsForms.Telas.Funcinarios
{
    partial class CargoView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CargoView));
            chkStatus = new CheckBox();
            gbCargoNovo = new GroupBox();
            txtCargo = new TextBox();
            btnSalvar = new Button();
            btnNovoCargo = new Button();
            btnRecarregar = new Button();
            gvCargos = new DataGridView();
            lblGridView = new Label();
            gbCargoNovo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gvCargos).BeginInit();
            SuspendLayout();
            // 
            // chkStatus
            // 
            chkStatus.AutoSize = true;
            chkStatus.Location = new Point(477, 44);
            chkStatus.Name = "chkStatus";
            chkStatus.Size = new Size(107, 24);
            chkStatus.TabIndex = 0;
            chkStatus.Text = "Cargo Ativo";
            chkStatus.UseVisualStyleBackColor = true;
            // 
            // gbCargoNovo
            // 
            gbCargoNovo.Controls.Add(txtCargo);
            gbCargoNovo.Controls.Add(chkStatus);
            gbCargoNovo.Controls.Add(btnSalvar);
            gbCargoNovo.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            gbCargoNovo.Location = new Point(12, 54);
            gbCargoNovo.Name = "gbCargoNovo";
            gbCargoNovo.Size = new Size(776, 100);
            gbCargoNovo.TabIndex = 1;
            gbCargoNovo.TabStop = false;
            gbCargoNovo.Text = "Novo Cargo";
            gbCargoNovo.Visible = false;
            // 
            // txtCargo
            // 
            txtCargo.Location = new Point(6, 46);
            txtCargo.Name = "txtCargo";
            txtCargo.Size = new Size(454, 27);
            txtCargo.TabIndex = 4;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(670, 44);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(100, 29);
            btnSalvar.TabIndex = 2;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnNovoCargo
            // 
            btnNovoCargo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnNovoCargo.Location = new Point(12, 12);
            btnNovoCargo.Name = "btnNovoCargo";
            btnNovoCargo.Size = new Size(146, 36);
            btnNovoCargo.TabIndex = 3;
            btnNovoCargo.Text = "Novo Cargo";
            btnNovoCargo.UseVisualStyleBackColor = true;
            btnNovoCargo.Click += btnNovoCargo_Click;
            // 
            // btnRecarregar
            // 
            btnRecarregar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnRecarregar.Location = new Point(682, 159);
            btnRecarregar.Name = "btnRecarregar";
            btnRecarregar.Size = new Size(106, 31);
            btnRecarregar.TabIndex = 5;
            btnRecarregar.Text = "Recarregar";
            btnRecarregar.UseVisualStyleBackColor = true;
            // 
            // gvCargos
            // 
            gvCargos.AllowUserToOrderColumns = true;
            gvCargos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gvCargos.Location = new Point(12, 196);
            gvCargos.Name = "gvCargos";
            gvCargos.RowTemplate.Height = 25;
            gvCargos.Size = new Size(776, 230);
            gvCargos.TabIndex = 6;
            gvCargos.CellClick += gvCargos_CellClick;
            // 
            // lblGridView
            // 
            lblGridView.AutoSize = true;
            lblGridView.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblGridView.Location = new Point(12, 172);
            lblGridView.Name = "lblGridView";
            lblGridView.Size = new Size(201, 21);
            lblGridView.TabIndex = 7;
            lblGridView.Text = "Todos os Cargos (GridView)";
            // 
            // CargoView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblGridView);
            Controls.Add(gvCargos);
            Controls.Add(btnRecarregar);
            Controls.Add(btnNovoCargo);
            Controls.Add(gbCargoNovo);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "CargoView";
            Text = "CadastroFuncinarios";
            Load += CargoView_Load;
            gbCargoNovo.ResumeLayout(false);
            gbCargoNovo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gvCargos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox chkStatus;
        private GroupBox gbCargoNovo;
        private Button btnSalvar;
        private Button btnNovoCargo;
        private TextBox txtCargo;
        private Button btnRecarregar;
        private DataGridView gvCargos;
        private Label lblGridView;
    }
}