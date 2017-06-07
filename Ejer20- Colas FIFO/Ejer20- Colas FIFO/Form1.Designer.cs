namespace Ejer20__Colas_FIFO
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtCiclosColaVacía = new System.Windows.Forms.TextBox();
            this.lblProcesosPendientes = new System.Windows.Forms.Label();
            this.txtProcesosPendientes = new System.Windows.Forms.TextBox();
            this.lblSumadeCiclosPendientes = new System.Windows.Forms.Label();
            this.txtSumaCiclos = new System.Windows.Forms.TextBox();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número de ciclos con cola vacía:";
            // 
            // txtCiclosColaVacía
            // 
            this.txtCiclosColaVacía.Location = new System.Drawing.Point(273, 33);
            this.txtCiclosColaVacía.Name = "txtCiclosColaVacía";
            this.txtCiclosColaVacía.ReadOnly = true;
            this.txtCiclosColaVacía.Size = new System.Drawing.Size(112, 26);
            this.txtCiclosColaVacía.TabIndex = 1;
            // 
            // lblProcesosPendientes
            // 
            this.lblProcesosPendientes.AutoSize = true;
            this.lblProcesosPendientes.Location = new System.Drawing.Point(12, 75);
            this.lblProcesosPendientes.Name = "lblProcesosPendientes";
            this.lblProcesosPendientes.Size = new System.Drawing.Size(247, 20);
            this.lblProcesosPendientes.TabIndex = 2;
            this.lblProcesosPendientes.Text = "Número de procesos pendientes: ";
            // 
            // txtProcesosPendientes
            // 
            this.txtProcesosPendientes.Location = new System.Drawing.Point(273, 72);
            this.txtProcesosPendientes.Name = "txtProcesosPendientes";
            this.txtProcesosPendientes.ReadOnly = true;
            this.txtProcesosPendientes.Size = new System.Drawing.Size(112, 26);
            this.txtProcesosPendientes.TabIndex = 3;
            // 
            // lblSumadeCiclosPendientes
            // 
            this.lblSumadeCiclosPendientes.AutoSize = true;
            this.lblSumadeCiclosPendientes.Location = new System.Drawing.Point(12, 116);
            this.lblSumadeCiclosPendientes.Name = "lblSumadeCiclosPendientes";
            this.lblSumadeCiclosPendientes.Size = new System.Drawing.Size(207, 20);
            this.lblSumadeCiclosPendientes.TabIndex = 4;
            this.lblSumadeCiclosPendientes.Text = "Suma de ciclos pendientes: ";
            // 
            // txtSumaCiclos
            // 
            this.txtSumaCiclos.Location = new System.Drawing.Point(273, 113);
            this.txtSumaCiclos.Name = "txtSumaCiclos";
            this.txtSumaCiclos.ReadOnly = true;
            this.txtSumaCiclos.Size = new System.Drawing.Size(112, 26);
            this.txtSumaCiclos.TabIndex = 5;
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(243, 158);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(142, 43);
            this.btnGenerar.TabIndex = 6;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 213);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.txtSumaCiclos);
            this.Controls.Add(this.lblSumadeCiclosPendientes);
            this.Controls.Add(this.txtProcesosPendientes);
            this.Controls.Add(this.lblProcesosPendientes);
            this.Controls.Add(this.txtCiclosColaVacía);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCiclosColaVacía;
        private System.Windows.Forms.Label lblProcesosPendientes;
        private System.Windows.Forms.TextBox txtProcesosPendientes;
        private System.Windows.Forms.Label lblSumadeCiclosPendientes;
        private System.Windows.Forms.TextBox txtSumaCiclos;
        private System.Windows.Forms.Button btnGenerar;
    }
}

