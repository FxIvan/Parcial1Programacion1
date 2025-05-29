namespace Parcial1Programacion1
{
    partial class frmParcial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmParcial));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnHPTL1 = new System.Windows.Forms.Button();
            this.btnXEROXPrint = new System.Windows.Forms.Button();
            this.btnIBMFullColor = new System.Windows.Forms.Button();
            this.btnHPOne = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCantidadDeCopias = new System.Windows.Forms.TextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lstListaDeCopia = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnHPTL1);
            this.groupBox1.Controls.Add(this.btnXEROXPrint);
            this.groupBox1.Controls.Add(this.btnIBMFullColor);
            this.groupBox1.Controls.Add(this.btnHPOne);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(531, 57);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Impresoras";
            // 
            // btnHPTL1
            // 
            this.btnHPTL1.Location = new System.Drawing.Point(398, 19);
            this.btnHPTL1.Name = "btnHPTL1";
            this.btnHPTL1.Size = new System.Drawing.Size(120, 25);
            this.btnHPTL1.TabIndex = 4;
            this.btnHPTL1.Text = "HP TL-1";
            this.btnHPTL1.UseVisualStyleBackColor = true;
            this.btnHPTL1.Click += new System.EventHandler(this.btnHPTL1_Click);
            // 
            // btnXEROXPrint
            // 
            this.btnXEROXPrint.Location = new System.Drawing.Point(272, 19);
            this.btnXEROXPrint.Name = "btnXEROXPrint";
            this.btnXEROXPrint.Size = new System.Drawing.Size(120, 25);
            this.btnXEROXPrint.TabIndex = 3;
            this.btnXEROXPrint.Text = "XEROX Print";
            this.btnXEROXPrint.UseVisualStyleBackColor = true;
            this.btnXEROXPrint.Click += new System.EventHandler(this.btnXEROXPrint_Click);
            // 
            // btnIBMFullColor
            // 
            this.btnIBMFullColor.Location = new System.Drawing.Point(146, 19);
            this.btnIBMFullColor.Name = "btnIBMFullColor";
            this.btnIBMFullColor.Size = new System.Drawing.Size(120, 25);
            this.btnIBMFullColor.TabIndex = 2;
            this.btnIBMFullColor.Text = "IBM Full Color";
            this.btnIBMFullColor.UseVisualStyleBackColor = true;
            this.btnIBMFullColor.Click += new System.EventHandler(this.btnIBMFullColor_Click);
            // 
            // btnHPOne
            // 
            this.btnHPOne.Location = new System.Drawing.Point(20, 19);
            this.btnHPOne.Name = "btnHPOne";
            this.btnHPOne.Size = new System.Drawing.Size(120, 25);
            this.btnHPOne.TabIndex = 1;
            this.btnHPOne.Text = "HP One";
            this.btnHPOne.UseVisualStyleBackColor = true;
            this.btnHPOne.Click += new System.EventHandler(this.btnHPOne_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cantidad de copias:";
            // 
            // txtCantidadDeCopias
            // 
            this.txtCantidadDeCopias.Location = new System.Drawing.Point(157, 19);
            this.txtCantidadDeCopias.Name = "txtCantidadDeCopias";
            this.txtCantidadDeCopias.Size = new System.Drawing.Size(163, 20);
            this.txtCantidadDeCopias.TabIndex = 2;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(326, 16);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(93, 25);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(425, 16);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(93, 25);
            this.btnImprimir.TabIndex = 4;
            this.btnImprimir.Text = "IMPRIMIR";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnImprimir);
            this.groupBox2.Controls.Add(this.btnSalir);
            this.groupBox2.Controls.Add(this.txtCantidadDeCopias);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(13, 75);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(530, 50);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            // 
            // lstListaDeCopia
            // 
            this.lstListaDeCopia.FormattingEnabled = true;
            this.lstListaDeCopia.Location = new System.Drawing.Point(13, 149);
            this.lstListaDeCopia.Name = "lstListaDeCopia";
            this.lstListaDeCopia.Size = new System.Drawing.Size(530, 225);
            this.lstListaDeCopia.TabIndex = 6;
            // 
            // frmParcial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 394);
            this.Controls.Add(this.lstListaDeCopia);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmParcial";
            this.Text = "Primer Parcial";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnHPTL1;
        private System.Windows.Forms.Button btnXEROXPrint;
        private System.Windows.Forms.Button btnIBMFullColor;
        private System.Windows.Forms.Button btnHPOne;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCantidadDeCopias;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lstListaDeCopia;
    }
}

