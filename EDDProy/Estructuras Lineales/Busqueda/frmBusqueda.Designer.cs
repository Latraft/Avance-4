namespace EDDemo.Estructuras_Lineales.Busqueda
{
    partial class frmBusqueda
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
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtObjetivo = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.txtObjetivos = new System.Windows.Forms.TextBox();
            this.txtNumeros = new System.Windows.Forms.TextBox();
            this.btnBuscarr = new System.Windows.Forms.Button();
            this.lblResulta2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(12, 67);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(100, 20);
            this.txtNumero.TabIndex = 0;
            this.txtNumero.TextChanged += new System.EventHandler(this.txtNumeros_TextChanged);
            // 
            // txtObjetivo
            // 
            this.txtObjetivo.Location = new System.Drawing.Point(188, 67);
            this.txtObjetivo.Name = "txtObjetivo";
            this.txtObjetivo.Size = new System.Drawing.Size(100, 20);
            this.txtObjetivo.TabIndex = 1;
            this.txtObjetivo.TextChanged += new System.EventHandler(this.txtObjetivo_TextChanged);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(117, 107);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Busqueda Secuencial";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(132, 144);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(0, 13);
            this.lblResultado.TabIndex = 4;
            // 
            // txtObjetivos
            // 
            this.txtObjetivos.Location = new System.Drawing.Point(539, 67);
            this.txtObjetivos.Name = "txtObjetivos";
            this.txtObjetivos.Size = new System.Drawing.Size(100, 20);
            this.txtObjetivos.TabIndex = 5;
            // 
            // txtNumeros
            // 
            this.txtNumeros.Location = new System.Drawing.Point(357, 67);
            this.txtNumeros.Name = "txtNumeros";
            this.txtNumeros.Size = new System.Drawing.Size(100, 20);
            this.txtNumeros.TabIndex = 6;
            this.txtNumeros.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // btnBuscarr
            // 
            this.btnBuscarr.Location = new System.Drawing.Point(464, 98);
            this.btnBuscarr.Name = "btnBuscarr";
            this.btnBuscarr.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarr.TabIndex = 7;
            this.btnBuscarr.Text = "button1";
            this.btnBuscarr.UseVisualStyleBackColor = true;
            this.btnBuscarr.Click += new System.EventHandler(this.btnBuscarr_Click);
            // 
            // lblResulta2
            // 
            this.lblResulta2.AutoSize = true;
            this.lblResulta2.Location = new System.Drawing.Point(484, 124);
            this.lblResulta2.Name = "lblResulta2";
            this.lblResulta2.Size = new System.Drawing.Size(0, 13);
            this.lblResulta2.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(446, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Busqueda por Hashing";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // frmBusqueda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblResulta2);
            this.Controls.Add(this.btnBuscarr);
            this.Controls.Add(this.txtNumeros);
            this.Controls.Add(this.txtObjetivos);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtObjetivo);
            this.Controls.Add(this.txtNumero);
            this.Name = "frmBusqueda";
            this.Text = "Busquedas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtObjetivo;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.TextBox txtObjetivos;
        private System.Windows.Forms.TextBox txtNumeros;
        private System.Windows.Forms.Button btnBuscarr;
        private System.Windows.Forms.Label lblResulta2;
        private System.Windows.Forms.Label label3;
    }
}