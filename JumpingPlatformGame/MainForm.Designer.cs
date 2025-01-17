﻿namespace JumpingPlatformGame {
	partial class MainForm {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.worldPanel = new System.Windows.Forms.Panel();
            this.jumpingPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.joeButton = new System.Windows.Forms.Button();
            this.janeButton = new System.Windows.Forms.Button();
            this.jackButton = new System.Windows.Forms.Button();
            this.jillButton = new System.Windows.Forms.Button();
            this.updateTimer = new System.Windows.Forms.Timer(this.components);
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // worldPanel
            // 
            this.worldPanel.BackColor = System.Drawing.Color.White;
            this.worldPanel.Location = new System.Drawing.Point(16, 50);
            this.worldPanel.Margin = new System.Windows.Forms.Padding(4);
            this.worldPanel.Name = "worldPanel";
            this.worldPanel.Size = new System.Drawing.Size(1133, 512);
            this.worldPanel.TabIndex = 0;
            // 
            // jumpingPanel
            // 
            this.jumpingPanel.BackColor = System.Drawing.Color.Khaki;
            this.jumpingPanel.Location = new System.Drawing.Point(16, 570);
            this.jumpingPanel.Margin = new System.Windows.Forms.Padding(4);
            this.jumpingPanel.Name = "jumpingPanel";
            this.jumpingPanel.Size = new System.Drawing.Size(1133, 118);
            this.jumpingPanel.TabIndex = 1;
            // 
            // joeButton
            // 
            this.joeButton.Location = new System.Drawing.Point(16, 15);
            this.joeButton.Margin = new System.Windows.Forms.Padding(4);
            this.joeButton.Name = "joeButton";
            this.joeButton.Size = new System.Drawing.Size(100, 28);
            this.joeButton.TabIndex = 2;
            this.joeButton.Text = "Joe";
            this.joeButton.UseVisualStyleBackColor = true;
            this.joeButton.Click += new System.EventHandler(this.joeButton_Click);
            // 
            // janeButton
            // 
            this.janeButton.Location = new System.Drawing.Point(124, 15);
            this.janeButton.Margin = new System.Windows.Forms.Padding(4);
            this.janeButton.Name = "janeButton";
            this.janeButton.Size = new System.Drawing.Size(100, 28);
            this.janeButton.TabIndex = 3;
            this.janeButton.Text = "Jane";
            this.janeButton.UseVisualStyleBackColor = true;
            this.janeButton.Click += new System.EventHandler(this.janeButton_Click);
            // 
            // jackButton
            // 
            this.jackButton.Location = new System.Drawing.Point(232, 15);
            this.jackButton.Margin = new System.Windows.Forms.Padding(4);
            this.jackButton.Name = "jackButton";
            this.jackButton.Size = new System.Drawing.Size(100, 28);
            this.jackButton.TabIndex = 4;
            this.jackButton.Text = "Jack";
            this.jackButton.UseVisualStyleBackColor = true;
            this.jackButton.Click += new System.EventHandler(this.jackButton_Click);
            // 
            // jillButton
            // 
            this.jillButton.Location = new System.Drawing.Point(340, 15);
            this.jillButton.Margin = new System.Windows.Forms.Padding(4);
            this.jillButton.Name = "jillButton";
            this.jillButton.Size = new System.Drawing.Size(100, 28);
            this.jillButton.TabIndex = 5;
            this.jillButton.Text = "Jill";
            this.jillButton.UseVisualStyleBackColor = true;
            this.jillButton.Click += new System.EventHandler(this.jillButton_Click);
            // 
            // updateTimer
            // 
            this.updateTimer.Enabled = true;
            this.updateTimer.Interval = 40;
            this.updateTimer.Tick += new System.EventHandler(this.updateTimer_Tick);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(1156, 50);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(330, 564);
            this.listBox1.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1156, 627);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(330, 61);
            this.button1.TabIndex = 7;
            this.button1.Text = "Add customer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1503, 703);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.jillButton);
            this.Controls.Add(this.jackButton);
            this.Controls.Add(this.janeButton);
            this.Controls.Add(this.joeButton);
            this.Controls.Add(this.jumpingPanel);
            this.Controls.Add(this.worldPanel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "Jumping Platform Game";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel worldPanel;
		private System.Windows.Forms.FlowLayoutPanel jumpingPanel;
		private System.Windows.Forms.Button joeButton;
		private System.Windows.Forms.Button janeButton;
		private System.Windows.Forms.Button jackButton;
		private System.Windows.Forms.Button jillButton;
		private System.Windows.Forms.Timer updateTimer;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
    }
}

