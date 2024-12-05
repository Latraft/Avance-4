namespace EDDemo.Estructuras_Lineales.Clases
{
    partial class frmListas
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
            this.btnDatoC = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label = new System.Windows.Forms.Label();
            this.btnCircular = new System.Windows.Forms.Label();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMostrar = new System.Windows.Forms.Label();
            this.btnInsertarC = new System.Windows.Forms.Button();
            this.btnEliminarC = new System.Windows.Forms.Button();
            this.btnValores = new System.Windows.Forms.TextBox();
            this.btnInicio = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCrear = new System.Windows.Forms.Button();
            this.btnInser = new System.Windows.Forms.Button();
            this.btnVerL = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDatoC
            // 
            this.btnDatoC.Location = new System.Drawing.Point(12, 59);
            this.btnDatoC.Name = "btnDatoC";
            this.btnDatoC.Size = new System.Drawing.Size(99, 20);
            this.btnDatoC.TabIndex = 0;
            this.btnDatoC.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(9, 22);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(100, 13);
            this.label.TabIndex = 2;
            this.label.Text = "Listas circular doble";
            this.label.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnCircular
            // 
            this.btnCircular.AutoSize = true;
            this.btnCircular.Location = new System.Drawing.Point(12, 43);
            this.btnCircular.Name = "btnCircular";
            this.btnCircular.Size = new System.Drawing.Size(0, 13);
            this.btnCircular.TabIndex = 3;
            this.btnCircular.Click += new System.EventHandler(this.btnCircular_Click);
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(15, 85);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(75, 23);
            this.btnInsertar.TabIndex = 4;
            this.btnInsertar.Text = "Agregar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(15, 114);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 5;
            this.btnEliminar.Text = "Limpiar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Listas Dooblemente Enlazada";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // btnMostrar
            // 
            this.btnMostrar.AutoSize = true;
            this.btnMostrar.Location = new System.Drawing.Point(30, 185);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(0, 13);
            this.btnMostrar.TabIndex = 7;
            this.btnMostrar.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnInsertarC
            // 
            this.btnInsertarC.Location = new System.Drawing.Point(33, 237);
            this.btnInsertarC.Name = "btnInsertarC";
            this.btnInsertarC.Size = new System.Drawing.Size(89, 22);
            this.btnInsertarC.TabIndex = 8;
            this.btnInsertarC.Text = "Inicio";
            this.btnInsertarC.UseVisualStyleBackColor = true;
            this.btnInsertarC.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnEliminarC
            // 
            this.btnEliminarC.Location = new System.Drawing.Point(33, 265);
            this.btnEliminarC.Name = "btnEliminarC";
            this.btnEliminarC.Size = new System.Drawing.Size(89, 27);
            this.btnEliminarC.TabIndex = 9;
            this.btnEliminarC.Text = "Limpiar";
            this.btnEliminarC.UseVisualStyleBackColor = true;
            this.btnEliminarC.Click += new System.EventHandler(this.btnEliminarC_Click);
            // 
            // btnValores
            // 
            this.btnValores.Location = new System.Drawing.Point(33, 201);
            this.btnValores.Name = "btnValores";
            this.btnValores.Size = new System.Drawing.Size(100, 20);
            this.btnValores.TabIndex = 10;
            this.btnValores.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // btnInicio
            // 
            this.btnInicio.Location = new System.Drawing.Point(128, 236);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(75, 23);
            this.btnInicio.TabIndex = 11;
            this.btnInicio.Text = "Final";
            this.btnInicio.UseVisualStyleBackColor = true;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(103, 362);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 12;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_2);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(103, 336);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 13;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 343);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Dato";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 369);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Lista";
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(15, 398);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(75, 23);
            this.btnCrear.TabIndex = 16;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // btnInser
            // 
            this.btnInser.Location = new System.Drawing.Point(96, 398);
            this.btnInser.Name = "btnInser";
            this.btnInser.Size = new System.Drawing.Size(75, 23);
            this.btnInser.TabIndex = 17;
            this.btnInser.Text = "Inssertar";
            this.btnInser.UseVisualStyleBackColor = true;
            this.btnInser.Click += new System.EventHandler(this.btnInser_Click);
            // 
            // btnVerL
            // 
            this.btnVerL.Location = new System.Drawing.Point(188, 398);
            this.btnVerL.Name = "btnVerL";
            this.btnVerL.Size = new System.Drawing.Size(75, 23);
            this.btnVerL.TabIndex = 18;
            this.btnVerL.Text = "Ver Lista";
            this.btnVerL.UseVisualStyleBackColor = true;
            this.btnVerL.Click += new System.EventHandler(this.btnVerL_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(15, 437);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 19;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(103, 430);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(53, 36);
            this.btnBorrar.TabIndex = 20;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // frmListas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 539);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnVerL);
            this.Controls.Add(this.btnInser);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnInicio);
            this.Controls.Add(this.btnValores);
            this.Controls.Add(this.btnEliminarC);
            this.Controls.Add(this.btnInsertarC);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.btnCircular);
            this.Controls.Add(this.label);
            this.Controls.Add(this.btnDatoC);
            this.Name = "frmListas";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmListas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox btnDatoC;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label btnCircular;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label btnMostrar;
        private System.Windows.Forms.Button btnInsertarC;
        private System.Windows.Forms.Button btnEliminarC;
        private System.Windows.Forms.TextBox btnValores;
        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Button btnInser;
        private System.Windows.Forms.Button btnVerL;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnBorrar;
    }
}