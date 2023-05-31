using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Maze2
{
    public partial class Form1 : Form
    {
        private int m = 11, n = 15, px = 30, time = 0, v = 100, pxPlayer;
        private int  redS = 0, blueS = 0;
        private bool redOver, blueOver;
        Point cursor, button, redHistory, blueHistory;
        private readonly int X = 240, Y = 80;
        private int Xm, Ym;
        private Map map;
        private readonly Pen pen = new Pen(Color.Black, 1);
        private readonly SolidBrush brush = new SolidBrush(Color.Yellow);
        private readonly SolidBrush brushOver = new SolidBrush(Color.Orange);
        private readonly SolidBrush redBrush = new SolidBrush(Color.OrangeRed);
        private readonly SolidBrush blueBrush = new SolidBrush(Color.LightBlue);
        private Point[,] points;
        List<Point> redMarks = new List<Point>();
        List<Point> blueMarks = new List<Point>();
        int redi = -1, bluei = -1;
        Dictionary<Keys, bool> canMove = new Dictionary<Keys, bool>(8)
        {
            {Keys.W, false }, {Keys.S, false}, {Keys.A, false}, {Keys.D, false},
            {Keys.Up, false}, {Keys.Down, false},{Keys.Left, false},{Keys.Right, false}
        };
        Form2 form2 = new Form2();

        public Form1()
        {
            InitializeComponent();
            mInput.Value = m; 
            nInput.Value = n; 
            pxInput.Value = px;
            vInput.Value = v;
            Create();
            redFresh_Click(null, null);
            blueFresh_Click(null, null);
            isRed.Checked = true;
            isBlue.Checked = true;
        }

        // 时间控制台
        private void isTime_CheckedChanged(object sender, EventArgs e)
        {

            if (isTime.Checked) timer.Start();
            else timer.Stop();
        }
        private void ShowTime_Click(object sender, EventArgs e)
        {
            if (isTime.Checked)
            {
                timer.Stop();
                isTime.Checked = false;
            }
            else
            {
                timer.Start();
                isTime.Checked = true;
            }
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            time++;
            ShowTime.Text = String.Format("{0:D2}:{1:D2}:{2:D2}", time / 3600, (time / 60) % 60, time % 60);
        }
        private void timerScore_Tick(object sender, EventArgs e)
        {
            redScore.Text = "得分： " + redS;
            blueScore.Text = "得分： " + blueS;
            redScore.ForeColor = Color.Black;
            blueScore.ForeColor = Color.Black;
            timerScore.Stop();
        }
        private void fresh_Click(object sender, EventArgs e)
        {
            time = 0;
            ShowTime.Text = "00:00:00";
            isTime.Checked = false;
            timer.Stop();
        }
        private void vInput_ValueChanged(object sender, EventArgs e)
        {
            v = vInput.Value;
            timerMove.Interval = 1000 / v;
        }
        private void timerMove_Tick(object sender, EventArgs e)
        {
            foreach (KeyValuePair<Keys, bool> a in canMove)
            {
                if (a.Value) MovePlayer(a.Key);
            }
            WinCheck();
        }
        private void timerMouseRed_Tick(object sender, EventArgs e)
        {
            redPlayer.Left = button.X + MousePosition.X - cursor.X;
            redPlayer.Top = button.Y + MousePosition.Y - cursor.Y;
        }
        private void timerMouseBlue_Tick(object sender, EventArgs e)
        {
            bluePlayer.Left = button.X + MousePosition.X - cursor.X;
            bluePlayer.Top = button.Y + MousePosition.Y - cursor.Y;
        }

        // 迷宫控制台
        private void mInput_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) creatMap_Click(null, null);
        }
        private void nInput_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) creatMap_Click(null, null);
        }
        private void pxInput_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) creatMap_Click(null, null);
        }
        private void creatMap_Click(object sender, EventArgs e)
        {
            Create();
            Invalidate();
        }

        // 角色控制台
        private void isRed_CheckedChanged(object sender, EventArgs e)
        {
            if (isRed.Checked) redPlayer.Visible = true;
            else redPlayer.Visible = false;
        }
        private void isBlue_CheckedChanged(object sender, EventArgs e)
        {
            if (isBlue.Checked) bluePlayer.Visible = true;
            else bluePlayer.Visible = false;
        }
        private void redFresh_Click(object sender, EventArgs e)
        {
            redHistory = redPlayer.Location;
            redPlayer.Width = redPlayer.Height = pxPlayer;
            redPlayer.Left = X + px / 6;
            redPlayer.Top = Y + px / 6;
            redPlayer.Location = new Point(redPlayer.Left, redPlayer.Top);
            canMove[Keys.W] = canMove[Keys.S] = canMove[Keys.A] = canMove[Keys.D] = false;
        }
        private void blueFresh_Click(object sender, EventArgs e)
        {
            blueHistory = bluePlayer.Location;
            bluePlayer.Width = bluePlayer.Height = pxPlayer;
            bluePlayer.Left = X + px * (n - 1) + px / 6;
            bluePlayer.Top = Y + px * (m - 1) + px / 6;
            bluePlayer.Location = new Point(bluePlayer.Left, bluePlayer.Top);
            canMove[Keys.Up] = canMove[Keys.Down] = canMove[Keys.Left] = canMove[Keys.Right] = false;
        }
        private void redPlayer_Enter(object sender, EventArgs e)
        {
            button = redPlayer.Location;
            cursor = MousePosition;
            timerMouseRed.Start();
        }
        private void bluePlayer_Enter(object sender, EventArgs e)
        {
            button = bluePlayer.Location;
            cursor = MousePosition;
            timerMouseBlue.Start();
        }
        private void redPlayer_MouseCaptureChanged(object sender, EventArgs e)
        {
            if (redPlayer.Left < X || redPlayer.Top < Y || redPlayer.Right > Xm || redPlayer.Bottom > Ym)
                redPlayer.Location = button;
            timerMouseRed.Stop();
            focusLock.Focus();
            WinCheck();
        }
        private void bluePlayer_MouseCaptureChanged(object sender, EventArgs e)
        {
            if (bluePlayer.Left < X || bluePlayer.Top < Y || bluePlayer.Right > Xm || bluePlayer.Bottom > Ym)
                bluePlayer.Location = button;
            timerMouseBlue.Stop();
            focusLock.Focus();
            WinCheck();
        }
        private void start_Click(object sender, EventArgs e)
        {
            if (timerMove.Enabled)
            {
                start.ForeColor = Color.Red;
                start.Text = "游戏状态：停止";
                timerMove.Enabled = false;
                isTime.Checked = false;
                canMove = new Dictionary<Keys, bool>(8)
                {
                    {Keys.W, false }, {Keys.S, false}, {Keys.A, false}, {Keys.D, false},
                    {Keys.Up, false}, {Keys.Down, false},{Keys.Left, false},{Keys.Right, false}
                 };
            }
            else
            {
                start.ForeColor = Color.Green;
                start.Text = "游戏状态：进行";
                timerMove.Enabled = true;
                isTime.Checked = true;
            }
        }

        // 迷宫重绘方法
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.FillRectangle(brush, X, Y, px, px);
            g.FillRectangle(brush, Xm - px, Ym - px, px, px);
            if (redOver) g.FillRectangle(brushOver, Xm - px, Ym - px, px, px);
            if (blueOver) g.FillRectangle(brushOver, X, Y, px, px);
            foreach (Point p in redMarks)
            {
                g.FillRectangle(redBrush, p.X, p.Y, pxPlayer, pxPlayer);
            }
            foreach (Point p in blueMarks)
            {
                g.FillRectangle(blueBrush, p.X, p.Y, pxPlayer, pxPlayer);
            }
            for (int i = 0; i < points.GetLength(1); i++)
            {
                g.DrawLine(pen, points[0, i], points[1, i]);
            }
        }

        // 重写系统按键方法
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            try
            {
                if (!canMove[keyData]) canMove[keyData] = true;
                focusLock.Focus();
                debug.Text = keyData.ToString();
                return true;
            }
            catch
            {
                switch (keyData)
                {
                    case Keys.Space:
                        redi = redMarks.Count;
                        redMarks.Add(redPlayer.Location);
                        break;
                    case Keys.Decimal:
                        bluei = blueMarks.Count;
                        blueMarks.Add(bluePlayer.Location);
                        break;
                    case Keys.L: start_Click(null, null); break;
                    case Keys.K: creatMap_Click(null, null); break;
                    case Keys.F:
                        if (redOver) fresh_Click(null, null); creatMap_Click(null, null); start_Click(null, null); break;
                    case Keys.NumPad0:
                        if (blueOver) fresh_Click(null, null); creatMap_Click(null, null); start_Click(null, null); break;
                    case Keys.Q: redFresh_Click(null, null); break;
                    case Keys.OemQuestion: blueFresh_Click(null, null); break;
                    case Keys.E: redPlayer.Location = redHistory; break;
                    case Keys.Oem7: bluePlayer.Location = blueHistory; break;
                    case Keys.D1:
                        if (redMarks.Count == 0) break;
                        if (redi == -1) redi = redMarks.Count - 1;
                        redPlayer.Location = redMarks[redi--];
                        break;
                    case Keys.D3:
                        if (redMarks.Count == 0) break;
                        if (redi == redMarks.Count - 1) redi = -1;
                        redPlayer.Location = redMarks[++redi];
                        break;
                    case Keys.NumPad1:
                        if (blueMarks.Count == 0) break;
                        if (bluei == -1) bluei = blueMarks.Count - 1;
                        bluePlayer.Location = blueMarks[bluei--];
                        break;
                    case Keys.NumPad3:
                        if (blueMarks.Count == 0) break;
                        if (bluei == blueMarks.Count - 1) bluei = -1;
                        bluePlayer.Location = blueMarks[++bluei];
                        break;
                }
                Invalidate();
                debug.Text = keyData.ToString();
                return false;
            }
        }
        private void focusLock_KeyUp(object sender, KeyEventArgs e)
        {
            if (canMove.ContainsKey(e.KeyCode)) canMove[e.KeyCode] = false;
        }

        // 菜单
        private void 记录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            start_Click(null, null);
            form2.ShowDialog();
        }
        private void 关于ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            start_Click(null, null);
            MessageBox.Show("西安交通大学 全校通识选修课\nGNED100727 计算思维与程序设计02 (20222)\n教师：杨琦\n作者：2225015585 物试2202 黄得清\n2023年6月", "关于");
        }
        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        // 非系统创建的方法
        private void Create()
        {
            m = (int)mInput.Value;
            n = (int)nInput.Value;
            px = (int)pxInput.Value;
            redOver = blueOver = false;
            map = new Map(m, n);
            pxPlayer = px * 2 / 3;
            Xm = X + px * n;
            Ym = Y + px * m;
            redFresh_Click(null, null);
            blueFresh_Click(null, null);
            redHistory = redPlayer.Location;
            blueHistory = bluePlayer.Location;
            redMarks = new List<Point>();
            blueMarks = new List<Point>();
            points = map.DrawPoints(X, Y, px);
        }
        private bool Allow(int x, int y)
        {
            if (x < X || y < Y || x + pxPlayer > Xm || y + pxPlayer > Ym) return false;
            Element e1 = map.map[(x - X) / px, (y - Y) / px];
            Element e2 = map.map[(x + pxPlayer - X - 1) / px, (y - Y) / px];
            Element e3 = map.map[(x - X) / px, (y + pxPlayer - Y - 1) / px];
            Element e4 = map.map[(x + pxPlayer - X - 1) / px, (y + pxPlayer - Y - 1) / px];
            if (e1 == e2 && e2 == e3 && e3 == e4) return true;
            else if (e1 == e2 && e3 == e4 && !e1.s) return true;
            else if (e1 == e3 && e2 == e4 && !e1.d) return true;
            else if (!e1.s && !e1.d && !e4.w && !e4.a) return true;
            else return false;
        }
        private void MovePlayer(Keys k)
        {
            switch (k)
            {
                case Keys.W:
                    if (Allow(redPlayer.Left, redPlayer.Top - 1)) redPlayer.Top--;
                    break;
                case Keys.S:
                    if (Allow(redPlayer.Left, redPlayer.Top + 1)) redPlayer.Top++;
                    break;
                case Keys.A:
                    if (Allow(redPlayer.Left - 1, redPlayer.Top)) redPlayer.Left--;
                    break;
                case Keys.D:
                    if (Allow(redPlayer.Left + 1, redPlayer.Top)) redPlayer.Left++;
                    break;
                case Keys.Up:
                    if (Allow(bluePlayer.Left, bluePlayer.Top - 1)) bluePlayer.Top--;
                    break;
                case Keys.Down:
                    if (Allow(bluePlayer.Left, bluePlayer.Top + 1)) bluePlayer.Top++;
                    break;
                case Keys.Left:
                    if (Allow(bluePlayer.Left - 1, bluePlayer.Top)) bluePlayer.Left--;
                    break;
                case Keys.Right:
                    if (Allow(bluePlayer.Left + 1, bluePlayer.Top)) bluePlayer.Left++;
                    break;
            }
        }
        private void WinCheck()
        {
            if (!redOver && (redPlayer.Left - X) / px == n - 1 && (redPlayer.Top - Y) / px == m - 1)
            {
                redS++;
                redScore.ForeColor = Color.Red;
                redScore.Text += " + 1";
                redOver = true;
                timerScore.Start();
                Invalidate();
                form2.ScoreofRed.Items.Add(redS + "  " + ShowTime.Text + "  " + DateTime.Now.ToString("yyyy/MM/dd  HH:mm:ss"));
            }
            if (!blueOver && (bluePlayer.Right - X) / px == 0 && (bluePlayer.Bottom - Y) / px == 0)
            {
                blueS++;
                blueScore.ForeColor = Color.Blue;
                blueScore.Text += " + 1";
                blueOver = true;
                timerScore.Start();
                Invalidate();
                form2.ScoreofBlue.Items.Add(blueS + "  " + ShowTime.Text + "  " + DateTime.Now.ToString("yyyy/MM/dd  HH:mm:ss"));
            }
        }

    }
}
