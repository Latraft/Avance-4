namespace EDDemo.Estructuras_Lineales.Clases
{
    partial class frmCola
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
            this.btnIniciar = new System.Windows.Forms.Button();
            this.lblVarillaA = new System.Windows.Forms.Label();
            this.lblVarillaB = new System.Windows.Forms.Label();
            this.lblVarillaC = new System.Windows.Forms.Label();
            this.txtDiscos = new System.Windows.Forms.TextBox();
            this.lblProgreso = new System.Windows.Forms.Label();
            this.btnMoverDiscos = new System.Windows.Forms.Button();
            this.btnDetener = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFib = new System.Windows.Forms.TextBox();
            this.btnResult = new System.Windows.Forms.Label();
            this.Fibanocci = new System.Windows.Forms.Label();
            this.btnFiabIn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnIniciar
            // 
            this.btnIniciar.Location = new System.Drawing.Point(36, 100);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(75, 23);
            this.btnIniciar.TabIndex = 0;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click_1);
            // 
            // lblVarillaA
            // 
            this.lblVarillaA.AutoSize = true;
            this.lblVarillaA.Location = new System.Drawing.Point(70, 193);
            this.lblVarillaA.Name = "lblVarillaA";
            this.lblVarillaA.Size = new System.Drawing.Size(0, 13);
            this.lblVarillaA.TabIndex = 1;
            this.lblVarillaA.Click += new System.EventHandler(this.lblVarillaA_Click);
            // 
            // lblVarillaB
            // 
            this.lblVarillaB.AutoSize = true;
            this.lblVarillaB.Location = new System.Drawing.Point(70, 225);
            this.lblVarillaB.Name = "lblVarillaB";
            this.lblVarillaB.Size = new System.Drawing.Size(0, 13);
            this.lblVarillaB.TabIndex = 2;
            this.lblVarillaB.Click += new System.EventHandler(this.lblVarillaB_Click);
            // 
            // lblVarillaC
            // 
            this.lblVarillaC.AutoSize = true;
            this.lblVarillaC.Location = new System.Drawing.Point(70, 253);
            this.lblVarillaC.Name = "lblVarillaC";
            this.lblVarillaC.Size = new System.Drawing.Size(0, 13);
            this.lblVarillaC.TabIndex = 3;
            // 
            // txtDiscos
            // 
            this.txtDiscos.Location = new System.Drawing.Point(36, 74);
            this.txtDiscos.Name = "txtDiscos";
            this.txtDiscos.Size = new System.Drawing.Size(114, 20);
            this.txtDiscos.TabIndex = 4;
            this.txtDiscos.TextChanged += new System.EventHandler(this.txtDiscos_TextChanged);
            // 
            // lblProgreso
            // 
            this.lblProgreso.AutoSize = true;
            this.lblProgreso.Location = new System.Drawing.Point(156, 58);
            this.lblProgreso.Name = "lblProgreso";
            this.lblProgreso.Size = new System.Drawing.Size(58, 13);
            this.lblProgreso.TabIndex = 5;
            this.lblProgreso.Text = "Progreso...";
            this.lblProgreso.Click += new System.EventHandler(this.lblProgreso_Click);
            // 
            // btnMoverDiscos
            // 
            this.btnMoverDiscos.Location = new System.Drawing.Point(117, 100);
            this.btnMoverDiscos.Name = "btnMoverDiscos";
            this.btnMoverDiscos.Size = new System.Drawing.Size(75, 23);
            this.btnMoverDiscos.TabIndex = 6;
            this.btnMoverDiscos.Text = "Mover";
            this.btnMoverDiscos.UseVisualStyleBackColor = true;
            this.btnMoverDiscos.Click += new System.EventHandler(this.btnMoverDiscos_Click);
            // 
            // btnDetener
            // 
            this.btnDetener.Location = new System.Drawing.Point(36, 129);
            this.btnDetener.Name = "btnDetener";
            this.btnDetener.Size = new System.Drawing.Size(75, 23);
            this.btnDetener.TabIndex = 7;
            this.btnDetener.Text = "Detener";
            this.btnDetener.UseVisualStyleBackColor = true;
            this.btnDetener.Click += new System.EventHandler(this.btnDetener_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Torre de Hano";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnFib
            // 
            this.btnFib.Location = new System.Drawing.Point(340, 96);
            this.btnFib.Name = "btnFib";
            this.btnFib.Size = new System.Drawing.Size(100, 20);
            this.btnFib.TabIndex = 9;
            // 
            // btnResult
            // 
            this.btnResult.AutoSize = true;
            this.btnResult.Location = new System.Drawing.Point(446, 96);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(0, 13);
            this.btnResult.TabIndex = 10;
            // 
            // Fibanocci
            // 
            this.Fibanocci.AutoSize = true;
            this.Fibanocci.Location = new System.Drawing.Point(337, 77);
            this.Fibanocci.Name = "Fibanocci";
            this.Fibanocci.Size = new System.Drawing.Size(53, 13);
            this.Fibanocci.TabIndex = 11;
            this.Fibanocci.Text = "Fibanocci";
            // 
            // btnFiabIn
            // 
            this.btnFiabIn.Location = new System.Drawing.Point(340, 122);
            this.btnFiabIn.Name = "btnFiabIn";
            this.btnFiabIn.Size = new System.Drawing.Size(75, 23);
            this.btnFiabIn.TabIndex = 12;
            this.btnFiabIn.Text = "Iniciar";
            this.btnFiabIn.UseVisualStyleBackColor = true;
            this.btnFiabIn.Click += new System.EventHandler(this.btnFiabIn_Click);
            // 
            // frmCola
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnFiabIn);
            this.Controls.Add(this.Fibanocci);
            this.Controls.Add(this.btnResult);
            this.Controls.Add(this.btnFib);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDetener);
            this.Controls.Add(this.btnMoverDiscos);
            this.Controls.Add(this.lblProgreso);
            this.Controls.Add(this.txtDiscos);
            this.Controls.Add(this.lblVarillaC);
            this.Controls.Add(this.lblVarillaB);
            this.Controls.Add(this.lblVarillaA);
            this.Controls.Add(this.btnIniciar);
            this.Name = "frmCola";
            this.Text = "frmCola";
            this.Load += new System.EventHandler(this.frmCola_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Label lblVarillaA;
        private System.Windows.Forms.Label lblVarillaB;
        private System.Windows.Forms.Label lblVarillaC;
        private System.Windows.Forms.TextBox txtDiscos;
        private System.Windows.Forms.Label lblProgreso;
        private System.Windows.Forms.Button btnMoverDiscos;
        private System.Windows.Forms.Button btnDetener;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox btnFib;
        private System.Windows.Forms.Label btnResult;
        private System.Windows.Forms.Label Fibanocci;
        private System.Windows.Forms.Button btnFiabIn;
    }
}