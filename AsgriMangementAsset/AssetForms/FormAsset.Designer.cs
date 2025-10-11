namespace AsgriMangementAsset.AssetForms
{
    partial class FormAsset
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
            this.dgAsset = new System.Windows.Forms.DataGridView();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelet = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AssetLableNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AssetCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.وضعیت = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.عنوان = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AssetCompany = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AssetCountry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AssetPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AssetColor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AssetModel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AssetSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgAsset)).BeginInit();
            this.SuspendLayout();
            // 
            // dgAsset
            // 
            this.dgAsset.AllowUserToAddRows = false;
            this.dgAsset.AllowUserToDeleteRows = false;
            this.dgAsset.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAsset.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AssetLableNumber,
            this.AssetCode,
            this.وضعیت,
            this.عنوان,
            this.AssetCompany,
            this.AssetCountry,
            this.AssetPrice,
            this.AssetColor,
            this.AssetModel,
            this.AssetSize});
            this.dgAsset.Location = new System.Drawing.Point(12, 122);
            this.dgAsset.Name = "dgAsset";
            this.dgAsset.ReadOnly = true;
            this.dgAsset.Size = new System.Drawing.Size(753, 304);
            this.dgAsset.TabIndex = 0;
            this.dgAsset.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgAsset_CellContentClick);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(672, 12);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(93, 34);
            this.btnInsert.TabIndex = 1;
            this.btnInsert.Text = " افزودن اموال";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(376, 12);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(93, 34);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Text = "بروز رسانی";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(574, 12);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(93, 34);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "ویرایش اموال";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelet
            // 
            this.btnDelet.Location = new System.Drawing.Point(475, 12);
            this.btnDelet.Name = "btnDelet";
            this.btnDelet.Size = new System.Drawing.Size(93, 34);
            this.btnDelet.TabIndex = 4;
            this.btnDelet.Text = "حذف اموال";
            this.btnDelet.UseVisualStyleBackColor = true;
            this.btnDelet.Click += new System.EventHandler(this.btnDelet_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(417, 81);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(250, 20);
            this.txtSearch.TabIndex = 5;
            this.txtSearch.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(709, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "جستوجو";
            // 
            // AssetLableNumber
            // 
            this.AssetLableNumber.DataPropertyName = "AssetLableNumber";
            this.AssetLableNumber.HeaderText = "AssetLableNumber";
            this.AssetLableNumber.Name = "AssetLableNumber";
            this.AssetLableNumber.ReadOnly = true;
            this.AssetLableNumber.Visible = false;
            // 
            // AssetCode
            // 
            this.AssetCode.DataPropertyName = "AssetCode";
            this.AssetCode.HeaderText = "کد";
            this.AssetCode.Name = "AssetCode";
            this.AssetCode.ReadOnly = true;
            // 
            // وضعیت
            // 
            this.وضعیت.DataPropertyName = "Status";
            this.وضعیت.HeaderText = "وضعیت";
            this.وضعیت.Name = "وضعیت";
            this.وضعیت.ReadOnly = true;
            // 
            // عنوان
            // 
            this.عنوان.DataPropertyName = "AssetTitle";
            this.عنوان.HeaderText = "عنوان";
            this.عنوان.Name = "عنوان";
            this.عنوان.ReadOnly = true;
            // 
            // AssetCompany
            // 
            this.AssetCompany.DataPropertyName = "AssetCompany";
            this.AssetCompany.HeaderText = "شرکت سازنده";
            this.AssetCompany.Name = "AssetCompany";
            this.AssetCompany.ReadOnly = true;
            // 
            // AssetCountry
            // 
            this.AssetCountry.DataPropertyName = "AssetCountry";
            this.AssetCountry.HeaderText = "کشور سازنده";
            this.AssetCountry.Name = "AssetCountry";
            this.AssetCountry.ReadOnly = true;
            // 
            // AssetPrice
            // 
            this.AssetPrice.DataPropertyName = "AssetPrice";
            this.AssetPrice.HeaderText = "ارزش اموال";
            this.AssetPrice.Name = "AssetPrice";
            this.AssetPrice.ReadOnly = true;
            // 
            // AssetColor
            // 
            this.AssetColor.DataPropertyName = "AssetColor";
            this.AssetColor.HeaderText = "رنگ";
            this.AssetColor.Name = "AssetColor";
            this.AssetColor.ReadOnly = true;
            // 
            // AssetModel
            // 
            this.AssetModel.DataPropertyName = "AssetModel";
            this.AssetModel.HeaderText = "مدل اموال";
            this.AssetModel.Name = "AssetModel";
            this.AssetModel.ReadOnly = true;
            // 
            // AssetSize
            // 
            this.AssetSize.DataPropertyName = "AssetSize";
            this.AssetSize.HeaderText = "ابعاد اموال";
            this.AssetSize.Name = "AssetSize";
            this.AssetSize.ReadOnly = true;
            // 
            // FormAsset
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 438);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnDelet);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.dgAsset);
            this.Name = "FormAsset";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "ثبت اموال";
            this.Load += new System.EventHandler(this.FormAsset_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgAsset)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgAsset;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelet;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn AssetLableNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn AssetCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn وضعیت;
        private System.Windows.Forms.DataGridViewTextBoxColumn عنوان;
        private System.Windows.Forms.DataGridViewTextBoxColumn AssetCompany;
        private System.Windows.Forms.DataGridViewTextBoxColumn AssetCountry;
        private System.Windows.Forms.DataGridViewTextBoxColumn AssetPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn AssetColor;
        private System.Windows.Forms.DataGridViewTextBoxColumn AssetModel;
        private System.Windows.Forms.DataGridViewTextBoxColumn AssetSize;
    }
}