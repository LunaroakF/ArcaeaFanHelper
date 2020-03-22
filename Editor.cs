using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace ArcaeaFanHelper
{
    public partial class Editor : Form
    {
        int load;
        int cha;
        string[] pbstr;
        bool RUNNING;
        string arcaea = "ArcaeaTimeEditor v1.7";
        public Editor()
        {
            InitializeComponent();
            System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = false;
        }
        private void Editor_Load(object sender, EventArgs e)
        {
            this.Text = arcaea;
            LT.Text = "一爪一爪堆起这个软件的是天狐基友 冥栎 腌制大狐狸";
            L.Text = "既然你能看到这些字，那说明你已经将软件进行分析或者反编译，我抱紧我的大尾巴求求你放过我一马可以吗ww?";
        }
        private void input_TextChanged(object sender, EventArgs e)
        {
            
        }
        public void refload()
        {
            this.output.SelectionStart = this.output.Text.Length;
            this.output.SelectionLength = 0;
            this.output.ScrollToCaret();
        }
        private void Run_Click(object sender, EventArgs e)
        {
            
            try
            {
                Run.Enabled = false;
                Copybt.Enabled = false;
                input.ReadOnly = true;
                Run.Text = "处理中";
                this.Text = arcaea + " - " + "处理中......";
                System.Windows.Forms.Application.DoEvents();
                int i = 0;
                string[] str = new string[this.input.Lines.Length];
                for (i = 0; i < this.input.Lines.Length; i++)
                {
                    str[i] = this.input.Lines[i];
                }
                load = i;
                string main = str[0];
                string[] sArray = main.Split('(');
                main = sArray[1];
                sArray = main.Split(',');
                main = sArray[0];
                cha = int.Parse(Starttime.Text) - int.Parse(main);
                //MessageBox.Show(cha.ToString());
                
                if (input.Text != string.Empty)
                {
                    if (Starttime.Text != string.Empty)
                    {
                        Stopbt.Visible = true;
                        RUNNING = true;
                        output.ReadOnly = true;
                        output.Text = string.Empty;
                        System.Windows.Forms.Application.DoEvents();
                        Thread.Sleep(100);
                        pbstr = str;
                        rap(0, str);
                        Thread thread = new Thread(new ThreadStart(Cos));
                        thread.Start();
                    }
                    else
                    {
                        MessageBox.Show("请输入目标时间", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Run.Enabled = true;
                        Copybt.Enabled = true;
                        input.ReadOnly = false;
                        Run.Text = "转换";
                        System.Windows.Forms.Application.DoEvents();
                    }
                }
                else
                {
                    MessageBox.Show("请输入数据", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Run.Enabled = true;
                    Copybt.Enabled = true;
                    input.ReadOnly = false;
                    Run.Text = "转换";
                    System.Windows.Forms.Application.DoEvents();
                }
            }
            catch
            {
                RUNNING = false;
                Stopbt.Enabled = false;
                Stopbt.Text = "错误";
                this.Text = arcaea + " - " + "错误";
                System.Windows.Forms.Application.DoEvents();
                string thing = "无法转换数据" + System.Environment.NewLine + "- 请确认输入框第一行不为空" + System.Environment.NewLine + "- 符合要求的数据格式应是:" + System.Environment.NewLine+"   ''timing(a,b,c);' " + System.Environment.NewLine+"   ''hold(a,b,c);''" + System.Environment.NewLine+"   ''arc(a,b,c,d,e,f,g,h,i,j);''" + System.Environment.NewLine+ "   ''arc(a,b,c,d,e,f,g,h,i,j)[arctap(k)······];''" + System.Environment.NewLine + "   ''(a,b);''" + System.Environment.NewLine+"   ''camera(a,b,c,d,e,f,g,h,i);''" + System.Environment.NewLine + "- 开始位置参数应为整数 且数值小于10^9";
                MessageBox.Show(thing, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Error();
                Run.Enabled = true;
                Copybt.Enabled = true;
                input.ReadOnly = false;
                this.Text = arcaea;
                Run.Text = "转换";
                System.Windows.Forms.Application.DoEvents();
            }
        }
        public void rap(int tim,string[] str)
        {
            string main = str[tim];
            string test = main;
            string[] sArray = main.Split('(');
            main = sArray[0];
            if (main == "timing")
            {
                sArray = sArray[1].Split(',');
                main = sArray[0];
                main = (int.Parse(main) + cha).ToString();
                TimingDisplay(tim, main, str);
            }
            else if (main == "arc")
            {
                try
                {
                    string[] c = test.Split('[');
                    string[] s = c;
                    test = c[1];
                    c = test.Split('(');
                    if (c[0] == "arctap")
                    {
                        string[] d = s[1].Split(']');
                        d = d[0].Split(',');
                        int alltype = CostPr(d);
                        int cost=0;
                        string comp;

                        string[] a = d[cost].Split('(');
                        a = a[1].Split(')');
                        string nb = a[0];
                        string aw = (int.Parse(nb) + cha).ToString();//结果 例子：2500
                        comp = aw+",";
                        cost++;
                        while (cost<alltype)
                        {
                            string[] a2 = d[cost].Split('(');
                            a2 = a2[1].Split(')');
                            string nb2 = a2[0];
                            string aw2 = (int.Parse(nb2) + cha).ToString();//结果 例子：2500
                            comp = comp + aw2 + ",";
                            cost++;
                        }
                        

                        {
                            c = c[1].Split(')');
                            string tap = (int.Parse(c[0]) + cha).ToString();
                            sArray = sArray[1].Split(',');
                            main = sArray[0];
                            string cost1 = (int.Parse(main) + cha).ToString();
                            main = sArray[1];
                            string cost2 = (int.Parse(main) + cha).ToString();
                            ArctapDisplay(tim, cost1, cost2, comp.Split(','), str);
                            // ArctapDisplay(tim, cost1, cost2, tap, str);
                        }
                    }
                }
                catch
                {
                    sArray = sArray[1].Split(',');
                    main = sArray[0];
                    string cost1 = (int.Parse(main) + cha).ToString();
                    main = sArray[1];
                    string cost2 = (int.Parse(main) + cha).ToString();
                    ArcDisplay(tim, cost1, cost2, str);
                }
            }
            else if (main == "")
            {
                if (str[tim] != string.Empty)
                {
                    sArray = sArray[1].Split(',');
                    main = sArray[0];
                    string cost1 = (int.Parse(main) + cha).ToString();
                    sArray = sArray[1].Split(')');
                    EmptyDisplay(tim, cost1, sArray[0], str);
                }
                else
                {
                    output.Text = output.Text + string.Empty + Environment.NewLine;
                    refload();
                }
            }
            else if (main == "hold")
            {
                sArray = sArray[1].Split(',');
                main = sArray[0];
                string cost1 = (int.Parse(main) + cha).ToString();
                main = sArray[1];
                string cost2 = (int.Parse(main) + cha).ToString();
                HoldDisplay(tim, cost1, cost2, str);
            }
            else if (main == "camera")
            {
                sArray = sArray[1].Split(',');
                main = sArray[0];
                main = (int.Parse(main) + cha).ToString();
                CameraDisplay(tim, main, str);
            }
            else
            {
                RUNNING = false;
                Stopbt.Enabled = false;
                Stopbt.Text = "错误";
                this.Text = arcaea + " - " + "错误";
                System.Windows.Forms.Application.DoEvents();
                MessageBox.Show("无法转换数据" + System.Environment.NewLine+"在第"+(tim+1).ToString()+"行 "+"有未知参数"+'"'+main+'"', "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Run.Enabled = true;
                output.ReadOnly = false;
                Copybt.Enabled = true;
                input.ReadOnly = false;
                Run.Text = "转换";
                RUNNING = false;
                this.Text = arcaea;
                System.Windows.Forms.Application.DoEvents();
                Thread thread = new Thread(new ThreadStart(Error));
                thread.Start();
            }
        }
        public void Cos()
        {
            load=load-1;
            try
            {
                int a = 0;
                while (load >= 0)
                {
                    while (RUNNING)
                    {
                        load--;
                        a++;
                        rap(a, pbstr);
                    }
                    if (RUNNING == false)
                    {
                        return;
                    }
                }
                if (RUNNING == false)
                {
                    return;
                }
            }

            catch
            {
                Run.Enabled = true;
                Copybt.Enabled = true;
                input.ReadOnly = false;
                Run.Text = "转换";
                output.ReadOnly = false;
                System.Windows.Forms.Application.DoEvents();
            }finally
            {
                Run.Enabled = true;
                Copybt.Enabled = true;
                input.ReadOnly = false;
                Run.Text = "转换";
                output.ReadOnly = false;
                RUNNING = false;
                System.Windows.Forms.Application.DoEvents();

            }
            
            Thread thread = new Thread(new ThreadStart(Ok));
            thread.Start();
        }
        public int CostPr(string[] main)
        {
            int a = 0;
            try
            {
                while (true)
                {
                    string b = main[a];
                    a++;
                }
            }
            catch {
                //a++;
                return a;
            }
        }
        public string Timepro(string get)
        {
            string[] sArray = get.Split(',');
            string sec = sArray[0].ToString();
            sArray = sec.Split('(');
            return sArray[1];
        }
        public void TimingDisplay(int time,string cost,string[] str)
        {
            string main = str[time];
            string[] sArray = main.Split(',');
            main = "," + sArray[1] + "," + sArray[2];
            output.Text = output.Text + "timing(" + cost + main+ Environment.NewLine;
            System.Windows.Forms.Application.DoEvents();
            refload();
        }
        public void EmptyDisplay(int time, string cost1,string cost2, string[] str)
        {
            string main = str[time];
            string[] sArray = main.Split(',');
            main = ");";
            output.Text = output.Text + "(" + cost1 + "," + cost2 + main + Environment.NewLine;
            refload();
        }
        public void CameraDisplay(int time,string cost,string[] str)
        {
            string main = str[time];
            string[] sArray = main.Split(',');
            main = ","+sArray[1]+","+sArray[2] + "," + sArray[3] + "," + sArray[4] + "," + sArray[5] + "," + sArray[6] + "," + sArray[7] + "," + sArray[8];
            output.Text = output.Text + "camera(" + cost + main+ Environment.NewLine;
            refload();
        }
        public void ArcDisplay(int time, string cost1,string cost2, string[] str)
        {
            string main = str[time];
            string[] sArray = main.Split(',');
            main = "," + sArray[2] + "," + sArray[3] + "," + sArray[4] + "," + sArray[5] + "," + sArray[6] + "," + sArray[7] + "," + sArray[8] + "," + sArray[9] ;
            output.Text = output.Text + "arc(" + cost1+","+cost2 + main + Environment.NewLine;
            refload();
        }
        public void ArctapDisplay(int time, string cost1, string cost2,string[] tap, string[] str)
        {
            string main = str[time];
            string[] sArray = main.Split(',');
            string[] last = sArray[9].Split('[');
            string tape="";

            main = "," + sArray[2] + "," + sArray[3] + "," + sArray[4] + "," + sArray[5] + "," + sArray[6] + "," + sArray[7] + "," + sArray[8] + "," + last[0].Split(')')[0]+")";
            int cos = CostPr(tap)-1;
            int comp=0;
            tape = "arctap(" + tap[comp] + ")";
            comp++;
            while (comp<cos)
            {
                tape = tape+","+"arctap("+tap[comp]+")";
                comp++;
            }


            output.Text = output.Text + "arc(" + cost1 + "," + cost2 + main +"["+tape+"];"+ Environment.NewLine;
            refload();
        }
        public void HoldDisplay(int time, string cost1, string cost2, string[] str)
        {
            string main = str[time];
            string[] sArray = main.Split(',');
            main = "," + sArray[2];
            output.Text = output.Text + "hold(" + cost1 + "," + cost2 + main + Environment.NewLine;
            refload();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Clipboard.SetDataObject(output.Text);
        }
        private void iptept_Click(object sender, EventArgs e)
        {
            input.Text = string.Empty;
        }

        private void Stopbt_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(new ThreadStart(Stop));
            thread.Start();
        }
        public void Stop()
        {
            RUNNING = false;
            Stopbt.Enabled = false;
            Stopbt.Text = "已终止";
            this.Text = arcaea;
            System.Windows.Forms.Application.DoEvents();
            Thread.Sleep(300);
            Stopbt.Visible = false;
            Stopbt.Text = "终止";
            Stopbt.Enabled = true;
        }
        public void Ok()
        {
            RUNNING = false;
            Stopbt.Enabled = false;
            Stopbt.Text = "已完成";
            this.Text = arcaea + " - " + "已完成"+"  "+"作者:天狐&狐冥栎";
            if (sdck)
            {
                System.Media.SystemSounds.Beep.Play();
            }
            System.Windows.Forms.Application.DoEvents();
            Thread.Sleep(1000);
            this.Text = arcaea;
            Stopbt.Visible = false;
            Stopbt.Text = "终止";
            Stopbt.Enabled = true;
        }
        public void Error()
        {
            RUNNING = false;
            Stopbt.Enabled = false;
            Stopbt.Text = "错误";
            this.Text = arcaea + " - " + "错误";
            System.Windows.Forms.Application.DoEvents();
            Thread.Sleep(300);
            this.Text = arcaea;
            Stopbt.Visible = false;
            Stopbt.Text = "终止";
            Stopbt.Enabled = true;
        }
        bool sdck = false;
        private void Soundck_CheckedChanged(object sender, EventArgs e)
        {
            if (Soundck.Checked)
            {
                sdck = true;
            }
            else
            {
                sdck = false;
            }
        }
    }
}
