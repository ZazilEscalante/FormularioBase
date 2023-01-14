namespace FormularioBase
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
            this.labelsaludo = new System.Windows.Forms.Label();
            this.labelcargo = new System.Windows.Forms.Label();
            this.labelnombre = new System.Windows.Forms.Label();
            this.labelpaterno = new System.Windows.Forms.Label();
            this.labelmaterno = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelsaludo
            // 
            this.labelsaludo.AutoSize = true;
            this.labelsaludo.Location = new System.Drawing.Point(25, 22);
            this.labelsaludo.Name = "labelsaludo";
            this.labelsaludo.Size = new System.Drawing.Size(38, 13);
            this.labelsaludo.TabIndex = 0;
            this.labelsaludo.Text = "saludo";
            // 
            // labelcargo
            // 
            this.labelcargo.AutoSize = true;
            this.labelcargo.Location = new System.Drawing.Point(195, 22);
            this.labelcargo.Name = "labelcargo";
            this.labelcargo.Size = new System.Drawing.Size(34, 13);
            this.labelcargo.TabIndex = 1;
            this.labelcargo.Text = "cargo";
            // 
            // labelnombre
            // 
            this.labelnombre.AutoSize = true;
            this.labelnombre.Location = new System.Drawing.Point(380, 22);
            this.labelnombre.Name = "labelnombre";
            this.labelnombre.Size = new System.Drawing.Size(42, 13);
            this.labelnombre.TabIndex = 2;
            this.labelnombre.Text = "nombre";
            // 
            // labelpaterno
            // 
            this.labelpaterno.AutoSize = true;
            this.labelpaterno.Location = new System.Drawing.Point(528, 22);
            this.labelpaterno.Name = "labelpaterno";
            this.labelpaterno.Size = new System.Drawing.Size(43, 13);
            this.labelpaterno.TabIndex = 3;
            this.labelpaterno.Text = "paterno";
            // 
            // labelmaterno
            // 
            this.labelmaterno.AutoSize = true;
            this.labelmaterno.Location = new System.Drawing.Point(679, 22);
            this.labelmaterno.Name = "labelmaterno";
            this.labelmaterno.Size = new System.Drawing.Size(45, 13);
            this.labelmaterno.TabIndex = 4;
            this.labelmaterno.Text = "materno";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 210);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "saludar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(178, 210);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "cargo";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(363, 214);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "nombre";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(508, 210);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 8;
            this.button4.Text = "paterno";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(649, 214);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 9;
            this.button5.Text = "materno";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelmaterno);
            this.Controls.Add(this.labelpaterno);
            this.Controls.Add(this.labelnombre);
            this.Controls.Add(this.labelcargo);
            this.Controls.Add(this.labelsaludo);
            this.Name = "Form1";
            this.Text = "Base";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelsaludo;
        private System.Windows.Forms.Label labelcargo;
        private System.Windows.Forms.Label labelnombre;
        private System.Windows.Forms.Label labelpaterno;
        private System.Windows.Forms.Label labelmaterno;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}

