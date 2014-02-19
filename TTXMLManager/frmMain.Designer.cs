namespace TTXMLManager
{
    partial class frmMain
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다.
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lstCategories = new System.Windows.Forms.ListBox();
            this.lstAttachments = new System.Windows.Forms.ListBox();
            this.lstArticles = new System.Windows.Forms.ListBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbtnOpen = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnAttachment = new System.Windows.Forms.ToolStripDropDownButton();
            this.첨부파일만추출ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.첨부파일추출및제거ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbtnCategory = new System.Windows.Forms.ToolStripDropDownButton();
            this.현재카테고리만추출ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.현재및하위카테고리추출ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tscboSplitSize = new System.Windows.Forms.ToolStripComboBox();
            this.tsbtnSplit = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnAbout = new System.Windows.Forms.ToolStripButton();
            this.tsProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.tsbtnCancel = new System.Windows.Forms.ToolStripButton();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.bgworkerScan = new System.ComponentModel.BackgroundWorker();
            this.tableLayoutPanel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.Controls.Add(this.lstCategories, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lstAttachments, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lstArticles, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(10, 40);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(1);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(755, 415);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // lstCategories
            // 
            this.lstCategories.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstCategories.FormattingEnabled = true;
            this.lstCategories.HorizontalScrollbar = true;
            this.lstCategories.ItemHeight = 12;
            this.lstCategories.Location = new System.Drawing.Point(3, 3);
            this.lstCategories.Name = "lstCategories";
            this.lstCategories.Size = new System.Drawing.Size(220, 304);
            this.lstCategories.TabIndex = 0;
            // 
            // lstAttachments
            // 
            this.lstAttachments.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.lstAttachments, 2);
            this.lstAttachments.FormattingEnabled = true;
            this.lstAttachments.ItemHeight = 12;
            this.lstAttachments.Location = new System.Drawing.Point(3, 314);
            this.lstAttachments.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.lstAttachments.Name = "lstAttachments";
            this.lstAttachments.Size = new System.Drawing.Size(749, 100);
            this.lstAttachments.TabIndex = 5;
            // 
            // lstArticles
            // 
            this.lstArticles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstArticles.FormattingEnabled = true;
            this.lstArticles.HorizontalScrollbar = true;
            this.lstArticles.ItemHeight = 12;
            this.lstArticles.Location = new System.Drawing.Point(229, 3);
            this.lstArticles.Name = "lstArticles";
            this.lstArticles.Size = new System.Drawing.Size(523, 304);
            this.lstArticles.TabIndex = 4;
            // 
            // toolStrip1
            // 
            this.toolStrip1.AllowMerge = false;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(26, 26);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnOpen,
            this.toolStripSeparator1,
            this.tsbtnAttachment,
            this.tsbtnCategory,
            this.toolStripSeparator2,
            this.tscboSplitSize,
            this.tsbtnSplit,
            this.toolStripSeparator3,
            this.tsbtnAbout,
            this.tsProgressBar,
            this.tsbtnCancel});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(2);
            this.toolStrip1.Size = new System.Drawing.Size(775, 37);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbtnOpen
            // 
            this.tsbtnOpen.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnOpen.Image")));
            this.tsbtnOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnOpen.Name = "tsbtnOpen";
            this.tsbtnOpen.Size = new System.Drawing.Size(61, 30);
            this.tsbtnOpen.Text = "열기";
            this.tsbtnOpen.ToolTipText = "작업할 TTXML 파일을 선택하고 기본 정보를 읽어옵니다.";
            this.tsbtnOpen.Click += new System.EventHandler(this.tsbtnOpen_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 33);
            // 
            // tsbtnAttachment
            // 
            this.tsbtnAttachment.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.첨부파일만추출ToolStripMenuItem,
            this.첨부파일추출및제거ToolStripMenuItem});
            this.tsbtnAttachment.Enabled = false;
            this.tsbtnAttachment.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnAttachment.Image")));
            this.tsbtnAttachment.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnAttachment.Name = "tsbtnAttachment";
            this.tsbtnAttachment.Size = new System.Drawing.Size(94, 30);
            this.tsbtnAttachment.Text = "첨부파일";
            this.tsbtnAttachment.ToolTipText = "첨부파일 관련 작업을 선택합니다.";
            // 
            // 첨부파일만추출ToolStripMenuItem
            // 
            this.첨부파일만추출ToolStripMenuItem.Name = "첨부파일만추출ToolStripMenuItem";
            this.첨부파일만추출ToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.첨부파일만추출ToolStripMenuItem.Text = "첨부파일만 추출";
            // 
            // 첨부파일추출및제거ToolStripMenuItem
            // 
            this.첨부파일추출및제거ToolStripMenuItem.Name = "첨부파일추출및제거ToolStripMenuItem";
            this.첨부파일추출및제거ToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.첨부파일추출및제거ToolStripMenuItem.Text = "첨부파일 추출 및 제거";
            // 
            // tsbtnCategory
            // 
            this.tsbtnCategory.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.현재카테고리만추출ToolStripMenuItem,
            this.현재및하위카테고리추출ToolStripMenuItem});
            this.tsbtnCategory.Enabled = false;
            this.tsbtnCategory.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnCategory.Image")));
            this.tsbtnCategory.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnCategory.Name = "tsbtnCategory";
            this.tsbtnCategory.Size = new System.Drawing.Size(94, 30);
            this.tsbtnCategory.Text = "카테고리";
            this.tsbtnCategory.ToolTipText = "카테고리 관련 작업을 선택합니다.";
            // 
            // 현재카테고리만추출ToolStripMenuItem
            // 
            this.현재카테고리만추출ToolStripMenuItem.Name = "현재카테고리만추출ToolStripMenuItem";
            this.현재카테고리만추출ToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.현재카테고리만추출ToolStripMenuItem.Text = "현재 카테고리만 추출";
            // 
            // 현재및하위카테고리추출ToolStripMenuItem
            // 
            this.현재및하위카테고리추출ToolStripMenuItem.Name = "현재및하위카테고리추출ToolStripMenuItem";
            this.현재및하위카테고리추출ToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.현재및하위카테고리추출ToolStripMenuItem.Text = "현재 및 하위 카테고리 추출";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 33);
            // 
            // tscboSplitSize
            // 
            this.tscboSplitSize.Items.AddRange(new object[] {
            "10 MB",
            "50 MB",
            "100 MB",
            "500 MB",
            "1 GB"});
            this.tscboSplitSize.Name = "tscboSplitSize";
            this.tscboSplitSize.Size = new System.Drawing.Size(75, 33);
            this.tscboSplitSize.Text = "100 MB";
            this.tscboSplitSize.ToolTipText = "분할된 파일들의 용량을 지정합니다.";
            // 
            // tsbtnSplit
            // 
            this.tsbtnSplit.Enabled = false;
            this.tsbtnSplit.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnSplit.Image")));
            this.tsbtnSplit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnSplit.Name = "tsbtnSplit";
            this.tsbtnSplit.Size = new System.Drawing.Size(89, 30);
            this.tsbtnSplit.Text = "용량 분할";
            this.tsbtnSplit.ToolTipText = "용량 분할 관련 작업을 선택합니다.";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 33);
            // 
            // tsbtnAbout
            // 
            this.tsbtnAbout.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnAbout.Image")));
            this.tsbtnAbout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnAbout.Name = "tsbtnAbout";
            this.tsbtnAbout.Size = new System.Drawing.Size(113, 30);
            this.tsbtnAbout.Text = "프로그램 정보";
            this.tsbtnAbout.ToolTipText = "프로그램 제작자와 라이선스에 대해 알아봅니다.";
            this.tsbtnAbout.Click += new System.EventHandler(this.tsbtnAbout_Click);
            // 
            // tsProgressBar
            // 
            this.tsProgressBar.AutoSize = false;
            this.tsProgressBar.Name = "tsProgressBar";
            this.tsProgressBar.Size = new System.Drawing.Size(100, 16);
            this.tsProgressBar.Visible = false;
            // 
            // tsbtnCancel
            // 
            this.tsbtnCancel.AutoSize = false;
            this.tsbtnCancel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnCancel.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnCancel.Image")));
            this.tsbtnCancel.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtnCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnCancel.Name = "tsbtnCancel";
            this.tsbtnCancel.Size = new System.Drawing.Size(16, 16);
            this.tsbtnCancel.Text = "작업 취소";
            this.tsbtnCancel.ToolTipText = "현재 진행 중인 작업을 중단합니다.";
            this.tsbtnCancel.Visible = false;
            this.tsbtnCancel.Click += new System.EventHandler(this.tsbtnCancel_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "TTXML 파일|*.xml|모든 파일|*.*";
            // 
            // bgworkerScan
            // 
            this.bgworkerScan.WorkerReportsProgress = true;
            this.bgworkerScan.WorkerSupportsCancellation = true;
            this.bgworkerScan.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgworkerScan_DoWork);
            this.bgworkerScan.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgworkerScan_ProgressChanged);
            this.bgworkerScan.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgworkerScan_RunWorkerCompleted);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 465);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmMain";
            this.Text = "Textcube TTXML 관리";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbtnOpen;
        private System.Windows.Forms.ListBox lstCategories;
        private System.Windows.Forms.ListBox lstArticles;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripDropDownButton tsbtnAttachment;
        private System.Windows.Forms.ToolStripMenuItem 첨부파일만추출ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 첨부파일추출및제거ToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton tsbtnCategory;
        private System.Windows.Forms.ToolStripMenuItem 현재카테고리만추출ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 현재및하위카테고리추출ToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox tscboSplitSize;
        private System.Windows.Forms.ToolStripButton tsbtnSplit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ListBox lstAttachments;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tsbtnAbout;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.ComponentModel.BackgroundWorker bgworkerScan;
        private System.Windows.Forms.ToolStripProgressBar tsProgressBar;
        private System.Windows.Forms.ToolStripButton tsbtnCancel;
    }
}

