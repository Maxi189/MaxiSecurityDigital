
namespace ServicoPortaria.Presentation.Sindico
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
            this.lblNome = new System.Windows.Forms.Label();
            this.lblPredio = new System.Windows.Forms.Label();
            this.lblCondominio = new System.Windows.Forms.Label();
            this.lblDocCivil = new System.Windows.Forms.Label();
            this.lblRG = new System.Windows.Forms.Label();
            this.lblCPF = new System.Windows.Forms.Label();
            this.lblSobrenome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtSobrenome = new System.Windows.Forms.TextBox();
            this.lblIdCondominio = new System.Windows.Forms.Label();
            this.lblIdPredio = new System.Windows.Forms.Label();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.mtxCPF = new System.Windows.Forms.MaskedTextBox();
            this.mtxRG = new System.Windows.Forms.MaskedTextBox();
            this.txtDocCivil = new System.Windows.Forms.TextBox();
            this.txtCondominio = new System.Windows.Forms.TextBox();
            this.txtPredio = new System.Windows.Forms.TextBox();
            this.groupNome = new System.Windows.Forms.GroupBox();
            this.groupDocumentacao = new System.Windows.Forms.GroupBox();
            this.groupLocal = new System.Windows.Forms.GroupBox();
            this.groupCodigos = new System.Windows.Forms.GroupBox();
            this.groupConsultar = new System.Windows.Forms.GroupBox();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.lblClose = new System.Windows.Forms.Label();
            this.mnsCondominio = new System.Windows.Forms.MenuStrip();
            this.tsmCondomínio = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmPredio = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmMorador = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmApartamento = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmVisitante = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmVeiculo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmPrestadorDeServicos = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSindico = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmHomePage = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmVisita = new System.Windows.Forms.ToolStripMenuItem();
            this.groupNome.SuspendLayout();
            this.groupDocumentacao.SuspendLayout();
            this.groupLocal.SuspendLayout();
            this.groupCodigos.SuspendLayout();
            this.groupConsultar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.mnsCondominio.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(16, 21);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(40, 15);
            this.lblNome.TabIndex = 61;
            this.lblNome.Text = "Nome";
            // 
            // lblPredio
            // 
            this.lblPredio.AutoSize = true;
            this.lblPredio.Location = new System.Drawing.Point(16, 66);
            this.lblPredio.Name = "lblPredio";
            this.lblPredio.Size = new System.Drawing.Size(41, 15);
            this.lblPredio.TabIndex = 62;
            this.lblPredio.Text = "Prédio";
            // 
            // lblCondominio
            // 
            this.lblCondominio.AutoSize = true;
            this.lblCondominio.Location = new System.Drawing.Point(16, 18);
            this.lblCondominio.Name = "lblCondominio";
            this.lblCondominio.Size = new System.Drawing.Size(74, 15);
            this.lblCondominio.TabIndex = 63;
            this.lblCondominio.Text = "Condomínio";
            // 
            // lblDocCivil
            // 
            this.lblDocCivil.AutoSize = true;
            this.lblDocCivil.Location = new System.Drawing.Point(23, 113);
            this.lblDocCivil.Name = "lblDocCivil";
            this.lblDocCivil.Size = new System.Drawing.Size(114, 15);
            this.lblDocCivil.TabIndex = 64;
            this.lblDocCivil.Text = "Documentação Civil";
            // 
            // lblRG
            // 
            this.lblRG.AutoSize = true;
            this.lblRG.Location = new System.Drawing.Point(23, 69);
            this.lblRG.Name = "lblRG";
            this.lblRG.Size = new System.Drawing.Size(22, 15);
            this.lblRG.TabIndex = 65;
            this.lblRG.Text = "RG";
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Location = new System.Drawing.Point(23, 21);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(28, 15);
            this.lblCPF.TabIndex = 66;
            this.lblCPF.Text = "CPF";
            // 
            // lblSobrenome
            // 
            this.lblSobrenome.AutoSize = true;
            this.lblSobrenome.Location = new System.Drawing.Point(16, 69);
            this.lblSobrenome.Name = "lblSobrenome";
            this.lblSobrenome.Size = new System.Drawing.Size(68, 15);
            this.lblSobrenome.TabIndex = 67;
            this.lblSobrenome.Text = "Sobrenome";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(96, 17);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(163, 23);
            this.txtNome.TabIndex = 68;
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            // 
            // txtSobrenome
            // 
            this.txtSobrenome.Location = new System.Drawing.Point(96, 65);
            this.txtSobrenome.Name = "txtSobrenome";
            this.txtSobrenome.Size = new System.Drawing.Size(163, 23);
            this.txtSobrenome.TabIndex = 69;
            this.txtSobrenome.TextChanged += new System.EventHandler(this.txtSobrenome_TextChanged);
            // 
            // lblIdCondominio
            // 
            this.lblIdCondominio.AutoSize = true;
            this.lblIdCondominio.Location = new System.Drawing.Point(95, 24);
            this.lblIdCondominio.Name = "lblIdCondominio";
            this.lblIdCondominio.Size = new System.Drawing.Size(133, 15);
            this.lblIdCondominio.TabIndex = 71;
            this.lblIdCondominio.Text = "Código do Condomínio";
            // 
            // lblIdPredio
            // 
            this.lblIdPredio.AutoSize = true;
            this.lblIdPredio.Location = new System.Drawing.Point(95, 72);
            this.lblIdPredio.Name = "lblIdPredio";
            this.lblIdPredio.Size = new System.Drawing.Size(100, 15);
            this.lblIdPredio.TabIndex = 70;
            this.lblIdPredio.Text = "Código do Prédio";
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.Color.Black;
            this.btnConsultar.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnConsultar.ForeColor = System.Drawing.Color.White;
            this.btnConsultar.Location = new System.Drawing.Point(51, 28);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(208, 89);
            this.btnConsultar.TabIndex = 72;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // mtxCPF
            // 
            this.mtxCPF.Location = new System.Drawing.Point(154, 18);
            this.mtxCPF.Mask = "000.000.000-00";
            this.mtxCPF.Name = "mtxCPF";
            this.mtxCPF.Size = new System.Drawing.Size(173, 23);
            this.mtxCPF.TabIndex = 73;
            this.mtxCPF.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mtxCPF_MaskInputRejected);
            this.mtxCPF.TextChanged += new System.EventHandler(this.mtxCPF_TextChanged);
            // 
            // mtxRG
            // 
            this.mtxRG.Location = new System.Drawing.Point(154, 66);
            this.mtxRG.Mask = "00.000.000-0";
            this.mtxRG.Name = "mtxRG";
            this.mtxRG.Size = new System.Drawing.Size(173, 23);
            this.mtxRG.TabIndex = 74;
            this.mtxRG.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mtxRG_MaskInputRejected);
            this.mtxRG.TextChanged += new System.EventHandler(this.mtxRG_TextChanged);
            // 
            // txtDocCivil
            // 
            this.txtDocCivil.Location = new System.Drawing.Point(154, 110);
            this.txtDocCivil.Name = "txtDocCivil";
            this.txtDocCivil.Size = new System.Drawing.Size(173, 23);
            this.txtDocCivil.TabIndex = 75;
            this.txtDocCivil.TextChanged += new System.EventHandler(this.txtDocCivil_TextChanged);
            // 
            // txtCondominio
            // 
            this.txtCondominio.Location = new System.Drawing.Point(96, 15);
            this.txtCondominio.Name = "txtCondominio";
            this.txtCondominio.Size = new System.Drawing.Size(163, 23);
            this.txtCondominio.TabIndex = 76;
            this.txtCondominio.TextChanged += new System.EventHandler(this.txtCondominio_TextChanged);
            // 
            // txtPredio
            // 
            this.txtPredio.Location = new System.Drawing.Point(96, 63);
            this.txtPredio.Name = "txtPredio";
            this.txtPredio.Size = new System.Drawing.Size(163, 23);
            this.txtPredio.TabIndex = 77;
            this.txtPredio.TextChanged += new System.EventHandler(this.txtPredio_TextChanged);
            // 
            // groupNome
            // 
            this.groupNome.Controls.Add(this.txtSobrenome);
            this.groupNome.Controls.Add(this.txtNome);
            this.groupNome.Controls.Add(this.lblSobrenome);
            this.groupNome.Controls.Add(this.lblNome);
            this.groupNome.Location = new System.Drawing.Point(265, 84);
            this.groupNome.Name = "groupNome";
            this.groupNome.Size = new System.Drawing.Size(270, 145);
            this.groupNome.TabIndex = 78;
            this.groupNome.TabStop = false;
            this.groupNome.Text = "Nome";
            // 
            // groupDocumentacao
            // 
            this.groupDocumentacao.Controls.Add(this.txtDocCivil);
            this.groupDocumentacao.Controls.Add(this.mtxRG);
            this.groupDocumentacao.Controls.Add(this.mtxCPF);
            this.groupDocumentacao.Controls.Add(this.lblCPF);
            this.groupDocumentacao.Controls.Add(this.lblRG);
            this.groupDocumentacao.Controls.Add(this.lblDocCivil);
            this.groupDocumentacao.Location = new System.Drawing.Point(548, 84);
            this.groupDocumentacao.Name = "groupDocumentacao";
            this.groupDocumentacao.Size = new System.Drawing.Size(345, 144);
            this.groupDocumentacao.TabIndex = 79;
            this.groupDocumentacao.TabStop = false;
            this.groupDocumentacao.Text = "Documentação Civil";
            // 
            // groupLocal
            // 
            this.groupLocal.Controls.Add(this.txtPredio);
            this.groupLocal.Controls.Add(this.txtCondominio);
            this.groupLocal.Controls.Add(this.lblCondominio);
            this.groupLocal.Controls.Add(this.lblPredio);
            this.groupLocal.Location = new System.Drawing.Point(265, 264);
            this.groupLocal.Name = "groupLocal";
            this.groupLocal.Size = new System.Drawing.Size(267, 95);
            this.groupLocal.TabIndex = 80;
            this.groupLocal.TabStop = false;
            this.groupLocal.Text = "Local";
            // 
            // groupCodigos
            // 
            this.groupCodigos.Controls.Add(this.lblIdCondominio);
            this.groupCodigos.Controls.Add(this.lblIdPredio);
            this.groupCodigos.Location = new System.Drawing.Point(553, 264);
            this.groupCodigos.Name = "groupCodigos";
            this.groupCodigos.Size = new System.Drawing.Size(340, 94);
            this.groupCodigos.TabIndex = 81;
            this.groupCodigos.TabStop = false;
            this.groupCodigos.Text = "Códigos";
            // 
            // groupConsultar
            // 
            this.groupConsultar.Controls.Add(this.btnConsultar);
            this.groupConsultar.Location = new System.Drawing.Point(962, 165);
            this.groupConsultar.Name = "groupConsultar";
            this.groupConsultar.Size = new System.Drawing.Size(279, 138);
            this.groupConsultar.TabIndex = 82;
            this.groupConsultar.TabStop = false;
            this.groupConsultar.Text = "Consultar";
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToAddRows = false;
            this.dgvData.AllowUserToDeleteRows = false;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Location = new System.Drawing.Point(553, 404);
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            this.dgvData.RowTemplate.Height = 25;
            this.dgvData.Size = new System.Drawing.Size(450, 271);
            this.dgvData.TabIndex = 83;
            // 
            // lblClose
            // 
            this.lblClose.BackColor = System.Drawing.Color.Red;
            this.lblClose.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblClose.ForeColor = System.Drawing.Color.White;
            this.lblClose.Location = new System.Drawing.Point(1345, 0);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(25, 25);
            this.lblClose.TabIndex = 84;
            this.lblClose.Text = "X";
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            // 
            // mnsCondominio
            // 
            this.mnsCondominio.BackColor = System.Drawing.Color.Black;
            this.mnsCondominio.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmCondomínio,
            this.tsmPredio,
            this.tsmMorador,
            this.tsmApartamento,
            this.tsmVisitante,
            this.tsmVeiculo,
            this.tsmPrestadorDeServicos,
            this.tsmSindico,
            this.tsmHomePage,
            this.tsmVisita});
            this.mnsCondominio.Location = new System.Drawing.Point(0, 0);
            this.mnsCondominio.Name = "mnsCondominio";
            this.mnsCondominio.Size = new System.Drawing.Size(1370, 24);
            this.mnsCondominio.TabIndex = 94;
            this.mnsCondominio.Text = "Condomínio";
            // 
            // tsmCondomínio
            // 
            this.tsmCondomínio.ForeColor = System.Drawing.Color.White;
            this.tsmCondomínio.Name = "tsmCondomínio";
            this.tsmCondomínio.Size = new System.Drawing.Size(86, 20);
            this.tsmCondomínio.Text = "Condomínio";
            // 
            // tsmPredio
            // 
            this.tsmPredio.ForeColor = System.Drawing.Color.White;
            this.tsmPredio.Name = "tsmPredio";
            this.tsmPredio.Size = new System.Drawing.Size(53, 20);
            this.tsmPredio.Text = "Prédio";
            // 
            // tsmMorador
            // 
            this.tsmMorador.ForeColor = System.Drawing.Color.White;
            this.tsmMorador.Name = "tsmMorador";
            this.tsmMorador.Size = new System.Drawing.Size(65, 20);
            this.tsmMorador.Text = "Morador";
            // 
            // tsmApartamento
            // 
            this.tsmApartamento.ForeColor = System.Drawing.Color.White;
            this.tsmApartamento.Name = "tsmApartamento";
            this.tsmApartamento.Size = new System.Drawing.Size(89, 20);
            this.tsmApartamento.Text = "Apartamento";
            // 
            // tsmVisitante
            // 
            this.tsmVisitante.ForeColor = System.Drawing.Color.White;
            this.tsmVisitante.Name = "tsmVisitante";
            this.tsmVisitante.Size = new System.Drawing.Size(64, 20);
            this.tsmVisitante.Text = "Visitante";
            // 
            // tsmVeiculo
            // 
            this.tsmVeiculo.Enabled = false;
            this.tsmVeiculo.ForeColor = System.Drawing.Color.White;
            this.tsmVeiculo.Name = "tsmVeiculo";
            this.tsmVeiculo.Size = new System.Drawing.Size(57, 20);
            this.tsmVeiculo.Text = "Veículo";
            // 
            // tsmPrestadorDeServicos
            // 
            this.tsmPrestadorDeServicos.ForeColor = System.Drawing.Color.White;
            this.tsmPrestadorDeServicos.Name = "tsmPrestadorDeServicos";
            this.tsmPrestadorDeServicos.Size = new System.Drawing.Size(131, 20);
            this.tsmPrestadorDeServicos.Text = "Prestador de Serviços";
            // 
            // tsmSindico
            // 
            this.tsmSindico.ForeColor = System.Drawing.Color.White;
            this.tsmSindico.Name = "tsmSindico";
            this.tsmSindico.Size = new System.Drawing.Size(58, 20);
            this.tsmSindico.Text = "Síndico";
            // 
            // tsmHomePage
            // 
            this.tsmHomePage.ForeColor = System.Drawing.Color.White;
            this.tsmHomePage.Name = "tsmHomePage";
            this.tsmHomePage.Size = new System.Drawing.Size(81, 20);
            this.tsmHomePage.Text = "Home Page";
            // 
            // tsmVisita
            // 
            this.tsmVisita.ForeColor = System.Drawing.Color.White;
            this.tsmVisita.Name = "tsmVisita";
            this.tsmVisita.Size = new System.Drawing.Size(47, 20);
            this.tsmVisita.Text = "Visita";
            // 
            // ucConsultar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblClose);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.groupConsultar);
            this.Controls.Add(this.groupCodigos);
            this.Controls.Add(this.groupLocal);
            this.Controls.Add(this.groupDocumentacao);
            this.Controls.Add(this.groupNome);
            this.Controls.Add(this.mnsCondominio);
            this.Name = "ucConsultar";
            this.Size = new System.Drawing.Size(1370, 800);
            this.groupNome.ResumeLayout(false);
            this.groupNome.PerformLayout();
            this.groupDocumentacao.ResumeLayout(false);
            this.groupDocumentacao.PerformLayout();
            this.groupLocal.ResumeLayout(false);
            this.groupLocal.PerformLayout();
            this.groupCodigos.ResumeLayout(false);
            this.groupCodigos.PerformLayout();
            this.groupConsultar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.mnsCondominio.ResumeLayout(false);
            this.mnsCondominio.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblPredio;
        private System.Windows.Forms.Label lblCondominio;
        private System.Windows.Forms.Label lblDocCivil;
        private System.Windows.Forms.Label lblRG;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.Label lblSobrenome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtSobrenome;
        private System.Windows.Forms.Label lblIdCondominio;
        private System.Windows.Forms.Label lblIdPredio;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.MaskedTextBox mtxCPF;
        private System.Windows.Forms.MaskedTextBox mtxRG;
        private System.Windows.Forms.TextBox txtDocCivil;
        private System.Windows.Forms.TextBox txtCondominio;
        private System.Windows.Forms.TextBox txtPredio;
        private System.Windows.Forms.GroupBox groupNome;
        private System.Windows.Forms.GroupBox groupDocumentacao;
        private System.Windows.Forms.GroupBox groupLocal;
        private System.Windows.Forms.GroupBox groupCodigos;
        private System.Windows.Forms.GroupBox groupConsultar;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.MenuStrip mnsCondominio;
        private System.Windows.Forms.ToolStripMenuItem tsmCondomínio;
        private System.Windows.Forms.ToolStripMenuItem tsmPredio;
        private System.Windows.Forms.ToolStripMenuItem tsmMorador;
        private System.Windows.Forms.ToolStripMenuItem tsmApartamento;
        private System.Windows.Forms.ToolStripMenuItem tsmVisitante;
        private System.Windows.Forms.ToolStripMenuItem tsmVeiculo;
        private System.Windows.Forms.ToolStripMenuItem tsmPrestadorDeServicos;
        private System.Windows.Forms.ToolStripMenuItem tsmSindico;
        private System.Windows.Forms.ToolStripMenuItem tsmHomePage;
        private System.Windows.Forms.ToolStripMenuItem tsmVisita;
    }
}
