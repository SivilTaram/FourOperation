

using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.skinToolTip1 = new CCWin.SkinToolTip(this.components);
            this.skinMenuStrip1 = new CCWin.SkinControl.SkinMenuStrip();
            this.开始ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.更改Gradetxt生成路径ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.更改Exercisetxt生成路径ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.更改Answertxt生成路径ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPageCheck = new System.Windows.Forms.TabPage();
            this.DisGradeBox = new CCWin.SkinControl.SkinTextBox();
            this.ExeText = new System.Windows.Forms.TextBox();
            this.AnswerText = new System.Windows.Forms.TextBox();
            this.skinButton1 = new CCWin.SkinControl.SkinButton();
            this.ExeButton = new CCWin.SkinControl.SkinButton();
            this.AnswerButton = new CCWin.SkinControl.SkinButton();
            this.tabPageGen = new System.Windows.Forms.TabPage();
            this.GenPage = new CCWin.SkinControl.SkinPanel();
            this.GenProgressIndicator = new CCWin.SkinControl.SkinProgressIndicator();
            this.ExeCountList = new CCWin.SkinControl.SkinNumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.HasFracCheck = new CCWin.SkinControl.SkinCheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.HasMultDivCheck = new CCWin.SkinControl.SkinCheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.HasBrackCheck = new CCWin.SkinControl.SkinCheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rightRange = new CCWin.SkinControl.SkinNumericUpDown();
            this.leftRange = new CCWin.SkinControl.SkinNumericUpDown();
            this.GenButton = new CCWin.SkinControl.SkinButton();
            this.OpCountList = new CCWin.SkinControl.SkinNumericUpDown();
            this.HasNegCheck = new CCWin.SkinControl.SkinCheckBox();
            this.ExeAnsTextBox = new CCWin.SkinControl.SkinTextBox();
            this.PageSet = new System.Windows.Forms.TabControl();
            this.tabPageCalc = new System.Windows.Forms.TabPage();
            this.rtfRichTextBox1 = new CCWin.SkinControl.RtfRichTextBox();
            this.calcTextBox = new CCWin.SkinControl.SkinTextBox();
            this.calcButtonDelete = new CCWin.SkinControl.SkinButton();
            this.calcButtonRBrack = new CCWin.SkinControl.SkinButton();
            this.calcButtonLBrack = new CCWin.SkinControl.SkinButton();
            this.calcButtonResult = new CCWin.SkinControl.SkinButton();
            this.calcButtonClean = new CCWin.SkinControl.SkinButton();
            this.calcButtonSub = new CCWin.SkinControl.SkinButton();
            this.calcButtonAdd = new CCWin.SkinControl.SkinButton();
            this.calcButtonMult = new CCWin.SkinControl.SkinButton();
            this.calcButtonDiv = new CCWin.SkinControl.SkinButton();
            this.calcButtonQuestion = new CCWin.SkinControl.SkinButton();
            this.calcButtonQuote = new CCWin.SkinControl.SkinButton();
            this.calcButton0 = new CCWin.SkinControl.SkinButton();
            this.calcButton3 = new CCWin.SkinControl.SkinButton();
            this.calcButton2 = new CCWin.SkinControl.SkinButton();
            this.calcButton1 = new CCWin.SkinControl.SkinButton();
            this.calcButton6 = new CCWin.SkinControl.SkinButton();
            this.calcButton5 = new CCWin.SkinControl.SkinButton();
            this.calcButton4 = new CCWin.SkinControl.SkinButton();
            this.calcButton9 = new CCWin.SkinControl.SkinButton();
            this.calcButton8 = new CCWin.SkinControl.SkinButton();
            this.calcButton7 = new CCWin.SkinControl.SkinButton();
            this.GradeFolderDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.skinMenuStrip1.SuspendLayout();
            this.tabPageCheck.SuspendLayout();
            this.tabPageGen.SuspendLayout();
            this.GenPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExeCountList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightRange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftRange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OpCountList)).BeginInit();
            this.PageSet.SuspendLayout();
            this.tabPageCalc.SuspendLayout();
            this.SuspendLayout();
            // 
            // skinToolTip1
            // 
            this.skinToolTip1.AutoPopDelay = 5000;
            this.skinToolTip1.InitialDelay = 500;
            this.skinToolTip1.OwnerDraw = true;
            this.skinToolTip1.ReshowDelay = 800;
            this.skinToolTip1.ShowAlways = true;
            this.skinToolTip1.ToolTipTitle = "格式说明：";
            // 
            // skinMenuStrip1
            // 
            this.skinMenuStrip1.Arrow = System.Drawing.Color.Black;
            this.skinMenuStrip1.Back = System.Drawing.Color.White;
            this.skinMenuStrip1.BackRadius = 4;
            this.skinMenuStrip1.BackRectangle = new System.Drawing.Rectangle(10, 10, 10, 10);
            this.skinMenuStrip1.Base = System.Drawing.Color.White;
            this.skinMenuStrip1.BaseFore = System.Drawing.Color.Black;
            this.skinMenuStrip1.BaseForeAnamorphosis = false;
            this.skinMenuStrip1.BaseForeAnamorphosisBorder = 4;
            this.skinMenuStrip1.BaseForeAnamorphosisColor = System.Drawing.Color.White;
            this.skinMenuStrip1.BaseHoverFore = System.Drawing.Color.White;
            this.skinMenuStrip1.BaseItemAnamorphosis = true;
            this.skinMenuStrip1.BaseItemBorder = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.skinMenuStrip1.BaseItemBorderShow = true;
            this.skinMenuStrip1.BaseItemDown = ((System.Drawing.Image)(resources.GetObject("skinMenuStrip1.BaseItemDown")));
            this.skinMenuStrip1.BaseItemHover = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.skinMenuStrip1.BaseItemMouse = ((System.Drawing.Image)(resources.GetObject("skinMenuStrip1.BaseItemMouse")));
            this.skinMenuStrip1.BaseItemPressed = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.skinMenuStrip1.BaseItemRadius = 4;
            this.skinMenuStrip1.BaseItemRadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinMenuStrip1.BaseItemSplitter = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.skinMenuStrip1.DropDownImageSeparator = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.skinMenuStrip1.Fore = System.Drawing.Color.Black;
            this.skinMenuStrip1.HoverFore = System.Drawing.Color.White;
            this.skinMenuStrip1.ItemAnamorphosis = true;
            this.skinMenuStrip1.ItemBorder = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.skinMenuStrip1.ItemBorderShow = true;
            this.skinMenuStrip1.ItemHover = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.skinMenuStrip1.ItemPressed = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.skinMenuStrip1.ItemRadius = 4;
            this.skinMenuStrip1.ItemRadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.开始ToolStripMenuItem,
            this.关于ToolStripMenuItem,
            this.帮助ToolStripMenuItem});
            this.skinMenuStrip1.Location = new System.Drawing.Point(4, 28);
            this.skinMenuStrip1.Name = "skinMenuStrip1";
            this.skinMenuStrip1.RadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinMenuStrip1.Size = new System.Drawing.Size(635, 24);
            this.skinMenuStrip1.SkinAllColor = true;
            this.skinMenuStrip1.TabIndex = 1;
            this.skinMenuStrip1.Text = "skinMenuStrip1";
            this.skinMenuStrip1.TitleAnamorphosis = true;
            this.skinMenuStrip1.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(228)))), ((int)(((byte)(236)))));
            this.skinMenuStrip1.TitleRadius = 4;
            this.skinMenuStrip1.TitleRadiusStyle = CCWin.SkinClass.RoundStyle.All;
            // 
            // 开始ToolStripMenuItem
            // 
            this.开始ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.更改Gradetxt生成路径ToolStripMenuItem,
            this.更改Exercisetxt生成路径ToolStripMenuItem,
            this.更改Answertxt生成路径ToolStripMenuItem});
            this.开始ToolStripMenuItem.Name = "开始ToolStripMenuItem";
            this.开始ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.开始ToolStripMenuItem.Text = "开始";
            // 
            // 更改Gradetxt生成路径ToolStripMenuItem
            // 
            this.更改Gradetxt生成路径ToolStripMenuItem.Name = "更改Gradetxt生成路径ToolStripMenuItem";
            this.更改Gradetxt生成路径ToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.更改Gradetxt生成路径ToolStripMenuItem.Text = "更改Grade.txt生成路径";
            this.更改Gradetxt生成路径ToolStripMenuItem.Click += new System.EventHandler(this.更改Gradetxt生成路径ToolStripMenuItem_Click);
            // 
            // 更改Exercisetxt生成路径ToolStripMenuItem
            // 
            this.更改Exercisetxt生成路径ToolStripMenuItem.Name = "更改Exercisetxt生成路径ToolStripMenuItem";
            this.更改Exercisetxt生成路径ToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.更改Exercisetxt生成路径ToolStripMenuItem.Text = "更改Exercise.txt生成路径";
            this.更改Exercisetxt生成路径ToolStripMenuItem.Click += new System.EventHandler(this.更改Exercisetxt生成路径ToolStripMenuItem_Click);
            // 
            // 更改Answertxt生成路径ToolStripMenuItem
            // 
            this.更改Answertxt生成路径ToolStripMenuItem.Name = "更改Answertxt生成路径ToolStripMenuItem";
            this.更改Answertxt生成路径ToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.更改Answertxt生成路径ToolStripMenuItem.Text = "更改Answer.txt生成路径";
            this.更改Answertxt生成路径ToolStripMenuItem.Click += new System.EventHandler(this.更改Answertxt生成路径ToolStripMenuItem_Click);
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.关于ToolStripMenuItem.Text = "关于";
            this.关于ToolStripMenuItem.Click += new System.EventHandler(this.关于ToolStripMenuItem_Click);
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.帮助ToolStripMenuItem.Text = "帮助";
            this.帮助ToolStripMenuItem.Click += new System.EventHandler(this.帮助ToolStripMenuItem_Click);
            // 
            // tabPageCheck
            // 
            this.tabPageCheck.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPageCheck.Controls.Add(this.DisGradeBox);
            this.tabPageCheck.Controls.Add(this.ExeText);
            this.tabPageCheck.Controls.Add(this.AnswerText);
            this.tabPageCheck.Controls.Add(this.skinButton1);
            this.tabPageCheck.Controls.Add(this.ExeButton);
            this.tabPageCheck.Controls.Add(this.AnswerButton);
            this.tabPageCheck.Location = new System.Drawing.Point(4, 29);
            this.tabPageCheck.Name = "tabPageCheck";
            this.tabPageCheck.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCheck.Size = new System.Drawing.Size(627, 279);
            this.tabPageCheck.TabIndex = 1;
            this.tabPageCheck.Text = "检查答案";
            this.tabPageCheck.UseVisualStyleBackColor = true;
            // 
            // DisGradeBox
            // 
            this.DisGradeBox.BackColor = System.Drawing.Color.Transparent;
            this.DisGradeBox.DownBack = null;
            this.DisGradeBox.Icon = null;
            this.DisGradeBox.IconIsButton = false;
            this.DisGradeBox.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.DisGradeBox.IsPasswordChat = '\0';
            this.DisGradeBox.IsSystemPasswordChar = false;
            this.DisGradeBox.Lines = new string[0];
            this.DisGradeBox.Location = new System.Drawing.Point(45, 154);
            this.DisGradeBox.Margin = new System.Windows.Forms.Padding(0);
            this.DisGradeBox.MaxLength = 32767;
            this.DisGradeBox.MinimumSize = new System.Drawing.Size(28, 28);
            this.DisGradeBox.MouseBack = null;
            this.DisGradeBox.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.DisGradeBox.Multiline = true;
            this.DisGradeBox.Name = "DisGradeBox";
            this.DisGradeBox.NormlBack = null;
            this.DisGradeBox.Padding = new System.Windows.Forms.Padding(5);
            this.DisGradeBox.ReadOnly = false;
            this.DisGradeBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.DisGradeBox.Size = new System.Drawing.Size(510, 108);
            // 
            // 
            // 
            this.DisGradeBox.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DisGradeBox.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DisGradeBox.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.DisGradeBox.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.DisGradeBox.SkinTxt.Multiline = true;
            this.DisGradeBox.SkinTxt.Name = "BaseText";
            this.DisGradeBox.SkinTxt.Size = new System.Drawing.Size(500, 98);
            this.DisGradeBox.SkinTxt.TabIndex = 0;
            this.DisGradeBox.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.DisGradeBox.SkinTxt.WaterText = "";
            this.DisGradeBox.TabIndex = 9;
            this.DisGradeBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.DisGradeBox.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.DisGradeBox.WaterText = "";
            this.DisGradeBox.WordWrap = true;
            // 
            // ExeText
            // 
            this.ExeText.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
            this.ExeText.Location = new System.Drawing.Point(179, 88);
            this.ExeText.Multiline = true;
            this.ExeText.Name = "ExeText";
            this.ExeText.ReadOnly = true;
            this.ExeText.Size = new System.Drawing.Size(227, 37);
            this.ExeText.TabIndex = 3;
            this.ExeText.WordWrap = false;
            // 
            // AnswerText
            // 
            this.AnswerText.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
            this.AnswerText.Location = new System.Drawing.Point(179, 32);
            this.AnswerText.Multiline = true;
            this.AnswerText.Name = "AnswerText";
            this.AnswerText.ReadOnly = true;
            this.AnswerText.Size = new System.Drawing.Size(227, 37);
            this.AnswerText.TabIndex = 1;
            this.AnswerText.WordWrap = false;
            // 
            // skinButton1
            // 
            this.skinButton1.BackColor = System.Drawing.Color.Transparent;
            this.skinButton1.BaseColor = System.Drawing.Color.OrangeRed;
            this.skinButton1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton1.DownBack = null;
            this.skinButton1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.skinButton1.Location = new System.Drawing.Point(466, 39);
            this.skinButton1.MouseBack = null;
            this.skinButton1.Name = "skinButton1";
            this.skinButton1.NormlBack = null;
            this.skinButton1.Size = new System.Drawing.Size(89, 71);
            this.skinButton1.TabIndex = 8;
            this.skinButton1.Text = "开始检查";
            this.skinButton1.UseVisualStyleBackColor = false;
            this.skinButton1.Click += new System.EventHandler(this.skinButton1_Click_1);
            // 
            // ExeButton
            // 
            this.ExeButton.BackColor = System.Drawing.Color.Transparent;
            this.ExeButton.BaseColor = System.Drawing.Color.OrangeRed;
            this.ExeButton.ControlState = CCWin.SkinClass.ControlState.Hover;
            this.ExeButton.DownBack = null;
            this.ExeButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ExeButton.Location = new System.Drawing.Point(43, 88);
            this.ExeButton.MouseBack = null;
            this.ExeButton.Name = "ExeButton";
            this.ExeButton.NormlBack = null;
            this.ExeButton.Size = new System.Drawing.Size(112, 37);
            this.ExeButton.TabIndex = 7;
            this.ExeButton.Text = "导入测验题目";
            this.ExeButton.UseVisualStyleBackColor = false;
            this.ExeButton.Click += new System.EventHandler(this.ExeButton_Click);
            // 
            // AnswerButton
            // 
            this.AnswerButton.BackColor = System.Drawing.Color.Transparent;
            this.AnswerButton.BaseColor = System.Drawing.Color.OrangeRed;
            this.AnswerButton.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.AnswerButton.DownBack = null;
            this.AnswerButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AnswerButton.Location = new System.Drawing.Point(43, 32);
            this.AnswerButton.MouseBack = null;
            this.AnswerButton.Name = "AnswerButton";
            this.AnswerButton.NormlBack = null;
            this.AnswerButton.Size = new System.Drawing.Size(112, 37);
            this.AnswerButton.TabIndex = 6;
            this.AnswerButton.Text = "导入答案文件";
            this.AnswerButton.UseVisualStyleBackColor = false;
            this.AnswerButton.Click += new System.EventHandler(this.AnswerButton_Click);
            // 
            // tabPageGen
            // 
            this.tabPageGen.Controls.Add(this.GenPage);
            this.tabPageGen.Location = new System.Drawing.Point(4, 29);
            this.tabPageGen.Name = "tabPageGen";
            this.tabPageGen.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageGen.Size = new System.Drawing.Size(627, 279);
            this.tabPageGen.TabIndex = 0;
            this.tabPageGen.Text = "生成表达式";
            this.tabPageGen.UseVisualStyleBackColor = true;
            // 
            // GenPage
            // 
            this.GenPage.BackColor = System.Drawing.Color.Transparent;
            this.GenPage.Controls.Add(this.GenProgressIndicator);
            this.GenPage.Controls.Add(this.ExeCountList);
            this.GenPage.Controls.Add(this.label7);
            this.GenPage.Controls.Add(this.HasFracCheck);
            this.GenPage.Controls.Add(this.label6);
            this.GenPage.Controls.Add(this.HasMultDivCheck);
            this.GenPage.Controls.Add(this.label5);
            this.GenPage.Controls.Add(this.HasBrackCheck);
            this.GenPage.Controls.Add(this.label4);
            this.GenPage.Controls.Add(this.label3);
            this.GenPage.Controls.Add(this.label2);
            this.GenPage.Controls.Add(this.label1);
            this.GenPage.Controls.Add(this.rightRange);
            this.GenPage.Controls.Add(this.leftRange);
            this.GenPage.Controls.Add(this.GenButton);
            this.GenPage.Controls.Add(this.OpCountList);
            this.GenPage.Controls.Add(this.HasNegCheck);
            this.GenPage.Controls.Add(this.ExeAnsTextBox);
            this.GenPage.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.GenPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GenPage.DownBack = null;
            this.GenPage.Location = new System.Drawing.Point(3, 3);
            this.GenPage.MouseBack = null;
            this.GenPage.Name = "GenPage";
            this.GenPage.NormlBack = null;
            this.GenPage.Size = new System.Drawing.Size(621, 273);
            this.GenPage.TabIndex = 0;
            // 
            // GenProgressIndicator
            // 
            this.GenProgressIndicator.BackColor = System.Drawing.Color.Transparent;
            this.GenProgressIndicator.CircleColor = System.Drawing.Color.LightSkyBlue;
            this.GenProgressIndicator.Location = new System.Drawing.Point(420, 117);
            this.GenProgressIndicator.Name = "GenProgressIndicator";
            this.GenProgressIndicator.Percentage = 0F;
            this.GenProgressIndicator.Size = new System.Drawing.Size(111, 111);
            this.GenProgressIndicator.TabIndex = 15;
            this.GenProgressIndicator.Text = "skinProgressIndicator1";
            this.GenProgressIndicator.Visible = false;
            // 
            // ExeCountList
            // 
            this.ExeCountList.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExeCountList.Location = new System.Drawing.Point(219, 51);
            this.ExeCountList.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.ExeCountList.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ExeCountList.Name = "ExeCountList";
            this.ExeCountList.Size = new System.Drawing.Size(87, 26);
            this.ExeCountList.TabIndex = 33;
            this.ExeCountList.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ExeCountList.ValueChanged += new System.EventHandler(this.ExeCountList_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(42, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 20);
            this.label7.TabIndex = 31;
            this.label7.Text = "题目的数量";
            // 
            // HasFracCheck
            // 
            this.HasFracCheck.AutoSize = true;
            this.HasFracCheck.BackColor = System.Drawing.Color.Transparent;
            this.HasFracCheck.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.HasFracCheck.DefaultCheckButtonWidth = 16;
            this.HasFracCheck.DownBack = null;
            this.HasFracCheck.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.HasFracCheck.LightEffectWidth = 3;
            this.HasFracCheck.Location = new System.Drawing.Point(218, 185);
            this.HasFracCheck.MinimumSize = new System.Drawing.Size(23, 23);
            this.HasFracCheck.MouseBack = null;
            this.HasFracCheck.Name = "HasFracCheck";
            this.HasFracCheck.NormlBack = null;
            this.HasFracCheck.SelectedDownBack = null;
            this.HasFracCheck.SelectedMouseBack = null;
            this.HasFracCheck.SelectedNormlBack = null;
            this.HasFracCheck.Size = new System.Drawing.Size(23, 23);
            this.HasFracCheck.TabIndex = 30;
            this.HasFracCheck.UseVisualStyleBackColor = false;
            this.HasFracCheck.CheckedChanged += new System.EventHandler(this.HasFracCheck_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(163, 20);
            this.label6.TabIndex = 29;
            this.label6.Text = "题目中或运算中出现分数";
            // 
            // HasMultDivCheck
            // 
            this.HasMultDivCheck.AutoSize = true;
            this.HasMultDivCheck.BackColor = System.Drawing.Color.Transparent;
            this.HasMultDivCheck.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.HasMultDivCheck.DefaultCheckButtonWidth = 16;
            this.HasMultDivCheck.DownBack = null;
            this.HasMultDivCheck.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.HasMultDivCheck.LightEffectWidth = 3;
            this.HasMultDivCheck.Location = new System.Drawing.Point(218, 157);
            this.HasMultDivCheck.MinimumSize = new System.Drawing.Size(23, 23);
            this.HasMultDivCheck.MouseBack = null;
            this.HasMultDivCheck.Name = "HasMultDivCheck";
            this.HasMultDivCheck.NormlBack = null;
            this.HasMultDivCheck.SelectedDownBack = null;
            this.HasMultDivCheck.SelectedMouseBack = null;
            this.HasMultDivCheck.SelectedNormlBack = null;
            this.HasMultDivCheck.Size = new System.Drawing.Size(23, 23);
            this.HasMultDivCheck.TabIndex = 28;
            this.HasMultDivCheck.UseVisualStyleBackColor = false;
            this.HasMultDivCheck.CheckedChanged += new System.EventHandler(this.HasMultDivCheck_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 20);
            this.label5.TabIndex = 27;
            this.label5.Text = "题目中出现乘除法";
            // 
            // HasBrackCheck
            // 
            this.HasBrackCheck.AutoSize = true;
            this.HasBrackCheck.BackColor = System.Drawing.Color.Transparent;
            this.HasBrackCheck.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.HasBrackCheck.DefaultCheckButtonWidth = 16;
            this.HasBrackCheck.DownBack = null;
            this.HasBrackCheck.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.HasBrackCheck.LightEffectWidth = 3;
            this.HasBrackCheck.Location = new System.Drawing.Point(218, 129);
            this.HasBrackCheck.MinimumSize = new System.Drawing.Size(23, 23);
            this.HasBrackCheck.MouseBack = null;
            this.HasBrackCheck.Name = "HasBrackCheck";
            this.HasBrackCheck.NormlBack = null;
            this.HasBrackCheck.SelectedDownBack = null;
            this.HasBrackCheck.SelectedMouseBack = null;
            this.HasBrackCheck.SelectedNormlBack = null;
            this.HasBrackCheck.Size = new System.Drawing.Size(23, 23);
            this.HasBrackCheck.TabIndex = 26;
            this.HasBrackCheck.UseVisualStyleBackColor = false;
            this.HasBrackCheck.CheckedChanged += new System.EventHandler(this.HasBrackCheck_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 20);
            this.label4.TabIndex = 25;
            this.label4.Text = "题目中出现括号";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 20);
            this.label3.TabIndex = 24;
            this.label3.Text = "题目中数值的范围";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 20);
            this.label2.TabIndex = 23;
            this.label2.Text = "题目中运算符的个数";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 215);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 20);
            this.label1.TabIndex = 22;
            this.label1.Text = "题目中或运算中出现负数";
            // 
            // rightRange
            // 
            this.rightRange.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rightRange.Location = new System.Drawing.Point(270, 83);
            this.rightRange.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.rightRange.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.rightRange.Name = "rightRange";
            this.rightRange.Size = new System.Drawing.Size(73, 26);
            this.rightRange.TabIndex = 21;
            this.rightRange.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.rightRange.ValueChanged += new System.EventHandler(this.rightRange_ValueChanged);
            // 
            // leftRange
            // 
            this.leftRange.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leftRange.Location = new System.Drawing.Point(191, 83);
            this.leftRange.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.leftRange.Name = "leftRange";
            this.leftRange.Size = new System.Drawing.Size(75, 26);
            this.leftRange.TabIndex = 20;
            this.leftRange.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.leftRange.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.leftRange.ValueChanged += new System.EventHandler(this.leftRange_ValueChanged);
            // 
            // GenButton
            // 
            this.GenButton.BackColor = System.Drawing.Color.Transparent;
            this.GenButton.BaseColor = System.Drawing.Color.LightSkyBlue;
            this.GenButton.ControlState = CCWin.SkinClass.ControlState.Hover;
            this.GenButton.DownBack = null;
            this.GenButton.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.GenButton.ForeColor = System.Drawing.Color.Teal;
            this.GenButton.Location = new System.Drawing.Point(270, 144);
            this.GenButton.MouseBack = null;
            this.GenButton.Name = "GenButton";
            this.GenButton.NormlBack = null;
            this.GenButton.Size = new System.Drawing.Size(87, 78);
            this.GenButton.TabIndex = 16;
            this.GenButton.Text = "开始生成";
            this.GenButton.UseVisualStyleBackColor = false;
            this.GenButton.Click += new System.EventHandler(this.skinButton1_Click);
            // 
            // OpCountList
            // 
            this.OpCountList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OpCountList.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpCountList.Location = new System.Drawing.Point(248, 19);
            this.OpCountList.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.OpCountList.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.OpCountList.Name = "OpCountList";
            this.OpCountList.Size = new System.Drawing.Size(43, 26);
            this.OpCountList.TabIndex = 4;
            this.OpCountList.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.OpCountList.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.OpCountList.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.OpCountList.ValueChanged += new System.EventHandler(this.OpCountList_ValueChanged);
            // 
            // HasNegCheck
            // 
            this.HasNegCheck.AutoSize = true;
            this.HasNegCheck.BackColor = System.Drawing.Color.Transparent;
            this.HasNegCheck.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.HasNegCheck.DefaultCheckButtonWidth = 16;
            this.HasNegCheck.DownBack = null;
            this.HasNegCheck.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.HasNegCheck.LightEffectWidth = 3;
            this.HasNegCheck.Location = new System.Drawing.Point(218, 213);
            this.HasNegCheck.MinimumSize = new System.Drawing.Size(23, 23);
            this.HasNegCheck.MouseBack = null;
            this.HasNegCheck.Name = "HasNegCheck";
            this.HasNegCheck.NormlBack = null;
            this.HasNegCheck.SelectedDownBack = null;
            this.HasNegCheck.SelectedMouseBack = null;
            this.HasNegCheck.SelectedNormlBack = null;
            this.HasNegCheck.Size = new System.Drawing.Size(23, 23);
            this.HasNegCheck.TabIndex = 0;
            this.HasNegCheck.UseVisualStyleBackColor = false;
            this.HasNegCheck.CheckedChanged += new System.EventHandler(this.HasNegCheck_CheckedChanged);
            // 
            // ExeAnsTextBox
            // 
            this.ExeAnsTextBox.BackColor = System.Drawing.Color.Transparent;
            this.ExeAnsTextBox.DownBack = null;
            this.ExeAnsTextBox.Icon = null;
            this.ExeAnsTextBox.IconIsButton = false;
            this.ExeAnsTextBox.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.ExeAnsTextBox.IsPasswordChat = '\0';
            this.ExeAnsTextBox.IsSystemPasswordChar = false;
            this.ExeAnsTextBox.Lines = new string[0];
            this.ExeAnsTextBox.Location = new System.Drawing.Point(374, 0);
            this.ExeAnsTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.ExeAnsTextBox.MaxLength = 32767;
            this.ExeAnsTextBox.MinimumSize = new System.Drawing.Size(28, 28);
            this.ExeAnsTextBox.MouseBack = null;
            this.ExeAnsTextBox.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.ExeAnsTextBox.Multiline = true;
            this.ExeAnsTextBox.Name = "ExeAnsTextBox";
            this.ExeAnsTextBox.NormlBack = null;
            this.ExeAnsTextBox.Padding = new System.Windows.Forms.Padding(5);
            this.ExeAnsTextBox.ReadOnly = true;
            this.ExeAnsTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ExeAnsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ExeAnsTextBox.Size = new System.Drawing.Size(215, 140);
            // 
            // 
            // 
            this.ExeAnsTextBox.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ExeAnsTextBox.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ExeAnsTextBox.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.ExeAnsTextBox.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.ExeAnsTextBox.SkinTxt.Multiline = true;
            this.ExeAnsTextBox.SkinTxt.Name = "BaseText";
            this.ExeAnsTextBox.SkinTxt.ReadOnly = true;
            this.ExeAnsTextBox.SkinTxt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ExeAnsTextBox.SkinTxt.Size = new System.Drawing.Size(205, 130);
            this.ExeAnsTextBox.SkinTxt.TabIndex = 0;
            this.ExeAnsTextBox.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.ExeAnsTextBox.SkinTxt.WaterText = "SivilTaram";
            this.ExeAnsTextBox.TabIndex = 34;
            this.ExeAnsTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ExeAnsTextBox.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.ExeAnsTextBox.WaterText = "SivilTaram";
            this.ExeAnsTextBox.WordWrap = true;
            // 
            // PageSet
            // 
            this.PageSet.Controls.Add(this.tabPageGen);
            this.PageSet.Controls.Add(this.tabPageCheck);
            this.PageSet.Controls.Add(this.tabPageCalc);
            this.PageSet.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.PageSet.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PageSet.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PageSet.Location = new System.Drawing.Point(4, 62);
            this.PageSet.Margin = new System.Windows.Forms.Padding(0);
            this.PageSet.Name = "PageSet";
            this.PageSet.SelectedIndex = 0;
            this.PageSet.Size = new System.Drawing.Size(635, 312);
            this.PageSet.TabIndex = 0;
            // 
            // tabPageCalc
            // 
            this.tabPageCalc.Controls.Add(this.rtfRichTextBox1);
            this.tabPageCalc.Controls.Add(this.calcTextBox);
            this.tabPageCalc.Controls.Add(this.calcButtonDelete);
            this.tabPageCalc.Controls.Add(this.calcButtonRBrack);
            this.tabPageCalc.Controls.Add(this.calcButtonLBrack);
            this.tabPageCalc.Controls.Add(this.calcButtonResult);
            this.tabPageCalc.Controls.Add(this.calcButtonClean);
            this.tabPageCalc.Controls.Add(this.calcButtonSub);
            this.tabPageCalc.Controls.Add(this.calcButtonAdd);
            this.tabPageCalc.Controls.Add(this.calcButtonMult);
            this.tabPageCalc.Controls.Add(this.calcButtonDiv);
            this.tabPageCalc.Controls.Add(this.calcButtonQuestion);
            this.tabPageCalc.Controls.Add(this.calcButtonQuote);
            this.tabPageCalc.Controls.Add(this.calcButton0);
            this.tabPageCalc.Controls.Add(this.calcButton3);
            this.tabPageCalc.Controls.Add(this.calcButton2);
            this.tabPageCalc.Controls.Add(this.calcButton1);
            this.tabPageCalc.Controls.Add(this.calcButton6);
            this.tabPageCalc.Controls.Add(this.calcButton5);
            this.tabPageCalc.Controls.Add(this.calcButton4);
            this.tabPageCalc.Controls.Add(this.calcButton9);
            this.tabPageCalc.Controls.Add(this.calcButton8);
            this.tabPageCalc.Controls.Add(this.calcButton7);
            this.tabPageCalc.Location = new System.Drawing.Point(4, 29);
            this.tabPageCalc.Name = "tabPageCalc";
            this.tabPageCalc.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCalc.Size = new System.Drawing.Size(627, 279);
            this.tabPageCalc.TabIndex = 2;
            this.tabPageCalc.Text = "计算器";
            this.tabPageCalc.UseVisualStyleBackColor = true;
            // 
            // rtfRichTextBox1
            // 
            this.rtfRichTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtfRichTextBox1.ForeColor = System.Drawing.Color.DarkGreen;
            this.rtfRichTextBox1.HiglightColor = CCWin.SkinControl.RtfRichTextBox.RtfColor.White;
            this.rtfRichTextBox1.Location = new System.Drawing.Point(355, 6);
            this.rtfRichTextBox1.Name = "rtfRichTextBox1";
            this.rtfRichTextBox1.ReadOnly = true;
            this.rtfRichTextBox1.Size = new System.Drawing.Size(233, 267);
            this.rtfRichTextBox1.TabIndex = 22;
            this.rtfRichTextBox1.Text = "计算器支持键盘快捷键输入，以下为快捷键映射说明：\nShift + \'8\' = \'×\'\nShift + \'/\' = \'÷\'\nShift + \'9\' = \'(\'\nSh" +
    "ift + \'0\' = \')\'\nShift + \'=\' = \'+\'\nShift + \'\"\' = \' \' \'\nEnter = \'=\'\n其余均为键盘默认单键控制";
            this.rtfRichTextBox1.TextColor = CCWin.SkinControl.RtfRichTextBox.RtfColor.Black;
            // 
            // calcTextBox
            // 
            this.calcTextBox.BackColor = System.Drawing.Color.Transparent;
            this.calcTextBox.DownBack = null;
            this.calcTextBox.Icon = null;
            this.calcTextBox.IconIsButton = false;
            this.calcTextBox.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.calcTextBox.IsPasswordChat = '\0';
            this.calcTextBox.IsSystemPasswordChar = false;
            this.calcTextBox.Lines = new string[0];
            this.calcTextBox.Location = new System.Drawing.Point(76, 36);
            this.calcTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.calcTextBox.MaxLength = 32767;
            this.calcTextBox.MinimumSize = new System.Drawing.Size(28, 28);
            this.calcTextBox.MouseBack = null;
            this.calcTextBox.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.calcTextBox.Multiline = true;
            this.calcTextBox.Name = "calcTextBox";
            this.calcTextBox.NormlBack = null;
            this.calcTextBox.Padding = new System.Windows.Forms.Padding(5);
            this.calcTextBox.ReadOnly = true;
            this.calcTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.calcTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.calcTextBox.Size = new System.Drawing.Size(246, 33);
            // 
            // 
            // 
            this.calcTextBox.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.calcTextBox.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.calcTextBox.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.calcTextBox.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.calcTextBox.SkinTxt.Multiline = true;
            this.calcTextBox.SkinTxt.Name = "BaseText";
            this.calcTextBox.SkinTxt.ReadOnly = true;
            this.calcTextBox.SkinTxt.Size = new System.Drawing.Size(236, 23);
            this.calcTextBox.SkinTxt.TabIndex = 0;
            this.calcTextBox.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.calcTextBox.SkinTxt.WaterText = "";
            this.calcTextBox.SkinTxt.WordWrap = false;
            this.calcTextBox.TabIndex = 21;
            this.calcTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.calcTextBox.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.calcTextBox.WaterText = "";
            this.calcTextBox.WordWrap = false;
            // 
            // calcButtonDelete
            // 
            this.calcButtonDelete.BackColor = System.Drawing.Color.Transparent;
            this.calcButtonDelete.BaseColor = System.Drawing.SystemColors.Highlight;
            this.calcButtonDelete.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.calcButtonDelete.DownBack = null;
            this.calcButtonDelete.Location = new System.Drawing.Point(244, 84);
            this.calcButtonDelete.MouseBack = null;
            this.calcButtonDelete.Name = "calcButtonDelete";
            this.calcButtonDelete.NormlBack = null;
            this.calcButtonDelete.Size = new System.Drawing.Size(78, 36);
            this.calcButtonDelete.TabIndex = 20;
            this.calcButtonDelete.Text = "←";
            this.calcButtonDelete.UseVisualStyleBackColor = false;
            this.calcButtonDelete.Click += new System.EventHandler(this.calcButtonDelete_Click);
            // 
            // calcButtonRBrack
            // 
            this.calcButtonRBrack.BackColor = System.Drawing.Color.Transparent;
            this.calcButtonRBrack.BaseColor = System.Drawing.SystemColors.Highlight;
            this.calcButtonRBrack.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.calcButtonRBrack.DownBack = null;
            this.calcButtonRBrack.Location = new System.Drawing.Point(244, 210);
            this.calcButtonRBrack.MouseBack = null;
            this.calcButtonRBrack.Name = "calcButtonRBrack";
            this.calcButtonRBrack.NormlBack = null;
            this.calcButtonRBrack.Size = new System.Drawing.Size(36, 36);
            this.calcButtonRBrack.TabIndex = 19;
            this.calcButtonRBrack.Text = ")";
            this.calcButtonRBrack.UseVisualStyleBackColor = false;
            this.calcButtonRBrack.Click += new System.EventHandler(this.calcButtonRBrack_Click);
            // 
            // calcButtonLBrack
            // 
            this.calcButtonLBrack.BackColor = System.Drawing.Color.Transparent;
            this.calcButtonLBrack.BaseColor = System.Drawing.SystemColors.Highlight;
            this.calcButtonLBrack.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.calcButtonLBrack.DownBack = null;
            this.calcButtonLBrack.Location = new System.Drawing.Point(244, 168);
            this.calcButtonLBrack.MouseBack = null;
            this.calcButtonLBrack.Name = "calcButtonLBrack";
            this.calcButtonLBrack.NormlBack = null;
            this.calcButtonLBrack.Size = new System.Drawing.Size(36, 36);
            this.calcButtonLBrack.TabIndex = 18;
            this.calcButtonLBrack.Text = "(";
            this.calcButtonLBrack.UseVisualStyleBackColor = false;
            this.calcButtonLBrack.Click += new System.EventHandler(this.calcButtonLBrack_Click);
            // 
            // calcButtonResult
            // 
            this.calcButtonResult.BackColor = System.Drawing.Color.Transparent;
            this.calcButtonResult.BaseColor = System.Drawing.SystemColors.Highlight;
            this.calcButtonResult.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.calcButtonResult.DownBack = null;
            this.calcButtonResult.Location = new System.Drawing.Point(286, 126);
            this.calcButtonResult.MouseBack = null;
            this.calcButtonResult.Name = "calcButtonResult";
            this.calcButtonResult.NormlBack = null;
            this.calcButtonResult.Size = new System.Drawing.Size(36, 120);
            this.calcButtonResult.TabIndex = 17;
            this.calcButtonResult.Text = "=";
            this.calcButtonResult.UseVisualStyleBackColor = false;
            this.calcButtonResult.Click += new System.EventHandler(this.calcButtonResult_Click);
            // 
            // calcButtonClean
            // 
            this.calcButtonClean.BackColor = System.Drawing.Color.Transparent;
            this.calcButtonClean.BaseColor = System.Drawing.SystemColors.Highlight;
            this.calcButtonClean.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.calcButtonClean.DownBack = null;
            this.calcButtonClean.Location = new System.Drawing.Point(244, 126);
            this.calcButtonClean.MouseBack = null;
            this.calcButtonClean.Name = "calcButtonClean";
            this.calcButtonClean.NormlBack = null;
            this.calcButtonClean.Size = new System.Drawing.Size(36, 36);
            this.calcButtonClean.TabIndex = 16;
            this.calcButtonClean.Text = "C";
            this.calcButtonClean.UseVisualStyleBackColor = false;
            this.calcButtonClean.Click += new System.EventHandler(this.calcButtonClean_Click);
            // 
            // calcButtonSub
            // 
            this.calcButtonSub.BackColor = System.Drawing.Color.Transparent;
            this.calcButtonSub.BaseColor = System.Drawing.SystemColors.Highlight;
            this.calcButtonSub.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.calcButtonSub.DownBack = null;
            this.calcButtonSub.Location = new System.Drawing.Point(202, 210);
            this.calcButtonSub.MouseBack = null;
            this.calcButtonSub.Name = "calcButtonSub";
            this.calcButtonSub.NormlBack = null;
            this.calcButtonSub.Size = new System.Drawing.Size(36, 36);
            this.calcButtonSub.TabIndex = 15;
            this.calcButtonSub.Text = "-";
            this.calcButtonSub.UseVisualStyleBackColor = false;
            this.calcButtonSub.Click += new System.EventHandler(this.calcButtonSub_Click);
            // 
            // calcButtonAdd
            // 
            this.calcButtonAdd.BackColor = System.Drawing.Color.Transparent;
            this.calcButtonAdd.BaseColor = System.Drawing.SystemColors.Highlight;
            this.calcButtonAdd.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.calcButtonAdd.DownBack = null;
            this.calcButtonAdd.Location = new System.Drawing.Point(202, 168);
            this.calcButtonAdd.MouseBack = null;
            this.calcButtonAdd.Name = "calcButtonAdd";
            this.calcButtonAdd.NormlBack = null;
            this.calcButtonAdd.Size = new System.Drawing.Size(36, 36);
            this.calcButtonAdd.TabIndex = 14;
            this.calcButtonAdd.Text = "+";
            this.calcButtonAdd.UseVisualStyleBackColor = false;
            this.calcButtonAdd.Click += new System.EventHandler(this.calcButtonAdd_Click);
            // 
            // calcButtonMult
            // 
            this.calcButtonMult.BackColor = System.Drawing.Color.Transparent;
            this.calcButtonMult.BaseColor = System.Drawing.SystemColors.Highlight;
            this.calcButtonMult.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.calcButtonMult.DownBack = null;
            this.calcButtonMult.Location = new System.Drawing.Point(202, 126);
            this.calcButtonMult.MouseBack = null;
            this.calcButtonMult.Name = "calcButtonMult";
            this.calcButtonMult.NormlBack = null;
            this.calcButtonMult.Size = new System.Drawing.Size(36, 36);
            this.calcButtonMult.TabIndex = 13;
            this.calcButtonMult.Text = "×";
            this.calcButtonMult.UseVisualStyleBackColor = false;
            this.calcButtonMult.Click += new System.EventHandler(this.calcButtonMult_Click);
            // 
            // calcButtonDiv
            // 
            this.calcButtonDiv.BackColor = System.Drawing.Color.Transparent;
            this.calcButtonDiv.BaseColor = System.Drawing.SystemColors.Highlight;
            this.calcButtonDiv.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.calcButtonDiv.DownBack = null;
            this.calcButtonDiv.Location = new System.Drawing.Point(202, 84);
            this.calcButtonDiv.MouseBack = null;
            this.calcButtonDiv.Name = "calcButtonDiv";
            this.calcButtonDiv.NormlBack = null;
            this.calcButtonDiv.Size = new System.Drawing.Size(36, 36);
            this.calcButtonDiv.TabIndex = 12;
            this.calcButtonDiv.Text = "÷";
            this.calcButtonDiv.UseVisualStyleBackColor = false;
            this.calcButtonDiv.Click += new System.EventHandler(this.calcButtonDiv_Click);
            // 
            // calcButtonQuestion
            // 
            this.calcButtonQuestion.BackColor = System.Drawing.Color.Transparent;
            this.calcButtonQuestion.BaseColor = System.Drawing.SystemColors.Highlight;
            this.calcButtonQuestion.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.calcButtonQuestion.DownBack = null;
            this.calcButtonQuestion.Location = new System.Drawing.Point(160, 210);
            this.calcButtonQuestion.MouseBack = null;
            this.calcButtonQuestion.Name = "calcButtonQuestion";
            this.calcButtonQuestion.NormlBack = null;
            this.calcButtonQuestion.Size = new System.Drawing.Size(36, 36);
            this.calcButtonQuestion.TabIndex = 11;
            this.calcButtonQuestion.Text = "/";
            this.calcButtonQuestion.UseVisualStyleBackColor = false;
            this.calcButtonQuestion.Click += new System.EventHandler(this.calcButtonQuestion_Click);
            // 
            // calcButtonQuote
            // 
            this.calcButtonQuote.BackColor = System.Drawing.Color.Transparent;
            this.calcButtonQuote.BaseColor = System.Drawing.SystemColors.Highlight;
            this.calcButtonQuote.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.calcButtonQuote.DownBack = null;
            this.calcButtonQuote.Location = new System.Drawing.Point(118, 210);
            this.calcButtonQuote.MouseBack = null;
            this.calcButtonQuote.Name = "calcButtonQuote";
            this.calcButtonQuote.NormlBack = null;
            this.calcButtonQuote.Size = new System.Drawing.Size(36, 36);
            this.calcButtonQuote.TabIndex = 10;
            this.calcButtonQuote.Text = "\'";
            this.calcButtonQuote.UseVisualStyleBackColor = false;
            this.calcButtonQuote.Click += new System.EventHandler(this.calcButtonQuote_Click);
            // 
            // calcButton0
            // 
            this.calcButton0.BackColor = System.Drawing.Color.Transparent;
            this.calcButton0.BaseColor = System.Drawing.SystemColors.Highlight;
            this.calcButton0.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.calcButton0.DownBack = null;
            this.calcButton0.Location = new System.Drawing.Point(76, 210);
            this.calcButton0.MouseBack = null;
            this.calcButton0.Name = "calcButton0";
            this.calcButton0.NormlBack = null;
            this.calcButton0.Size = new System.Drawing.Size(36, 36);
            this.calcButton0.TabIndex = 9;
            this.calcButton0.Text = "0";
            this.calcButton0.UseVisualStyleBackColor = false;
            this.calcButton0.Click += new System.EventHandler(this.calcButton0_Click);
            // 
            // calcButton3
            // 
            this.calcButton3.BackColor = System.Drawing.Color.Transparent;
            this.calcButton3.BaseColor = System.Drawing.SystemColors.Highlight;
            this.calcButton3.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.calcButton3.DownBack = null;
            this.calcButton3.Location = new System.Drawing.Point(160, 168);
            this.calcButton3.MouseBack = null;
            this.calcButton3.Name = "calcButton3";
            this.calcButton3.NormlBack = null;
            this.calcButton3.Size = new System.Drawing.Size(36, 36);
            this.calcButton3.TabIndex = 8;
            this.calcButton3.Text = "3";
            this.calcButton3.UseVisualStyleBackColor = false;
            this.calcButton3.Click += new System.EventHandler(this.calcButton3_Click);
            // 
            // calcButton2
            // 
            this.calcButton2.BackColor = System.Drawing.Color.Transparent;
            this.calcButton2.BaseColor = System.Drawing.SystemColors.Highlight;
            this.calcButton2.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.calcButton2.DownBack = null;
            this.calcButton2.Location = new System.Drawing.Point(118, 168);
            this.calcButton2.MouseBack = null;
            this.calcButton2.Name = "calcButton2";
            this.calcButton2.NormlBack = null;
            this.calcButton2.Size = new System.Drawing.Size(36, 36);
            this.calcButton2.TabIndex = 7;
            this.calcButton2.Text = "2";
            this.calcButton2.UseVisualStyleBackColor = false;
            this.calcButton2.Click += new System.EventHandler(this.calcButton2_Click);
            // 
            // calcButton1
            // 
            this.calcButton1.BackColor = System.Drawing.Color.Transparent;
            this.calcButton1.BaseColor = System.Drawing.SystemColors.Highlight;
            this.calcButton1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.calcButton1.DownBack = null;
            this.calcButton1.Location = new System.Drawing.Point(76, 168);
            this.calcButton1.MouseBack = null;
            this.calcButton1.Name = "calcButton1";
            this.calcButton1.NormlBack = null;
            this.calcButton1.Size = new System.Drawing.Size(36, 36);
            this.calcButton1.TabIndex = 6;
            this.calcButton1.Text = "1";
            this.calcButton1.UseVisualStyleBackColor = false;
            this.calcButton1.Click += new System.EventHandler(this.calcButton1_Click);
            // 
            // calcButton6
            // 
            this.calcButton6.BackColor = System.Drawing.Color.Transparent;
            this.calcButton6.BaseColor = System.Drawing.SystemColors.Highlight;
            this.calcButton6.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.calcButton6.DownBack = null;
            this.calcButton6.Location = new System.Drawing.Point(160, 126);
            this.calcButton6.MouseBack = null;
            this.calcButton6.Name = "calcButton6";
            this.calcButton6.NormlBack = null;
            this.calcButton6.Size = new System.Drawing.Size(36, 36);
            this.calcButton6.TabIndex = 5;
            this.calcButton6.Text = "6";
            this.calcButton6.UseVisualStyleBackColor = false;
            this.calcButton6.Click += new System.EventHandler(this.calcButton6_Click);
            // 
            // calcButton5
            // 
            this.calcButton5.BackColor = System.Drawing.Color.Transparent;
            this.calcButton5.BaseColor = System.Drawing.SystemColors.Highlight;
            this.calcButton5.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.calcButton5.DownBack = null;
            this.calcButton5.Location = new System.Drawing.Point(118, 126);
            this.calcButton5.MouseBack = null;
            this.calcButton5.Name = "calcButton5";
            this.calcButton5.NormlBack = null;
            this.calcButton5.Size = new System.Drawing.Size(36, 36);
            this.calcButton5.TabIndex = 4;
            this.calcButton5.Text = "5";
            this.calcButton5.UseVisualStyleBackColor = false;
            this.calcButton5.Click += new System.EventHandler(this.calcButton5_Click);
            // 
            // calcButton4
            // 
            this.calcButton4.BackColor = System.Drawing.Color.Transparent;
            this.calcButton4.BaseColor = System.Drawing.SystemColors.Highlight;
            this.calcButton4.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.calcButton4.DownBack = null;
            this.calcButton4.Location = new System.Drawing.Point(76, 126);
            this.calcButton4.MouseBack = null;
            this.calcButton4.Name = "calcButton4";
            this.calcButton4.NormlBack = null;
            this.calcButton4.Size = new System.Drawing.Size(36, 36);
            this.calcButton4.TabIndex = 3;
            this.calcButton4.Text = "4";
            this.calcButton4.UseVisualStyleBackColor = false;
            this.calcButton4.Click += new System.EventHandler(this.calcButton4_Click);
            // 
            // calcButton9
            // 
            this.calcButton9.BackColor = System.Drawing.Color.Transparent;
            this.calcButton9.BaseColor = System.Drawing.SystemColors.Highlight;
            this.calcButton9.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.calcButton9.DownBack = null;
            this.calcButton9.Location = new System.Drawing.Point(160, 84);
            this.calcButton9.MouseBack = null;
            this.calcButton9.Name = "calcButton9";
            this.calcButton9.NormlBack = null;
            this.calcButton9.Size = new System.Drawing.Size(36, 36);
            this.calcButton9.TabIndex = 2;
            this.calcButton9.Text = "9";
            this.calcButton9.UseVisualStyleBackColor = false;
            this.calcButton9.Click += new System.EventHandler(this.calcButton9_Click);
            // 
            // calcButton8
            // 
            this.calcButton8.BackColor = System.Drawing.Color.Transparent;
            this.calcButton8.BaseColor = System.Drawing.SystemColors.Highlight;
            this.calcButton8.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.calcButton8.DownBack = null;
            this.calcButton8.Location = new System.Drawing.Point(118, 84);
            this.calcButton8.MouseBack = null;
            this.calcButton8.Name = "calcButton8";
            this.calcButton8.NormlBack = null;
            this.calcButton8.Size = new System.Drawing.Size(36, 36);
            this.calcButton8.TabIndex = 1;
            this.calcButton8.Text = "8";
            this.calcButton8.UseVisualStyleBackColor = false;
            this.calcButton8.Click += new System.EventHandler(this.calcButton8_Click);
            // 
            // calcButton7
            // 
            this.calcButton7.BackColor = System.Drawing.Color.Transparent;
            this.calcButton7.BaseColor = System.Drawing.SystemColors.Highlight;
            this.calcButton7.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.calcButton7.DownBack = null;
            this.calcButton7.Location = new System.Drawing.Point(76, 84);
            this.calcButton7.MouseBack = null;
            this.calcButton7.Name = "calcButton7";
            this.calcButton7.NormlBack = null;
            this.calcButton7.Size = new System.Drawing.Size(36, 36);
            this.calcButton7.TabIndex = 0;
            this.calcButton7.Text = "7";
            this.calcButton7.UseVisualStyleBackColor = false;
            this.calcButton7.Click += new System.EventHandler(this.calcButton7_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(643, 378);
            this.Controls.Add(this.skinMenuStrip1);
            this.Controls.Add(this.PageSet);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.skinMenuStrip1;
            this.MaximumSize = new System.Drawing.Size(643, 378);
            this.MinimumSize = new System.Drawing.Size(643, 378);
            this.Name = "MainForm";
            this.Text = "四则运算测验器";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.skinMenuStrip1.ResumeLayout(false);
            this.skinMenuStrip1.PerformLayout();
            this.tabPageCheck.ResumeLayout(false);
            this.tabPageCheck.PerformLayout();
            this.tabPageGen.ResumeLayout(false);
            this.GenPage.ResumeLayout(false);
            this.GenPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExeCountList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightRange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftRange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OpCountList)).EndInit();
            this.PageSet.ResumeLayout(false);
            this.tabPageCalc.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private CCWin.SkinToolTip skinToolTip1;
        private CCWin.SkinControl.SkinMenuStrip skinMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
        private System.Windows.Forms.TabPage tabPageCheck;
        public System.Windows.Forms.TextBox ExeText;
        public System.Windows.Forms.TextBox AnswerText;
        private CCWin.SkinControl.SkinButton skinButton1;
        private CCWin.SkinControl.SkinButton ExeButton;
        private CCWin.SkinControl.SkinButton AnswerButton;
        private System.Windows.Forms.TabPage tabPageGen;
        private CCWin.SkinControl.SkinPanel GenPage;
        private CCWin.SkinControl.SkinButton GenButton;
        private CCWin.SkinControl.SkinNumericUpDown OpCountList;
        private CCWin.SkinControl.SkinCheckBox HasNegCheck;
        private System.Windows.Forms.TabControl PageSet;
        private CCWin.SkinControl.SkinNumericUpDown rightRange;
        private CCWin.SkinControl.SkinNumericUpDown leftRange;
        private CCWin.SkinControl.SkinNumericUpDown ExeCountList;
        private System.Windows.Forms.Label label7;
        private CCWin.SkinControl.SkinCheckBox HasFracCheck;
        private System.Windows.Forms.Label label6;
        private CCWin.SkinControl.SkinCheckBox HasMultDivCheck;
        private System.Windows.Forms.Label label5;
        private CCWin.SkinControl.SkinCheckBox HasBrackCheck;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPageCalc;
        private CCWin.SkinControl.SkinButton calcButtonResult;
        private CCWin.SkinControl.SkinButton calcButtonClean;
        private CCWin.SkinControl.SkinButton calcButtonSub;
        private CCWin.SkinControl.SkinButton calcButtonAdd;
        private CCWin.SkinControl.SkinButton calcButtonMult;
        private CCWin.SkinControl.SkinButton calcButtonDiv;
        private CCWin.SkinControl.SkinButton calcButtonQuestion;
        private CCWin.SkinControl.SkinButton calcButtonQuote;
        private CCWin.SkinControl.SkinButton calcButton0;
        private CCWin.SkinControl.SkinButton calcButton3;
        private CCWin.SkinControl.SkinButton calcButton2;
        private CCWin.SkinControl.SkinButton calcButton1;
        private CCWin.SkinControl.SkinButton calcButton6;
        private CCWin.SkinControl.SkinButton calcButton5;
        private CCWin.SkinControl.SkinButton calcButton4;
        private CCWin.SkinControl.SkinButton calcButton9;
        private CCWin.SkinControl.SkinButton calcButton8;
        private CCWin.SkinControl.SkinButton calcButton7;
        private CCWin.SkinControl.SkinButton calcButtonDelete;
        private CCWin.SkinControl.SkinButton calcButtonRBrack;
        private CCWin.SkinControl.SkinButton calcButtonLBrack;
        private CCWin.SkinControl.SkinTextBox calcTextBox;
        private CCWin.SkinControl.RtfRichTextBox rtfRichTextBox1;
        private CCWin.SkinControl.SkinTextBox DisGradeBox;
        private ToolStripMenuItem 开始ToolStripMenuItem;
        private ToolStripMenuItem 更改Gradetxt生成路径ToolStripMenuItem;
        private FolderBrowserDialog GradeFolderDialog;
        private CCWin.SkinControl.SkinProgressIndicator GenProgressIndicator;
        private ToolStripMenuItem 更改Exercisetxt生成路径ToolStripMenuItem;
        private ToolStripMenuItem 更改Answertxt生成路径ToolStripMenuItem;
        private CCWin.SkinControl.SkinTextBox ExeAnsTextBox;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private ToolStripMenuItem 帮助ToolStripMenuItem;
    }
   
}

