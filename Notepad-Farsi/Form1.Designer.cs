namespace Notepad_Farsi
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel2 = new System.Windows.Forms.Panel();
            this.body = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.فایلToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.سندجدیدToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOpenDocument = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOpenNewWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuSave = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuPrint = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.ویرایشToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUndo = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCut = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.جستجوToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.جایگزینیToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuSelectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDatetime = new System.Windows.Forms.ToolStripMenuItem();
            this.قالببندیToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFont = new System.Windows.Forms.ToolStripMenuItem();
            this.رنگفونتToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.نماToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.نواروضعیتToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.جعبهابزارToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.راهنماToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel3 = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.body);
            this.panel2.Controls.Add(this.menuStrip1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(822, 406);
            this.panel2.TabIndex = 1;
            // 
            // body
            // 
            this.body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.body.Location = new System.Drawing.Point(0, 27);
            this.body.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.body.Name = "body";
            this.body.Size = new System.Drawing.Size(822, 379);
            this.body.TabIndex = 0;
            this.body.Text = "";
            this.body.TextChanged += new System.EventHandler(this.body_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.فایلToolStripMenuItem,
            this.ویرایشToolStripMenuItem,
            this.قالببندیToolStripMenuItem,
            this.نماToolStripMenuItem,
            this.راهنماToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(10, 4, 0, 4);
            this.menuStrip1.Size = new System.Drawing.Size(822, 27);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // فایلToolStripMenuItem
            // 
            this.فایلToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.سندجدیدToolStripMenuItem,
            this.mnuOpenDocument,
            this.mnuOpenNewWindow,
            this.toolStripSeparator1,
            this.mnuSave,
            this.mnuSaveAs,
            this.toolStripSeparator2,
            this.mnuPrint,
            this.toolStripSeparator3,
            this.mnuExit});
            this.فایلToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.فایلToolStripMenuItem.Name = "فایلToolStripMenuItem";
            this.فایلToolStripMenuItem.Size = new System.Drawing.Size(40, 19);
            this.فایلToolStripMenuItem.Text = "فایل";
            // 
            // سندجدیدToolStripMenuItem
            // 
            this.سندجدیدToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.سندجدیدToolStripMenuItem.Image = global::Notepad_Farsi.Properties.Resources.folder__1_;
            this.سندجدیدToolStripMenuItem.Name = "سندجدیدToolStripMenuItem";
            this.سندجدیدToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.سندجدیدToolStripMenuItem.Size = new System.Drawing.Size(242, 22);
            this.سندجدیدToolStripMenuItem.Text = "سند جدید";
            this.سندجدیدToolStripMenuItem.Click += new System.EventHandler(this.سندجدیدToolStripMenuItem_Click);
            // 
            // mnuOpenDocument
            // 
            this.mnuOpenDocument.Image = global::Notepad_Farsi.Properties.Resources.new_document1;
            this.mnuOpenDocument.Name = "mnuOpenDocument";
            this.mnuOpenDocument.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.mnuOpenDocument.Size = new System.Drawing.Size(242, 22);
            this.mnuOpenDocument.Text = "باز کردن سند";
            this.mnuOpenDocument.Click += new System.EventHandler(this.mnuOpenDocument_Click);
            // 
            // mnuOpenNewWindow
            // 
            this.mnuOpenNewWindow.Image = global::Notepad_Farsi.Properties.Resources.open_folder;
            this.mnuOpenNewWindow.Name = "mnuOpenNewWindow";
            this.mnuOpenNewWindow.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.N)));
            this.mnuOpenNewWindow.Size = new System.Drawing.Size(242, 22);
            this.mnuOpenNewWindow.Text = "باز کردن پنجره جدید";
            this.mnuOpenNewWindow.Click += new System.EventHandler(this.mnuOpenNewWindow_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(239, 6);
            // 
            // mnuSave
            // 
            this.mnuSave.Image = global::Notepad_Farsi.Properties.Resources.diskette;
            this.mnuSave.Name = "mnuSave";
            this.mnuSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.mnuSave.Size = new System.Drawing.Size(242, 22);
            this.mnuSave.Text = "ذخیره";
            this.mnuSave.Click += new System.EventHandler(this.mnuSave_Click);
            // 
            // mnuSaveAs
            // 
            this.mnuSaveAs.Image = global::Notepad_Farsi.Properties.Resources.save_as;
            this.mnuSaveAs.Name = "mnuSaveAs";
            this.mnuSaveAs.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.mnuSaveAs.Size = new System.Drawing.Size(242, 22);
            this.mnuSaveAs.Text = "ذخیره در...";
            this.mnuSaveAs.Click += new System.EventHandler(this.mnuSaveAs_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(239, 6);
            // 
            // mnuPrint
            // 
            this.mnuPrint.Image = global::Notepad_Farsi.Properties.Resources.printer;
            this.mnuPrint.Name = "mnuPrint";
            this.mnuPrint.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.mnuPrint.Size = new System.Drawing.Size(242, 22);
            this.mnuPrint.Text = "چاپ";
            this.mnuPrint.Click += new System.EventHandler(this.mnuPrint_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(239, 6);
            // 
            // mnuExit
            // 
            this.mnuExit.Image = global::Notepad_Farsi.Properties.Resources.exit;
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.mnuExit.Size = new System.Drawing.Size(242, 22);
            this.mnuExit.Text = "خروج از برنامه";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // ویرایشToolStripMenuItem
            // 
            this.ویرایشToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuUndo,
            this.mnuCopy,
            this.mnuPaste,
            this.mnuCut,
            this.toolStripSeparator4,
            this.جستجوToolStripMenuItem,
            this.جایگزینیToolStripMenuItem,
            this.toolStripSeparator5,
            this.mnuSelectAll,
            this.mnuDatetime});
            this.ویرایشToolStripMenuItem.Name = "ویرایشToolStripMenuItem";
            this.ویرایشToolStripMenuItem.Size = new System.Drawing.Size(55, 19);
            this.ویرایشToolStripMenuItem.Text = "ویرایش";
            // 
            // mnuUndo
            // 
            this.mnuUndo.Image = global::Notepad_Farsi.Properties.Resources.undo;
            this.mnuUndo.Name = "mnuUndo";
            this.mnuUndo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.mnuUndo.Size = new System.Drawing.Size(194, 22);
            this.mnuUndo.Text = "Undo";
            this.mnuUndo.Click += new System.EventHandler(this.واگردToolStripMenuItem_Click);
            // 
            // mnuCopy
            // 
            this.mnuCopy.Image = global::Notepad_Farsi.Properties.Resources.copy_two_paper_sheets_interface_symbol;
            this.mnuCopy.Name = "mnuCopy";
            this.mnuCopy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.mnuCopy.Size = new System.Drawing.Size(194, 22);
            this.mnuCopy.Text = "Copy";
            this.mnuCopy.Click += new System.EventHandler(this.چسباندنToolStripMenuItem_Click);
            // 
            // mnuPaste
            // 
            this.mnuPaste.Image = global::Notepad_Farsi.Properties.Resources.paste;
            this.mnuPaste.Name = "mnuPaste";
            this.mnuPaste.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.mnuPaste.Size = new System.Drawing.Size(194, 22);
            this.mnuPaste.Text = "Paste";
            this.mnuPaste.Click += new System.EventHandler(this.mnuPaste_Click);
            // 
            // mnuCut
            // 
            this.mnuCut.Image = global::Notepad_Farsi.Properties.Resources.scissors;
            this.mnuCut.Name = "mnuCut";
            this.mnuCut.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.mnuCut.Size = new System.Drawing.Size(194, 22);
            this.mnuCut.Text = "Cut";
            this.mnuCut.Click += new System.EventHandler(this.mnuCut_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(191, 6);
            // 
            // جستجوToolStripMenuItem
            // 
            this.جستجوToolStripMenuItem.Image = global::Notepad_Farsi.Properties.Resources.magnifying_glass;
            this.جستجوToolStripMenuItem.Name = "جستجوToolStripMenuItem";
            this.جستجوToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.جستجوToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.جستجوToolStripMenuItem.Text = "جستجو";
            // 
            // جایگزینیToolStripMenuItem
            // 
            this.جایگزینیToolStripMenuItem.Image = global::Notepad_Farsi.Properties.Resources.replace;
            this.جایگزینیToolStripMenuItem.Name = "جایگزینیToolStripMenuItem";
            this.جایگزینیToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.جایگزینیToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.جایگزینیToolStripMenuItem.Text = "جایگزینی";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(191, 6);
            // 
            // mnuSelectAll
            // 
            this.mnuSelectAll.Image = global::Notepad_Farsi.Properties.Resources.list;
            this.mnuSelectAll.Name = "mnuSelectAll";
            this.mnuSelectAll.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.mnuSelectAll.Size = new System.Drawing.Size(194, 22);
            this.mnuSelectAll.Text = "انتخاب همه متن";
            this.mnuSelectAll.Click += new System.EventHandler(this.mnuSelectAll_Click);
            // 
            // mnuDatetime
            // 
            this.mnuDatetime.Image = global::Notepad_Farsi.Properties.Resources.calendar;
            this.mnuDatetime.Name = "mnuDatetime";
            this.mnuDatetime.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.T)));
            this.mnuDatetime.Size = new System.Drawing.Size(194, 22);
            this.mnuDatetime.Text = "درج تاریخ";
            this.mnuDatetime.Click += new System.EventHandler(this.mnuDatetime_Click);
            // 
            // قالببندیToolStripMenuItem
            // 
            this.قالببندیToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFont,
            this.رنگفونتToolStripMenuItem});
            this.قالببندیToolStripMenuItem.Name = "قالببندیToolStripMenuItem";
            this.قالببندیToolStripMenuItem.Size = new System.Drawing.Size(69, 19);
            this.قالببندیToolStripMenuItem.Text = "قالب بندی";
            // 
            // mnuFont
            // 
            this.mnuFont.Image = global::Notepad_Farsi.Properties.Resources.font;
            this.mnuFont.Name = "mnuFont";
            this.mnuFont.Size = new System.Drawing.Size(180, 22);
            this.mnuFont.Text = "انتخاب فونت";
            this.mnuFont.Click += new System.EventHandler(this.mnuFont_Click);
            // 
            // رنگفونتToolStripMenuItem
            // 
            this.رنگفونتToolStripMenuItem.Image = global::Notepad_Farsi.Properties.Resources.eye_dropper;
            this.رنگفونتToolStripMenuItem.Name = "رنگفونتToolStripMenuItem";
            this.رنگفونتToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.رنگفونتToolStripMenuItem.Text = "رنگ فونت";
            // 
            // نماToolStripMenuItem
            // 
            this.نماToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.نواروضعیتToolStripMenuItem,
            this.جعبهابزارToolStripMenuItem});
            this.نماToolStripMenuItem.Name = "نماToolStripMenuItem";
            this.نماToolStripMenuItem.Size = new System.Drawing.Size(33, 19);
            this.نماToolStripMenuItem.Text = "نما";
            // 
            // نواروضعیتToolStripMenuItem
            // 
            this.نواروضعیتToolStripMenuItem.Checked = true;
            this.نواروضعیتToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.نواروضعیتToolStripMenuItem.Name = "نواروضعیتToolStripMenuItem";
            this.نواروضعیتToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.نواروضعیتToolStripMenuItem.Text = "نوار وضعیت";
            // 
            // جعبهابزارToolStripMenuItem
            // 
            this.جعبهابزارToolStripMenuItem.Checked = true;
            this.جعبهابزارToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.جعبهابزارToolStripMenuItem.Name = "جعبهابزارToolStripMenuItem";
            this.جعبهابزارToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.جعبهابزارToolStripMenuItem.Text = "جعبه ابزار";
            // 
            // راهنماToolStripMenuItem
            // 
            this.راهنماToolStripMenuItem.Name = "راهنماToolStripMenuItem";
            this.راهنماToolStripMenuItem.Size = new System.Drawing.Size(48, 19);
            this.راهنماToolStripMenuItem.Text = "راهنما";
            this.راهنماToolStripMenuItem.Click += new System.EventHandler(this.راهنماToolStripMenuItem_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.statusStrip1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 383);
            this.panel3.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(822, 23);
            this.panel3.TabIndex = 2;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3,
            this.toolStripStatusLabel4});
            this.statusStrip1.Location = new System.Drawing.Point(0, 1);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(24, 0, 1, 0);
            this.statusStrip1.Size = new System.Drawing.Size(822, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(70, 17);
            this.toolStripStatusLabel1.Text = "تعداد کاراکتر:";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(13, 17);
            this.toolStripStatusLabel2.Text = "0";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(70, 17);
            this.toolStripStatusLabel3.Text = "تعداد کلمات:";
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(13, 17);
            this.toolStripStatusLabel4.Text = "0";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "txt";
            this.saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            this.saveFileDialog1.Title = "ذخیره سند";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 406);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("B Yekan", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "دفترچه یادداشت";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RichTextBox body;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem فایلToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem سندجدیدToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuOpenDocument;
        private System.Windows.Forms.ToolStripMenuItem mnuOpenNewWindow;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mnuSave;
        private System.Windows.Forms.ToolStripMenuItem mnuSaveAs;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem mnuPrint;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem ویرایشToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuUndo;
        private System.Windows.Forms.ToolStripMenuItem mnuCopy;
        private System.Windows.Forms.ToolStripMenuItem mnuPaste;
        private System.Windows.Forms.ToolStripMenuItem mnuCut;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem جستجوToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem جایگزینیToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuSelectAll;
        private System.Windows.Forms.ToolStripMenuItem قالببندیToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuFont;
        private System.Windows.Forms.ToolStripMenuItem رنگفونتToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem نماToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem نواروضعیتToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem جعبهابزارToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem راهنماToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuDatetime;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintDialog printDialog1;
    }
}

