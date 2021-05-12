
namespace ServicoPortaria.Presentation.Visitante
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
            this.Modificar = new ServicoPortaria.Presentation.Visitante.ucModificar();
            this.lblClose = new System.Windows.Forms.Label();
            this.groupContato = new System.Windows.Forms.GroupBox();
            this.txtEMail = new System.Windows.Forms.TextBox();
            this.txtTelefoneFixo = new System.Windows.Forms.TextBox();
            this.txtCelular = new System.Windows.Forms.TextBox();
            this.lblEMail = new System.Windows.Forms.Label();
            this.lblFixo = new System.Windows.Forms.Label();
            this.lblCelular = new System.Windows.Forms.Label();
            this.groupInsert = new System.Windows.Forms.GroupBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.groupDocCivil = new System.Windows.Forms.GroupBox();
            this.txtSexo = new System.Windows.Forms.TextBox();
            this.txtDocCivil = new System.Windows.Forms.TextBox();
            this.mtxRG = new System.Windows.Forms.MaskedTextBox();
            this.mtxCPF = new System.Windows.Forms.MaskedTextBox();
            this.lblSexo = new System.Windows.Forms.Label();
            this.lblDocCivil = new System.Windows.Forms.Label();
            this.lblRG = new System.Windows.Forms.Label();
            this.lblCPF = new System.Windows.Forms.Label();
            this.groupNome = new System.Windows.Forms.GroupBox();
            this.txtSobrenome = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblSobrenome = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.groupModificar = new System.Windows.Forms.GroupBox();
            this.groupConsultar = new System.Windows.Forms.GroupBox();
            this.txtConsultarDocCivil = new System.Windows.Forms.TextBox();
            this.mtxConsultarRG = new System.Windows.Forms.MaskedTextBox();
            this.mtxConsultarCPF = new System.Windows.Forms.MaskedTextBox();
            this.lblConsultarDocCivil = new System.Windows.Forms.Label();
            this.lblConsultarRG = new System.Windows.Forms.Label();
            this.lblConsultarCPF = new System.Windows.Forms.Label();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.lblCodigoVisitante = new System.Windows.Forms.Label();
            this.groupContato.SuspendLayout();
            this.groupInsert.SuspendLayout();
            this.groupDocCivil.SuspendLayout();
            this.groupNome.SuspendLayout();
            this.groupModificar.SuspendLayout();
            this.groupConsultar.SuspendLayout();
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
            this.lblClose.TabIndex = 68;
            this.lblClose.Text = "X";
            this.lblClose.Click += new System.EventHandler(lblClose_Click);
            // 
            // groupContato
            // 
            this.groupContato.Controls.Add(this.txtEMail);
            this.groupContato.Controls.Add(this.txtTelefoneFixo);
            this.groupContato.Controls.Add(this.txtCelular);
            this.groupContato.Controls.Add(this.lblEMail);
            this.groupContato.Controls.Add(this.lblFixo);
            this.groupContato.Controls.Add(this.lblCelular);
            this.groupContato.Location = new System.Drawing.Point(18, 341);
            this.groupContato.Name = "groupContato";
            this.groupContato.Size = new System.Drawing.Size(444, 137);
            this.groupContato.TabIndex = 76;
            this.groupContato.TabStop = false;
            this.groupContato.Text = "Contato";
            // 
            // txtEMail
            // 
            this.txtEMail.Location = new System.Drawing.Point(190, 106);
            this.txtEMail.Name = "txtEMail";
            this.txtEMail.Size = new System.Drawing.Size(232, 23);
            this.txtEMail.TabIndex = 70;
            // 
            // txtTelefoneFixo
            // 
            this.txtTelefoneFixo.Location = new System.Drawing.Point(190, 60);
            this.txtTelefoneFixo.Name = "txtTelefoneFixo";
            this.txtTelefoneFixo.Size = new System.Drawing.Size(232, 23);
            this.txtTelefoneFixo.TabIndex = 69;
            // 
            // txtCelular
            // 
            this.txtCelular.Location = new System.Drawing.Point(190, 12);
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(232, 23);
            this.txtCelular.TabIndex = 68;
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
            // lblFixo
            // 
            this.lblFixo.AutoSize = true;
            this.lblFixo.Location = new System.Drawing.Point(12, 63);
            this.lblFixo.Name = "lblFixo";
            this.lblFixo.Size = new System.Drawing.Size(76, 15);
            this.lblFixo.TabIndex = 66;
            this.lblFixo.Text = "Telefone Fixo";
            // 
            // lblCelular
            // 
            this.lblCelular.AutoSize = true;
            this.lblCelular.Location = new System.Drawing.Point(12, 15);
            this.lblCelular.Name = "lblCelular";
            this.lblCelular.Size = new System.Drawing.Size(44, 15);
            this.lblCelular.TabIndex = 65;
            this.lblCelular.Text = "Celular";
            // 
            // groupInsert
            // 
            this.groupInsert.Controls.Add(this.btnModificar);
            this.groupInsert.Location = new System.Drawing.Point(89, 484);
            this.groupInsert.Name = "groupInsert";
            this.groupInsert.Size = new System.Drawing.Size(300, 101);
            this.groupInsert.TabIndex = 75;
            this.groupInsert.TabStop = false;
            this.groupInsert.Text = "Cadastrar";
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.Black;
            this.btnModificar.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnModificar.ForeColor = System.Drawing.Color.White;
            this.btnModificar.Location = new System.Drawing.Point(25, 22);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(269, 62);
            this.btnModificar.TabIndex = 0;
            this.btnModificar.Text = "Modificar Dados";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(btnModificar_Click);
            // 
            // groupDocCivil
            // 
            this.groupDocCivil.Controls.Add(this.txtSexo);
            this.groupDocCivil.Controls.Add(this.txtDocCivil);
            this.groupDocCivil.Controls.Add(this.mtxRG);
            this.groupDocCivil.Controls.Add(this.mtxCPF);
            this.groupDocCivil.Controls.Add(this.lblSexo);
            this.groupDocCivil.Controls.Add(this.lblDocCivil);
            this.groupDocCivil.Controls.Add(this.lblRG);
            this.groupDocCivil.Controls.Add(this.lblCPF);
            this.groupDocCivil.Location = new System.Drawing.Point(18, 146);
            this.groupDocCivil.Name = "groupDocCivil";
            this.groupDocCivil.Size = new System.Drawing.Size(444, 188);
            this.groupDocCivil.TabIndex = 74;
            this.groupDocCivil.TabStop = false;
            this.groupDocCivil.Text = "Documentação Civil";
            // 
            // txtSexo
            // 
            this.txtSexo.Location = new System.Drawing.Point(190, 148);
            this.txtSexo.Name = "txtSexo";
            this.txtSexo.Size = new System.Drawing.Size(232, 23);
            this.txtSexo.TabIndex = 63;
            // 
            // txtDocCivil
            // 
            this.txtDocCivil.Location = new System.Drawing.Point(190, 107);
            this.txtDocCivil.Name = "txtDocCivil";
            this.txtDocCivil.Size = new System.Drawing.Size(232, 23);
            this.txtDocCivil.TabIndex = 62;
            // 
            // mtxRG
            // 
            this.mtxRG.Location = new System.Drawing.Point(190, 64);
            this.mtxRG.Mask = "00.000.000-0";
            this.mtxRG.Name = "mtxRG";
            this.mtxRG.Size = new System.Drawing.Size(232, 23);
            this.mtxRG.TabIndex = 61;
            // 
            // mtxCPF
            // 
            this.mtxCPF.Location = new System.Drawing.Point(190, 18);
            this.mtxCPF.Mask = "000.000.000-00";
            this.mtxCPF.Name = "mtxCPF";
            this.mtxCPF.Size = new System.Drawing.Size(232, 23);
            this.mtxCPF.TabIndex = 60;
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
            // lblDocCivil
            // 
            this.lblDocCivil.AutoSize = true;
            this.lblDocCivil.Location = new System.Drawing.Point(12, 110);
            this.lblDocCivil.Name = "lblDocCivil";
            this.lblDocCivil.Size = new System.Drawing.Size(96, 15);
            this.lblDocCivil.TabIndex = 58;
            this.lblDocCivil.Text = "Documento Civil";
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
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Location = new System.Drawing.Point(12, 21);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(28, 15);
            this.lblCPF.TabIndex = 56;
            this.lblCPF.Text = "CPF";
            // 
            // groupNome
            // 
            this.groupNome.Controls.Add(this.txtSobrenome);
            this.groupNome.Controls.Add(this.txtNome);
            this.groupNome.Controls.Add(this.lblSobrenome);
            this.groupNome.Controls.Add(this.lblNome);
            this.groupNome.Location = new System.Drawing.Point(18, 15);
            this.groupNome.Name = "groupNome";
            this.groupNome.Size = new System.Drawing.Size(444, 125);
            this.groupNome.TabIndex = 73;
            this.groupNome.TabStop = false;
            this.groupNome.Text = "Nome do Visitante";
            // 
            // txtSobrenome
            // 
            this.txtSobrenome.Location = new System.Drawing.Point(190, 76);
            this.txtSobrenome.Name = "txtSobrenome";
            this.txtSobrenome.Size = new System.Drawing.Size(232, 23);
            this.txtSobrenome.TabIndex = 54;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(190, 32);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(232, 23);
            this.txtNome.TabIndex = 53;
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
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(12, 35);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(40, 15);
            this.lblNome.TabIndex = 51;
            this.lblNome.Text = "Nome";
            // 
            // groupModificar
            // 
            this.groupModificar.Controls.Add(this.groupContato);
            this.groupModificar.Controls.Add(this.groupInsert);
            this.groupModificar.Controls.Add(this.groupDocCivil);
            this.groupModificar.Controls.Add(this.groupNome);
            this.groupModificar.Location = new System.Drawing.Point(254, 90);
            this.groupModificar.Name = "groupModificar";
            this.groupModificar.Size = new System.Drawing.Size(485, 595);
            this.groupModificar.TabIndex = 77;
            this.groupModificar.TabStop = false;
            this.groupModificar.Text = "Modificar";
            // 
            // groupConsultar
            // 
            this.groupConsultar.Controls.Add(this.lblCodigoVisitante);
            this.groupConsultar.Controls.Add(this.btnConsultar);
            this.groupConsultar.Controls.Add(this.txtConsultarDocCivil);
            this.groupConsultar.Controls.Add(this.mtxConsultarRG);
            this.groupConsultar.Controls.Add(this.mtxConsultarCPF);
            this.groupConsultar.Controls.Add(this.lblConsultarDocCivil);
            this.groupConsultar.Controls.Add(this.lblConsultarRG);
            this.groupConsultar.Controls.Add(this.lblConsultarCPF);
            this.groupConsultar.Location = new System.Drawing.Point(792, 90);
            this.groupConsultar.Name = "groupConsultar";
            this.groupConsultar.Size = new System.Drawing.Size(442, 334);
            this.groupConsultar.TabIndex = 78;
            this.groupConsultar.TabStop = false;
            this.groupConsultar.Text = "Consultar";
            // 
            // txtConsultarDocCivil
            // 
            this.txtConsultarDocCivil.Location = new System.Drawing.Point(195, 131);
            this.txtConsultarDocCivil.Name = "txtConsultarDocCivil";
            this.txtConsultarDocCivil.Size = new System.Drawing.Size(232, 23);
            this.txtConsultarDocCivil.TabIndex = 68;
            // 
            // mtxConsultarRG
            // 
            this.mtxConsultarRG.Location = new System.Drawing.Point(195, 88);
            this.mtxConsultarRG.Mask = "00.000.000-0";
            this.mtxConsultarRG.Name = "mtxConsultarRG";
            this.mtxConsultarRG.Size = new System.Drawing.Size(232, 23);
            this.mtxConsultarRG.TabIndex = 67;
            // 
            // mtxConsultarCPF
            // 
            this.mtxConsultarCPF.Location = new System.Drawing.Point(195, 42);
            this.mtxConsultarCPF.Mask = "000.000.000-00";
            this.mtxConsultarCPF.Name = "mtxConsultarCPF";
            this.mtxConsultarCPF.Size = new System.Drawing.Size(232, 23);
            this.mtxConsultarCPF.TabIndex = 66;
            // 
            // lblConsultarDocCivil
            // 
            this.lblConsultarDocCivil.AutoSize = true;
            this.lblConsultarDocCivil.Location = new System.Drawing.Point(17, 134);
            this.lblConsultarDocCivil.Name = "lblConsultarDocCivil";
            this.lblConsultarDocCivil.Size = new System.Drawing.Size(96, 15);
            this.lblConsultarDocCivil.TabIndex = 65;
            this.lblConsultarDocCivil.Text = "Documento Civil";
            // 
            // lblConsultarRG
            // 
            this.lblConsultarRG.AutoSize = true;
            this.lblConsultarRG.Location = new System.Drawing.Point(17, 91);
            this.lblConsultarRG.Name = "lblConsultarRG";
            this.lblConsultarRG.Size = new System.Drawing.Size(22, 15);
            this.lblConsultarRG.TabIndex = 64;
            this.lblConsultarRG.Text = "RG";
            // 
            // lblConsultarCPF
            // 
            this.lblConsultarCPF.AutoSize = true;
            this.lblConsultarCPF.Location = new System.Drawing.Point(17, 45);
            this.lblConsultarCPF.Name = "lblConsultarCPF";
            this.lblConsultarCPF.Size = new System.Drawing.Size(28, 15);
            this.lblConsultarCPF.TabIndex = 63;
            this.lblConsultarCPF.Text = "CPF";
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.Color.Black;
            this.btnConsultar.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnConsultar.ForeColor = System.Drawing.Color.White;
            this.btnConsultar.Location = new System.Drawing.Point(85, 233);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(280, 79);
            this.btnConsultar.TabIndex = 69;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(btnConsultar_Click);
            // 
            // lblCodigoVisitante
            // 
            this.lblCodigoVisitante.AutoSize = true;
            this.lblCodigoVisitante.Location = new System.Drawing.Point(17, 183);
            this.lblCodigoVisitante.Name = "lblCodigoVisitante";
            this.lblCodigoVisitante.Size = new System.Drawing.Size(82, 15);
            this.lblCodigoVisitante.TabIndex = 70;
            this.lblCodigoVisitante.Text = "Id do Visitante";
            // 
            // ucModificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupConsultar);
            this.Controls.Add(this.groupModificar);
            this.Controls.Add(this.lblClose);
            this.Name = "ucModificar";
            this.Size = new System.Drawing.Size(1370, 800);
            this.Load += new System.EventHandler(ucModificar_Load);
            this.groupContato.ResumeLayout(false);
            this.groupContato.PerformLayout();
            this.groupInsert.ResumeLayout(false);
            this.groupDocCivil.ResumeLayout(false);
            this.groupDocCivil.PerformLayout();
            this.groupNome.ResumeLayout(false);
            this.groupNome.PerformLayout();
            this.groupModificar.ResumeLayout(false);
            this.groupConsultar.ResumeLayout(false);
            this.groupConsultar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ucModificar Modificar;
        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.GroupBox groupContato;
        private System.Windows.Forms.TextBox txtEMail;
        private System.Windows.Forms.TextBox txtTelefoneFixo;
        private System.Windows.Forms.TextBox txtCelular;
        private System.Windows.Forms.Label lblEMail;
        private System.Windows.Forms.Label lblFixo;
        private System.Windows.Forms.Label lblCelular;
        private System.Windows.Forms.GroupBox groupInsert;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.GroupBox groupDocCivil;
        private System.Windows.Forms.TextBox txtSexo;
        private System.Windows.Forms.TextBox txtDocCivil;
        private System.Windows.Forms.MaskedTextBox mtxRG;
        private System.Windows.Forms.MaskedTextBox mtxCPF;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.Label lblDocCivil;
        private System.Windows.Forms.Label lblRG;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.GroupBox groupNome;
        private System.Windows.Forms.TextBox txtSobrenome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblSobrenome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.GroupBox groupModificar;
        private System.Windows.Forms.GroupBox groupConsultar;
        private System.Windows.Forms.Label lblCodigoVisitante;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.TextBox txtConsultarDocCivil;
        private System.Windows.Forms.MaskedTextBox mtxConsultarRG;
        private System.Windows.Forms.MaskedTextBox mtxConsultarCPF;
        private System.Windows.Forms.Label lblConsultarDocCivil;
        private System.Windows.Forms.Label lblConsultarRG;
        private System.Windows.Forms.Label lblConsultarCPF;
    }
}
