
namespace ServicoPortaria.Presentation.PrestadorDeServicos
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
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.txtCondominio = new System.Windows.Forms.TextBox();
            this.txtNomePredio = new System.Windows.Forms.TextBox();
            this.mtxCPF = new System.Windows.Forms.MaskedTextBox();
            this.mtxCNPJ = new System.Windows.Forms.MaskedTextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblCondominio = new System.Windows.Forms.Label();
            this.lblPredio = new System.Windows.Forms.Label();
            this.lblCPF = new System.Windows.Forms.Label();
            this.lblCNPJ = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.groupCadastro = new System.Windows.Forms.GroupBox();
            this.dtpHoraSaida = new System.Windows.Forms.DateTimePicker();
            this.dtpHoraChegada = new System.Windows.Forms.DateTimePicker();
            this.dtpDataSaida = new System.Windows.Forms.DateTimePicker();
            this.dtpDataChegada = new System.Windows.Forms.DateTimePicker();
            this.lblHoraDaSaida = new System.Windows.Forms.Label();
            this.lblHoraChegada = new System.Windows.Forms.Label();
            this.lblDataSaida = new System.Windows.Forms.Label();
            this.lblDataChegada = new System.Windows.Forms.Label();
            this.lblCodCondominio = new System.Windows.Forms.Label();
            this.lblCodPredio = new System.Windows.Forms.Label();
            this.groupConsulta = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpConsultarDataChegada = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpConsultarDataSaida = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpConsultarHoraChegada = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpConsultarHoraSaida = new System.Windows.Forms.DateTimePicker();
            this.btnConsulta = new System.Windows.Forms.Button();
            this.lblCodPrestador = new System.Windows.Forms.Label();
            this.mtxConsultaCPF = new System.Windows.Forms.MaskedTextBox();
            this.mtxConsultaCNPJ = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupCadastro.SuspendLayout();
            this.groupConsulta.SuspendLayout();
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
            this.lblClose.TabIndex = 82;
            this.lblClose.Text = "X";
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.Black;
            this.btnCadastrar.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCadastrar.ForeColor = System.Drawing.Color.White;
            this.btnCadastrar.Location = new System.Drawing.Point(103, 496);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(267, 69);
            this.btnCadastrar.TabIndex = 93;
            this.btnCadastrar.Text = "Modificar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // txtCondominio
            // 
            this.txtCondominio.Location = new System.Drawing.Point(137, 183);
            this.txtCondominio.Name = "txtCondominio";
            this.txtCondominio.Size = new System.Drawing.Size(218, 23);
            this.txtCondominio.TabIndex = 92;
            // 
            // txtNomePredio
            // 
            this.txtNomePredio.Location = new System.Drawing.Point(137, 140);
            this.txtNomePredio.Name = "txtNomePredio";
            this.txtNomePredio.Size = new System.Drawing.Size(218, 23);
            this.txtNomePredio.TabIndex = 91;
            // 
            // mtxCPF
            // 
            this.mtxCPF.Location = new System.Drawing.Point(137, 97);
            this.mtxCPF.Mask = "000.000.000-00";
            this.mtxCPF.Name = "mtxCPF";
            this.mtxCPF.Size = new System.Drawing.Size(218, 23);
            this.mtxCPF.TabIndex = 90;
            // 
            // mtxCNPJ
            // 
            this.mtxCNPJ.Location = new System.Drawing.Point(137, 57);
            this.mtxCNPJ.Mask = "00.000.000/0000-00";
            this.mtxCNPJ.Name = "mtxCNPJ";
            this.mtxCNPJ.Size = new System.Drawing.Size(218, 23);
            this.mtxCNPJ.TabIndex = 89;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(137, 17);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(218, 23);
            this.txtNome.TabIndex = 88;
            // 
            // lblCondominio
            // 
            this.lblCondominio.AutoSize = true;
            this.lblCondominio.Location = new System.Drawing.Point(15, 186);
            this.lblCondominio.Name = "lblCondominio";
            this.lblCondominio.Size = new System.Drawing.Size(74, 15);
            this.lblCondominio.TabIndex = 87;
            this.lblCondominio.Text = "Condomínio";
            // 
            // lblPredio
            // 
            this.lblPredio.AutoSize = true;
            this.lblPredio.Location = new System.Drawing.Point(15, 143);
            this.lblPredio.Name = "lblPredio";
            this.lblPredio.Size = new System.Drawing.Size(94, 15);
            this.lblPredio.TabIndex = 86;
            this.lblPredio.Text = "Nome do Prédio";
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Location = new System.Drawing.Point(15, 100);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(28, 15);
            this.lblCPF.TabIndex = 85;
            this.lblCPF.Text = "CPF";
            // 
            // lblCNPJ
            // 
            this.lblCNPJ.AutoSize = true;
            this.lblCNPJ.Location = new System.Drawing.Point(15, 60);
            this.lblCNPJ.Name = "lblCNPJ";
            this.lblCNPJ.Size = new System.Drawing.Size(34, 15);
            this.lblCNPJ.TabIndex = 84;
            this.lblCNPJ.Text = "CNPJ";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(15, 20);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(40, 15);
            this.lblNome.TabIndex = 83;
            this.lblNome.Text = "Nome";
            // 
            // groupCadastro
            // 
            this.groupCadastro.Controls.Add(this.dtpHoraSaida);
            this.groupCadastro.Controls.Add(this.dtpHoraChegada);
            this.groupCadastro.Controls.Add(this.dtpDataSaida);
            this.groupCadastro.Controls.Add(this.dtpDataChegada);
            this.groupCadastro.Controls.Add(this.lblHoraDaSaida);
            this.groupCadastro.Controls.Add(this.lblHoraChegada);
            this.groupCadastro.Controls.Add(this.lblDataSaida);
            this.groupCadastro.Controls.Add(this.lblDataChegada);
            this.groupCadastro.Controls.Add(this.lblCodCondominio);
            this.groupCadastro.Controls.Add(this.lblCodPredio);
            this.groupCadastro.Controls.Add(this.btnCadastrar);
            this.groupCadastro.Controls.Add(this.txtCondominio);
            this.groupCadastro.Controls.Add(this.txtNomePredio);
            this.groupCadastro.Controls.Add(this.mtxCPF);
            this.groupCadastro.Controls.Add(this.mtxCNPJ);
            this.groupCadastro.Controls.Add(this.txtNome);
            this.groupCadastro.Controls.Add(this.lblCondominio);
            this.groupCadastro.Controls.Add(this.lblPredio);
            this.groupCadastro.Controls.Add(this.lblCPF);
            this.groupCadastro.Controls.Add(this.lblCNPJ);
            this.groupCadastro.Controls.Add(this.lblNome);
            this.groupCadastro.Location = new System.Drawing.Point(306, 144);
            this.groupCadastro.Name = "groupCadastro";
            this.groupCadastro.Size = new System.Drawing.Size(479, 583);
            this.groupCadastro.TabIndex = 94;
            this.groupCadastro.TabStop = false;
            this.groupCadastro.Text = "Atualização de Dados";
            // 
            // dtpHoraSaida
            // 
            this.dtpHoraSaida.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHoraSaida.Location = new System.Drawing.Point(137, 459);
            this.dtpHoraSaida.Name = "dtpHoraSaida";
            this.dtpHoraSaida.Size = new System.Drawing.Size(218, 23);
            this.dtpHoraSaida.TabIndex = 103;
            // 
            // dtpHoraChegada
            // 
            this.dtpHoraChegada.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHoraChegada.Location = new System.Drawing.Point(137, 407);
            this.dtpHoraChegada.Name = "dtpHoraChegada";
            this.dtpHoraChegada.Size = new System.Drawing.Size(218, 23);
            this.dtpHoraChegada.TabIndex = 102;
            // 
            // dtpDataSaida
            // 
            this.dtpDataSaida.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataSaida.Location = new System.Drawing.Point(137, 353);
            this.dtpDataSaida.Name = "dtpDataSaida";
            this.dtpDataSaida.Size = new System.Drawing.Size(218, 23);
            this.dtpDataSaida.TabIndex = 101;
            // 
            // dtpDataChegada
            // 
            this.dtpDataChegada.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataChegada.Location = new System.Drawing.Point(137, 299);
            this.dtpDataChegada.Name = "dtpDataChegada";
            this.dtpDataChegada.Size = new System.Drawing.Size(218, 23);
            this.dtpDataChegada.TabIndex = 100;
            // 
            // lblHoraDaSaida
            // 
            this.lblHoraDaSaida.AutoSize = true;
            this.lblHoraDaSaida.Location = new System.Drawing.Point(15, 465);
            this.lblHoraDaSaida.Name = "lblHoraDaSaida";
            this.lblHoraDaSaida.Size = new System.Drawing.Size(80, 15);
            this.lblHoraDaSaida.TabIndex = 99;
            this.lblHoraDaSaida.Text = "Hora da Saída";
            // 
            // lblHoraChegada
            // 
            this.lblHoraChegada.AutoSize = true;
            this.lblHoraChegada.Location = new System.Drawing.Point(15, 413);
            this.lblHoraChegada.Name = "lblHoraChegada";
            this.lblHoraChegada.Size = new System.Drawing.Size(99, 15);
            this.lblHoraChegada.TabIndex = 98;
            this.lblHoraChegada.Text = "Hora da Chegada";
            // 
            // lblDataSaida
            // 
            this.lblDataSaida.AutoSize = true;
            this.lblDataSaida.Location = new System.Drawing.Point(15, 359);
            this.lblDataSaida.Name = "lblDataSaida";
            this.lblDataSaida.Size = new System.Drawing.Size(78, 15);
            this.lblDataSaida.TabIndex = 97;
            this.lblDataSaida.Text = "Data da Saída";
            // 
            // lblDataChegada
            // 
            this.lblDataChegada.AutoSize = true;
            this.lblDataChegada.Location = new System.Drawing.Point(15, 305);
            this.lblDataChegada.Name = "lblDataChegada";
            this.lblDataChegada.Size = new System.Drawing.Size(97, 15);
            this.lblDataChegada.TabIndex = 96;
            this.lblDataChegada.Text = "Data da Chegada";
            // 
            // lblCodCondominio
            // 
            this.lblCodCondominio.AutoSize = true;
            this.lblCodCondominio.Location = new System.Drawing.Point(162, 276);
            this.lblCodCondominio.Name = "lblCodCondominio";
            this.lblCodCondominio.Size = new System.Drawing.Size(133, 15);
            this.lblCodCondominio.TabIndex = 95;
            this.lblCodCondominio.Text = "Código do Condomínio";
            // 
            // lblCodPredio
            // 
            this.lblCodPredio.AutoSize = true;
            this.lblCodPredio.Location = new System.Drawing.Point(178, 234);
            this.lblCodPredio.Name = "lblCodPredio";
            this.lblCodPredio.Size = new System.Drawing.Size(100, 15);
            this.lblCodPredio.TabIndex = 94;
            this.lblCodPredio.Text = "Código do Prédio";
            // 
            // groupConsulta
            // 
            this.groupConsulta.Controls.Add(this.label3);
            this.groupConsulta.Controls.Add(this.dtpConsultarDataChegada);
            this.groupConsulta.Controls.Add(this.label4);
            this.groupConsulta.Controls.Add(this.dtpConsultarDataSaida);
            this.groupConsulta.Controls.Add(this.label5);
            this.groupConsulta.Controls.Add(this.dtpConsultarHoraChegada);
            this.groupConsulta.Controls.Add(this.label6);
            this.groupConsulta.Controls.Add(this.dtpConsultarHoraSaida);
            this.groupConsulta.Controls.Add(this.btnConsulta);
            this.groupConsulta.Controls.Add(this.lblCodPrestador);
            this.groupConsulta.Controls.Add(this.mtxConsultaCPF);
            this.groupConsulta.Controls.Add(this.mtxConsultaCNPJ);
            this.groupConsulta.Controls.Add(this.label1);
            this.groupConsulta.Controls.Add(this.label2);
            this.groupConsulta.Location = new System.Drawing.Point(804, 144);
            this.groupConsulta.Name = "groupConsulta";
            this.groupConsulta.Size = new System.Drawing.Size(428, 583);
            this.groupConsulta.TabIndex = 95;
            this.groupConsulta.TabStop = false;
            this.groupConsulta.Text = "Consulta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 413);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 15);
            this.label3.TabIndex = 107;
            this.label3.Text = "Hora da Saída";
            // 
            // dtpConsultarDataChegada
            // 
            this.dtpConsultarDataChegada.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpConsultarDataChegada.Location = new System.Drawing.Point(160, 234);
            this.dtpConsultarDataChegada.Name = "dtpConsultarDataChegada";
            this.dtpConsultarDataChegada.Size = new System.Drawing.Size(218, 23);
            this.dtpConsultarDataChegada.TabIndex = 108;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(0, 359);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 15);
            this.label4.TabIndex = 106;
            this.label4.Text = "Hora da Chegada";
            // 
            // dtpConsultarDataSaida
            // 
            this.dtpConsultarDataSaida.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpConsultarDataSaida.Location = new System.Drawing.Point(160, 299);
            this.dtpConsultarDataSaida.Name = "dtpConsultarDataSaida";
            this.dtpConsultarDataSaida.Size = new System.Drawing.Size(218, 23);
            this.dtpConsultarDataSaida.TabIndex = 109;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 305);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 15);
            this.label5.TabIndex = 105;
            this.label5.Text = "Data da Saída";
            // 
            // dtpConsultarHoraChegada
            // 
            this.dtpConsultarHoraChegada.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpConsultarHoraChegada.Location = new System.Drawing.Point(160, 353);
            this.dtpConsultarHoraChegada.Name = "dtpConsultarHoraChegada";
            this.dtpConsultarHoraChegada.Size = new System.Drawing.Size(218, 23);
            this.dtpConsultarHoraChegada.TabIndex = 110;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 240);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 15);
            this.label6.TabIndex = 104;
            this.label6.Text = "Data da Chegada";
            // 
            // dtpConsultarHoraSaida
            // 
            this.dtpConsultarHoraSaida.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpConsultarHoraSaida.Location = new System.Drawing.Point(160, 407);
            this.dtpConsultarHoraSaida.Name = "dtpConsultarHoraSaida";
            this.dtpConsultarHoraSaida.Size = new System.Drawing.Size(218, 23);
            this.dtpConsultarHoraSaida.TabIndex = 111;
            // 
            // btnConsulta
            // 
            this.btnConsulta.BackColor = System.Drawing.Color.Black;
            this.btnConsulta.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnConsulta.ForeColor = System.Drawing.Color.White;
            this.btnConsulta.Location = new System.Drawing.Point(59, 496);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(319, 69);
            this.btnConsulta.TabIndex = 96;
            this.btnConsulta.Text = "Consultar";
            this.btnConsulta.UseVisualStyleBackColor = false;
            this.btnConsulta.Click += new System.EventHandler(this.btnConsulta_Click);
            // 
            // lblCodPrestador
            // 
            this.lblCodPrestador.AutoSize = true;
            this.lblCodPrestador.Location = new System.Drawing.Point(160, 148);
            this.lblCodPrestador.Name = "lblCodPrestador";
            this.lblCodPrestador.Size = new System.Drawing.Size(116, 15);
            this.lblCodPrestador.TabIndex = 95;
            this.lblCodPrestador.Text = "Código do Prestador";
            // 
            // mtxConsultaCPF
            // 
            this.mtxConsultaCPF.Location = new System.Drawing.Point(160, 111);
            this.mtxConsultaCPF.Mask = "000.000.000-00";
            this.mtxConsultaCPF.Name = "mtxConsultaCPF";
            this.mtxConsultaCPF.Size = new System.Drawing.Size(218, 23);
            this.mtxConsultaCPF.TabIndex = 94;
            // 
            // mtxConsultaCNPJ
            // 
            this.mtxConsultaCNPJ.Location = new System.Drawing.Point(160, 71);
            this.mtxConsultaCNPJ.Mask = "00.000.000/0000-00";
            this.mtxConsultaCNPJ.Name = "mtxConsultaCNPJ";
            this.mtxConsultaCNPJ.Size = new System.Drawing.Size(218, 23);
            this.mtxConsultaCNPJ.TabIndex = 93;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 15);
            this.label1.TabIndex = 92;
            this.label1.Text = "CPF";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 15);
            this.label2.TabIndex = 91;
            this.label2.Text = "CNPJ";
            // 
            // ucModificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupConsulta);
            this.Controls.Add(this.lblClose);
            this.Controls.Add(this.groupCadastro);
            this.Name = "ucModificar";
            this.Size = new System.Drawing.Size(1370, 800);
            this.Load += new System.EventHandler(this.ucModificar_Load);
            this.groupCadastro.ResumeLayout(false);
            this.groupCadastro.PerformLayout();
            this.groupConsulta.ResumeLayout(false);
            this.groupConsulta.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.TextBox txtCondominio;
        private System.Windows.Forms.TextBox txtNomePredio;
        private System.Windows.Forms.MaskedTextBox mtxCPF;
        private System.Windows.Forms.MaskedTextBox mtxCNPJ;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblCondominio;
        private System.Windows.Forms.Label lblPredio;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.Label lblCNPJ;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.GroupBox groupCadastro;
        private System.Windows.Forms.GroupBox groupConsulta;
        private System.Windows.Forms.Label lblCodCondominio;
        private System.Windows.Forms.Label lblCodPredio;
        private System.Windows.Forms.Button btnConsulta;
        private System.Windows.Forms.Label lblCodPrestador;
        private System.Windows.Forms.MaskedTextBox mtxConsultaCPF;
        private System.Windows.Forms.MaskedTextBox mtxConsultaCNPJ;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpHoraSaida;
        private System.Windows.Forms.DateTimePicker dtpHoraChegada;
        private System.Windows.Forms.DateTimePicker dtpDataSaida;
        private System.Windows.Forms.DateTimePicker dtpDataChegada;
        private System.Windows.Forms.Label lblHoraDaSaida;
        private System.Windows.Forms.Label lblHoraChegada;
        private System.Windows.Forms.Label lblDataSaida;
        private System.Windows.Forms.Label lblDataChegada;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpConsultarDataChegada;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpConsultarDataSaida;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpConsultarHoraChegada;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpConsultarHoraSaida;
    }
}
