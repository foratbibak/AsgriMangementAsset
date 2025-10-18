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
            this.stiReports = new Stimulsoft.Report.StiReport();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label4 = new System.Windows.Forms.Label();
            this.customValidator1 = new ValidationComponents.CustomValidator(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgAsset)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
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
            this.dgAsset.Location = new System.Drawing.Point(7, 24);
            this.dgAsset.Margin = new System.Windows.Forms.Padding(4);
            this.dgAsset.Name = "dgAsset";
            this.dgAsset.ReadOnly = true;
            this.dgAsset.Size = new System.Drawing.Size(918, 371);
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
            this.AssetCompany.Width = 120;
            // 
            // AssetCountry
            // 
            this.AssetCountry.DataPropertyName = "AssetCountry";
            this.AssetCountry.HeaderText = "کشور سازنده";
            this.AssetCountry.Name = "AssetCountry";
            this.AssetCountry.ReadOnly = true;
            this.AssetCountry.Width = 120;
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
            this.btnInsert.Location = new System.Drawing.Point(692, 18);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(4);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(108, 42);
            this.btnInsert.TabIndex = 1;
            this.btnInsert.Text = " افزودن اموال";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(297, 18);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(108, 42);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Text = "بروز رسانی";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(563, 18);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(108, 42);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "ویرایش اموال";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelet
            // 
            this.btnDelet.Location = new System.Drawing.Point(430, 18);
            this.btnDelet.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelet.Name = "btnDelet";
            this.btnDelet.Size = new System.Drawing.Size(108, 42);
            this.btnDelet.TabIndex = 4;
            this.btnDelet.Text = "حذف اموال";
            this.btnDelet.UseVisualStyleBackColor = true;
            this.btnDelet.Click += new System.EventHandler(this.btnDelet_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(247, 29);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(215, 23);
            this.txtSearch.TabIndex = 5;
            this.txtSearch.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(470, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "جستوجو :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cmbTitle
            // 
            this.cmbTitle.FormattingEnabled = true;
            this.cmbTitle.Location = new System.Drawing.Point(28, 28);
            this.cmbTitle.Margin = new System.Windows.Forms.Padding(4);
            this.cmbTitle.Name = "cmbTitle";
            this.cmbTitle.Size = new System.Drawing.Size(200, 24);
            this.cmbTitle.TabIndex = 7;
            this.cmbTitle.SelectedIndexChanged += new System.EventHandler(this.cmbTitle_SelectedIndexChanged);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(150, 18);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(108, 42);
            this.btnPrint.TabIndex = 8;
            this.btnPrint.Text = "چاپ";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgAsset);
            this.groupBox1.Location = new System.Drawing.Point(9, 176);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(933, 403);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "موجودی اموال ";
            this.groupBox1.UseCompatibleTextRendering = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtSearch);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cmbTitle);
            this.groupBox2.Location = new System.Drawing.Point(393, 88);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(541, 70);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "فیلتر جدول ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 10);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "فیلتر بر اساس کد اموال ";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnEdit);
            this.groupBox3.Controls.Add(this.btnInsert);
            this.groupBox3.Controls.Add(this.btnRefresh);
            this.groupBox3.Controls.Add(this.btnPrint);
            this.groupBox3.Controls.Add(this.btnDelet);
            this.groupBox3.Location = new System.Drawing.Point(16, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(918, 70);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "فیلتر جدول ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label3.Location = new System.Drawing.Point(756, 583);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "ساخته شده توسط  فرات بی باک";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label4.Location = new System.Drawing.Point(589, 584);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "از گروه مهندسی شارپ آی تی";
            // 
            // customValidator1
            // 
            this.customValidator1.CancelFocusChangeWhenInvalid = false;
            this.customValidator1.ControlToValidate = null;
            this.customValidator1.ErrorMessage = null;
            this.customValidator1.Icon = ((System.Drawing.Icon)(resources.GetObject("customValidator1.Icon")));
            this.customValidator1.IsValidated = false;
            // 

            // 
            // FormAsset
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(947, 602);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormAsset";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ثبت اموال";
            this.Load += new System.EventHandler(this.FormAsset_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgAsset)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
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
        private System.Windows.Forms.ComboBox cmbTitle;
        private System.Windows.Forms.Button btnPrint;
        private ValidationComponents.CustomValidator customValidator1;
        private Stimulsoft.Report.StiReport stiReports;
        private System.Windows.Forms.GroupBox groupBox1;
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
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label4;
    }
}