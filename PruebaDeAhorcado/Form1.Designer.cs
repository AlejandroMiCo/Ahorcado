﻿namespace PruebaDeAhorcado
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.ahorcadoComponent1 = new DibujoAhorcado.AhorcadoComponent();
            this.SuspendLayout();
            // 
            // ahorcadoComponent1
            // 
            this.ahorcadoComponent1.Errores = 7;
            this.ahorcadoComponent1.Location = new System.Drawing.Point(137, 12);
            this.ahorcadoComponent1.Name = "ahorcadoComponent1";
            this.ahorcadoComponent1.Size = new System.Drawing.Size(898, 459);
            this.ahorcadoComponent1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 625);
            this.Controls.Add(this.ahorcadoComponent1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private DibujoAhorcado.AhorcadoComponent ahorcadoComponent1;
    }
}

