
namespace ServicoPortaria.Presentation.PrestadorDeServicos.Forms
{
    partial class frmListarTodos
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
            this.ListarTodos = new PrestadorDeServicos.ucListarTodos();
            this.components = new System.ComponentModel.Container();
            //
            // ucListarTodos
            //
            this.ListarTodos.BackColor = System.Drawing.Color.White;
            this.ListarTodos.Location = new System.Drawing.Point(0, 0);
            this.ListarTodos.Name = "ListarTodos";
            this.ListarTodos.Size = new System.Drawing.Size(1370, 800);
            this.ListarTodos.TabIndex = 0;
            //
            // frmListarTodos
            //
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 800);
            this.Controls.Add(ListarTodos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Text = "frmListarTodos";
        }

        #endregion

        private Presentation.PrestadorDeServicos.ucListarTodos ListarTodos;
    }
}