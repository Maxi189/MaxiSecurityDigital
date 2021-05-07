
namespace ServicoPortaria.Presentation.Visita
{
    partial class ucInserir
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
            this.lblIdApartamento = new System.Windows.Forms.Label();
            this.lblMorador = new System.Windows.Forms.Label();
            this.lblCondominio = new System.Windows.Forms.Label();
            this.lblPredio = new System.Windows.Forms.Label();
            this.lblCPFVisitante = new System.Windows.Forms.Label();
            this.mtxCPFMorador = new System.Windows.Forms.MaskedTextBox();
            this.txtCondominio = new System.Windows.Forms.TextBox();
            this.txtPredio = new System.Windows.Forms.TextBox();
            this.lblIdMorador = new System.Windows.Forms.Label();
            this.lblIdCondominio = new System.Windows.Forms.Label();
            this.lblIdPredio = new System.Windows.Forms.Label();
            this.lblIdVisitante = new System.Windows.Forms.Label();
            this.mtxCPFVisitante = new System.Windows.Forms.MaskedTextBox();
            this.groupInfo = new System.Windows.Forms.GroupBox();
            this.lblDataChegada = new System.Windows.Forms.Label();
            this.lblDataSaida = new System.Windows.Forms.Label();
            this.lblHoraChegada = new System.Windows.Forms.Label();
            this.lblHoraSaida = new System.Windows.Forms.Label();
            this.dtpHoraChegada = new System.Windows.Forms.DateTimePicker();
            this.dtpDataChegada = new System.Windows.Forms.DateTimePicker();
            this.dtpDataSaida = new System.Windows.Forms.DateTimePicker();
            this.dtpHoraSaida = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupCadastrar = new System.Windows.Forms.GroupBox();
            this.btnCadastrarVisita = new System.Windows.Forms.Button();
            this.mnsCondominio = new System.Windows.Forms.MenuStrip();
            this.tsmCondomínio = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmPredio = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmMorador = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmApartamento = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmVisitante = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmGaragem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmVeiculo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmPrestadorDeServicos = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSindico = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmHomePage = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmVisita = new System.Windows.Forms.ToolStripMenuItem();
            this.lblClose = new System.Windows.Forms.Label();
            this.nudNumeroApartamento = new System.Windows.Forms.NumericUpDown();
            this.lblNumeroApartamento = new System.Windows.Forms.Label();
            this.groupInfo.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupCadastrar.SuspendLayout();
            this.mnsCondominio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumeroApartamento)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIdApartamento
            // 
            this.lblIdApartamento.AutoSize = true;
            this.lblIdApartamento.Location = new System.Drawing.Point(544, 24);
            this.lblIdApartamento.Name = "lblIdApartamento";
            this.lblIdApartamento.Size = new System.Drawing.Size(136, 15);
            this.lblIdApartamento.TabIndex = 56;
            this.lblIdApartamento.Text = "Código do Apartamento";
            // 
            // lblMorador
            // 
            this.lblMorador.AutoSize = true;
            this.lblMorador.Location = new System.Drawing.Point(0, 66);
            this.lblMorador.Name = "lblMorador";
            this.lblMorador.Size = new System.Drawing.Size(94, 15);
            this.lblMorador.TabIndex = 57;
            this.lblMorador.Text = "CPF do Morador";
            // 
            // lblCondominio
            // 
            this.lblCondominio.AutoSize = true;
            this.lblCondominio.Location = new System.Drawing.Point(0, 109);
            this.lblCondominio.Name = "lblCondominio";
            this.lblCondominio.Size = new System.Drawing.Size(127, 15);
            this.lblCondominio.TabIndex = 58;
            this.lblCondominio.Text = "Nome do Condomínio";
            // 
            // lblPredio
            // 
            this.lblPredio.AutoSize = true;
            this.lblPredio.Location = new System.Drawing.Point(0, 152);
            this.lblPredio.Name = "lblPredio";
            this.lblPredio.Size = new System.Drawing.Size(94, 15);
            this.lblPredio.TabIndex = 59;
            this.lblPredio.Text = "Nome do Prédio";
            // 
            // lblCPFVisitante
            // 
            this.lblCPFVisitante.AutoSize = true;
            this.lblCPFVisitante.Location = new System.Drawing.Point(0, 198);
            this.lblCPFVisitante.Name = "lblCPFVisitante";
            this.lblCPFVisitante.Size = new System.Drawing.Size(93, 15);
            this.lblCPFVisitante.TabIndex = 60;
            this.lblCPFVisitante.Text = "CPF do Visitante";
            // 
            // mtxCPFMorador
            // 
            this.mtxCPFMorador.Location = new System.Drawing.Point(230, 63);
            this.mtxCPFMorador.Mask = "000.000.000-00";
            this.mtxCPFMorador.Name = "mtxCPFMorador";
            this.mtxCPFMorador.Size = new System.Drawing.Size(190, 23);
            this.mtxCPFMorador.TabIndex = 61;
            // 
            // txtCondominio
            // 
            this.txtCondominio.Location = new System.Drawing.Point(230, 106);
            this.txtCondominio.Name = "txtCondominio";
            this.txtCondominio.Size = new System.Drawing.Size(190, 23);
            this.txtCondominio.TabIndex = 62;
            // 
            // txtPredio
            // 
            this.txtPredio.Location = new System.Drawing.Point(230, 149);
            this.txtPredio.Name = "txtPredio";
            this.txtPredio.Size = new System.Drawing.Size(190, 23);
            this.txtPredio.TabIndex = 63;
            // 
            // lblIdMorador
            // 
            this.lblIdMorador.AutoSize = true;
            this.lblIdMorador.Location = new System.Drawing.Point(544, 66);
            this.lblIdMorador.Name = "lblIdMorador";
            this.lblIdMorador.Size = new System.Drawing.Size(112, 15);
            this.lblIdMorador.TabIndex = 65;
            this.lblIdMorador.Text = "Código do Morador";
            // 
            // lblIdCondominio
            // 
            this.lblIdCondominio.AutoSize = true;
            this.lblIdCondominio.Location = new System.Drawing.Point(1022, 232);
            this.lblIdCondominio.Name = "lblIdCondominio";
            this.lblIdCondominio.Size = new System.Drawing.Size(133, 15);
            this.lblIdCondominio.TabIndex = 66;
            this.lblIdCondominio.Text = "Código do Condomínio";
            // 
            // lblIdPredio
            // 
            this.lblIdPredio.AutoSize = true;
            this.lblIdPredio.Location = new System.Drawing.Point(544, 152);
            this.lblIdPredio.Name = "lblIdPredio";
            this.lblIdPredio.Size = new System.Drawing.Size(100, 15);
            this.lblIdPredio.TabIndex = 67;
            this.lblIdPredio.Text = "Código do Prédio";
            // 
            // lblIdVisitante
            // 
            this.lblIdVisitante.AutoSize = true;
            this.lblIdVisitante.Location = new System.Drawing.Point(544, 198);
            this.lblIdVisitante.Name = "lblIdVisitante";
            this.lblIdVisitante.Size = new System.Drawing.Size(111, 15);
            this.lblIdVisitante.TabIndex = 68;
            this.lblIdVisitante.Text = "Código do Visitante";
            // 
            // mtxCPFVisitante
            // 
            this.mtxCPFVisitante.Location = new System.Drawing.Point(230, 195);
            this.mtxCPFVisitante.Mask = "000.000.000-00";
            this.mtxCPFVisitante.Name = "mtxCPFVisitante";
            this.mtxCPFVisitante.Size = new System.Drawing.Size(190, 23);
            this.mtxCPFVisitante.TabIndex = 69;
            // 
            // groupInfo
            // 
            this.groupInfo.Controls.Add(this.lblNumeroApartamento);
            this.groupInfo.Controls.Add(this.nudNumeroApartamento);
            this.groupInfo.Controls.Add(this.mtxCPFVisitante);
            this.groupInfo.Controls.Add(this.lblIdVisitante);
            this.groupInfo.Controls.Add(this.lblIdPredio);
            this.groupInfo.Controls.Add(this.lblIdMorador);
            this.groupInfo.Controls.Add(this.txtPredio);
            this.groupInfo.Controls.Add(this.txtCondominio);
            this.groupInfo.Controls.Add(this.mtxCPFMorador);
            this.groupInfo.Controls.Add(this.lblCPFVisitante);
            this.groupInfo.Controls.Add(this.lblPredio);
            this.groupInfo.Controls.Add(this.lblCondominio);
            this.groupInfo.Controls.Add(this.lblMorador);
            this.groupInfo.Controls.Add(this.lblIdApartamento);
            this.groupInfo.Location = new System.Drawing.Point(478, 123);
            this.groupInfo.Name = "groupInfo";
            this.groupInfo.Size = new System.Drawing.Size(689, 235);
            this.groupInfo.TabIndex = 70;
            this.groupInfo.TabStop = false;
            this.groupInfo.Text = "Informações do Apartamento";
            // 
            // lblDataChegada
            // 
            this.lblDataChegada.AutoSize = true;
            this.lblDataChegada.Location = new System.Drawing.Point(0, 14);
            this.lblDataChegada.Name = "lblDataChegada";
            this.lblDataChegada.Size = new System.Drawing.Size(98, 15);
            this.lblDataChegada.TabIndex = 71;
            this.lblDataChegada.Text = "Data De Chegada";
            // 
            // lblDataSaida
            // 
            this.lblDataSaida.AutoSize = true;
            this.lblDataSaida.Location = new System.Drawing.Point(0, 57);
            this.lblDataSaida.Name = "lblDataSaida";
            this.lblDataSaida.Size = new System.Drawing.Size(78, 15);
            this.lblDataSaida.TabIndex = 72;
            this.lblDataSaida.Text = "Data de Saída";
            // 
            // lblHoraChegada
            // 
            this.lblHoraChegada.AutoSize = true;
            this.lblHoraChegada.Location = new System.Drawing.Point(0, 102);
            this.lblHoraChegada.Name = "lblHoraChegada";
            this.lblHoraChegada.Size = new System.Drawing.Size(99, 15);
            this.lblHoraChegada.TabIndex = 73;
            this.lblHoraChegada.Text = "Hora de Chegada";
            // 
            // lblHoraSaida
            // 
            this.lblHoraSaida.AutoSize = true;
            this.lblHoraSaida.Location = new System.Drawing.Point(0, 146);
            this.lblHoraSaida.Name = "lblHoraSaida";
            this.lblHoraSaida.Size = new System.Drawing.Size(80, 15);
            this.lblHoraSaida.TabIndex = 74;
            this.lblHoraSaida.Text = "Hora de Saída";
            // 
            // dtpHoraChegada
            // 
            this.dtpHoraChegada.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHoraChegada.Location = new System.Drawing.Point(230, 96);
            this.dtpHoraChegada.Name = "dtpHoraChegada";
            this.dtpHoraChegada.Size = new System.Drawing.Size(190, 23);
            this.dtpHoraChegada.TabIndex = 75;
            // 
            // dtpDataChegada
            // 
            this.dtpDataChegada.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataChegada.Location = new System.Drawing.Point(230, 8);
            this.dtpDataChegada.Name = "dtpDataChegada";
            this.dtpDataChegada.Size = new System.Drawing.Size(190, 23);
            this.dtpDataChegada.TabIndex = 76;
            // 
            // dtpDataSaida
            // 
            this.dtpDataSaida.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataSaida.Location = new System.Drawing.Point(230, 51);
            this.dtpDataSaida.Name = "dtpDataSaida";
            this.dtpDataSaida.Size = new System.Drawing.Size(190, 23);
            this.dtpDataSaida.TabIndex = 77;
            // 
            // dtpHoraSaida
            // 
            this.dtpHoraSaida.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHoraSaida.Location = new System.Drawing.Point(230, 140);
            this.dtpHoraSaida.Name = "dtpHoraSaida";
            this.dtpHoraSaida.Size = new System.Drawing.Size(190, 23);
            this.dtpHoraSaida.TabIndex = 78;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpHoraSaida);
            this.groupBox1.Controls.Add(this.dtpDataSaida);
            this.groupBox1.Controls.Add(this.dtpDataChegada);
            this.groupBox1.Controls.Add(this.dtpHoraChegada);
            this.groupBox1.Controls.Add(this.lblHoraSaida);
            this.groupBox1.Controls.Add(this.lblHoraChegada);
            this.groupBox1.Controls.Add(this.lblDataSaida);
            this.groupBox1.Controls.Add(this.lblDataChegada);
            this.groupBox1.Location = new System.Drawing.Point(478, 367);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(445, 182);
            this.groupBox1.TabIndex = 79;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data da Visita";
            // 
            // groupCadastrar
            // 
            this.groupCadastrar.Controls.Add(this.btnCadastrarVisita);
            this.groupCadastrar.Location = new System.Drawing.Point(478, 555);
            this.groupCadastrar.Name = "groupCadastrar";
            this.groupCadastrar.Size = new System.Drawing.Size(440, 97);
            this.groupCadastrar.TabIndex = 80;
            this.groupCadastrar.TabStop = false;
            this.groupCadastrar.Text = "Cadastrar";
            // 
            // btnCadastrarVisita
            // 
            this.btnCadastrarVisita.BackColor = System.Drawing.Color.Black;
            this.btnCadastrarVisita.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCadastrarVisita.ForeColor = System.Drawing.Color.White;
            this.btnCadastrarVisita.Location = new System.Drawing.Point(67, 25);
            this.btnCadastrarVisita.Name = "btnCadastrarVisita";
            this.btnCadastrarVisita.Size = new System.Drawing.Size(301, 59);
            this.btnCadastrarVisita.TabIndex = 0;
            this.btnCadastrarVisita.Text = "Cadastrar Visita";
            this.btnCadastrarVisita.UseVisualStyleBackColor = false;
            this.btnCadastrarVisita.Click += new System.EventHandler(this.btnCadastrarVisita_Click);
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
            this.tsmGaragem,
            this.tsmVeiculo,
            this.tsmPrestadorDeServicos,
            this.tsmSindico,
            this.tsmHomePage,
            this.tsmVisita});
            this.mnsCondominio.Location = new System.Drawing.Point(0, 0);
            this.mnsCondominio.Name = "mnsCondominio";
            this.mnsCondominio.Size = new System.Drawing.Size(1388, 24);
            this.mnsCondominio.TabIndex = 94;
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
            // tsmGaragem
            // 
            this.tsmGaragem.ForeColor = System.Drawing.Color.White;
            this.tsmGaragem.Name = "tsmGaragem";
            this.tsmGaragem.Size = new System.Drawing.Size(67, 20);
            this.tsmGaragem.Text = "Garagem";
            this.tsmGaragem.Click += new System.EventHandler(tsmGaragem_Click);
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
            this.tsmSindico.Enabled = false;
            this.tsmSindico.ForeColor = System.Drawing.Color.White;
            this.tsmSindico.Name = "tsmSindico";
            this.tsmSindico.Size = new System.Drawing.Size(58, 20);
            this.tsmSindico.Text = "Síndico";
            this.tsmSindico.Click += new System.EventHandler(tsmPrestadorDeServicos_Click);
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
            this.tsmVisita.Enabled = false;
            this.tsmVisita.ForeColor = System.Drawing.Color.White;
            this.tsmVisita.Name = "tsmVisita";
            this.tsmVisita.Size = new System.Drawing.Size(47, 20);
            this.tsmVisita.Text = "Visita";
            // 
            // lblClose
            // 
            this.lblClose.BackColor = System.Drawing.Color.Red;
            this.lblClose.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblClose.ForeColor = System.Drawing.Color.White;
            this.lblClose.Location = new System.Drawing.Point(1363, 0);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(25, 25);
            this.lblClose.TabIndex = 95;
            this.lblClose.Text = "X";
            this.lblClose.Click += new System.EventHandler(lblClose_Click);
            // 
            // nudNumeroApartamento
            // 
            this.nudNumeroApartamento.Location = new System.Drawing.Point(230, 22);
            this.nudNumeroApartamento.Name = "nudNumeroApartamento";
            this.nudNumeroApartamento.Size = new System.Drawing.Size(190, 23);
            this.nudNumeroApartamento.TabIndex = 70;
            // 
            // lblNumeroApartamento
            // 
            this.lblNumeroApartamento.AutoSize = true;
            this.lblNumeroApartamento.Location = new System.Drawing.Point(0, 24);
            this.lblNumeroApartamento.Name = "lblNumeroApartamento";
            this.lblNumeroApartamento.Size = new System.Drawing.Size(141, 15);
            this.lblNumeroApartamento.TabIndex = 71;
            this.lblNumeroApartamento.Text = "Número do Apartamento";
            // 
            // ucInserir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblClose);
            this.Controls.Add(this.mnsCondominio);
            this.Controls.Add(this.groupCadastrar);
            this.Controls.Add(this.lblIdCondominio);
            this.Controls.Add(this.groupInfo);
            this.Controls.Add(this.groupBox1);
            this.Name = "ucInserir";
            this.Size = new System.Drawing.Size(1388, 800);
            this.groupInfo.ResumeLayout(false);
            this.groupInfo.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupCadastrar.ResumeLayout(false);
            this.mnsCondominio.ResumeLayout(false);
            this.mnsCondominio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumeroApartamento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblIdApartamento;
        private System.Windows.Forms.Label lblMorador;
        private System.Windows.Forms.Label lblCondominio;
        private System.Windows.Forms.Label lblPredio;
        private System.Windows.Forms.Label lblCPFVisitante;
        private System.Windows.Forms.MaskedTextBox mtxCPFMorador;
        private System.Windows.Forms.TextBox txtCondominio;
        private System.Windows.Forms.TextBox txtPredio;
        private System.Windows.Forms.Label lblIdMorador;
        private System.Windows.Forms.Label lblIdCondominio;
        private System.Windows.Forms.Label lblIdPredio;
        private System.Windows.Forms.Label lblIdVisitante;
        private System.Windows.Forms.MaskedTextBox mtxCPFVisitante;
        private System.Windows.Forms.GroupBox groupInfo;
        private System.Windows.Forms.Label lblDataChegada;
        private System.Windows.Forms.Label lblDataSaida;
        private System.Windows.Forms.Label lblHoraChegada;
        private System.Windows.Forms.Label lblHoraSaida;
        private System.Windows.Forms.DateTimePicker dtpHoraChegada;
        private System.Windows.Forms.DateTimePicker dtpDataChegada;
        private System.Windows.Forms.DateTimePicker dtpDataSaida;
        private System.Windows.Forms.DateTimePicker dtpHoraSaida;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupCadastrar;
        private System.Windows.Forms.Button btnCadastrarVisita;
        private System.Windows.Forms.MenuStrip mnsCondominio;
        private System.Windows.Forms.ToolStripMenuItem tsmCondomínio;
        private System.Windows.Forms.ToolStripMenuItem tsmPredio;
        private System.Windows.Forms.ToolStripMenuItem tsmMorador;
        private System.Windows.Forms.ToolStripMenuItem tsmApartamento;
        private System.Windows.Forms.ToolStripMenuItem tsmVisitante;
        private System.Windows.Forms.ToolStripMenuItem tsmGaragem;
        private System.Windows.Forms.ToolStripMenuItem tsmVeiculo;
        private System.Windows.Forms.ToolStripMenuItem tsmPrestadorDeServicos;
        private System.Windows.Forms.ToolStripMenuItem tsmSindico;
        private System.Windows.Forms.ToolStripMenuItem tsmHomePage;
        private System.Windows.Forms.ToolStripMenuItem tsmVisita;
        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.Label lblNumeroApartamento;
        private System.Windows.Forms.NumericUpDown nudNumeroApartamento;
    }
}
