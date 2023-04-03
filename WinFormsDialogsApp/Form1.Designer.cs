namespace WinFormsDialogsApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            txtEditor = new TextBox();
            contextMenuEditor = new ContextMenuStrip(components);
            openToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem1 = new ToolStripMenuItem();
            saveAsToolStripMenuItem1 = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            cutToolStripMenuItem = new ToolStripMenuItem();
            copyToolStripMenuItem = new ToolStripMenuItem();
            pasteToolStripMenuItem = new ToolStripMenuItem();
            openFileDialog = new OpenFileDialog();
            btnOpenFile = new Button();
            btnSaveFile = new Button();
            saveFileDialog = new SaveFileDialog();
            btnFont = new Button();
            fontDialog = new FontDialog();
            btnBackColor = new Button();
            colorDialog = new ColorDialog();
            menuMain = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            newToolStripMenuItem = new ToolStripMenuItem();
            openStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            saveAsToolStripMenuItem = new ToolStripMenuItem();
            closeToolStripMenuItem = new ToolStripMenuItem();
            separatorStripMenuItem = new ToolStripSeparator();
            exitToolStripMenuItem = new ToolStripMenuItem();
            toolStrip1 = new ToolStrip();
            toolStripButton1 = new ToolStripButton();
            statusStrip = new StatusStrip();
            toolTip = new ToolTip(components);
            contextMenuEditor.SuspendLayout();
            menuMain.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // txtEditor
            // 
            txtEditor.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtEditor.ContextMenuStrip = contextMenuEditor;
            txtEditor.Location = new Point(0, 51);
            txtEditor.Multiline = true;
            txtEditor.Name = "txtEditor";
            txtEditor.ScrollBars = ScrollBars.Both;
            txtEditor.Size = new Size(800, 343);
            txtEditor.TabIndex = 0;
            toolTip.SetToolTip(txtEditor, "This is Editor of text");
            txtEditor.WordWrap = false;
            // 
            // contextMenuEditor
            // 
            contextMenuEditor.Items.AddRange(new ToolStripItem[] { openToolStripMenuItem, saveToolStripMenuItem1, saveAsToolStripMenuItem1, toolStripMenuItem1, cutToolStripMenuItem, copyToolStripMenuItem, pasteToolStripMenuItem });
            contextMenuEditor.Name = "contextMenuEditor";
            contextMenuEditor.Size = new Size(115, 142);
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(114, 22);
            openToolStripMenuItem.Text = "Open";
            // 
            // saveToolStripMenuItem1
            // 
            saveToolStripMenuItem1.Name = "saveToolStripMenuItem1";
            saveToolStripMenuItem1.Size = new Size(114, 22);
            saveToolStripMenuItem1.Text = "Save";
            // 
            // saveAsToolStripMenuItem1
            // 
            saveAsToolStripMenuItem1.Name = "saveAsToolStripMenuItem1";
            saveAsToolStripMenuItem1.Size = new Size(114, 22);
            saveAsToolStripMenuItem1.Text = "Save As";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(111, 6);
            // 
            // cutToolStripMenuItem
            // 
            cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            cutToolStripMenuItem.Size = new Size(114, 22);
            cutToolStripMenuItem.Text = "Cut";
            // 
            // copyToolStripMenuItem
            // 
            copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            copyToolStripMenuItem.Size = new Size(114, 22);
            copyToolStripMenuItem.Text = "Copy";
            // 
            // pasteToolStripMenuItem
            // 
            pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            pasteToolStripMenuItem.Size = new Size(114, 22);
            pasteToolStripMenuItem.Text = "Paste";
            // 
            // openFileDialog
            // 
            openFileDialog.FileName = "openFileDialog1";
            // 
            // btnOpenFile
            // 
            btnOpenFile.Location = new Point(12, 434);
            btnOpenFile.Name = "btnOpenFile";
            btnOpenFile.Size = new Size(75, 23);
            btnOpenFile.TabIndex = 1;
            btnOpenFile.Text = "Open File";
            toolTip.SetToolTip(btnOpenFile, "Open File for Editor");
            btnOpenFile.UseVisualStyleBackColor = true;
            btnOpenFile.Click += btnOpenFile_Click;
            // 
            // btnSaveFile
            // 
            btnSaveFile.Location = new Point(108, 434);
            btnSaveFile.Name = "btnSaveFile";
            btnSaveFile.Size = new Size(75, 23);
            btnSaveFile.TabIndex = 2;
            btnSaveFile.Text = "Save File";
            btnSaveFile.UseVisualStyleBackColor = true;
            btnSaveFile.Click += btnSaveFile_Click;
            // 
            // btnFont
            // 
            btnFont.Location = new Point(620, 434);
            btnFont.Name = "btnFont";
            btnFont.Size = new Size(75, 23);
            btnFont.TabIndex = 3;
            btnFont.Text = "Font";
            btnFont.UseVisualStyleBackColor = true;
            btnFont.Click += btnFont_Click;
            // 
            // btnBackColor
            // 
            btnBackColor.Location = new Point(713, 434);
            btnBackColor.Name = "btnBackColor";
            btnBackColor.Size = new Size(75, 23);
            btnBackColor.TabIndex = 4;
            btnBackColor.Text = "Back Color";
            btnBackColor.UseVisualStyleBackColor = true;
            btnBackColor.Click += btnBackColor_Click;
            // 
            // menuMain
            // 
            menuMain.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuMain.LayoutStyle = ToolStripLayoutStyle.Flow;
            menuMain.Location = new Point(0, 0);
            menuMain.Name = "menuMain";
            menuMain.Size = new Size(800, 23);
            menuMain.TabIndex = 5;
            menuMain.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newToolStripMenuItem, openStripMenuItem, saveToolStripMenuItem, saveAsToolStripMenuItem, closeToolStripMenuItem, separatorStripMenuItem, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 19);
            fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.Size = new Size(114, 22);
            newToolStripMenuItem.Text = "New";
            // 
            // openStripMenuItem
            // 
            openStripMenuItem.Name = "openStripMenuItem";
            openStripMenuItem.Size = new Size(114, 22);
            openStripMenuItem.Text = "Open";
            openStripMenuItem.Click += openStripMenuItem_Click;
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(114, 22);
            saveToolStripMenuItem.Text = "Save";
            // 
            // saveAsToolStripMenuItem
            // 
            saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            saveAsToolStripMenuItem.Size = new Size(114, 22);
            saveAsToolStripMenuItem.Text = "Save As";
            // 
            // closeToolStripMenuItem
            // 
            closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            closeToolStripMenuItem.Size = new Size(114, 22);
            closeToolStripMenuItem.Text = "Close";
            // 
            // separatorStripMenuItem
            // 
            separatorStripMenuItem.Name = "separatorStripMenuItem";
            separatorStripMenuItem.Size = new Size(111, 6);
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(114, 22);
            exitToolStripMenuItem.Text = "Exit";
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton1 });
            toolStrip1.Location = new Point(0, 23);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 25);
            toolStrip1.TabIndex = 6;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(23, 22);
            toolStripButton1.Text = "toolStripButton1";
            toolStripButton1.ToolTipText = "Open File";
            // 
            // statusStrip
            // 
            statusStrip.Location = new Point(0, 496);
            statusStrip.Name = "statusStrip";
            statusStrip.Size = new Size(800, 22);
            statusStrip.TabIndex = 7;
            statusStrip.Text = "statusStrip1";
            // 
            // toolTip
            // 
            toolTip.BackColor = Color.FromArgb(255, 192, 192);
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 518);
            Controls.Add(statusStrip);
            Controls.Add(toolStrip1);
            Controls.Add(btnBackColor);
            Controls.Add(btnFont);
            Controls.Add(btnSaveFile);
            Controls.Add(btnOpenFile);
            Controls.Add(txtEditor);
            Controls.Add(menuMain);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuMain;
            Name = "Form1";
            Text = "Блокнот";
            contextMenuEditor.ResumeLayout(false);
            menuMain.ResumeLayout(false);
            menuMain.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtEditor;
        private OpenFileDialog openFileDialog;
        private Button btnOpenFile;
        private Button btnSaveFile;
        private SaveFileDialog saveFileDialog;
        private Button btnFont;
        private FontDialog fontDialog;
        private Button btnBackColor;
        private ColorDialog colorDialog;
        private MenuStrip menuMain;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem openStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem saveAsToolStripMenuItem;
        private ToolStripMenuItem closeToolStripMenuItem;
        private ToolStripSeparator separatorStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStrip toolStrip1;
        private ContextMenuStrip contextMenuEditor;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem1;
        private ToolStripMenuItem saveAsToolStripMenuItem1;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem cutToolStripMenuItem;
        private ToolStripMenuItem copyToolStripMenuItem;
        private ToolStripMenuItem pasteToolStripMenuItem;
        private StatusStrip statusStrip;
        private ToolTip toolTip;
        private ToolStripButton toolStripButton1;
    }
}