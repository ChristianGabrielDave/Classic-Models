namespace ClassicModels
{
    partial class FrmOrders
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
            this.TbcntrlOrdrs = new System.Windows.Forms.TabControl();
            this.NewOrdrs = new System.Windows.Forms.TabPage();
            this.BttnCancel = new System.Windows.Forms.Button();
            this.BttnUpdate = new System.Windows.Forms.Button();
            this.BttnSave = new System.Windows.Forms.Button();
            this.BttnDelete = new System.Windows.Forms.Button();
            this.BttnNew = new System.Windows.Forms.Button();
            this.CmbbxCntry = new System.Windows.Forms.ComboBox();
            this.TxtbxAddTwo = new System.Windows.Forms.TextBox();
            this.TxtbxAddOne = new System.Windows.Forms.TextBox();
            this.TxtbxCntctFN = new System.Windows.Forms.TextBox();
            this.TxtbxCntctLN = new System.Windows.Forms.TextBox();
            this.TxtbxCstmrNm = new System.Windows.Forms.TextBox();
            this.TxtbxCstmrNmbr = new System.Windows.Forms.TextBox();
            this.BttnLast = new System.Windows.Forms.Button();
            this.BttnNext = new System.Windows.Forms.Button();
            this.BttnPrevious = new System.Windows.Forms.Button();
            this.BttnFirst = new System.Windows.Forms.Button();
            this.LblAddTwo = new System.Windows.Forms.Label();
            this.LblAddOne = new System.Windows.Forms.Label();
            this.LblPhnNmbr = new System.Windows.Forms.Label();
            this.LblCntctFN = new System.Windows.Forms.Label();
            this.LblCntctLN = new System.Windows.Forms.Label();
            this.LblCstmrNm = new System.Windows.Forms.Label();
            this.LblCstmrNmbr = new System.Windows.Forms.Label();
            this.ViewOrdrs = new System.Windows.Forms.TabPage();
            this.DtgrdOrdrs = new System.Windows.Forms.DataGridView();
            this.TbcntrlOrdrs.SuspendLayout();
            this.NewOrdrs.SuspendLayout();
            this.ViewOrdrs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtgrdOrdrs)).BeginInit();
            this.SuspendLayout();
            // 
            // TbcntrlOrdrs
            // 
            this.TbcntrlOrdrs.Controls.Add(this.NewOrdrs);
            this.TbcntrlOrdrs.Controls.Add(this.ViewOrdrs);
            this.TbcntrlOrdrs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TbcntrlOrdrs.Location = new System.Drawing.Point(0, 0);
            this.TbcntrlOrdrs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TbcntrlOrdrs.Name = "TbcntrlOrdrs";
            this.TbcntrlOrdrs.SelectedIndex = 0;
            this.TbcntrlOrdrs.Size = new System.Drawing.Size(1065, 731);
            this.TbcntrlOrdrs.TabIndex = 1;
            // 
            // NewOrdrs
            // 
            this.NewOrdrs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.NewOrdrs.Controls.Add(this.BttnCancel);
            this.NewOrdrs.Controls.Add(this.BttnUpdate);
            this.NewOrdrs.Controls.Add(this.BttnSave);
            this.NewOrdrs.Controls.Add(this.BttnDelete);
            this.NewOrdrs.Controls.Add(this.BttnNew);
            this.NewOrdrs.Controls.Add(this.CmbbxCntry);
            this.NewOrdrs.Controls.Add(this.TxtbxAddTwo);
            this.NewOrdrs.Controls.Add(this.TxtbxAddOne);
            this.NewOrdrs.Controls.Add(this.TxtbxCntctFN);
            this.NewOrdrs.Controls.Add(this.TxtbxCntctLN);
            this.NewOrdrs.Controls.Add(this.TxtbxCstmrNm);
            this.NewOrdrs.Controls.Add(this.TxtbxCstmrNmbr);
            this.NewOrdrs.Controls.Add(this.BttnLast);
            this.NewOrdrs.Controls.Add(this.BttnNext);
            this.NewOrdrs.Controls.Add(this.BttnPrevious);
            this.NewOrdrs.Controls.Add(this.BttnFirst);
            this.NewOrdrs.Controls.Add(this.LblAddTwo);
            this.NewOrdrs.Controls.Add(this.LblAddOne);
            this.NewOrdrs.Controls.Add(this.LblPhnNmbr);
            this.NewOrdrs.Controls.Add(this.LblCntctFN);
            this.NewOrdrs.Controls.Add(this.LblCntctLN);
            this.NewOrdrs.Controls.Add(this.LblCstmrNm);
            this.NewOrdrs.Controls.Add(this.LblCstmrNmbr);
            this.NewOrdrs.Location = new System.Drawing.Point(4, 25);
            this.NewOrdrs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NewOrdrs.Name = "NewOrdrs";
            this.NewOrdrs.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NewOrdrs.Size = new System.Drawing.Size(1057, 702);
            this.NewOrdrs.TabIndex = 0;
            this.NewOrdrs.Text = "New Order";
            // 
            // BttnCancel
            // 
            this.BttnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BttnCancel.Location = new System.Drawing.Point(463, 535);
            this.BttnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BttnCancel.Name = "BttnCancel";
            this.BttnCancel.Size = new System.Drawing.Size(173, 41);
            this.BttnCancel.TabIndex = 37;
            this.BttnCancel.Text = "Cancel";
            this.BttnCancel.UseVisualStyleBackColor = true;
            // 
            // BttnUpdate
            // 
            this.BttnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BttnUpdate.Location = new System.Drawing.Point(592, 474);
            this.BttnUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BttnUpdate.Name = "BttnUpdate";
            this.BttnUpdate.Size = new System.Drawing.Size(173, 41);
            this.BttnUpdate.TabIndex = 36;
            this.BttnUpdate.Text = "Update";
            this.BttnUpdate.UseVisualStyleBackColor = true;
            // 
            // BttnSave
            // 
            this.BttnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BttnSave.Location = new System.Drawing.Point(338, 474);
            this.BttnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BttnSave.Name = "BttnSave";
            this.BttnSave.Size = new System.Drawing.Size(173, 41);
            this.BttnSave.TabIndex = 35;
            this.BttnSave.Text = "Save";
            this.BttnSave.UseVisualStyleBackColor = true;
            // 
            // BttnDelete
            // 
            this.BttnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BttnDelete.Location = new System.Drawing.Point(592, 419);
            this.BttnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BttnDelete.Name = "BttnDelete";
            this.BttnDelete.Size = new System.Drawing.Size(173, 41);
            this.BttnDelete.TabIndex = 34;
            this.BttnDelete.Text = "Delete";
            this.BttnDelete.UseVisualStyleBackColor = true;
            // 
            // BttnNew
            // 
            this.BttnNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BttnNew.Location = new System.Drawing.Point(338, 419);
            this.BttnNew.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BttnNew.Name = "BttnNew";
            this.BttnNew.Size = new System.Drawing.Size(173, 41);
            this.BttnNew.TabIndex = 33;
            this.BttnNew.Text = "New";
            this.BttnNew.UseVisualStyleBackColor = true;
            // 
            // CmbbxCntry
            // 
            this.CmbbxCntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbbxCntry.FormattingEnabled = true;
            this.CmbbxCntry.Location = new System.Drawing.Point(184, 225);
            this.CmbbxCntry.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CmbbxCntry.Name = "CmbbxCntry";
            this.CmbbxCntry.Size = new System.Drawing.Size(362, 39);
            this.CmbbxCntry.TabIndex = 29;
            // 
            // TxtbxAddTwo
            // 
            this.TxtbxAddTwo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtbxAddTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtbxAddTwo.Location = new System.Drawing.Point(294, 335);
            this.TxtbxAddTwo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtbxAddTwo.Name = "TxtbxAddTwo";
            this.TxtbxAddTwo.Size = new System.Drawing.Size(806, 38);
            this.TxtbxAddTwo.TabIndex = 23;
            // 
            // TxtbxAddOne
            // 
            this.TxtbxAddOne.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtbxAddOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtbxAddOne.Location = new System.Drawing.Point(272, 280);
            this.TxtbxAddOne.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtbxAddOne.Name = "TxtbxAddOne";
            this.TxtbxAddOne.Size = new System.Drawing.Size(806, 38);
            this.TxtbxAddOne.TabIndex = 22;
            // 
            // TxtbxCntctFN
            // 
            this.TxtbxCntctFN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtbxCntctFN.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtbxCntctFN.Location = new System.Drawing.Point(222, 174);
            this.TxtbxCntctFN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtbxCntctFN.Name = "TxtbxCntctFN";
            this.TxtbxCntctFN.Size = new System.Drawing.Size(806, 38);
            this.TxtbxCntctFN.TabIndex = 20;
            // 
            // TxtbxCntctLN
            // 
            this.TxtbxCntctLN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtbxCntctLN.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtbxCntctLN.Location = new System.Drawing.Point(222, 118);
            this.TxtbxCntctLN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtbxCntctLN.Name = "TxtbxCntctLN";
            this.TxtbxCntctLN.Size = new System.Drawing.Size(806, 38);
            this.TxtbxCntctLN.TabIndex = 19;
            // 
            // TxtbxCstmrNm
            // 
            this.TxtbxCstmrNm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtbxCstmrNm.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtbxCstmrNm.Location = new System.Drawing.Point(222, 61);
            this.TxtbxCstmrNm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtbxCstmrNm.Name = "TxtbxCstmrNm";
            this.TxtbxCstmrNm.Size = new System.Drawing.Size(806, 38);
            this.TxtbxCstmrNm.TabIndex = 18;
            // 
            // TxtbxCstmrNmbr
            // 
            this.TxtbxCstmrNmbr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtbxCstmrNmbr.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtbxCstmrNmbr.Location = new System.Drawing.Point(239, 13);
            this.TxtbxCstmrNmbr.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtbxCstmrNmbr.Name = "TxtbxCstmrNmbr";
            this.TxtbxCstmrNmbr.Size = new System.Drawing.Size(327, 38);
            this.TxtbxCstmrNmbr.TabIndex = 16;
            // 
            // BttnLast
            // 
            this.BttnLast.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BttnLast.Location = new System.Drawing.Point(674, 623);
            this.BttnLast.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BttnLast.Name = "BttnLast";
            this.BttnLast.Size = new System.Drawing.Size(173, 41);
            this.BttnLast.TabIndex = 15;
            this.BttnLast.Text = "Last";
            this.BttnLast.UseVisualStyleBackColor = true;
            // 
            // BttnNext
            // 
            this.BttnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BttnNext.Location = new System.Drawing.Point(251, 623);
            this.BttnNext.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BttnNext.Name = "BttnNext";
            this.BttnNext.Size = new System.Drawing.Size(173, 41);
            this.BttnNext.TabIndex = 14;
            this.BttnNext.Text = "Next";
            this.BttnNext.UseVisualStyleBackColor = true;
            // 
            // BttnPrevious
            // 
            this.BttnPrevious.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BttnPrevious.Location = new System.Drawing.Point(461, 623);
            this.BttnPrevious.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BttnPrevious.Name = "BttnPrevious";
            this.BttnPrevious.Size = new System.Drawing.Size(173, 41);
            this.BttnPrevious.TabIndex = 14;
            this.BttnPrevious.Text = "Previous";
            this.BttnPrevious.UseVisualStyleBackColor = true;
            // 
            // BttnFirst
            // 
            this.BttnFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BttnFirst.Location = new System.Drawing.Point(41, 623);
            this.BttnFirst.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BttnFirst.Name = "BttnFirst";
            this.BttnFirst.Size = new System.Drawing.Size(173, 41);
            this.BttnFirst.TabIndex = 13;
            this.BttnFirst.Text = "First";
            this.BttnFirst.UseVisualStyleBackColor = true;
            // 
            // LblAddTwo
            // 
            this.LblAddTwo.AutoSize = true;
            this.LblAddTwo.BackColor = System.Drawing.Color.Transparent;
            this.LblAddTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAddTwo.Location = new System.Drawing.Point(36, 337);
            this.LblAddTwo.Name = "LblAddTwo";
            this.LblAddTwo.Size = new System.Drawing.Size(263, 36);
            this.LblAddTwo.TabIndex = 10;
            this.LblAddTwo.Text = "Customer Number:";
            // 
            // LblAddOne
            // 
            this.LblAddOne.AutoSize = true;
            this.LblAddOne.BackColor = System.Drawing.Color.Transparent;
            this.LblAddOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAddOne.Location = new System.Drawing.Point(71, 279);
            this.LblAddOne.Name = "LblAddOne";
            this.LblAddOne.Size = new System.Drawing.Size(163, 36);
            this.LblAddOne.TabIndex = 9;
            this.LblAddOne.Text = "Comments:";
            // 
            // LblPhnNmbr
            // 
            this.LblPhnNmbr.AutoSize = true;
            this.LblPhnNmbr.BackColor = System.Drawing.Color.Transparent;
            this.LblPhnNmbr.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPhnNmbr.Location = new System.Drawing.Point(71, 228);
            this.LblPhnNmbr.Name = "LblPhnNmbr";
            this.LblPhnNmbr.Size = new System.Drawing.Size(107, 36);
            this.LblPhnNmbr.TabIndex = 8;
            this.LblPhnNmbr.Text = "Status:";
            // 
            // LblCntctFN
            // 
            this.LblCntctFN.AutoSize = true;
            this.LblCntctFN.BackColor = System.Drawing.Color.Transparent;
            this.LblCntctFN.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCntctFN.Location = new System.Drawing.Point(18, 176);
            this.LblCntctFN.Name = "LblCntctFN";
            this.LblCntctFN.Size = new System.Drawing.Size(203, 36);
            this.LblCntctFN.TabIndex = 7;
            this.LblCntctFN.Text = "Shipped Date:";
            // 
            // LblCntctLN
            // 
            this.LblCntctLN.AutoSize = true;
            this.LblCntctLN.BackColor = System.Drawing.Color.Transparent;
            this.LblCntctLN.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCntctLN.Location = new System.Drawing.Point(20, 120);
            this.LblCntctLN.Name = "LblCntctLN";
            this.LblCntctLN.Size = new System.Drawing.Size(214, 36);
            this.LblCntctLN.TabIndex = 6;
            this.LblCntctLN.Text = "Required Date:";
            // 
            // LblCstmrNm
            // 
            this.LblCstmrNm.AutoSize = true;
            this.LblCstmrNm.BackColor = System.Drawing.Color.Transparent;
            this.LblCstmrNm.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCstmrNm.Location = new System.Drawing.Point(59, 63);
            this.LblCstmrNm.Name = "LblCstmrNm";
            this.LblCstmrNm.Size = new System.Drawing.Size(167, 36);
            this.LblCstmrNm.TabIndex = 5;
            this.LblCstmrNm.Text = "Order Date:";
            // 
            // LblCstmrNmbr
            // 
            this.LblCstmrNmbr.AutoSize = true;
            this.LblCstmrNmbr.BackColor = System.Drawing.Color.Transparent;
            this.LblCstmrNmbr.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCstmrNmbr.Location = new System.Drawing.Point(29, 15);
            this.LblCstmrNmbr.Name = "LblCstmrNmbr";
            this.LblCstmrNmbr.Size = new System.Drawing.Size(211, 36);
            this.LblCstmrNmbr.TabIndex = 0;
            this.LblCstmrNmbr.Text = "Order Number:";
            // 
            // ViewOrdrs
            // 
            this.ViewOrdrs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ViewOrdrs.Controls.Add(this.DtgrdOrdrs);
            this.ViewOrdrs.Location = new System.Drawing.Point(4, 25);
            this.ViewOrdrs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ViewOrdrs.Name = "ViewOrdrs";
            this.ViewOrdrs.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ViewOrdrs.Size = new System.Drawing.Size(1057, 702);
            this.ViewOrdrs.TabIndex = 1;
            this.ViewOrdrs.Text = "View Orders";
            // 
            // DtgrdOrdrs
            // 
            this.DtgrdOrdrs.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.DtgrdOrdrs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgrdOrdrs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DtgrdOrdrs.Location = new System.Drawing.Point(3, 2);
            this.DtgrdOrdrs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DtgrdOrdrs.Name = "DtgrdOrdrs";
            this.DtgrdOrdrs.RowHeadersWidth = 51;
            this.DtgrdOrdrs.RowTemplate.Height = 24;
            this.DtgrdOrdrs.Size = new System.Drawing.Size(1051, 698);
            this.DtgrdOrdrs.TabIndex = 0;
            // 
            // FrmOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1065, 731);
            this.Controls.Add(this.TbcntrlOrdrs);
            this.Name = "FrmOrders";
            this.Text = "Orders";
            this.TbcntrlOrdrs.ResumeLayout(false);
            this.NewOrdrs.ResumeLayout(false);
            this.NewOrdrs.PerformLayout();
            this.ViewOrdrs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DtgrdOrdrs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TbcntrlOrdrs;
        private System.Windows.Forms.TabPage NewOrdrs;
        private System.Windows.Forms.Button BttnCancel;
        private System.Windows.Forms.Button BttnUpdate;
        private System.Windows.Forms.Button BttnSave;
        private System.Windows.Forms.Button BttnDelete;
        private System.Windows.Forms.Button BttnNew;
        private System.Windows.Forms.ComboBox CmbbxCntry;
        private System.Windows.Forms.TextBox TxtbxAddTwo;
        private System.Windows.Forms.TextBox TxtbxAddOne;
        private System.Windows.Forms.TextBox TxtbxCntctFN;
        private System.Windows.Forms.TextBox TxtbxCntctLN;
        private System.Windows.Forms.TextBox TxtbxCstmrNm;
        private System.Windows.Forms.TextBox TxtbxCstmrNmbr;
        private System.Windows.Forms.Button BttnLast;
        private System.Windows.Forms.Button BttnNext;
        private System.Windows.Forms.Button BttnPrevious;
        private System.Windows.Forms.Button BttnFirst;
        private System.Windows.Forms.Label LblAddTwo;
        private System.Windows.Forms.Label LblAddOne;
        private System.Windows.Forms.Label LblPhnNmbr;
        private System.Windows.Forms.Label LblCntctFN;
        private System.Windows.Forms.Label LblCntctLN;
        private System.Windows.Forms.Label LblCstmrNm;
        private System.Windows.Forms.Label LblCstmrNmbr;
        private System.Windows.Forms.TabPage ViewOrdrs;
        private System.Windows.Forms.DataGridView DtgrdOrdrs;
    }
}