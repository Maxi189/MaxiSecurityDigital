
namespace ServicoPortaria.Presentation.PrestadorDeServicos
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
            this.lblCondominio = new System.Windows.Forms.Label();
            this.lblPredio = new System.Windows.Forms.Label();
            this.lblCNPJ = new System.Windows.Forms.Label();
            this.lblCPF = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCondominio = new System.Windows.Forms.TextBox();
            this.txtPredio = new System.Windows.Forms.TextBox();
            this.mtxCPF = new System.Windows.Forms.MaskedTextBox();
            this.mtxCNPJ = new System.Windows.Forms.MaskedTextBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupInformacoes = new System.Windows.Forms.GroupBox();
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
            this.groupDataVisita = new System.Windows.Forms.GroupBox();
            this.dtpHoraSaida = new System.Windows.Forms.DateTimePicker();
            this.dtpHoraChegada = new System.Windows.Forms.DateTimePicker();
            this.dtpDataSaida = new System.Windows.Forms.DateTimePicker();
            this.dtpDataChegada = new System.Windows.Forms.DateTimePicker();
            this.lblHoraSaida = new System.Windows.Forms.Label();
            this.lblHoraChegada = new System.Windows.Forms.Label();
            this.lblDataSaida = new System.Windows.Forms.Label();
            this.lblDataChegada = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupInformacoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.mnsCondominio.SuspendLayout();
            this.groupDataVisita.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblClose
            // 
            this.lblClose.BackColor = System.Drawing.Color.Red;
            this.lblClose.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblClose.ForeColor = System.Drawing.Color.White;
            this.lblClose.Location = new System.Drawing.Point(1345, -1);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(25, 25);
            this.lblClose.TabIndex = 63;
            this.lblClose.Text = "X";
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(18, 30);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(40, 15);
            this.lblNome.TabIndex = 60;
            this.lblNome.Text = "Nome";
            // 
            // lblCondominio
            // 
            this.lblCondominio.AutoSize = true;
            this.lblCondominio.Location = new System.Drawing.Point(18, 146);
            this.lblCondominio.Name = "lblCondominio";
            this.lblCondominio.Size = new System.Drawing.Size(74, 15);
            this.lblCondominio.TabIndex = 61;
            this.lblCondominio.Text = "Condomínio";
            // 
            // lblPredio
            // 
            this.lblPredio.AutoSize = true;
            this.lblPredio.Location = new System.Drawing.Point(18, 117);
            this.lblPredio.Name = "lblPredio";
            this.lblPredio.Size = new System.Drawing.Size(41, 15);
            this.lblPredio.TabIndex = 62;
            this.lblPredio.Text = "Prédio";
            // 
            // lblCNPJ
            // 
            this.lblCNPJ.AutoSize = true;
            this.lblCNPJ.Location = new System.Drawing.Point(18, 88);
            this.lblCNPJ.Name = "lblCNPJ";
            this.lblCNPJ.Size = new System.Drawing.Size(34, 15);
            this.lblCNPJ.TabIndex = 63;
            this.lblCNPJ.Text = "CNPJ";
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Location = new System.Drawing.Point(18, 59);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(28, 15);
            this.lblCPF.TabIndex = 64;
            this.lblCPF.Text = "CPF";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(146, 27);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(240, 23);
            this.txtNome.TabIndex = 65;
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            // 
            // txtCondominio
            // 
            this.txtCondominio.Location = new System.Drawing.Point(146, 143);
            this.txtCondominio.Name = "txtCondominio";
            this.txtCondominio.Size = new System.Drawing.Size(240, 23);
            this.txtCondominio.TabIndex = 66;
            this.txtCondominio.TextChanged += new System.EventHandler(this.txtCondominio_TextChanged);
            // 
            // txtPredio
            // 
            this.txtPredio.Location = new System.Drawing.Point(146, 114);
            this.txtPredio.Name = "txtPredio";
            this.txtPredio.Size = new System.Drawing.Size(240, 23);
            this.txtPredio.TabIndex = 67;
            this.txtPredio.TextChanged += new System.EventHandler(this.txtPredio_TextChanged);
            // 
            // mtxCPF
            // 
            this.mtxCPF.Location = new System.Drawing.Point(146, 56);
            this.mtxCPF.Mask = "000.000.000-00";
            this.mtxCPF.Name = "mtxCPF";
            this.mtxCPF.Size = new System.Drawing.Size(240, 23);
            this.mtxCPF.TabIndex = 68;
            this.mtxCPF.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mtxCPF_MaskInputRejected);
            this.mtxCPF.TextChanged += new System.EventHandler(this.mtxCPF_TextChanged);
            // 
            // mtxCNPJ
            // 
            this.mtxCNPJ.Location = new System.Drawing.Point(146, 85);
            this.mtxCNPJ.Mask = "00.000.000/0000-00";
            this.mtxCNPJ.Name = "mtxCNPJ";
            this.mtxCNPJ.Size = new System.Drawing.Size(240, 23);
            this.mtxCNPJ.TabIndex = 69;
            this.mtxCNPJ.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mtxCNPJ_MaskInputRejected);
            this.mtxCNPJ.TextChanged += new System.EventHandler(this.mtxCNPJ_TextChanged);
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.Color.Black;
            this.btnConsultar.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnConsultar.ForeColor = System.Drawing.Color.White;
            this.btnConsultar.Location = new System.Drawing.Point(24, 34);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(261, 105);
            this.btnConsultar.TabIndex = 70;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnConsultar);
            this.groupBox1.Location = new System.Drawing.Point(966, 160);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(303, 179);
            this.groupBox1.TabIndex = 71;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Consultar";
            // 
            // groupInformacoes
            // 
            this.groupInformacoes.Controls.Add(this.mtxCNPJ);
            this.groupInformacoes.Controls.Add(this.mtxCPF);
            this.groupInformacoes.Controls.Add(this.txtPredio);
            this.groupInformacoes.Controls.Add(this.txtCondominio);
            this.groupInformacoes.Controls.Add(this.txtNome);
            this.groupInformacoes.Controls.Add(this.lblCPF);
            this.groupInformacoes.Controls.Add(this.lblCNPJ);
            this.groupInformacoes.Controls.Add(this.lblPredio);
            this.groupInformacoes.Controls.Add(this.lblCondominio);
            this.groupInformacoes.Controls.Add(this.lblNome);
            this.groupInformacoes.Location = new System.Drawing.Point(99, 160);
            this.groupInformacoes.Name = "groupInformacoes";
            this.groupInformacoes.Size = new System.Drawing.Size(392, 179);
            this.groupInformacoes.TabIndex = 72;
            this.groupInformacoes.TabStop = false;
            this.groupInformacoes.Text = "Informações";
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToAddRows = false;
            this.dgvData.AllowUserToDeleteRows = false;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Location = new System.Drawing.Point(485, 358);
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            this.dgvData.RowTemplate.Height = 25;
            this.dgvData.Size = new System.Drawing.Size(475, 280);
            this.dgvData.TabIndex = 73;
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
            // groupDataVisita
            // 
            this.groupDataVisita.Controls.Add(this.dtpHoraSaida);
            this.groupDataVisita.Controls.Add(this.dtpHoraChegada);
            this.groupDataVisita.Controls.Add(this.dtpDataSaida);
            this.groupDataVisita.Controls.Add(this.dtpDataChegada);
            this.groupDataVisita.Controls.Add(this.lblHoraSaida);
            this.groupDataVisita.Controls.Add(this.lblHoraChegada);
            this.groupDataVisita.Controls.Add(this.lblDataSaida);
            this.groupDataVisita.Controls.Add(this.lblDataChegada);
            this.groupDataVisita.Location = new System.Drawing.Point(507, 160);
            this.groupDataVisita.Name = "groupDataVisita";
            this.groupDataVisita.Size = new System.Drawing.Size(431, 178);
            this.groupDataVisita.TabIndex = 95;
            this.groupDataVisita.TabStop = false;
            this.groupDataVisita.Text = "Data da Visita";
            // 
            // dtpHoraSaida
            // 
            this.dtpHoraSaida.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHoraSaida.Location = new System.Drawing.Point(196, 114);
            this.dtpHoraSaida.Name = "dtpHoraSaida";
            this.dtpHoraSaida.Size = new System.Drawing.Size(118, 23);
            this.dtpHoraSaida.TabIndex = 7;
            this.dtpHoraSaida.ValueChanged += new System.EventHandler(this.dtpHoraSaida_ValueChanged);
            // 
            // dtpHoraChegada
            // 
            this.dtpHoraChegada.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHoraChegada.Location = new System.Drawing.Point(196, 85);
            this.dtpHoraChegada.Name = "dtpHoraChegada";
            this.dtpHoraChegada.Size = new System.Drawing.Size(118, 23);
            this.dtpHoraChegada.TabIndex = 6;
            this.dtpHoraChegada.ValueChanged += new System.EventHandler(this.dtpHoraChegada_ValueChanged);
            // 
            // dtpDataSaida
            // 
            this.dtpDataSaida.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataSaida.Location = new System.Drawing.Point(196, 56);
            this.dtpDataSaida.Name = "dtpDataSaida";
            this.dtpDataSaida.Size = new System.Drawing.Size(118, 23);
            this.dtpDataSaida.TabIndex = 5;
            this.dtpDataSaida.ValueChanged += new System.EventHandler(this.dtpDataSaida_ValueChanged);
            // 
            // dtpDataChegada
            // 
            this.dtpDataChegada.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataChegada.Location = new System.Drawing.Point(196, 27);
            this.dtpDataChegada.Name = "dtpDataChegada";
            this.dtpDataChegada.Size = new System.Drawing.Size(118, 23);
            this.dtpDataChegada.TabIndex = 4;
            this.dtpDataChegada.ValueChanged += new System.EventHandler(this.dtpDataChegada_ValueChanged);
            // 
            // lblHoraSaida
            // 
            this.lblHoraSaida.AutoSize = true;
            this.lblHoraSaida.Location = new System.Drawing.Point(48, 117);
            this.lblHoraSaida.Name = "lblHoraSaida";
            this.lblHoraSaida.Size = new System.Drawing.Size(80, 15);
            this.lblHoraSaida.TabIndex = 3;
            this.lblHoraSaida.Text = "Hora de Saída";
            // 
            // lblHoraChegada
            // 
            this.lblHoraChegada.AutoSize = true;
            this.lblHoraChegada.Location = new System.Drawing.Point(48, 88);
            this.lblHoraChegada.Name = "lblHoraChegada";
            this.lblHoraChegada.Size = new System.Drawing.Size(99, 15);
            this.lblHoraChegada.TabIndex = 2;
            this.lblHoraChegada.Text = "Hora de Chegada";
            // 
            // lblDataSaida
            // 
            this.lblDataSaida.AutoSize = true;
            this.lblDataSaida.Location = new System.Drawing.Point(48, 59);
            this.lblDataSaida.Name = "lblDataSaida";
            this.lblDataSaida.Size = new System.Drawing.Size(78, 15);
            this.lblDataSaida.TabIndex = 1;
            this.lblDataSaida.Text = "Data de Saída";
            // 
            // lblDataChegada
            // 
            this.lblDataChegada.AutoSize = true;
            this.lblDataChegada.Location = new System.Drawing.Point(48, 30);
            this.lblDataChegada.Name = "lblDataChegada";
            this.lblDataChegada.Size = new System.Drawing.Size(97, 15);
            this.lblDataChegada.TabIndex = 0;
            this.lblDataChegada.Text = "Data de Chegada";
            // 
            // ucConsultar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupDataVisita);
            this.Controls.Add(this.lblClose);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.groupInformacoes);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.mnsCondominio);
            this.Name = "ucConsultar";
            this.Size = new System.Drawing.Size(1370, 800);
            this.groupBox1.ResumeLayout(false);
            this.groupInformacoes.ResumeLayout(false);
            this.groupInformacoes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.mnsCondominio.ResumeLayout(false);
            this.mnsCondominio.PerformLayout();
            this.groupDataVisita.ResumeLayout(false);
            this.groupDataVisita.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblCondominio;
        private System.Windows.Forms.Label lblPredio;
        private System.Windows.Forms.Label lblCNPJ;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCondominio;
        private System.Windows.Forms.TextBox txtPredio;
        private System.Windows.Forms.MaskedTextBox mtxCPF;
        private System.Windows.Forms.MaskedTextBox mtxCNPJ;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupInformacoes;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.Label lbl;
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
        private System.Windows.Forms.GroupBox groupDataVisita;
        private System.Windows.Forms.DateTimePicker dtpHoraSaida;
        private System.Windows.Forms.DateTimePicker dtpHoraChegada;
        private System.Windows.Forms.DateTimePicker dtpDataSaida;
        private System.Windows.Forms.DateTimePicker dtpDataChegada;
        private System.Windows.Forms.Label lblHoraSaida;
        private System.Windows.Forms.Label lblHoraChegada;
        private System.Windows.Forms.Label lblDataSaida;
        private System.Windows.Forms.Label lblDataChegada;
    }
}
