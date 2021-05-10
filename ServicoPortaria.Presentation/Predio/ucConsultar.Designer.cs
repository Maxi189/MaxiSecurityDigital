
namespace ServicoPortaria.Presentation.Predio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucConsultar));
            this.Consultar = new ServicoPortaria.Presentation.Predio.ucConsultar();
            this.mnsPresentation = new System.Windows.Forms.MenuStrip();
            this.tsmCondominio = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmPredio = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmMorador = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmApartamento = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmVisitante = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmVeiculo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmPrestadorServicos = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSindico = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmHomePage = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmVisita = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsCondominio = new System.Windows.Forms.MenuStrip();
            this.lblClose = new System.Windows.Forms.Label();
            this.lblPredio = new System.Windows.Forms.Label();
            this.lblCondominio = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCondominio = new System.Windows.Forms.TextBox();
            this.nudNumero = new System.Windows.Forms.NumericUpDown();
            this.groupInformacao = new System.Windows.Forms.GroupBox();
            this.groupConsulta = new System.Windows.Forms.GroupBox();
            this.btnConsulta = new System.Windows.Forms.Button();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.groupInformacoesCarregadas = new System.Windows.Forms.GroupBox();
            this.lblCodigoCondominio = new System.Windows.Forms.Label();
            this.mnsPresentation.SuspendLayout();
            this.mnsCondominio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumero)).BeginInit();
            this.groupInformacao.SuspendLayout();
            this.groupConsulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.groupInformacoesCarregadas.SuspendLayout();
            this.SuspendLayout();
            // 
            // Consultar
            // 
            this.Consultar.Location = new System.Drawing.Point(0, 0);
            this.Consultar.Name = "Consultar";
            this.Consultar.Size = new System.Drawing.Size(150, 150);
            this.Consultar.TabIndex = 0;
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
            this.mnsCondominio.TabIndex = 53;
            this.mnsCondominio.Text = "Condomínio";
            // 
            // tsmCondomínio
            // 
            this.tsmCondominio.ForeColor = System.Drawing.Color.White;
            this.tsmCondominio.Name = "tsmCondominio";
            this.tsmCondominio.Size = new System.Drawing.Size(131, 20);
            this.tsmCondominio.Text = "Condomínio";
            this.tsmCondominio.Click += new System.EventHandler(tsmCondominio_Click);
            // 
            // tsmPredio
            // 
            this.tsmPredio.Enabled = false;
            this.tsmPredio.ForeColor = System.Drawing.Color.White;
            this.tsmPredio.Name = "tsmPredio";
            this.tsmPredio.Size = new System.Drawing.Size(133, 20);
            this.tsmPredio.Text = "Prédio";
            // 
            // tsmMorador
            // 
            this.tsmMorador.ForeColor = System.Drawing.Color.White;
            this.tsmMorador.Name = "tsmMorador";
            this.tsmMorador.Size = new System.Drawing.Size(125, 20);
            this.tsmMorador.Text = "Morador";
            this.tsmMorador.Click += new System.EventHandler(tsmMorador_Click);
            // 
            // tsmApartamento
            // 
            this.tsmApartamento.ForeColor = System.Drawing.Color.White;
            this.tsmApartamento.Name = "tsmApartamento";
            this.tsmApartamento.Size = new System.Drawing.Size(125, 20);
            this.tsmApartamento.Text = "Apartamento";
            this.tsmApartamento.Click += new System.EventHandler(tsmApartamento_Click);
            // 
            // tsmVisitante
            // 
            this.tsmVisitante.ForeColor = System.Drawing.Color.White;
            this.tsmVisitante.Name = "tsmVisitante";
            this.tsmVisitante.Size = new System.Drawing.Size(125, 20);
            this.tsmVisitante.Text = "Visitante";
            this.tsmVisitante.Click += new System.EventHandler(tsmVisitante_Click);
            // 
            // tsmVeiculo
            // 
            this.tsmVeiculo.ForeColor = System.Drawing.Color.White;
            this.tsmVeiculo.Name = "tsmVeiculo";
            this.tsmVisitante.Size = new System.Drawing.Size(125, 20);
            this.tsmVisitante.Text = "Veículo";
            this.tsmVisitante.Click += new System.EventHandler(tsmVisitante_Click);
            // 
            // tsmPrestadorServicos
            // 
            this.tsmPrestadorServicos.ForeColor = System.Drawing.Color.White;
            this.tsmPrestadorServicos.Name = "tsmPrestadorServicos";
            this.tsmPrestadorServicos.Size = new System.Drawing.Size(125, 20);
            this.tsmPrestadorServicos.Text = "Prestador de Serviços";
            this.tsmPrestadorServicos.Click += new System.EventHandler(tsmPrestadorServicos_Click);
            // 
            // tsmSindico
            // 
            this.tsmSindico.ForeColor = System.Drawing.Color.White;
            this.tsmSindico.Name = "tsmSindico";
            this.tsmSindico.Size = new System.Drawing.Size(125, 20);
            this.tsmSindico.Text = "Síndico";
            this.tsmSindico.Click += new System.EventHandler(tsmSindico_Click);
            // 
            // tsmVisita
            // 
            this.tsmVisita.ForeColor = System.Drawing.Color.White;
            this.tsmVisita.Name = "tsmSindico";
            this.tsmVisita.Size = new System.Drawing.Size(125, 20);
            this.tsmVisita.Text = "Síndico";
            this.tsmVisita.Click += new System.EventHandler(tsmVisita_Click);
            // 
            // lblClose
            // 
            this.lblClose.BackColor = System.Drawing.Color.Red;
            this.lblClose.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblClose.ForeColor = System.Drawing.Color.White;
            this.lblClose.Location = new System.Drawing.Point(1345, 0);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(25, 25);
            this.lblClose.TabIndex = 62;
            this.lblClose.Text = "X";
            this.lblClose.Click += new System.EventHandler(lblClose_Click);
            // 
            // lblPredio
            // 
            this.lblPredio.AutoSize = true;
            this.lblPredio.Location = new System.Drawing.Point(27, 42);
            this.lblPredio.Name = "lblPredio";
            this.lblPredio.Size = new System.Drawing.Size(94, 15);
            this.lblPredio.TabIndex = 63;
            this.lblPredio.Text = "Nome do Prédio";
            // 
            // lblCondominio
            // 
            this.lblCondominio.AutoSize = true;
            this.lblCondominio.Location = new System.Drawing.Point(27, 149);
            this.lblCondominio.Name = "lblCondominio";
            this.lblCondominio.Size = new System.Drawing.Size(127, 15);
            this.lblCondominio.TabIndex = 64;
            this.lblCondominio.Text = "Nome do Condomínio";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(27, 98);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(51, 15);
            this.lblNumero.TabIndex = 65;
            this.lblNumero.Text = "Número";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(155, 39);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(212, 23);
            this.txtNome.TabIndex = 66;
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            // 
            // txtCondominio
            // 
            this.txtCondominio.Location = new System.Drawing.Point(155, 146);
            this.txtCondominio.Name = "txtCondominio";
            this.txtCondominio.Size = new System.Drawing.Size(212, 23);
            this.txtCondominio.TabIndex = 67;
            this.txtCondominio.TextChanged += new System.EventHandler(this.txtCondominio_TextChanged);
            // 
            // nudNumero
            // 
            this.nudNumero.Location = new System.Drawing.Point(155, 96);
            this.nudNumero.Name = "nudNumero";
            this.nudNumero.Size = new System.Drawing.Size(212, 23);
            this.nudNumero.TabIndex = 68;
            this.nudNumero.ValueChanged += new System.EventHandler(this.nudNumero_ValueChanged);
            // 
            // groupInformacao
            // 
            this.groupInformacao.Controls.Add(this.nudNumero);
            this.groupInformacao.Controls.Add(this.txtCondominio);
            this.groupInformacao.Controls.Add(this.txtNome);
            this.groupInformacao.Controls.Add(this.lblNumero);
            this.groupInformacao.Controls.Add(this.lblCondominio);
            this.groupInformacao.Controls.Add(this.lblPredio);
            this.groupInformacao.Location = new System.Drawing.Point(264, 162);
            this.groupInformacao.Name = "groupInformacao";
            this.groupInformacao.Size = new System.Drawing.Size(391, 195);
            this.groupInformacao.TabIndex = 69;
            this.groupInformacao.TabStop = false;
            this.groupInformacao.Text = "Informações";
            // 
            // groupConsulta
            // 
            this.groupConsulta.Controls.Add(this.btnConsulta);
            this.groupConsulta.Location = new System.Drawing.Point(962, 162);
            this.groupConsulta.Name = "groupConsulta";
            this.groupConsulta.Size = new System.Drawing.Size(301, 195);
            this.groupConsulta.TabIndex = 70;
            this.groupConsulta.TabStop = false;
            this.groupConsulta.Text = "Consultar";
            // 
            // btnConsulta
            // 
            this.btnConsulta.BackColor = System.Drawing.Color.Black;
            this.btnConsulta.ForeColor = System.Drawing.Color.White;
            this.btnConsulta.Location = new System.Drawing.Point(35, 51);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(239, 83);
            this.btnConsulta.TabIndex = 0;
            this.btnConsulta.Text = "Consultar";
            this.btnConsulta.UseVisualStyleBackColor = false;
            this.btnConsulta.Click += new System.EventHandler(btnConsulta_Click);
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToAddRows = false;
            this.dgvData.AllowUserToDeleteRows = false;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Location = new System.Drawing.Point(503, 384);
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            this.dgvData.RowTemplate.Height = 25;
            this.dgvData.Size = new System.Drawing.Size(445, 264);
            this.dgvData.TabIndex = 71;
            // 
            // groupInformacoesCarregadas
            // 
            this.groupInformacoesCarregadas.Controls.Add(this.lblCodigoCondominio);
            this.groupInformacoesCarregadas.Location = new System.Drawing.Point(672, 162);
            this.groupInformacoesCarregadas.Name = "groupInformacoesCarregadas";
            this.groupInformacoesCarregadas.Size = new System.Drawing.Size(276, 194);
            this.groupInformacoesCarregadas.TabIndex = 72;
            this.groupInformacoesCarregadas.TabStop = false;
            this.groupInformacoesCarregadas.Text = "Informações Carregadas";
            // 
            // lblCodigoCondominio
            // 
            this.lblCodigoCondominio.AutoSize = true;
            this.lblCodigoCondominio.Location = new System.Drawing.Point(69, 149);
            this.lblCodigoCondominio.Name = "lblCodigoCondominio";
            this.lblCodigoCondominio.Size = new System.Drawing.Size(133, 15);
            this.lblCodigoCondominio.TabIndex = 0;
            this.lblCodigoCondominio.Text = "Código do Condomínio";
            // 
            // ucConsultar
            // 
            this.Controls.Add(this.groupInformacoesCarregadas);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.groupConsulta);
            this.Controls.Add(this.groupInformacao);
            this.Controls.Add(this.lblClose);
            this.Controls.Add(this.mnsCondominio);
            this.Controls.Add(this.mnsPresentation);
            this.Name = "ucConsultar";
            this.Size = new System.Drawing.Size(1370, 800);
            this.mnsPresentation.ResumeLayout(false);
            this.mnsPresentation.PerformLayout();
            this.mnsCondominio.ResumeLayout(false);
            this.mnsCondominio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumero)).EndInit();
            this.groupInformacao.ResumeLayout(false);
            this.groupInformacao.PerformLayout();
            this.groupConsulta.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.groupInformacoesCarregadas.ResumeLayout(false);
            this.groupInformacoesCarregadas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ucConsultar Consultar;
        private System.Windows.Forms.MenuStrip mnsPresentation;
        private System.Windows.Forms.ToolStripMenuItem tsmCondominio;
        private System.Windows.Forms.ToolStripMenuItem tsmPredio;
        private System.Windows.Forms.ToolStripMenuItem tsmMorador;
        private System.Windows.Forms.ToolStripMenuItem tsmApartamento;
        private System.Windows.Forms.ToolStripMenuItem tsmVisitante;
        private System.Windows.Forms.ToolStripMenuItem tsmGaragem;
        private System.Windows.Forms.ToolStripMenuItem tsmVeiculo;
        private System.Windows.Forms.ToolStripMenuItem tsmPrestadorServicos;
        private System.Windows.Forms.ToolStripMenuItem tsmSindico;
        private System.Windows.Forms.ToolStripMenuItem tsmHomePage;
        private System.Windows.Forms.ToolStripMenuItem tsmVisita;
        private System.Windows.Forms.MenuStrip mnsCondominio;
        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.Label lblPredio;
        private System.Windows.Forms.Label lblCondominio;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCondominio;
        private System.Windows.Forms.NumericUpDown nudNumero;
        private System.Windows.Forms.GroupBox groupInformacao;
        private System.Windows.Forms.GroupBox groupConsulta;
        private System.Windows.Forms.Button btnConsulta;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.GroupBox groupInformacoesCarregadas;
        private System.Windows.Forms.Label lblCodigoCondominio;
    }
}
