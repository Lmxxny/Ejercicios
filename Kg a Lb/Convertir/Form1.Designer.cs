namespace Convertir
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
            this.rdkal = new System.Windows.Forms.RadioButton();
            this.rdlak = new System.Windows.Forms.RadioButton();
            this.txtkal = new System.Windows.Forms.TextBox();
            this.txtlak = new System.Windows.Forms.TextBox();
            this.txtn = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.btncalc = new System.Windows.Forms.Button();
            this.btncerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rdkal
            // 
            this.rdkal.AutoSize = true;
            this.rdkal.Location = new System.Drawing.Point(69, 156);
            this.rdkal.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.rdkal.Name = "rdkal";
            this.rdkal.Size = new System.Drawing.Size(195, 26);
            this.rdkal.TabIndex = 0;
            this.rdkal.TabStop = true;
            this.rdkal.Text = "Kilogramos a Libras: ";
            this.rdkal.UseVisualStyleBackColor = true;
            // 
            // rdlak
            // 
            this.rdlak.AutoSize = true;
            this.rdlak.Location = new System.Drawing.Point(69, 213);
            this.rdlak.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.rdlak.Name = "rdlak";
            this.rdlak.Size = new System.Drawing.Size(195, 26);
            this.rdlak.TabIndex = 1;
            this.rdlak.TabStop = true;
            this.rdlak.Text = "Libras a Kilogramos: ";
            this.rdlak.UseVisualStyleBackColor = true;
            // 
            // txtkal
            // 
            this.txtkal.Location = new System.Drawing.Point(272, 153);
            this.txtkal.Name = "txtkal";
            this.txtkal.Size = new System.Drawing.Size(143, 29);
            this.txtkal.TabIndex = 2;
            // 
            // txtlak
            // 
            this.txtlak.Location = new System.Drawing.Point(272, 210);
            this.txtlak.Name = "txtlak";
            this.txtlak.Size = new System.Drawing.Size(143, 29);
            this.txtlak.TabIndex = 3;
            // 
            // txtn
            // 
            this.txtn.Location = new System.Drawing.Point(166, 75);
            this.txtn.Name = "txtn";
            this.txtn.Size = new System.Drawing.Size(137, 29);
            this.txtn.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Constantia", 12.22642F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(185, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 22);
            this.label1.TabIndex = 5;
            this.label1.Text = "Convertir:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Constantia", 12.22642F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(221, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 22);
            this.label2.TabIndex = 6;
            this.label2.Text = "A:";
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnlimpiar.Font = new System.Drawing.Font("Constantia", 12.22642F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlimpiar.Location = new System.Drawing.Point(28, 281);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(138, 56);
            this.btnlimpiar.TabIndex = 7;
            this.btnlimpiar.Text = "Limpiar";
            this.btnlimpiar.UseVisualStyleBackColor = false;
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
            // 
            // btncalc
            // 
            this.btncalc.BackColor = System.Drawing.Color.LavenderBlush;
            this.btncalc.Font = new System.Drawing.Font("Constantia", 12.22642F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalc.Location = new System.Drawing.Point(172, 281);
            this.btncalc.Name = "btncalc";
            this.btncalc.Size = new System.Drawing.Size(138, 56);
            this.btncalc.TabIndex = 8;
            this.btncalc.Text = "Calcular";
            this.btncalc.UseVisualStyleBackColor = false;
            this.btncalc.Click += new System.EventHandler(this.btncalc_Click);
            // 
            // btncerrar
            // 
            this.btncerrar.BackColor = System.Drawing.Color.LavenderBlush;
            this.btncerrar.Font = new System.Drawing.Font("Constantia", 12.22642F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncerrar.Location = new System.Drawing.Point(316, 281);
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.Size = new System.Drawing.Size(138, 56);
            this.btncerrar.TabIndex = 9;
            this.btncerrar.Text = "Cerrar";
            this.btncerrar.UseVisualStyleBackColor = false;
            this.btncerrar.Click += new System.EventHandler(this.btncerrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(495, 361);
            this.Controls.Add(this.btncerrar);
            this.Controls.Add(this.btncalc);
            this.Controls.Add(this.btnlimpiar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtn);
            this.Controls.Add(this.txtlak);
            this.Controls.Add(this.txtkal);
            this.Controls.Add(this.rdlak);
            this.Controls.Add(this.rdkal);
            this.Font = new System.Drawing.Font("Constantia", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdkal;
        private System.Windows.Forms.RadioButton rdlak;
        private System.Windows.Forms.TextBox txtkal;
        private System.Windows.Forms.TextBox txtlak;
        private System.Windows.Forms.TextBox txtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnlimpiar;
        private System.Windows.Forms.Button btncalc;
        private System.Windows.Forms.Button btncerrar;
    }
}

