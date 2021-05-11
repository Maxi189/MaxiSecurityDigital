
namespace ServicoPortaria.Presentation.Apartamento
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
            this.lblClose = new System.Windows.Forms.Label();
            this.lblCondominio = new System.Windows.Forms.Label();
            this.lblPredio = new System.Windows.Forms.Label();
            this.lblBloco = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblRamal = new System.Windows.Forms.Label();
            this.txtCondominio = new System.Windows.Forms.TextBox();
            this.txtRamal = new System.Windows.Forms.TextBox();
            this.txtBloco = new System.Windows.Forms.TextBox();
            this.txtPredio = new System.Windows.Forms.TextBox();
            this.nudNumero = new System.Windows.Forms.NumericUpDown();
            this.groupDados = new System.Windows.Forms.GroupBox();
            this.lblIdCondominio = new System.Windows.Forms.Label();
            this.lblIdPredio = new System.Windows.Forms.Label();
            this.groupId = new System.Windows.Forms.GroupBox();
            this.groupConsultar = new System.Windows.Forms.GroupBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.dgvData = new System.Windows.Forms.DataGridView();
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
            ((System.ComponentModel.ISupportInitialize)(this.nudNumero)).BeginInit();
            this.groupDados.SuspendLayout();
            this.groupId.SuspendLayout();
            this.groupConsultar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.mnsCondominio.SuspendLayout();
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
            this.lblClose.TabIndex = 64;
            this.lblClose.Text = "X";
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            // 
            // lblCondominio
            // 
            this.lblCondominio.AutoSize = true;
            this.lblCondominio.Location = new System.Drawing.Point(15, 37);
            this.lblCondominio.Name = "lblCondominio";
            this.lblCondominio.Size = new System.Drawing.Size(127, 15);
            this.lblCondominio.TabIndex = 65;
            this.lblCondominio.Text = "Nome do Condomínio";
            // 
            // lblPredio
            // 
            this.lblPredio.AutoSize = true;
            this.lblPredio.Location = new System.Drawing.Point(15, 78);
            this.lblPredio.Name = "lblPredio";
            this.lblPredio.Size = new System.Drawing.Size(94, 15);
            this.lblPredio.TabIndex = 66;
            this.lblPredio.Text = "Nome do Prédio";
            // 
            // lblBloco
            // 
            this.lblBloco.AutoSize = true;
            this.lblBloco.Location = new System.Drawing.Point(15, 115);
            this.lblBloco.Name = "lblBloco";
            this.lblBloco.Size = new System.Drawing.Size(37, 15);
            this.lblBloco.TabIndex = 67;
            this.lblBloco.Text = "Bloco";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(15, 192);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(51, 15);
            this.lblNumero.TabIndex = 68;
            this.lblNumero.Text = "Número";
            // 
            // lblRamal
            // 
            this.lblRamal.AutoSize = true;
            this.lblRamal.Location = new System.Drawing.Point(15, 154);
            this.lblRamal.Name = "lblRamal";
            this.lblRamal.Size = new System.Drawing.Size(40, 15);
            this.lblRamal.TabIndex = 69;
            this.lblRamal.Text = "Ramal";
            // 
            // txtCondominio
            // 
            this.txtCondominio.Location = new System.Drawing.Point(148, 34);
            this.txtCondominio.Name = "txtCondominio";
            this.txtCondominio.Size = new System.Drawing.Size(183, 23);
            this.txtCondominio.TabIndex = 70;
            this.txtCondominio.TextChanged += new System.EventHandler(this.txtCondominio_TextChanged);
            // 
            // txtRamal
            // 
            this.txtRamal.Location = new System.Drawing.Point(148, 151);
            this.txtRamal.Name = "txtRamal";
            this.txtRamal.Size = new System.Drawing.Size(183, 23);
            this.txtRamal.TabIndex = 71;
            this.txtRamal.TextChanged += new System.EventHandler(this.txtRamal_TextChanged);
            // 
            // txtBloco
            // 
            this.txtBloco.Location = new System.Drawing.Point(148, 112);
            this.txtBloco.Name = "txtBloco";
            this.txtBloco.Size = new System.Drawing.Size(183, 23);
            this.txtBloco.TabIndex = 72;
            this.txtBloco.TextChanged += new System.EventHandler(this.txtBloco_TextChanged);
            // 
            // txtPredio
            // 
            this.txtPredio.Location = new System.Drawing.Point(148, 75);
            this.txtPredio.Name = "txtPredio";
            this.txtPredio.Size = new System.Drawing.Size(183, 23);
            this.txtPredio.TabIndex = 73;
            this.txtPredio.TextChanged += new System.EventHandler(this.txtPredio_TextChanged);
            // 
            // nudNumero
            // 
            this.nudNumero.Location = new System.Drawing.Point(148, 190);
            this.nudNumero.Name = "nudNumero";
            this.nudNumero.Size = new System.Drawing.Size(183, 23);
            this.nudNumero.TabIndex = 74;
            this.nudNumero.ValueChanged += new System.EventHandler(this.nudNumero_ValueChanged);
            // 
            // groupDados
            // 
            this.groupDados.Controls.Add(this.nudNumero);
            this.groupDados.Controls.Add(this.txtPredio);
            this.groupDados.Controls.Add(this.txtBloco);
            this.groupDados.Controls.Add(this.txtRamal);
            this.groupDados.Controls.Add(this.txtCondominio);
            this.groupDados.Controls.Add(this.lblRamal);
            this.groupDados.Controls.Add(this.lblNumero);
            this.groupDados.Controls.Add(this.lblBloco);
            this.groupDados.Controls.Add(this.lblPredio);
            this.groupDados.Controls.Add(this.lblCondominio);
            this.groupDados.Location = new System.Drawing.Point(254, 128);
            this.groupDados.Name = "groupDados";
            this.groupDados.Size = new System.Drawing.Size(354, 227);
            this.groupDados.TabIndex = 75;
            this.groupDados.TabStop = false;
            this.groupDados.Text = "Dados";
            // 
            // lblIdCondominio
            // 
            this.lblIdCondominio.AutoSize = true;
            this.lblIdCondominio.Location = new System.Drawing.Point(35, 27);
            this.lblIdCondominio.Name = "lblIdCondominio";
            this.lblIdCondominio.Size = new System.Drawing.Size(133, 15);
            this.lblIdCondominio.TabIndex = 76;
            this.lblIdCondominio.Text = "Código do Condomínio";
            // 
            // lblIdPredio
            // 
            this.lblIdPredio.AutoSize = true;
            this.lblIdPredio.Location = new System.Drawing.Point(35, 68);
            this.lblIdPredio.Name = "lblIdPredio";
            this.lblIdPredio.Size = new System.Drawing.Size(100, 15);
            this.lblIdPredio.TabIndex = 77;
            this.lblIdPredio.Text = "Código do Prédio";
            // 
            // groupId
            // 
            this.groupId.Controls.Add(this.lblIdPredio);
            this.groupId.Controls.Add(this.lblIdCondominio);
            this.groupId.Location = new System.Drawing.Point(614, 128);
            this.groupId.Name = "groupId";
            this.groupId.Size = new System.Drawing.Size(306, 227);
            this.groupId.TabIndex = 78;
            this.groupId.TabStop = false;
            this.groupId.Text = "Códigos";
            // 
            // groupConsultar
            // 
            this.groupConsultar.Controls.Add(this.btnConsultar);
            this.groupConsultar.Location = new System.Drawing.Point(932, 126);
            this.groupConsultar.Name = "groupConsultar";
            this.groupConsultar.Size = new System.Drawing.Size(293, 229);
            this.groupConsultar.TabIndex = 79;
            this.groupConsultar.TabStop = false;
            this.groupConsultar.Text = "Consultar";
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.Color.Black;
            this.btnConsultar.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnConsultar.ForeColor = System.Drawing.Color.White;
            this.btnConsultar.Location = new System.Drawing.Point(39, 58);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(218, 132);
            this.btnConsultar.TabIndex = 0;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToAddRows = false;
            this.dgvData.AllowUserToDeleteRows = false;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Location = new System.Drawing.Point(471, 385);
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            this.dgvData.RowTemplate.Height = 25;
            this.dgvData.Size = new System.Drawing.Size(531, 264);
            this.dgvData.TabIndex = 80;
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
            this.mnsCondominio.TabIndex = 91;
            this.mnsCondominio.Text = "Condomínio";
            // 
            // tsmCondomínio
            // 
            this.tsmCondomínio.ForeColor = System.Drawing.Color.White;
            this.tsmCondomínio.Name = "tsmCondomínio";
            this.tsmCondomínio.Size = new System.Drawing.Size(86, 20);
            this.tsmCondomínio.Text = "Condomínio";
            this.tsmCondomínio.Click += new System.EventHandler(tsmCondominio_Click);
            // 
            // tsmPredio
            // 
            this.tsmPredio.ForeColor = System.Drawing.Color.White;
            this.tsmPredio.Name = "tsmPredio";
            this.tsmPredio.Size = new System.Drawing.Size(53, 20);
            this.tsmPredio.Text = "Prédio";
            this.tsmPredio.Click += new System.EventHandler(tsmPredio_Click);
            // 
            // tsmMorador
            // 
            this.tsmMorador.ForeColor = System.Drawing.Color.White;
            this.tsmMorador.Name = "tsmMorador";
            this.tsmMorador.Size = new System.Drawing.Size(65, 20);
            this.tsmMorador.Text = "Morador";
            this.tsmMorador.Click += new System.EventHandler(tsmMorador_Click);
            // 
            // tsmApartamento
            // 
            this.tsmApartamento.Enabled = false;
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
            this.tsmVisitante.Click += new System.EventHandler(tsmVisitante_Click);
            // 
            // tsmVeiculo
            // 
            this.tsmVeiculo.ForeColor = System.Drawing.Color.White;
            this.tsmVeiculo.Name = "tsmVeiculo";
            this.tsmVeiculo.Size = new System.Drawing.Size(57, 20);
            this.tsmVeiculo.Text = "Veículo";
            this.tsmVeiculo.Click += new System.EventHandler(tsmVeiculo_Click);
            // 
            // tsmPrestadorDeServicos
            // 
            this.tsmPrestadorDeServicos.ForeColor = System.Drawing.Color.White;
            this.tsmPrestadorDeServicos.Name = "tsmPrestadorDeServicos";
            this.tsmPrestadorDeServicos.Size = new System.Drawing.Size(131, 20);
            this.tsmPrestadorDeServicos.Text = "Prestador de Serviços";
            this.tsmPrestadorDeServicos.Click += new System.EventHandler(tsmPrestadorDeServicos_Click);
            // 
            // tsmSindico
            // 
            this.tsmSindico.ForeColor = System.Drawing.Color.White;
            this.tsmSindico.Name = "tsmSindico";
            this.tsmSindico.Size = new System.Drawing.Size(58, 20);
            this.tsmSindico.Text = "Síndico";
            this.tsmSindico.Click += new System.EventHandler(tsmSindico_Click);
            // 
            // tsmHomePage
            // 
            this.tsmHomePage.ForeColor = System.Drawing.Color.White;
            this.tsmHomePage.Name = "tsmHomePage";
            this.tsmHomePage.Size = new System.Drawing.Size(81, 20);
            this.tsmHomePage.Text = "Home Page";
            this.tsmHomePage.Click += new System.EventHandler(tsmHomePage_Click);
            // 
            // tsmVisita
            // 
            this.tsmVisita.ForeColor = System.Drawing.Color.White;
            this.tsmVisita.Name = "tsmVisita";
            this.tsmVisita.Size = new System.Drawing.Size(47, 20);
            this.tsmVisita.Text = "Visita";
            this.tsmVisita.Click += new System.EventHandler(tsmVisita_Click);
            // 
            // ucConsultar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.groupConsultar);
            this.Controls.Add(this.groupId);
            this.Controls.Add(this.groupDados);
            this.Controls.Add(this.lblClose);
            this.Controls.Add(this.mnsCondominio);
            this.Name = "ucConsultar";
            this.Size = new System.Drawing.Size(1370, 800);
            ((System.ComponentModel.ISupportInitialize)(this.nudNumero)).EndInit();
            this.groupDados.ResumeLayout(false);
            this.groupDados.PerformLayout();
            this.groupId.ResumeLayout(false);
            this.groupId.PerformLayout();
            this.groupConsultar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.mnsCondominio.ResumeLayout(false);
            this.mnsCondominio.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.Label lblCondominio;
        private System.Windows.Forms.Label lblPredio;
        private System.Windows.Forms.Label lblBloco;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label lblRamal;
        private System.Windows.Forms.TextBox txtCondominio;
        private System.Windows.Forms.TextBox txtRamal;
        private System.Windows.Forms.TextBox txtBloco;
        private System.Windows.Forms.TextBox txtPredio;
        private System.Windows.Forms.NumericUpDown nudNumero;
        private System.Windows.Forms.GroupBox groupDados;
        private System.Windows.Forms.Label lblIdCondominio;
        private System.Windows.Forms.Label lblIdPredio;
        private System.Windows.Forms.GroupBox groupId;
        private System.Windows.Forms.GroupBox groupConsultar;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.DataGridView dgvData;
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
