
namespace ServicoPortaria.Presentation.Predio
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
            this.Modificar = new ServicoPortaria.Presentation.Predio.ucModificar();
            this.lblClose = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.lblIdCondominio = new System.Windows.Forms.Label();
            this.nudNumero = new System.Windows.Forms.NumericUpDown();
            this.txtCondominio = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblCondominio = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.btnConsultarPredio = new System.Windows.Forms.Button();
            this.lblIdPredio = new System.Windows.Forms.Label();
            this.nudConsultarNumero = new System.Windows.Forms.NumericUpDown();
            this.txtConsultarNome = new System.Windows.Forms.TextBox();
            this.lblConsultarNumero = new System.Windows.Forms.Label();
            this.lblConsultarNome = new System.Windows.Forms.Label();
            this.groupUpdate = new System.Windows.Forms.GroupBox();
            this.groupConsulta = new System.Windows.Forms.GroupBox();
            this.groupUpdate.SuspendLayout();
            this.groupConsulta.SuspendLayout();
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
            this.lblClose.TabIndex = 66;
            this.lblClose.Text = "X";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.Black;
            this.btnCadastrar.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCadastrar.ForeColor = System.Drawing.Color.White;
            this.btnCadastrar.Location = new System.Drawing.Point(68, 238);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(259, 58);
            this.btnCadastrar.TabIndex = 74;
            this.btnCadastrar.Text = "Cadastrar Prédio";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(btnModificar_Click);
            // 
            // lblIdCondominio
            // 
            this.lblIdCondominio.AutoSize = true;
            this.lblIdCondominio.Location = new System.Drawing.Point(22, 200);
            this.lblIdCondominio.Name = "lblIdCondominio";
            this.lblIdCondominio.Size = new System.Drawing.Size(119, 15);
            this.lblIdCondominio.TabIndex = 73;
            this.lblIdCondominio.Text = "Cód. do Condomínio";
            // 
            // nudNumero
            // 
            this.nudNumero.Location = new System.Drawing.Point(171, 78);
            this.nudNumero.Name = "nudNumero";
            this.nudNumero.Size = new System.Drawing.Size(207, 23);
            this.nudNumero.TabIndex = 72;
            // 
            // txtCondominio
            // 
            this.txtCondominio.Location = new System.Drawing.Point(171, 134);
            this.txtCondominio.Name = "txtCondominio";
            this.txtCondominio.Size = new System.Drawing.Size(207, 23);
            this.txtCondominio.TabIndex = 71;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(171, 26);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(207, 23);
            this.txtNome.TabIndex = 70;
            // 
            // lblCondominio
            // 
            this.lblCondominio.AutoSize = true;
            this.lblCondominio.Location = new System.Drawing.Point(22, 137);
            this.lblCondominio.Name = "lblCondominio";
            this.lblCondominio.Size = new System.Drawing.Size(74, 15);
            this.lblCondominio.TabIndex = 69;
            this.lblCondominio.Text = "Condomínio";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(22, 80);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(51, 15);
            this.lblNumero.TabIndex = 68;
            this.lblNumero.Text = "Número";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(22, 29);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(40, 15);
            this.lblNome.TabIndex = 67;
            this.lblNome.Text = "Nome";
            // 
            // btnConsultarPredio
            // 
            this.btnConsultarPredio.BackColor = System.Drawing.Color.Black;
            this.btnConsultarPredio.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnConsultarPredio.ForeColor = System.Drawing.Color.White;
            this.btnConsultarPredio.Location = new System.Drawing.Point(863, 452);
            this.btnConsultarPredio.Name = "btnConsultarPredio";
            this.btnConsultarPredio.Size = new System.Drawing.Size(259, 58);
            this.btnConsultarPredio.TabIndex = 82;
            this.btnConsultarPredio.Text = "Consultar Prédio";
            this.btnConsultarPredio.UseVisualStyleBackColor = false;
            this.btnConsultarPredio.Click += new System.EventHandler(btnConsultarPredio_Click);
            // 
            // lblIdPredio
            // 
            this.lblIdPredio.AutoSize = true;
            this.lblIdPredio.Location = new System.Drawing.Point(23, 197);
            this.lblIdPredio.Name = "lblIdPredio";
            this.lblIdPredio.Size = new System.Drawing.Size(86, 15);
            this.lblIdPredio.TabIndex = 81;
            this.lblIdPredio.Text = "Cód. do Prédio";
            // 
            // nudConsultarNumero
            // 
            this.nudConsultarNumero.Location = new System.Drawing.Point(172, 75);
            this.nudConsultarNumero.Name = "nudConsultarNumero";
            this.nudConsultarNumero.Size = new System.Drawing.Size(207, 23);
            this.nudConsultarNumero.TabIndex = 80;
            // 
            // txtConsultarNome
            // 
            this.txtConsultarNome.Location = new System.Drawing.Point(172, 23);
            this.txtConsultarNome.Name = "txtConsultarNome";
            this.txtConsultarNome.Size = new System.Drawing.Size(207, 23);
            this.txtConsultarNome.TabIndex = 78;
            // 
            // lblConsultarNumero
            // 
            this.lblConsultarNumero.AutoSize = true;
            this.lblConsultarNumero.Location = new System.Drawing.Point(23, 77);
            this.lblConsultarNumero.Name = "lblConsultarNumero";
            this.lblConsultarNumero.Size = new System.Drawing.Size(51, 15);
            this.lblConsultarNumero.TabIndex = 76;
            this.lblConsultarNumero.Text = "Número";
            // 
            // lblConsultarNome
            // 
            this.lblConsultarNome.AutoSize = true;
            this.lblConsultarNome.Location = new System.Drawing.Point(23, 26);
            this.lblConsultarNome.Name = "lblConsultarNome";
            this.lblConsultarNome.Size = new System.Drawing.Size(40, 15);
            this.lblConsultarNome.TabIndex = 75;
            this.lblConsultarNome.Text = "Nome";
            // 
            // groupUpdate
            // 
            this.groupUpdate.Controls.Add(this.btnCadastrar);
            this.groupUpdate.Controls.Add(this.lblIdCondominio);
            this.groupUpdate.Controls.Add(this.nudNumero);
            this.groupUpdate.Controls.Add(this.txtCondominio);
            this.groupUpdate.Controls.Add(this.txtNome);
            this.groupUpdate.Controls.Add(this.lblCondominio);
            this.groupUpdate.Controls.Add(this.lblNumero);
            this.groupUpdate.Controls.Add(this.lblNome);
            this.groupUpdate.Location = new System.Drawing.Point(266, 214);
            this.groupUpdate.Name = "groupUpdate";
            this.groupUpdate.Size = new System.Drawing.Size(402, 308);
            this.groupUpdate.TabIndex = 83;
            this.groupUpdate.TabStop = false;
            this.groupUpdate.Text = "Modificar Dados";
            // 
            // groupConsulta
            // 
            this.groupConsulta.Controls.Add(this.lblIdPredio);
            this.groupConsulta.Controls.Add(this.nudConsultarNumero);
            this.groupConsulta.Controls.Add(this.txtConsultarNome);
            this.groupConsulta.Controls.Add(this.lblConsultarNumero);
            this.groupConsulta.Controls.Add(this.lblConsultarNome);
            this.groupConsulta.Location = new System.Drawing.Point(794, 214);
            this.groupConsulta.Name = "groupConsulta";
            this.groupConsulta.Size = new System.Drawing.Size(412, 308);
            this.groupConsulta.TabIndex = 84;
            this.groupConsulta.TabStop = false;
            this.groupConsulta.Text = "Consultar Prédio";
            // 
            // ucModificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupUpdate);
            this.Controls.Add(this.btnConsultarPredio);
            this.Controls.Add(this.lblClose);
            this.Controls.Add(this.groupConsulta);
            this.Name = "ucModificar";
            this.Size = new System.Drawing.Size(1370, 800);
            this.Load += new System.EventHandler(ucModificar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudNumero)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudConsultarNumero)).EndInit();
            this.groupUpdate.ResumeLayout(false);
            this.groupUpdate.PerformLayout();
            this.groupConsulta.ResumeLayout(false);
            this.groupConsulta.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private ucModificar Modificar;
        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label lblIdCondominio;
        private System.Windows.Forms.NumericUpDown nudNumero;
        private System.Windows.Forms.TextBox txtCondominio;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblCondominio;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Button btnConsultarPredio;
        private System.Windows.Forms.Label lblIdPredio;
        private System.Windows.Forms.NumericUpDown nudConsultarNumero;
        private System.Windows.Forms.TextBox txtConsultarNome;
        private System.Windows.Forms.Label lblConsultarNumero;
        private System.Windows.Forms.Label lblConsultarNome;
        private System.Windows.Forms.GroupBox groupUpdate;
        private System.Windows.Forms.GroupBox groupConsulta;
    }
}
