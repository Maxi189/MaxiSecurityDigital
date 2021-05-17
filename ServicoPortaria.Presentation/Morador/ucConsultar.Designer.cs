
namespace ServicoPortaria.Presentation.Morador
{
    partial class ucConsultar
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
            this.tsmCondominio = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmApartamento = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmVisitante = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmGaragem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmVeiculo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmPrestadorServicos = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSindico = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmHomePage = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmVisita = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsCondominio = new System.Windows.Forms.MenuStrip();
            this.tsmCadastroMorador = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmPredio = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmMorador = new System.Windows.Forms.ToolStripMenuItem();
            this.lblClose = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblSobrenome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtSobrenome = new System.Windows.Forms.TextBox();
            this.groupNome = new System.Windows.Forms.GroupBox();
            this.lblCPF = new System.Windows.Forms.Label();
            this.lblDocCivil = new System.Windows.Forms.Label();
            this.lblRG = new System.Windows.Forms.Label();
            this.mtxCPF = new System.Windows.Forms.MaskedTextBox();
            this.mtxRG = new System.Windows.Forms.MaskedTextBox();
            this.txtDocCivil = new System.Windows.Forms.TextBox();
            this.groupDocCivil = new System.Windows.Forms.GroupBox();
            this.lblCodPostal = new System.Windows.Forms.Label();
            this.lblCEP = new System.Windows.Forms.Label();
            this.lblRua = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.mtxCEP = new System.Windows.Forms.MaskedTextBox();
            this.txtCodPostal = new System.Windows.Forms.TextBox();
            this.txtRua = new System.Windows.Forms.TextBox();
            this.nudNumero = new System.Windows.Forms.NumericUpDown();
            this.groupEndereco = new System.Windows.Forms.GroupBox();
            this.lblCelular = new System.Windows.Forms.Label();
            this.lblEMail = new System.Windows.Forms.Label();
            this.lblFoneFixo = new System.Windows.Forms.Label();
            this.txtCelular = new System.Windows.Forms.TextBox();
            this.txtFoneFixo = new System.Windows.Forms.TextBox();
            this.txtEMail = new System.Windows.Forms.TextBox();
            this.groupContato = new System.Windows.Forms.GroupBox();
            this.groupConsultar = new System.Windows.Forms.GroupBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.mnsPresentation.SuspendLayout();
            this.mnsCondominio.SuspendLayout();
            this.groupNome.SuspendLayout();
            this.groupDocCivil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumero)).BeginInit();
            this.groupEndereco.SuspendLayout();
            this.groupContato.SuspendLayout();
            this.groupConsultar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();   
            // 
            // mnsCondominio
            // 
            this.mnsCondominio.BackColor = System.Drawing.Color.Black;
            this.mnsCondominio.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmCondominio,
            this.tsmPredio,
            this.tsmMorador,
            this.tsmApartamento,
            this.tsmVisitante,
            this.tsmVeiculo,
            this.tsmPrestadorServicos,
            this.tsmSindico,
            this.tsmHomePage,
            this.tsmVisita});
            this.mnsCondominio.Location = new System.Drawing.Point(137, 0);
            this.mnsCondominio.Name = "mnsCondominio";
            this.mnsCondominio.Size = new System.Drawing.Size(1233, 24);
            this.mnsCondominio.TabIndex = 54;
            this.mnsCondominio.Text = "Condomínio";
            // 
            // tsmCondominio
            // 
            this.tsmCondominio.ForeColor = System.Drawing.Color.White;
            this.tsmCondominio.Name = "tsmCondominio";
            this.tsmCondominio.Size = new System.Drawing.Size(131, 20);
            this.tsmCondominio.Text = "Condomínio";
            this.tsmCondominio.Click += new System.EventHandler(tsmCondominio_Click);
            // 
            // tsmPredio
            // 
            this.tsmPredio.ForeColor = System.Drawing.Color.White;
            this.tsmPredio.Name = "tsmPredio";
            this.tsmPredio.Size = new System.Drawing.Size(133, 20);
            this.tsmPredio.Text = "Prédio";
            this.tsmPredio.Click += new System.EventHandler(tsmPredio_Click);
            // 
            // tsmMorador
            // 
            this.tsmMorador.Enabled = false;
            this.tsmMorador.ForeColor = System.Drawing.Color.White;
            this.tsmMorador.Name = "tsmMorador";
            this.tsmMorador.Size = new System.Drawing.Size(125, 20);
            this.tsmMorador.Text = "Morador";
            // 
            // tsmApartamento
            // 
            this.tsmApartamento.ForeColor = System.Drawing.Color.White;
            this.tsmApartamento.Name = "tsmMorador";
            this.tsmApartamento.Size = new System.Drawing.Size(125, 20);
            this.tsmApartamento.Text = "Morador";
            this.tsmApartamento.Click += new System.EventHandler(tsmApartamento_Click);
            // 
            // tsmVisitante
            // 
            this.tsmVisitante.ForeColor = System.Drawing.Color.White;
            this.tsmVisitante.Name = "tsmMorador";
            this.tsmVisitante.Size = new System.Drawing.Size(125, 20);
            this.tsmVisitante.Text = "Morador";
            this.tsmVisitante.Click += new System.EventHandler(tsmVisitante_Click);
            // 
            // tsmVeiculo
            // 
            this.tsmVeiculo.ForeColor = System.Drawing.Color.White;
            this.tsmVeiculo.Name = "tsmMorador";
            this.tsmVeiculo.Size = new System.Drawing.Size(125, 20);
            this.tsmVeiculo.Text = "Morador";
            this.tsmVeiculo.Click += new System.EventHandler(tsmVeiculo_Click);
            // 
            // tsmPrestadorDeServicos
            // 
            this.tsmPrestadorServicos.ForeColor = System.Drawing.Color.White;
            this.tsmPrestadorServicos.Name = "tsmMorador";
            this.tsmPrestadorServicos.Size = new System.Drawing.Size(125, 20);
            this.tsmPrestadorServicos.Text = "Morador";
            this.tsmPrestadorServicos.Click += new System.EventHandler(tsmPrestadorDeServicos_Click);
            // 
            // tsmSindico
            // 
            this.tsmSindico.ForeColor = System.Drawing.Color.White;
            this.tsmSindico.Name = "tsmMorador";
            this.tsmSindico.Size = new System.Drawing.Size(125, 20);
            this.tsmSindico.Text = "Morador";
            this.tsmSindico.Click += new System.EventHandler(tsmSindico_Click);
            // 
            // tsmVisita
            // 
            this.tsmVisita.ForeColor = System.Drawing.Color.White;
            this.tsmVisita.Name = "tsmMorador";
            this.tsmVisita.Size = new System.Drawing.Size(125, 20);
            this.tsmVisita.Text = "Morador";
            this.tsmVisita.Click += new System.EventHandler(tsmVisita_Click);
            // 
            // tsmHomePage
            // 
            this.tsmHomePage.ForeColor = System.Drawing.Color.White;
            this.tsmHomePage.Name = "tsmMorador";
            this.tsmHomePage.Size = new System.Drawing.Size(125, 20);
            this.tsmHomePage.Text = "Morador";
            this.tsmHomePage.Click += new System.EventHandler(tsmHomePage_Click);
            // 
            // lblClose
            // 
            this.lblClose.BackColor = System.Drawing.Color.Red;
            this.lblClose.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblClose.ForeColor = System.Drawing.Color.White;
            this.lblClose.Location = new System.Drawing.Point(1345, 0);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(25, 25);
            this.lblClose.TabIndex = 63;
            this.lblClose.Text = "X";
            this.lblClose.Click += new System.EventHandler(lblClose_Click);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(33, 39);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(40, 15);
            this.lblNome.TabIndex = 64;
            this.lblNome.Text = "Nome";
            // 
            // lblSobrenome
            // 
            this.lblSobrenome.AutoSize = true;
            this.lblSobrenome.Location = new System.Drawing.Point(33, 92);
            this.lblSobrenome.Name = "lblSobrenome";
            this.lblSobrenome.Size = new System.Drawing.Size(68, 15);
            this.lblSobrenome.TabIndex = 65;
            this.lblSobrenome.Text = "Sobrenome";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(154, 39);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(167, 23);
            this.txtNome.TabIndex = 66;
            this.txtNome.TextChanged += new System.EventHandler(txtNome_TextChanged);
            // 
            // txtSobrenome
            // 
            this.txtSobrenome.Location = new System.Drawing.Point(154, 89);
            this.txtSobrenome.Name = "txtSobrenome";
            this.txtSobrenome.Size = new System.Drawing.Size(167, 23);
            this.txtSobrenome.TabIndex = 67;
            this.txtSobrenome.TextChanged += new System.EventHandler(txtSobrenome_TextChanged);
            // 
            // groupNome
            // 
            this.groupNome.Controls.Add(this.txtSobrenome);
            this.groupNome.Controls.Add(this.txtNome);
            this.groupNome.Controls.Add(this.lblSobrenome);
            this.groupNome.Controls.Add(this.lblNome);
            this.groupNome.Location = new System.Drawing.Point(178, 84);
            this.groupNome.Name = "groupNome";
            this.groupNome.Size = new System.Drawing.Size(339, 133);
            this.groupNome.TabIndex = 68;
            this.groupNome.TabStop = false;
            this.groupNome.Text = "Nome";
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Location = new System.Drawing.Point(11, 31);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(28, 15);
            this.lblCPF.TabIndex = 69;
            this.lblCPF.Text = "CPF";
            // 
            // lblDocCivil
            // 
            this.lblDocCivil.AutoSize = true;
            this.lblDocCivil.Location = new System.Drawing.Point(11, 109);
            this.lblDocCivil.Name = "lblDocCivil";
            this.lblDocCivil.Size = new System.Drawing.Size(96, 15);
            this.lblDocCivil.TabIndex = 70;
            this.lblDocCivil.Text = "Documento Civil";
            // 
            // lblRG
            // 
            this.lblRG.AutoSize = true;
            this.lblRG.Location = new System.Drawing.Point(11, 68);
            this.lblRG.Name = "lblRG";
            this.lblRG.Size = new System.Drawing.Size(22, 15);
            this.lblRG.TabIndex = 71;
            this.lblRG.Text = "RG";
            // 
            // mtxCPF
            // 
            this.mtxCPF.Location = new System.Drawing.Point(160, 29);
            this.mtxCPF.Mask = "000.000.000-00";
            this.mtxCPF.Name = "mtxDocCivil";
            this.mtxCPF.Size = new System.Drawing.Size(170, 23);
            this.mtxCPF.TabIndex = 72;
            this.mtxCPF.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(mtxCPF_MaskInputRejected);
            this.mtxCPF.TextChanged += new System.EventHandler(mtxCPF_TextChanged);
            // 
            // mtxRG
            // 
            this.mtxRG.Location = new System.Drawing.Point(160, 65);
            this.mtxRG.Mask = "00.000.000-0";
            this.mtxRG.Name = "mtxRG";
            this.mtxRG.Size = new System.Drawing.Size(170, 23);
            this.mtxRG.TabIndex = 73;
            this.mtxRG.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(mtxRG_MaskInputRejected);
            this.mtxRG.TextChanged += new System.EventHandler(mtxRG_TextChanged);
            // 
            // txtDocCivil
            // 
            this.txtDocCivil.Location = new System.Drawing.Point(160, 106);
            this.txtDocCivil.Name = "txtDocCivil";
            this.txtDocCivil.Size = new System.Drawing.Size(170, 23);
            this.txtDocCivil.TabIndex = 68;
            this.txtDocCivil.TextChanged += new System.EventHandler(txtDocCivil_TextChanged);
            // 
            // groupDocCivil
            // 
            this.groupDocCivil.Controls.Add(this.txtDocCivil);
            this.groupDocCivil.Controls.Add(this.mtxRG);
            this.groupDocCivil.Controls.Add(this.mtxCPF);
            this.groupDocCivil.Controls.Add(this.lblRG);
            this.groupDocCivil.Controls.Add(this.lblDocCivil);
            this.groupDocCivil.Controls.Add(this.lblCPF);
            this.groupDocCivil.Location = new System.Drawing.Point(523, 77);
            this.groupDocCivil.Name = "groupDocCivil";
            this.groupDocCivil.Size = new System.Drawing.Size(341, 140);
            this.groupDocCivil.TabIndex = 74;
            this.groupDocCivil.TabStop = false;
            this.groupDocCivil.Text = "Documentação Civil";
            // 
            // lblCodPostal
            // 
            this.lblCodPostal.AutoSize = true;
            this.lblCodPostal.Location = new System.Drawing.Point(12, 60);
            this.lblCodPostal.Name = "lblCodPostal";
            this.lblCodPostal.Size = new System.Drawing.Size(81, 15);
            this.lblCodPostal.TabIndex = 75;
            this.lblCodPostal.Text = "Código Postal";
            // 
            // lblCEP
            // 
            this.lblCEP.AutoSize = true;
            this.lblCEP.Location = new System.Drawing.Point(12, 28);
            this.lblCEP.Name = "lblCEP";
            this.lblCEP.Size = new System.Drawing.Size(28, 15);
            this.lblCEP.TabIndex = 76;
            this.lblCEP.Text = "CEP";
            // 
            // lblRua
            // 
            this.lblRua.AutoSize = true;
            this.lblRua.Location = new System.Drawing.Point(12, 96);
            this.lblRua.Name = "lblRua";
            this.lblRua.Size = new System.Drawing.Size(27, 15);
            this.lblRua.TabIndex = 77;
            this.lblRua.Text = "Rua";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(12, 137);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(51, 15);
            this.lblNumero.TabIndex = 78;
            this.lblNumero.Text = "Número";
            // 
            // mtxCEP
            // 
            this.mtxCEP.Location = new System.Drawing.Point(160, 25);
            this.mtxCEP.Mask = "00000-000";
            this.mtxCEP.Name = "mtsCEP";
            this.mtxCEP.Size = new System.Drawing.Size(161, 23);
            this.mtxCEP.TabIndex = 79;
            this.mtxCEP.TextChanged += new System.EventHandler(mtxCEP_TextChanged);
            this.mtxCEP.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(mtxCEP_MaskInputRejected);
            // 
            // txtCodPostal
            // 
            this.txtCodPostal.Location = new System.Drawing.Point(160, 57);
            this.txtCodPostal.Name = "txtCodPostal";
            this.txtCodPostal.Size = new System.Drawing.Size(161, 23);
            this.txtCodPostal.TabIndex = 80;
            this.txtCodPostal.TextChanged += new System.EventHandler(txtCodPostal_TextChanged);
            // 
            // txtRua
            // 
            this.txtRua.Location = new System.Drawing.Point(160, 93);
            this.txtRua.Name = "txtRua";
            this.txtRua.Size = new System.Drawing.Size(161, 23);
            this.txtRua.TabIndex = 81;
            this.txtRua.TextChanged += new System.EventHandler(txtRua_TextChanged);
            // 
            // nudNumero
            // 
            this.nudNumero.Location = new System.Drawing.Point(160, 135);
            this.nudNumero.Name = "nudNumero";
            this.nudNumero.Size = new System.Drawing.Size(161, 23);
            this.nudNumero.TabIndex = 82;
            this.nudNumero.ValueChanged += new System.EventHandler(nudNumero_ValueChanged);
            // 
            // groupEndereco
            // 
            this.groupEndereco.Controls.Add(this.nudNumero);
            this.groupEndereco.Controls.Add(this.txtRua);
            this.groupEndereco.Controls.Add(this.txtCodPostal);
            this.groupEndereco.Controls.Add(this.mtxCEP);
            this.groupEndereco.Controls.Add(this.lblNumero);
            this.groupEndereco.Controls.Add(this.lblRua);
            this.groupEndereco.Controls.Add(this.lblCEP);
            this.groupEndereco.Controls.Add(this.lblCodPostal);
            this.groupEndereco.Location = new System.Drawing.Point(910, 49);
            this.groupEndereco.Name = "groupEndereco";
            this.groupEndereco.Size = new System.Drawing.Size(339, 167);
            this.groupEndereco.TabIndex = 83;
            this.groupEndereco.TabStop = false;
            this.groupEndereco.Text = "Endereço";
            // 
            // lblCelular
            // 
            this.lblCelular.AutoSize = true;
            this.lblCelular.Location = new System.Drawing.Point(27, 26);
            this.lblCelular.Name = "lblCelular";
            this.lblCelular.Size = new System.Drawing.Size(44, 15);
            this.lblCelular.TabIndex = 84;
            this.lblCelular.Text = "Celular";
            // 
            // lblEMail
            // 
            this.lblEMail.AutoSize = true;
            this.lblEMail.Location = new System.Drawing.Point(27, 98);
            this.lblEMail.Name = "lblEMail";
            this.lblEMail.Size = new System.Drawing.Size(41, 15);
            this.lblEMail.TabIndex = 85;
            this.lblEMail.Text = "E-Mail";
            // 
            // lblFoneFixo
            // 
            this.lblFoneFixo.AutoSize = true;
            this.lblFoneFixo.Location = new System.Drawing.Point(27, 61);
            this.lblFoneFixo.Name = "lblFoneFixo";
            this.lblFoneFixo.Size = new System.Drawing.Size(76, 15);
            this.lblFoneFixo.TabIndex = 86;
            this.lblFoneFixo.Text = "Telefone Fixo";
            // 
            // txtCelular
            // 
            this.txtCelular.Location = new System.Drawing.Point(168, 23);
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(142, 23);
            this.txtCelular.TabIndex = 87;
            this.txtCelular.TextChanged += new System.EventHandler(txtCelular_TextChanged);
            // 
            // txtFoneFixo
            // 
            this.txtFoneFixo.Location = new System.Drawing.Point(168, 58);
            this.txtFoneFixo.Name = "txtFoneFixo";
            this.txtFoneFixo.Size = new System.Drawing.Size(142, 23);
            this.txtFoneFixo.TabIndex = 88;
            this.txtFoneFixo.TextChanged += new System.EventHandler(txtFoneFixo_TextChanged);
            // 
            // txtEMail
            // 
            this.txtEMail.Location = new System.Drawing.Point(168, 95);
            this.txtEMail.Name = "txtEMail";
            this.txtEMail.Size = new System.Drawing.Size(142, 23);
            this.txtEMail.TabIndex = 89;
            this.txtEMail.TextChanged += new System.EventHandler(txtEMail_TextChanged);
            // 
            // groupContato
            // 
            this.groupContato.Controls.Add(this.txtEMail);
            this.groupContato.Controls.Add(this.txtFoneFixo);
            this.groupContato.Controls.Add(this.txtCelular);
            this.groupContato.Controls.Add(this.lblFoneFixo);
            this.groupContato.Controls.Add(this.lblEMail);
            this.groupContato.Controls.Add(this.lblCelular);
            this.groupContato.Location = new System.Drawing.Point(362, 230);
            this.groupContato.Name = "groupContato";
            this.groupContato.Size = new System.Drawing.Size(325, 132);
            this.groupContato.TabIndex = 90;
            this.groupContato.TabStop = false;
            this.groupContato.Text = "Contato";
            // 
            // groupConsultar
            // 
            this.groupConsultar.Controls.Add(this.btnConsultar);
            this.groupConsultar.Location = new System.Drawing.Point(715, 230);
            this.groupConsultar.Name = "groupConsultar";
            this.groupConsultar.Size = new System.Drawing.Size(321, 132);
            this.groupConsultar.TabIndex = 91;
            this.groupConsultar.TabStop = false;
            this.groupConsultar.Text = "Consultar";
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.Color.Black;
            this.btnConsultar.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnConsultar.ForeColor = System.Drawing.Color.White;
            this.btnConsultar.Location = new System.Drawing.Point(43, 26);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(235, 72);
            this.btnConsultar.TabIndex = 0;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(btnConsultar_Click);
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToAddRows = false;
            this.dgvData.AllowUserToDeleteRows = false;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Location = new System.Drawing.Point(448, 397);
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            this.dgvData.RowTemplate.Height = 25;
            this.dgvData.Size = new System.Drawing.Size(542, 287);
            this.dgvData.TabIndex = 92;
            // 
            // ucConsultar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.groupConsultar);
            this.Controls.Add(this.groupContato);
            this.Controls.Add(this.groupEndereco);
            this.Controls.Add(this.groupDocCivil);
            this.Controls.Add(this.groupNome);
            this.Controls.Add(this.lblClose);
            this.Controls.Add(this.mnsCondominio);
            this.Controls.Add(this.mnsPresentation);
            this.Name = "ucConsultar";
            this.Size = new System.Drawing.Size(1370, 800);
            this.mnsPresentation.ResumeLayout(false);
            this.mnsPresentation.PerformLayout();
            this.mnsCondominio.ResumeLayout(false);
            this.mnsCondominio.PerformLayout();
            this.groupNome.ResumeLayout(false);
            this.groupNome.PerformLayout();
            this.groupDocCivil.ResumeLayout(false);
            this.groupDocCivil.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumero)).EndInit();
            this.groupEndereco.ResumeLayout(false);
            this.groupEndereco.PerformLayout();
            this.groupContato.ResumeLayout(false);
            this.groupContato.PerformLayout();
            this.groupConsultar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ucConsultar Consultar;
        private System.Windows.Forms.MenuStrip mnsPresentation;
        private System.Windows.Forms.ToolStripMenuItem tsmCondominio;
        private System.Windows.Forms.ToolStripMenuItem tsmApartamento;
        private System.Windows.Forms.ToolStripMenuItem tsmVisitante;
        private System.Windows.Forms.ToolStripMenuItem tsmGaragem;
        private System.Windows.Forms.ToolStripMenuItem tsmVeiculo;
        private System.Windows.Forms.ToolStripMenuItem tsmPrestadorServicos;
        private System.Windows.Forms.ToolStripMenuItem tsmSindico;
        private System.Windows.Forms.ToolStripMenuItem tsmHomePage;
        private System.Windows.Forms.ToolStripMenuItem tsmVisita;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printPreviewToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem indexToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.MenuStrip mnsCondominio;
        private System.Windows.Forms.ToolStripMenuItem tsmCadastroMorador;
        private System.Windows.Forms.ToolStripMenuItem tsmPredio;
        private System.Windows.Forms.ToolStripMenuItem tsmMorador;
        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblSobrenome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtSobrenome;
        private System.Windows.Forms.GroupBox groupNome;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.Label lblDocCivil;
        private System.Windows.Forms.Label lblRG;
        private System.Windows.Forms.MaskedTextBox mtxCPF;
        private System.Windows.Forms.MaskedTextBox mtxRG;
        private System.Windows.Forms.TextBox txtDocCivil;
        private System.Windows.Forms.GroupBox groupDocCivil;
        private System.Windows.Forms.Label lblCodPostal;
        private System.Windows.Forms.Label lblCEP;
        private System.Windows.Forms.Label lblRua;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.MaskedTextBox mtxCEP;
        private System.Windows.Forms.TextBox txtCodPostal;
        private System.Windows.Forms.TextBox txtRua;
        private System.Windows.Forms.NumericUpDown nudNumero;
        private System.Windows.Forms.GroupBox groupEndereco;
        private System.Windows.Forms.Label lblCelular;
        private System.Windows.Forms.Label lblEMail;
        private System.Windows.Forms.Label lblFoneFixo;
        private System.Windows.Forms.TextBox txtCelular;
        private System.Windows.Forms.TextBox txtFoneFixo;
        private System.Windows.Forms.TextBox txtEMail;
        private System.Windows.Forms.GroupBox groupContato;
        private System.Windows.Forms.GroupBox groupConsultar;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.DataGridView dgvData;
    }
}
