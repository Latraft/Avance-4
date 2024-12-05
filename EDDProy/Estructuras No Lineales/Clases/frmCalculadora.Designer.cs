namespace EDDemo.Estructuras_No_Lineales.Clases
{
    partial class frmCalculadora
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
            this.btnFactorial = new System.Windows.Forms.TextBox();
            this.btnNombreF = new System.Windows.Forms.Label();
            this.btnBottar = new System.Windows.Forms.Button();
            this.btnHazlo = new System.Windows.Forms.Button();
            this.btnResultado = new System.Windows.Forms.Label();
            this.btnExponenteZ = new System.Windows.Forms.TextBox();
            this.Exponente = new System.Windows.Forms.Label();
            this.btnRespuesta = new System.Windows.Forms.Label();
            this.btnExponenteCalcu = new System.Windows.Forms.Button();
            this.btnBorrarZ = new System.Windows.Forms.Button();
            this.btnBaseZ = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtArreglo = new System.Windows.Forms.TextBox();
            this.btnSumar = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnFactorial
            // 
            this.btnFactorial.Location = new System.Drawing.Point(22, 62);
            this.btnFactorial.Name = "btnFactorial";
            this.btnFactorial.Size = new System.Drawing.Size(100, 20);
            this.btnFactorial.TabIndex = 2;
            this.btnFactorial.TextChanged += new System.EventHandler(this.btnFactorial_TextChanged);
            // 
            // btnNombreF
            // 
            this.btnNombreF.AutoSize = true;
            this.btnNombreF.Location = new System.Drawing.Point(19, 34);
            this.btnNombreF.Name = "btnNombreF";
            this.btnNombreF.Size = new System.Drawing.Size(47, 13);
            this.btnNombreF.TabIndex = 5;
            this.btnNombreF.Text = "Factorial";
            // 
            // btnBottar
            // 
            this.btnBottar.Location = new System.Drawing.Point(103, 108);
            this.btnBottar.Name = "btnBottar";
            this.btnBottar.Size = new System.Drawing.Size(75, 23);
            this.btnBottar.TabIndex = 6;
            this.btnBottar.Text = "Borrar";
            this.btnBottar.UseVisualStyleBackColor = true;
            this.btnBottar.Click += new System.EventHandler(this.btnBottar_Click);
            // 
            // btnHazlo
            // 
            this.btnHazlo.Location = new System.Drawing.Point(22, 108);
            this.btnHazlo.Name = "btnHazlo";
            this.btnHazlo.Size = new System.Drawing.Size(75, 23);
            this.btnHazlo.TabIndex = 7;
            this.btnHazlo.Text = "Iniciar";
            this.btnHazlo.UseVisualStyleBackColor = true;
            this.btnHazlo.Click += new System.EventHandler(this.btnHazlo_Click);
            // 
            // btnResultado
            // 
            this.btnResultado.AutoSize = true;
            this.btnResultado.Location = new System.Drawing.Point(100, 144);
            this.btnResultado.Name = "btnResultado";
            this.btnResultado.Size = new System.Drawing.Size(0, 13);
            this.btnResultado.TabIndex = 8;
            // 
            // btnExponenteZ
            // 
            this.btnExponenteZ.Location = new System.Drawing.Point(106, 192);
            this.btnExponenteZ.Name = "btnExponenteZ";
            this.btnExponenteZ.Size = new System.Drawing.Size(100, 20);
            this.btnExponenteZ.TabIndex = 9;
            this.btnExponenteZ.TextChanged += new System.EventHandler(this.btnExponenteZ_TextChanged);
            // 
            // Exponente
            // 
            this.Exponente.AutoSize = true;
            this.Exponente.Location = new System.Drawing.Point(103, 176);
            this.Exponente.Name = "Exponente";
            this.Exponente.Size = new System.Drawing.Size(58, 13);
            this.Exponente.TabIndex = 10;
            this.Exponente.Text = "Exponente";
            this.Exponente.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnRespuesta
            // 
            this.btnRespuesta.AutoSize = true;
            this.btnRespuesta.Location = new System.Drawing.Point(28, 244);
            this.btnRespuesta.Name = "btnRespuesta";
            this.btnRespuesta.Size = new System.Drawing.Size(0, 13);
            this.btnRespuesta.TabIndex = 11;
            this.btnRespuesta.Click += new System.EventHandler(this.btnRespuesta_Click);
            // 
            // btnExponenteCalcu
            // 
            this.btnExponenteCalcu.Location = new System.Drawing.Point(22, 218);
            this.btnExponenteCalcu.Name = "btnExponenteCalcu";
            this.btnExponenteCalcu.Size = new System.Drawing.Size(75, 23);
            this.btnExponenteCalcu.TabIndex = 12;
            this.btnExponenteCalcu.Text = "Iniciar";
            this.btnExponenteCalcu.UseVisualStyleBackColor = true;
            this.btnExponenteCalcu.Click += new System.EventHandler(this.btnExponenteCalcu_Click);
            // 
            // btnBorrarZ
            // 
            this.btnBorrarZ.Location = new System.Drawing.Point(103, 218);
            this.btnBorrarZ.Name = "btnBorrarZ";
            this.btnBorrarZ.Size = new System.Drawing.Size(75, 23);
            this.btnBorrarZ.TabIndex = 13;
            this.btnBorrarZ.Text = "Borrar";
            this.btnBorrarZ.UseVisualStyleBackColor = true;
            this.btnBorrarZ.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnBaseZ
            // 
            this.btnBaseZ.Location = new System.Drawing.Point(0, 192);
            this.btnBaseZ.Name = "btnBaseZ";
            this.btnBaseZ.Size = new System.Drawing.Size(100, 20);
            this.btnBaseZ.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-3, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Base";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-3, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Calculadora de Exponentes";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtArreglo
            // 
            this.txtArreglo.Location = new System.Drawing.Point(11, 301);
            this.txtArreglo.Name = "txtArreglo";
            this.txtArreglo.Size = new System.Drawing.Size(100, 20);
            this.txtArreglo.TabIndex = 17;
            this.txtArreglo.TextChanged += new System.EventHandler(this.txtArreglo_TextChanged);
            // 
            // btnSumar
            // 
            this.btnSumar.Location = new System.Drawing.Point(11, 327);
            this.btnSumar.Name = "btnSumar";
            this.btnSumar.Size = new System.Drawing.Size(75, 23);
            this.btnSumar.TabIndex = 18;
            this.btnSumar.Text = "Sumar";
            this.btnSumar.UseVisualStyleBackColor = true;
            this.btnSumar.Click += new System.EventHandler(this.btnSumar_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(12, 353);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(0, 13);
            this.lblResultado.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 285);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Suma de arreglos";
            // 
            // frmCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnSumar);
            this.Controls.Add(this.txtArreglo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBaseZ);
            this.Controls.Add(this.btnBorrarZ);
            this.Controls.Add(this.btnExponenteCalcu);
            this.Controls.Add(this.btnRespuesta);
            this.Controls.Add(this.Exponente);
            this.Controls.Add(this.btnExponenteZ);
            this.Controls.Add(this.btnResultado);
            this.Controls.Add(this.btnHazlo);
            this.Controls.Add(this.btnBottar);
            this.Controls.Add(this.btnNombreF);
            this.Controls.Add(this.btnFactorial);
            this.Name = "frmCalculadora";
            this.Text = "frmCalculadora";
            this.Load += new System.EventHandler(this.frmCalculadora_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox btnFactorial;
        private System.Windows.Forms.Label btnNombreF;
        private System.Windows.Forms.Button btnBottar;
        private System.Windows.Forms.Button btnHazlo;
        private System.Windows.Forms.Label btnResultado;
        private System.Windows.Forms.TextBox btnExponenteZ;
        private System.Windows.Forms.Label Exponente;
        private System.Windows.Forms.Label btnRespuesta;
        private System.Windows.Forms.Button btnExponenteCalcu;
        private System.Windows.Forms.Button btnBorrarZ;
        private System.Windows.Forms.TextBox btnBaseZ;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtArreglo;
        private System.Windows.Forms.Button btnSumar;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label label3;
    }
}