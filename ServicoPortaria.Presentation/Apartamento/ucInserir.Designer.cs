
namespace ServicoPortaria.Presentation.Apartamento
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
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblRamal = new System.Windows.Forms.Label();
            this.lblBloco = new System.Windows.Forms.Label();
            this.nudNumero = new System.Windows.Forms.NumericUpDown();
            this.txtBloco = new System.Windows.Forms.TextBox();
            this.txtRamal = new System.Windows.Forms.TextBox();
            this.groupLocal = new System.Windows.Forms.GroupBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblMorador = new System.Windows.Forms.Label();
            this.lblPredio = new System.Windows.Forms.Label();
            this.txtCondominio = new System.Windows.Forms.TextBox();
            this.txtPredio = new System.Windows.Forms.TextBox();
            this.mtxCPF = new System.Windows.Forms.MaskedTextBox();
            this.lblIdCondominio = new System.Windows.Forms.Label();
            this.lblIdPredio = new System.Windows.Forms.Label();
            this.lblIdMorador = new System.Windows.Forms.Label();
            this.groupApartamento = new System.Windows.Forms.GroupBox();
            this.groupInserir = new System.Windows.Forms.GroupBox();
            this.btnInserir = new System.Windows.Forms.Button();
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
            ((System.ComponentModel.ISupportInitialize)(this.nudNumero)).BeginInit();
            this.groupLocal.SuspendLayout();
            this.groupApartamento.SuspendLayout();
            this.groupInserir.SuspendLayout();
            this.mnsCondominio.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(8, 39);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(51, 15);
            this.lblNumero.TabIndex = 50;
            this.lblNumero.Text = "Número";
            // 
            // lblRamal
            // 
            this.lblRamal.AutoSize = true;
            this.lblRamal.Location = new System.Drawing.Point(8, 142);
            this.lblRamal.Name = "lblRamal";
            this.lblRamal.Size = new System.Drawing.Size(40, 15);
            this.lblRamal.TabIndex = 51;
            this.lblRamal.Text = "Ramal";
            // 
            // lblBloco
            // 
            this.lblBloco.AutoSize = true;
            this.lblBloco.Location = new System.Drawing.Point(8, 92);
            this.lblBloco.Name = "lblBloco";
            this.lblBloco.Size = new System.Drawing.Size(37, 15);
            this.lblBloco.TabIndex = 52;
            this.lblBloco.Text = "Bloco";
            // 
            // nudNumero
            // 
            this.nudNumero.Location = new System.Drawing.Point(139, 37);
            this.nudNumero.Name = "nudNumero";
            this.nudNumero.Size = new System.Drawing.Size(283, 23);
            this.nudNumero.TabIndex = 53;
            // 
            // txtBloco
            // 
            this.txtBloco.Location = new System.Drawing.Point(139, 89);
            this.txtBloco.Name = "txtBloco";
            this.txtBloco.Size = new System.Drawing.Size(283, 23);
            this.txtBloco.TabIndex = 54;
            // 
            // txtRamal
            // 
            this.txtRamal.Location = new System.Drawing.Point(139, 139);
            this.txtRamal.Name = "txtRamal";
            this.txtRamal.Size = new System.Drawing.Size(283, 23);
            this.txtRamal.TabIndex = 55;
            // 
            // groupLocal
            // 
            this.groupLocal.Controls.Add(this.txtRamal);
            this.groupLocal.Controls.Add(this.txtBloco);
            this.groupLocal.Controls.Add(this.nudNumero);
            this.groupLocal.Controls.Add(this.lblBloco);
            this.groupLocal.Controls.Add(this.lblRamal);
            this.groupLocal.Controls.Add(this.lblNumero);
            this.groupLocal.Location = new System.Drawing.Point(432, 163);
            this.groupLocal.Name = "groupLocal";
            this.groupLocal.Size = new System.Drawing.Size(428, 184);
            this.groupLocal.TabIndex = 56;
            this.groupLocal.TabStop = false;
            this.groupLocal.Text = "Local";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(8, 25);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(127, 15);
            this.lblNome.TabIndex = 57;
            this.lblNome.Text = "Nome do Condomínio";
            // 
            // lblMorador
            // 
            this.lblMorador.AutoSize = true;
            this.lblMorador.Location = new System.Drawing.Point(8, 136);
            this.lblMorador.Name = "lblMorador";
            this.lblMorador.Size = new System.Drawing.Size(94, 15);
            this.lblMorador.TabIndex = 58;
            this.lblMorador.Text = "CPF do Morador";
            // 
            // lblPredio
            // 
            this.lblPredio.AutoSize = true;
            this.lblPredio.Location = new System.Drawing.Point(8, 80);
            this.lblPredio.Name = "lblPredio";
            this.lblPredio.Size = new System.Drawing.Size(94, 15);
            this.lblPredio.TabIndex = 59;
            this.lblPredio.Text = "Nome do Prédio";
            // 
            // txtCondominio
            // 
            this.txtCondominio.Location = new System.Drawing.Point(139, 22);
            this.txtCondominio.Name = "txtCondominio";
            this.txtCondominio.Size = new System.Drawing.Size(283, 23);
            this.txtCondominio.TabIndex = 56;
            // 
            // txtPredio
            // 
            this.txtPredio.Location = new System.Drawing.Point(139, 77);
            this.txtPredio.Name = "txtPredio";
            this.txtPredio.Size = new System.Drawing.Size(283, 23);
            this.txtPredio.TabIndex = 60;
            // 
            // mtxCPF
            // 
            this.mtxCPF.Location = new System.Drawing.Point(139, 133);
            this.mtxCPF.Mask = "000.000.000-00";
            this.mtxCPF.Name = "mtxCPF";
            this.mtxCPF.Size = new System.Drawing.Size(283, 23);
            this.mtxCPF.TabIndex = 61;
            // 
            // lblIdCondominio
            // 
            this.lblIdCondominio.AutoSize = true;
            this.lblIdCondominio.Location = new System.Drawing.Point(491, 25);
            this.lblIdCondominio.Name = "lblIdCondominio";
            this.lblIdCondominio.Size = new System.Drawing.Size(119, 15);
            this.lblIdCondominio.TabIndex = 62;
            this.lblIdCondominio.Text = "Cod. do Condomínio";
            // 
            // lblIdPredio
            // 
            this.lblIdPredio.AutoSize = true;
            this.lblIdPredio.Location = new System.Drawing.Point(491, 80);
            this.lblIdPredio.Name = "lblIdPredio";
            this.lblIdPredio.Size = new System.Drawing.Size(86, 15);
            this.lblIdPredio.TabIndex = 63;
            this.lblIdPredio.Text = "Cod. do Prédio";
            // 
            // lblIdMorador
            // 
            this.lblIdMorador.AutoSize = true;
            this.lblIdMorador.Location = new System.Drawing.Point(491, 136);
            this.lblIdMorador.Name = "lblIdMorador";
            this.lblIdMorador.Size = new System.Drawing.Size(98, 15);
            this.lblIdMorador.TabIndex = 64;
            this.lblIdMorador.Text = "Cod. do Morador";
            // 
            // groupApartamento
            // 
            this.groupApartamento.Controls.Add(this.lblIdMorador);
            this.groupApartamento.Controls.Add(this.lblIdPredio);
            this.groupApartamento.Controls.Add(this.lblIdCondominio);
            this.groupApartamento.Controls.Add(this.mtxCPF);
            this.groupApartamento.Controls.Add(this.txtPredio);
            this.groupApartamento.Controls.Add(this.txtCondominio);
            this.groupApartamento.Controls.Add(this.lblPredio);
            this.groupApartamento.Controls.Add(this.lblMorador);
            this.groupApartamento.Controls.Add(this.lblNome);
            this.groupApartamento.Location = new System.Drawing.Point(366, 353);
            this.groupApartamento.Name = "groupApartamento";
            this.groupApartamento.Size = new System.Drawing.Size(632, 183);
            this.groupApartamento.TabIndex = 65;
            this.groupApartamento.TabStop = false;
            this.groupApartamento.Text = "Dados do Apartamento";
            // 
            // groupInserir
            // 
            this.groupInserir.Controls.Add(this.btnInserir);
            this.groupInserir.Location = new System.Drawing.Point(471, 542);
            this.groupInserir.Name = "groupInserir";
            this.groupInserir.Size = new System.Drawing.Size(400, 99);
            this.groupInserir.TabIndex = 66;
            this.groupInserir.TabStop = false;
            this.groupInserir.Text = "Inserir";
            // 
            // btnInserir
            // 
            this.btnInserir.BackColor = System.Drawing.Color.Black;
            this.btnInserir.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnInserir.ForeColor = System.Drawing.Color.White;
            this.btnInserir.Location = new System.Drawing.Point(37, 22);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(283, 59);
            this.btnInserir.TabIndex = 0;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = false;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
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
            this.mnsCondominio.Size = new System.Drawing.Size(1512, 24);
            this.mnsCondominio.TabIndex = 90;
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
            this.tsmApartamento.Enabled = false;
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
            this.tsmPrestadorDeServicos.ForeColor = System.Drawing.Color.White;
            this.tsmPrestadorDeServicos.Name = "tsmPrestadorDeServicos";
            this.tsmPrestadorDeServicos.Size = new System.Drawing.Size(131, 20);
            this.tsmPrestadorDeServicos.Text = "Prestador de Serviços";
            this.tsmPrestadorDeServicos.Click += new System.EventHandler(this.tsmPrestadorDeServicos_Click);
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
            // lblClose
            // 
            this.lblClose.BackColor = System.Drawing.Color.Red;
            this.lblClose.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblClose.ForeColor = System.Drawing.Color.White;
            this.lblClose.Location = new System.Drawing.Point(1487, 0);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(25, 25);
            this.lblClose.TabIndex = 91;
            this.lblClose.Text = "X";
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            // 
            // ucInserir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblClose);
            this.Controls.Add(this.mnsCondominio);
            this.Controls.Add(this.groupInserir);
            this.Controls.Add(this.groupApartamento);
            this.Controls.Add(this.groupLocal);
            this.Name = "ucInserir";
            this.Size = new System.Drawing.Size(1512, 800);
            ((System.ComponentModel.ISupportInitialize)(this.nudNumero)).EndInit();
            this.groupLocal.ResumeLayout(false);
            this.groupLocal.PerformLayout();
            this.groupApartamento.ResumeLayout(false);
            this.groupApartamento.PerformLayout();
            this.groupInserir.ResumeLayout(false);
            this.mnsCondominio.ResumeLayout(false);
            this.mnsCondominio.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label lblRamal;
        private System.Windows.Forms.Label lblBloco;
        private System.Windows.Forms.NumericUpDown nudNumero;
        private System.Windows.Forms.TextBox txtBloco;
        private System.Windows.Forms.TextBox txtRamal;
        private System.Windows.Forms.GroupBox groupLocal;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblMorador;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.TextBox txtCondominio;
        private System.Windows.Forms.TextBox txtPredio;
        private System.Windows.Forms.Label lblPredio;
        private System.Windows.Forms.MaskedTextBox mtxCPF;
        private System.Windows.Forms.Label lblIdCondominio;
        private System.Windows.Forms.Label lblIdPredio;
        private System.Windows.Forms.Label lblIdMorador;
        private System.Windows.Forms.GroupBox groupApartamento;
        private System.Windows.Forms.GroupBox groupInserir;
        private System.Windows.Forms.Button btnInserir;
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
    }
}
