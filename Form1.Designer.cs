namespace sd9tool_front_end
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preferencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.elementsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileoutput = new System.Windows.Forms.TabPage();
            this.ConsoleOutput = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.txtSD9File = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SD9FileText = new System.Windows.Forms.Label();
            this.SD9FilePreview = new System.Windows.Forms.Button();
            this.TheFirst = new System.Windows.Forms.TabControl();
            this.modify = new System.Windows.Forms.TabPage();
            this.button14 = new System.Windows.Forms.Button();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.button13 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.overwriteask = new System.Windows.Forms.CheckBox();
            this.loopendvar = new System.Windows.Forms.TextBox();
            this.loopstartvar = new System.Windows.Forms.TextBox();
            this.loopendtext = new System.Windows.Forms.Label();
            this.looptext = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.loopstarttext = new System.Windows.Forms.Label();
            this.newaudiovol = new System.Windows.Forms.Label();
            this.newaudiovolvar = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.importwavbrowse = new System.Windows.Forms.Button();
            this.importwavpreview = new System.Windows.Forms.Button();
            this.importwavtext = new System.Windows.Forms.Label();
            this.importwavfield = new System.Windows.Forms.TextBox();
            this.transfer = new System.Windows.Forms.TabPage();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.sd9newfilebox = new System.Windows.Forms.TextBox();
            this.sd9origfilebox = new System.Windows.Forms.TextBox();
            this.sd9NewBox = new System.Windows.Forms.TextBox();
            this.s9newbuttonbrowse = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button9 = new System.Windows.Forms.Button();
            this.sd9OriginBox = new System.Windows.Forms.TextBox();
            this.sd9newbuttonbrowse = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.Settings = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.ffmpegpathbox = new System.Windows.Forms.TextBox();
            this.ffmpegbrowse = new System.Windows.Forms.Button();
            this.s9toolpathtext = new System.Windows.Forms.Label();
            this.s9toolpath = new System.Windows.Forms.TextBox();
            this.s9toolpathBrowse = new System.Windows.Forms.Button();
            this.PythonTextPath = new System.Windows.Forms.Label();
            this.PythonPath = new System.Windows.Forms.TextBox();
            this.BrowsePython = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.fileoutput.SuspendLayout();
            this.TheFirst.SuspendLayout();
            this.modify.SuspendLayout();
            this.transfer.SuspendLayout();
            this.Settings.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(759, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.newToolStripMenuItem.Text = "New";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.openToolStripMenuItem.Text = "Open...";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.saveAsToolStripMenuItem.Text = "Save As..";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.preferencesToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // preferencesToolStripMenuItem
            // 
            this.preferencesToolStripMenuItem.Name = "preferencesToolStripMenuItem";
            this.preferencesToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.preferencesToolStripMenuItem.Text = "Preferences";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.elementsToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            this.viewToolStripMenuItem.Click += new System.EventHandler(this.viewToolStripMenuItem_Click);
            // 
            // elementsToolStripMenuItem
            // 
            this.elementsToolStripMenuItem.Name = "elementsToolStripMenuItem";
            this.elementsToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.elementsToolStripMenuItem.Text = "Elements";
            // 
            // fileoutput
            // 
            this.fileoutput.Controls.Add(this.ConsoleOutput);
            this.fileoutput.Controls.Add(this.button3);
            this.fileoutput.Controls.Add(this.txtOutput);
            this.fileoutput.Controls.Add(this.txtSD9File);
            this.fileoutput.Controls.Add(this.button1);
            this.fileoutput.Controls.Add(this.SD9FileText);
            this.fileoutput.Controls.Add(this.SD9FilePreview);
            this.fileoutput.Location = new System.Drawing.Point(4, 22);
            this.fileoutput.Name = "fileoutput";
            this.fileoutput.Padding = new System.Windows.Forms.Padding(3);
            this.fileoutput.Size = new System.Drawing.Size(727, 390);
            this.fileoutput.TabIndex = 0;
            this.fileoutput.Text = "File output";
            this.fileoutput.UseVisualStyleBackColor = true;
            this.fileoutput.Click += new System.EventHandler(this.Main_Click);
            // 
            // ConsoleOutput
            // 
            this.ConsoleOutput.AutoSize = true;
            this.ConsoleOutput.Location = new System.Drawing.Point(13, 74);
            this.ConsoleOutput.Name = "ConsoleOutput";
            this.ConsoleOutput.Size = new System.Drawing.Size(78, 13);
            this.ConsoleOutput.TabIndex = 31;
            this.ConsoleOutput.Text = "Console output";
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Location = new System.Drawing.Point(416, 14);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 30;
            this.button3.Text = "Export wav";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // txtOutput
            // 
            this.txtOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOutput.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOutput.Location = new System.Drawing.Point(13, 93);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.Size = new System.Drawing.Size(708, 262);
            this.txtOutput.TabIndex = 26;
            // 
            // txtSD9File
            // 
            this.txtSD9File.Location = new System.Drawing.Point(75, 14);
            this.txtSD9File.Name = "txtSD9File";
            this.txtSD9File.Size = new System.Drawing.Size(254, 20);
            this.txtSD9File.TabIndex = 2;
            this.txtSD9File.TextChanged += new System.EventHandler(this.txtSD9File_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(335, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Browse";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SD9FileText
            // 
            this.SD9FileText.AutoSize = true;
            this.SD9FileText.Location = new System.Drawing.Point(22, 18);
            this.SD9FileText.Name = "SD9FileText";
            this.SD9FileText.Size = new System.Drawing.Size(47, 13);
            this.SD9FileText.TabIndex = 1;
            this.SD9FileText.Text = "SD9 File";
            this.SD9FileText.Click += new System.EventHandler(this.label1_Click);
            // 
            // SD9FilePreview
            // 
            this.SD9FilePreview.Location = new System.Drawing.Point(497, 14);
            this.SD9FilePreview.Name = "SD9FilePreview";
            this.SD9FilePreview.Size = new System.Drawing.Size(115, 23);
            this.SD9FilePreview.TabIndex = 23;
            this.SD9FilePreview.Text = "Export and Preview";
            this.SD9FilePreview.UseVisualStyleBackColor = true;
            this.SD9FilePreview.Click += new System.EventHandler(this.button5_Click);
            // 
            // TheFirst
            // 
            this.TheFirst.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TheFirst.Controls.Add(this.fileoutput);
            this.TheFirst.Controls.Add(this.modify);
            this.TheFirst.Controls.Add(this.transfer);
            this.TheFirst.Controls.Add(this.Settings);
            this.TheFirst.Location = new System.Drawing.Point(12, 33);
            this.TheFirst.Name = "TheFirst";
            this.TheFirst.SelectedIndex = 0;
            this.TheFirst.Size = new System.Drawing.Size(735, 416);
            this.TheFirst.TabIndex = 25;
            // 
            // modify
            // 
            this.modify.Controls.Add(this.button14);
            this.modify.Controls.Add(this.textBox10);
            this.modify.Controls.Add(this.button13);
            this.modify.Controls.Add(this.label7);
            this.modify.Controls.Add(this.overwriteask);
            this.modify.Controls.Add(this.loopendvar);
            this.modify.Controls.Add(this.loopstartvar);
            this.modify.Controls.Add(this.loopendtext);
            this.modify.Controls.Add(this.looptext);
            this.modify.Controls.Add(this.comboBox1);
            this.modify.Controls.Add(this.loopstarttext);
            this.modify.Controls.Add(this.newaudiovol);
            this.modify.Controls.Add(this.newaudiovolvar);
            this.modify.Controls.Add(this.button4);
            this.modify.Controls.Add(this.importwavbrowse);
            this.modify.Controls.Add(this.importwavpreview);
            this.modify.Controls.Add(this.importwavtext);
            this.modify.Controls.Add(this.importwavfield);
            this.modify.Location = new System.Drawing.Point(4, 22);
            this.modify.Name = "modify";
            this.modify.Padding = new System.Windows.Forms.Padding(3);
            this.modify.Size = new System.Drawing.Size(727, 390);
            this.modify.TabIndex = 1;
            this.modify.Text = "Modify";
            this.modify.UseVisualStyleBackColor = true;
            this.modify.Click += new System.EventHandler(this.Overdrive_Click);
            // 
            // button14
            // 
            this.button14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button14.Location = new System.Drawing.Point(573, 39);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(75, 23);
            this.button14.TabIndex = 47;
            this.button14.Text = "Preview";
            this.button14.UseVisualStyleBackColor = true;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(276, 39);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(210, 20);
            this.textBox10.TabIndex = 46;
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(492, 38);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(75, 23);
            this.button13.TabIndex = 44;
            this.button13.Text = "Browse";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(223, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 45;
            this.label7.Text = "SD9 File";
            // 
            // overwriteask
            // 
            this.overwriteask.AutoSize = true;
            this.overwriteask.Location = new System.Drawing.Point(221, 161);
            this.overwriteask.Name = "overwriteask";
            this.overwriteask.Size = new System.Drawing.Size(134, 17);
            this.overwriteask.TabIndex = 43;
            this.overwriteask.Text = "Overwrite file on save?";
            this.overwriteask.UseVisualStyleBackColor = true;
            // 
            // loopendvar
            // 
            this.loopendvar.Location = new System.Drawing.Point(24, 218);
            this.loopendvar.Name = "loopendvar";
            this.loopendvar.Size = new System.Drawing.Size(109, 20);
            this.loopendvar.TabIndex = 41;
            // 
            // loopstartvar
            // 
            this.loopstartvar.Location = new System.Drawing.Point(24, 158);
            this.loopstartvar.Name = "loopstartvar";
            this.loopstartvar.Size = new System.Drawing.Size(109, 20);
            this.loopstartvar.TabIndex = 40;
            // 
            // loopendtext
            // 
            this.loopendtext.AutoSize = true;
            this.loopendtext.Location = new System.Drawing.Point(21, 202);
            this.loopendtext.Name = "loopendtext";
            this.loopendtext.Size = new System.Drawing.Size(110, 13);
            this.loopendtext.TabIndex = 39;
            this.loopendtext.Text = "Loop end (in samples)";
            // 
            // looptext
            // 
            this.looptext.AutoSize = true;
            this.looptext.Location = new System.Drawing.Point(19, 87);
            this.looptext.Name = "looptext";
            this.looptext.Size = new System.Drawing.Size(47, 13);
            this.looptext.TabIndex = 36;
            this.looptext.Text = "It loops?";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "True",
            "False"});
            this.comboBox1.Location = new System.Drawing.Point(22, 103);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(134, 21);
            this.comboBox1.TabIndex = 37;
            // 
            // loopstarttext
            // 
            this.loopstarttext.AutoSize = true;
            this.loopstarttext.Location = new System.Drawing.Point(19, 142);
            this.loopstarttext.Name = "loopstarttext";
            this.loopstarttext.Size = new System.Drawing.Size(112, 13);
            this.loopstarttext.TabIndex = 38;
            this.loopstarttext.Text = "Loop start (in samples)";
            // 
            // newaudiovol
            // 
            this.newaudiovol.AutoSize = true;
            this.newaudiovol.Location = new System.Drawing.Point(19, 22);
            this.newaudiovol.Name = "newaudiovol";
            this.newaudiovol.Size = new System.Drawing.Size(137, 13);
            this.newaudiovol.TabIndex = 31;
            this.newaudiovol.Text = "New audio volume (0 - 125)";
            // 
            // newaudiovolvar
            // 
            this.newaudiovolvar.Location = new System.Drawing.Point(22, 41);
            this.newaudiovolvar.Name = "newaudiovolvar";
            this.newaudiovolvar.Size = new System.Drawing.Size(134, 20);
            this.newaudiovolvar.TabIndex = 32;
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.Location = new System.Drawing.Point(646, 361);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 30;
            this.button4.Text = "Save SD9";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // importwavbrowse
            // 
            this.importwavbrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.importwavbrowse.Location = new System.Drawing.Point(492, 98);
            this.importwavbrowse.Name = "importwavbrowse";
            this.importwavbrowse.Size = new System.Drawing.Size(75, 23);
            this.importwavbrowse.TabIndex = 27;
            this.importwavbrowse.Text = "Browse";
            this.importwavbrowse.UseVisualStyleBackColor = true;
            this.importwavbrowse.Click += new System.EventHandler(this.importwavbrowse_Click);
            // 
            // importwavpreview
            // 
            this.importwavpreview.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.importwavpreview.Location = new System.Drawing.Point(573, 98);
            this.importwavpreview.Name = "importwavpreview";
            this.importwavpreview.Size = new System.Drawing.Size(75, 23);
            this.importwavpreview.TabIndex = 28;
            this.importwavpreview.Text = "Preview";
            this.importwavpreview.UseVisualStyleBackColor = true;
            // 
            // importwavtext
            // 
            this.importwavtext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.importwavtext.AutoSize = true;
            this.importwavtext.Location = new System.Drawing.Point(218, 103);
            this.importwavtext.Name = "importwavtext";
            this.importwavtext.Size = new System.Drawing.Size(59, 13);
            this.importwavtext.TabIndex = 25;
            this.importwavtext.Text = "Import wav";
            // 
            // importwavfield
            // 
            this.importwavfield.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.importwavfield.Location = new System.Drawing.Point(276, 100);
            this.importwavfield.Name = "importwavfield";
            this.importwavfield.Size = new System.Drawing.Size(210, 20);
            this.importwavfield.TabIndex = 26;
            // 
            // transfer
            // 
            this.transfer.Controls.Add(this.button11);
            this.transfer.Controls.Add(this.button10);
            this.transfer.Controls.Add(this.label5);
            this.transfer.Controls.Add(this.label4);
            this.transfer.Controls.Add(this.sd9newfilebox);
            this.transfer.Controls.Add(this.sd9origfilebox);
            this.transfer.Controls.Add(this.sd9NewBox);
            this.transfer.Controls.Add(this.s9newbuttonbrowse);
            this.transfer.Controls.Add(this.label3);
            this.transfer.Controls.Add(this.button9);
            this.transfer.Controls.Add(this.sd9OriginBox);
            this.transfer.Controls.Add(this.sd9newbuttonbrowse);
            this.transfer.Controls.Add(this.label2);
            this.transfer.Controls.Add(this.button7);
            this.transfer.Location = new System.Drawing.Point(4, 22);
            this.transfer.Name = "transfer";
            this.transfer.Padding = new System.Windows.Forms.Padding(3);
            this.transfer.Size = new System.Drawing.Size(727, 390);
            this.transfer.TabIndex = 3;
            this.transfer.Text = "Transfer";
            this.transfer.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button11.Location = new System.Drawing.Point(605, 361);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(105, 23);
            this.button11.TabIndex = 37;
            this.button11.Text = "Save new  SD9";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(332, 215);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(75, 23);
            this.button10.TabIndex = 36;
            this.button10.Text = "Transfer!";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(419, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 13);
            this.label5.TabIndex = 35;
            this.label5.Text = "SD9 New File Settings";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 13);
            this.label4.TabIndex = 34;
            this.label4.Text = "SD9 Origin File Settings";
            // 
            // sd9newfilebox
            // 
            this.sd9newfilebox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sd9newfilebox.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sd9newfilebox.Location = new System.Drawing.Point(422, 130);
            this.sd9newfilebox.Multiline = true;
            this.sd9newfilebox.Name = "sd9newfilebox";
            this.sd9newfilebox.ReadOnly = true;
            this.sd9newfilebox.Size = new System.Drawing.Size(288, 218);
            this.sd9newfilebox.TabIndex = 33;
            // 
            // sd9origfilebox
            // 
            this.sd9origfilebox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sd9origfilebox.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sd9origfilebox.Location = new System.Drawing.Point(29, 130);
            this.sd9origfilebox.Multiline = true;
            this.sd9origfilebox.Name = "sd9origfilebox";
            this.sd9origfilebox.ReadOnly = true;
            this.sd9origfilebox.Size = new System.Drawing.Size(288, 218);
            this.sd9origfilebox.TabIndex = 32;
            this.sd9origfilebox.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // sd9NewBox
            // 
            this.sd9NewBox.Location = new System.Drawing.Point(122, 63);
            this.sd9NewBox.Name = "sd9NewBox";
            this.sd9NewBox.Size = new System.Drawing.Size(254, 20);
            this.sd9NewBox.TabIndex = 30;
            // 
            // s9newbuttonbrowse
            // 
            this.s9newbuttonbrowse.Location = new System.Drawing.Point(382, 62);
            this.s9newbuttonbrowse.Name = "s9newbuttonbrowse";
            this.s9newbuttonbrowse.Size = new System.Drawing.Size(75, 23);
            this.s9newbuttonbrowse.TabIndex = 28;
            this.s9newbuttonbrowse.Text = "Browse";
            this.s9newbuttonbrowse.UseVisualStyleBackColor = true;
            this.s9newbuttonbrowse.Click += new System.EventHandler(this.s9newbuttonbrowse_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "SD9 New File";
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(472, 62);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 23);
            this.button9.TabIndex = 31;
            this.button9.Text = "Preview";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // sd9OriginBox
            // 
            this.sd9OriginBox.Location = new System.Drawing.Point(122, 24);
            this.sd9OriginBox.Name = "sd9OriginBox";
            this.sd9OriginBox.Size = new System.Drawing.Size(254, 20);
            this.sd9OriginBox.TabIndex = 26;
            // 
            // sd9newbuttonbrowse
            // 
            this.sd9newbuttonbrowse.Location = new System.Drawing.Point(382, 22);
            this.sd9newbuttonbrowse.Name = "sd9newbuttonbrowse";
            this.sd9newbuttonbrowse.Size = new System.Drawing.Size(75, 23);
            this.sd9newbuttonbrowse.TabIndex = 24;
            this.sd9newbuttonbrowse.Text = "Browse";
            this.sd9newbuttonbrowse.UseVisualStyleBackColor = true;
            this.sd9newbuttonbrowse.Click += new System.EventHandler(this.sd9newbuttonbrowse_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "SD9 Origin File";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(472, 22);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 27;
            this.button7.Text = "Preview";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // Settings
            // 
            this.Settings.Controls.Add(this.label6);
            this.Settings.Controls.Add(this.ffmpegpathbox);
            this.Settings.Controls.Add(this.ffmpegbrowse);
            this.Settings.Controls.Add(this.s9toolpathtext);
            this.Settings.Controls.Add(this.s9toolpath);
            this.Settings.Controls.Add(this.s9toolpathBrowse);
            this.Settings.Controls.Add(this.PythonTextPath);
            this.Settings.Controls.Add(this.PythonPath);
            this.Settings.Controls.Add(this.BrowsePython);
            this.Settings.Location = new System.Drawing.Point(4, 22);
            this.Settings.Name = "Settings";
            this.Settings.Padding = new System.Windows.Forms.Padding(3);
            this.Settings.Size = new System.Drawing.Size(727, 390);
            this.Settings.TabIndex = 4;
            this.Settings.Text = "Settings";
            this.Settings.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 101);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "ffmpeg path";
            // 
            // ffmpegpathbox
            // 
            this.ffmpegpathbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ffmpegpathbox.Location = new System.Drawing.Point(125, 98);
            this.ffmpegpathbox.Name = "ffmpegpathbox";
            this.ffmpegpathbox.Size = new System.Drawing.Size(499, 20);
            this.ffmpegpathbox.TabIndex = 7;
            // 
            // ffmpegbrowse
            // 
            this.ffmpegbrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ffmpegbrowse.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ffmpegbrowse.Location = new System.Drawing.Point(630, 98);
            this.ffmpegbrowse.Name = "ffmpegbrowse";
            this.ffmpegbrowse.Size = new System.Drawing.Size(75, 23);
            this.ffmpegbrowse.TabIndex = 6;
            this.ffmpegbrowse.Text = "Browse";
            this.ffmpegbrowse.UseVisualStyleBackColor = true;
            // 
            // s9toolpathtext
            // 
            this.s9toolpathtext.AutoSize = true;
            this.s9toolpathtext.Location = new System.Drawing.Point(17, 60);
            this.s9toolpathtext.Name = "s9toolpathtext";
            this.s9toolpathtext.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.s9toolpathtext.Size = new System.Drawing.Size(92, 13);
            this.s9toolpathtext.TabIndex = 5;
            this.s9toolpathtext.Text = "SD9Tools.py path";
            // 
            // s9toolpath
            // 
            this.s9toolpath.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.s9toolpath.Location = new System.Drawing.Point(125, 57);
            this.s9toolpath.Name = "s9toolpath";
            this.s9toolpath.Size = new System.Drawing.Size(499, 20);
            this.s9toolpath.TabIndex = 4;
            // 
            // s9toolpathBrowse
            // 
            this.s9toolpathBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.s9toolpathBrowse.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.s9toolpathBrowse.Location = new System.Drawing.Point(630, 57);
            this.s9toolpathBrowse.Name = "s9toolpathBrowse";
            this.s9toolpathBrowse.Size = new System.Drawing.Size(75, 23);
            this.s9toolpathBrowse.TabIndex = 3;
            this.s9toolpathBrowse.Text = "Browse";
            this.s9toolpathBrowse.UseVisualStyleBackColor = true;
            this.s9toolpathBrowse.Click += new System.EventHandler(this.s9toolpathBrowse_Click);
            // 
            // PythonTextPath
            // 
            this.PythonTextPath.AutoSize = true;
            this.PythonTextPath.Location = new System.Drawing.Point(45, 21);
            this.PythonTextPath.Name = "PythonTextPath";
            this.PythonTextPath.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.PythonTextPath.Size = new System.Drawing.Size(64, 13);
            this.PythonTextPath.TabIndex = 2;
            this.PythonTextPath.Text = "Python path";
            // 
            // PythonPath
            // 
            this.PythonPath.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PythonPath.Location = new System.Drawing.Point(125, 18);
            this.PythonPath.Name = "PythonPath";
            this.PythonPath.Size = new System.Drawing.Size(499, 20);
            this.PythonPath.TabIndex = 1;
            // 
            // BrowsePython
            // 
            this.BrowsePython.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BrowsePython.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BrowsePython.Location = new System.Drawing.Point(630, 16);
            this.BrowsePython.Name = "BrowsePython";
            this.BrowsePython.Size = new System.Drawing.Size(75, 23);
            this.BrowsePython.TabIndex = 0;
            this.BrowsePython.Text = "Browse";
            this.BrowsePython.UseVisualStyleBackColor = true;
            this.BrowsePython.Click += new System.EventHandler(this.BrowsePython_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 461);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.TheFirst);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(775, 500);
            this.MinimumSize = new System.Drawing.Size(775, 500);
            this.Name = "Form1";
            this.Text = "SD9 Tools front-end";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.fileoutput.ResumeLayout(false);
            this.fileoutput.PerformLayout();
            this.TheFirst.ResumeLayout(false);
            this.modify.ResumeLayout(false);
            this.modify.PerformLayout();
            this.transfer.ResumeLayout(false);
            this.transfer.PerformLayout();
            this.Settings.ResumeLayout(false);
            this.Settings.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem preferencesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem elementsToolStripMenuItem;
        private System.Windows.Forms.TabPage fileoutput;
        private System.Windows.Forms.TextBox txtSD9File;
        private System.Windows.Forms.Label SD9FileText;
        private System.Windows.Forms.Button SD9FilePreview;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.TabPage modify;
        private System.Windows.Forms.Button importwavbrowse;
        private System.Windows.Forms.Button importwavpreview;
        private System.Windows.Forms.Label importwavtext;
        private System.Windows.Forms.TextBox importwavfield;
        private System.Windows.Forms.TabControl TheFirst;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label newaudiovol;
        private System.Windows.Forms.TextBox newaudiovolvar;
        private System.Windows.Forms.TextBox loopendvar;
        private System.Windows.Forms.TextBox loopstartvar;
        private System.Windows.Forms.Label loopendtext;
        private System.Windows.Forms.Label looptext;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label loopstarttext;
        private System.Windows.Forms.TabPage Settings;
        private System.Windows.Forms.Label s9toolpathtext;
        private System.Windows.Forms.TextBox s9toolpath;
        private System.Windows.Forms.Button s9toolpathBrowse;
        private System.Windows.Forms.Label PythonTextPath;
        private System.Windows.Forms.TextBox PythonPath;
        private System.Windows.Forms.Button BrowsePython;
        private System.Windows.Forms.TabPage transfer;
        private System.Windows.Forms.TextBox sd9origfilebox;
        private System.Windows.Forms.TextBox sd9NewBox;
        private System.Windows.Forms.Button s9newbuttonbrowse;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.TextBox sd9OriginBox;
        private System.Windows.Forms.Button sd9newbuttonbrowse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox sd9newfilebox;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox overwriteask;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ffmpegpathbox;
        private System.Windows.Forms.Button ffmpegbrowse;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Label ConsoleOutput;
    }
}

