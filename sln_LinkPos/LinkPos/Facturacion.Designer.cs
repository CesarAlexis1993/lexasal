namespace LinkPos
{
    partial class Facturacion
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTck = new System.Windows.Forms.Button();
            this.btnFact = new System.Windows.Forms.Button();
            this.btnCcf = new System.Windows.Forms.Button();
            this.txtNumFact = new System.Windows.Forms.TextBox();
            this.txtNumCcf = new System.Windows.Forms.TextBox();
            this.txtNumTck = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNumTck);
            this.groupBox1.Controls.Add(this.txtNumCcf);
            this.groupBox1.Controls.Add(this.txtNumFact);
            this.groupBox1.Controls.Add(this.btnCcf);
            this.groupBox1.Controls.Add(this.btnFact);
            this.groupBox1.Controls.Add(this.btnTck);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(616, 261);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Documentos";
            // 
            // btnTck
            // 
            this.btnTck.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTck.Location = new System.Drawing.Point(6, 68);
            this.btnTck.Name = "btnTck";
            this.btnTck.Size = new System.Drawing.Size(197, 180);
            this.btnTck.TabIndex = 0;
            this.btnTck.Text = "TICKET";
            this.btnTck.UseVisualStyleBackColor = true;
            // 
            // btnFact
            // 
            this.btnFact.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFact.Location = new System.Drawing.Point(209, 68);
            this.btnFact.Name = "btnFact";
            this.btnFact.Size = new System.Drawing.Size(197, 180);
            this.btnFact.TabIndex = 1;
            this.btnFact.Text = "FACTURA";
            this.btnFact.UseVisualStyleBackColor = true;
            // 
            // btnCcf
            // 
            this.btnCcf.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCcf.Location = new System.Drawing.Point(412, 68);
            this.btnCcf.Name = "btnCcf";
            this.btnCcf.Size = new System.Drawing.Size(197, 180);
            this.btnCcf.TabIndex = 2;
            this.btnCcf.Text = "CRÉDITO FISCAL";
            this.btnCcf.UseVisualStyleBackColor = true;
            // 
            // txtNumFact
            // 
            this.txtNumFact.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumFact.Location = new System.Drawing.Point(209, 33);
            this.txtNumFact.Name = "txtNumFact";
            this.txtNumFact.Size = new System.Drawing.Size(197, 29);
            this.txtNumFact.TabIndex = 3;
            // 
            // txtNumCcf
            // 
            this.txtNumCcf.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumCcf.Location = new System.Drawing.Point(412, 33);
            this.txtNumCcf.Name = "txtNumCcf";
            this.txtNumCcf.Size = new System.Drawing.Size(197, 29);
            this.txtNumCcf.TabIndex = 4;
            // 
            // txtNumTck
            // 
            this.txtNumTck.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumTck.Location = new System.Drawing.Point(6, 33);
            this.txtNumTck.Name = "txtNumTck";
            this.txtNumTck.Size = new System.Drawing.Size(197, 29);
            this.txtNumTck.TabIndex = 5;
            // 
            // Facturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 332);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Facturacion";
            this.Text = "Facturacion";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNumTck;
        private System.Windows.Forms.TextBox txtNumCcf;
        private System.Windows.Forms.TextBox txtNumFact;
        private System.Windows.Forms.Button btnCcf;
        private System.Windows.Forms.Button btnFact;
        private System.Windows.Forms.Button btnTck;
    }
}