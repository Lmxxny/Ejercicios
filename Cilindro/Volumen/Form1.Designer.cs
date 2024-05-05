namespace Volumen
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
            this.label5 = new System.Windows.Forms.Label();
            this.txth = new System.Windows.Forms.TextBox();
            this.txtvol = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btncerrar = new System.Windows.Forms.Button();
            this.btncalc = new System.Windows.Forms.Button();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.txtrd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(135, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 23);
            this.label5.TabIndex = 32;
            this.label5.Text = "Altura:";
            // 
            // txth
            // 
            this.txth.Location = new System.Drawing.Point(218, 142);
            this.txth.Name = "txth";
            this.txth.Size = new System.Drawing.Size(98, 29);
            this.txth.TabIndex = 31;
            this.txth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtvol
            // 
            this.txtvol.Location = new System.Drawing.Point(196, 271);
            this.txtvol.Name = "txtvol";
            this.txtvol.Size = new System.Drawing.Size(173, 29);
            this.txtvol.TabIndex = 30;
            this.txtvol.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(104, 274);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 23);
            this.label3.TabIndex = 29;
            this.label3.Text = "Volumen:";
            // 
            // btncerrar
            // 
            this.btncerrar.BackColor = System.Drawing.Color.LavenderBlush;
            this.btncerrar.Font = new System.Drawing.Font("Constantia", 12.22642F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncerrar.Location = new System.Drawing.Point(305, 195);
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.Size = new System.Drawing.Size(103, 44);
            this.btncerrar.TabIndex = 28;
            this.btncerrar.Text = "Cerrar";
            this.btncerrar.UseVisualStyleBackColor = false;
            this.btncerrar.Click += new System.EventHandler(this.btncerrar_Click);
            // 
            // btncalc
            // 
            this.btncalc.BackColor = System.Drawing.Color.LavenderBlush;
            this.btncalc.Font = new System.Drawing.Font("Constantia", 12.22642F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalc.Location = new System.Drawing.Point(196, 195);
            this.btncalc.Name = "btncalc";
            this.btncalc.Size = new System.Drawing.Size(103, 44);
            this.btncalc.TabIndex = 27;
            this.btncalc.Text = "Calcular";
            this.btncalc.UseVisualStyleBackColor = false;
            this.btncalc.Click += new System.EventHandler(this.btncalc_Click);
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnlimpiar.Font = new System.Drawing.Font("Constantia", 12.22642F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlimpiar.Location = new System.Drawing.Point(87, 195);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(103, 44);
            this.btnlimpiar.TabIndex = 26;
            this.btnlimpiar.Text = "Limpiar";
            this.btnlimpiar.UseVisualStyleBackColor = false;
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
            // 
            // txtrd
            // 
            this.txtrd.Location = new System.Drawing.Point(218, 84);
            this.txtrd.Name = "txtrd";
            this.txtrd.Size = new System.Drawing.Size(98, 29);
            this.txtrd.TabIndex = 25;
            this.txtrd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(138, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 23);
            this.label2.TabIndex = 24;
            this.label2.Text = "Radio:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Constantia", 14.26415F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(76, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(347, 26);
            this.label1.TabIndex = 23;
            this.label1.Text = "Calcular el volumen de un cilindro";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(478, 341);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txth);
            this.Controls.Add(this.txtvol);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btncerrar);
            this.Controls.Add(this.btncalc);
            this.Controls.Add(this.btnlimpiar);
            this.Controls.Add(this.txtrd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Constantia", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txth;
        private System.Windows.Forms.TextBox txtvol;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btncerrar;
        private System.Windows.Forms.Button btncalc;
        private System.Windows.Forms.Button btnlimpiar;
        private System.Windows.Forms.TextBox txtrd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

