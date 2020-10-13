namespace WindowsFormsApp1
{
    partial class Calculadora
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbxPrevio = new System.Windows.Forms.TextBox();
            this.pantalla = new System.Windows.Forms.TextBox();
            this.btnIgual = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnDivision = new System.Windows.Forms.Button();
            this.btnPunto = new System.Windows.Forms.Button();
            this.btnN3 = new System.Windows.Forms.Button();
            this.btnN6 = new System.Windows.Forms.Button();
            this.btnN9 = new System.Windows.Forms.Button();
            this.btnMultiplicacion = new System.Windows.Forms.Button();
            this.btnN2 = new System.Windows.Forms.Button();
            this.btnN5 = new System.Windows.Forms.Button();
            this.btnN8 = new System.Windows.Forms.Button();
            this.btnResta = new System.Windows.Forms.Button();
            this.btnN0 = new System.Windows.Forms.Button();
            this.btnN1 = new System.Windows.Forms.Button();
            this.btnN4 = new System.Windows.Forms.Button();
            this.btnN7 = new System.Windows.Forms.Button();
            this.btnSuma = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbxPrevio
            // 
            this.tbxPrevio.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.tbxPrevio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPrevio.ForeColor = System.Drawing.Color.Black;
            this.tbxPrevio.Location = new System.Drawing.Point(352, 65);
            this.tbxPrevio.Name = "tbxPrevio";
            this.tbxPrevio.ReadOnly = true;
            this.tbxPrevio.Size = new System.Drawing.Size(198, 29);
            this.tbxPrevio.TabIndex = 57;
            this.tbxPrevio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // pantalla
            // 
            this.pantalla.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.pantalla.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pantalla.ForeColor = System.Drawing.Color.Navy;
            this.pantalla.Location = new System.Drawing.Point(352, 89);
            this.pantalla.Name = "pantalla";
            this.pantalla.ReadOnly = true;
            this.pantalla.Size = new System.Drawing.Size(198, 47);
            this.pantalla.TabIndex = 54;
            this.pantalla.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnIgual
            // 
            this.btnIgual.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnIgual.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIgual.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIgual.Location = new System.Drawing.Point(505, 290);
            this.btnIgual.Name = "btnIgual";
            this.btnIgual.Size = new System.Drawing.Size(45, 96);
            this.btnIgual.TabIndex = 53;
            this.btnIgual.Text = "=";
            this.btnIgual.UseVisualStyleBackColor = false;
            this.btnIgual.Click += new System.EventHandler(this.btnIgual_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.IndianRed;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLimpiar.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(352, 137);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(45, 45);
            this.btnLimpiar.TabIndex = 51;
            this.btnLimpiar.Text = "CE";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnDivision
            // 
            this.btnDivision.BackColor = System.Drawing.Color.IndianRed;
            this.btnDivision.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDivision.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDivision.Location = new System.Drawing.Point(505, 137);
            this.btnDivision.Name = "btnDivision";
            this.btnDivision.Size = new System.Drawing.Size(45, 45);
            this.btnDivision.TabIndex = 50;
            this.btnDivision.Text = "÷";
            this.btnDivision.UseVisualStyleBackColor = false;
            this.btnDivision.Click += new System.EventHandler(this.btnDivision_Click);
            // 
            // btnPunto
            // 
            this.btnPunto.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnPunto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPunto.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPunto.Location = new System.Drawing.Point(454, 341);
            this.btnPunto.Name = "btnPunto";
            this.btnPunto.Size = new System.Drawing.Size(45, 45);
            this.btnPunto.TabIndex = 49;
            this.btnPunto.Text = ".";
            this.btnPunto.UseVisualStyleBackColor = false;
            this.btnPunto.Click += new System.EventHandler(this.btnPunto_Click);
            // 
            // btnN3
            // 
            this.btnN3.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnN3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnN3.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnN3.Location = new System.Drawing.Point(454, 290);
            this.btnN3.Name = "btnN3";
            this.btnN3.Size = new System.Drawing.Size(45, 45);
            this.btnN3.TabIndex = 48;
            this.btnN3.Text = "3";
            this.btnN3.UseVisualStyleBackColor = false;
            this.btnN3.Click += new System.EventHandler(this.btnN3_Click);
            // 
            // btnN6
            // 
            this.btnN6.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnN6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnN6.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnN6.Location = new System.Drawing.Point(454, 239);
            this.btnN6.Name = "btnN6";
            this.btnN6.Size = new System.Drawing.Size(45, 45);
            this.btnN6.TabIndex = 47;
            this.btnN6.Text = "6";
            this.btnN6.UseVisualStyleBackColor = false;
            this.btnN6.Click += new System.EventHandler(this.btnN6_Click);
            // 
            // btnN9
            // 
            this.btnN9.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnN9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnN9.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnN9.Location = new System.Drawing.Point(454, 188);
            this.btnN9.Name = "btnN9";
            this.btnN9.Size = new System.Drawing.Size(45, 45);
            this.btnN9.TabIndex = 46;
            this.btnN9.Text = "9";
            this.btnN9.UseVisualStyleBackColor = false;
            this.btnN9.Click += new System.EventHandler(this.btnN9_Click);
            // 
            // btnMultiplicacion
            // 
            this.btnMultiplicacion.BackColor = System.Drawing.Color.IndianRed;
            this.btnMultiplicacion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMultiplicacion.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiplicacion.Location = new System.Drawing.Point(454, 137);
            this.btnMultiplicacion.Name = "btnMultiplicacion";
            this.btnMultiplicacion.Size = new System.Drawing.Size(45, 45);
            this.btnMultiplicacion.TabIndex = 45;
            this.btnMultiplicacion.Text = "×";
            this.btnMultiplicacion.UseVisualStyleBackColor = false;
            this.btnMultiplicacion.Click += new System.EventHandler(this.btnMultiplicacion_Click);
            // 
            // btnN2
            // 
            this.btnN2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnN2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnN2.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnN2.Location = new System.Drawing.Point(403, 290);
            this.btnN2.Name = "btnN2";
            this.btnN2.Size = new System.Drawing.Size(45, 45);
            this.btnN2.TabIndex = 44;
            this.btnN2.Text = "2";
            this.btnN2.UseVisualStyleBackColor = false;
            this.btnN2.Click += new System.EventHandler(this.btnN2_Click);
            // 
            // btnN5
            // 
            this.btnN5.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnN5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnN5.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnN5.Location = new System.Drawing.Point(403, 239);
            this.btnN5.Name = "btnN5";
            this.btnN5.Size = new System.Drawing.Size(45, 45);
            this.btnN5.TabIndex = 43;
            this.btnN5.Text = "5";
            this.btnN5.UseVisualStyleBackColor = false;
            this.btnN5.Click += new System.EventHandler(this.btnN5_Click);
            // 
            // btnN8
            // 
            this.btnN8.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnN8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnN8.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnN8.Location = new System.Drawing.Point(403, 188);
            this.btnN8.Name = "btnN8";
            this.btnN8.Size = new System.Drawing.Size(45, 45);
            this.btnN8.TabIndex = 42;
            this.btnN8.Text = "8";
            this.btnN8.UseVisualStyleBackColor = false;
            this.btnN8.Click += new System.EventHandler(this.btnN8_Click);
            // 
            // btnResta
            // 
            this.btnResta.BackColor = System.Drawing.Color.IndianRed;
            this.btnResta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnResta.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResta.Location = new System.Drawing.Point(403, 137);
            this.btnResta.Name = "btnResta";
            this.btnResta.Size = new System.Drawing.Size(45, 45);
            this.btnResta.TabIndex = 41;
            this.btnResta.Text = "−";
            this.btnResta.UseVisualStyleBackColor = false;
            this.btnResta.Click += new System.EventHandler(this.btnResta_Click);
            // 
            // btnN0
            // 
            this.btnN0.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnN0.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnN0.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnN0.Location = new System.Drawing.Point(352, 341);
            this.btnN0.Name = "btnN0";
            this.btnN0.Size = new System.Drawing.Size(96, 45);
            this.btnN0.TabIndex = 40;
            this.btnN0.Text = "0";
            this.btnN0.UseVisualStyleBackColor = false;
            this.btnN0.Click += new System.EventHandler(this.btnN0_Click);
            // 
            // btnN1
            // 
            this.btnN1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnN1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnN1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnN1.Location = new System.Drawing.Point(352, 290);
            this.btnN1.Name = "btnN1";
            this.btnN1.Size = new System.Drawing.Size(45, 45);
            this.btnN1.TabIndex = 39;
            this.btnN1.Text = "1";
            this.btnN1.UseVisualStyleBackColor = false;
            this.btnN1.Click += new System.EventHandler(this.btnN1_Click);
            // 
            // btnN4
            // 
            this.btnN4.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnN4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnN4.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnN4.Location = new System.Drawing.Point(352, 239);
            this.btnN4.Name = "btnN4";
            this.btnN4.Size = new System.Drawing.Size(45, 45);
            this.btnN4.TabIndex = 38;
            this.btnN4.Text = "4";
            this.btnN4.UseVisualStyleBackColor = false;
            this.btnN4.Click += new System.EventHandler(this.btnN4_Click);
            // 
            // btnN7
            // 
            this.btnN7.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnN7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnN7.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnN7.Location = new System.Drawing.Point(352, 188);
            this.btnN7.Name = "btnN7";
            this.btnN7.Size = new System.Drawing.Size(45, 45);
            this.btnN7.TabIndex = 37;
            this.btnN7.Text = "7";
            this.btnN7.UseVisualStyleBackColor = false;
            this.btnN7.Click += new System.EventHandler(this.btnN7_Click);
            // 
            // btnSuma
            // 
            this.btnSuma.BackColor = System.Drawing.Color.IndianRed;
            this.btnSuma.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSuma.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuma.Location = new System.Drawing.Point(505, 188);
            this.btnSuma.Name = "btnSuma";
            this.btnSuma.Size = new System.Drawing.Size(45, 96);
            this.btnSuma.TabIndex = 36;
            this.btnSuma.Text = "+";
            this.btnSuma.UseVisualStyleBackColor = false;
            this.btnSuma.Click += new System.EventHandler(this.btnSuma_Click);
            // 
            // Calculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbxPrevio);
            this.Controls.Add(this.pantalla);
            this.Controls.Add(this.btnIgual);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnDivision);
            this.Controls.Add(this.btnPunto);
            this.Controls.Add(this.btnN3);
            this.Controls.Add(this.btnN6);
            this.Controls.Add(this.btnN9);
            this.Controls.Add(this.btnMultiplicacion);
            this.Controls.Add(this.btnN2);
            this.Controls.Add(this.btnN5);
            this.Controls.Add(this.btnN8);
            this.Controls.Add(this.btnResta);
            this.Controls.Add(this.btnN0);
            this.Controls.Add(this.btnN1);
            this.Controls.Add(this.btnN4);
            this.Controls.Add(this.btnN7);
            this.Controls.Add(this.btnSuma);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Calculadora";
            this.Text = "Calculadora";
            this.Load += new System.EventHandler(this.Calculadora_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxPrevio;
        private System.Windows.Forms.TextBox pantalla;
        private System.Windows.Forms.Button btnIgual;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnDivision;
        private System.Windows.Forms.Button btnPunto;
        private System.Windows.Forms.Button btnN3;
        private System.Windows.Forms.Button btnN6;
        private System.Windows.Forms.Button btnN9;
        private System.Windows.Forms.Button btnMultiplicacion;
        private System.Windows.Forms.Button btnN2;
        private System.Windows.Forms.Button btnN5;
        private System.Windows.Forms.Button btnN8;
        private System.Windows.Forms.Button btnResta;
        private System.Windows.Forms.Button btnN0;
        private System.Windows.Forms.Button btnN1;
        private System.Windows.Forms.Button btnN4;
        private System.Windows.Forms.Button btnN7;
        private System.Windows.Forms.Button btnSuma;
    }
}