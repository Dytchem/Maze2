namespace Maze2
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.得分记录ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mInput = new System.Windows.Forms.NumericUpDown();
            this.nInput = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.creatMap = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pxInput = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.blueFresh = new System.Windows.Forms.Button();
            this.redFresh = new System.Windows.Forms.Button();
            this.blueScore = new System.Windows.Forms.Label();
            this.redScore = new System.Windows.Forms.Label();
            this.isBlue = new System.Windows.Forms.CheckBox();
            this.isRed = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ShowTime = new System.Windows.Forms.Label();
            this.isTime = new System.Windows.Forms.CheckBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.redPlayer = new System.Windows.Forms.Button();
            this.bluePlayer = new System.Windows.Forms.Button();
            this.fresh = new System.Windows.Forms.Button();
            this.vInput = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.timerScore = new System.Windows.Forms.Timer(this.components);
            this.focusLock = new System.Windows.Forms.Button();
            this.timerMove = new System.Windows.Forms.Timer(this.components);
            this.start = new System.Windows.Forms.Button();
            this.timerMouseRed = new System.Windows.Forms.Timer(this.components);
            this.timerMouseBlue = new System.Windows.Forms.Timer(this.components);
            this.debug = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxInput)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vInput)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(982, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.得分记录ToolStripMenuItem,
            this.toolStripSeparator1,
            this.关于ToolStripMenuItem,
            this.toolStripSeparator2,
            this.退出ToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(53, 24);
            this.toolStripMenuItem1.Text = "更多";
            // 
            // 得分记录ToolStripMenuItem
            // 
            this.得分记录ToolStripMenuItem.Name = "得分记录ToolStripMenuItem";
            this.得分记录ToolStripMenuItem.Size = new System.Drawing.Size(122, 26);
            this.得分记录ToolStripMenuItem.Text = "记录";
            this.得分记录ToolStripMenuItem.Click += new System.EventHandler(this.记录ToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(119, 6);
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(122, 26);
            this.关于ToolStripMenuItem.Text = "关于";
            this.关于ToolStripMenuItem.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.关于ToolStripMenuItem.Click += new System.EventHandler(this.关于ToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(119, 6);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(122, 26);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // mInput
            // 
            this.mInput.Location = new System.Drawing.Point(96, 36);
            this.mInput.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.mInput.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.mInput.Name = "mInput";
            this.mInput.Size = new System.Drawing.Size(120, 25);
            this.mInput.TabIndex = 1;
            this.mInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mInput.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.mInput.KeyUp += new System.Windows.Forms.KeyEventHandler(this.mInput_KeyUp);
            // 
            // nInput
            // 
            this.nInput.Location = new System.Drawing.Point(96, 78);
            this.nInput.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nInput.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nInput.Name = "nInput";
            this.nInput.Size = new System.Drawing.Size(120, 25);
            this.nInput.TabIndex = 2;
            this.nInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nInput.Value = new decimal(new int[] {
            35,
            0,
            0,
            0});
            this.nInput.KeyUp += new System.Windows.Forms.KeyEventHandler(this.nInput_KeyUp);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(35, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "行数：";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(35, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "列数：";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // creatMap
            // 
            this.creatMap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.creatMap.Location = new System.Drawing.Point(38, 162);
            this.creatMap.Name = "creatMap";
            this.creatMap.Size = new System.Drawing.Size(178, 25);
            this.creatMap.TabIndex = 5;
            this.creatMap.Text = "生成迷宫（K）";
            this.creatMap.UseVisualStyleBackColor = true;
            this.creatMap.Click += new System.EventHandler(this.creatMap_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(35, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "像素：";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pxInput
            // 
            this.pxInput.Location = new System.Drawing.Point(96, 120);
            this.pxInput.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.pxInput.Name = "pxInput";
            this.pxInput.Size = new System.Drawing.Size(120, 25);
            this.pxInput.TabIndex = 7;
            this.pxInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.pxInput.Value = new decimal(new int[] {
            13,
            0,
            0,
            0});
            this.pxInput.KeyUp += new System.Windows.Forms.KeyEventHandler(this.pxInput_KeyUp);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pxInput);
            this.groupBox1.Controls.Add(this.mInput);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.nInput);
            this.groupBox1.Controls.Add(this.creatMap);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(21, 85);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(256, 215);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "迷宫控制台";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(38, 186);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(178, 23);
            this.label8.TabIndex = 105;
            this.label8.Text = "（F）、（0）";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.blueFresh);
            this.groupBox2.Controls.Add(this.redFresh);
            this.groupBox2.Controls.Add(this.blueScore);
            this.groupBox2.Controls.Add(this.redScore);
            this.groupBox2.Controls.Add(this.isBlue);
            this.groupBox2.Controls.Add(this.isRed);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(21, 317);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(256, 215);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "角色控制台";
            // 
            // blueFresh
            // 
            this.blueFresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.blueFresh.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.blueFresh.Font = new System.Drawing.Font("黑体", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.blueFresh.Location = new System.Drawing.Point(220, 119);
            this.blueFresh.Name = "blueFresh";
            this.blueFresh.Size = new System.Drawing.Size(30, 30);
            this.blueFresh.TabIndex = 15;
            this.blueFresh.Text = "⟳";
            this.blueFresh.UseVisualStyleBackColor = true;
            this.blueFresh.Click += new System.EventHandler(this.blueFresh_Click);
            // 
            // redFresh
            // 
            this.redFresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.redFresh.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.redFresh.Font = new System.Drawing.Font("黑体", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.redFresh.Location = new System.Drawing.Point(220, 36);
            this.redFresh.Name = "redFresh";
            this.redFresh.Size = new System.Drawing.Size(30, 30);
            this.redFresh.TabIndex = 14;
            this.redFresh.Text = "⟳";
            this.redFresh.UseVisualStyleBackColor = true;
            this.redFresh.Click += new System.EventHandler(this.redFresh_Click);
            // 
            // blueScore
            // 
            this.blueScore.Location = new System.Drawing.Point(123, 167);
            this.blueScore.Name = "blueScore";
            this.blueScore.Size = new System.Drawing.Size(127, 23);
            this.blueScore.TabIndex = 3;
            this.blueScore.Text = "得分： 0";
            this.blueScore.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // redScore
            // 
            this.redScore.Location = new System.Drawing.Point(123, 83);
            this.redScore.Name = "redScore";
            this.redScore.Size = new System.Drawing.Size(127, 23);
            this.redScore.TabIndex = 2;
            this.redScore.Text = "得分： 0";
            this.redScore.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // isBlue
            // 
            this.isBlue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.isBlue.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.isBlue.ForeColor = System.Drawing.Color.Blue;
            this.isBlue.Location = new System.Drawing.Point(38, 125);
            this.isBlue.Name = "isBlue";
            this.isBlue.Size = new System.Drawing.Size(152, 25);
            this.isBlue.TabIndex = 1;
            this.isBlue.Text = "角色1： 蓝方";
            this.isBlue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.isBlue.UseVisualStyleBackColor = true;
            this.isBlue.CheckedChanged += new System.EventHandler(this.isBlue_CheckedChanged);
            // 
            // isRed
            // 
            this.isRed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.isRed.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.isRed.ForeColor = System.Drawing.Color.Red;
            this.isRed.Location = new System.Drawing.Point(38, 41);
            this.isRed.Name = "isRed";
            this.isRed.Size = new System.Drawing.Size(152, 25);
            this.isRed.TabIndex = 0;
            this.isRed.Text = "角色1： 红方";
            this.isRed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.isRed.UseVisualStyleBackColor = true;
            this.isRed.CheckedChanged += new System.EventHandler(this.isRed_CheckedChanged);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(206, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 23);
            this.label6.TabIndex = 105;
            this.label6.Text = "（Q）";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(206, 147);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 23);
            this.label7.TabIndex = 106;
            this.label7.Text = "（?）";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ShowTime
            // 
            this.ShowTime.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ShowTime.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ShowTime.Location = new System.Drawing.Point(110, 39);
            this.ShowTime.Name = "ShowTime";
            this.ShowTime.Size = new System.Drawing.Size(131, 28);
            this.ShowTime.TabIndex = 10;
            this.ShowTime.Text = "00:00:00";
            this.ShowTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ShowTime.Click += new System.EventHandler(this.ShowTime_Click);
            // 
            // isTime
            // 
            this.isTime.BackColor = System.Drawing.SystemColors.Control;
            this.isTime.Cursor = System.Windows.Forms.Cursors.Hand;
            this.isTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.isTime.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.isTime.ForeColor = System.Drawing.SystemColors.ControlText;
            this.isTime.Location = new System.Drawing.Point(21, 40);
            this.isTime.Name = "isTime";
            this.isTime.Size = new System.Drawing.Size(256, 28);
            this.isTime.TabIndex = 4;
            this.isTime.Text = "计时器：";
            this.isTime.UseVisualStyleBackColor = false;
            this.isTime.CheckedChanged += new System.EventHandler(this.isTime_CheckedChanged);
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // redPlayer
            // 
            this.redPlayer.BackColor = System.Drawing.Color.Red;
            this.redPlayer.Cursor = System.Windows.Forms.Cursors.Cross;
            this.redPlayer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.redPlayer.Location = new System.Drawing.Point(283, 364);
            this.redPlayer.Name = "redPlayer";
            this.redPlayer.Size = new System.Drawing.Size(10, 10);
            this.redPlayer.TabIndex = 11;
            this.redPlayer.UseVisualStyleBackColor = false;
            this.redPlayer.Visible = false;
            this.redPlayer.Enter += new System.EventHandler(this.redPlayer_Enter);
            this.redPlayer.MouseCaptureChanged += new System.EventHandler(this.redPlayer_MouseCaptureChanged);
            // 
            // bluePlayer
            // 
            this.bluePlayer.BackColor = System.Drawing.Color.Blue;
            this.bluePlayer.Cursor = System.Windows.Forms.Cursors.Cross;
            this.bluePlayer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bluePlayer.Location = new System.Drawing.Point(283, 448);
            this.bluePlayer.Name = "bluePlayer";
            this.bluePlayer.Size = new System.Drawing.Size(10, 10);
            this.bluePlayer.TabIndex = 12;
            this.bluePlayer.UseVisualStyleBackColor = false;
            this.bluePlayer.Visible = false;
            this.bluePlayer.Enter += new System.EventHandler(this.bluePlayer_Enter);
            this.bluePlayer.MouseCaptureChanged += new System.EventHandler(this.bluePlayer_MouseCaptureChanged);
            // 
            // fresh
            // 
            this.fresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fresh.Font = new System.Drawing.Font("黑体", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.fresh.Location = new System.Drawing.Point(241, 39);
            this.fresh.Name = "fresh";
            this.fresh.Size = new System.Drawing.Size(30, 30);
            this.fresh.TabIndex = 13;
            this.fresh.Text = "⟳";
            this.fresh.UseVisualStyleBackColor = true;
            this.fresh.Click += new System.EventHandler(this.fresh_Click);
            // 
            // vInput
            // 
            this.vInput.Cursor = System.Windows.Forms.Cursors.Hand;
            this.vInput.LargeChange = 10;
            this.vInput.Location = new System.Drawing.Point(391, 40);
            this.vInput.Maximum = 200;
            this.vInput.Minimum = 10;
            this.vInput.Name = "vInput";
            this.vInput.Size = new System.Drawing.Size(332, 56);
            this.vInput.SmallChange = 10;
            this.vInput.TabIndex = 16;
            this.vInput.TickFrequency = 10;
            this.vInput.Value = 100;
            this.vInput.ValueChanged += new System.EventHandler(this.vInput_ValueChanged);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("宋体", 11F);
            this.label4.Location = new System.Drawing.Point(311, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "速度：";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timerScore
            // 
            this.timerScore.Interval = 3000;
            this.timerScore.Tick += new System.EventHandler(this.timerScore_Tick);
            // 
            // focusLock
            // 
            this.focusLock.Cursor = System.Windows.Forms.Cursors.No;
            this.focusLock.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.focusLock.Location = new System.Drawing.Point(0, 0);
            this.focusLock.Name = "focusLock";
            this.focusLock.Size = new System.Drawing.Size(0, 0);
            this.focusLock.TabIndex = 100;
            this.focusLock.UseVisualStyleBackColor = true;
            this.focusLock.KeyUp += new System.Windows.Forms.KeyEventHandler(this.focusLock_KeyUp);
            // 
            // timerMove
            // 
            this.timerMove.Interval = 10;
            this.timerMove.Tick += new System.EventHandler(this.timerMove_Tick);
            // 
            // start
            // 
            this.start.Cursor = System.Windows.Forms.Cursors.Hand;
            this.start.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.start.ForeColor = System.Drawing.Color.Red;
            this.start.Location = new System.Drawing.Point(763, 29);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(190, 35);
            this.start.TabIndex = 102;
            this.start.Text = "游戏状态：停止";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // timerMouseRed
            // 
            this.timerMouseRed.Tick += new System.EventHandler(this.timerMouseRed_Tick);
            // 
            // timerMouseBlue
            // 
            this.timerMouseBlue.Tick += new System.EventHandler(this.timerMouseBlue_Tick);
            // 
            // debug
            // 
            this.debug.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.debug.ForeColor = System.Drawing.Color.Red;
            this.debug.Location = new System.Drawing.Point(550, 0);
            this.debug.Name = "debug";
            this.debug.Size = new System.Drawing.Size(432, 37);
            this.debug.TabIndex = 103;
            this.debug.Visible = false;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(760, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(190, 23);
            this.label5.TabIndex = 104;
            this.label5.Text = "（L）";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Italic);
            this.label9.Location = new System.Drawing.Point(67, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(915, 37);
            this.label9.TabIndex = 105;
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.start);
            this.Controls.Add(this.debug);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.vInput);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.focusLock);
            this.Controls.Add(this.fresh);
            this.Controls.Add(this.bluePlayer);
            this.Controls.Add(this.redPlayer);
            this.Controls.Add(this.ShowTime);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.isTime);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Maze";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxInput)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.vInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.NumericUpDown mInput;
        private System.Windows.Forms.NumericUpDown nInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button creatMap;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown pxInput;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox isRed;
        private System.Windows.Forms.Label blueScore;
        private System.Windows.Forms.Label redScore;
        private System.Windows.Forms.CheckBox isBlue;
        private System.Windows.Forms.Label ShowTime;
        private System.Windows.Forms.CheckBox isTime;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button redPlayer;
        private System.Windows.Forms.Button bluePlayer;
        private System.Windows.Forms.Button fresh;
        private System.Windows.Forms.Button blueFresh;
        private System.Windows.Forms.Button redFresh;
        private System.Windows.Forms.TrackBar vInput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer timerScore;
        private System.Windows.Forms.Button focusLock;
        private System.Windows.Forms.Timer timerMove;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Timer timerMouseRed;
        private System.Windows.Forms.Timer timerMouseBlue;
        private System.Windows.Forms.Label debug;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStripMenuItem 得分记录ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}

