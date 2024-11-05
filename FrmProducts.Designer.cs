namespace ClassicModels
{
    partial class FrmProducts
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
            this.TbcntrlPrdcts = new System.Windows.Forms.TabControl();
            this.NewPrdcts = new System.Windows.Forms.TabPage();
            this.BttnCancel = new System.Windows.Forms.Button();
            this.BttnUpdate = new System.Windows.Forms.Button();
            this.BttnSave = new System.Windows.Forms.Button();
            this.BttnDelete = new System.Windows.Forms.Button();
            this.BttnNew = new System.Windows.Forms.Button();
            this.BttnLast = new System.Windows.Forms.Button();
            this.BttnNext = new System.Windows.Forms.Button();
            this.BttnPrevious = new System.Windows.Forms.Button();
            this.BttnFirst = new System.Windows.Forms.Button();
            this.TxtbxPrdctDesc = new System.Windows.Forms.TextBox();
            this.TxtbxMSRP = new System.Windows.Forms.TextBox();
            this.TxtbxBuyPrc = new System.Windows.Forms.TextBox();
            this.TxtbxPrdctCd = new System.Windows.Forms.TextBox();
            this.TxtbxPrdctLn = new System.Windows.Forms.TextBox();
            this.TxtbxPrdctScl = new System.Windows.Forms.TextBox();
            this.TxtbxPrdctNm = new System.Windows.Forms.TextBox();
            this.TxtbxPrdctVndr = new System.Windows.Forms.TextBox();
            this.LblPrdctNm = new System.Windows.Forms.Label();
            this.LblPrdctLn = new System.Windows.Forms.Label();
            this.LblPrdctScl = new System.Windows.Forms.Label();
            this.LblPrdctVndr = new System.Windows.Forms.Label();
            this.LblPrdctDesc = new System.Windows.Forms.Label();
            this.LblQntStck = new System.Windows.Forms.Label();
            this.LblBuyPrc = new System.Windows.Forms.Label();
            this.LblMSRP = new System.Windows.Forms.Label();
            this.TxtbxQntStck = new System.Windows.Forms.TextBox();
            this.LblPrdctCd = new System.Windows.Forms.Label();
            this.ViewPrdcts = new System.Windows.Forms.TabPage();
            this.DtgrdPrdcts = new System.Windows.Forms.DataGridView();
            this.TbcntrlPrdcts.SuspendLayout();
            this.NewPrdcts.SuspendLayout();
            this.ViewPrdcts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtgrdPrdcts)).BeginInit();
            this.SuspendLayout();
            // 
            // TbcntrlPrdcts
            // 
            this.TbcntrlPrdcts.Controls.Add(this.NewPrdcts);
            this.TbcntrlPrdcts.Controls.Add(this.ViewPrdcts);
            this.TbcntrlPrdcts.Location = new System.Drawing.Point(-2, -2);
            this.TbcntrlPrdcts.Margin = new System.Windows.Forms.Padding(2);
            this.TbcntrlPrdcts.Name = "TbcntrlPrdcts";
            this.TbcntrlPrdcts.SelectedIndex = 0;
            this.TbcntrlPrdcts.Size = new System.Drawing.Size(803, 600);
            this.TbcntrlPrdcts.TabIndex = 0;
            // 
            // NewPrdcts
            // 
            this.NewPrdcts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.NewPrdcts.Controls.Add(this.BttnCancel);
            this.NewPrdcts.Controls.Add(this.BttnUpdate);
            this.NewPrdcts.Controls.Add(this.BttnSave);
            this.NewPrdcts.Controls.Add(this.BttnDelete);
            this.NewPrdcts.Controls.Add(this.BttnNew);
            this.NewPrdcts.Controls.Add(this.BttnLast);
            this.NewPrdcts.Controls.Add(this.BttnNext);
            this.NewPrdcts.Controls.Add(this.BttnPrevious);
            this.NewPrdcts.Controls.Add(this.BttnFirst);
            this.NewPrdcts.Controls.Add(this.TxtbxPrdctDesc);
            this.NewPrdcts.Controls.Add(this.TxtbxMSRP);
            this.NewPrdcts.Controls.Add(this.TxtbxBuyPrc);
            this.NewPrdcts.Controls.Add(this.TxtbxPrdctCd);
            this.NewPrdcts.Controls.Add(this.TxtbxPrdctLn);
            this.NewPrdcts.Controls.Add(this.TxtbxPrdctScl);
            this.NewPrdcts.Controls.Add(this.TxtbxPrdctNm);
            this.NewPrdcts.Controls.Add(this.TxtbxPrdctVndr);
            this.NewPrdcts.Controls.Add(this.LblPrdctNm);
            this.NewPrdcts.Controls.Add(this.LblPrdctLn);
            this.NewPrdcts.Controls.Add(this.LblPrdctScl);
            this.NewPrdcts.Controls.Add(this.LblPrdctVndr);
            this.NewPrdcts.Controls.Add(this.LblPrdctDesc);
            this.NewPrdcts.Controls.Add(this.LblQntStck);
            this.NewPrdcts.Controls.Add(this.LblBuyPrc);
            this.NewPrdcts.Controls.Add(this.LblMSRP);
            this.NewPrdcts.Controls.Add(this.TxtbxQntStck);
            this.NewPrdcts.Controls.Add(this.LblPrdctCd);
            this.NewPrdcts.Location = new System.Drawing.Point(4, 22);
            this.NewPrdcts.Margin = new System.Windows.Forms.Padding(2);
            this.NewPrdcts.Name = "NewPrdcts";
            this.NewPrdcts.Padding = new System.Windows.Forms.Padding(2);
            this.NewPrdcts.Size = new System.Drawing.Size(795, 574);
            this.NewPrdcts.TabIndex = 0;
            this.NewPrdcts.Text = "New Product";
            // 
            // BttnCancel
            // 
            this.BttnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BttnCancel.Location = new System.Drawing.Point(568, 123);
            this.BttnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.BttnCancel.Name = "BttnCancel";
            this.BttnCancel.Size = new System.Drawing.Size(130, 33);
            this.BttnCancel.TabIndex = 42;
            this.BttnCancel.Text = "Cancel";
            this.BttnCancel.UseVisualStyleBackColor = true;
            // 
            // BttnUpdate
            // 
            this.BttnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BttnUpdate.Location = new System.Drawing.Point(644, 74);
            this.BttnUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.BttnUpdate.Name = "BttnUpdate";
            this.BttnUpdate.Size = new System.Drawing.Size(130, 33);
            this.BttnUpdate.TabIndex = 41;
            this.BttnUpdate.Text = "Update";
            this.BttnUpdate.UseVisualStyleBackColor = true;
            // 
            // BttnSave
            // 
            this.BttnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BttnSave.Location = new System.Drawing.Point(491, 74);
            this.BttnSave.Margin = new System.Windows.Forms.Padding(2);
            this.BttnSave.Name = "BttnSave";
            this.BttnSave.Size = new System.Drawing.Size(130, 33);
            this.BttnSave.TabIndex = 40;
            this.BttnSave.Text = "Save";
            this.BttnSave.UseVisualStyleBackColor = true;
            // 
            // BttnDelete
            // 
            this.BttnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BttnDelete.Location = new System.Drawing.Point(644, 29);
            this.BttnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.BttnDelete.Name = "BttnDelete";
            this.BttnDelete.Size = new System.Drawing.Size(130, 33);
            this.BttnDelete.TabIndex = 39;
            this.BttnDelete.Text = "Delete";
            this.BttnDelete.UseVisualStyleBackColor = true;
            // 
            // BttnNew
            // 
            this.BttnNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BttnNew.Location = new System.Drawing.Point(491, 29);
            this.BttnNew.Margin = new System.Windows.Forms.Padding(2);
            this.BttnNew.Name = "BttnNew";
            this.BttnNew.Size = new System.Drawing.Size(130, 33);
            this.BttnNew.TabIndex = 38;
            this.BttnNew.Text = "New";
            this.BttnNew.UseVisualStyleBackColor = true;
            // 
            // BttnLast
            // 
            this.BttnLast.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BttnLast.Location = new System.Drawing.Point(675, 511);
            this.BttnLast.Margin = new System.Windows.Forms.Padding(2);
            this.BttnLast.Name = "BttnLast";
            this.BttnLast.Size = new System.Drawing.Size(98, 33);
            this.BttnLast.TabIndex = 37;
            this.BttnLast.Text = "Last";
            this.BttnLast.UseVisualStyleBackColor = true;
            // 
            // BttnNext
            // 
            this.BttnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BttnNext.Location = new System.Drawing.Point(391, 511);
            this.BttnNext.Margin = new System.Windows.Forms.Padding(2);
            this.BttnNext.Name = "BttnNext";
            this.BttnNext.Size = new System.Drawing.Size(98, 33);
            this.BttnNext.TabIndex = 35;
            this.BttnNext.Text = "Next";
            this.BttnNext.UseVisualStyleBackColor = true;
            // 
            // BttnPrevious
            // 
            this.BttnPrevious.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BttnPrevious.Location = new System.Drawing.Point(534, 511);
            this.BttnPrevious.Margin = new System.Windows.Forms.Padding(2);
            this.BttnPrevious.Name = "BttnPrevious";
            this.BttnPrevious.Size = new System.Drawing.Size(98, 33);
            this.BttnPrevious.TabIndex = 36;
            this.BttnPrevious.Text = "Previous";
            this.BttnPrevious.UseVisualStyleBackColor = true;
            // 
            // BttnFirst
            // 
            this.BttnFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BttnFirst.Location = new System.Drawing.Point(246, 511);
            this.BttnFirst.Margin = new System.Windows.Forms.Padding(2);
            this.BttnFirst.Name = "BttnFirst";
            this.BttnFirst.Size = new System.Drawing.Size(98, 33);
            this.BttnFirst.TabIndex = 34;
            this.BttnFirst.Text = "First";
            this.BttnFirst.UseVisualStyleBackColor = true;
            // 
            // TxtbxPrdctDesc
            // 
            this.TxtbxPrdctDesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtbxPrdctDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtbxPrdctDesc.Location = new System.Drawing.Point(246, 456);
            this.TxtbxPrdctDesc.Margin = new System.Windows.Forms.Padding(2);
            this.TxtbxPrdctDesc.Name = "TxtbxPrdctDesc";
            this.TxtbxPrdctDesc.Size = new System.Drawing.Size(528, 32);
            this.TxtbxPrdctDesc.TabIndex = 33;
            // 
            // TxtbxMSRP
            // 
            this.TxtbxMSRP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtbxMSRP.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtbxMSRP.Location = new System.Drawing.Point(246, 404);
            this.TxtbxMSRP.Margin = new System.Windows.Forms.Padding(2);
            this.TxtbxMSRP.Name = "TxtbxMSRP";
            this.TxtbxMSRP.Size = new System.Drawing.Size(528, 32);
            this.TxtbxMSRP.TabIndex = 32;
            // 
            // TxtbxBuyPrc
            // 
            this.TxtbxBuyPrc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtbxBuyPrc.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtbxBuyPrc.Location = new System.Drawing.Point(246, 352);
            this.TxtbxBuyPrc.Margin = new System.Windows.Forms.Padding(2);
            this.TxtbxBuyPrc.Name = "TxtbxBuyPrc";
            this.TxtbxBuyPrc.Size = new System.Drawing.Size(528, 32);
            this.TxtbxBuyPrc.TabIndex = 31;
            // 
            // TxtbxPrdctCd
            // 
            this.TxtbxPrdctCd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtbxPrdctCd.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtbxPrdctCd.Location = new System.Drawing.Point(246, 20);
            this.TxtbxPrdctCd.Margin = new System.Windows.Forms.Padding(2);
            this.TxtbxPrdctCd.Name = "TxtbxPrdctCd";
            this.TxtbxPrdctCd.Size = new System.Drawing.Size(232, 32);
            this.TxtbxPrdctCd.TabIndex = 30;
            this.TxtbxPrdctCd.TextChanged += new System.EventHandler(this.TxtbxPrdctCd_TextChanged);
            // 
            // TxtbxPrdctLn
            // 
            this.TxtbxPrdctLn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtbxPrdctLn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtbxPrdctLn.Location = new System.Drawing.Point(246, 72);
            this.TxtbxPrdctLn.Margin = new System.Windows.Forms.Padding(2);
            this.TxtbxPrdctLn.Name = "TxtbxPrdctLn";
            this.TxtbxPrdctLn.Size = new System.Drawing.Size(232, 32);
            this.TxtbxPrdctLn.TabIndex = 29;
            // 
            // TxtbxPrdctScl
            // 
            this.TxtbxPrdctScl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtbxPrdctScl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtbxPrdctScl.Location = new System.Drawing.Point(246, 124);
            this.TxtbxPrdctScl.Margin = new System.Windows.Forms.Padding(2);
            this.TxtbxPrdctScl.Name = "TxtbxPrdctScl";
            this.TxtbxPrdctScl.Size = new System.Drawing.Size(232, 32);
            this.TxtbxPrdctScl.TabIndex = 28;
            // 
            // TxtbxPrdctNm
            // 
            this.TxtbxPrdctNm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtbxPrdctNm.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtbxPrdctNm.Location = new System.Drawing.Point(246, 183);
            this.TxtbxPrdctNm.Margin = new System.Windows.Forms.Padding(2);
            this.TxtbxPrdctNm.Name = "TxtbxPrdctNm";
            this.TxtbxPrdctNm.Size = new System.Drawing.Size(528, 32);
            this.TxtbxPrdctNm.TabIndex = 27;
            // 
            // TxtbxPrdctVndr
            // 
            this.TxtbxPrdctVndr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtbxPrdctVndr.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtbxPrdctVndr.Location = new System.Drawing.Point(246, 237);
            this.TxtbxPrdctVndr.Margin = new System.Windows.Forms.Padding(2);
            this.TxtbxPrdctVndr.Name = "TxtbxPrdctVndr";
            this.TxtbxPrdctVndr.Size = new System.Drawing.Size(528, 32);
            this.TxtbxPrdctVndr.TabIndex = 26;
            // 
            // LblPrdctNm
            // 
            this.LblPrdctNm.AutoSize = true;
            this.LblPrdctNm.BackColor = System.Drawing.Color.Transparent;
            this.LblPrdctNm.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPrdctNm.Location = new System.Drawing.Point(65, 184);
            this.LblPrdctNm.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblPrdctNm.Name = "LblPrdctNm";
            this.LblPrdctNm.Size = new System.Drawing.Size(173, 29);
            this.LblPrdctNm.TabIndex = 25;
            this.LblPrdctNm.Text = "Product Name:";
            // 
            // LblPrdctLn
            // 
            this.LblPrdctLn.AutoSize = true;
            this.LblPrdctLn.BackColor = System.Drawing.Color.Transparent;
            this.LblPrdctLn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPrdctLn.Location = new System.Drawing.Point(80, 78);
            this.LblPrdctLn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblPrdctLn.Name = "LblPrdctLn";
            this.LblPrdctLn.Size = new System.Drawing.Size(154, 29);
            this.LblPrdctLn.TabIndex = 24;
            this.LblPrdctLn.Text = "Product Line:";
            // 
            // LblPrdctScl
            // 
            this.LblPrdctScl.AutoSize = true;
            this.LblPrdctScl.BackColor = System.Drawing.Color.Transparent;
            this.LblPrdctScl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPrdctScl.Location = new System.Drawing.Point(68, 127);
            this.LblPrdctScl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblPrdctScl.Name = "LblPrdctScl";
            this.LblPrdctScl.Size = new System.Drawing.Size(169, 29);
            this.LblPrdctScl.TabIndex = 23;
            this.LblPrdctScl.Text = "Product Scale:";
            // 
            // LblPrdctVndr
            // 
            this.LblPrdctVndr.AutoSize = true;
            this.LblPrdctVndr.BackColor = System.Drawing.Color.Transparent;
            this.LblPrdctVndr.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPrdctVndr.Location = new System.Drawing.Point(50, 239);
            this.LblPrdctVndr.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblPrdctVndr.Name = "LblPrdctVndr";
            this.LblPrdctVndr.Size = new System.Drawing.Size(186, 29);
            this.LblPrdctVndr.TabIndex = 22;
            this.LblPrdctVndr.Text = "Product Vendor:";
            // 
            // LblPrdctDesc
            // 
            this.LblPrdctDesc.AutoSize = true;
            this.LblPrdctDesc.BackColor = System.Drawing.Color.Transparent;
            this.LblPrdctDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPrdctDesc.Location = new System.Drawing.Point(17, 457);
            this.LblPrdctDesc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblPrdctDesc.Name = "LblPrdctDesc";
            this.LblPrdctDesc.Size = new System.Drawing.Size(230, 29);
            this.LblPrdctDesc.TabIndex = 21;
            this.LblPrdctDesc.Text = "Product Description:";
            // 
            // LblQntStck
            // 
            this.LblQntStck.AutoSize = true;
            this.LblQntStck.BackColor = System.Drawing.Color.Transparent;
            this.LblQntStck.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblQntStck.Location = new System.Drawing.Point(38, 295);
            this.LblQntStck.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblQntStck.Name = "LblQntStck";
            this.LblQntStck.Size = new System.Drawing.Size(197, 29);
            this.LblQntStck.TabIndex = 20;
            this.LblQntStck.Text = "Quantity in Stock:";
            // 
            // LblBuyPrc
            // 
            this.LblBuyPrc.AutoSize = true;
            this.LblBuyPrc.BackColor = System.Drawing.Color.Transparent;
            this.LblBuyPrc.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBuyPrc.Location = new System.Drawing.Point(111, 353);
            this.LblBuyPrc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblBuyPrc.Name = "LblBuyPrc";
            this.LblBuyPrc.Size = new System.Drawing.Size(121, 29);
            this.LblBuyPrc.TabIndex = 19;
            this.LblBuyPrc.Text = "Buy Price:";
            // 
            // LblMSRP
            // 
            this.LblMSRP.AutoSize = true;
            this.LblMSRP.BackColor = System.Drawing.Color.Transparent;
            this.LblMSRP.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMSRP.Location = new System.Drawing.Point(142, 405);
            this.LblMSRP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblMSRP.Name = "LblMSRP";
            this.LblMSRP.Size = new System.Drawing.Size(88, 29);
            this.LblMSRP.TabIndex = 18;
            this.LblMSRP.Text = "MSRP:";
            // 
            // TxtbxQntStck
            // 
            this.TxtbxQntStck.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtbxQntStck.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtbxQntStck.Location = new System.Drawing.Point(246, 295);
            this.TxtbxQntStck.Margin = new System.Windows.Forms.Padding(2);
            this.TxtbxQntStck.Name = "TxtbxQntStck";
            this.TxtbxQntStck.Size = new System.Drawing.Size(528, 32);
            this.TxtbxQntStck.TabIndex = 17;
            // 
            // LblPrdctCd
            // 
            this.LblPrdctCd.AutoSize = true;
            this.LblPrdctCd.BackColor = System.Drawing.Color.Transparent;
            this.LblPrdctCd.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPrdctCd.Location = new System.Drawing.Point(70, 20);
            this.LblPrdctCd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblPrdctCd.Name = "LblPrdctCd";
            this.LblPrdctCd.Size = new System.Drawing.Size(167, 29);
            this.LblPrdctCd.TabIndex = 1;
            this.LblPrdctCd.Text = "Product Code:";
            // 
            // ViewPrdcts
            // 
            this.ViewPrdcts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ViewPrdcts.Controls.Add(this.DtgrdPrdcts);
            this.ViewPrdcts.Location = new System.Drawing.Point(4, 22);
            this.ViewPrdcts.Margin = new System.Windows.Forms.Padding(2);
            this.ViewPrdcts.Name = "ViewPrdcts";
            this.ViewPrdcts.Padding = new System.Windows.Forms.Padding(2);
            this.ViewPrdcts.Size = new System.Drawing.Size(795, 574);
            this.ViewPrdcts.TabIndex = 1;
            this.ViewPrdcts.Text = "View Products";
            // 
            // DtgrdPrdcts
            // 
            this.DtgrdPrdcts.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.DtgrdPrdcts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgrdPrdcts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DtgrdPrdcts.Location = new System.Drawing.Point(2, 2);
            this.DtgrdPrdcts.Margin = new System.Windows.Forms.Padding(2);
            this.DtgrdPrdcts.Name = "DtgrdPrdcts";
            this.DtgrdPrdcts.RowHeadersWidth = 51;
            this.DtgrdPrdcts.RowTemplate.Height = 24;
            this.DtgrdPrdcts.Size = new System.Drawing.Size(791, 570);
            this.DtgrdPrdcts.TabIndex = 0;
            this.DtgrdPrdcts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtgrdPrdcts_CellContentClick);
            // 
            // FrmProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(799, 594);
            this.Controls.Add(this.TbcntrlPrdcts);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmProducts";
            this.Text = "Products";
            this.Load += new System.EventHandler(this.FrmProducts_Load);
            this.TbcntrlPrdcts.ResumeLayout(false);
            this.NewPrdcts.ResumeLayout(false);
            this.NewPrdcts.PerformLayout();
            this.ViewPrdcts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DtgrdPrdcts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TbcntrlPrdcts;
        private System.Windows.Forms.TabPage NewPrdcts;
        private System.Windows.Forms.TabPage ViewPrdcts;
        private System.Windows.Forms.DataGridView DtgrdPrdcts;
        private System.Windows.Forms.Label LblPrdctCd;
        private System.Windows.Forms.TextBox TxtbxQntStck;
        private System.Windows.Forms.TextBox TxtbxPrdctDesc;
        private System.Windows.Forms.TextBox TxtbxMSRP;
        private System.Windows.Forms.TextBox TxtbxBuyPrc;
        private System.Windows.Forms.TextBox TxtbxPrdctCd;
        private System.Windows.Forms.TextBox TxtbxPrdctLn;
        private System.Windows.Forms.TextBox TxtbxPrdctScl;
        private System.Windows.Forms.TextBox TxtbxPrdctNm;
        private System.Windows.Forms.TextBox TxtbxPrdctVndr;
        private System.Windows.Forms.Label LblPrdctNm;
        private System.Windows.Forms.Label LblPrdctLn;
        private System.Windows.Forms.Label LblPrdctScl;
        private System.Windows.Forms.Label LblPrdctVndr;
        private System.Windows.Forms.Label LblPrdctDesc;
        private System.Windows.Forms.Label LblQntStck;
        private System.Windows.Forms.Label LblBuyPrc;
        private System.Windows.Forms.Label LblMSRP;
        private System.Windows.Forms.Button BttnLast;
        private System.Windows.Forms.Button BttnNext;
        private System.Windows.Forms.Button BttnPrevious;
        private System.Windows.Forms.Button BttnFirst;
        private System.Windows.Forms.Button BttnCancel;
        private System.Windows.Forms.Button BttnUpdate;
        private System.Windows.Forms.Button BttnSave;
        private System.Windows.Forms.Button BttnDelete;
        private System.Windows.Forms.Button BttnNew;
    }
}