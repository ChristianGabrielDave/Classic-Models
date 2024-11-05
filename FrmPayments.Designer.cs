namespace ClassicModels
{
    partial class FrmPayments
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
            this.TbcntrlPymnts = new System.Windows.Forms.TabControl();
            this.NewPymnts = new System.Windows.Forms.TabPage();
            this.BttnCancel = new System.Windows.Forms.Button();
            this.BttnUpdate = new System.Windows.Forms.Button();
            this.BttnSave = new System.Windows.Forms.Button();
            this.BttnDelete = new System.Windows.Forms.Button();
            this.BttnNew = new System.Windows.Forms.Button();
            this.TxtbxAmnt = new System.Windows.Forms.TextBox();
            this.TxtbxPymntDt = new System.Windows.Forms.TextBox();
            this.TxtbxChckNmbr = new System.Windows.Forms.TextBox();
            this.TxtbxCstmrNmbr = new System.Windows.Forms.TextBox();
            this.BttnLast = new System.Windows.Forms.Button();
            this.BttnNext = new System.Windows.Forms.Button();
            this.BttnPrevious = new System.Windows.Forms.Button();
            this.BttnFirst = new System.Windows.Forms.Button();
            this.LblAmnt = new System.Windows.Forms.Label();
            this.LblPymntDt = new System.Windows.Forms.Label();
            this.LblChckNmbr = new System.Windows.Forms.Label();
            this.LblCstmrNmbr = new System.Windows.Forms.Label();
            this.ViewPymnts = new System.Windows.Forms.TabPage();
            this.DtgrdPymnts = new System.Windows.Forms.DataGridView();
            this.TbcntrlPymnts.SuspendLayout();
            this.NewPymnts.SuspendLayout();
            this.ViewPymnts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtgrdPymnts)).BeginInit();
            this.SuspendLayout();
            // 
            // TbcntrlPymnts
            // 
            this.TbcntrlPymnts.Controls.Add(this.NewPymnts);
            this.TbcntrlPymnts.Controls.Add(this.ViewPymnts);
            this.TbcntrlPymnts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TbcntrlPymnts.Location = new System.Drawing.Point(0, 0);
            this.TbcntrlPymnts.Margin = new System.Windows.Forms.Padding(2);
            this.TbcntrlPymnts.Name = "TbcntrlPymnts";
            this.TbcntrlPymnts.SelectedIndex = 0;
            this.TbcntrlPymnts.Size = new System.Drawing.Size(807, 274);
            this.TbcntrlPymnts.TabIndex = 1;
            // 
            // NewPymnts
            // 
            this.NewPymnts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.NewPymnts.Controls.Add(this.BttnCancel);
            this.NewPymnts.Controls.Add(this.BttnUpdate);
            this.NewPymnts.Controls.Add(this.BttnSave);
            this.NewPymnts.Controls.Add(this.BttnDelete);
            this.NewPymnts.Controls.Add(this.BttnNew);
            this.NewPymnts.Controls.Add(this.TxtbxAmnt);
            this.NewPymnts.Controls.Add(this.TxtbxPymntDt);
            this.NewPymnts.Controls.Add(this.TxtbxChckNmbr);
            this.NewPymnts.Controls.Add(this.TxtbxCstmrNmbr);
            this.NewPymnts.Controls.Add(this.BttnLast);
            this.NewPymnts.Controls.Add(this.BttnNext);
            this.NewPymnts.Controls.Add(this.BttnPrevious);
            this.NewPymnts.Controls.Add(this.BttnFirst);
            this.NewPymnts.Controls.Add(this.LblAmnt);
            this.NewPymnts.Controls.Add(this.LblPymntDt);
            this.NewPymnts.Controls.Add(this.LblChckNmbr);
            this.NewPymnts.Controls.Add(this.LblCstmrNmbr);
            this.NewPymnts.Location = new System.Drawing.Point(4, 22);
            this.NewPymnts.Margin = new System.Windows.Forms.Padding(2);
            this.NewPymnts.Name = "NewPymnts";
            this.NewPymnts.Padding = new System.Windows.Forms.Padding(2);
            this.NewPymnts.Size = new System.Drawing.Size(799, 248);
            this.NewPymnts.TabIndex = 0;
            this.NewPymnts.Text = "New Payment";
            // 
            // BttnCancel
            // 
            this.BttnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BttnCancel.Location = new System.Drawing.Point(692, 61);
            this.BttnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.BttnCancel.Name = "BttnCancel";
            this.BttnCancel.Size = new System.Drawing.Size(92, 33);
            this.BttnCancel.TabIndex = 37;
            this.BttnCancel.Text = "Cancel";
            this.BttnCancel.UseVisualStyleBackColor = true;
            // 
            // BttnUpdate
            // 
            this.BttnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BttnUpdate.Location = new System.Drawing.Point(627, 98);
            this.BttnUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.BttnUpdate.Name = "BttnUpdate";
            this.BttnUpdate.Size = new System.Drawing.Size(92, 33);
            this.BttnUpdate.TabIndex = 36;
            this.BttnUpdate.Text = "Update";
            this.BttnUpdate.UseVisualStyleBackColor = true;
            // 
            // BttnSave
            // 
            this.BttnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BttnSave.Location = new System.Drawing.Point(567, 61);
            this.BttnSave.Margin = new System.Windows.Forms.Padding(2);
            this.BttnSave.Name = "BttnSave";
            this.BttnSave.Size = new System.Drawing.Size(92, 33);
            this.BttnSave.TabIndex = 35;
            this.BttnSave.Text = "Save";
            this.BttnSave.UseVisualStyleBackColor = true;
            // 
            // BttnDelete
            // 
            this.BttnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BttnDelete.Location = new System.Drawing.Point(692, 12);
            this.BttnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.BttnDelete.Name = "BttnDelete";
            this.BttnDelete.Size = new System.Drawing.Size(92, 33);
            this.BttnDelete.TabIndex = 34;
            this.BttnDelete.Text = "Delete";
            this.BttnDelete.UseVisualStyleBackColor = true;
            // 
            // BttnNew
            // 
            this.BttnNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BttnNew.Location = new System.Drawing.Point(567, 12);
            this.BttnNew.Margin = new System.Windows.Forms.Padding(2);
            this.BttnNew.Name = "BttnNew";
            this.BttnNew.Size = new System.Drawing.Size(92, 33);
            this.BttnNew.TabIndex = 33;
            this.BttnNew.Text = "New";
            this.BttnNew.UseVisualStyleBackColor = true;
            this.BttnNew.Click += new System.EventHandler(this.BttnNew_Click);
            // 
            // TxtbxAmnt
            // 
            this.TxtbxAmnt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtbxAmnt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtbxAmnt.Location = new System.Drawing.Point(264, 140);
            this.TxtbxAmnt.Margin = new System.Windows.Forms.Padding(2);
            this.TxtbxAmnt.Name = "TxtbxAmnt";
            this.TxtbxAmnt.Size = new System.Drawing.Size(520, 32);
            this.TxtbxAmnt.TabIndex = 20;
            // 
            // TxtbxPymntDt
            // 
            this.TxtbxPymntDt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtbxPymntDt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtbxPymntDt.Location = new System.Drawing.Point(264, 95);
            this.TxtbxPymntDt.Margin = new System.Windows.Forms.Padding(2);
            this.TxtbxPymntDt.Name = "TxtbxPymntDt";
            this.TxtbxPymntDt.Size = new System.Drawing.Size(299, 32);
            this.TxtbxPymntDt.TabIndex = 19;
            // 
            // TxtbxChckNmbr
            // 
            this.TxtbxChckNmbr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtbxChckNmbr.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtbxChckNmbr.Location = new System.Drawing.Point(264, 51);
            this.TxtbxChckNmbr.Margin = new System.Windows.Forms.Padding(2);
            this.TxtbxChckNmbr.Name = "TxtbxChckNmbr";
            this.TxtbxChckNmbr.Size = new System.Drawing.Size(299, 32);
            this.TxtbxChckNmbr.TabIndex = 18;
            // 
            // TxtbxCstmrNmbr
            // 
            this.TxtbxCstmrNmbr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtbxCstmrNmbr.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtbxCstmrNmbr.Location = new System.Drawing.Point(264, 11);
            this.TxtbxCstmrNmbr.Margin = new System.Windows.Forms.Padding(2);
            this.TxtbxCstmrNmbr.Name = "TxtbxCstmrNmbr";
            this.TxtbxCstmrNmbr.Size = new System.Drawing.Size(299, 32);
            this.TxtbxCstmrNmbr.TabIndex = 16;
            // 
            // BttnLast
            // 
            this.BttnLast.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BttnLast.Location = new System.Drawing.Point(685, 190);
            this.BttnLast.Margin = new System.Windows.Forms.Padding(2);
            this.BttnLast.Name = "BttnLast";
            this.BttnLast.Size = new System.Drawing.Size(99, 33);
            this.BttnLast.TabIndex = 15;
            this.BttnLast.Text = "Last";
            this.BttnLast.UseVisualStyleBackColor = true;
            // 
            // BttnNext
            // 
            this.BttnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BttnNext.Location = new System.Drawing.Point(404, 190);
            this.BttnNext.Margin = new System.Windows.Forms.Padding(2);
            this.BttnNext.Name = "BttnNext";
            this.BttnNext.Size = new System.Drawing.Size(99, 33);
            this.BttnNext.TabIndex = 14;
            this.BttnNext.Text = "Next";
            this.BttnNext.UseVisualStyleBackColor = true;
            // 
            // BttnPrevious
            // 
            this.BttnPrevious.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BttnPrevious.Location = new System.Drawing.Point(542, 190);
            this.BttnPrevious.Margin = new System.Windows.Forms.Padding(2);
            this.BttnPrevious.Name = "BttnPrevious";
            this.BttnPrevious.Size = new System.Drawing.Size(99, 33);
            this.BttnPrevious.TabIndex = 14;
            this.BttnPrevious.Text = "Previous";
            this.BttnPrevious.UseVisualStyleBackColor = true;
            // 
            // BttnFirst
            // 
            this.BttnFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BttnFirst.Location = new System.Drawing.Point(264, 190);
            this.BttnFirst.Margin = new System.Windows.Forms.Padding(2);
            this.BttnFirst.Name = "BttnFirst";
            this.BttnFirst.Size = new System.Drawing.Size(99, 33);
            this.BttnFirst.TabIndex = 13;
            this.BttnFirst.Text = "First";
            this.BttnFirst.UseVisualStyleBackColor = true;
            // 
            // LblAmnt
            // 
            this.LblAmnt.AutoSize = true;
            this.LblAmnt.BackColor = System.Drawing.Color.Transparent;
            this.LblAmnt.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAmnt.Location = new System.Drawing.Point(146, 143);
            this.LblAmnt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblAmnt.Name = "LblAmnt";
            this.LblAmnt.Size = new System.Drawing.Size(100, 29);
            this.LblAmnt.TabIndex = 7;
            this.LblAmnt.Text = "Amount:";
            // 
            // LblPymntDt
            // 
            this.LblPymntDt.AutoSize = true;
            this.LblPymntDt.BackColor = System.Drawing.Color.Transparent;
            this.LblPymntDt.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPymntDt.Location = new System.Drawing.Point(78, 98);
            this.LblPymntDt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblPymntDt.Name = "LblPymntDt";
            this.LblPymntDt.Size = new System.Drawing.Size(168, 29);
            this.LblPymntDt.TabIndex = 6;
            this.LblPymntDt.Text = "Payment Date:";
            // 
            // LblChckNmbr
            // 
            this.LblChckNmbr.AutoSize = true;
            this.LblChckNmbr.BackColor = System.Drawing.Color.Transparent;
            this.LblChckNmbr.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblChckNmbr.Location = new System.Drawing.Point(66, 54);
            this.LblChckNmbr.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblChckNmbr.Name = "LblChckNmbr";
            this.LblChckNmbr.Size = new System.Drawing.Size(180, 29);
            this.LblChckNmbr.TabIndex = 5;
            this.LblChckNmbr.Text = "Check Number:";
            // 
            // LblCstmrNmbr
            // 
            this.LblCstmrNmbr.AutoSize = true;
            this.LblCstmrNmbr.BackColor = System.Drawing.Color.Transparent;
            this.LblCstmrNmbr.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCstmrNmbr.Location = new System.Drawing.Point(30, 16);
            this.LblCstmrNmbr.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblCstmrNmbr.Name = "LblCstmrNmbr";
            this.LblCstmrNmbr.Size = new System.Drawing.Size(216, 29);
            this.LblCstmrNmbr.TabIndex = 0;
            this.LblCstmrNmbr.Text = "Customer Number:";
            // 
            // ViewPymnts
            // 
            this.ViewPymnts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ViewPymnts.Controls.Add(this.DtgrdPymnts);
            this.ViewPymnts.Location = new System.Drawing.Point(4, 22);
            this.ViewPymnts.Margin = new System.Windows.Forms.Padding(2);
            this.ViewPymnts.Name = "ViewPymnts";
            this.ViewPymnts.Padding = new System.Windows.Forms.Padding(2);
            this.ViewPymnts.Size = new System.Drawing.Size(799, 248);
            this.ViewPymnts.TabIndex = 1;
            this.ViewPymnts.Text = "View Payments";
            // 
            // DtgrdPymnts
            // 
            this.DtgrdPymnts.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.DtgrdPymnts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgrdPymnts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DtgrdPymnts.Location = new System.Drawing.Point(2, 2);
            this.DtgrdPymnts.Margin = new System.Windows.Forms.Padding(2);
            this.DtgrdPymnts.Name = "DtgrdPymnts";
            this.DtgrdPymnts.RowHeadersWidth = 51;
            this.DtgrdPymnts.RowTemplate.Height = 24;
            this.DtgrdPymnts.Size = new System.Drawing.Size(795, 244);
            this.DtgrdPymnts.TabIndex = 0;
            this.DtgrdPymnts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtgrdPymnts_CellContentClick);
            // 
            // FrmPayments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(807, 274);
            this.Controls.Add(this.TbcntrlPymnts);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmPayments";
            this.Text = "Payments";
            this.Load += new System.EventHandler(this.FrmPayments_Load);
            this.TbcntrlPymnts.ResumeLayout(false);
            this.NewPymnts.ResumeLayout(false);
            this.NewPymnts.PerformLayout();
            this.ViewPymnts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DtgrdPymnts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TbcntrlPymnts;
        private System.Windows.Forms.TabPage NewPymnts;
        private System.Windows.Forms.Button BttnCancel;
        private System.Windows.Forms.Button BttnUpdate;
        private System.Windows.Forms.Button BttnSave;
        private System.Windows.Forms.Button BttnDelete;
        private System.Windows.Forms.Button BttnNew;
        private System.Windows.Forms.TextBox TxtbxAmnt;
        private System.Windows.Forms.TextBox TxtbxPymntDt;
        private System.Windows.Forms.TextBox TxtbxChckNmbr;
        private System.Windows.Forms.TextBox TxtbxCstmrNmbr;
        private System.Windows.Forms.Button BttnLast;
        private System.Windows.Forms.Button BttnNext;
        private System.Windows.Forms.Button BttnPrevious;
        private System.Windows.Forms.Button BttnFirst;
        private System.Windows.Forms.Label LblAmnt;
        private System.Windows.Forms.Label LblPymntDt;
        private System.Windows.Forms.Label LblChckNmbr;
        private System.Windows.Forms.Label LblCstmrNmbr;
        private System.Windows.Forms.TabPage ViewPymnts;
        private System.Windows.Forms.DataGridView DtgrdPymnts;
    }
}