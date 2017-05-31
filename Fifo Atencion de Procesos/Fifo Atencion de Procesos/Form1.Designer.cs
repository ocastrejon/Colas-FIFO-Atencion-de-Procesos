namespace Fifo_Atencion_de_Procesos
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
            this.lblProcesosFaltantes = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCiclosOcio = new System.Windows.Forms.Label();
            this.txtNumProFaltantes = new System.Windows.Forms.TextBox();
            this.txtListaProFaltantes = new System.Windows.Forms.TextBox();
            this.txtCiclosOcio = new System.Windows.Forms.TextBox();
            this.txtReporte = new System.Windows.Forms.TextBox();
            this.bttonMostrarProcesos = new System.Windows.Forms.Button();
            this.bttonComenzar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblProcesosFaltantes
            // 
            this.lblProcesosFaltantes.AutoSize = true;
            this.lblProcesosFaltantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProcesosFaltantes.Location = new System.Drawing.Point(24, 219);
            this.lblProcesosFaltantes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProcesosFaltantes.Name = "lblProcesosFaltantes";
            this.lblProcesosFaltantes.Size = new System.Drawing.Size(210, 29);
            this.lblProcesosFaltantes.TabIndex = 3;
            this.lblProcesosFaltantes.Text = "Procesos faltantes";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 106);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 58);
            this.label1.TabIndex = 10;
            this.label1.Text = "Número de procesos\r\nfaltantes";
            // 
            // lblCiclosOcio
            // 
            this.lblCiclosOcio.AutoSize = true;
            this.lblCiclosOcio.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCiclosOcio.Location = new System.Drawing.Point(23, 26);
            this.lblCiclosOcio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCiclosOcio.Name = "lblCiclosOcio";
            this.lblCiclosOcio.Size = new System.Drawing.Size(166, 29);
            this.lblCiclosOcio.TabIndex = 11;
            this.lblCiclosOcio.Text = "Ciclos de ocio";
            // 
            // txtNumProFaltantes
            // 
            this.txtNumProFaltantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumProFaltantes.Location = new System.Drawing.Point(29, 168);
            this.txtNumProFaltantes.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumProFaltantes.Name = "txtNumProFaltantes";
            this.txtNumProFaltantes.ReadOnly = true;
            this.txtNumProFaltantes.Size = new System.Drawing.Size(211, 34);
            this.txtNumProFaltantes.TabIndex = 4;
            this.txtNumProFaltantes.TabStop = false;
            // 
            // txtListaProFaltantes
            // 
            this.txtListaProFaltantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtListaProFaltantes.Location = new System.Drawing.Point(28, 252);
            this.txtListaProFaltantes.Margin = new System.Windows.Forms.Padding(4);
            this.txtListaProFaltantes.Multiline = true;
            this.txtListaProFaltantes.Name = "txtListaProFaltantes";
            this.txtListaProFaltantes.ReadOnly = true;
            this.txtListaProFaltantes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtListaProFaltantes.Size = new System.Drawing.Size(276, 298);
            this.txtListaProFaltantes.TabIndex = 5;
            this.txtListaProFaltantes.TabStop = false;
            // 
            // txtCiclosOcio
            // 
            this.txtCiclosOcio.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCiclosOcio.Location = new System.Drawing.Point(29, 59);
            this.txtCiclosOcio.Margin = new System.Windows.Forms.Padding(4);
            this.txtCiclosOcio.Name = "txtCiclosOcio";
            this.txtCiclosOcio.ReadOnly = true;
            this.txtCiclosOcio.Size = new System.Drawing.Size(211, 34);
            this.txtCiclosOcio.TabIndex = 6;
            this.txtCiclosOcio.TabStop = false;
            // 
            // txtReporte
            // 
            this.txtReporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReporte.Location = new System.Drawing.Point(340, 23);
            this.txtReporte.Margin = new System.Windows.Forms.Padding(4);
            this.txtReporte.Multiline = true;
            this.txtReporte.Name = "txtReporte";
            this.txtReporte.ReadOnly = true;
            this.txtReporte.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtReporte.Size = new System.Drawing.Size(278, 616);
            this.txtReporte.TabIndex = 7;
            this.txtReporte.TabStop = false;
            this.txtReporte.TextChanged += new System.EventHandler(this.txtReporte_TextChanged);
            // 
            // bttonMostrarProcesos
            // 
            this.bttonMostrarProcesos.AutoSize = true;
            this.bttonMostrarProcesos.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttonMostrarProcesos.Location = new System.Drawing.Point(28, 571);
            this.bttonMostrarProcesos.Margin = new System.Windows.Forms.Padding(4);
            this.bttonMostrarProcesos.Name = "bttonMostrarProcesos";
            this.bttonMostrarProcesos.Size = new System.Drawing.Size(133, 68);
            this.bttonMostrarProcesos.TabIndex = 8;
            this.bttonMostrarProcesos.Text = "Mostrar\r\nProcesos";
            this.bttonMostrarProcesos.UseVisualStyleBackColor = true;
            this.bttonMostrarProcesos.Click += new System.EventHandler(this.bttonMostrarProcesos_Click);
            // 
            // bttonComenzar
            // 
            this.bttonComenzar.AutoSize = true;
            this.bttonComenzar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttonComenzar.Location = new System.Drawing.Point(171, 586);
            this.bttonComenzar.Margin = new System.Windows.Forms.Padding(4);
            this.bttonComenzar.Name = "bttonComenzar";
            this.bttonComenzar.Size = new System.Drawing.Size(133, 39);
            this.bttonComenzar.TabIndex = 9;
            this.bttonComenzar.Text = "Comenzar";
            this.bttonComenzar.UseVisualStyleBackColor = true;
            this.bttonComenzar.Click += new System.EventHandler(this.bttonComenzar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 663);
            this.Controls.Add(this.lblProcesosFaltantes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCiclosOcio);
            this.Controls.Add(this.txtNumProFaltantes);
            this.Controls.Add(this.txtListaProFaltantes);
            this.Controls.Add(this.txtCiclosOcio);
            this.Controls.Add(this.txtReporte);
            this.Controls.Add(this.bttonMostrarProcesos);
            this.Controls.Add(this.bttonComenzar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProcesosFaltantes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCiclosOcio;
        private System.Windows.Forms.TextBox txtNumProFaltantes;
        private System.Windows.Forms.TextBox txtListaProFaltantes;
        private System.Windows.Forms.TextBox txtCiclosOcio;
        private System.Windows.Forms.TextBox txtReporte;
        private System.Windows.Forms.Button bttonMostrarProcesos;
        private System.Windows.Forms.Button bttonComenzar;
    }
}

