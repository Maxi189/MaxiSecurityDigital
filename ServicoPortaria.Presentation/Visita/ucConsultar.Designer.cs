
namespace ServicoPortaria.Presentation.Visita
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
            this.lblCPFVisitante = new System.Windows.Forms.Label();
            this.lblIdApartamento = new System.Windows.Forms.Label();
            this.lblCodigoPredio = new System.Windows.Forms.Label();
            this.lblIdVisitante = new System.Windows.Forms.Label();
            this.lblNomeCondominio = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblNomePredio = new System.Windows.Forms.Label();
            this.lblIdCondominio = new System.Windows.Forms.Label();
            this.lblHoraSaida = new System.Windows.Forms.Label();
            this.lblDataChegada = new System.Windows.Forms.Label();
            this.lblDataSaida = new System.Windows.Forms.Label();
            this.lblHoraChegada = new System.Windows.Forms.Label();
            this.txtPredio = new System.Windows.Forms.TextBox();
            this.txtCondominio = new System.Windows.Forms.TextBox();
            this.dtpDataChegada = new System.Windows.Forms.DateTimePicker();
            this.dtpDataSaida = new System.Windows.Forms.DateTimePicker();
            this.dtpHoraSaida = new System.Windows.Forms.DateTimePicker();
            this.dtpHoraChegada = new System.Windows.Forms.DateTimePicker();
            this.groupDadosVisita = new System.Windows.Forms.GroupBox();
            this.mtxCPF = new System.Windows.Forms.MaskedTextBox();
            this.groupDate = new System.Windows.Forms.GroupBox();
            this.groupCodigo = new System.Windows.Forms.GroupBox();
            this.groupConsultar = new System.Windows.Forms.GroupBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.nudNumero = new System.Windows.Forms.NumericUpDown();
            this.groupDadosVisita.SuspendLayout();
            this.groupDate.SuspendLayout();
            this.groupCodigo.SuspendLayout();
            this.groupConsultar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumero)).BeginInit();
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
            // 
            // lblCPFVisitante
            // 
            this.lblCPFVisitante.AutoSize = true;
            this.lblCPFVisitante.Location = new System.Drawing.Point(32, 28);
            this.lblCPFVisitante.Name = "lblCPFVisitante";
            this.lblCPFVisitante.Size = new System.Drawing.Size(93, 15);
            this.lblCPFVisitante.TabIndex = 65;
            this.lblCPFVisitante.Text = "CPF do Visitante";
            // 
            // lblIdApartamento
            // 
            this.lblIdApartamento.AutoSize = true;
            this.lblIdApartamento.Location = new System.Drawing.Point(74, 109);
            this.lblIdApartamento.Name = "lblIdApartamento";
            this.lblIdApartamento.Size = new System.Drawing.Size(136, 15);
            this.lblIdApartamento.TabIndex = 66;
            this.lblIdApartamento.Text = "Código do Apartamento";
            // 
            // lblCodigoPredio
            // 
            this.lblCodigoPredio.AutoSize = true;
            this.lblCodigoPredio.Location = new System.Drawing.Point(74, 66);
            this.lblCodigoPredio.Name = "lblCodigoPredio";
            this.lblCodigoPredio.Size = new System.Drawing.Size(100, 15);
            this.lblCodigoPredio.TabIndex = 67;
            this.lblCodigoPredio.Text = "Código do Prédio";
            // 
            // lblIdVisitante
            // 
            this.lblIdVisitante.AutoSize = true;
            this.lblIdVisitante.Location = new System.Drawing.Point(74, 28);
            this.lblIdVisitante.Name = "lblIdVisitante";
            this.lblIdVisitante.Size = new System.Drawing.Size(111, 15);
            this.lblIdVisitante.TabIndex = 68;
            this.lblIdVisitante.Text = "Código do Visitante";
            // 
            // lblNomeCondominio
            // 
            this.lblNomeCondominio.AutoSize = true;
            this.lblNomeCondominio.Location = new System.Drawing.Point(32, 157);
            this.lblNomeCondominio.Name = "lblNomeCondominio";
            this.lblNomeCondominio.Size = new System.Drawing.Size(127, 15);
            this.lblNomeCondominio.TabIndex = 69;
            this.lblNomeCondominio.Text = "Nome do Condomínio";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 15);
            this.label6.TabIndex = 70;
            this.label6.Text = "Número do Apartamento";
            // 
            // lblNomePredio
            // 
            this.lblNomePredio.AutoSize = true;
            this.lblNomePredio.Location = new System.Drawing.Point(32, 71);
            this.lblNomePredio.Name = "lblNomePredio";
            this.lblNomePredio.Size = new System.Drawing.Size(94, 15);
            this.lblNomePredio.TabIndex = 71;
            this.lblNomePredio.Text = "Nome do Prédio";
            // 
            // lblIdCondominio
            // 
            this.lblIdCondominio.AutoSize = true;
            this.lblIdCondominio.Location = new System.Drawing.Point(74, 152);
            this.lblIdCondominio.Name = "lblIdCondominio";
            this.lblIdCondominio.Size = new System.Drawing.Size(133, 15);
            this.lblIdCondominio.TabIndex = 72;
            this.lblIdCondominio.Text = "Código do Condomínio";
            // 
            // lblHoraSaida
            // 
            this.lblHoraSaida.AutoSize = true;
            this.lblHoraSaida.Location = new System.Drawing.Point(32, 132);
            this.lblHoraSaida.Name = "lblHoraSaida";
            this.lblHoraSaida.Size = new System.Drawing.Size(80, 15);
            this.lblHoraSaida.TabIndex = 76;
            this.lblHoraSaida.Text = "Hora de Saída";
            // 
            // lblDataChegada
            // 
            this.lblDataChegada.AutoSize = true;
            this.lblDataChegada.Location = new System.Drawing.Point(32, 19);
            this.lblDataChegada.Name = "lblDataChegada";
            this.lblDataChegada.Size = new System.Drawing.Size(97, 15);
            this.lblDataChegada.TabIndex = 75;
            this.lblDataChegada.Text = "Data de Chegada";
            // 
            // lblDataSaida
            // 
            this.lblDataSaida.AutoSize = true;
            this.lblDataSaida.Location = new System.Drawing.Point(32, 56);
            this.lblDataSaida.Name = "lblDataSaida";
            this.lblDataSaida.Size = new System.Drawing.Size(78, 15);
            this.lblDataSaida.TabIndex = 74;
            this.lblDataSaida.Text = "Data de Saída";
            // 
            // lblHoraChegada
            // 
            this.lblHoraChegada.AutoSize = true;
            this.lblHoraChegada.Location = new System.Drawing.Point(32, 93);
            this.lblHoraChegada.Name = "lblHoraChegada";
            this.lblHoraChegada.Size = new System.Drawing.Size(99, 15);
            this.lblHoraChegada.TabIndex = 73;
            this.lblHoraChegada.Text = "Hora de Chegada";
            // 
            // txtPredio
            // 
            this.txtPredio.Location = new System.Drawing.Point(193, 63);
            this.txtPredio.Name = "txtPredio";
            this.txtPredio.Size = new System.Drawing.Size(236, 23);
            this.txtPredio.TabIndex = 78;
            this.txtPredio.TextChanged += new System.EventHandler(this.txtPredio_TextChanged);
            // 
            // txtCondominio
            // 
            this.txtCondominio.Location = new System.Drawing.Point(193, 149);
            this.txtCondominio.Name = "txtCondominio";
            this.txtCondominio.Size = new System.Drawing.Size(236, 23);
            this.txtCondominio.TabIndex = 80;
            this.txtCondominio.TextChanged += new System.EventHandler(this.txtCondominio_TextChanged);
            // 
            // dtpDataChegada
            // 
            this.dtpDataChegada.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataChegada.Location = new System.Drawing.Point(193, 15);
            this.dtpDataChegada.Name = "dtpDataChegada";
            this.dtpDataChegada.Size = new System.Drawing.Size(104, 23);
            this.dtpDataChegada.TabIndex = 81;
            this.dtpDataChegada.ValueChanged += new System.EventHandler(this.dtpDataChegada_ValueChanged);
            // 
            // dtpDataSaida
            // 
            this.dtpDataSaida.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataSaida.Location = new System.Drawing.Point(193, 50);
            this.dtpDataSaida.Name = "dtpDataSaida";
            this.dtpDataSaida.Size = new System.Drawing.Size(104, 23);
            this.dtpDataSaida.TabIndex = 82;
            this.dtpDataSaida.ValueChanged += new System.EventHandler(this.dtpDataSaida_ValueChanged);
            // 
            // dtpHoraSaida
            // 
            this.dtpHoraSaida.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHoraSaida.Location = new System.Drawing.Point(193, 126);
            this.dtpHoraSaida.Name = "dtpHoraSaida";
            this.dtpHoraSaida.Size = new System.Drawing.Size(104, 23);
            this.dtpHoraSaida.TabIndex = 84;
            this.dtpHoraSaida.ValueChanged += new System.EventHandler(this.dtpHoraSaida_ValueChanged);
            // 
            // dtpHoraChegada
            // 
            this.dtpHoraChegada.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHoraChegada.Location = new System.Drawing.Point(193, 87);
            this.dtpHoraChegada.Name = "dtpHoraChegada";
            this.dtpHoraChegada.Size = new System.Drawing.Size(104, 23);
            this.dtpHoraChegada.TabIndex = 83;
            this.dtpHoraChegada.ValueChanged += new System.EventHandler(this.dtpHoraChegada_ValueChanged);
            // 
            // groupDadosVisita
            // 
            this.groupDadosVisita.Controls.Add(this.nudNumero);
            this.groupDadosVisita.Controls.Add(this.mtxCPF);
            this.groupDadosVisita.Controls.Add(this.txtCondominio);
            this.groupDadosVisita.Controls.Add(this.txtPredio);
            this.groupDadosVisita.Controls.Add(this.lblNomePredio);
            this.groupDadosVisita.Controls.Add(this.label6);
            this.groupDadosVisita.Controls.Add(this.lblNomeCondominio);
            this.groupDadosVisita.Controls.Add(this.lblCPFVisitante);
            this.groupDadosVisita.Location = new System.Drawing.Point(240, 135);
            this.groupDadosVisita.Name = "groupDadosVisita";
            this.groupDadosVisita.Size = new System.Drawing.Size(435, 185);
            this.groupDadosVisita.TabIndex = 85;
            this.groupDadosVisita.TabStop = false;
            this.groupDadosVisita.Text = "Dados da Visita";
            // 
            // mtxCPF
            // 
            this.mtxCPF.Location = new System.Drawing.Point(193, 25);
            this.mtxCPF.Mask = "000.000.000-00";
            this.mtxCPF.Name = "mtxCPF";
            this.mtxCPF.Size = new System.Drawing.Size(236, 23);
            this.mtxCPF.TabIndex = 81;
            this.mtxCPF.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mtxCPF_MaskInputRejected);
            this.mtxCPF.TextChanged += new System.EventHandler(this.mtxCPF_TextChanged);
            // 
            // groupDate
            // 
            this.groupDate.Controls.Add(this.dtpHoraSaida);
            this.groupDate.Controls.Add(this.dtpHoraChegada);
            this.groupDate.Controls.Add(this.dtpDataSaida);
            this.groupDate.Controls.Add(this.dtpDataChegada);
            this.groupDate.Controls.Add(this.lblHoraSaida);
            this.groupDate.Controls.Add(this.lblDataChegada);
            this.groupDate.Controls.Add(this.lblDataSaida);
            this.groupDate.Controls.Add(this.lblHoraChegada);
            this.groupDate.Location = new System.Drawing.Point(240, 324);
            this.groupDate.Name = "groupDate";
            this.groupDate.Size = new System.Drawing.Size(435, 167);
            this.groupDate.TabIndex = 86;
            this.groupDate.TabStop = false;
            this.groupDate.Text = "Data de Chegada";
            // 
            // groupCodigo
            // 
            this.groupCodigo.Controls.Add(this.lblIdCondominio);
            this.groupCodigo.Controls.Add(this.lblIdVisitante);
            this.groupCodigo.Controls.Add(this.lblCodigoPredio);
            this.groupCodigo.Controls.Add(this.lblIdApartamento);
            this.groupCodigo.Location = new System.Drawing.Point(785, 135);
            this.groupCodigo.Name = "groupCodigo";
            this.groupCodigo.Size = new System.Drawing.Size(249, 184);
            this.groupCodigo.TabIndex = 87;
            this.groupCodigo.TabStop = false;
            this.groupCodigo.Text = "Código";
            // 
            // groupConsultar
            // 
            this.groupConsultar.Controls.Add(this.btnConsultar);
            this.groupConsultar.Location = new System.Drawing.Point(785, 332);
            this.groupConsultar.Name = "groupConsultar";
            this.groupConsultar.Size = new System.Drawing.Size(248, 159);
            this.groupConsultar.TabIndex = 88;
            this.groupConsultar.TabStop = false;
            this.groupConsultar.Text = "Consultar";
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.Color.Black;
            this.btnConsultar.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnConsultar.ForeColor = System.Drawing.Color.White;
            this.btnConsultar.Location = new System.Drawing.Point(39, 46);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(164, 78);
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
            this.dgvData.Location = new System.Drawing.Point(466, 510);
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            this.dgvData.Size = new System.Drawing.Size(466, 248);
            this.dgvData.TabIndex = 89;
            // 
            // nudNumero
            // 
            this.nudNumero.Location = new System.Drawing.Point(193, 107);
            this.nudNumero.Name = "nudNumero";
            this.nudNumero.Size = new System.Drawing.Size(236, 23);
            this.nudNumero.TabIndex = 82;
            this.nudNumero.ValueChanged += new System.EventHandler(this.nudNumero_ValueChanged);
            // 
            // ucConsultar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.groupConsultar);
            this.Controls.Add(this.groupCodigo);
            this.Controls.Add(this.groupDate);
            this.Controls.Add(this.groupDadosVisita);
            this.Controls.Add(this.lblClose);
            this.Name = "ucConsultar";
            this.Size = new System.Drawing.Size(1370, 800);
            this.groupDadosVisita.ResumeLayout(false);
            this.groupDadosVisita.PerformLayout();
            this.groupDate.ResumeLayout(false);
            this.groupDate.PerformLayout();
            this.groupCodigo.ResumeLayout(false);
            this.groupCodigo.PerformLayout();
            this.groupConsultar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumero)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.Label lblCPFVisitante;
        private System.Windows.Forms.Label lblIdApartamento;
        private System.Windows.Forms.Label lblCodigoPredio;
        private System.Windows.Forms.Label lblIdVisitante;
        private System.Windows.Forms.Label lblNomeCondominio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblNomePredio;
        private System.Windows.Forms.Label lblIdCondominio;
        private System.Windows.Forms.Label lblHoraSaida;
        private System.Windows.Forms.Label lblDataChegada;
        private System.Windows.Forms.Label lblDataSaida;
        private System.Windows.Forms.Label lblHoraChegada;
        private System.Windows.Forms.TextBox txtPredio;
        private System.Windows.Forms.TextBox txtCondominio;
        private System.Windows.Forms.DateTimePicker dtpDataChegada;
        private System.Windows.Forms.DateTimePicker dtpDataSaida;
        private System.Windows.Forms.DateTimePicker dtpHoraSaida;
        private System.Windows.Forms.DateTimePicker dtpHoraChegada;
        private System.Windows.Forms.GroupBox groupDadosVisita;
        private System.Windows.Forms.GroupBox groupDate;
        private System.Windows.Forms.GroupBox groupCodigo;
        private System.Windows.Forms.GroupBox groupConsultar;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.MaskedTextBox mtxCPF;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.NumericUpDown nudNumero;
    }
}
