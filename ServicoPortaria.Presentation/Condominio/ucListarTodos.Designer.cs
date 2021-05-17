
namespace ServicoPortaria.Presentation.Condominio
{
    partial class ucListarTodos
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
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.lblPresentation = new System.Windows.Forms.Label();
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
            this.groupFunções = new System.Windows.Forms.GroupBox();
            this.lllDeletarDados = new System.Windows.Forms.LinkLabel();
            this.lllModificarDados = new System.Windows.Forms.LinkLabel();
            this.lllConsultar = new System.Windows.Forms.LinkLabel();
            this.lllInserir = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.mnsCondominio.SuspendLayout();
            this.groupFunções.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblClose
            // 
            this.lblClose.AutoSize = true;
            this.lblClose.BackColor = System.Drawing.Color.Red;
            this.lblClose.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblClose.ForeColor = System.Drawing.Color.White;
            this.lblClose.Location = new System.Drawing.Point(1345, 0);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(24, 25);
            this.lblClose.TabIndex = 39;
            this.lblClose.Text = "X";
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToAddRows = false;
            this.dgvData.AllowUserToDeleteRows = false;
            this.dgvData.AllowUserToResizeColumns = false;
            this.dgvData.AllowUserToResizeRows = false;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Location = new System.Drawing.Point(386, 240);
            this.dgvData.Name = "dgvData";
            this.dgvData.RowTemplate.Height = 25;
            this.dgvData.Size = new System.Drawing.Size(545, 290);
            this.dgvData.TabIndex = 40;
            this.dgvData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellContentClick);
            // 
            // lblPresentation
            // 
            this.lblPresentation.AutoSize = true;
            this.lblPresentation.Location = new System.Drawing.Point(521, 179);
            this.lblPresentation.Name = "lblPresentation";
            this.lblPresentation.Size = new System.Drawing.Size(299, 15);
            this.lblPresentation.TabIndex = 41;
            this.lblPresentation.Text = "Olá, seja muito bem vindo ao módulo de condomínios!";
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
            // groupFunções
            // 
            this.groupFunções.Controls.Add(this.lllDeletarDados);
            this.groupFunções.Controls.Add(this.lllModificarDados);
            this.groupFunções.Controls.Add(this.lllConsultar);
            this.groupFunções.Controls.Add(this.lllInserir);
            this.groupFunções.Location = new System.Drawing.Point(951, 277);
            this.groupFunções.Name = "groupFunções";
            this.groupFunções.Size = new System.Drawing.Size(252, 174);
            this.groupFunções.TabIndex = 87;
            this.groupFunções.TabStop = false;
            this.groupFunções.Text = "Funções";
            // 
            // lllDeletarDados
            // 
            this.lllDeletarDados.AutoSize = true;
            this.lllDeletarDados.Location = new System.Drawing.Point(61, 139);
            this.lllDeletarDados.Name = "lllDeletarDados";
            this.lllDeletarDados.Size = new System.Drawing.Size(80, 15);
            this.lllDeletarDados.TabIndex = 3;
            this.lllDeletarDados.TabStop = true;
            this.lllDeletarDados.Text = "Deletar Dados";
            // 
            // lllModificarDados
            // 
            this.lllModificarDados.AutoSize = true;
            this.lllModificarDados.Location = new System.Drawing.Point(61, 104);
            this.lllModificarDados.Name = "lllModificarDados";
            this.lllModificarDados.Size = new System.Drawing.Size(94, 15);
            this.lllModificarDados.TabIndex = 2;
            this.lllModificarDados.TabStop = true;
            this.lllModificarDados.Text = "Modificar Dados";
            // 
            // lllConsultar
            // 
            this.lllConsultar.AutoSize = true;
            this.lllConsultar.Location = new System.Drawing.Point(61, 71);
            this.lllConsultar.Name = "lllConsultar";
            this.lllConsultar.Size = new System.Drawing.Size(58, 15);
            this.lllConsultar.TabIndex = 1;
            this.lllConsultar.TabStop = true;
            this.lllConsultar.Text = "Consultar";
            this.lllConsultar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lllConsultar_LinkClicked);
            // 
            // lllInserir
            // 
            this.lllInserir.AutoSize = true;
            this.lllInserir.Location = new System.Drawing.Point(61, 41);
            this.lllInserir.Name = "lllInserir";
            this.lllInserir.Size = new System.Drawing.Size(39, 15);
            this.lllInserir.TabIndex = 0;
            this.lllInserir.TabStop = true;
            this.lllInserir.Text = "Inserir";
            this.lllInserir.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lllInserir_LinkClicked);
            // 
            // ucListarTodos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupFunções);
            this.Controls.Add(this.lblPresentation);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.lblClose);
            this.Controls.Add(this.mnsCondominio);
            this.Name = "ucListarTodos";
            this.Size = new System.Drawing.Size(1370, 800);
            this.Load += new System.EventHandler(this.ucListarTodos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.mnsCondominio.ResumeLayout(false);
            this.mnsCondominio.PerformLayout();
            this.groupFunções.ResumeLayout(false);
            this.groupFunções.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.Label lblPresentation;
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
        private System.Windows.Forms.GroupBox groupFunções;
        private System.Windows.Forms.LinkLabel lllDeletarDados;
        private System.Windows.Forms.LinkLabel lllModificarDados;
        private System.Windows.Forms.LinkLabel lllConsultar;
        private System.Windows.Forms.LinkLabel lllInserir;
    }
}
