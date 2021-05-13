
namespace ServicoPortaria.Presentation.Predio.Forms
{
    partial class frmConsultar
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
            this.Consultar = new ucConsultar();
            this.components = new System.ComponentModel.Container();
            //
            // ucConsultar
            //
            this.Consultar.BackColor = System.Drawing.Color.White;
            this.Consultar.Location = new System.Drawing.Point(1, 1);
            this.Consultar.Name = "ucInserir";
            this.Consultar.Size = new System.Drawing.Size(1370, 800);
            this.Consultar.TabIndex = 0;
            //
            // frmConsultar
            //
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 800);
            this.Controls.Add(Consultar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Text = "frmConsultar";
        }

        #endregion

        private Predio.ucConsultar Consultar;
    }
}