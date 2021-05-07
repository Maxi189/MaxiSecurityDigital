
namespace ServicoPortaria.Presentation.PrestadorDeServicos
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
            this.lblNome = new System.Windows.Forms.Label();
            this.lblCNPJ = new System.Windows.Forms.Label();
            this.lblCPF = new System.Windows.Forms.Label();
            this.lblPredio = new System.Windows.Forms.Label();
            this.lblCondominio = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.mtxCNPJ = new System.Windows.Forms.MaskedTextBox();
            this.mtxCPF = new System.Windows.Forms.MaskedTextBox();
            this.txtNomePredio = new System.Windows.Forms.TextBox();
            this.txtCondominio = new System.Windows.Forms.TextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.lblIdPredio = new System.Windows.Forms.Label();
            this.lblIdCondominio = new System.Windows.Forms.Label();
            this.lblClose = new System.Windows.Forms.Label();
            this.lblDataChegada = new System.Windows.Forms.Label();
            this.lblDataSaida = new System.Windows.Forms.Label();
            this.lblHoraChegada = new System.Windows.Forms.Label();
            this.lblHoraDaSaida = new System.Windows.Forms.Label();
            this.groupDocumentacao = new System.Windows.Forms.GroupBox();
            this.groupVisita = new System.Windows.Forms.GroupBox();
            this.dtpHoraSaida = new System.Windows.Forms.DateTimePicker();
            this.dtpHoraChegada = new System.Windows.Forms.DateTimePicker();
            this.dtpDataSaida = new System.Windows.Forms.DateTimePicker();
            this.dtpDataChegada = new System.Windows.Forms.DateTimePicker();
            this.groupInformacoes = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
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
            this.groupDocumentacao.SuspendLayout();
            this.groupVisita.SuspendLayout();
            this.groupInformacoes.SuspendLayout();
            this.mnsCondominio.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(15, 20);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(40, 15);
            this.lblNome.TabIndex = 55;
            this.lblNome.Text = "Nome";
            // 
            // lblCNPJ
            // 
            this.lblCNPJ.AutoSize = true;
            this.lblCNPJ.Location = new System.Drawing.Point(15, 60);
            this.lblCNPJ.Name = "lblCNPJ";
            this.lblCNPJ.Size = new System.Drawing.Size(34, 15);
            this.lblCNPJ.TabIndex = 56;
            this.lblCNPJ.Text = "CNPJ";
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Location = new System.Drawing.Point(15, 100);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(28, 15);
            this.lblCPF.TabIndex = 57;
            this.lblCPF.Text = "CPF";
            // 
            // lblPredio
            // 
            this.lblPredio.AutoSize = true;
            this.lblPredio.Location = new System.Drawing.Point(18, 26);
            this.lblPredio.Name = "lblPredio";
            this.lblPredio.Size = new System.Drawing.Size(94, 15);
            this.lblPredio.TabIndex = 58;
            this.lblPredio.Text = "Nome do Prédio";
            // 
            // lblCondominio
            // 
            this.lblCondominio.AutoSize = true;
            this.lblCondominio.Location = new System.Drawing.Point(18, 80);
            this.lblCondominio.Name = "lblCondominio";
            this.lblCondominio.Size = new System.Drawing.Size(74, 15);
            this.lblCondominio.TabIndex = 59;
            this.lblCondominio.Text = "Condomínio";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(132, 17);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(218, 23);
            this.txtNome.TabIndex = 60;
            // 
            // mtxCNPJ
            // 
            this.mtxCNPJ.Location = new System.Drawing.Point(132, 57);
            this.mtxCNPJ.Mask = "00.000.000/0000-00";
            this.mtxCNPJ.Name = "mtxCNPJ";
            this.mtxCNPJ.Size = new System.Drawing.Size(218, 23);
            this.mtxCNPJ.TabIndex = 61;
            // 
            // mtxCPF
            // 
            this.mtxCPF.Location = new System.Drawing.Point(132, 97);
            this.mtxCPF.Mask = "000.000.000-00";
            this.mtxCPF.Name = "mtxCPF";
            this.mtxCPF.Size = new System.Drawing.Size(218, 23);
            this.mtxCPF.TabIndex = 62;
            // 
            // txtNomePredio
            // 
            this.txtNomePredio.Location = new System.Drawing.Point(132, 23);
            this.txtNomePredio.Name = "txtNomePredio";
            this.txtNomePredio.Size = new System.Drawing.Size(218, 23);
            this.txtNomePredio.TabIndex = 63;
            // 
            // txtCondominio
            // 
            this.txtCondominio.Location = new System.Drawing.Point(132, 77);
            this.txtCondominio.Name = "txtCondominio";
            this.txtCondominio.Size = new System.Drawing.Size(218, 23);
            this.txtCondominio.TabIndex = 64;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.Black;
            this.btnCadastrar.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCadastrar.ForeColor = System.Drawing.Color.White;
            this.btnCadastrar.Location = new System.Drawing.Point(610, 608);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(267, 69);
            this.btnCadastrar.TabIndex = 65;
            this.btnCadastrar.Text = "Cadastrar Prestador";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // lblIdPredio
            // 
            this.lblIdPredio.AutoSize = true;
            this.lblIdPredio.Location = new System.Drawing.Point(365, 26);
            this.lblIdPredio.Name = "lblIdPredio";
            this.lblIdPredio.Size = new System.Drawing.Size(100, 15);
            this.lblIdPredio.TabIndex = 66;
            this.lblIdPredio.Text = "Código do Prédio";
            // 
            // lblIdCondominio
            // 
            this.lblIdCondominio.AutoSize = true;
            this.lblIdCondominio.Location = new System.Drawing.Point(365, 80);
            this.lblIdCondominio.Name = "lblIdCondominio";
            this.lblIdCondominio.Size = new System.Drawing.Size(133, 15);
            this.lblIdCondominio.TabIndex = 67;
            this.lblIdCondominio.Text = "Código do Condomínio";
            // 
            // lblClose
            // 
            this.lblClose.BackColor = System.Drawing.Color.Red;
            this.lblClose.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblClose.ForeColor = System.Drawing.Color.White;
            this.lblClose.Location = new System.Drawing.Point(1345, 0);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(25, 25);
            this.lblClose.TabIndex = 69;
            this.lblClose.Text = "X";
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            // 
            // lblDataChegada
            // 
            this.lblDataChegada.AutoSize = true;
            this.lblDataChegada.Location = new System.Drawing.Point(18, 19);
            this.lblDataChegada.Name = "lblDataChegada";
            this.lblDataChegada.Size = new System.Drawing.Size(97, 15);
            this.lblDataChegada.TabIndex = 70;
            this.lblDataChegada.Text = "Data da Chegada";
            // 
            // lblDataSaida
            // 
            this.lblDataSaida.AutoSize = true;
            this.lblDataSaida.Location = new System.Drawing.Point(18, 53);
            this.lblDataSaida.Name = "lblDataSaida";
            this.lblDataSaida.Size = new System.Drawing.Size(78, 15);
            this.lblDataSaida.TabIndex = 71;
            this.lblDataSaida.Text = "Data da Saída";
            // 
            // lblHoraChegada
            // 
            this.lblHoraChegada.AutoSize = true;
            this.lblHoraChegada.Location = new System.Drawing.Point(18, 93);
            this.lblHoraChegada.Name = "lblHoraChegada";
            this.lblHoraChegada.Size = new System.Drawing.Size(99, 15);
            this.lblHoraChegada.TabIndex = 72;
            this.lblHoraChegada.Text = "Hora da Chegada";
            // 
            // lblHoraDaSaida
            // 
            this.lblHoraDaSaida.AutoSize = true;
            this.lblHoraDaSaida.Location = new System.Drawing.Point(18, 129);
            this.lblHoraDaSaida.Name = "lblHoraDaSaida";
            this.lblHoraDaSaida.Size = new System.Drawing.Size(80, 15);
            this.lblHoraDaSaida.TabIndex = 73;
            this.lblHoraDaSaida.Text = "Hora da Saída";
            // 
            // groupDocumentacao
            // 
            this.groupDocumentacao.Controls.Add(this.mtxCPF);
            this.groupDocumentacao.Controls.Add(this.mtxCNPJ);
            this.groupDocumentacao.Controls.Add(this.txtNome);
            this.groupDocumentacao.Controls.Add(this.lblCPF);
            this.groupDocumentacao.Controls.Add(this.lblCNPJ);
            this.groupDocumentacao.Controls.Add(this.lblNome);
            this.groupDocumentacao.Location = new System.Drawing.Point(489, 162);
            this.groupDocumentacao.Name = "groupDocumentacao";
            this.groupDocumentacao.Size = new System.Drawing.Size(515, 142);
            this.groupDocumentacao.TabIndex = 74;
            this.groupDocumentacao.TabStop = false;
            this.groupDocumentacao.Text = "Documentação";
            // 
            // groupVisita
            // 
            this.groupVisita.Controls.Add(this.dtpHoraSaida);
            this.groupVisita.Controls.Add(this.dtpHoraChegada);
            this.groupVisita.Controls.Add(this.dtpDataSaida);
            this.groupVisita.Controls.Add(this.dtpDataChegada);
            this.groupVisita.Controls.Add(this.lblHoraDaSaida);
            this.groupVisita.Controls.Add(this.lblHoraChegada);
            this.groupVisita.Controls.Add(this.lblDataSaida);
            this.groupVisita.Controls.Add(this.lblDataChegada);
            this.groupVisita.Location = new System.Drawing.Point(489, 310);
            this.groupVisita.Name = "groupVisita";
            this.groupVisita.Size = new System.Drawing.Size(515, 160);
            this.groupVisita.TabIndex = 75;
            this.groupVisita.TabStop = false;
            this.groupVisita.Text = "Visita";
            // 
            // dtpHoraSaida
            // 
            this.dtpHoraSaida.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHoraSaida.Location = new System.Drawing.Point(132, 123);
            this.dtpHoraSaida.Name = "dtpHoraSaida";
            this.dtpHoraSaida.Size = new System.Drawing.Size(218, 23);
            this.dtpHoraSaida.TabIndex = 77;
            // 
            // dtpHoraChegada
            // 
            this.dtpHoraChegada.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHoraChegada.Location = new System.Drawing.Point(132, 87);
            this.dtpHoraChegada.Name = "dtpHoraChegada";
            this.dtpHoraChegada.Size = new System.Drawing.Size(218, 23);
            this.dtpHoraChegada.TabIndex = 76;
            // 
            // dtpDataSaida
            // 
            this.dtpDataSaida.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataSaida.Location = new System.Drawing.Point(132, 47);
            this.dtpDataSaida.Name = "dtpDataSaida";
            this.dtpDataSaida.Size = new System.Drawing.Size(218, 23);
            this.dtpDataSaida.TabIndex = 75;
            // 
            // dtpDataChegada
            // 
            this.dtpDataChegada.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataChegada.Location = new System.Drawing.Point(132, 13);
            this.dtpDataChegada.Name = "dtpDataChegada";
            this.dtpDataChegada.Size = new System.Drawing.Size(218, 23);
            this.dtpDataChegada.TabIndex = 74;
            // 
            // groupInformacoes
            // 
            this.groupInformacoes.Controls.Add(this.lblIdCondominio);
            this.groupInformacoes.Controls.Add(this.lblIdPredio);
            this.groupInformacoes.Controls.Add(this.txtNomePredio);
            this.groupInformacoes.Controls.Add(this.lblCondominio);
            this.groupInformacoes.Controls.Add(this.txtCondominio);
            this.groupInformacoes.Controls.Add(this.lblPredio);
            this.groupInformacoes.Location = new System.Drawing.Point(489, 476);
            this.groupInformacoes.Name = "groupInformacoes";
            this.groupInformacoes.Size = new System.Drawing.Size(515, 115);
            this.groupInformacoes.TabIndex = 76;
            this.groupInformacoes.TabStop = false;
            this.groupInformacoes.Text = "Informações";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 15);
            this.label2.TabIndex = 71;
            this.label2.Text = "Data da Saída";
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
            this.mnsCondominio.Size = new System.Drawing.Size(1370, 24);
            this.mnsCondominio.TabIndex = 92;
            this.mnsCondominio.Text = "Condomínio";
            // 
            // tsmCondomínio
            // 
            this.tsmCondomínio.ForeColor = System.Drawing.Color.White;
            this.tsmCondomínio.Name = "tsmCondomínio";
            this.tsmCondomínio.Size = new System.Drawing.Size(86, 20);
            this.tsmCondomínio.Text = "Condomínio";
            this.tsmCondomínio.Click += new System.EventHandler(this.tsmCondominio_Click);
            // 
            // tsmPredio
            // 
            this.tsmPredio.ForeColor = System.Drawing.Color.White;
            this.tsmPredio.Name = "tsmPredio";
            this.tsmPredio.Size = new System.Drawing.Size(53, 20);
            this.tsmPredio.Text = "Prédio";
            this.tsmPredio.Click += new System.EventHandler(this.tsmPredio_Click);
            // 
            // tsmMorador
            // 
            this.tsmMorador.ForeColor = System.Drawing.Color.White;
            this.tsmMorador.Name = "tsmMorador";
            this.tsmMorador.Size = new System.Drawing.Size(65, 20);
            this.tsmMorador.Text = "Morador";
            this.tsmMorador.Click += new System.EventHandler(this.tsmMorador_Click);
            // 
            // tsmApartamento
            // 
            this.tsmApartamento.ForeColor = System.Drawing.Color.White;
            this.tsmApartamento.Name = "tsmApartamento";
            this.tsmApartamento.Size = new System.Drawing.Size(89, 20);
            this.tsmApartamento.Text = "Apartamento";
            this.tsmApartamento.Click += new System.EventHandler(this.tsmApartamento_Click);
            // 
            // tsmVisitante
            // 
            this.tsmVisitante.ForeColor = System.Drawing.Color.White;
            this.tsmVisitante.Name = "tsmVisitante";
            this.tsmVisitante.Size = new System.Drawing.Size(64, 20);
            this.tsmVisitante.Text = "Visitante";
            this.tsmVisitante.Click += new System.EventHandler(this.tsmVisitante_Click);
            // 
            // tsmGaragem
            // 
            this.tsmGaragem.ForeColor = System.Drawing.Color.White;
            this.tsmGaragem.Name = "tsmGaragem";
            this.tsmGaragem.Size = new System.Drawing.Size(67, 20);
            this.tsmGaragem.Text = "Garagem";
            this.tsmGaragem.Click += new System.EventHandler(this.tsmGaragem_Click);
            // 
            // tsmVeiculo
            // 
            this.tsmVeiculo.ForeColor = System.Drawing.Color.White;
            this.tsmVeiculo.Name = "tsmVeiculo";
            this.tsmVeiculo.Size = new System.Drawing.Size(57, 20);
            this.tsmVeiculo.Text = "Veículo";
            this.tsmVeiculo.Click += new System.EventHandler(this.tsmVeiculo_Click);
            // 
            // tsmPrestadorDeServicos
            // 
            this.tsmPrestadorDeServicos.Enabled = false;
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
            this.tsmSindico.Click += new System.EventHandler(this.tsmSindico_Click);
            // 
            // tsmHomePage
            // 
            this.tsmHomePage.ForeColor = System.Drawing.Color.White;
            this.tsmHomePage.Name = "tsmHomePage";
            this.tsmHomePage.Size = new System.Drawing.Size(81, 20);
            this.tsmHomePage.Text = "Home Page";
            this.tsmHomePage.Click += new System.EventHandler(this.tsmHomePage_Click);
            // 
            // tsmVisita
            // 
            this.tsmVisita.ForeColor = System.Drawing.Color.White;
            this.tsmVisita.Name = "tsmVisita";
            this.tsmVisita.Size = new System.Drawing.Size(47, 20);
            this.tsmVisita.Text = "Visita";
            this.tsmVisita.Click += new System.EventHandler(this.tsmVisita_Click);
            // 
            // ucInserir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupVisita);
            this.Controls.Add(this.groupDocumentacao);
            this.Controls.Add(this.lblClose);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.groupInformacoes);
            this.Controls.Add(this.mnsCondominio);
            this.Name = "ucInserir";
            this.Size = new System.Drawing.Size(1370, 800);
            this.groupDocumentacao.ResumeLayout(false);
            this.groupDocumentacao.PerformLayout();
            this.groupVisita.ResumeLayout(false);
            this.groupVisita.PerformLayout();
            this.groupInformacoes.ResumeLayout(false);
            this.groupInformacoes.PerformLayout();
            this.mnsCondominio.ResumeLayout(false);
            this.mnsCondominio.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblCNPJ;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.Label lblPredio;
        private System.Windows.Forms.Label lblCondominio;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.MaskedTextBox mtxCNPJ;
        private System.Windows.Forms.MaskedTextBox mtxCPF;
        private System.Windows.Forms.TextBox txtNomePredio;
        private System.Windows.Forms.TextBox txtCondominio;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label lblIdPredio;
        private System.Windows.Forms.Label lblIdCondominio;
        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.Label lblDataChegada;
        private System.Windows.Forms.Label lblDataSaida;
        private System.Windows.Forms.Label lblHoraChegada;
        private System.Windows.Forms.Label lblHoraDaSaida;
        private System.Windows.Forms.GroupBox groupDocumentacao;
        private System.Windows.Forms.GroupBox groupVisita;
        private System.Windows.Forms.GroupBox groupInformacoes;
        private System.Windows.Forms.DateTimePicker dtpHoraSaida;
        private System.Windows.Forms.DateTimePicker dtpHoraChegada;
        private System.Windows.Forms.DateTimePicker dtpDataSaida;
        private System.Windows.Forms.DateTimePicker dtpDataChegada;
        private System.Windows.Forms.Label label2;
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
    }
}
