
namespace ServicoPortaria.Presentation.Veiculo
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
            this.Modificar = new ServicoPortaria.Presentation.Veiculo.ucModificar();
            this.groupCadastrar = new System.Windows.Forms.GroupBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.groupCarro = new System.Windows.Forms.GroupBox();
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.lblPlaca = new System.Windows.Forms.Label();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblModelo = new System.Windows.Forms.Label();
            this.groupInformacoes = new System.Windows.Forms.GroupBox();
            this.lblIdMorador = new System.Windows.Forms.Label();
            this.mtxCPF = new System.Windows.Forms.MaskedTextBox();
            this.lblCPFMorador = new System.Windows.Forms.Label();
            this.lblIdCondominio = new System.Windows.Forms.Label();
            this.lblIdPredio = new System.Windows.Forms.Label();
            this.txtCondominio = new System.Windows.Forms.TextBox();
            this.txtPredio = new System.Windows.Forms.TextBox();
            this.lblPredio = new System.Windows.Forms.Label();
            this.lblNomeCondominio = new System.Windows.Forms.Label();
            this.groupConsultar = new System.Windows.Forms.GroupBox();
            this.mtxConsultarMorador = new System.Windows.Forms.MaskedTextBox();
            this.lblConsultarMorador = new System.Windows.Forms.Label();
            this.txtConsultarPlaca = new System.Windows.Forms.TextBox();
            this.lblConsultarPlaca = new System.Windows.Forms.Label();
            this.txtConsultarModelo = new System.Windows.Forms.TextBox();
            this.txtConsultarMarca = new System.Windows.Forms.TextBox();
            this.lblConsultarMarca = new System.Windows.Forms.Label();
            this.lblConsultarModelo = new System.Windows.Forms.Label();
            this.lblIdVeiculo = new System.Windows.Forms.Label();
            this.groupFuncoes = new System.Windows.Forms.GroupBox();
            this.lllDeletar = new System.Windows.Forms.LinkLabel();
            this.lllConsultarTodos = new System.Windows.Forms.LinkLabel();
            this.lllConsultar = new System.Windows.Forms.LinkLabel();
            this.lllInserir = new System.Windows.Forms.LinkLabel();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.groupConsulta = new System.Windows.Forms.GroupBox();
            this.lblClose = new System.Windows.Forms.Label();
            this.groupCadastrar.SuspendLayout();
            this.groupCarro.SuspendLayout();
            this.groupInformacoes.SuspendLayout();
            this.groupConsultar.SuspendLayout();
            this.groupFuncoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupCadastrar
            // 
            this.groupCadastrar.Controls.Add(this.btnModificar);
            this.groupCadastrar.Location = new System.Drawing.Point(198, 548);
            this.groupCadastrar.Name = "groupCadastrar";
            this.groupCadastrar.Size = new System.Drawing.Size(434, 114);
            this.groupCadastrar.TabIndex = 77;
            this.groupCadastrar.TabStop = false;
            this.groupCadastrar.Text = "Cadastrar";
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.Black;
            this.btnModificar.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnModificar.ForeColor = System.Drawing.Color.White;
            this.btnModificar.Location = new System.Drawing.Point(28, 19);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(372, 84);
            this.btnModificar.TabIndex = 66;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(btnModificar_Click);
            // 
            // groupCarro
            // 
            this.groupCarro.Controls.Add(this.txtPlaca);
            this.groupCarro.Controls.Add(this.lblPlaca);
            this.groupCarro.Controls.Add(this.txtModelo);
            this.groupCarro.Controls.Add(this.txtMarca);
            this.groupCarro.Controls.Add(this.lblMarca);
            this.groupCarro.Controls.Add(this.lblModelo);
            this.groupCarro.Location = new System.Drawing.Point(198, 164);
            this.groupCarro.Name = "groupCarro";
            this.groupCarro.Size = new System.Drawing.Size(561, 192);
            this.groupCarro.TabIndex = 76;
            this.groupCarro.TabStop = false;
            this.groupCarro.Text = "Carro";
            // 
            // txtPlaca
            // 
            this.txtPlaca.Location = new System.Drawing.Point(263, 136);
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(251, 23);
            this.txtPlaca.TabIndex = 68;
            // 
            // lblPlaca
            // 
            this.lblPlaca.AutoSize = true;
            this.lblPlaca.Location = new System.Drawing.Point(0, 139);
            this.lblPlaca.Name = "lblPlaca";
            this.lblPlaca.Size = new System.Drawing.Size(35, 15);
            this.lblPlaca.TabIndex = 67;
            this.lblPlaca.Text = "Placa";
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(263, 81);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(251, 23);
            this.txtModelo.TabIndex = 60;
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(263, 28);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(251, 23);
            this.txtMarca.TabIndex = 59;
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(0, 31);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(40, 15);
            this.lblMarca.TabIndex = 57;
            this.lblMarca.Text = "Marca";
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Location = new System.Drawing.Point(0, 84);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(48, 15);
            this.lblModelo.TabIndex = 56;
            this.lblModelo.Text = "Modelo";
            // 
            // groupInformacoes
            // 
            this.groupInformacoes.Controls.Add(this.lblIdMorador);
            this.groupInformacoes.Controls.Add(this.mtxCPF);
            this.groupInformacoes.Controls.Add(this.lblCPFMorador);
            this.groupInformacoes.Controls.Add(this.lblIdCondominio);
            this.groupInformacoes.Controls.Add(this.lblIdPredio);
            this.groupInformacoes.Controls.Add(this.txtCondominio);
            this.groupInformacoes.Controls.Add(this.txtPredio);
            this.groupInformacoes.Controls.Add(this.lblPredio);
            this.groupInformacoes.Controls.Add(this.lblNomeCondominio);
            this.groupInformacoes.Location = new System.Drawing.Point(198, 362);
            this.groupInformacoes.Name = "groupInformacoes";
            this.groupInformacoes.Size = new System.Drawing.Size(747, 180);
            this.groupInformacoes.TabIndex = 75;
            this.groupInformacoes.TabStop = false;
            this.groupInformacoes.Text = "Informações";
            // 
            // lblIdMorador
            // 
            this.lblIdMorador.AutoSize = true;
            this.lblIdMorador.Location = new System.Drawing.Point(583, 38);
            this.lblIdMorador.Name = "lblIdMorador";
            this.lblIdMorador.Size = new System.Drawing.Size(112, 15);
            this.lblIdMorador.TabIndex = 71;
            this.lblIdMorador.Text = "Código do Morador";
            // 
            // mtxCPF
            // 
            this.mtxCPF.Location = new System.Drawing.Point(263, 35);
            this.mtxCPF.Mask = "000.000.000-00";
            this.mtxCPF.Name = "mtxCPF";
            this.mtxCPF.Size = new System.Drawing.Size(251, 23);
            this.mtxCPF.TabIndex = 70;
            // 
            // lblCPFMorador
            // 
            this.lblCPFMorador.AutoSize = true;
            this.lblCPFMorador.Location = new System.Drawing.Point(0, 38);
            this.lblCPFMorador.Name = "lblCPFMorador";
            this.lblCPFMorador.Size = new System.Drawing.Size(94, 15);
            this.lblCPFMorador.TabIndex = 69;
            this.lblCPFMorador.Text = "CPF do Morador";
            // 
            // lblIdCondominio
            // 
            this.lblIdCondominio.AutoSize = true;
            this.lblIdCondominio.Location = new System.Drawing.Point(583, 145);
            this.lblIdCondominio.Name = "lblIdCondominio";
            this.lblIdCondominio.Size = new System.Drawing.Size(133, 15);
            this.lblIdCondominio.TabIndex = 64;
            this.lblIdCondominio.Text = "Código do Condomínio";
            // 
            // lblIdPredio
            // 
            this.lblIdPredio.AutoSize = true;
            this.lblIdPredio.Location = new System.Drawing.Point(583, 92);
            this.lblIdPredio.Name = "lblIdPredio";
            this.lblIdPredio.Size = new System.Drawing.Size(100, 15);
            this.lblIdPredio.TabIndex = 63;
            this.lblIdPredio.Text = "Código do Prédio";
            // 
            // txtCondominio
            // 
            this.txtCondominio.Location = new System.Drawing.Point(263, 142);
            this.txtCondominio.Name = "txtCondominio";
            this.txtCondominio.Size = new System.Drawing.Size(251, 23);
            this.txtCondominio.TabIndex = 62;
            // 
            // txtPredio
            // 
            this.txtPredio.Location = new System.Drawing.Point(263, 88);
            this.txtPredio.Name = "txtPredio";
            this.txtPredio.Size = new System.Drawing.Size(251, 23);
            this.txtPredio.TabIndex = 61;
            // 
            // lblPredio
            // 
            this.lblPredio.AutoSize = true;
            this.lblPredio.Location = new System.Drawing.Point(0, 91);
            this.lblPredio.Name = "lblPredio";
            this.lblPredio.Size = new System.Drawing.Size(94, 15);
            this.lblPredio.TabIndex = 55;
            this.lblPredio.Text = "Nome do Prédio";
            // 
            // lblNomeCondominio
            // 
            this.lblNomeCondominio.AutoSize = true;
            this.lblNomeCondominio.Location = new System.Drawing.Point(0, 145);
            this.lblNomeCondominio.Name = "lblNomeCondominio";
            this.lblNomeCondominio.Size = new System.Drawing.Size(127, 15);
            this.lblNomeCondominio.TabIndex = 54;
            this.lblNomeCondominio.Text = "Nome do Condomínio";
            // 
            // groupConsultar
            // 
            this.groupConsultar.Controls.Add(this.mtxConsultarMorador);
            this.groupConsultar.Controls.Add(this.lblConsultarMorador);
            this.groupConsultar.Controls.Add(this.txtConsultarPlaca);
            this.groupConsultar.Controls.Add(this.lblConsultarPlaca);
            this.groupConsultar.Controls.Add(this.txtConsultarModelo);
            this.groupConsultar.Controls.Add(this.txtConsultarMarca);
            this.groupConsultar.Controls.Add(this.lblConsultarMarca);
            this.groupConsultar.Controls.Add(this.lblConsultarModelo);
            this.groupConsultar.Location = new System.Drawing.Point(765, 164);
            this.groupConsultar.Name = "groupConsultar";
            this.groupConsultar.Size = new System.Drawing.Size(561, 192);
            this.groupConsultar.TabIndex = 78;
            this.groupConsultar.TabStop = false;
            this.groupConsultar.Text = "Consultar";
            // 
            // mtxConsultarMorador
            // 
            this.mtxConsultarMorador.Location = new System.Drawing.Point(263, 115);
            this.mtxConsultarMorador.Mask = "000.000.000-00";
            this.mtxConsultarMorador.Name = "mtxConsultarMorador";
            this.mtxConsultarMorador.Size = new System.Drawing.Size(251, 23);
            this.mtxConsultarMorador.TabIndex = 72;
            // 
            // lblConsultarMorador
            // 
            this.lblConsultarMorador.AutoSize = true;
            this.lblConsultarMorador.Location = new System.Drawing.Point(0, 123);
            this.lblConsultarMorador.Name = "lblConsultarMorador";
            this.lblConsultarMorador.Size = new System.Drawing.Size(94, 15);
            this.lblConsultarMorador.TabIndex = 71;
            this.lblConsultarMorador.Text = "CPF do Morador";
            // 
            // txtConsultarPlaca
            // 
            this.txtConsultarPlaca.Location = new System.Drawing.Point(263, 86);
            this.txtConsultarPlaca.Name = "txtConsultarPlaca";
            this.txtConsultarPlaca.Size = new System.Drawing.Size(251, 23);
            this.txtConsultarPlaca.TabIndex = 68;
            // 
            // lblConsultarPlaca
            // 
            this.lblConsultarPlaca.AutoSize = true;
            this.lblConsultarPlaca.Location = new System.Drawing.Point(0, 89);
            this.lblConsultarPlaca.Name = "lblConsultarPlaca";
            this.lblConsultarPlaca.Size = new System.Drawing.Size(35, 15);
            this.lblConsultarPlaca.TabIndex = 67;
            this.lblConsultarPlaca.Text = "Placa";
            // 
            // txtConsultarModelo
            // 
            this.txtConsultarModelo.Location = new System.Drawing.Point(263, 57);
            this.txtConsultarModelo.Name = "txtConsultarModelo";
            this.txtConsultarModelo.Size = new System.Drawing.Size(251, 23);
            this.txtConsultarModelo.TabIndex = 60;
            // 
            // txtConsultarMarca
            // 
            this.txtConsultarMarca.Location = new System.Drawing.Point(263, 28);
            this.txtConsultarMarca.Name = "txtConsultarMarca";
            this.txtConsultarMarca.Size = new System.Drawing.Size(251, 23);
            this.txtConsultarMarca.TabIndex = 59;
            // 
            // lblConsultarMarca
            // 
            this.lblConsultarMarca.AutoSize = true;
            this.lblConsultarMarca.Location = new System.Drawing.Point(0, 31);
            this.lblConsultarMarca.Name = "lblConsultarMarca";
            this.lblConsultarMarca.Size = new System.Drawing.Size(40, 15);
            this.lblConsultarMarca.TabIndex = 57;
            this.lblConsultarMarca.Text = "Marca";
            //
            // lblIdVeiculo
            //
            this.lblIdVeiculo.AutoSize = true;
            this.lblIdVeiculo.Location = new System.Drawing.Point(0, 150);
            this.lblIdVeiculo.Name = "lblIdVeiculo";
            this.lblIdVeiculo.Size = new System.Drawing.Size(40, 15);
            this.lblIdVeiculo.TabIndex = 100;
            this.lblIdVeiculo.Text = "Veículo";
            // 
            // lblConsultarModelo
            // 
            this.lblConsultarModelo.AutoSize = true;
            this.lblConsultarModelo.Location = new System.Drawing.Point(0, 60);
            this.lblConsultarModelo.Name = "lblConsultarModelo";
            this.lblConsultarModelo.Size = new System.Drawing.Size(48, 15);
            this.lblConsultarModelo.TabIndex = 56;
            this.lblConsultarModelo.Text = "Modelo";
            // 
            // groupFuncoes
            // 
            this.groupFuncoes.Controls.Add(this.lllDeletar);
            this.groupFuncoes.Controls.Add(this.lllConsultarTodos);
            this.groupFuncoes.Controls.Add(this.lllConsultar);
            this.groupFuncoes.Controls.Add(this.lllInserir);
            this.groupFuncoes.Location = new System.Drawing.Point(955, 363);
            this.groupFuncoes.Name = "groupFuncoes";
            this.groupFuncoes.Size = new System.Drawing.Size(371, 185);
            this.groupFuncoes.TabIndex = 79;
            this.groupFuncoes.TabStop = false;
            this.groupFuncoes.Text = "Funções";
            // 
            // lllDeletar
            // 
            this.lllDeletar.AutoSize = true;
            this.lllDeletar.Location = new System.Drawing.Point(95, 141);
            this.lllDeletar.Name = "lllDeletar";
            this.lllDeletar.Size = new System.Drawing.Size(44, 15);
            this.lllDeletar.TabIndex = 3;
            this.lllDeletar.TabStop = true;
            this.lllDeletar.Text = "Deletar";
            // 
            // lllConsultarTodos
            // 
            this.lllConsultarTodos.AutoSize = true;
            this.lllConsultarTodos.Location = new System.Drawing.Point(95, 110);
            this.lllConsultarTodos.Name = "lllConsultarTodos";
            this.lllConsultarTodos.Size = new System.Drawing.Size(92, 15);
            this.lllConsultarTodos.TabIndex = 2;
            this.lllConsultarTodos.TabStop = true;
            this.lllConsultarTodos.Text = "Consultar Todos";
            // 
            // lllConsultar
            // 
            this.lllConsultar.AutoSize = true;
            this.lllConsultar.Location = new System.Drawing.Point(95, 78);
            this.lllConsultar.Name = "lllConsultar";
            this.lllConsultar.Size = new System.Drawing.Size(58, 15);
            this.lllConsultar.TabIndex = 1;
            this.lllConsultar.TabStop = true;
            this.lllConsultar.Text = "Consultar";
            // 
            // lllInserir
            // 
            this.lllInserir.AutoSize = true;
            this.lllInserir.Location = new System.Drawing.Point(95, 45);
            this.lllInserir.Name = "lllInserir";
            this.lllInserir.Size = new System.Drawing.Size(39, 15);
            this.lllInserir.TabIndex = 0;
            this.lllInserir.TabStop = true;
            this.lllInserir.Text = "Inserir";
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.Color.Black;
            this.btnConsultar.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnConsultar.ForeColor = System.Drawing.Color.White;
            this.btnConsultar.Location = new System.Drawing.Point(842, 567);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(233, 84);
            this.btnConsultar.TabIndex = 0;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(btnConsultar_Click);
            // 
            // groupConsulta
            // 
            this.groupConsulta.Location = new System.Drawing.Point(660, 548);
            this.groupConsulta.Name = "groupConsulta";
            this.groupConsulta.Size = new System.Drawing.Size(666, 114);
            this.groupConsulta.TabIndex = 80;
            this.groupConsulta.TabStop = false;
            this.groupConsulta.Text = "Consulta";
            // 
            // lblClose
            // 
            this.lblClose.BackColor = System.Drawing.Color.Red;
            this.lblClose.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblClose.ForeColor = System.Drawing.Color.White;
            this.lblClose.Location = new System.Drawing.Point(1345, 0);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(25, 25);
            this.lblClose.TabIndex = 81;
            this.lblClose.Text = "X";
            this.lblClose.Click += new System.EventHandler(lblClose_Click);
            // 
            // ucModificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblClose);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.groupFuncoes);
            this.Controls.Add(this.groupConsultar);
            this.Controls.Add(this.groupCadastrar);
            this.Controls.Add(this.groupCarro);
            this.Controls.Add(this.groupInformacoes);
            this.Controls.Add(this.groupConsulta);
            this.Name = "ucModificar";
            this.Size = new System.Drawing.Size(1370, 800);
            this.Load += new System.EventHandler(ucModificar_Load);
            this.groupCadastrar.ResumeLayout(false);
            this.groupCarro.ResumeLayout(false);
            this.groupCarro.PerformLayout();
            this.groupInformacoes.ResumeLayout(false);
            this.groupInformacoes.PerformLayout();
            this.groupConsultar.ResumeLayout(false);
            this.groupConsultar.PerformLayout();
            this.groupFuncoes.ResumeLayout(false);
            this.groupFuncoes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ucModificar Modificar;
        private System.Windows.Forms.GroupBox groupCadastrar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.GroupBox groupCarro;
        private System.Windows.Forms.TextBox txtPlaca;
        private System.Windows.Forms.Label lblPlaca;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.GroupBox groupInformacoes;
        private System.Windows.Forms.Label lblIdMorador;
        private System.Windows.Forms.MaskedTextBox mtxCPF;
        private System.Windows.Forms.Label lblCPFMorador;
        private System.Windows.Forms.Label lblIdCondominio;
        private System.Windows.Forms.Label lblIdPredio;
        private System.Windows.Forms.TextBox txtCondominio;
        private System.Windows.Forms.TextBox txtPredio;
        private System.Windows.Forms.Label lblPredio;
        private System.Windows.Forms.Label lblNomeCondominio;
        private System.Windows.Forms.GroupBox groupConsultar;
        private System.Windows.Forms.MaskedTextBox mtxConsultarMorador;
        private System.Windows.Forms.Label lblConsultarMorador;
        private System.Windows.Forms.TextBox txtConsultarPlaca;
        private System.Windows.Forms.Label lblConsultarPlaca;
        private System.Windows.Forms.TextBox txtConsultarModelo;
        private System.Windows.Forms.TextBox txtConsultarMarca;
        private System.Windows.Forms.Label lblConsultarMarca;
        private System.Windows.Forms.Label lblConsultarModelo;
        private System.Windows.Forms.Label lblIdVeiculo;
        private System.Windows.Forms.GroupBox groupFuncoes;
        private System.Windows.Forms.LinkLabel lllDeletar;
        private System.Windows.Forms.LinkLabel lllConsultarTodos;
        private System.Windows.Forms.LinkLabel lllConsultar;
        private System.Windows.Forms.LinkLabel lllInserir;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.GroupBox groupConsulta;
        private System.Windows.Forms.Label lblClose;
    }
}
