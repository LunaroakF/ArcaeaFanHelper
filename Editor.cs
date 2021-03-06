﻿using System;
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
        int pgball;
        int cha;
        string[] pbstr;
        bool RUNNING;//是否正在处理
        float superduoble;
        bool bszhengshu=false;
        string arcaea = "ArcaeaTimeEditor v2.2";//标题
        public Editor()
        {
            InitializeComponent();
            System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = false;
        }
        private void Editor_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }  
        private void Editor_Load(object sender, EventArgs e)
        {
            this.Text = arcaea;//修改窗口标题为string_arcaea
        }
        private void input_TextChanged(object sender, EventArgs e)
        {
            
        }
        public void refload()
        {
            progressBar1.Minimum = 0;
            progressBar1.Maximum = pgball;
            var a = this.output.Lines.GetUpperBound(0);
            progressBar1.Value = a;
            ywc.Text = "已完成:" + a;

            this.output.SelectionStart = this.output.Text.Length;
            this.output.SelectionLength = 0;
            this.output.ScrollToCaret();
            System.Windows.Forms.Application.DoEvents();
        }


        private void Run_Click(object sender, EventArgs e)//开始工作
        {
            try
            {
                if (Convert.ToSingle(Speed.Text) - 0 == 0)
                {
                    RUNNING = false;
                    Stopbt.Enabled = false;
                    Stopbt.Text = "错误";
                    this.Text = arcaea + " - " + "错误";
                    System.Windows.Forms.Application.DoEvents();
                    MessageBox.Show("无法转换数据，变速倍数不允许为0", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Text = arcaea;
                    Stopbt.Visible = false;
                    Stopbt.Text = "终止";
                    Stopbt.Enabled = true;
                    return;
                }

            }
            catch {
                RUNNING = false;
                Stopbt.Enabled = false;
                Stopbt.Text = "错误";
                this.Text = arcaea + " - " + "错误";
                System.Windows.Forms.Application.DoEvents();
                MessageBox.Show("无法转换数据，变速倍数为无效数据，若不需要此功能请输入1", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Text = arcaea;
                Stopbt.Visible = false;
                Stopbt.Text = "终止";
                Stopbt.Enabled = true;
                return;
            }

            Thread thread = new Thread(new ThreadStart(mancel));
            thread.Start();
            Stopbt.Visible = true;
            Stopbt.Enabled = false;
            //  mancel();
        }

        public void mancel()//主线程调用过来，开始处理
        {
            if (bszhengshu)
            {
                superduoble = 1;
            }

            else {
                superduoble = Convert.ToSingle(Speed.Text);
            }
            try
            {

                try
                {
                    iptept.Enabled = false;
                    Run.Enabled = false;
                    Starttime.Enabled = false;
                    Speed.Enabled = false;
                    Copybt.Enabled = false;
                    input.ReadOnly = true;
                    if (bszhengshu)
                    {
                        Run.Text = "二次处理中";
                        this.Text = arcaea + " - " + "二次处理中......";
                    }
                    else
                    { 
                        Run.Text = "处理中";
                        this.Text = arcaea + " - " + "处理中......";
                    }
                    rwhs.Text = "任务队列:" +"获取中......";

                    System.Windows.Forms.Application.DoEvents();
                    string main;
                    int i;
                    string[] str;
                    if (bszhengshu == false)
                    {
                        i = 0;
                        str = new string[this.input.Lines.Length];
                        for (i = 0; i < this.input.Lines.Length; i++)
                        {
                            str[i] = this.input.Lines[i];
                        }
                        main = str[0];
                    }
                    else
                    {

                        i = 0;
                        str = new string[this.SpeedRedo.Lines.Length];
                        for (i = 0; i < this.SpeedRedo.Lines.Length; i++)
                        {
                            str[i] = this.SpeedRedo.Lines[i];
                        }
                        main = str[0];
                    }
                    load = i;
                    pgball = i;
                    rwhs.Text = "任务队列:" + i.ToString();
                    Stopbt.Enabled = true;
                    string[] sArray = main.Split('(');
                    main = sArray[1];
                    sArray = main.Split(',');
                    main = sArray[0];
                    //MessageBox.Show(main);
                    float a = Convert.ToSingle(main)+0.5f;
                    //MessageBox.Show(((int)a).ToString());
                    cha = int.Parse(Starttime.Text) - (int) a;
                    //MessageBox.Show(cha.ToString());

                    if (input.Text != string.Empty)
                    {
                        if (Starttime.Text != string.Empty)
                        {
                            Stopbt.Visible = true;
                            RUNNING = true;
                            Starttime.Enabled = false;
                            Speed.Enabled = false;
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
                            iptept.Enabled = true;
                            Starttime.Enabled = true;
                            Speed.Enabled = true;
                            bszhengshu = false;
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
                        iptept.Enabled = true;
                        Starttime.Enabled = true;
                        Speed.Enabled = true;
                        bszhengshu = false;
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
                    Starttime.Enabled = true;
                    Speed.Enabled = true;
                    Stopbt.Enabled = false;
                    bszhengshu = false;
                    iptept.Enabled = true;
                    Stopbt.Text = "错误";
                    this.Text = arcaea + " - " + "错误";
                    System.Windows.Forms.Application.DoEvents();
                    string thing = "无法转换数据" + System.Environment.NewLine + "- 请确认输入框第一行不为空" + System.Environment.NewLine + "- 符合要求的数据格式应是:" + System.Environment.NewLine + "   ''timing(a,b,c);' " + System.Environment.NewLine + "   ''hold(a,b,c);''" + System.Environment.NewLine + "   ''arc(a,b,c,d,e,f,g,h,i,j);''" + System.Environment.NewLine + "   ''arc(a,b,c,d,e,f,g,h,i,j)[arctap(k)······];''" + System.Environment.NewLine + "   ''(a,b);''" + System.Environment.NewLine + "   ''camera(a,b,c,d,e,f,g,h,i);''" + System.Environment.NewLine + "- 开始位置参数应为整数 且数值小于10^9";
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
            catch
            {
                iptept.Enabled = true;
                MessageBox.Show("无法转换数据，变速倍数为无效数据，若不需要此功能请输入1", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void rap(int tim,string[] str)//处理总集，到处调用
        {
            string main = str[tim];
            string test = main;
            string[] sArray = main.Split('(');
            main = sArray[0];
            if (main == "timing")
            {
                sArray = sArray[1].Split(',');
                main = sArray[0];
                float a = Convert.ToSingle(main) + 0.5f;
                int b = (int)a;
                main = ((int)((b+cha)/superduoble)).ToString();
                TimingDisplay(tim, main, str);
            }
            else if (main == "arc")//读入数据开头若为"arc"
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
                        float z = Convert.ToSingle(nb) + 0.5f;
                        int b = (int)z;
                        string aw = ((int)((b + cha) / superduoble)).ToString();//结果 例子：2500
                        comp = aw+",";
                        cost++;
                        while (cost<alltype)
                        {
                            string[] a2 = d[cost].Split('(');
                            a2 = a2[1].Split(')');
                            string nb2 = a2[0];
                            float x = Convert.ToSingle(nb2) + 0.5f;
                            int g = (int)x;
                            string aw2 = ((int)((g + cha) / superduoble)).ToString();//结果 例子：2500
                            comp = comp + aw2 + ",";
                            cost++;
                        }
                        

                        {
                            c = c[1].Split(')');
                            string tap = ((int.Parse(c[0]) + cha) / superduoble).ToString();
                            sArray = sArray[1].Split(',');
                            main = sArray[0];
                            float x = Convert.ToSingle(main) + 0.5f;
                            int g = (int)x;
                            string cost1 = ((int)((g + cha) / superduoble)).ToString();
                            main = sArray[1];
                            float v = Convert.ToSingle(main) + 0.5f;
                            int pa = (int)v;
                            string cost2 = ((int)((pa + cha) / superduoble)).ToString();
                            ArctapDisplay(tim, cost1, cost2, comp.Split(','), str);
                            // ArctapDisplay(tim, cost1, cost2, tap, str);
                        }
                    }
                }
                catch
                {
                    sArray = sArray[1].Split(',');
                    main = sArray[0];
                    float a = Convert.ToSingle(main) + 0.5f;
                    int b = (int)a;
                    string cost1 = ((int)((b + cha) / superduoble)).ToString();
                    main = sArray[1];
                    a = Convert.ToSingle(main) + 0.5f;
                    b = (int)a;
                    string cost2 = ((int)((b + cha) / superduoble)).ToString();
                    ArcDisplay(tim, cost1, cost2, str);
                }
            }
            else if (main == "")//读入数据开头若为空
            {
                if (str[tim] != string.Empty)
                {
                    sArray = sArray[1].Split(',');
                    main = sArray[0];
                    float a = Convert.ToSingle(main) + 0.5f;
                    int b = (int)a;
                    string cost1 = ((int)((b + cha) / superduoble)).ToString();
                    sArray = sArray[1].Split(')');
                    EmptyDisplay(tim, cost1, sArray[0], str);
                }
                else
                {
                    output.Text = output.Text + string.Empty + Environment.NewLine;
                    refload();
                }
            }
            else if (main == "hold")//读入数据开头若为"hold"
            {
                sArray = sArray[1].Split(',');
                main = sArray[0];
                float a = Convert.ToSingle(main) + 0.5f;
                int b = (int)a;
                string cost1 = ((int)((b + cha) / superduoble)).ToString();
                main = sArray[1];
                a = Convert.ToSingle(main) + 0.5f;
                b = (int)a;
                string cost2 = ((int)((b + cha) / superduoble)).ToString();
                HoldDisplay(tim, cost1, cost2, str);
            }
            else if (main == "camera")//读入数据开头若为"camera"
            {
                sArray = sArray[1].Split(',');
                main = sArray[0];
                float a = Convert.ToSingle(main) + 0.5f;
                int b = (int)a;
                main = ((int)((b + cha) / superduoble)).ToString();
                if (bszhengshu)
                {
                    main = int.Parse(main).ToString();
                }
                CameraDisplay(tim, main, str);
            }
            else
            {
                RUNNING = false;
                Stopbt.Enabled = false;
                iptept.Enabled = true;
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
                Starttime.Enabled = true;
                Speed.Enabled = true;
                Copybt.Enabled = true;
                input.ReadOnly = false;
                Run.Text = "转换";
                output.ReadOnly = false;
                System.Windows.Forms.Application.DoEvents();
            }finally
            {
                Run.Enabled = true;
                Starttime.Enabled = true;
                Speed.Enabled = true;
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
        public void TimingDisplay(int time,string cost,string[] str)//timing的输出
        {
            string main = str[time];
            string[] sArray = main.Split(',');
            main = "," + sArray[1] + "," + sArray[2];
            output.Text = output.Text + "timing(" + cost + main+ Environment.NewLine;
            System.Windows.Forms.Application.DoEvents();
            refload();
        }
        public void EmptyDisplay(int time, string cost1,string cost2, string[] str)//单个键的输出
        {
            string main = str[time];
            string[] sArray = main.Split(',');
            main = ");";
            output.Text = output.Text + "(" + cost1 + "," + cost2 + main + Environment.NewLine;
            refload();
        }
        public void CameraDisplay(int time,string cost,string[] str)//camera的输出
        {
            string main = str[time];
            string[] sArray = main.Split(',');
            main = ","+sArray[1]+","+sArray[2] + "," + sArray[3] + "," + sArray[4] + "," + sArray[5] + "," + sArray[6] + "," + sArray[7] + "," + sArray[8];
            output.Text = output.Text + "camera(" + cost + main+ Environment.NewLine;
            refload();
        }
        public void ArcDisplay(int time, string cost1,string cost2, string[] str)//arc的输出
        {
            string main = str[time];
            string[] sArray = main.Split(',');
            main = "," + sArray[2] + "," + sArray[3] + "," + sArray[4] + "," + sArray[5] + "," + sArray[6] + "," + sArray[7] + "," + sArray[8] + "," + sArray[9] ;
            output.Text = output.Text + "arc(" + cost1+","+cost2 + main + Environment.NewLine;
            refload();
        }
        public void ArctapDisplay(int time, string cost1, string cost2,string[] tap, string[] str)//arctap的输出
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
        public void HoldDisplay(int time, string cost1, string cost2, string[] str)//Hold的输出
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
        public void Stop()//终止调用
        {
            RUNNING = false;
            Stopbt.Enabled = false;
            Starttime.Enabled = true;
            Speed.Enabled = true;
            bszhengshu = false;
            Stopbt.Text = "已终止";
            iptept.Enabled = true;
            this.Text = arcaea;
            System.Windows.Forms.Application.DoEvents();
            Thread.Sleep(300);
            Stopbt.Visible = false;
            Stopbt.Text = "终止";
            Stopbt.Enabled = true;
        }
        public void Ok()//处理完毕调用
        {
            if (bszhengshu == false)
            {
                if (Convert.ToSingle(Speed.Text) - 1 == 0)
                {
                    bszhengshu = true;
                    Ok();
                    return;
                }

                bszhengshu = true;
                SpeedRedo.Text = output.Text;
                Run.Text = "二次处理中";
                System.Windows.Forms.Application.DoEvents();
                mancel();
                return;
            }
            Starttime.Enabled = true;
            Speed.Enabled = true;
            bszhengshu = false;
            RUNNING = false;
            iptept.Enabled = true;
            Stopbt.Enabled = false;
            Stopbt.Text = "已完成";
            this.Text = arcaea + " - " + "已完成";
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
        public void Error()//出错调用
        {
            RUNNING = false;
            Starttime.Enabled = true;
            Speed.Enabled = true;
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
        private void Soundck_CheckedChanged(object sender, EventArgs e)//声音提醒
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
