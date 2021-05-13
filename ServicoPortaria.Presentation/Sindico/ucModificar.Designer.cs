
namespace ServicoPortaria.Presentation.Sindico
{
    partial class ucModificar
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
            this.groupInserir = new System.Windows.Forms.GroupBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.groupLocal = new System.Windows.Forms.GroupBox();
            this.lblCodCondominio = new System.Windows.Forms.Label();
            this.lblIdPredio = new System.Windows.Forms.Label();
            this.txtCondominio = new System.Windows.Forms.TextBox();
            this.txtPredio = new System.Windows.Forms.TextBox();
            this.lblCondominio = new System.Windows.Forms.Label();
            this.lblNomePredio = new System.Windows.Forms.Label();
            this.txtEMail = new System.Windows.Forms.TextBox();
            this.groupDocumentacao = new System.Windows.Forms.GroupBox();
            this.txtDocCivil = new System.Windows.Forms.TextBox();
            this.mtxRG = new System.Windows.Forms.MaskedTextBox();
            this.mtxCPF = new System.Windows.Forms.MaskedTextBox();
            this.lblCPF = new System.Windows.Forms.Label();
            this.lblRG = new System.Windows.Forms.Label();
            this.lblDocCivil = new System.Windows.Forms.Label();
            this.groupNome = new System.Windows.Forms.GroupBox();
            this.txtSobrenome = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblSobrenome = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblEMail = new System.Windows.Forms.Label();
            this.groupContato = new System.Windows.Forms.GroupBox();
            this.txtCelular = new System.Windows.Forms.TextBox();
            this.lblCelular = new System.Windows.Forms.Label();
            this.groupModificar = new System.Windows.Forms.GroupBox();
            this.groupConsultar = new System.Windows.Forms.GroupBox();
            this.groupBotaoConsultar = new System.Windows.Forms.GroupBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.groupCodigo = new System.Windows.Forms.GroupBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtConsultarDocCivil = new System.Windows.Forms.TextBox();
            this.mtxConsultarRG = new System.Windows.Forms.MaskedTextBox();
            this.mtxConsultarCPF = new System.Windows.Forms.MaskedTextBox();
            this.lblConsultarCPF = new System.Windows.Forms.Label();
            this.lblConsultarRG = new System.Windows.Forms.Label();
            this.lblConsultarDocCivil = new System.Windows.Forms.Label();
            this.groupInserir.SuspendLayout();
            this.groupLocal.SuspendLayout();
            this.groupDocumentacao.SuspendLayout();
            this.groupNome.SuspendLayout();
            this.groupContato.SuspendLayout();
            this.groupModificar.SuspendLayout();
            this.groupConsultar.SuspendLayout();
            this.groupBotaoConsultar.SuspendLayout();
            this.groupCodigo.SuspendLayout();
            this.groupBox4.SuspendLayout();
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
            this.lblClose.TabIndex = 83;
            this.lblClose.Text = "X";
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            // 
            // groupInserir
            // 
            this.groupInserir.Controls.Add(this.btnInsert);
            this.groupInserir.Location = new System.Drawing.Point(164, 603);
            this.groupInserir.Name = "groupInserir";
            this.groupInserir.Size = new System.Drawing.Size(423, 107);
            this.groupInserir.TabIndex = 90;
            this.groupInserir.TabStop = false;
            this.groupInserir.Text = "Inserir";
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.Color.Black;
            this.btnInsert.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnInsert.ForeColor = System.Drawing.Color.White;
            this.btnInsert.Location = new System.Drawing.Point(36, 22);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(356, 66);
            this.btnInsert.TabIndex = 0;
            this.btnInsert.Text = "Cadastrar Síndico";
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // groupLocal
            // 
            this.groupLocal.Controls.Add(this.lblCodCondominio);
            this.groupLocal.Controls.Add(this.lblIdPredio);
            this.groupLocal.Controls.Add(this.txtCondominio);
            this.groupLocal.Controls.Add(this.txtPredio);
            this.groupLocal.Controls.Add(this.lblCondominio);
            this.groupLocal.Controls.Add(this.lblNomePredio);
            this.groupLocal.Location = new System.Drawing.Point(10, 22);
            this.groupLocal.Name = "groupLocal";
            this.groupLocal.Size = new System.Drawing.Size(599, 97);
            this.groupLocal.TabIndex = 89;
            this.groupLocal.TabStop = false;
            this.groupLocal.Text = "Local";
            // 
            // lblCodCondominio
            // 
            this.lblCodCondominio.AutoSize = true;
            this.lblCodCondominio.Location = new System.Drawing.Point(454, 73);
            this.lblCodCondominio.Name = "lblCodCondominio";
            this.lblCodCondominio.Size = new System.Drawing.Size(133, 15);
            this.lblCodCondominio.TabIndex = 76;
            this.lblCodCondominio.Text = "Código do Condomínio";
            // 
            // lblIdPredio
            // 
            this.lblIdPredio.AutoSize = true;
            this.lblIdPredio.Location = new System.Drawing.Point(454, 32);
            this.lblIdPredio.Name = "lblIdPredio";
            this.lblIdPredio.Size = new System.Drawing.Size(100, 15);
            this.lblIdPredio.TabIndex = 75;
            this.lblIdPredio.Text = "Código do Prédio";
            // 
            // txtCondominio
            // 
            this.txtCondominio.Location = new System.Drawing.Point(139, 70);
            this.txtCondominio.Name = "txtCondominio";
            this.txtCondominio.Size = new System.Drawing.Size(277, 23);
            this.txtCondominio.TabIndex = 74;
            // 
            // txtPredio
            // 
            this.txtPredio.Location = new System.Drawing.Point(139, 29);
            this.txtPredio.Name = "txtPredio";
            this.txtPredio.Size = new System.Drawing.Size(277, 23);
            this.txtPredio.TabIndex = 67;
            // 
            // lblCondominio
            // 
            this.lblCondominio.AutoSize = true;
            this.lblCondominio.Location = new System.Drawing.Point(9, 73);
            this.lblCondominio.Name = "lblCondominio";
            this.lblCondominio.Size = new System.Drawing.Size(127, 15);
            this.lblCondominio.TabIndex = 73;
            this.lblCondominio.Text = "Nome do Condomínio";
            // 
            // lblNomePredio
            // 
            this.lblNomePredio.AutoSize = true;
            this.lblNomePredio.Location = new System.Drawing.Point(9, 32);
            this.lblNomePredio.Name = "lblNomePredio";
            this.lblNomePredio.Size = new System.Drawing.Size(94, 15);
            this.lblNomePredio.TabIndex = 58;
            this.lblNomePredio.Text = "Nome do Prédio";
            // 
            // txtEMail
            // 
            this.txtEMail.Location = new System.Drawing.Point(149, 448);
            this.txtEMail.Name = "txtEMail";
            this.txtEMail.Size = new System.Drawing.Size(277, 23);
            this.txtEMail.TabIndex = 86;
            // 
            // groupDocumentacao
            // 
            this.groupDocumentacao.Controls.Add(this.txtDocCivil);
            this.groupDocumentacao.Controls.Add(this.mtxRG);
            this.groupDocumentacao.Controls.Add(this.mtxCPF);
            this.groupDocumentacao.Controls.Add(this.lblCPF);
            this.groupDocumentacao.Controls.Add(this.lblRG);
            this.groupDocumentacao.Controls.Add(this.lblDocCivil);
            this.groupDocumentacao.Location = new System.Drawing.Point(10, 234);
            this.groupDocumentacao.Name = "groupDocumentacao";
            this.groupDocumentacao.Size = new System.Drawing.Size(423, 151);
            this.groupDocumentacao.TabIndex = 87;
            this.groupDocumentacao.TabStop = false;
            this.groupDocumentacao.Text = "Documentação Civil";
            // 
            // txtDocCivil
            // 
            this.txtDocCivil.Location = new System.Drawing.Point(139, 110);
            this.txtDocCivil.Name = "txtDocCivil";
            this.txtDocCivil.Size = new System.Drawing.Size(277, 23);
            this.txtDocCivil.TabIndex = 67;
            // 
            // mtxRG
            // 
            this.mtxRG.Location = new System.Drawing.Point(139, 63);
            this.mtxRG.Mask = "00.000.000-0";
            this.mtxRG.Name = "mtxRG";
            this.mtxRG.Size = new System.Drawing.Size(277, 23);
            this.mtxRG.TabIndex = 69;
            // 
            // mtxCPF
            // 
            this.mtxCPF.Location = new System.Drawing.Point(139, 18);
            this.mtxCPF.Mask = "000.000.000-00";
            this.mtxCPF.Name = "mtxCPF";
            this.mtxCPF.Size = new System.Drawing.Size(277, 23);
            this.mtxCPF.TabIndex = 68;
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Location = new System.Drawing.Point(9, 21);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(28, 15);
            this.lblCPF.TabIndex = 63;
            this.lblCPF.Text = "CPF";
            // 
            // lblRG
            // 
            this.lblRG.AutoSize = true;
            this.lblRG.Location = new System.Drawing.Point(9, 66);
            this.lblRG.Name = "lblRG";
            this.lblRG.Size = new System.Drawing.Size(22, 15);
            this.lblRG.TabIndex = 62;
            this.lblRG.Text = "RG";
            // 
            // lblDocCivil
            // 
            this.lblDocCivil.AutoSize = true;
            this.lblDocCivil.Location = new System.Drawing.Point(9, 113);
            this.lblDocCivil.Name = "lblDocCivil";
            this.lblDocCivil.Size = new System.Drawing.Size(96, 15);
            this.lblDocCivil.TabIndex = 61;
            this.lblDocCivil.Text = "Documento Civil";
            // 
            // groupNome
            // 
            this.groupNome.Controls.Add(this.txtSobrenome);
            this.groupNome.Controls.Add(this.txtNome);
            this.groupNome.Controls.Add(this.lblSobrenome);
            this.groupNome.Controls.Add(this.lblNome);
            this.groupNome.Location = new System.Drawing.Point(10, 125);
            this.groupNome.Name = "groupNome";
            this.groupNome.Size = new System.Drawing.Size(423, 103);
            this.groupNome.TabIndex = 85;
            this.groupNome.TabStop = false;
            this.groupNome.Text = "Nome";
            // 
            // txtSobrenome
            // 
            this.txtSobrenome.Location = new System.Drawing.Point(139, 64);
            this.txtSobrenome.Name = "txtSobrenome";
            this.txtSobrenome.Size = new System.Drawing.Size(277, 23);
            this.txtSobrenome.TabIndex = 66;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(139, 19);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(277, 23);
            this.txtNome.TabIndex = 65;
            // 
            // lblSobrenome
            // 
            this.lblSobrenome.AutoSize = true;
            this.lblSobrenome.Location = new System.Drawing.Point(9, 67);
            this.lblSobrenome.Name = "lblSobrenome";
            this.lblSobrenome.Size = new System.Drawing.Size(68, 15);
            this.lblSobrenome.TabIndex = 64;
            this.lblSobrenome.Text = "Sobrenome";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(9, 22);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(40, 15);
            this.lblNome.TabIndex = 57;
            this.lblNome.Text = "Nome";
            // 
            // lblEMail
            // 
            this.lblEMail.AutoSize = true;
            this.lblEMail.Location = new System.Drawing.Point(9, 61);
            this.lblEMail.Name = "lblEMail";
            this.lblEMail.Size = new System.Drawing.Size(41, 15);
            this.lblEMail.TabIndex = 84;
            this.lblEMail.Text = "E-Mail";
            // 
            // groupContato
            // 
            this.groupContato.Controls.Add(this.txtCelular);
            this.groupContato.Controls.Add(this.lblCelular);
            this.groupContato.Controls.Add(this.lblEMail);
            this.groupContato.Location = new System.Drawing.Point(10, 390);
            this.groupContato.Name = "groupContato";
            this.groupContato.Size = new System.Drawing.Size(423, 88);
            this.groupContato.TabIndex = 88;
            this.groupContato.TabStop = false;
            this.groupContato.Text = "Contato";
            // 
            // txtCelular
            // 
            this.txtCelular.Location = new System.Drawing.Point(139, 12);
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(277, 23);
            this.txtCelular.TabIndex = 71;
            // 
            // lblCelular
            // 
            this.lblCelular.AutoSize = true;
            this.lblCelular.Location = new System.Drawing.Point(9, 15);
            this.lblCelular.Name = "lblCelular";
            this.lblCelular.Size = new System.Drawing.Size(44, 15);
            this.lblCelular.TabIndex = 60;
            this.lblCelular.Text = "Celular";
            // 
            // groupModificar
            // 
            this.groupModificar.Controls.Add(this.groupLocal);
            this.groupModificar.Controls.Add(this.txtEMail);
            this.groupModificar.Controls.Add(this.groupDocumentacao);
            this.groupModificar.Controls.Add(this.groupNome);
            this.groupModificar.Controls.Add(this.groupContato);
            this.groupModificar.Location = new System.Drawing.Point(154, 130);
            this.groupModificar.Name = "groupModificar";
            this.groupModificar.Size = new System.Drawing.Size(620, 597);
            this.groupModificar.TabIndex = 91;
            this.groupModificar.TabStop = false;
            this.groupModificar.Text = "Modificar";
            // 
            // groupConsultar
            // 
            this.groupConsultar.Controls.Add(this.groupBotaoConsultar);
            this.groupConsultar.Controls.Add(this.groupCodigo);
            this.groupConsultar.Controls.Add(this.groupBox4);
            this.groupConsultar.Location = new System.Drawing.Point(805, 136);
            this.groupConsultar.Name = "groupConsultar";
            this.groupConsultar.Size = new System.Drawing.Size(464, 591);
            this.groupConsultar.TabIndex = 92;
            this.groupConsultar.TabStop = false;
            this.groupConsultar.Text = "Consultar";
            // 
            // groupBotaoConsultar
            // 
            this.groupBotaoConsultar.Controls.Add(this.btnConsultar);
            this.groupBotaoConsultar.Location = new System.Drawing.Point(20, 467);
            this.groupBotaoConsultar.Name = "groupBotaoConsultar";
            this.groupBotaoConsultar.Size = new System.Drawing.Size(422, 107);
            this.groupBotaoConsultar.TabIndex = 90;
            this.groupBotaoConsultar.TabStop = false;
            this.groupBotaoConsultar.Text = "Consultar";
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.Color.Black;
            this.btnConsultar.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnConsultar.ForeColor = System.Drawing.Color.White;
            this.btnConsultar.Location = new System.Drawing.Point(88, 26);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(258, 66);
            this.btnConsultar.TabIndex = 0;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // groupCodigo
            // 
            this.groupCodigo.Controls.Add(this.lblCodigo);
            this.groupCodigo.Location = new System.Drawing.Point(20, 304);
            this.groupCodigo.Name = "groupCodigo";
            this.groupCodigo.Size = new System.Drawing.Size(422, 138);
            this.groupCodigo.TabIndex = 89;
            this.groupCodigo.TabStop = false;
            this.groupCodigo.Text = "Código";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(150, 60);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(105, 15);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código do Síndico";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtConsultarDocCivil);
            this.groupBox4.Controls.Add(this.mtxConsultarRG);
            this.groupBox4.Controls.Add(this.mtxConsultarCPF);
            this.groupBox4.Controls.Add(this.lblConsultarCPF);
            this.groupBox4.Controls.Add(this.lblConsultarRG);
            this.groupBox4.Controls.Add(this.lblConsultarDocCivil);
            this.groupBox4.Location = new System.Drawing.Point(19, 22);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(423, 263);
            this.groupBox4.TabIndex = 88;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Documentação Civil";
            // 
            // txtConsultarDocCivil
            // 
            this.txtConsultarDocCivil.Location = new System.Drawing.Point(139, 206);
            this.txtConsultarDocCivil.Name = "txtConsultarDocCivil";
            this.txtConsultarDocCivil.Size = new System.Drawing.Size(277, 23);
            this.txtConsultarDocCivil.TabIndex = 67;
            // 
            // mtxConsultarRG
            // 
            this.mtxConsultarRG.Location = new System.Drawing.Point(139, 116);
            this.mtxConsultarRG.Mask = "00.000.000-0";
            this.mtxConsultarRG.Name = "mtxConsultarRG";
            this.mtxConsultarRG.Size = new System.Drawing.Size(277, 23);
            this.mtxConsultarRG.TabIndex = 69;
            // 
            // mtxConsultarCPF
            // 
            this.mtxConsultarCPF.Location = new System.Drawing.Point(139, 18);
            this.mtxConsultarCPF.Mask = "000.000.000-00";
            this.mtxConsultarCPF.Name = "mtxConsultarCPF";
            this.mtxConsultarCPF.Size = new System.Drawing.Size(277, 23);
            this.mtxConsultarCPF.TabIndex = 68;
            // 
            // lblConsultarCPF
            // 
            this.lblConsultarCPF.AutoSize = true;
            this.lblConsultarCPF.Location = new System.Drawing.Point(9, 21);
            this.lblConsultarCPF.Name = "lblConsultarCPF";
            this.lblConsultarCPF.Size = new System.Drawing.Size(28, 15);
            this.lblConsultarCPF.TabIndex = 63;
            this.lblConsultarCPF.Text = "CPF";
            // 
            // lblConsultarRG
            // 
            this.lblConsultarRG.AutoSize = true;
            this.lblConsultarRG.Location = new System.Drawing.Point(9, 119);
            this.lblConsultarRG.Name = "lblConsultarRG";
            this.lblConsultarRG.Size = new System.Drawing.Size(22, 15);
            this.lblConsultarRG.TabIndex = 62;
            this.lblConsultarRG.Text = "RG";
            // 
            // lblConsultarDocCivil
            // 
            this.lblConsultarDocCivil.AutoSize = true;
            this.lblConsultarDocCivil.Location = new System.Drawing.Point(9, 209);
            this.lblConsultarDocCivil.Name = "lblConsultarDocCivil";
            this.lblConsultarDocCivil.Size = new System.Drawing.Size(96, 15);
            this.lblConsultarDocCivil.TabIndex = 61;
            this.lblConsultarDocCivil.Text = "Documento Civil";
            // 
            // ucModificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupConsultar);
            this.Controls.Add(this.groupInserir);
            this.Controls.Add(this.lblClose);
            this.Controls.Add(this.groupModificar);
            this.Name = "ucModificar";
            this.Size = new System.Drawing.Size(1370, 800);
            this.Load += new System.EventHandler(this.ucModificar_Load);
            this.groupInserir.ResumeLayout(false);
            this.groupLocal.ResumeLayout(false);
            this.groupLocal.PerformLayout();
            this.groupDocumentacao.ResumeLayout(false);
            this.groupDocumentacao.PerformLayout();
            this.groupNome.ResumeLayout(false);
            this.groupNome.PerformLayout();
            this.groupContato.ResumeLayout(false);
            this.groupContato.PerformLayout();
            this.groupModificar.ResumeLayout(false);
            this.groupModificar.PerformLayout();
            this.groupConsultar.ResumeLayout(false);
            this.groupBotaoConsultar.ResumeLayout(false);
            this.groupCodigo.ResumeLayout(false);
            this.groupCodigo.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnsPresentation;
        private System.Windows.Forms.ToolStripMenuItem tmsCondominio;
        private System.Windows.Forms.ToolStripMenuItem tmsPredio;
        private System.Windows.Forms.ToolStripMenuItem tmsMorador;
        private System.Windows.Forms.ToolStripMenuItem tsmApartamento;
        private System.Windows.Forms.ToolStripMenuItem tsmVisitante;
        private System.Windows.Forms.ToolStripMenuItem tsmGaragem;
        private System.Windows.Forms.ToolStripMenuItem tsmVeículo;
        private System.Windows.Forms.ToolStripMenuItem tsmPrestadorServicos;
        private System.Windows.Forms.ToolStripMenuItem tsmSindico;
        private System.Windows.Forms.ToolStripMenuItem tsmInicio;
        private System.Windows.Forms.ToolStripMenuItem tsmVisita;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printPreviewToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem indexToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.MenuStrip mnsCondominio;
        private System.Windows.Forms.ToolStripMenuItem tsmCadastroMorador;
        private System.Windows.Forms.ToolStripMenuItem tsmConsultarMorador;
        private System.Windows.Forms.ToolStripMenuItem tsmModuloVisitante;
        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.GroupBox groupInserir;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.GroupBox groupLocal;
        private System.Windows.Forms.Label lblCodCondominio;
        private System.Windows.Forms.Label lblIdPredio;
        private System.Windows.Forms.TextBox txtCondominio;
        private System.Windows.Forms.TextBox txtPredio;
        private System.Windows.Forms.Label lblCondominio;
        private System.Windows.Forms.Label lblNomePredio;
        private System.Windows.Forms.TextBox txtEMail;
        private System.Windows.Forms.GroupBox groupDocumentacao;
        private System.Windows.Forms.TextBox txtDocCivil;
        private System.Windows.Forms.MaskedTextBox mtxRG;
        private System.Windows.Forms.MaskedTextBox mtxCPF;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.Label lblRG;
        private System.Windows.Forms.Label lblDocCivil;
        private System.Windows.Forms.GroupBox groupNome;
        private System.Windows.Forms.TextBox txtSobrenome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblSobrenome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblEMail;
        private System.Windows.Forms.GroupBox groupContato;
        private System.Windows.Forms.TextBox txtCelular;
        private System.Windows.Forms.Label lblCelular;
        private System.Windows.Forms.GroupBox groupModificar;
        private System.Windows.Forms.GroupBox groupConsultar;
        private System.Windows.Forms.GroupBox groupBotaoConsultar;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.GroupBox groupCodigo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtConsultarDocCivil;
        private System.Windows.Forms.MaskedTextBox mtxConsultarRG;
        private System.Windows.Forms.MaskedTextBox mtxConsultarCPF;
        private System.Windows.Forms.Label lblConsultarCPF;
        private System.Windows.Forms.Label lblConsultarRG;
        private System.Windows.Forms.Label lblConsultarDocCivil;
    }
}
