﻿namespace Sistema_Login
{
    partial class Form1
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
            this.label_BoasVindas = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_BoasVindas
            // 
            this.label_BoasVindas.Font = new System.Drawing.Font("Modern No. 20", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_BoasVindas.Location = new System.Drawing.Point(242, 42);
            this.label_BoasVindas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_BoasVindas.Name = "label_BoasVindas";
            this.label_BoasVindas.Size = new System.Drawing.Size(1159, 712);
            this.label_BoasVindas.TabIndex = 0;
            this.label_BoasVindas.Text = "Tela Inicial";
            this.label_BoasVindas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1614, 983);
            this.Controls.Add(this.label_BoasVindas);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_BoasVindas;
    }
}

