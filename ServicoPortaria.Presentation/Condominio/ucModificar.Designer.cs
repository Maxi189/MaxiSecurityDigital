
namespace ServicoPortaria.Presentation.Condominio
{
    partial class ucModificar
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblClose = new System.Windows.Forms.Label();
            this.txtRua = new System.Windows.Forms.TextBox();
            this.lblRua = new System.Windows.Forms.Label();
            this.nudNumero = new System.Windows.Forms.NumericUpDown();
            this.mtxCEP = new System.Windows.Forms.MaskedTextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtPais = new System.Windows.Forms.TextBox();
            this.txtProvincia = new System.Windows.Forms.TextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.txtCodPostal = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblPais = new System.Windows.Forms.Label();
            this.lblProvincia = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblCidade = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblCodPostal = new System.Windows.Forms.Label();
            this.lblCEP = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.groupModificar = new System.Windows.Forms.GroupBox();
            this.groupConsultar = new System.Windows.Forms.GroupBox();
            this.btnConsultarDados = new System.Windows.Forms.Button();
            this.lblIdCondominio = new System.Windows.Forms.Label();
            this.txtConsultarPais = new System.Windows.Forms.TextBox();
            this.lblConsultarPais = new System.Windows.Forms.Label();
            this.txtConsultarCidade = new System.Windows.Forms.TextBox();
            this.lblConsultarCidade = new System.Windows.Forms.Label();
            this.mtxConsultarCEP = new System.Windows.Forms.MaskedTextBox();
            this.lblConsultarCEP = new System.Windows.Forms.Label();
            this.txtConsultarNome = new System.Windows.Forms.TextBox();
            this.lblConsultarNome = new System.Windows.Forms.Label();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumero)).BeginInit();
            this.groupModificar.SuspendLayout();
            this.groupConsultar.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblClose
            // 
            this.lblClose.BackColor = System.Drawing.Color.Red;
            this.lblClose.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblClose.ForeColor = System.Drawing.Color.White;
            this.lblClose.Location = new System.Drawing.Point(1345, 0);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(25, 25);
            this.lblClose.TabIndex = 65;
            this.lblClose.Text = "X";
            // 
            // txtRua
            // 
            this.txtRua.Location = new System.Drawing.Point(183, 138);
            this.txtRua.Name = "txtRua";
            this.txtRua.Size = new System.Drawing.Size(243, 23);
            this.txtRua.TabIndex = 84;
            // 
            // lblRua
            // 
            this.lblRua.AutoSize = true;
            this.lblRua.Location = new System.Drawing.Point(25, 141);
            this.lblRua.Name = "lblRua";
            this.lblRua.Size = new System.Drawing.Size(27, 15);
            this.lblRua.TabIndex = 83;
            this.lblRua.Text = "Rua";
            // 
            // nudNumero
            // 
            this.nudNumero.Location = new System.Drawing.Point(183, 196);
            this.nudNumero.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.nudNumero.Name = "nudNumero";
            this.nudNumero.Size = new System.Drawing.Size(243, 23);
            this.nudNumero.TabIndex = 82;
            // 
            // mtxCEP
            // 
            this.mtxCEP.Location = new System.Drawing.Point(183, 109);
            this.mtxCEP.Mask = "00000-000";
            this.mtxCEP.Name = "mtxCEP";
            this.mtxCEP.Size = new System.Drawing.Size(243, 23);
            this.mtxCEP.TabIndex = 81;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Black;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(116, 380);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(261, 61);
            this.btnUpdate.TabIndex = 80;
            this.btnUpdate.Text = "Modificar Dados";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtPais
            // 
            this.txtPais.Location = new System.Drawing.Point(183, 324);
            this.txtPais.Name = "txtPais";
            this.txtPais.Size = new System.Drawing.Size(243, 23);
            this.txtPais.TabIndex = 79;
            // 
            // txtProvincia
            // 
            this.txtProvincia.Location = new System.Drawing.Point(183, 290);
            this.txtProvincia.Name = "txtProvincia";
            this.txtProvincia.Size = new System.Drawing.Size(243, 23);
            this.txtProvincia.TabIndex = 78;
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(183, 225);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(243, 23);
            this.txtCidade.TabIndex = 76;
            // 
            // txtCodPostal
            // 
            this.txtCodPostal.Location = new System.Drawing.Point(183, 167);
            this.txtCodPostal.Name = "txtCodPostal";
            this.txtCodPostal.Size = new System.Drawing.Size(243, 23);
            this.txtCodPostal.TabIndex = 75;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(183, 71);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(243, 23);
            this.txtNome.TabIndex = 74;
            // 
            // lblPais
            // 
            this.lblPais.AutoSize = true;
            this.lblPais.Location = new System.Drawing.Point(25, 327);
            this.lblPais.Name = "lblPais";
            this.lblPais.Size = new System.Drawing.Size(28, 15);
            this.lblPais.TabIndex = 73;
            this.lblPais.Text = "País";
            // 
            // lblProvincia
            // 
            this.lblProvincia.AutoSize = true;
            this.lblProvincia.Location = new System.Drawing.Point(25, 293);
            this.lblProvincia.Name = "lblProvincia";
            this.lblProvincia.Size = new System.Drawing.Size(56, 15);
            this.lblProvincia.TabIndex = 72;
            this.lblProvincia.Text = "Província";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(25, 261);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(42, 15);
            this.lblEstado.TabIndex = 71;
            this.lblEstado.Text = "Estado";
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Location = new System.Drawing.Point(25, 225);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(44, 15);
            this.lblCidade.TabIndex = 70;
            this.lblCidade.Text = "Cidade";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(25, 198);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(138, 15);
            this.lblNumero.TabIndex = 69;
            this.lblNumero.Text = "Número do Condomínio";
            // 
            // lblCodPostal
            // 
            this.lblCodPostal.AutoSize = true;
            this.lblCodPostal.Location = new System.Drawing.Point(25, 170);
            this.lblCodPostal.Name = "lblCodPostal";
            this.lblCodPostal.Size = new System.Drawing.Size(81, 15);
            this.lblCodPostal.TabIndex = 68;
            this.lblCodPostal.Text = "Código Postal";
            // 
            // lblCEP
            // 
            this.lblCEP.AutoSize = true;
            this.lblCEP.Location = new System.Drawing.Point(25, 112);
            this.lblCEP.Name = "lblCEP";
            this.lblCEP.Size = new System.Drawing.Size(28, 15);
            this.lblCEP.TabIndex = 67;
            this.lblCEP.Text = "CEP";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(25, 74);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(40, 15);
            this.lblNome.TabIndex = 66;
            this.lblNome.Text = "Nome";
            // 
            // groupModificar
            // 
            this.groupModificar.Controls.Add(this.cmbEstado);
            this.groupModificar.Controls.Add(this.txtRua);
            this.groupModificar.Controls.Add(this.lblIdCondominio);
            this.groupModificar.Controls.Add(this.lblRua);
            this.groupModificar.Controls.Add(this.nudNumero);
            this.groupModificar.Controls.Add(this.mtxCEP);
            this.groupModificar.Controls.Add(this.btnUpdate);
            this.groupModificar.Controls.Add(this.txtPais);
            this.groupModificar.Controls.Add(this.txtProvincia);
            this.groupModificar.Controls.Add(this.txtCidade);
            this.groupModificar.Controls.Add(this.txtCodPostal);
            this.groupModificar.Controls.Add(this.txtNome);
            this.groupModificar.Controls.Add(this.lblPais);
            this.groupModificar.Controls.Add(this.lblProvincia);
            this.groupModificar.Controls.Add(this.lblEstado);
            this.groupModificar.Controls.Add(this.lblCidade);
            this.groupModificar.Controls.Add(this.lblNumero);
            this.groupModificar.Controls.Add(this.lblCodPostal);
            this.groupModificar.Controls.Add(this.lblCEP);
            this.groupModificar.Controls.Add(this.lblNome);
            this.groupModificar.Location = new System.Drawing.Point(253, 178);
            this.groupModificar.Name = "groupModificar";
            this.groupModificar.Size = new System.Drawing.Size(483, 455);
            this.groupModificar.TabIndex = 85;
            this.groupModificar.TabStop = false;
            this.groupModificar.Text = "Modificar Dados";
            // 
            // groupConsultar
            // 
            this.groupConsultar.Controls.Add(this.btnConsultarDados);
            this.groupConsultar.Controls.Add(this.txtConsultarPais);
            this.groupConsultar.Controls.Add(this.lblConsultarPais);
            this.groupConsultar.Controls.Add(this.txtConsultarCidade);
            this.groupConsultar.Controls.Add(this.lblConsultarCidade);
            this.groupConsultar.Controls.Add(this.mtxConsultarCEP);
            this.groupConsultar.Controls.Add(this.lblConsultarCEP);
            this.groupConsultar.Controls.Add(this.txtConsultarNome);
            this.groupConsultar.Controls.Add(this.lblConsultarNome);
            this.groupConsultar.Location = new System.Drawing.Point(771, 185);
            this.groupConsultar.Name = "groupConsultar";
            this.groupConsultar.Size = new System.Drawing.Size(427, 448);
            this.groupConsultar.TabIndex = 86;
            this.groupConsultar.TabStop = false;
            this.groupConsultar.Text = "Consultar Dados";
            // 
            // btnConsultarDados
            // 
            this.btnConsultarDados.BackColor = System.Drawing.Color.Black;
            this.btnConsultarDados.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnConsultarDados.ForeColor = System.Drawing.Color.White;
            this.btnConsultarDados.Location = new System.Drawing.Point(83, 373);
            this.btnConsultarDados.Name = "btnConsultarDados";
            this.btnConsultarDados.Size = new System.Drawing.Size(273, 61);
            this.btnConsultarDados.TabIndex = 92;
            this.btnConsultarDados.Text = "Consultar Dados";
            this.btnConsultarDados.UseVisualStyleBackColor = false;
            this.btnConsultarDados.Click += new System.EventHandler(this.btnConsultarDados_Click);
            // 
            // lblIdCondominio
            // 
            this.lblIdCondominio.AutoSize = true;
            this.lblIdCondominio.Location = new System.Drawing.Point(183, 30);
            this.lblIdCondominio.Name = "lblIdCondominio";
            this.lblIdCondominio.Size = new System.Drawing.Size(133, 15);
            this.lblIdCondominio.TabIndex = 91;
            this.lblIdCondominio.Text = "Código do Condomínio";
            // 
            // txtConsultarPais
            // 
            this.txtConsultarPais.Location = new System.Drawing.Point(168, 236);
            this.txtConsultarPais.Name = "txtConsultarPais";
            this.txtConsultarPais.Size = new System.Drawing.Size(243, 23);
            this.txtConsultarPais.TabIndex = 90;
            // 
            // lblConsultarPais
            // 
            this.lblConsultarPais.AutoSize = true;
            this.lblConsultarPais.Location = new System.Drawing.Point(10, 239);
            this.lblConsultarPais.Name = "lblConsultarPais";
            this.lblConsultarPais.Size = new System.Drawing.Size(28, 15);
            this.lblConsultarPais.TabIndex = 89;
            this.lblConsultarPais.Text = "País";
            // 
            // txtConsultarCidade
            // 
            this.txtConsultarCidade.Location = new System.Drawing.Point(168, 174);
            this.txtConsultarCidade.Name = "txtConsultarCidade";
            this.txtConsultarCidade.Size = new System.Drawing.Size(243, 23);
            this.txtConsultarCidade.TabIndex = 88;
            // 
            // lblConsultarCidade
            // 
            this.lblConsultarCidade.AutoSize = true;
            this.lblConsultarCidade.Location = new System.Drawing.Point(10, 174);
            this.lblConsultarCidade.Name = "lblConsultarCidade";
            this.lblConsultarCidade.Size = new System.Drawing.Size(44, 15);
            this.lblConsultarCidade.TabIndex = 87;
            this.lblConsultarCidade.Text = "Cidade";
            // 
            // mtxConsultarCEP
            // 
            this.mtxConsultarCEP.Location = new System.Drawing.Point(168, 109);
            this.mtxConsultarCEP.Mask = "00000-000";
            this.mtxConsultarCEP.Name = "mtxConsultarCEP";
            this.mtxConsultarCEP.Size = new System.Drawing.Size(243, 23);
            this.mtxConsultarCEP.TabIndex = 86;
            // 
            // lblConsultarCEP
            // 
            this.lblConsultarCEP.AutoSize = true;
            this.lblConsultarCEP.Location = new System.Drawing.Point(10, 112);
            this.lblConsultarCEP.Name = "lblConsultarCEP";
            this.lblConsultarCEP.Size = new System.Drawing.Size(28, 15);
            this.lblConsultarCEP.TabIndex = 85;
            this.lblConsultarCEP.Text = "CEP";
            // 
            // txtConsultarNome
            // 
            this.txtConsultarNome.Location = new System.Drawing.Point(168, 52);
            this.txtConsultarNome.Name = "txtConsultarNome";
            this.txtConsultarNome.Size = new System.Drawing.Size(243, 23);
            this.txtConsultarNome.TabIndex = 76;
            // 
            // lblConsultarNome
            // 
            this.lblConsultarNome.AutoSize = true;
            this.lblConsultarNome.Location = new System.Drawing.Point(10, 55);
            this.lblConsultarNome.Name = "lblConsultarNome";
            this.lblConsultarNome.Size = new System.Drawing.Size(40, 15);
            this.lblConsultarNome.TabIndex = 75;
            this.lblConsultarNome.Text = "Nome";
            // 
            // cmbEstado
            // 
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AM",
            "AP",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MG",
            "MS",
            "MT",
            "PA",
            "PB",
            "PE",
            "PI",
            "PR",
            "RJ",
            "RN",
            "RO",
            "RR",
            "RS",
            "SC",
            "SE",
            "SP",
            "TO"});
            this.cmbEstado.Location = new System.Drawing.Point(183, 258);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(243, 23);
            this.cmbEstado.TabIndex = 92;
            // 
            // ucModificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupConsultar);
            this.Controls.Add(this.groupModificar);
            this.Controls.Add(this.lblClose);
            this.Name = "ucModificar";
            this.Size = new System.Drawing.Size(1370, 800);
            this.Load += new System.EventHandler(this.ucModificar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudNumero)).EndInit();
            this.groupModificar.ResumeLayout(false);
            this.groupModificar.PerformLayout();
            this.groupConsultar.ResumeLayout(false);
            this.groupConsultar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.TextBox txtRua;
        private System.Windows.Forms.Label lblRua;
        private System.Windows.Forms.NumericUpDown nudNumero;
        private System.Windows.Forms.MaskedTextBox mtxCEP;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtPais;
        private System.Windows.Forms.TextBox txtProvincia;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.TextBox txtCodPostal;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblPais;
        private System.Windows.Forms.Label lblProvincia;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label lblCodPostal;
        private System.Windows.Forms.Label lblCEP;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.GroupBox groupModificar;
        private System.Windows.Forms.GroupBox groupConsultar;
        private System.Windows.Forms.TextBox txtConsultarNome;
        private System.Windows.Forms.Label lblConsultarNome;
        private System.Windows.Forms.Button btnConsultarDados;
        private System.Windows.Forms.Label lblIdCondominio;
        private System.Windows.Forms.TextBox txtConsultarPais;
        private System.Windows.Forms.Label lblConsultarPais;
        private System.Windows.Forms.TextBox txtConsultarCidade;
        private System.Windows.Forms.Label lblConsultarCidade;
        private System.Windows.Forms.MaskedTextBox mtxConsultarCEP;
        private System.Windows.Forms.Label lblConsultarCEP;
        private System.Windows.Forms.ComboBox cmbEstado;
    }
}
