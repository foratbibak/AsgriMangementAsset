namespace AsgriMangementAsset
{
    partial class frmReports
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReports));
            this.btnPrint = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnClearReports = new System.Windows.Forms.Button();
            this.dgvReports = new System.Windows.Forms.DataGridView();
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
            this.txtToDate = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFromDate = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnReports = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.stiReports = new Stimulsoft.Report.StiReport();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReports)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPrint
            // 
            this.btnPrint.Font = new System.Drawing.Font("Tahoma", 13F);
            this.btnPrint.Location = new System.Drawing.Point(168, 23);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(134, 55);
            this.btnPrint.TabIndex = 13;
            this.btnPrint.Text = "چاپ";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 15.25F);
            this.label3.Location = new System.Drawing.Point(158, 36);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 25);
            this.label3.TabIndex = 17;
            this.label3.Text = "تا تاریخ:";
            // 
            // btnClearReports
            // 
            this.btnClearReports.Font = new System.Drawing.Font("Tahoma", 11F);
            this.btnClearReports.Location = new System.Drawing.Point(310, 23);
            this.btnClearReports.Margin = new System.Windows.Forms.Padding(4);
            this.btnClearReports.Name = "btnClearReports";
            this.btnClearReports.Size = new System.Drawing.Size(134, 55);
            this.btnClearReports.TabIndex = 12;
            this.btnClearReports.Text = "حذف گزارش";
            this.btnClearReports.UseVisualStyleBackColor = true;
            this.btnClearReports.Click += new System.EventHandler(this.btnClearReports_Click);
            // 
            // dgvReports
            // 
            this.dgvReports.AllowUserToAddRows = false;
            this.dgvReports.AllowUserToDeleteRows = false;
            this.dgvReports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReports.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.dgvReports.Location = new System.Drawing.Point(9, 260);
            this.dgvReports.Margin = new System.Windows.Forms.Padding(5);
            this.dgvReports.Name = "dgvReports";
            this.dgvReports.ReadOnly = true;
            this.dgvReports.Size = new System.Drawing.Size(748, 287);
            this.dgvReports.TabIndex = 18;
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
            // txtToDate
            // 
            this.txtToDate.Location = new System.Drawing.Point(7, 40);
            this.txtToDate.Margin = new System.Windows.Forms.Padding(4);
            this.txtToDate.Mask = "0000/00/00";
            this.txtToDate.Name = "txtToDate";
            this.txtToDate.Size = new System.Drawing.Size(143, 23);
            this.txtToDate.TabIndex = 16;
            this.txtToDate.ValidatingType = typeof(System.DateTime);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.label2.Location = new System.Drawing.Point(670, 37);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 23);
            this.label2.TabIndex = 15;
            this.label2.Text = "از تاریخ:";
            // 
            // txtFromDate
            // 
            this.txtFromDate.Location = new System.Drawing.Point(519, 40);
            this.txtFromDate.Margin = new System.Windows.Forms.Padding(4);
            this.txtFromDate.Mask = "0000/00/00";
            this.txtFromDate.Name = "txtFromDate";
            this.txtFromDate.Size = new System.Drawing.Size(143, 23);
            this.txtFromDate.TabIndex = 14;
            this.txtFromDate.ValidatingType = typeof(System.DateTime);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnReports);
            this.groupBox1.Controls.Add(this.btnClearReports);
            this.groupBox1.Controls.Add(this.btnPrint);
            this.groupBox1.Location = new System.Drawing.Point(9, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(748, 100);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "دکمه های عملیاتی";
            // 
            // btnReports
            // 
            this.btnReports.Font = new System.Drawing.Font("Tahoma", 11F);
            this.btnReports.Location = new System.Drawing.Point(451, 23);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(134, 55);
            this.btnReports.TabIndex = 14;
            this.btnReports.Text = "ثبت گزارش";
            this.btnReports.UseVisualStyleBackColor = true;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtFromDate);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtToDate);
            this.groupBox2.Location = new System.Drawing.Point(9, 167);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(748, 87);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "تاریخ گزارش گیری";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 18.25F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(460, 125);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 30);
            this.label1.TabIndex = 21;
            this.label1.Text = "هنرستان شهید عسگری";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arabic Typesetting", 30F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(9, 119);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(195, 45);
            this.label4.TabIndex = 24;
            this.label4.Text = "SharpIT Group";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.label5.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label5.Location = new System.Drawing.Point(377, 544);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(185, 17);
            this.label5.TabIndex = 23;
            this.label5.Text = "از گروه مهندسی شارپ آی تی";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.label6.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label6.Location = new System.Drawing.Point(556, 544);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(200, 17);
            this.label6.TabIndex = 22;
            this.label6.Text = "ساخته شده توسط  فرات بی باک";
            // 
            // frmReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(760, 564);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvReports);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmReports";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmReports";
            this.Load += new System.EventHandler(this.frmReports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReports)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnClearReports;
        private System.Windows.Forms.DataGridView dgvReports;
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
        private System.Windows.Forms.MaskedTextBox txtToDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txtFromDate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnReports;
        private Stimulsoft.Report.StiReport stiReports;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}