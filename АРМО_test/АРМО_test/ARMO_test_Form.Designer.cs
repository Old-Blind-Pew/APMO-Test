namespace ARMO_test
{
    partial class ARMO_test_Form
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ARMO_test_Form));
            this.mainSplit = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ExitBut = new System.Windows.Forms.Button();
            this.PauseResumeBut = new System.Windows.Forms.Button();
            this.StartStopBut = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.NodeImageList = new System.Windows.Forms.ImageList(this.components);
            this.mainStatus = new System.Windows.Forms.StatusStrip();
            this.CountLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.SearchInLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.TimeLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.m_search_filter = new АРМО_test.Controls.SearchFilter();
            this.m_directorySource = new АРМО_test.Controls.DirectorySource();
            this.ResultView = new АРМО_test.Controls.UserTreeView();
            ((System.ComponentModel.ISupportInitialize)(this.mainSplit)).BeginInit();
            this.mainSplit.Panel1.SuspendLayout();
            this.mainSplit.Panel2.SuspendLayout();
            this.mainSplit.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.mainStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainSplit
            // 
            this.mainSplit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainSplit.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.mainSplit.IsSplitterFixed = true;
            this.mainSplit.Location = new System.Drawing.Point(0, 0);
            this.mainSplit.Name = "mainSplit";
            this.mainSplit.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // mainSplit.Panel1
            // 
            this.mainSplit.Panel1.Controls.Add(this.groupBox1);
            this.mainSplit.Panel1MinSize = 131;
            // 
            // mainSplit.Panel2
            // 
            this.mainSplit.Panel2.Controls.Add(this.groupBox2);
            this.mainSplit.Size = new System.Drawing.Size(670, 384);
            this.mainSplit.SplitterDistance = 131;
            this.mainSplit.SplitterWidth = 2;
            this.mainSplit.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ExitBut);
            this.groupBox1.Controls.Add(this.PauseResumeBut);
            this.groupBox1.Controls.Add(this.StartStopBut);
            this.groupBox1.Controls.Add(this.m_search_filter);
            this.groupBox1.Controls.Add(this.m_directorySource);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(670, 131);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Параметры поиска:";
            // 
            // ExitBut
            // 
            this.ExitBut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ExitBut.Location = new System.Drawing.Point(564, 88);
            this.ExitBut.Name = "ExitBut";
            this.ExitBut.Size = new System.Drawing.Size(94, 23);
            this.ExitBut.TabIndex = 4;
            this.ExitBut.Text = "Выход";
            this.ExitBut.UseVisualStyleBackColor = true;
            this.ExitBut.Click += new System.EventHandler(this.ExitBut_Click);
            // 
            // PauseResumeBut
            // 
            this.PauseResumeBut.Location = new System.Drawing.Point(184, 88);
            this.PauseResumeBut.Name = "PauseResumeBut";
            this.PauseResumeBut.Size = new System.Drawing.Size(157, 23);
            this.PauseResumeBut.TabIndex = 3;
            this.PauseResumeBut.UseVisualStyleBackColor = true;
            this.PauseResumeBut.Visible = false;
            this.PauseResumeBut.Click += new System.EventHandler(this.PauseResumeBut_Click);
            // 
            // StartStopBut
            // 
            this.StartStopBut.Location = new System.Drawing.Point(11, 88);
            this.StartStopBut.Name = "StartStopBut";
            this.StartStopBut.Size = new System.Drawing.Size(157, 23);
            this.StartStopBut.TabIndex = 2;
            this.StartStopBut.UseVisualStyleBackColor = true;
            this.StartStopBut.Click += new System.EventHandler(this.StartStopBut_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ResultView);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(670, 251);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Результат поиска:";
            // 
            // NodeImageList
            // 
            this.NodeImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("NodeImageList.ImageStream")));
            this.NodeImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.NodeImageList.Images.SetKeyName(0, "ClosedDir.ico");
            this.NodeImageList.Images.SetKeyName(1, "OpenedDir.ico");
            this.NodeImageList.Images.SetKeyName(2, "File.ico");
            // 
            // mainStatus
            // 
            this.mainStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CountLabel,
            this.SearchInLabel,
            this.TimeLabel});
            this.mainStatus.Location = new System.Drawing.Point(0, 384);
            this.mainStatus.Name = "mainStatus";
            this.mainStatus.ShowItemToolTips = true;
            this.mainStatus.Size = new System.Drawing.Size(670, 22);
            this.mainStatus.TabIndex = 1;
            // 
            // CountLabel
            // 
            this.CountLabel.AutoSize = false;
            this.CountLabel.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.CountLabel.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenInner;
            this.CountLabel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.CountLabel.Margin = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.CountLabel.Name = "CountLabel";
            this.CountLabel.Overflow = System.Windows.Forms.ToolStripItemOverflow.Always;
            this.CountLabel.Size = new System.Drawing.Size(180, 20);
            this.CountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SearchInLabel
            // 
            this.SearchInLabel.AutoSize = false;
            this.SearchInLabel.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.SearchInLabel.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenInner;
            this.SearchInLabel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.SearchInLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SearchInLabel.Name = "SearchInLabel";
            this.SearchInLabel.Size = new System.Drawing.Size(411, 22);
            this.SearchInLabel.Spring = true;
            this.SearchInLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SearchInLabel.ToolTipText = "Поиск в папке";
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = false;
            this.TimeLabel.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.TimeLabel.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenInner;
            this.TimeLabel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.TimeLabel.Margin = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Overflow = System.Windows.Forms.ToolStripItemOverflow.Always;
            this.TimeLabel.Size = new System.Drawing.Size(60, 20);
            this.TimeLabel.ToolTipText = "Прошло времени";
            // 
            // m_search_filter
            // 
            this.m_search_filter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.m_search_filter.Location = new System.Drawing.Point(6, 43);
            this.m_search_filter.Name = "m_search_filter";
            this.m_search_filter.Size = new System.Drawing.Size(652, 30);
            this.m_search_filter.TabIndex = 1;
            // 
            // m_directorySource
            // 
            this.m_directorySource.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.m_directorySource.Location = new System.Drawing.Point(6, 17);
            this.m_directorySource.Name = "m_directorySource";
            this.m_directorySource.Size = new System.Drawing.Size(652, 30);
            this.m_directorySource.TabIndex = 0;
            // 
            // ResultView
            // 
            this.ResultView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ResultView.FullRowSelect = true;
            this.ResultView.HideSelection = false;
            this.ResultView.Location = new System.Drawing.Point(3, 16);
            this.ResultView.Name = "ResultView";
            this.ResultView.Size = new System.Drawing.Size(664, 232);
            this.ResultView.StateImageList = this.NodeImageList;
            this.ResultView.TabIndex = 0;
            this.ResultView.AfterCollapse += new System.Windows.Forms.TreeViewEventHandler(this.ResultView_AfterCollapse);
            this.ResultView.AfterExpand += new System.Windows.Forms.TreeViewEventHandler(this.ResultView_AfterExpand);
            // 
            // ARMO_test_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 406);
            this.Controls.Add(this.mainSplit);
            this.Controls.Add(this.mainStatus);
            this.MinimumSize = new System.Drawing.Size(686, 445);
            this.Name = "ARMO_test_Form";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Тест для  ГК АРМО";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ARMO_test_Form_FormClosing);
            this.mainSplit.Panel1.ResumeLayout(false);
            this.mainSplit.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainSplit)).EndInit();
            this.mainSplit.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.mainStatus.ResumeLayout(false);
            this.mainStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer mainSplit;
        private System.Windows.Forms.StatusStrip mainStatus;
        private System.Windows.Forms.ToolStripStatusLabel CountLabel;
        private System.Windows.Forms.ToolStripStatusLabel SearchInLabel;
        private System.Windows.Forms.ToolStripStatusLabel TimeLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private АРМО_test.Controls.DirectorySource m_directorySource;
        private АРМО_test.Controls.SearchFilter m_search_filter;
        private System.Windows.Forms.Button PauseResumeBut;
        private System.Windows.Forms.Button StartStopBut;
        //private System.Windows.Forms.TreeView ResultView;
        private АРМО_test.Controls.UserTreeView ResultView;
        private System.Windows.Forms.ImageList NodeImageList;
        private System.Windows.Forms.Button ExitBut;

    }
}

