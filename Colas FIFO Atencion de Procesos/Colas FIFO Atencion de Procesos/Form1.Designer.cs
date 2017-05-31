namespace Colas_FIFO_Atencion_de_Procesos
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtBxProcesos = new System.Windows.Forms.TextBox();
            this.bttnComenzar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Procesos";
            // 
            // txtBxProcesos
            // 
            this.txtBxProcesos.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxProcesos.Location = new System.Drawing.Point(180, 19);
            this.txtBxProcesos.Multiline = true;
            this.txtBxProcesos.Name = "txtBxProcesos";
            this.txtBxProcesos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBxProcesos.Size = new System.Drawing.Size(203, 610);
            this.txtBxProcesos.TabIndex = 1;
            // 
            // bttnComenzar
            // 
            this.bttnComenzar.AutoSize = true;
            this.bttnComenzar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnComenzar.Location = new System.Drawing.Point(24, 86);
            this.bttnComenzar.Name = "bttnComenzar";
            this.bttnComenzar.Size = new System.Drawing.Size(133, 39);
            this.bttnComenzar.TabIndex = 2;
            this.bttnComenzar.Text = "Comenzar";
            this.bttnComenzar.UseVisualStyleBackColor = true;
            this.bttnComenzar.Click += new System.EventHandler(this.bttnComenzar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 659);
            this.Controls.Add(this.bttnComenzar);
            this.Controls.Add(this.txtBxProcesos);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBxProcesos;
        private System.Windows.Forms.Button bttnComenzar;
    }
}

