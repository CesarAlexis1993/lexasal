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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Facturacion));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNumTck = new System.Windows.Forms.TextBox();
            this.txtNumCcf = new System.Windows.Forms.TextBox();
            this.txtNumFact = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblNumOrden = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnCcf = new System.Windows.Forms.Button();
            this.btnFact = new System.Windows.Forms.Button();
            this.btnTck = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.groupBox1.Location = new System.Drawing.Point(12, 147);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(688, 261);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Documentos";
            // 
            // txtNumTck
            // 
            this.txtNumTck.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumTck.ForeColor = System.Drawing.Color.Red;
            this.txtNumTck.Location = new System.Drawing.Point(6, 33);
            this.txtNumTck.Name = "txtNumTck";
            this.txtNumTck.Size = new System.Drawing.Size(220, 29);
            this.txtNumTck.TabIndex = 5;
            // 
            // txtNumCcf
            // 
            this.txtNumCcf.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumCcf.ForeColor = System.Drawing.Color.Red;
            this.txtNumCcf.Location = new System.Drawing.Point(232, 30);
            this.txtNumCcf.Name = "txtNumCcf";
            this.txtNumCcf.Size = new System.Drawing.Size(220, 29);
            this.txtNumCcf.TabIndex = 4;
            // 
            // txtNumFact
            // 
            this.txtNumFact.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumFact.ForeColor = System.Drawing.Color.Red;
            this.txtNumFact.Location = new System.Drawing.Point(458, 30);
            this.txtNumFact.Name = "txtNumFact";
            this.txtNumFact.Size = new System.Drawing.Size(220, 29);
            this.txtNumFact.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblNumOrden);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Window;
            this.groupBox2.Location = new System.Drawing.Point(12, 41);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(688, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Número de Orden";
            // 
            // lblNumOrden
            // 
            this.lblNumOrden.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumOrden.ForeColor = System.Drawing.Color.Red;
            this.lblNumOrden.Location = new System.Drawing.Point(6, 27);
            this.lblNumOrden.Name = "lblNumOrden";
            this.lblNumOrden.Size = new System.Drawing.Size(676, 70);
            this.lblNumOrden.TabIndex = 0;
            this.lblNumOrden.Text = "0";
            this.lblNumOrden.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnCerrar
            // 
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.ForeColor = System.Drawing.SystemColors.Window;
            this.btnCerrar.Location = new System.Drawing.Point(608, 12);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(20, 23);
            this.btnCerrar.TabIndex = 2;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnCcf
            // 
            this.btnCcf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCcf.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCcf.Image = ((System.Drawing.Image)(resources.GetObject("btnCcf.Image")));
            this.btnCcf.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCcf.Location = new System.Drawing.Point(458, 68);
            this.btnCcf.Name = "btnCcf";
            this.btnCcf.Size = new System.Drawing.Size(220, 180);
            this.btnCcf.TabIndex = 2;
            this.btnCcf.Text = "CRÉDITO FISCAL";
            this.btnCcf.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCcf.UseVisualStyleBackColor = true;
            this.btnCcf.Click += new System.EventHandler(this.btnCcf_Click);
            // 
            // btnFact
            // 
            this.btnFact.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFact.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFact.Image = global::LinkPos.Properties.Resources.FAC;
            this.btnFact.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnFact.Location = new System.Drawing.Point(232, 68);
            this.btnFact.Name = "btnFact";
            this.btnFact.Size = new System.Drawing.Size(220, 180);
            this.btnFact.TabIndex = 1;
            this.btnFact.Text = "FACTURA";
            this.btnFact.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFact.UseVisualStyleBackColor = true;
            this.btnFact.Click += new System.EventHandler(this.btnFact_Click);
            // 
            // btnTck
            // 
            this.btnTck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTck.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTck.Image = ((System.Drawing.Image)(resources.GetObject("btnTck.Image")));
            this.btnTck.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnTck.Location = new System.Drawing.Point(6, 68);
            this.btnTck.Name = "btnTck";
            this.btnTck.Size = new System.Drawing.Size(220, 180);
            this.btnTck.TabIndex = 0;
            this.btnTck.Text = "TICKET";
            this.btnTck.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTck.UseVisualStyleBackColor = true;
            this.btnTck.Click += new System.EventHandler(this.btnTck_Click);
            // 
            // Facturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(712, 419);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Facturacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facturacion";
            this.Load += new System.EventHandler(this.Facturacion_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
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
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblNumOrden;
        private System.Windows.Forms.Button btnCerrar;
    }
}