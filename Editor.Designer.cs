namespace ArcaeaFanHelper
{
    partial class Editor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Editor));
            this.input = new System.Windows.Forms.TextBox();
            this.output = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Starttime = new System.Windows.Forms.TextBox();
            this.Run = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Copybt = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.iptept = new System.Windows.Forms.Button();
            this.Stopbt = new System.Windows.Forms.Button();
            this.Soundck = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Speed = new System.Windows.Forms.TextBox();
            this.SpeedRedo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.rwhs = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.ywc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // input
            // 
            this.input.Font = new System.Drawing.Font("微软雅黑", 8F);
            this.input.Location = new System.Drawing.Point(17, 144);
            this.input.MaxLength = 9999999;
            this.input.Multiline = true;
            this.input.Name = "input";
            this.input.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.input.Size = new System.Drawing.Size(364, 171);
            this.input.TabIndex = 0;
            this.input.WordWrap = false;
            this.input.TextChanged += new System.EventHandler(this.input_TextChanged);
            // 
            // output
            // 
            this.output.Font = new System.Drawing.Font("微软雅黑", 8F);
            this.output.Location = new System.Drawing.Point(498, 144);
            this.output.MaxLength = 9999999;
            this.output.Multiline = true;
            this.output.Name = "output";
            this.output.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.output.Size = new System.Drawing.Size(364, 171);
            this.output.TabIndex = 1;
            this.output.WordWrap = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(85, 318);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "将谱面文件中需复制的部分拷贝到上方";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(664, 318);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "结果";
            // 
            // Starttime
            // 
            this.Starttime.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Starttime.Location = new System.Drawing.Point(309, 70);
            this.Starttime.Name = "Starttime";
            this.Starttime.Size = new System.Drawing.Size(130, 26);
            this.Starttime.TabIndex = 4;
            // 
            // Run
            // 
            this.Run.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Run.Location = new System.Drawing.Point(387, 204);
            this.Run.Name = "Run";
            this.Run.Size = new System.Drawing.Size(105, 36);
            this.Run.TabIndex = 1;
            this.Run.Text = "转换";
            this.Run.UseVisualStyleBackColor = true;
            this.Run.Click += new System.EventHandler(this.Run_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(323, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "开始位置(整数)";
            // 
            // Copybt
            // 
            this.Copybt.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Copybt.Location = new System.Drawing.Point(796, 110);
            this.Copybt.Name = "Copybt";
            this.Copybt.Size = new System.Drawing.Size(66, 28);
            this.Copybt.TabIndex = 7;
            this.Copybt.Text = "复制";
            this.Copybt.UseVisualStyleBackColor = true;
            this.Copybt.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(351, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "≤10^9";
            // 
            // iptept
            // 
            this.iptept.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.iptept.Location = new System.Drawing.Point(17, 110);
            this.iptept.Name = "iptept";
            this.iptept.Size = new System.Drawing.Size(66, 28);
            this.iptept.TabIndex = 9;
            this.iptept.Text = "清空";
            this.iptept.UseVisualStyleBackColor = true;
            this.iptept.Click += new System.EventHandler(this.iptept_Click);
            // 
            // Stopbt
            // 
            this.Stopbt.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Stopbt.ForeColor = System.Drawing.Color.Red;
            this.Stopbt.Location = new System.Drawing.Point(406, 318);
            this.Stopbt.Name = "Stopbt";
            this.Stopbt.Size = new System.Drawing.Size(66, 28);
            this.Stopbt.TabIndex = 10;
            this.Stopbt.Text = "终止";
            this.Stopbt.UseVisualStyleBackColor = true;
            this.Stopbt.Visible = false;
            this.Stopbt.Click += new System.EventHandler(this.Stopbt_Click);
            // 
            // Soundck
            // 
            this.Soundck.AutoSize = true;
            this.Soundck.BackColor = System.Drawing.Color.Transparent;
            this.Soundck.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Soundck.Location = new System.Drawing.Point(262, 115);
            this.Soundck.Name = "Soundck";
            this.Soundck.Size = new System.Drawing.Size(119, 23);
            this.Soundck.TabIndex = 13;
            this.Soundck.Text = "完成后声音提醒";
            this.Soundck.UseVisualStyleBackColor = false;
            this.Soundck.CheckedChanged += new System.EventHandler(this.Soundck_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(476, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "≤10^9且≠0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(477, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "变速倍数";
            // 
            // Speed
            // 
            this.Speed.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Speed.Location = new System.Drawing.Point(445, 70);
            this.Speed.Name = "Speed";
            this.Speed.Size = new System.Drawing.Size(130, 26);
            this.Speed.TabIndex = 14;
            this.Speed.Text = "1";
            // 
            // SpeedRedo
            // 
            this.SpeedRedo.Font = new System.Drawing.Font("微软雅黑", 8F);
            this.SpeedRedo.Location = new System.Drawing.Point(794, 47);
            this.SpeedRedo.MaxLength = 9999999;
            this.SpeedRedo.Multiline = true;
            this.SpeedRedo.Name = "SpeedRedo";
            this.SpeedRedo.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.SpeedRedo.Size = new System.Drawing.Size(68, 58);
            this.SpeedRedo.TabIndex = 17;
            this.SpeedRedo.Visible = false;
            this.SpeedRedo.WordWrap = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(118, 338);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(183, 17);
            this.label7.TabIndex = 18;
            this.label7.Text = "请将camera与其他参数分开处理";
            // 
            // rwhs
            // 
            this.rwhs.AutoSize = true;
            this.rwhs.BackColor = System.Drawing.Color.Transparent;
            this.rwhs.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rwhs.Location = new System.Drawing.Point(12, 6);
            this.rwhs.Name = "rwhs";
            this.rwhs.Size = new System.Drawing.Size(76, 20);
            this.rwhs.TabIndex = 19;
            this.rwhs.Text = "任务队列:0";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(0, 0);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(877, 3);
            this.progressBar1.TabIndex = 20;
            // 
            // ywc
            // 
            this.ywc.AutoSize = true;
            this.ywc.BackColor = System.Drawing.Color.Transparent;
            this.ywc.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ywc.Location = new System.Drawing.Point(12, 27);
            this.ywc.Name = "ywc";
            this.ywc.Size = new System.Drawing.Size(62, 20);
            this.ywc.TabIndex = 21;
            this.ywc.Text = "已完成:0";
            // 
            // Editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(877, 358);
            this.Controls.Add(this.ywc);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.rwhs);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.SpeedRedo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Speed);
            this.Controls.Add(this.Soundck);
            this.Controls.Add(this.Stopbt);
            this.Controls.Add(this.iptept);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Copybt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Run);
            this.Controls.Add(this.Starttime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.output);
            this.Controls.Add(this.input);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Editor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ArcaeaTimeEditor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Editor_FormClosing);
            this.Load += new System.EventHandler(this.Editor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox input;
        private System.Windows.Forms.TextBox output;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Starttime;
        private System.Windows.Forms.Button Run;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Copybt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button iptept;
        private System.Windows.Forms.Button Stopbt;
        private System.Windows.Forms.CheckBox Soundck;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Speed;
        private System.Windows.Forms.TextBox SpeedRedo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label rwhs;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label ywc;
    }
}

