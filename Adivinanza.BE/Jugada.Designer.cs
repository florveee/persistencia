namespace Adivinanza.Front
{
    partial class Jugada
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
            this.lblingNum = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.btAdivinar = new System.Windows.Forms.Button();
            this.numsecreto = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(409, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(459, 59);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adivine el número entre el 1 y el 100";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblingNum
            // 
            this.lblingNum.AutoSize = true;
            this.lblingNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblingNum.ForeColor = System.Drawing.Color.White;
            this.lblingNum.Location = new System.Drawing.Point(549, 193);
            this.lblingNum.Name = "lblingNum";
            this.lblingNum.Size = new System.Drawing.Size(194, 24);
            this.lblingNum.TabIndex = 1;
            this.lblingNum.Text = "Ingrese un número:";
            this.lblingNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNumero
            // 
            this.txtNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumero.Location = new System.Drawing.Point(481, 230);
            this.txtNumero.Multiline = true;
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(323, 39);
            this.txtNumero.TabIndex = 2;
            // 
            // lblResultado
            // 
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.ForeColor = System.Drawing.Color.White;
            this.lblResultado.Location = new System.Drawing.Point(445, 439);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(405, 69);
            this.lblResultado.TabIndex = 4;
            this.lblResultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btAdivinar
            // 
            this.btAdivinar.BackColor = System.Drawing.Color.White;
            this.btAdivinar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAdivinar.Location = new System.Drawing.Point(577, 317);
            this.btAdivinar.Name = "btAdivinar";
            this.btAdivinar.Size = new System.Drawing.Size(131, 67);
            this.btAdivinar.TabIndex = 5;
            this.btAdivinar.Text = "Adivinar";
            this.btAdivinar.UseVisualStyleBackColor = false;
            this.btAdivinar.Click += new System.EventHandler(this.btAdivinar_Click);
            // 
            // numsecreto
            // 
            this.numsecreto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numsecreto.Location = new System.Drawing.Point(1056, 79);
            this.numsecreto.Name = "numsecreto";
            this.numsecreto.Size = new System.Drawing.Size(76, 49);
            this.numsecreto.TabIndex = 6;
            this.numsecreto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Jugada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.ClientSize = new System.Drawing.Size(1332, 620);
            this.Controls.Add(this.numsecreto);
            this.Controls.Add(this.btAdivinar);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.lblingNum);
            this.Controls.Add(this.label1);
            this.Name = "Jugada";
            this.Text = "Jugada";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblingNum;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button btAdivinar;
        private System.Windows.Forms.Label numsecreto;
    }
}