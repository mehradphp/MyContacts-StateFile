
namespace MyContacts
{
    partial class frmAddOrEddit
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
            this.Price = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSubmitState = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.Category = new System.Windows.Forms.ComboBox();
            this.Summery = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Mobile = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.CityName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Address = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.MalekName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CodeFile = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Price)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Price
            // 
            this.Price.Location = new System.Drawing.Point(285, 107);
            this.Price.Maximum = new decimal(new int[] {
            -305594368,
            20954757,
            0,
            0});
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(99, 22);
            this.Price.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSubmitState);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.Category);
            this.groupBox1.Controls.Add(this.Summery);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.Mobile);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.CityName);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.Price);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.Address);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.MalekName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.CodeFile);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(613, 349);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "افزودن اطلاعات";
            // 
            // btnSubmitState
            // 
            this.btnSubmitState.Location = new System.Drawing.Point(15, 281);
            this.btnSubmitState.Name = "btnSubmitState";
            this.btnSubmitState.Size = new System.Drawing.Size(578, 62);
            this.btnSubmitState.TabIndex = 17;
            this.btnSubmitState.Text = "ثبت فایل";
            this.btnSubmitState.UseVisualStyleBackColor = true;
            this.btnSubmitState.Click += new System.EventHandler(this.btnSubmitState_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(217, 111);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 14);
            this.label9.TabIndex = 16;
            this.label9.Text = "دسته بندی";
            // 
            // Category
            // 
            this.Category.FormattingEnabled = true;
            this.Category.Items.AddRange(new object[] {
            "زمین",
            "ویلا",
            "آپارتمان"});
            this.Category.Location = new System.Drawing.Point(15, 108);
            this.Category.Name = "Category";
            this.Category.Size = new System.Drawing.Size(196, 22);
            this.Category.TabIndex = 15;
            // 
            // Summery
            // 
            this.Summery.Location = new System.Drawing.Point(14, 176);
            this.Summery.Multiline = true;
            this.Summery.Name = "Summery";
            this.Summery.Size = new System.Drawing.Size(295, 99);
            this.Summery.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(259, 154);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 14);
            this.label8.TabIndex = 13;
            this.label8.Text = "توضیحات";
            // 
            // Mobile
            // 
            this.Mobile.Location = new System.Drawing.Point(15, 69);
            this.Mobile.Name = "Mobile";
            this.Mobile.Size = new System.Drawing.Size(196, 22);
            this.Mobile.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(217, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 14);
            this.label7.TabIndex = 11;
            this.label7.Text = "تلفن تماس";
            // 
            // CityName
            // 
            this.CityName.Location = new System.Drawing.Point(442, 107);
            this.CityName.Name = "CityName";
            this.CityName.Size = new System.Drawing.Size(100, 22);
            this.CityName.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(548, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 14);
            this.label6.TabIndex = 9;
            this.label6.Text = "نام شهر";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(391, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 14);
            this.label5.TabIndex = 7;
            this.label5.Text = "قیمت";
            // 
            // Address
            // 
            this.Address.Location = new System.Drawing.Point(324, 176);
            this.Address.Multiline = true;
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(269, 99);
            this.Address.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(562, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 14);
            this.label4.TabIndex = 5;
            this.label4.Text = "آدرس";
            // 
            // MalekName
            // 
            this.MalekName.Location = new System.Drawing.Point(285, 69);
            this.MalekName.Name = "MalekName";
            this.MalekName.Size = new System.Drawing.Size(100, 22);
            this.MalekName.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(391, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 14);
            this.label3.TabIndex = 3;
            this.label3.Text = "نام مالک";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // CodeFile
            // 
            this.CodeFile.Location = new System.Drawing.Point(442, 69);
            this.CodeFile.Name = "CodeFile";
            this.CodeFile.Size = new System.Drawing.Size(100, 22);
            this.CodeFile.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(548, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "کد فایل";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(537, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "اخرین کد ";
            // 
            // frmAddOrEddit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 373);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmAddOrEddit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmAddOrEddit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Price)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox MalekName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox CodeFile;
        private System.Windows.Forms.TextBox CityName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown Price;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Address;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Mobile;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Summery;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox Category;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnSubmitState;
    }
}