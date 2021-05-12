
namespace ServicoPortaria.Presentation.Apartamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucModificar));
            this.Modificar = new ServicoPortaria.Presentation.Apartamento.ucModificar();
            this.lblClose = new System.Windows.Forms.Label();
            this.groupInserir = new System.Windows.Forms.GroupBox();
            this.btnInserir = new System.Windows.Forms.Button();
            this.groupLocal = new System.Windows.Forms.GroupBox();
            this.txtRamal = new System.Windows.Forms.TextBox();
            this.txtBloco = new System.Windows.Forms.TextBox();
            this.nudNumero = new System.Windows.Forms.NumericUpDown();
            this.lblBloco = new System.Windows.Forms.Label();
            this.lblRamal = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.groupOutrasFuncoes = new System.Windows.Forms.GroupBox();
            this.lllDeletar = new System.Windows.Forms.LinkLabel();
            this.lllConsultarTodos = new System.Windows.Forms.LinkLabel();
            this.lllConsultar = new System.Windows.Forms.LinkLabel();
            this.lllInserir = new System.Windows.Forms.LinkLabel();
            this.groupConsultar = new System.Windows.Forms.GroupBox();
            this.mtxConsultarMorador = new System.Windows.Forms.MaskedTextBox();
            this.txtConsultarPredio = new System.Windows.Forms.TextBox();
            this.txtConsultarCondominio = new System.Windows.Forms.TextBox();
            this.lblConsultarPredio = new System.Windows.Forms.Label();
            this.lblConsultarMorador = new System.Windows.Forms.Label();
            this.lblConsultarCondominio = new System.Windows.Forms.Label();
            this.txtConsultarBloco = new System.Windows.Forms.TextBox();
            this.nudConsultarNumero = new System.Windows.Forms.NumericUpDown();
            this.lblConsultarBloco = new System.Windows.Forms.Label();
            this.lblConsultarNumero = new System.Windows.Forms.Label();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.lblConsultarIdPredio = new System.Windows.Forms.Label();
            this.lblConsultarIdCondominio = new System.Windows.Forms.Label();
            this.lblConsultarCodigoApartamento = new System.Windows.Forms.Label();
            this.lblConsultarCodigoMorador = new System.Windows.Forms.Label();
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
            this.groupInserir.SuspendLayout();
            this.groupLocal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumero)).BeginInit();
            this.groupOutrasFuncoes.SuspendLayout();
            this.groupConsultar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudConsultarNumero)).BeginInit();
            this.groupApartamento.SuspendLayout();
            this.SuspendLayout();
            // 
            // Modificar
            // 
            this.Modificar.Location = new System.Drawing.Point(0, 0);
            this.Modificar.Name = "Modificar";
            this.Modificar.Size = new System.Drawing.Size(150, 150);
            this.Modificar.TabIndex = 0;
            // 
            // lblClose
            // 
            this.lblClose.BackColor = System.Drawing.Color.Red;
            this.lblClose.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblClose.ForeColor = System.Drawing.Color.White;
            this.lblClose.Location = new System.Drawing.Point(1345, 0);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(25, 25);
            this.lblClose.TabIndex = 67;
            this.lblClose.Text = "X";
            this.lblClose.Click += new System.EventHandler(lblClose_Click);
            // 
            // groupInserir
            // 
            this.groupInserir.Controls.Add(this.btnInserir);
            this.groupInserir.Location = new System.Drawing.Point(271, 527);
            this.groupInserir.Name = "groupInserir";
            this.groupInserir.Size = new System.Drawing.Size(400, 99);
            this.groupInserir.TabIndex = 70;
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
            this.btnInserir.Click += new System.EventHandler(btnInserir_Click);
            // 
            // groupLocal
            // 
            this.groupLocal.Controls.Add(this.txtRamal);
            this.groupLocal.Controls.Add(this.txtBloco);
            this.groupLocal.Controls.Add(this.nudNumero);
            this.groupLocal.Controls.Add(this.lblBloco);
            this.groupLocal.Controls.Add(this.lblRamal);
            this.groupLocal.Controls.Add(this.lblNumero);
            this.groupLocal.Location = new System.Drawing.Point(166, 148);
            this.groupLocal.Name = "groupLocal";
            this.groupLocal.Size = new System.Drawing.Size(428, 184);
            this.groupLocal.TabIndex = 68;
            this.groupLocal.TabStop = false;
            this.groupLocal.Text = "Local";
            // 
            // txtRamal
            // 
            this.txtRamal.Location = new System.Drawing.Point(139, 139);
            this.txtRamal.Name = "txtRamal";
            this.txtRamal.Size = new System.Drawing.Size(283, 23);
            this.txtRamal.TabIndex = 55;
            // 
            // txtBloco
            // 
            this.txtBloco.Location = new System.Drawing.Point(139, 89);
            this.txtBloco.Name = "txtBloco";
            this.txtBloco.Size = new System.Drawing.Size(283, 23);
            this.txtBloco.TabIndex = 54;
            // 
            // nudNumero
            // 
            this.nudNumero.Location = new System.Drawing.Point(139, 37);
            this.nudNumero.Name = "nudNumero";
            this.nudNumero.Size = new System.Drawing.Size(283, 23);
            this.nudNumero.TabIndex = 53;
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
            // lblRamal
            // 
            this.lblRamal.AutoSize = true;
            this.lblRamal.Location = new System.Drawing.Point(8, 142);
            this.lblRamal.Name = "lblRamal";
            this.lblRamal.Size = new System.Drawing.Size(40, 15);
            this.lblRamal.TabIndex = 51;
            this.lblRamal.Text = "Ramal";
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
            // groupOutrasFuncoes
            // 
            this.groupOutrasFuncoes.Controls.Add(this.lllDeletar);
            this.groupOutrasFuncoes.Controls.Add(this.lllConsultarTodos);
            this.groupOutrasFuncoes.Controls.Add(this.lllConsultar);
            this.groupOutrasFuncoes.Controls.Add(this.lllInserir);
            this.groupOutrasFuncoes.Location = new System.Drawing.Point(608, 148);
            this.groupOutrasFuncoes.Name = "groupOutrasFuncoes";
            this.groupOutrasFuncoes.Size = new System.Drawing.Size(189, 183);
            this.groupOutrasFuncoes.TabIndex = 71;
            this.groupOutrasFuncoes.TabStop = false;
            this.groupOutrasFuncoes.Text = "Outras Funções";
            // 
            // lllDeletar
            // 
            this.lllDeletar.AutoSize = true;
            this.lllDeletar.Location = new System.Drawing.Point(48, 129);
            this.lllDeletar.Name = "lllDeletar";
            this.lllDeletar.Size = new System.Drawing.Size(44, 15);
            this.lllDeletar.TabIndex = 7;
            this.lllDeletar.TabStop = true;
            this.lllDeletar.Text = "Deletar";
            // 
            // lllConsultarTodos
            // 
            this.lllConsultarTodos.AutoSize = true;
            this.lllConsultarTodos.Location = new System.Drawing.Point(48, 97);
            this.lllConsultarTodos.Name = "lllConsultarTodos";
            this.lllConsultarTodos.Size = new System.Drawing.Size(92, 15);
            this.lllConsultarTodos.TabIndex = 6;
            this.lllConsultarTodos.TabStop = true;
            this.lllConsultarTodos.Text = "Consultar Todos";
            // 
            // lllConsultar
            // 
            this.lllConsultar.AutoSize = true;
            this.lllConsultar.Location = new System.Drawing.Point(48, 65);
            this.lllConsultar.Name = "lllConsultar";
            this.lllConsultar.Size = new System.Drawing.Size(58, 15);
            this.lllConsultar.TabIndex = 5;
            this.lllConsultar.TabStop = true;
            this.lllConsultar.Text = "Consultar";
            // 
            // lllInserir
            // 
            this.lllInserir.AutoSize = true;
            this.lllInserir.Location = new System.Drawing.Point(48, 38);
            this.lllInserir.Name = "lllInserir";
            this.lllInserir.Size = new System.Drawing.Size(39, 15);
            this.lllInserir.TabIndex = 4;
            this.lllInserir.TabStop = true;
            this.lllInserir.Text = "Inserir";
            // 
            // groupBox1
            // 
            this.groupConsultar.Controls.Add(this.lblConsultarCodigoMorador);
            this.groupConsultar.Controls.Add(this.lblConsultarCodigoApartamento);
            this.groupConsultar.Controls.Add(this.lblConsultarIdPredio);
            this.groupConsultar.Controls.Add(this.lblConsultarIdCondominio);
            this.groupConsultar.Controls.Add(this.btnConsultar);
            this.groupConsultar.Controls.Add(this.txtConsultarBloco);
            this.groupConsultar.Controls.Add(this.nudConsultarNumero);
            this.groupConsultar.Controls.Add(this.lblConsultarBloco);
            this.groupConsultar.Controls.Add(this.lblConsultarNumero);
            this.groupConsultar.Controls.Add(this.mtxConsultarMorador);
            this.groupConsultar.Controls.Add(this.txtConsultarPredio);
            this.groupConsultar.Controls.Add(this.txtConsultarCondominio);
            this.groupConsultar.Controls.Add(this.lblConsultarPredio);
            this.groupConsultar.Controls.Add(this.lblConsultarMorador);
            this.groupConsultar.Controls.Add(this.lblConsultarCondominio);
            this.groupConsultar.Location = new System.Drawing.Point(889, 148);
            this.groupConsultar.Name = "groupBox1";
            this.groupConsultar.Size = new System.Drawing.Size(445, 478);
            this.groupConsultar.TabIndex = 72;
            this.groupConsultar.TabStop = false;
            this.groupConsultar.Text = "Consultar Dados";
            // 
            // mtxConsultarMorador
            // 
            this.mtxConsultarMorador.Location = new System.Drawing.Point(146, 161);
            this.mtxConsultarMorador.Mask = "000.000.000-00";
            this.mtxConsultarMorador.Name = "mtxConsultarMorador";
            this.mtxConsultarMorador.Size = new System.Drawing.Size(283, 23);
            this.mtxConsultarMorador.TabIndex = 67;
            // 
            // txtConsultarPredio
            // 
            this.txtConsultarPredio.Location = new System.Drawing.Point(146, 105);
            this.txtConsultarPredio.Name = "txtConsultarPredio";
            this.txtConsultarPredio.Size = new System.Drawing.Size(283, 23);
            this.txtConsultarPredio.TabIndex = 66;
            // 
            // txtConsultarCondominio
            // 
            this.txtConsultarCondominio.Location = new System.Drawing.Point(146, 50);
            this.txtConsultarCondominio.Name = "txtConsultarCondominio";
            this.txtConsultarCondominio.Size = new System.Drawing.Size(283, 23);
            this.txtConsultarCondominio.TabIndex = 62;
            // 
            // lblConsultarPredio
            // 
            this.lblConsultarPredio.AutoSize = true;
            this.lblConsultarPredio.Location = new System.Drawing.Point(15, 108);
            this.lblConsultarPredio.Name = "lblConsultarPredio";
            this.lblConsultarPredio.Size = new System.Drawing.Size(94, 15);
            this.lblConsultarPredio.TabIndex = 65;
            this.lblConsultarPredio.Text = "Nome do Prédio";
            // 
            // lblConsultarMorador
            // 
            this.lblConsultarMorador.AutoSize = true;
            this.lblConsultarMorador.Location = new System.Drawing.Point(15, 164);
            this.lblConsultarMorador.Name = "lblConsultarMorador";
            this.lblConsultarMorador.Size = new System.Drawing.Size(94, 15);
            this.lblConsultarMorador.TabIndex = 64;
            this.lblConsultarMorador.Text = "CPF do Morador";
            // 
            // lblConsultarCondominio
            // 
            this.lblConsultarCondominio.AutoSize = true;
            this.lblConsultarCondominio.Location = new System.Drawing.Point(15, 53);
            this.lblConsultarCondominio.Name = "lblConsultarCondominio";
            this.lblConsultarCondominio.Size = new System.Drawing.Size(127, 15);
            this.lblConsultarCondominio.TabIndex = 63;
            this.lblConsultarCondominio.Text = "Nome do Condomínio";
            // 
            // txtConsultarBloco
            // 
            this.txtConsultarBloco.Location = new System.Drawing.Point(146, 267);
            this.txtConsultarBloco.Name = "txtConsultarBloco";
            this.txtConsultarBloco.Size = new System.Drawing.Size(283, 23);
            this.txtConsultarBloco.TabIndex = 71;
            // 
            // nudConsultarNumero
            // 
            this.nudConsultarNumero.Location = new System.Drawing.Point(146, 213);
            this.nudConsultarNumero.Name = "nudConsultarNumero";
            this.nudConsultarNumero.Size = new System.Drawing.Size(283, 23);
            this.nudConsultarNumero.TabIndex = 70;
            // 
            // lblConsultarBloco
            // 
            this.lblConsultarBloco.AutoSize = true;
            this.lblConsultarBloco.Location = new System.Drawing.Point(15, 270);
            this.lblConsultarBloco.Name = "lblConsultarBloco";
            this.lblConsultarBloco.Size = new System.Drawing.Size(37, 15);
            this.lblConsultarBloco.TabIndex = 69;
            this.lblConsultarBloco.Text = "Bloco";
            // 
            // lblConsultarNumero
            // 
            this.lblConsultarNumero.AutoSize = true;
            this.lblConsultarNumero.Location = new System.Drawing.Point(15, 220);
            this.lblConsultarNumero.Name = "lblConsultarNumero";
            this.lblConsultarNumero.Size = new System.Drawing.Size(51, 15);
            this.lblConsultarNumero.TabIndex = 68;
            this.lblConsultarNumero.Text = "Número";
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.Color.Black;
            this.btnConsultar.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnConsultar.ForeColor = System.Drawing.Color.White;
            this.btnConsultar.Location = new System.Drawing.Point(93, 401);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(283, 59);
            this.btnConsultar.TabIndex = 72;
            this.btnConsultar.Text = "Inserir";
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(btnConsultar_Click);
            // 
            // lblConsultarIdPredio
            // 
            this.lblConsultarIdPredio.AutoSize = true;
            this.lblConsultarIdPredio.Location = new System.Drawing.Point(15, 358);
            this.lblConsultarIdPredio.Name = "lblConsultarIdPredio";
            this.lblConsultarIdPredio.Size = new System.Drawing.Size(100, 15);
            this.lblConsultarIdPredio.TabIndex = 74;
            this.lblConsultarIdPredio.Text = "Código do Prédio";
            // 
            // lblConsultarIdCondominio
            // 
            this.lblConsultarIdCondominio.AutoSize = true;
            this.lblConsultarIdCondominio.Location = new System.Drawing.Point(15, 303);
            this.lblConsultarIdCondominio.Name = "lblConsultarIdCondominio";
            this.lblConsultarIdCondominio.Size = new System.Drawing.Size(133, 15);
            this.lblConsultarIdCondominio.TabIndex = 73;
            this.lblConsultarIdCondominio.Text = "Código do Condomínio";
            // 
            // lblConsultarCodigoApartamento
            // 
            this.lblConsultarCodigoApartamento.AutoSize = true;
            this.lblConsultarCodigoApartamento.Location = new System.Drawing.Point(293, 358);
            this.lblConsultarCodigoApartamento.Name = "lblConsultarCodigoApartamento";
            this.lblConsultarCodigoApartamento.Size = new System.Drawing.Size(136, 15);
            this.lblConsultarCodigoApartamento.TabIndex = 75;
            this.lblConsultarCodigoApartamento.Text = "Código do Apartamento";
            // 
            // lblConsultarCodigoMorador
            // 
            this.lblConsultarCodigoMorador.AutoSize = true;
            this.lblConsultarCodigoMorador.Location = new System.Drawing.Point(317, 303);
            this.lblConsultarCodigoMorador.Name = "lblConsultarCodigoMorador";
            this.lblConsultarCodigoMorador.Size = new System.Drawing.Size(112, 15);
            this.lblConsultarCodigoMorador.TabIndex = 76;
            this.lblConsultarCodigoMorador.Text = "Código do Morador";
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
            this.groupApartamento.Location = new System.Drawing.Point(166, 338);
            this.groupApartamento.Name = "groupApartamento";
            this.groupApartamento.Size = new System.Drawing.Size(632, 183);
            this.groupApartamento.TabIndex = 69;
            this.groupApartamento.TabStop = false;
            this.groupApartamento.Text = "Dados do Apartamento";
            // 
            // ucModificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupConsultar);
            this.Controls.Add(this.groupOutrasFuncoes);
            this.Controls.Add(this.groupInserir);
            this.Controls.Add(this.groupApartamento);
            this.Controls.Add(this.groupLocal);
            this.Controls.Add(this.lblClose);
            this.Name = "ucModificar";
            this.Size = new System.Drawing.Size(1370, 800);
            this.groupInserir.ResumeLayout(false);
            this.groupLocal.ResumeLayout(false);
            this.groupLocal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumero)).EndInit();
            this.groupOutrasFuncoes.ResumeLayout(false);
            this.groupOutrasFuncoes.PerformLayout();
            this.groupConsultar.ResumeLayout(false);
            this.groupConsultar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudConsultarNumero)).EndInit();
            this.groupApartamento.ResumeLayout(false);
            this.groupApartamento.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ucModificar Modificar;
        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.GroupBox groupInserir;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.GroupBox groupLocal;
        private System.Windows.Forms.TextBox txtRamal;
        private System.Windows.Forms.TextBox txtBloco;
        private System.Windows.Forms.NumericUpDown nudNumero;
        private System.Windows.Forms.Label lblBloco;
        private System.Windows.Forms.Label lblRamal;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.GroupBox groupOutrasFuncoes;
        private System.Windows.Forms.LinkLabel lllDeletar;
        private System.Windows.Forms.LinkLabel lllConsultarTodos;
        private System.Windows.Forms.LinkLabel lllConsultar;
        private System.Windows.Forms.LinkLabel lllInserir;
        private System.Windows.Forms.GroupBox groupConsultar;
        private System.Windows.Forms.Label lblConsultarCodigoMorador;
        private System.Windows.Forms.Label lblConsultarCodigoApartamento;
        private System.Windows.Forms.Label lblConsultarIdPredio;
        private System.Windows.Forms.Label lblConsultarIdCondominio;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.TextBox txtConsultarBloco;
        private System.Windows.Forms.NumericUpDown nudConsultarNumero;
        private System.Windows.Forms.Label lblConsultarBloco;
        private System.Windows.Forms.Label lblConsultarNumero;
        private System.Windows.Forms.MaskedTextBox mtxConsultarMorador;
        private System.Windows.Forms.TextBox txtConsultarPredio;
        private System.Windows.Forms.TextBox txtConsultarCondominio;
        private System.Windows.Forms.Label lblConsultarPredio;
        private System.Windows.Forms.Label lblConsultarMorador;
        private System.Windows.Forms.Label lblConsultarCondominio;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblMorador;
        private System.Windows.Forms.Label lblPredio;
        private System.Windows.Forms.TextBox txtCondominio;
        private System.Windows.Forms.TextBox txtPredio;
        private System.Windows.Forms.MaskedTextBox mtxCPF;
        private System.Windows.Forms.Label lblIdCondominio;
        private System.Windows.Forms.Label lblIdPredio;
        private System.Windows.Forms.Label lblIdMorador;
        private System.Windows.Forms.GroupBox groupApartamento;
    }
}
