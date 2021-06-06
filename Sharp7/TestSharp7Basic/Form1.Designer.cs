
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
            this.Login = new System.Windows.Forms.Label();
            this.Change = new System.Windows.Forms.Button();
            this.Input = new System.Windows.Forms.TextBox();
            this.ckbModule1 = new System.Windows.Forms.CheckBox();
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
            // Change
            // 
            this.Change.Location = new System.Drawing.Point(0, 38);
            this.Change.Name = "Change";
            this.Change.Size = new System.Drawing.Size(112, 29);
            this.Change.TabIndex = 1;
            this.Change.Text = "Change Data";
            this.Change.UseVisualStyleBackColor = true;
            this.Change.Click += new System.EventHandler(this.btnClick_Change);
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
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.ckbModule1);
            this.Controls.Add(this.Input);
            this.Controls.Add(this.Change);
            this.Controls.Add(this.Login);
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewControlSetting";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Login;
        private System.Windows.Forms.Button Change;
        private System.Windows.Forms.TextBox Input;
        private System.Windows.Forms.CheckBox ckbModule1;
    }
}