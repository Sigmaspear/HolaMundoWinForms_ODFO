namespace HolaMundo._1
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
            this.BotonValidar = new System.Windows.Forms.Button();
            this.txtContraseña1 = new System.Windows.Forms.TextBox();
            this.txtContraseña2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BotonValidar
            // 
            this.BotonValidar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BotonValidar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BotonValidar.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonValidar.Location = new System.Drawing.Point(275, 321);
            this.BotonValidar.Name = "BotonValidar";
            this.BotonValidar.Size = new System.Drawing.Size(196, 52);
            this.BotonValidar.TabIndex = 0;
            this.BotonValidar.Text = "Validar";
            this.BotonValidar.UseVisualStyleBackColor = false;
            this.BotonValidar.Click += new System.EventHandler(this.BotonValidar_Click);
            // 
            // txtContraseña1
            // 
            this.txtContraseña1.Location = new System.Drawing.Point(321, 160);
            this.txtContraseña1.Name = "txtContraseña1";
            this.txtContraseña1.Size = new System.Drawing.Size(271, 22);
            this.txtContraseña1.TabIndex = 1;
            // 
            // txtContraseña2
            // 
            this.txtContraseña2.Location = new System.Drawing.Point(322, 227);
            this.txtContraseña2.Name = "txtContraseña2";
            this.txtContraseña2.Size = new System.Drawing.Size(270, 22);
            this.txtContraseña2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(134, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Escribe tu contraseña";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(134, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Valida tu contraseña";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(189, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(360, 45);
            this.label3.TabIndex = 5;
            this.label3.Text = "Define tu contraseña";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtContraseña2);
            this.Controls.Add(this.txtContraseña1);
            this.Controls.Add(this.BotonValidar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BotonValidar;
        private System.Windows.Forms.TextBox txtContraseña1;
        private System.Windows.Forms.TextBox txtContraseña2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

