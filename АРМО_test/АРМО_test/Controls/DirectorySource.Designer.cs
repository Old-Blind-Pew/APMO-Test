namespace АРМО_test.Controls
{
    partial class DirectorySource
    {
        /// <summary> 
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Обязательный метод для поддержки конструктора - не изменяйте 
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.DirectorySourceText = new System.Windows.Forms.TextBox();
            this.DirectorySourceBrowse = new System.Windows.Forms.Button();
            this.DirectorySourceDlg = new System.DirectoryServices.DirectorySearcher();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DirectorySourceText
            // 
            this.DirectorySourceText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.DirectorySourceText.Location = new System.Drawing.Point(102, 5);
            this.DirectorySourceText.Name = "DirectorySourceText";
            this.DirectorySourceText.Size = new System.Drawing.Size(214, 20);
            this.DirectorySourceText.TabIndex = 0;
            // 
            // DirectorySourceBrowse
            // 
            this.DirectorySourceBrowse.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.DirectorySourceBrowse.Location = new System.Drawing.Point(320, 5);
            this.DirectorySourceBrowse.Name = "DirectorySourceBrowse";
            this.DirectorySourceBrowse.Size = new System.Drawing.Size(24, 20);
            this.DirectorySourceBrowse.TabIndex = 1;
            this.DirectorySourceBrowse.Text = "...";
            this.DirectorySourceBrowse.UseVisualStyleBackColor = true;
            this.DirectorySourceBrowse.Click += new System.EventHandler(this.DirectorySourceBrowse_Click);
            // 
            // DirectorySourceDlg
            // 
            this.DirectorySourceDlg.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.DirectorySourceDlg.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.DirectorySourceDlg.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Расположение:";
            // 
            // DirectorySource
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DirectorySourceBrowse);
            this.Controls.Add(this.DirectorySourceText);
            this.Name = "DirectorySource";
            this.Size = new System.Drawing.Size(352, 30);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DirectorySourceBrowse;
        private System.DirectoryServices.DirectorySearcher DirectorySourceDlg;
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.TextBox DirectorySourceText;
    }
}
