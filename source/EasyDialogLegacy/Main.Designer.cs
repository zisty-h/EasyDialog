namespace EasyDialogLegacy
{
    partial class Main
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.Run = new System.Windows.Forms.Button();
            this.ContentTextBox = new System.Windows.Forms.RichTextBox();
            this.Title = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Btn_AbReIg = new System.Windows.Forms.RadioButton();
            this.Btn_RetryCan = new System.Windows.Forms.RadioButton();
            this.Btn_YesNoCan = new System.Windows.Forms.RadioButton();
            this.Btn_YesNo = new System.Windows.Forms.RadioButton();
            this.Btn_OkCancel = new System.Windows.Forms.RadioButton();
            this.Btn_OK = new System.Windows.Forms.RadioButton();
            this.Ico_None = new System.Windows.Forms.RadioButton();
            this.Ico_Ques = new System.Windows.Forms.RadioButton();
            this.Ico_Warn = new System.Windows.Forms.RadioButton();
            this.Ico_Info = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Ico_Error = new System.Windows.Forms.RadioButton();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Run
            // 
            this.Run.Location = new System.Drawing.Point(183, 389);
            this.Run.Name = "Run";
            this.Run.Size = new System.Drawing.Size(82, 23);
            this.Run.TabIndex = 15;
            this.Run.Text = "Show Diarog";
            this.Run.UseVisualStyleBackColor = true;
            this.Run.Click += new System.EventHandler(this.Run_Click);
            // 
            // ContentTextBox
            // 
            this.ContentTextBox.Location = new System.Drawing.Point(12, 196);
            this.ContentTextBox.Name = "ContentTextBox";
            this.ContentTextBox.Size = new System.Drawing.Size(253, 187);
            this.ContentTextBox.TabIndex = 14;
            this.ContentTextBox.Text = "";
            // 
            // Title
            // 
            this.Title.Location = new System.Drawing.Point(46, 171);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(219, 19);
            this.Title.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 12);
            this.label1.TabIndex = 12;
            this.label1.Text = "Title";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Btn_AbReIg);
            this.groupBox2.Controls.Add(this.Btn_RetryCan);
            this.groupBox2.Controls.Add(this.Btn_YesNoCan);
            this.groupBox2.Controls.Add(this.Btn_YesNo);
            this.groupBox2.Controls.Add(this.Btn_OkCancel);
            this.groupBox2.Controls.Add(this.Btn_OK);
            this.groupBox2.Location = new System.Drawing.Point(111, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(154, 155);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Button";
            // 
            // Btn_AbReIg
            // 
            this.Btn_AbReIg.AutoSize = true;
            this.Btn_AbReIg.Location = new System.Drawing.Point(6, 128);
            this.Btn_AbReIg.Name = "Btn_AbReIg";
            this.Btn_AbReIg.Size = new System.Drawing.Size(124, 16);
            this.Btn_AbReIg.TabIndex = 5;
            this.Btn_AbReIg.Text = "About+Retry+Ignore";
            this.Btn_AbReIg.UseVisualStyleBackColor = true;
            // 
            // Btn_RetryCan
            // 
            this.Btn_RetryCan.AutoSize = true;
            this.Btn_RetryCan.Location = new System.Drawing.Point(6, 106);
            this.Btn_RetryCan.Name = "Btn_RetryCan";
            this.Btn_RetryCan.Size = new System.Drawing.Size(92, 16);
            this.Btn_RetryCan.TabIndex = 4;
            this.Btn_RetryCan.Text = "Retry+Cancel";
            this.Btn_RetryCan.UseVisualStyleBackColor = true;
            // 
            // Btn_YesNoCan
            // 
            this.Btn_YesNoCan.AutoSize = true;
            this.Btn_YesNoCan.Location = new System.Drawing.Point(6, 84);
            this.Btn_YesNoCan.Name = "Btn_YesNoCan";
            this.Btn_YesNoCan.Size = new System.Drawing.Size(103, 16);
            this.Btn_YesNoCan.TabIndex = 3;
            this.Btn_YesNoCan.Text = "Yes+No+Cancel";
            this.Btn_YesNoCan.UseVisualStyleBackColor = true;
            // 
            // Btn_YesNo
            // 
            this.Btn_YesNo.AutoSize = true;
            this.Btn_YesNo.Location = new System.Drawing.Point(6, 62);
            this.Btn_YesNo.Name = "Btn_YesNo";
            this.Btn_YesNo.Size = new System.Drawing.Size(62, 16);
            this.Btn_YesNo.TabIndex = 2;
            this.Btn_YesNo.Text = "Yes+No";
            this.Btn_YesNo.UseVisualStyleBackColor = true;
            // 
            // Btn_OkCancel
            // 
            this.Btn_OkCancel.AutoSize = true;
            this.Btn_OkCancel.Location = new System.Drawing.Point(6, 40);
            this.Btn_OkCancel.Name = "Btn_OkCancel";
            this.Btn_OkCancel.Size = new System.Drawing.Size(79, 16);
            this.Btn_OkCancel.TabIndex = 1;
            this.Btn_OkCancel.Text = "OK+Cancel";
            this.Btn_OkCancel.UseVisualStyleBackColor = true;
            // 
            // Btn_OK
            // 
            this.Btn_OK.AutoSize = true;
            this.Btn_OK.Checked = true;
            this.Btn_OK.Location = new System.Drawing.Point(6, 18);
            this.Btn_OK.Name = "Btn_OK";
            this.Btn_OK.Size = new System.Drawing.Size(38, 16);
            this.Btn_OK.TabIndex = 0;
            this.Btn_OK.TabStop = true;
            this.Btn_OK.Text = "OK";
            this.Btn_OK.UseVisualStyleBackColor = true;
            // 
            // Ico_None
            // 
            this.Ico_None.AutoSize = true;
            this.Ico_None.Checked = true;
            this.Ico_None.Location = new System.Drawing.Point(6, 18);
            this.Ico_None.Name = "Ico_None";
            this.Ico_None.Size = new System.Drawing.Size(49, 16);
            this.Ico_None.TabIndex = 0;
            this.Ico_None.TabStop = true;
            this.Ico_None.Text = "None";
            this.Ico_None.UseVisualStyleBackColor = true;
            // 
            // Ico_Ques
            // 
            this.Ico_Ques.AutoSize = true;
            this.Ico_Ques.Location = new System.Drawing.Point(6, 84);
            this.Ico_Ques.Name = "Ico_Ques";
            this.Ico_Ques.Size = new System.Drawing.Size(68, 16);
            this.Ico_Ques.TabIndex = 3;
            this.Ico_Ques.Text = "Question";
            this.Ico_Ques.UseVisualStyleBackColor = true;
            // 
            // Ico_Warn
            // 
            this.Ico_Warn.AutoSize = true;
            this.Ico_Warn.Location = new System.Drawing.Point(6, 62);
            this.Ico_Warn.Name = "Ico_Warn";
            this.Ico_Warn.Size = new System.Drawing.Size(48, 16);
            this.Ico_Warn.TabIndex = 2;
            this.Ico_Warn.Text = "Warn";
            this.Ico_Warn.UseVisualStyleBackColor = true;
            // 
            // Ico_Info
            // 
            this.Ico_Info.AutoSize = true;
            this.Ico_Info.Location = new System.Drawing.Point(6, 106);
            this.Ico_Info.Name = "Ico_Info";
            this.Ico_Info.Size = new System.Drawing.Size(42, 16);
            this.Ico_Info.TabIndex = 4;
            this.Ico_Info.Text = "Info";
            this.Ico_Info.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Ico_Info);
            this.groupBox1.Controls.Add(this.Ico_Ques);
            this.groupBox1.Controls.Add(this.Ico_Warn);
            this.groupBox1.Controls.Add(this.Ico_Error);
            this.groupBox1.Controls.Add(this.Ico_None);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(93, 155);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Icon";
            // 
            // Ico_Error
            // 
            this.Ico_Error.AutoSize = true;
            this.Ico_Error.Location = new System.Drawing.Point(6, 40);
            this.Ico_Error.Name = "Ico_Error";
            this.Ico_Error.Size = new System.Drawing.Size(48, 16);
            this.Ico_Error.TabIndex = 1;
            this.Ico_Error.Text = "Error";
            this.Ico_Error.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(277, 423);
            this.Controls.Add(this.Run);
            this.Controls.Add(this.ContentTextBox);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(293, 462);
            this.MinimumSize = new System.Drawing.Size(293, 462);
            this.Name = "Main";
            this.ShowIcon = false;
            this.Text = "EasyDialog-forLegacyOS";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Run;
        private System.Windows.Forms.RichTextBox ContentTextBox;
        private System.Windows.Forms.TextBox Title;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton Btn_AbReIg;
        private System.Windows.Forms.RadioButton Btn_RetryCan;
        private System.Windows.Forms.RadioButton Btn_YesNoCan;
        private System.Windows.Forms.RadioButton Btn_YesNo;
        private System.Windows.Forms.RadioButton Btn_OkCancel;
        private System.Windows.Forms.RadioButton Btn_OK;
        private System.Windows.Forms.RadioButton Ico_None;
        private System.Windows.Forms.RadioButton Ico_Ques;
        private System.Windows.Forms.RadioButton Ico_Warn;
        private System.Windows.Forms.RadioButton Ico_Info;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton Ico_Error;
    }
}

