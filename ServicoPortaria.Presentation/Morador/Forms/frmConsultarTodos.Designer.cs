﻿
namespace ServicoPortaria.Presentation.Morador.Forms
{
    partial class frmConsultarTodos
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
            this.ListarTodos = new Presentation.Morador.ucListarTodos();
            this.SuspendLayout();
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
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Controls.Add(ListarTodos);
            this.ClientSize = new System.Drawing.Size(1370, 800);
            this.Text = "frmConsultarTodos";
        }

        #endregion

        private Presentation.Morador.ucListarTodos ListarTodos;
    }
}