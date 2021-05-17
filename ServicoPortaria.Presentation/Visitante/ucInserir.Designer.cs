
namespace ServicoPortaria.Presentation.Visitante
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
            this.lblSobrenome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtSobrenome = new System.Windows.Forms.TextBox();
            this.groupNome = new System.Windows.Forms.GroupBox();
            this.lblCPF = new System.Windows.Forms.Label();
            this.lblRG = new System.Windows.Forms.Label();
            this.lblDocCivil = new System.Windows.Forms.Label();
            this.lblSexo = new System.Windows.Forms.Label();
            this.mtxCPF = new System.Windows.Forms.MaskedTextBox();
            this.mtxRG = new System.Windows.Forms.MaskedTextBox();
            this.txtDocCivil = new System.Windows.Forms.TextBox();
            this.txtSexo = new System.Windows.Forms.TextBox();
            this.groupDocCivil = new System.Windows.Forms.GroupBox();
            this.dtpDataDeNascimento = new System.Windows.Forms.DateTimePicker();
            this.lblDataNascimento = new System.Windows.Forms.Label();
            this.lblCelular = new System.Windows.Forms.Label();
            this.lblFixo = new System.Windows.Forms.Label();
            this.lblEMail = new System.Windows.Forms.Label();
            this.txtCelular = new System.Windows.Forms.TextBox();
            this.txtTelefoneFixo = new System.Windows.Forms.TextBox();
            this.txtEMail = new System.Windows.Forms.TextBox();
            this.groupInsert = new System.Windows.Forms.GroupBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.groupContato = new System.Windows.Forms.GroupBox();
            this.groupFoto = new System.Windows.Forms.GroupBox();
            this.imgWebCam = new System.Windows.Forms.PictureBox();
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
            this.lblClose = new System.Windows.Forms.Label();
            this.groupOutrasFuncoes = new System.Windows.Forms.GroupBox();
            this.lllDeletar = new System.Windows.Forms.LinkLabel();
            this.lllConsultarTodos = new System.Windows.Forms.LinkLabel();
            this.lllConsultar = new System.Windows.Forms.LinkLabel();
            this.lllModificar = new System.Windows.Forms.LinkLabel();
            this.groupNome.SuspendLayout();
            this.groupDocCivil.SuspendLayout();
            this.groupInsert.SuspendLayout();
            this.groupContato.SuspendLayout();
            this.groupFoto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgWebCam)).BeginInit();
            this.mnsCondominio.SuspendLayout();
            this.groupOutrasFuncoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(12, 35);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(40, 15);
            this.lblNome.TabIndex = 51;
            this.lblNome.Text = "Nome";
            // 
            // lblSobrenome
            // 
            this.lblSobrenome.AutoSize = true;
            this.lblSobrenome.Location = new System.Drawing.Point(12, 79);
            this.lblSobrenome.Name = "lblSobrenome";
            this.lblSobrenome.Size = new System.Drawing.Size(68, 15);
            this.lblSobrenome.TabIndex = 52;
            this.lblSobrenome.Text = "Sobrenome";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(190, 32);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(232, 23);
            this.txtNome.TabIndex = 53;
            // 
            // txtSobrenome
            // 
            this.txtSobrenome.Location = new System.Drawing.Point(190, 76);
            this.txtSobrenome.Name = "txtSobrenome";
            this.txtSobrenome.Size = new System.Drawing.Size(232, 23);
            this.txtSobrenome.TabIndex = 54;
            // 
            // groupNome
            // 
            this.groupNome.Controls.Add(this.txtSobrenome);
            this.groupNome.Controls.Add(this.txtNome);
            this.groupNome.Controls.Add(this.lblSobrenome);
            this.groupNome.Controls.Add(this.lblNome);
            this.groupNome.Location = new System.Drawing.Point(485, 113);
            this.groupNome.Name = "groupNome";
            this.groupNome.Size = new System.Drawing.Size(444, 125);
            this.groupNome.TabIndex = 55;
            this.groupNome.TabStop = false;
            this.groupNome.Text = "Nome do Visitante";
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Location = new System.Drawing.Point(12, 21);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(28, 15);
            this.lblCPF.TabIndex = 56;
            this.lblCPF.Text = "CPF";
            // 
            // lblRG
            // 
            this.lblRG.AutoSize = true;
            this.lblRG.Location = new System.Drawing.Point(12, 67);
            this.lblRG.Name = "lblRG";
            this.lblRG.Size = new System.Drawing.Size(22, 15);
            this.lblRG.TabIndex = 57;
            this.lblRG.Text = "RG";
            // 
            // lblDocCivil
            // 
            this.lblDocCivil.AutoSize = true;
            this.lblDocCivil.Location = new System.Drawing.Point(12, 110);
            this.lblDocCivil.Name = "lblDocCivil";
            this.lblDocCivil.Size = new System.Drawing.Size(96, 15);
            this.lblDocCivil.TabIndex = 58;
            this.lblDocCivil.Text = "Documento Civil";
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Location = new System.Drawing.Point(12, 151);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(32, 15);
            this.lblSexo.TabIndex = 59;
            this.lblSexo.Text = "Sexo";
            // 
            // mtxCPF
            // 
            this.mtxCPF.Location = new System.Drawing.Point(190, 18);
            this.mtxCPF.Mask = "000,000,000-00";
            this.mtxCPF.Name = "mtxCPF";
            this.mtxCPF.Size = new System.Drawing.Size(232, 23);
            this.mtxCPF.TabIndex = 60;
            // 
            // mtxRG
            // 
            this.mtxRG.Location = new System.Drawing.Point(190, 64);
            this.mtxRG.Mask = "00,000,000-0";
            this.mtxRG.Name = "mtxRG";
            this.mtxRG.Size = new System.Drawing.Size(232, 23);
            this.mtxRG.TabIndex = 61;
            // 
            // txtDocCivil
            // 
            this.txtDocCivil.Location = new System.Drawing.Point(190, 107);
            this.txtDocCivil.Name = "txtDocCivil";
            this.txtDocCivil.Size = new System.Drawing.Size(232, 23);
            this.txtDocCivil.TabIndex = 62;
            // 
            // txtSexo
            // 
            this.txtSexo.Location = new System.Drawing.Point(190, 148);
            this.txtSexo.Name = "txtSexo";
            this.txtSexo.Size = new System.Drawing.Size(232, 23);
            this.txtSexo.TabIndex = 63;
            // 
            // groupDocCivil
            // 
            this.groupDocCivil.Controls.Add(this.dtpDataDeNascimento);
            this.groupDocCivil.Controls.Add(this.lblDataNascimento);
            this.groupDocCivil.Controls.Add(this.txtSexo);
            this.groupDocCivil.Controls.Add(this.txtDocCivil);
            this.groupDocCivil.Controls.Add(this.mtxRG);
            this.groupDocCivil.Controls.Add(this.mtxCPF);
            this.groupDocCivil.Controls.Add(this.lblSexo);
            this.groupDocCivil.Controls.Add(this.lblDocCivil);
            this.groupDocCivil.Controls.Add(this.lblRG);
            this.groupDocCivil.Controls.Add(this.lblCPF);
            this.groupDocCivil.Location = new System.Drawing.Point(485, 244);
            this.groupDocCivil.Name = "groupDocCivil";
            this.groupDocCivil.Size = new System.Drawing.Size(444, 234);
            this.groupDocCivil.TabIndex = 64;
            this.groupDocCivil.TabStop = false;
            this.groupDocCivil.Text = "Documentação Civil";
            // 
            // dtpDataDeNascimento
            // 
            this.dtpDataDeNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataDeNascimento.Location = new System.Drawing.Point(190, 189);
            this.dtpDataDeNascimento.Name = "dtpDataDeNascimento";
            this.dtpDataDeNascimento.Size = new System.Drawing.Size(232, 23);
            this.dtpDataDeNascimento.TabIndex = 65;
            // 
            // lblDataNascimento
            // 
            this.lblDataNascimento.AutoSize = true;
            this.lblDataNascimento.Location = new System.Drawing.Point(12, 195);
            this.lblDataNascimento.Name = "lblDataNascimento";
            this.lblDataNascimento.Size = new System.Drawing.Size(114, 15);
            this.lblDataNascimento.TabIndex = 64;
            this.lblDataNascimento.Text = "Data de Nascimento";
            // 
            // lblCelular
            // 
            this.lblCelular.AutoSize = true;
            this.lblCelular.Location = new System.Drawing.Point(12, 23);
            this.lblCelular.Name = "lblCelular";
            this.lblCelular.Size = new System.Drawing.Size(44, 15);
            this.lblCelular.TabIndex = 65;
            this.lblCelular.Text = "Celular";
            // 
            // lblFixo
            // 
            this.lblFixo.AutoSize = true;
            this.lblFixo.Location = new System.Drawing.Point(12, 65);
            this.lblFixo.Name = "lblFixo";
            this.lblFixo.Size = new System.Drawing.Size(76, 15);
            this.lblFixo.TabIndex = 66;
            this.lblFixo.Text = "Telefone Fixo";
            // 
            // lblEMail
            // 
            this.lblEMail.AutoSize = true;
            this.lblEMail.Location = new System.Drawing.Point(12, 109);
            this.lblEMail.Name = "lblEMail";
            this.lblEMail.Size = new System.Drawing.Size(41, 15);
            this.lblEMail.TabIndex = 67;
            this.lblEMail.Text = "E-Mail";
            // 
            // txtCelular
            // 
            this.txtCelular.Location = new System.Drawing.Point(190, 20);
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(232, 23);
            this.txtCelular.TabIndex = 68;
            // 
            // txtTelefoneFixo
            // 
            this.txtTelefoneFixo.Location = new System.Drawing.Point(190, 62);
            this.txtTelefoneFixo.Name = "txtTelefoneFixo";
            this.txtTelefoneFixo.Size = new System.Drawing.Size(232, 23);
            this.txtTelefoneFixo.TabIndex = 69;
            // 
            // txtEMail
            // 
            this.txtEMail.Location = new System.Drawing.Point(190, 106);
            this.txtEMail.Name = "txtEMail";
            this.txtEMail.Size = new System.Drawing.Size(232, 23);
            this.txtEMail.TabIndex = 70;
            // 
            // groupInsert
            // 
            this.groupInsert.Controls.Add(this.btnCadastrar);
            this.groupInsert.Location = new System.Drawing.Point(544, 632);
            this.groupInsert.Name = "groupInsert";
            this.groupInsert.Size = new System.Drawing.Size(300, 101);
            this.groupInsert.TabIndex = 71;
            this.groupInsert.TabStop = false;
            this.groupInsert.Text = "Cadastrar";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.Black;
            this.btnCadastrar.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCadastrar.ForeColor = System.Drawing.Color.White;
            this.btnCadastrar.Location = new System.Drawing.Point(25, 22);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(269, 62);
            this.btnCadastrar.TabIndex = 0;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // groupContato
            // 
            this.groupContato.Controls.Add(this.txtEMail);
            this.groupContato.Controls.Add(this.txtTelefoneFixo);
            this.groupContato.Controls.Add(this.txtCelular);
            this.groupContato.Controls.Add(this.lblEMail);
            this.groupContato.Controls.Add(this.lblFixo);
            this.groupContato.Controls.Add(this.lblCelular);
            this.groupContato.Location = new System.Drawing.Point(485, 484);
            this.groupContato.Name = "groupContato";
            this.groupContato.Size = new System.Drawing.Size(444, 142);
            this.groupContato.TabIndex = 72;
            this.groupContato.TabStop = false;
            this.groupContato.Text = "Contato";
            // 
            // groupFoto
            // 
            this.groupFoto.Controls.Add(this.imgWebCam);
            this.groupFoto.Location = new System.Drawing.Point(935, 204);
            this.groupFoto.Name = "groupFoto";
            this.groupFoto.Size = new System.Drawing.Size(190, 170);
            this.groupFoto.TabIndex = 88;
            this.groupFoto.TabStop = false;
            this.groupFoto.Text = "Foto";
            // 
            // imgWebCam
            // 
            this.imgWebCam.Location = new System.Drawing.Point(29, 20);
            this.imgWebCam.Name = "imgWebCam";
            this.imgWebCam.Size = new System.Drawing.Size(132, 131);
            this.imgWebCam.TabIndex = 86;
            this.imgWebCam.TabStop = false;
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
            this.tsmApartamento.Name = "tsmApartamento";
            this.tsmApartamento.Size = new System.Drawing.Size(89, 20);
            this.tsmApartamento.Text = "Apartamento";
            this.tsmApartamento.Click += new System.EventHandler(this.tsmApartamento_Click);
            // 
            // tsmVisitante
            // 
            this.tsmVisitante.Enabled = false;
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
            this.lblClose.Location = new System.Drawing.Point(1345, 0);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(25, 25);
            this.lblClose.TabIndex = 91;
            this.lblClose.Text = "X";
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            // 
            // groupOutrasFuncoes
            // 
            this.groupOutrasFuncoes.Controls.Add(this.lllDeletar);
            this.groupOutrasFuncoes.Controls.Add(this.lllConsultarTodos);
            this.groupOutrasFuncoes.Controls.Add(this.lllConsultar);
            this.groupOutrasFuncoes.Controls.Add(this.lllModificar);
            this.groupOutrasFuncoes.Location = new System.Drawing.Point(935, 380);
            this.groupOutrasFuncoes.Name = "groupOutrasFuncoes";
            this.groupOutrasFuncoes.Size = new System.Drawing.Size(190, 170);
            this.groupOutrasFuncoes.TabIndex = 93;
            this.groupOutrasFuncoes.TabStop = false;
            this.groupOutrasFuncoes.Text = "Outras Funções";
            // 
            // lllDeletar
            // 
            this.lllDeletar.AutoSize = true;
            this.lllDeletar.Location = new System.Drawing.Point(53, 123);
            this.lllDeletar.Name = "lllDeletar";
            this.lllDeletar.Size = new System.Drawing.Size(44, 15);
            this.lllDeletar.TabIndex = 3;
            this.lllDeletar.TabStop = true;
            this.lllDeletar.Text = "Deletar";
            // 
            // lllConsultarTodos
            // 
            this.lllConsultarTodos.AutoSize = true;
            this.lllConsultarTodos.Location = new System.Drawing.Point(53, 59);
            this.lllConsultarTodos.Name = "lllConsultarTodos";
            this.lllConsultarTodos.Size = new System.Drawing.Size(92, 15);
            this.lllConsultarTodos.TabIndex = 2;
            this.lllConsultarTodos.TabStop = true;
            this.lllConsultarTodos.Text = "Consultar Todos";
            this.lllConsultarTodos.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lllConsultarTodos_LinkClicked);
            // 
            // lllConsultar
            // 
            this.lllConsultar.AutoSize = true;
            this.lllConsultar.Location = new System.Drawing.Point(53, 37);
            this.lllConsultar.Name = "lllConsultar";
            this.lllConsultar.Size = new System.Drawing.Size(58, 15);
            this.lllConsultar.TabIndex = 1;
            this.lllConsultar.TabStop = true;
            this.lllConsultar.Text = "Consultar";
            // 
            // lllModificar
            // 
            this.lllModificar.AutoSize = true;
            this.lllModificar.Location = new System.Drawing.Point(53, 92);
            this.lllModificar.Name = "lllModificar";
            this.lllModificar.Size = new System.Drawing.Size(58, 15);
            this.lllModificar.TabIndex = 0;
            this.lllModificar.TabStop = true;
            this.lllModificar.Text = "Modificar";
            // 
            // ucInserir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupOutrasFuncoes);
            this.Controls.Add(this.lblClose);
            this.Controls.Add(this.mnsCondominio);
            this.Controls.Add(this.groupFoto);
            this.Controls.Add(this.groupContato);
            this.Controls.Add(this.groupInsert);
            this.Controls.Add(this.groupDocCivil);
            this.Controls.Add(this.groupNome);
            this.Name = "ucInserir";
            this.Size = new System.Drawing.Size(1370, 800);
            this.groupNome.ResumeLayout(false);
            this.groupNome.PerformLayout();
            this.groupDocCivil.ResumeLayout(false);
            this.groupDocCivil.PerformLayout();
            this.groupInsert.ResumeLayout(false);
            this.groupContato.ResumeLayout(false);
            this.groupContato.PerformLayout();
            this.groupFoto.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgWebCam)).EndInit();
            this.mnsCondominio.ResumeLayout(false);
            this.mnsCondominio.PerformLayout();
            this.groupOutrasFuncoes.ResumeLayout(false);
            this.groupOutrasFuncoes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblSobrenome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtSobrenome;
        private System.Windows.Forms.GroupBox groupNome;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.Label lblRG;
        private System.Windows.Forms.Label lblDocCivil;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.MaskedTextBox mtxCPF;
        private System.Windows.Forms.MaskedTextBox mtxRG;
        private System.Windows.Forms.TextBox txtDocCivil;
        private System.Windows.Forms.TextBox txtSexo;
        private System.Windows.Forms.GroupBox groupDocCivil;
        private System.Windows.Forms.Label lblCelular;
        private System.Windows.Forms.Label lblFixo;
        private System.Windows.Forms.Label lblEMail;
        private System.Windows.Forms.TextBox txtCelular;
        private System.Windows.Forms.TextBox txtTelefoneFixo;
        private System.Windows.Forms.TextBox txtEMail;
        private System.Windows.Forms.GroupBox groupInsert;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.GroupBox groupContato;
        private System.Windows.Forms.GroupBox groupFoto;
        private System.Windows.Forms.PictureBox imgWebCam;
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
        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.GroupBox groupOutrasFuncoes;
        private System.Windows.Forms.LinkLabel lllDeletar;
        private System.Windows.Forms.LinkLabel lllConsultarTodos;
        private System.Windows.Forms.LinkLabel lllConsultar;
        private System.Windows.Forms.LinkLabel lllModificar;
        private System.Windows.Forms.DateTimePicker dtpDataDeNascimento;
        private System.Windows.Forms.Label lblDataNascimento;
    }
}
