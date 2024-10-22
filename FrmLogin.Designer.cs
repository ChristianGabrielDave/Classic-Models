namespace ClassicModels
{
    partial class FrmLogin
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
            this.LblSalesSystem = new System.Windows.Forms.Label();
            this.LblUsn = new System.Windows.Forms.Label();
            this.LblPsswrd = new System.Windows.Forms.Label();
            this.TxtbxUsn = new System.Windows.Forms.TextBox();
            this.TxtbxPass = new System.Windows.Forms.TextBox();
            this.BttnLgn = new System.Windows.Forms.Button();
            this.BttnCncl = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblSalesSystem
            // 
            this.LblSalesSystem.AutoSize = true;
            this.LblSalesSystem.Font = new System.Drawing.Font("Stencil", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSalesSystem.Location = new System.Drawing.Point(114, 29);
            this.LblSalesSystem.Name = "LblSalesSystem";
            this.LblSalesSystem.Size = new System.Drawing.Size(586, 95);
            this.LblSalesSystem.TabIndex = 0;
            this.LblSalesSystem.Text = "Sales System";
            // 
            // LblUsn
            // 
            this.LblUsn.AutoSize = true;
            this.LblUsn.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUsn.Location = new System.Drawing.Point(116, 156);
            this.LblUsn.Name = "LblUsn";
            this.LblUsn.Size = new System.Drawing.Size(210, 42);
            this.LblUsn.TabIndex = 1;
            this.LblUsn.Text = "Username: ";
            // 
            // LblPsswrd
            // 
            this.LblPsswrd.AutoSize = true;
            this.LblPsswrd.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPsswrd.Location = new System.Drawing.Point(123, 223);
            this.LblPsswrd.Name = "LblPsswrd";
            this.LblPsswrd.Size = new System.Drawing.Size(203, 42);
            this.LblPsswrd.TabIndex = 2;
            this.LblPsswrd.Text = "Password: ";
            // 
            // TxtbxUsn
            // 
            this.TxtbxUsn.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtbxUsn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtbxUsn.Location = new System.Drawing.Point(317, 162);
            this.TxtbxUsn.Name = "TxtbxUsn";
            this.TxtbxUsn.Size = new System.Drawing.Size(353, 34);
            this.TxtbxUsn.TabIndex = 3;
            // 
            // TxtbxPass
            // 
            this.TxtbxPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtbxPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtbxPass.Location = new System.Drawing.Point(317, 231);
            this.TxtbxPass.Name = "TxtbxPass";
            this.TxtbxPass.PasswordChar = '0';
            this.TxtbxPass.Size = new System.Drawing.Size(353, 34);
            this.TxtbxPass.TabIndex = 4;
            this.TxtbxPass.UseSystemPasswordChar = true;
            // 
            // BttnLgn
            // 
            this.BttnLgn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BttnLgn.Location = new System.Drawing.Point(317, 289);
            this.BttnLgn.Name = "BttnLgn";
            this.BttnLgn.Size = new System.Drawing.Size(165, 42);
            this.BttnLgn.TabIndex = 5;
            this.BttnLgn.Text = "Login";
            this.BttnLgn.UseVisualStyleBackColor = true;
            this.BttnLgn.Click += new System.EventHandler(this.BttnLgn_Click);
            // 
            // BttnCncl
            // 
            this.BttnCncl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BttnCncl.Location = new System.Drawing.Point(505, 289);
            this.BttnCncl.Name = "BttnCncl";
            this.BttnCncl.Size = new System.Drawing.Size(165, 42);
            this.BttnCncl.TabIndex = 6;
            this.BttnCncl.Text = "Cancel";
            this.BttnCncl.UseVisualStyleBackColor = true;
            this.BttnCncl.Click += new System.EventHandler(this.BttnCncl_Click);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BttnCncl);
            this.Controls.Add(this.BttnLgn);
            this.Controls.Add(this.TxtbxPass);
            this.Controls.Add(this.TxtbxUsn);
            this.Controls.Add(this.LblPsswrd);
            this.Controls.Add(this.LblUsn);
            this.Controls.Add(this.LblSalesSystem);
            this.Name = "FrmLogin";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblSalesSystem;
        private System.Windows.Forms.Label LblUsn;
        private System.Windows.Forms.Label LblPsswrd;
        private System.Windows.Forms.TextBox TxtbxUsn;
        private System.Windows.Forms.TextBox TxtbxPass;
        private System.Windows.Forms.Button BttnLgn;
        private System.Windows.Forms.Button BttnCncl;
    }
}

