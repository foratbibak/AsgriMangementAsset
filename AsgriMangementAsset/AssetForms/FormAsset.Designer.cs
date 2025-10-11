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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAsset));
            this.dgAsset = new System.Windows.Forms.DataGridView();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AssetCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.وضعیت = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.عنوان = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AssetCompany = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AssetCountry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AssetPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AssetColor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AssetModel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AssetSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateEdit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelet = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbTitle = new System.Windows.Forms.ComboBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.customValidator1 = new ValidationComponents.CustomValidator(this.components);
            this.stiReports = new Stimulsoft.Report.StiReport();
            ((System.ComponentModel.ISupportInitialize)(this.dgAsset)).BeginInit();
            this.SuspendLayout();
            // 
            // dgAsset
            // 
            this.dgAsset.AllowUserToAddRows = false;
            this.dgAsset.AllowUserToDeleteRows = false;
            this.dgAsset.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAsset.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Number,
            this.AssetCode,
            this.وضعیت,
            this.عنوان,
            this.AssetCompany,
            this.AssetCountry,
            this.AssetPrice,
            this.AssetColor,
            this.AssetModel,
            this.AssetSize,
            this.Date,
            this.DateEdit});
            this.dgAsset.Location = new System.Drawing.Point(12, 122);
            this.dgAsset.Name = "dgAsset";
            this.dgAsset.ReadOnly = true;
            this.dgAsset.Size = new System.Drawing.Size(753, 304);
            this.dgAsset.TabIndex = 0;
            this.dgAsset.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgAsset_CellContentClick);
            // 
            // Number
            // 
            this.Number.DataPropertyName = "AssetLabelNumber";
            this.Number.HeaderText = "AssetLableNumber";
            this.Number.Name = "Number";
            this.Number.ReadOnly = true;
            this.Number.Visible = false;
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
            // Date
            // 
            this.Date.DataPropertyName = "AssetDate";
            this.Date.HeaderText = "تاریخ ثبت";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // DateEdit
            // 
            this.DateEdit.DataPropertyName = "AssetEditDate";
            this.DateEdit.HeaderText = "تاریخ ویرایش";
            this.DateEdit.Name = "DateEdit";
            this.DateEdit.ReadOnly = true;
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
            // cmbTitle
            // 
            this.cmbTitle.FormattingEnabled = true;
            this.cmbTitle.Location = new System.Drawing.Point(246, 81);
            this.cmbTitle.Name = "cmbTitle";
            this.cmbTitle.Size = new System.Drawing.Size(151, 21);
            this.cmbTitle.TabIndex = 7;
            this.cmbTitle.SelectedIndexChanged += new System.EventHandler(this.cmbTitle_SelectedIndexChanged);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(277, 12);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(93, 34);
            this.btnPrint.TabIndex = 8;
            this.btnPrint.Text = "چاپ";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // customValidator1
            // 
            this.customValidator1.CancelFocusChangeWhenInvalid = false;
            this.customValidator1.ControlToValidate = null;
            this.customValidator1.ErrorMessage = null;
            this.customValidator1.Icon = ((System.Drawing.Icon)(resources.GetObject("customValidator1.Icon")));
            this.customValidator1.IsValidated = false;
            // 
            // stiReports
            // 
            this.stiReports.CookieContainer = null;
            this.stiReports.EngineVersion = Stimulsoft.Report.Engine.StiEngineVersion.EngineV2;
            this.stiReports.ReferencedAssemblies = new string[] {
        "System.Dll",
        "System.Drawing.Dll",
        "System.Windows.Forms.Dll",
        "System.Data.Dll",
        "System.Xml.Dll",
        "Stimulsoft.Controls.Dll",
        "Stimulsoft.Base.Dll",
        "Stimulsoft.Report.Dll"};
            this.stiReports.ReportAlias = "Report";
            this.stiReports.ReportGuid = "5f288a55e6934035865455bba6c9ca0a";
            this.stiReports.ReportName = "Report";
            this.stiReports.ReportSource = null;
            this.stiReports.ReportUnit = Stimulsoft.Report.StiReportUnitType.Inches;
            this.stiReports.ScriptLanguage = Stimulsoft.Report.StiReportLanguageType.CSharp;
            this.stiReports.UseProgressInThread = false;
            // 
            // FormAsset
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 438);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.cmbTitle);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn AssetCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn وضعیت;
        private System.Windows.Forms.DataGridViewTextBoxColumn عنوان;
        private System.Windows.Forms.DataGridViewTextBoxColumn AssetCompany;
        private System.Windows.Forms.DataGridViewTextBoxColumn AssetCountry;
        private System.Windows.Forms.DataGridViewTextBoxColumn AssetPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn AssetColor;
        private System.Windows.Forms.DataGridViewTextBoxColumn AssetModel;
        private System.Windows.Forms.DataGridViewTextBoxColumn AssetSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateEdit;
        private System.Windows.Forms.ComboBox cmbTitle;
        private System.Windows.Forms.Button btnPrint;
        private ValidationComponents.CustomValidator customValidator1;
        private Stimulsoft.Report.StiReport stiReports;
    }
}