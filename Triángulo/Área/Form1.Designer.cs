namespace Área
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
            this.txtarea = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btncerrar = new System.Windows.Forms.Button();
            this.btncalc = new System.Windows.Forms.Button();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.txtld1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtld3 = new System.Windows.Forms.TextBox();
            this.txtld2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txttipo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtarea
            // 
            this.txtarea.Location = new System.Drawing.Point(197, 340);
            this.txtarea.Name = "txtarea";
            this.txtarea.Size = new System.Drawing.Size(173, 29);
            this.txtarea.TabIndex = 18;
            this.txtarea.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(139, 343);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 22);
            this.label3.TabIndex = 17;
            this.label3.Text = "Área";
            // 
            // btncerrar
            // 
            this.btncerrar.BackColor = System.Drawing.Color.LavenderBlush;
            this.btncerrar.Font = new System.Drawing.Font("Constantia", 12.22642F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncerrar.Location = new System.Drawing.Point(303, 264);
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.Size = new System.Drawing.Size(103, 44);
            this.btncerrar.TabIndex = 16;
            this.btncerrar.Text = "Cerrar";
            this.btncerrar.UseVisualStyleBackColor = false;
            this.btncerrar.Click += new System.EventHandler(this.btncerrar_Click);
            // 
            // btncalc
            // 
            this.btncalc.BackColor = System.Drawing.Color.LavenderBlush;
            this.btncalc.Font = new System.Drawing.Font("Constantia", 12.22642F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalc.Location = new System.Drawing.Point(194, 264);
            this.btncalc.Name = "btncalc";
            this.btncalc.Size = new System.Drawing.Size(103, 44);
            this.btncalc.TabIndex = 15;
            this.btncalc.Text = "Calcular";
            this.btncalc.UseVisualStyleBackColor = false;
            this.btncalc.Click += new System.EventHandler(this.btncalc_Click);
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnlimpiar.Font = new System.Drawing.Font("Constantia", 12.22642F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlimpiar.Location = new System.Drawing.Point(85, 264);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(103, 44);
            this.btnlimpiar.TabIndex = 14;
            this.btnlimpiar.Text = "Limpiar";
            this.btnlimpiar.UseVisualStyleBackColor = false;
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
            // 
            // txtld1
            // 
            this.txtld1.Location = new System.Drawing.Point(222, 88);
            this.txtld1.Name = "txtld1";
            this.txtld1.Size = new System.Drawing.Size(98, 29);
            this.txtld1.TabIndex = 13;
            this.txtld1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(142, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 22);
            this.label2.TabIndex = 12;
            this.label2.Text = "Lado 1:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Constantia", 14.26415F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(87, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(319, 26);
            this.label1.TabIndex = 11;
            this.label1.Text = "Calcular el Área de un triángulo";
            // 
            // txtld3
            // 
            this.txtld3.Location = new System.Drawing.Point(222, 204);
            this.txtld3.Name = "txtld3";
            this.txtld3.Size = new System.Drawing.Size(98, 29);
            this.txtld3.TabIndex = 19;
            this.txtld3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtld2
            // 
            this.txtld2.Location = new System.Drawing.Point(222, 146);
            this.txtld2.Name = "txtld2";
            this.txtld2.Size = new System.Drawing.Size(98, 29);
            this.txtld2.TabIndex = 20;
            this.txtld2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(140, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 22);
            this.label4.TabIndex = 21;
            this.label4.Text = "Lado 3:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(139, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 22);
            this.label5.TabIndex = 22;
            this.label5.Text = "Lado 2:";
            // 
            // txttipo
            // 
            this.txttipo.Location = new System.Drawing.Point(197, 385);
            this.txttipo.Name = "txttipo";
            this.txttipo.Size = new System.Drawing.Size(137, 29);
            this.txttipo.TabIndex = 24;
            this.txttipo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(144, 392);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 22);
            this.label6.TabIndex = 23;
            this.label6.Text = "Tipo";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(468, 466);
            this.Controls.Add(this.txttipo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtld2);
            this.Controls.Add(this.txtld3);
            this.Controls.Add(this.txtarea);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btncerrar);
            this.Controls.Add(this.btncalc);
            this.Controls.Add(this.btnlimpiar);
            this.Controls.Add(this.txtld1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Constantia", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtarea;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btncerrar;
        private System.Windows.Forms.Button btncalc;
        private System.Windows.Forms.Button btnlimpiar;
        private System.Windows.Forms.TextBox txtld1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtld3;
        private System.Windows.Forms.TextBox txtld2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txttipo;
        private System.Windows.Forms.Label label6;
    }
}

