
namespace ServicoPortaria.Presentation.Veiculo.Forms
{
    partial class frmInserir
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Inserir = new ucInserir();
            this.components = new System.ComponentModel.Container();
            //
            // ucInserir
            //
            this.Inserir.BackColor = System.Drawing.Color.White;
            this.Inserir.Location = new System.Drawing.Point(0, 0);
            this.Inserir.Name = "Inserir";
            this.Inserir.Size = new System.Drawing.Size(1370, 800);
            this.Inserir.TabIndex = 0;
            //
            // frmInserir
            //
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.ClientSize = new System.Drawing.Size(1370, 800);
            this.Text = "frmInserir";
            this.Controls.Add(Inserir);
        }

        #endregion

        private ucInserir Inserir;
    }
}