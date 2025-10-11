namespace AsgriMangementAsset.AssetForms
{
    partial class frmAddoredit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddoredit));
            this.btnsabt = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblCompany = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblCode = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txTitle = new System.Windows.Forms.TextBox();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.txtCompany = new System.Windows.Forms.TextBox();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtSize = new System.Windows.Forms.TextBox();
            this.txtnumric = new System.Windows.Forms.NumericUpDown();
            this.Title = new ValidationComponents.RequiredFieldValidator(this.components);
            this.Code = new ValidationComponents.RequiredFieldValidator(this.components);
            this.Statuse = new ValidationComponents.RequiredFieldValidator(this.components);
            this.rangeValidator1 = new ValidationComponents.RangeValidator(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.txtnumric)).BeginInit();
            this.SuspendLayout();
            // 
            // btnsabt
            // 
            this.btnsabt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnsabt.Location = new System.Drawing.Point(162, 387);
            this.btnsabt.Name = "btnsabt";
            this.btnsabt.Size = new System.Drawing.Size(243, 34);
            this.btnsabt.TabIndex = 17;
            this.btnsabt.Text = "ثبت";
            this.btnsabt.UseVisualStyleBackColor = true;
            this.btnsabt.Click += new System.EventHandler(this.btnsabt_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblStatus.Location = new System.Drawing.Point(523, 100);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(63, 20);
            this.lblStatus.TabIndex = 16;
            this.lblStatus.Text = "وضعیت :";
            // 
            // lblCompany
            // 
            this.lblCompany.AutoSize = true;
            this.lblCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblCompany.Location = new System.Drawing.Point(213, 98);
            this.lblCompany.Name = "lblCompany";
            this.lblCompany.Size = new System.Drawing.Size(106, 20);
            this.lblCompany.TabIndex = 14;
            this.lblCompany.Text = " شرکت سازنده  :";
            this.lblCompany.Click += new System.EventHandler(this.lblAddress_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblTitle.Location = new System.Drawing.Point(532, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(52, 20);
            this.lblTitle.TabIndex = 12;
            this.lblTitle.Text = "عنوان :";
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblCode.Location = new System.Drawing.Point(226, 12);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(59, 18);
            this.lblCode.TabIndex = 10;
            this.lblCode.Text = "کد اموال :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label1.Location = new System.Drawing.Point(213, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "قیمت  :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label2.Location = new System.Drawing.Point(490, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "کشور سازنده  :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label3.Location = new System.Drawing.Point(538, 264);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 20);
            this.label3.TabIndex = 23;
            this.label3.Text = "رنگ  :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label4.Location = new System.Drawing.Point(213, 264);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 20);
            this.label4.TabIndex = 25;
            this.label4.Text = "مدل :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label5.Location = new System.Drawing.Point(375, 318);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 20);
            this.label5.TabIndex = 27;
            this.label5.Text = " ابعاد  :";
            // 
            // txTitle
            // 
            this.txTitle.Location = new System.Drawing.Point(375, 14);
            this.txTitle.Name = "txTitle";
            this.txTitle.Size = new System.Drawing.Size(142, 20);
            this.txTitle.TabIndex = 28;
            this.txTitle.TextChanged += new System.EventHandler(this.txTitle_TextChanged);
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(26, 12);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(181, 20);
            this.txtCode.TabIndex = 29;
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(375, 102);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(142, 20);
            this.txtStatus.TabIndex = 30;
            // 
            // txtCompany
            // 
            this.txtCompany.Location = new System.Drawing.Point(26, 99);
            this.txtCompany.Name = "txtCompany";
            this.txtCompany.Size = new System.Drawing.Size(181, 20);
            this.txtCompany.TabIndex = 31;
            // 
            // txtCountry
            // 
            this.txtCountry.Location = new System.Drawing.Point(375, 194);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(109, 20);
            this.txtCountry.TabIndex = 32;
            // 
            // txtColor
            // 
            this.txtColor.Location = new System.Drawing.Point(375, 266);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(157, 20);
            this.txtColor.TabIndex = 34;
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(26, 264);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(181, 20);
            this.txtModel.TabIndex = 35;
            // 
            // txtSize
            // 
            this.txtSize.Location = new System.Drawing.Point(226, 318);
            this.txtSize.Name = "txtSize";
            this.txtSize.Size = new System.Drawing.Size(143, 20);
            this.txtSize.TabIndex = 36;
            // 
            // txtnumric
            // 
            this.txtnumric.Location = new System.Drawing.Point(26, 192);
            this.txtnumric.Name = "txtnumric";
            this.txtnumric.Size = new System.Drawing.Size(181, 20);
            this.txtnumric.TabIndex = 37;
            // 
            // Title
            // 
            this.Title.CancelFocusChangeWhenInvalid = false;
            this.Title.ControlToValidate = this.txTitle;
            this.Title.ErrorMessage = "لطفا عنوان رو وارد فرمایید ";
            this.Title.Icon = ((System.Drawing.Icon)(resources.GetObject("Title.Icon")));
            // 
            // Code
            // 
            this.Code.CancelFocusChangeWhenInvalid = false;
            this.Code.ControlToValidate = this.txtCode;
            this.Code.ErrorMessage = "لطفا کد اموال را وارد فرمایید";
            this.Code.Icon = ((System.Drawing.Icon)(resources.GetObject("Code.Icon")));
            // 
            // Statuse
            // 
            this.Statuse.CancelFocusChangeWhenInvalid = false;
            this.Statuse.ControlToValidate = this.txtStatus;
            this.Statuse.ErrorMessage = "لطفا وضعیت اموال رو وارد فرمایید";
            this.Statuse.Icon = ((System.Drawing.Icon)(resources.GetObject("Statuse.Icon")));
            // 
            // rangeValidator1
            // 
            this.rangeValidator1.CancelFocusChangeWhenInvalid = false;
            this.rangeValidator1.ControlToValidate = this.txtnumric;
            this.rangeValidator1.ErrorMessage = "لطفا ارزش اموال را وارد فرمایید";
            this.rangeValidator1.Icon = ((System.Drawing.Icon)(resources.GetObject("rangeValidator1.Icon")));
            this.rangeValidator1.MaximumValue = "999999999999";
            this.rangeValidator1.MinimumValue = "0";
            this.rangeValidator1.Type = ValidationComponents.ValidationDataType.Integer;
            // 
            // frmAddoredit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 450);
            this.Controls.Add(this.txtnumric);
            this.Controls.Add(this.txtSize);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.txtColor);
            this.Controls.Add(this.txtCountry);
            this.Controls.Add(this.txtCompany);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.txTitle);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnsabt);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblCompany);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblCode);
            this.Name = "frmAddoredit";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "افزودن شخص جدید ";
            this.Load += new System.EventHandler(this.frmAddoredit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtnumric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnsabt;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblCompany;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private ValidationComponents.RequiredFieldValidator Title;
        private ValidationComponents.RequiredFieldValidator Code;
        private ValidationComponents.RequiredFieldValidator Statuse;
        private System.Windows.Forms.TextBox txTitle;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.TextBox txtCompany;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TextBox txtSize;
        private System.Windows.Forms.NumericUpDown txtnumric;
        private ValidationComponents.RangeValidator rangeValidator1;
    }
}