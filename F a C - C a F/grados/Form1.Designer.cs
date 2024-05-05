namespace grados
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
            this.btncerrar = new System.Windows.Forms.Button();
            this.btncalc = new System.Windows.Forms.Button();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtn = new System.Windows.Forms.TextBox();
            this.txtcaf = new System.Windows.Forms.TextBox();
            this.txtfac = new System.Windows.Forms.TextBox();
            this.rdcaf = new System.Windows.Forms.RadioButton();
            this.rdfac = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btncerrar
            // 
            this.btncerrar.BackColor = System.Drawing.Color.LavenderBlush;
            this.btncerrar.Font = new System.Drawing.Font("Constantia", 12.22642F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncerrar.Location = new System.Drawing.Point(362, 326);
            this.btncerrar.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.Size = new System.Drawing.Size(155, 66);
            this.btncerrar.TabIndex = 19;
            this.btncerrar.Text = "Cerrar";
            this.btncerrar.UseVisualStyleBackColor = false;
            this.btncerrar.Click += new System.EventHandler(this.btncerrar_Click);
            // 
            // btncalc
            // 
            this.btncalc.BackColor = System.Drawing.Color.LavenderBlush;
            this.btncalc.Font = new System.Drawing.Font("Constantia", 12.22642F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalc.Location = new System.Drawing.Point(197, 326);
            this.btncalc.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btncalc.Name = "btncalc";
            this.btncalc.Size = new System.Drawing.Size(155, 66);
            this.btncalc.TabIndex = 18;
            this.btncalc.Text = "Calcular";
            this.btncalc.UseVisualStyleBackColor = false;
            this.btncalc.Click += new System.EventHandler(this.btncalc_Click);
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnlimpiar.Font = new System.Drawing.Font("Constantia", 12.22642F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlimpiar.Location = new System.Drawing.Point(32, 326);
            this.btnlimpiar.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(155, 66);
            this.btnlimpiar.TabIndex = 17;
            this.btnlimpiar.Text = "Limpiar";
            this.btnlimpiar.UseVisualStyleBackColor = false;
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Constantia", 12.22642F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(241, 126);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 23);
            this.label2.TabIndex = 16;
            this.label2.Text = "A:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Constantia", 12.22642F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(221, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 15;
            this.label1.Text = "Convertir:";
            // 
            // txtn
            // 
            this.txtn.Location = new System.Drawing.Point(161, 67);
            this.txtn.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtn.Name = "txtn";
            this.txtn.Size = new System.Drawing.Size(226, 29);
            this.txtn.TabIndex = 14;
            this.txtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtcaf
            // 
            this.txtcaf.Location = new System.Drawing.Point(272, 262);
            this.txtcaf.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtcaf.Name = "txtcaf";
            this.txtcaf.Size = new System.Drawing.Size(236, 29);
            this.txtcaf.TabIndex = 13;
            this.txtcaf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtfac
            // 
            this.txtfac.Location = new System.Drawing.Point(272, 165);
            this.txtfac.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtfac.Name = "txtfac";
            this.txtfac.Size = new System.Drawing.Size(236, 29);
            this.txtfac.TabIndex = 12;
            this.txtfac.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rdcaf
            // 
            this.rdcaf.AutoSize = true;
            this.rdcaf.Location = new System.Drawing.Point(50, 265);
            this.rdcaf.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.rdcaf.Name = "rdcaf";
            this.rdcaf.Size = new System.Drawing.Size(191, 26);
            this.rdcaf.TabIndex = 11;
            this.rdcaf.TabStop = true;
            this.rdcaf.Text = "Celsius a Fahrenheit:";
            this.rdcaf.UseVisualStyleBackColor = true;
            // 
            // rdfac
            // 
            this.rdfac.AutoSize = true;
            this.rdfac.Location = new System.Drawing.Point(50, 168);
            this.rdfac.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.rdfac.Name = "rdfac";
            this.rdfac.Size = new System.Drawing.Size(191, 26);
            this.rdfac.TabIndex = 10;
            this.rdfac.TabStop = true;
            this.rdfac.Text = "Fahrenheit a Celsius:";
            this.rdfac.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(557, 436);
            this.Controls.Add(this.btncerrar);
            this.Controls.Add(this.btncalc);
            this.Controls.Add(this.btnlimpiar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtn);
            this.Controls.Add(this.txtcaf);
            this.Controls.Add(this.txtfac);
            this.Controls.Add(this.rdcaf);
            this.Controls.Add(this.rdfac);
            this.Font = new System.Drawing.Font("Constantia", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncerrar;
        private System.Windows.Forms.Button btncalc;
        private System.Windows.Forms.Button btnlimpiar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtn;
        private System.Windows.Forms.TextBox txtcaf;
        private System.Windows.Forms.TextBox txtfac;
        private System.Windows.Forms.RadioButton rdcaf;
        private System.Windows.Forms.RadioButton rdfac;
    }
}

