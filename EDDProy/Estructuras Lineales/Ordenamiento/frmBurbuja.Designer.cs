namespace EDDemo.Estructuras_Lineales.Busqueda
{
    partial class frmBurbuja
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
            this.components = new System.ComponentModel.Container();
            this.txtEntrada = new System.Windows.Forms.TextBox();
            this.btnOrdenar = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumeros = new System.Windows.Forms.TextBox();
            this.btnOrdenarShellsort = new System.Windows.Forms.Button();
            this.lblResultadoOrdenado = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.lblResultadoL = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnOrdenarQuickSort = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblResultadorU = new System.Windows.Forms.Label();
            this.btnOrdenarInsertionSort = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtNumerosU = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtEntrada
            // 
            this.txtEntrada.Location = new System.Drawing.Point(44, 69);
            this.txtEntrada.Name = "txtEntrada";
            this.txtEntrada.Size = new System.Drawing.Size(100, 20);
            this.txtEntrada.TabIndex = 0;
            this.txtEntrada.TextChanged += new System.EventHandler(this.txtEntrada_TextChanged);
            // 
            // btnOrdenar
            // 
            this.btnOrdenar.Location = new System.Drawing.Point(44, 95);
            this.btnOrdenar.Name = "btnOrdenar";
            this.btnOrdenar.Size = new System.Drawing.Size(75, 23);
            this.btnOrdenar.TabIndex = 2;
            this.btnOrdenar.Text = "Ordenar";
            this.btnOrdenar.UseVisualStyleBackColor = true;
            this.btnOrdenar.Click += new System.EventHandler(this.btnOrdenar_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(50, 121);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(0, 13);
            this.lblResultado.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Burbuja";
            // 
            // txtNumeros
            // 
            this.txtNumeros.Location = new System.Drawing.Point(229, 69);
            this.txtNumeros.Name = "txtNumeros";
            this.txtNumeros.Size = new System.Drawing.Size(103, 20);
            this.txtNumeros.TabIndex = 5;
            // 
            // btnOrdenarShellsort
            // 
            this.btnOrdenarShellsort.Location = new System.Drawing.Point(229, 95);
            this.btnOrdenarShellsort.Name = "btnOrdenarShellsort";
            this.btnOrdenarShellsort.Size = new System.Drawing.Size(75, 23);
            this.btnOrdenarShellsort.TabIndex = 6;
            this.btnOrdenarShellsort.Text = "Ordenar";
            this.btnOrdenarShellsort.UseVisualStyleBackColor = true;
            this.btnOrdenarShellsort.Click += new System.EventHandler(this.btnOrdenarShellsort_Click);
            // 
            // lblResultadoOrdenado
            // 
            this.lblResultadoOrdenado.AutoSize = true;
            this.lblResultadoOrdenado.Location = new System.Drawing.Point(261, 121);
            this.lblResultadoOrdenado.Name = "lblResultadoOrdenado";
            this.lblResultadoOrdenado.Size = new System.Drawing.Size(0, 13);
            this.lblResultadoOrdenado.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(226, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Shellsort";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(44, 204);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(100, 20);
            this.txtNumero.TabIndex = 9;
            // 
            // lblResultadoL
            // 
            this.lblResultadoL.AutoSize = true;
            this.lblResultadoL.Location = new System.Drawing.Point(49, 256);
            this.lblResultadoL.Name = "lblResultadoL";
            this.lblResultadoL.Size = new System.Drawing.Size(0, 13);
            this.lblResultadoL.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Quicksort";
            // 
            // btnOrdenarQuickSort
            // 
            this.btnOrdenarQuickSort.Location = new System.Drawing.Point(44, 230);
            this.btnOrdenarQuickSort.Name = "btnOrdenarQuickSort";
            this.btnOrdenarQuickSort.Size = new System.Drawing.Size(75, 23);
            this.btnOrdenarQuickSort.TabIndex = 12;
            this.btnOrdenarQuickSort.Text = "button1";
            this.btnOrdenarQuickSort.UseVisualStyleBackColor = true;
            this.btnOrdenarQuickSort.Click += new System.EventHandler(this.btnOrdenarQuickSort_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(226, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Insertionsort";
            // 
            // lblResultadorU
            // 
            this.lblResultadorU.AutoSize = true;
            this.lblResultadorU.Location = new System.Drawing.Point(226, 256);
            this.lblResultadorU.Name = "lblResultadorU";
            this.lblResultadorU.Size = new System.Drawing.Size(0, 13);
            this.lblResultadorU.TabIndex = 14;
            // 
            // btnOrdenarInsertionSort
            // 
            this.btnOrdenarInsertionSort.Location = new System.Drawing.Point(220, 230);
            this.btnOrdenarInsertionSort.Name = "btnOrdenarInsertionSort";
            this.btnOrdenarInsertionSort.Size = new System.Drawing.Size(75, 23);
            this.btnOrdenarInsertionSort.TabIndex = 15;
            this.btnOrdenarInsertionSort.Text = "Ordenar";
            this.btnOrdenarInsertionSort.UseVisualStyleBackColor = true;
            this.btnOrdenarInsertionSort.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtNumerosU
            // 
            this.txtNumerosU.Location = new System.Drawing.Point(220, 204);
            this.txtNumerosU.Name = "txtNumerosU";
            this.txtNumerosU.Size = new System.Drawing.Size(100, 20);
            this.txtNumerosU.TabIndex = 17;
            this.txtNumerosU.TextChanged += new System.EventHandler(this.txtNumerosU_TextChanged);
            // 
            // frmBurbuja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 349);
            this.Controls.Add(this.btnOrdenarInsertionSort);
            this.Controls.Add(this.txtNumerosU);
            this.Controls.Add(this.lblResultadorU);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnOrdenarQuickSort);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblResultadoL);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblResultadoOrdenado);
            this.Controls.Add(this.btnOrdenarShellsort);
            this.Controls.Add(this.txtNumeros);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnOrdenar);
            this.Controls.Add(this.txtEntrada);
            this.Name = "frmBurbuja";
            this.Text = "frmBurbuja";
            this.Load += new System.EventHandler(this.frmBurbuja_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEntrada;
        private System.Windows.Forms.Button btnOrdenar;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumeros;
        private System.Windows.Forms.Button btnOrdenarShellsort;
        private System.Windows.Forms.Label lblResultadoOrdenado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label lblResultadoL;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnOrdenarQuickSort;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblResultadorU;
        private System.Windows.Forms.Button btnOrdenarInsertionSort;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txtNumerosU;
    }
}