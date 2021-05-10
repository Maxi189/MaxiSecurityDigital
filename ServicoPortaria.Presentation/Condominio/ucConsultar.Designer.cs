
namespace ServicoPortaria.Presentation.Condominio
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
            this.lblNome = new System.Windows.Forms.Label();
            this.lblCEP = new System.Windows.Forms.Label();
            this.lblCodPostal = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.mskCEP = new System.Windows.Forms.MaskedTextBox();
            this.txtCodPostal = new System.Windows.Forms.TextBox();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.lblCidade = new System.Windows.Forms.Label();
            this.nudNumero = new System.Windows.Forms.NumericUpDown();
            this.btnPesquisar = new System.Windows.Forms.Button();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumero)).BeginInit();
            this.mnsCondominio.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblClose
            // 
            this.lblClose.AutoSize = true;
            this.lblClose.BackColor = System.Drawing.Color.Red;
            this.lblClose.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblClose.ForeColor = System.Drawing.Color.White;
            this.lblClose.Location = new System.Drawing.Point(1346, 0);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(24, 25);
            this.lblClose.TabIndex = 46;
            this.lblClose.Text = "X";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(605, 92);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(40, 15);
            this.lblNome.TabIndex = 47;
            this.lblNome.Text = "Nome";
            // 
            // lblCEP
            // 
            this.lblCEP.AutoSize = true;
            this.lblCEP.Location = new System.Drawing.Point(605, 130);
            this.lblCEP.Name = "lblCEP";
            this.lblCEP.Size = new System.Drawing.Size(28, 15);
            this.lblCEP.TabIndex = 48;
            this.lblCEP.Text = "CEP";
            // 
            // lblCodPostal
            // 
            this.lblCodPostal.AutoSize = true;
            this.lblCodPostal.Location = new System.Drawing.Point(605, 179);
            this.lblCodPostal.Name = "lblCodPostal";
            this.lblCodPostal.Size = new System.Drawing.Size(81, 15);
            this.lblCodPostal.TabIndex = 49;
            this.lblCodPostal.Text = "Código Postal";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(605, 227);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(51, 15);
            this.lblNumero.TabIndex = 50;
            this.lblNumero.Text = "Número";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(845, 89);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(179, 23);
            this.txtNome.TabIndex = 51;
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            // 
            // mskCEP
            // 
            this.mskCEP.Location = new System.Drawing.Point(845, 127);
            this.mskCEP.Mask = "00000-000";
            this.mskCEP.Name = "mskCEP";
            this.mskCEP.Size = new System.Drawing.Size(179, 23);
            this.mskCEP.TabIndex = 52;
            this.mskCEP.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mskCEP_MaskInputRejected);
            // 
            // txtCodPostal
            // 
            this.txtCodPostal.Location = new System.Drawing.Point(845, 176);
            this.txtCodPostal.Name = "txtCodPostal";
            this.txtCodPostal.Size = new System.Drawing.Size(179, 23);
            this.txtCodPostal.TabIndex = 53;
            this.txtCodPostal.TextChanged += new System.EventHandler(this.txtCodPostal_TextChanged);
            // 
            // dgvData
            // 
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Location = new System.Drawing.Point(604, 337);
            this.dgvData.Name = "dgvData";
            this.dgvData.RowTemplate.Height = 25;
            this.dgvData.Size = new System.Drawing.Size(420, 306);
            this.dgvData.TabIndex = 55;
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(845, 270);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(179, 23);
            this.txtCidade.TabIndex = 57;
            this.txtCidade.TextChanged += new System.EventHandler(this.txtCidade_TextChanged);
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Location = new System.Drawing.Point(605, 273);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(44, 15);
            this.lblCidade.TabIndex = 56;
            this.lblCidade.Text = "Cidade";
            // 
            // nudNumero
            // 
            this.nudNumero.Location = new System.Drawing.Point(845, 225);
            this.nudNumero.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.nudNumero.Name = "nudNumero";
            this.nudNumero.Size = new System.Drawing.Size(179, 23);
            this.nudNumero.TabIndex = 58;
            this.nudNumero.ValueChanged += new System.EventHandler(this.nudNumero_ValueChanged);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnPesquisar.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPesquisar.ForeColor = System.Drawing.Color.White;
            this.btnPesquisar.Location = new System.Drawing.Point(1119, 116);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(177, 67);
            this.btnPesquisar.TabIndex = 59;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = false;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
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
            this.mnsCondominio.TabIndex = 86;
            this.mnsCondominio.Text = "Condomínio";
            this.mnsCondominio.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.mnsCondominio_ItemClicked);
            // 
            // tsmCondomínio
            // 
            this.tsmCondomínio.Enabled = false;
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
            this.tsmApartamento.ForeColor = System.Drawing.Color.White;
            this.tsmApartamento.Name = "tsmApartamento";
            this.tsmApartamento.Size = new System.Drawing.Size(89, 20);
            this.tsmApartamento.Text = "Apartamento";
            this.tsmApartamento.Click += new System.EventHandler(tsmApartamento_Click);
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
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.nudNumero);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.lblCidade);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.txtCodPostal);
            this.Controls.Add(this.mskCEP);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.lblCodPostal);
            this.Controls.Add(this.lblCEP);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblClose);
            this.Controls.Add(this.mnsCondominio);
            this.Name = "ucConsultar";
            this.Size = new System.Drawing.Size(1370, 800);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumero)).EndInit();
            this.mnsCondominio.ResumeLayout(false);
            this.mnsCondominio.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblCEP;
        private System.Windows.Forms.Label lblCodPostal;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.MaskedTextBox mskCEP;
        private System.Windows.Forms.TextBox txtCodPostal;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.NumericUpDown nudNumero;
        private System.Windows.Forms.Button btnPesquisar;
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
