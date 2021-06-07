
namespace TestSharp7Basic
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
            this.components = new System.ComponentModel.Container();
            this.Login = new System.Windows.Forms.Label();
            this.btnChange = new System.Windows.Forms.Button();
            this.Input = new System.Windows.Forms.TextBox();
            this.ckbModule1 = new System.Windows.Forms.CheckBox();
            this.cbData = new System.Windows.Forms.ComboBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.btnIncrease = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lbDisplay = new System.Windows.Forms.Label();
            this.tbNum = new System.Windows.Forms.TextBox();
            this.lbTimeDisplay = new System.Windows.Forms.Label();
            this.btnTimer = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Login
            // 
            this.Login.AutoSize = true;
            this.Login.Location = new System.Drawing.Point(0, 0);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(0, 20);
            this.Login.TabIndex = 0;
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(0, 38);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(112, 29);
            this.btnChange.TabIndex = 1;
            this.btnChange.Text = "Change Data";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnClick_Change);
            // 
            // Input
            // 
            this.Input.Location = new System.Drawing.Point(0, 88);
            this.Input.Name = "Input";
            this.Input.Size = new System.Drawing.Size(226, 27);
            this.Input.TabIndex = 2;
            // 
            // ckbModule1
            // 
            this.ckbModule1.AutoSize = true;
            this.ckbModule1.Location = new System.Drawing.Point(0, 141);
            this.ckbModule1.Name = "ckbModule1";
            this.ckbModule1.Size = new System.Drawing.Size(94, 24);
            this.ckbModule1.TabIndex = 3;
            this.ckbModule1.Text = "Module 1";
            this.ckbModule1.UseVisualStyleBackColor = true;
            // 
            // cbData
            // 
            this.cbData.FormattingEnabled = true;
            this.cbData.Items.AddRange(new object[] {
            "Bùi Minh Trí",
            "Kenly Bùi",
            "Bùi Văn Tùng",
            "Trần Thị Thu Hường"});
            this.cbData.Location = new System.Drawing.Point(4, 241);
            this.cbData.Name = "cbData";
            this.cbData.Size = new System.Drawing.Size(186, 28);
            this.cbData.TabIndex = 4;
            this.cbData.SelectedIndexChanged += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(6, 194);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(184, 29);
            this.btnLoad.TabIndex = 1;
            this.btnLoad.Text = "Load list DATA";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnClick_Change);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(7, 306);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(176, 92);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(290, 38);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(870, 360);
            this.listView1.TabIndex = 6;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // btnIncrease
            // 
            this.btnIncrease.Location = new System.Drawing.Point(14, 458);
            this.btnIncrease.Name = "btnIncrease";
            this.btnIncrease.Size = new System.Drawing.Size(94, 29);
            this.btnIncrease.TabIndex = 7;
            this.btnIncrease.Text = "Increaces";
            this.btnIncrease.UseVisualStyleBackColor = true;
            this.btnIncrease.Click += new System.EventHandler(this.btnIncearces_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(138, 458);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 29);
            this.button2.TabIndex = 7;
            this.button2.Text = "Show";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // lbDisplay
            // 
            this.lbDisplay.AutoSize = true;
            this.lbDisplay.Location = new System.Drawing.Point(165, 512);
            this.lbDisplay.Name = "lbDisplay";
            this.lbDisplay.Size = new System.Drawing.Size(41, 20);
            this.lbDisplay.TabIndex = 8;
            this.lbDisplay.Text = "Num";
            // 
            // tbNum
            // 
            this.tbNum.Location = new System.Drawing.Point(14, 505);
            this.tbNum.Name = "tbNum";
            this.tbNum.Size = new System.Drawing.Size(125, 27);
            this.tbNum.TabIndex = 9;
            // 
            // lbTimeDisplay
            // 
            this.lbTimeDisplay.AutoSize = true;
            this.lbTimeDisplay.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbTimeDisplay.Location = new System.Drawing.Point(349, 506);
            this.lbTimeDisplay.Name = "lbTimeDisplay";
            this.lbTimeDisplay.Size = new System.Drawing.Size(33, 38);
            this.lbTimeDisplay.TabIndex = 10;
            this.lbTimeDisplay.Text = "0";
            // 
            // btnTimer
            // 
            this.btnTimer.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTimer.Location = new System.Drawing.Point(323, 458);
            this.btnTimer.Name = "btnTimer";
            this.btnTimer.Size = new System.Drawing.Size(92, 45);
            this.btnTimer.TabIndex = 11;
            this.btnTimer.Text = "Start";
            this.btnTimer.UseVisualStyleBackColor = true;
            this.btnTimer.Click += new System.EventHandler(this.btnTimer_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.btnTimer);
            this.Controls.Add(this.lbTimeDisplay);
            this.Controls.Add(this.tbNum);
            this.Controls.Add(this.lbDisplay);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnIncrease);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cbData);
            this.Controls.Add(this.ckbModule1);
            this.Controls.Add(this.Input);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.Login);
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewControlSetting";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Login;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.TextBox Input;
        private System.Windows.Forms.CheckBox ckbModule1;
        private System.Windows.Forms.ComboBox cbData;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button btnIncrease;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lbDisplay;
        private System.Windows.Forms.TextBox tbNum;
        private System.Windows.Forms.Label lbTimeDisplay;
        private System.Windows.Forms.Button btnTimer;
        private System.Windows.Forms.Timer timer1;
    }
}