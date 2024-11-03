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
            this.CmbbxStts = new System.Windows.Forms.ComboBox();
            this.TxtbxCstmrNmbr = new System.Windows.Forms.TextBox();
            this.TxtbxCmmnts = new System.Windows.Forms.TextBox();
            this.TxtbxShppDt = new System.Windows.Forms.TextBox();
            this.TxtbxRqrdDt = new System.Windows.Forms.TextBox();
            this.TxtbxOrdrDt = new System.Windows.Forms.TextBox();
            this.TxtbxOrdrNmbr = new System.Windows.Forms.TextBox();
            this.BttnLast = new System.Windows.Forms.Button();
            this.BttnNext = new System.Windows.Forms.Button();
            this.BttnPrevious = new System.Windows.Forms.Button();
            this.BttnFirst = new System.Windows.Forms.Button();
            this.LblCstmrNmbr = new System.Windows.Forms.Label();
            this.LblCmmnts = new System.Windows.Forms.Label();
            this.LblStts = new System.Windows.Forms.Label();
            this.LblShppDt = new System.Windows.Forms.Label();
            this.LblRqrdDt = new System.Windows.Forms.Label();
            this.LblOrdrDt = new System.Windows.Forms.Label();
            this.LblOrdrNmbr = new System.Windows.Forms.Label();
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
            this.TbcntrlOrdrs.Margin = new System.Windows.Forms.Padding(2);
            this.TbcntrlOrdrs.Name = "TbcntrlOrdrs";
            this.TbcntrlOrdrs.SelectedIndex = 0;
            this.TbcntrlOrdrs.Size = new System.Drawing.Size(780, 378);
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
            this.NewOrdrs.Controls.Add(this.CmbbxStts);
            this.NewOrdrs.Controls.Add(this.TxtbxCstmrNmbr);
            this.NewOrdrs.Controls.Add(this.TxtbxCmmnts);
            this.NewOrdrs.Controls.Add(this.TxtbxShppDt);
            this.NewOrdrs.Controls.Add(this.TxtbxRqrdDt);
            this.NewOrdrs.Controls.Add(this.TxtbxOrdrDt);
            this.NewOrdrs.Controls.Add(this.TxtbxOrdrNmbr);
            this.NewOrdrs.Controls.Add(this.BttnLast);
            this.NewOrdrs.Controls.Add(this.BttnNext);
            this.NewOrdrs.Controls.Add(this.BttnPrevious);
            this.NewOrdrs.Controls.Add(this.BttnFirst);
            this.NewOrdrs.Controls.Add(this.LblCstmrNmbr);
            this.NewOrdrs.Controls.Add(this.LblCmmnts);
            this.NewOrdrs.Controls.Add(this.LblStts);
            this.NewOrdrs.Controls.Add(this.LblShppDt);
            this.NewOrdrs.Controls.Add(this.LblRqrdDt);
            this.NewOrdrs.Controls.Add(this.LblOrdrDt);
            this.NewOrdrs.Controls.Add(this.LblOrdrNmbr);
            this.NewOrdrs.Location = new System.Drawing.Point(4, 22);
            this.NewOrdrs.Margin = new System.Windows.Forms.Padding(2);
            this.NewOrdrs.Name = "NewOrdrs";
            this.NewOrdrs.Padding = new System.Windows.Forms.Padding(2);
            this.NewOrdrs.Size = new System.Drawing.Size(772, 352);
            this.NewOrdrs.TabIndex = 0;
            this.NewOrdrs.Text = "New Order";
            // 
            // BttnCancel
            // 
            this.BttnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BttnCancel.Location = new System.Drawing.Point(576, 97);
            this.BttnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.BttnCancel.Name = "BttnCancel";
            this.BttnCancel.Size = new System.Drawing.Size(110, 33);
            this.BttnCancel.TabIndex = 37;
            this.BttnCancel.Text = "Cancel";
            this.BttnCancel.UseVisualStyleBackColor = true;
            // 
            // BttnUpdate
            // 
            this.BttnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BttnUpdate.Location = new System.Drawing.Point(652, 59);
            this.BttnUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.BttnUpdate.Name = "BttnUpdate";
            this.BttnUpdate.Size = new System.Drawing.Size(110, 33);
            this.BttnUpdate.TabIndex = 36;
            this.BttnUpdate.Text = "Update";
            this.BttnUpdate.UseVisualStyleBackColor = true;
            // 
            // BttnSave
            // 
            this.BttnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BttnSave.Location = new System.Drawing.Point(497, 59);
            this.BttnSave.Margin = new System.Windows.Forms.Padding(2);
            this.BttnSave.Name = "BttnSave";
            this.BttnSave.Size = new System.Drawing.Size(110, 33);
            this.BttnSave.TabIndex = 35;
            this.BttnSave.Text = "Save";
            this.BttnSave.UseVisualStyleBackColor = true;
            // 
            // BttnDelete
            // 
            this.BttnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BttnDelete.Location = new System.Drawing.Point(652, 14);
            this.BttnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.BttnDelete.Name = "BttnDelete";
            this.BttnDelete.Size = new System.Drawing.Size(110, 33);
            this.BttnDelete.TabIndex = 34;
            this.BttnDelete.Text = "Delete";
            this.BttnDelete.UseVisualStyleBackColor = true;
            // 
            // BttnNew
            // 
            this.BttnNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BttnNew.Location = new System.Drawing.Point(497, 14);
            this.BttnNew.Margin = new System.Windows.Forms.Padding(2);
            this.BttnNew.Name = "BttnNew";
            this.BttnNew.Size = new System.Drawing.Size(110, 33);
            this.BttnNew.TabIndex = 33;
            this.BttnNew.Text = "New";
            this.BttnNew.UseVisualStyleBackColor = true;
            // 
            // CmbbxStts
            // 
            this.CmbbxStts.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbbxStts.FormattingEnabled = true;
            this.CmbbxStts.Location = new System.Drawing.Point(232, 199);
            this.CmbbxStts.Margin = new System.Windows.Forms.Padding(2);
            this.CmbbxStts.Name = "CmbbxStts";
            this.CmbbxStts.Size = new System.Drawing.Size(530, 34);
            this.CmbbxStts.TabIndex = 29;
            // 
            // TxtbxCstmrNmbr
            // 
            this.TxtbxCstmrNmbr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtbxCstmrNmbr.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtbxCstmrNmbr.Location = new System.Drawing.Point(232, 62);
            this.TxtbxCstmrNmbr.Margin = new System.Windows.Forms.Padding(2);
            this.TxtbxCstmrNmbr.Name = "TxtbxCstmrNmbr";
            this.TxtbxCstmrNmbr.Size = new System.Drawing.Size(199, 32);
            this.TxtbxCstmrNmbr.TabIndex = 23;
            // 
            // TxtbxCmmnts
            // 
            this.TxtbxCmmnts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtbxCmmnts.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtbxCmmnts.Location = new System.Drawing.Point(232, 247);
            this.TxtbxCmmnts.Margin = new System.Windows.Forms.Padding(2);
            this.TxtbxCmmnts.Name = "TxtbxCmmnts";
            this.TxtbxCmmnts.Size = new System.Drawing.Size(530, 32);
            this.TxtbxCmmnts.TabIndex = 22;
            // 
            // TxtbxShppDt
            // 
            this.TxtbxShppDt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtbxShppDt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtbxShppDt.Location = new System.Drawing.Point(232, 152);
            this.TxtbxShppDt.Margin = new System.Windows.Forms.Padding(2);
            this.TxtbxShppDt.Name = "TxtbxShppDt";
            this.TxtbxShppDt.Size = new System.Drawing.Size(199, 32);
            this.TxtbxShppDt.TabIndex = 20;
            // 
            // TxtbxRqrdDt
            // 
            this.TxtbxRqrdDt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtbxRqrdDt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtbxRqrdDt.Location = new System.Drawing.Point(614, 155);
            this.TxtbxRqrdDt.Margin = new System.Windows.Forms.Padding(2);
            this.TxtbxRqrdDt.Name = "TxtbxRqrdDt";
            this.TxtbxRqrdDt.Size = new System.Drawing.Size(148, 32);
            this.TxtbxRqrdDt.TabIndex = 19;
            // 
            // TxtbxOrdrDt
            // 
            this.TxtbxOrdrDt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtbxOrdrDt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtbxOrdrDt.Location = new System.Drawing.Point(232, 107);
            this.TxtbxOrdrDt.Margin = new System.Windows.Forms.Padding(2);
            this.TxtbxOrdrDt.Name = "TxtbxOrdrDt";
            this.TxtbxOrdrDt.Size = new System.Drawing.Size(199, 32);
            this.TxtbxOrdrDt.TabIndex = 18;
            // 
            // TxtbxOrdrNmbr
            // 
            this.TxtbxOrdrNmbr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtbxOrdrNmbr.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtbxOrdrNmbr.Location = new System.Drawing.Point(232, 15);
            this.TxtbxOrdrNmbr.Margin = new System.Windows.Forms.Padding(2);
            this.TxtbxOrdrNmbr.Name = "TxtbxOrdrNmbr";
            this.TxtbxOrdrNmbr.Size = new System.Drawing.Size(199, 32);
            this.TxtbxOrdrNmbr.TabIndex = 16;
            // 
            // BttnLast
            // 
            this.BttnLast.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BttnLast.Location = new System.Drawing.Point(663, 294);
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
            this.BttnNext.Location = new System.Drawing.Point(379, 294);
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
            this.BttnPrevious.Location = new System.Drawing.Point(523, 294);
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
            this.BttnFirst.Location = new System.Drawing.Point(232, 294);
            this.BttnFirst.Margin = new System.Windows.Forms.Padding(2);
            this.BttnFirst.Name = "BttnFirst";
            this.BttnFirst.Size = new System.Drawing.Size(99, 33);
            this.BttnFirst.TabIndex = 13;
            this.BttnFirst.Text = "First";
            this.BttnFirst.UseVisualStyleBackColor = true;
            // 
            // LblCstmrNmbr
            // 
            this.LblCstmrNmbr.AutoSize = true;
            this.LblCstmrNmbr.BackColor = System.Drawing.Color.Transparent;
            this.LblCstmrNmbr.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCstmrNmbr.Location = new System.Drawing.Point(12, 65);
            this.LblCstmrNmbr.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblCstmrNmbr.Name = "LblCstmrNmbr";
            this.LblCstmrNmbr.Size = new System.Drawing.Size(216, 29);
            this.LblCstmrNmbr.TabIndex = 10;
            this.LblCstmrNmbr.Text = "Customer Number:";
            // 
            // LblCmmnts
            // 
            this.LblCmmnts.AutoSize = true;
            this.LblCmmnts.BackColor = System.Drawing.Color.Transparent;
            this.LblCmmnts.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCmmnts.Location = new System.Drawing.Point(93, 250);
            this.LblCmmnts.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblCmmnts.Name = "LblCmmnts";
            this.LblCmmnts.Size = new System.Drawing.Size(135, 29);
            this.LblCmmnts.TabIndex = 9;
            this.LblCmmnts.Text = "Comments:";
            // 
            // LblStts
            // 
            this.LblStts.AutoSize = true;
            this.LblStts.BackColor = System.Drawing.Color.Transparent;
            this.LblStts.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblStts.Location = new System.Drawing.Point(143, 204);
            this.LblStts.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblStts.Name = "LblStts";
            this.LblStts.Size = new System.Drawing.Size(85, 29);
            this.LblStts.TabIndex = 8;
            this.LblStts.Text = "Status:";
            // 
            // LblShppDt
            // 
            this.LblShppDt.AutoSize = true;
            this.LblShppDt.BackColor = System.Drawing.Color.Transparent;
            this.LblShppDt.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblShppDt.Location = new System.Drawing.Point(62, 155);
            this.LblShppDt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblShppDt.Name = "LblShppDt";
            this.LblShppDt.Size = new System.Drawing.Size(166, 29);
            this.LblShppDt.TabIndex = 7;
            this.LblShppDt.Text = "Shipped Date:";
            // 
            // LblRqrdDt
            // 
            this.LblRqrdDt.AutoSize = true;
            this.LblRqrdDt.BackColor = System.Drawing.Color.Transparent;
            this.LblRqrdDt.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRqrdDt.Location = new System.Drawing.Point(435, 155);
            this.LblRqrdDt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblRqrdDt.Name = "LblRqrdDt";
            this.LblRqrdDt.Size = new System.Drawing.Size(175, 29);
            this.LblRqrdDt.TabIndex = 6;
            this.LblRqrdDt.Text = "Required Date:";
            // 
            // LblOrdrDt
            // 
            this.LblOrdrDt.AutoSize = true;
            this.LblOrdrDt.BackColor = System.Drawing.Color.Transparent;
            this.LblOrdrDt.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblOrdrDt.Location = new System.Drawing.Point(90, 110);
            this.LblOrdrDt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblOrdrDt.Name = "LblOrdrDt";
            this.LblOrdrDt.Size = new System.Drawing.Size(138, 29);
            this.LblOrdrDt.TabIndex = 5;
            this.LblOrdrDt.Text = "Order Date:";
            // 
            // LblOrdrNmbr
            // 
            this.LblOrdrNmbr.AutoSize = true;
            this.LblOrdrNmbr.BackColor = System.Drawing.Color.Transparent;
            this.LblOrdrNmbr.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblOrdrNmbr.Location = new System.Drawing.Point(53, 18);
            this.LblOrdrNmbr.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblOrdrNmbr.Name = "LblOrdrNmbr";
            this.LblOrdrNmbr.Size = new System.Drawing.Size(175, 29);
            this.LblOrdrNmbr.TabIndex = 0;
            this.LblOrdrNmbr.Text = "Order Number:";
            // 
            // ViewOrdrs
            // 
            this.ViewOrdrs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ViewOrdrs.Controls.Add(this.DtgrdOrdrs);
            this.ViewOrdrs.Location = new System.Drawing.Point(4, 22);
            this.ViewOrdrs.Margin = new System.Windows.Forms.Padding(2);
            this.ViewOrdrs.Name = "ViewOrdrs";
            this.ViewOrdrs.Padding = new System.Windows.Forms.Padding(2);
            this.ViewOrdrs.Size = new System.Drawing.Size(772, 352);
            this.ViewOrdrs.TabIndex = 1;
            this.ViewOrdrs.Text = "View Orders";
            // 
            // DtgrdOrdrs
            // 
            this.DtgrdOrdrs.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.DtgrdOrdrs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgrdOrdrs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DtgrdOrdrs.Location = new System.Drawing.Point(2, 2);
            this.DtgrdOrdrs.Margin = new System.Windows.Forms.Padding(2);
            this.DtgrdOrdrs.Name = "DtgrdOrdrs";
            this.DtgrdOrdrs.RowHeadersWidth = 51;
            this.DtgrdOrdrs.RowTemplate.Height = 24;
            this.DtgrdOrdrs.Size = new System.Drawing.Size(768, 348);
            this.DtgrdOrdrs.TabIndex = 0;
            // 
            // FrmOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(780, 378);
            this.Controls.Add(this.TbcntrlOrdrs);
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private System.Windows.Forms.ComboBox CmbbxStts;
        private System.Windows.Forms.TextBox TxtbxCstmrNmbr;
        private System.Windows.Forms.TextBox TxtbxCmmnts;
        private System.Windows.Forms.TextBox TxtbxShppDt;
        private System.Windows.Forms.TextBox TxtbxRqrdDt;
        private System.Windows.Forms.TextBox TxtbxOrdrDt;
        private System.Windows.Forms.TextBox TxtbxOrdrNmbr;
        private System.Windows.Forms.Button BttnLast;
        private System.Windows.Forms.Button BttnNext;
        private System.Windows.Forms.Button BttnPrevious;
        private System.Windows.Forms.Button BttnFirst;
        private System.Windows.Forms.Label LblCstmrNmbr;
        private System.Windows.Forms.Label LblCmmnts;
        private System.Windows.Forms.Label LblStts;
        private System.Windows.Forms.Label LblShppDt;
        private System.Windows.Forms.Label LblRqrdDt;
        private System.Windows.Forms.Label LblOrdrDt;
        private System.Windows.Forms.Label LblOrdrNmbr;
        private System.Windows.Forms.TabPage ViewOrdrs;
        private System.Windows.Forms.DataGridView DtgrdOrdrs;
    }
}