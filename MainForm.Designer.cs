using System;
using System.Drawing;

namespace _7typingAPP
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainPanel = new _7typingAPP.MainPanel();
            this.modeSelectionPanel = new _7typingAPP.ModeSelectionPanel();
            this.typingInstructionPanel = new _7typingAPP.TypingInstructionPanel();
            this.typingPracticePanel = new _7typingAPP.TypingPracticePanel();
            this.virtualKeyboardPanel = new _7typingAPP.VirtualKeyboardPanel();
            this.statisticsPanel = new _7typingAPP.StatisticsPanel();
            this.typingPracticePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.Transparent;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(600, 450);
            this.mainPanel.TabIndex = 4;
            // 
            // modeSelectionPanel
            // 
            this.modeSelectionPanel.BackColor = System.Drawing.Color.Transparent;
            this.modeSelectionPanel.Location = new System.Drawing.Point(0, 0);
            this.modeSelectionPanel.Name = "modeSelectionPanel";
            this.modeSelectionPanel.Size = new System.Drawing.Size(600, 450);
            this.modeSelectionPanel.TabIndex = 3;
            // 
            // typingInstructionPanel
            // 
            this.typingInstructionPanel.BackColor = System.Drawing.Color.Transparent;
            this.typingInstructionPanel.BackgroundImage = global::_7typingAPP.Properties.Resources._18bf71_271830_1920_1080__1_;
            this.typingInstructionPanel.Location = new System.Drawing.Point(0, 0);
            this.typingInstructionPanel.Name = "typingInstructionPanel";
            this.typingInstructionPanel.Size = new System.Drawing.Size(600, 450);
            this.typingInstructionPanel.TabIndex = 2;
            // 
            // typingPracticePanel
            // 
            this.typingPracticePanel.BackColor = System.Drawing.Color.Transparent;
            this.typingPracticePanel.Controls.Add(this.virtualKeyboardPanel);
            this.typingPracticePanel.Location = new System.Drawing.Point(0, 0);
            this.typingPracticePanel.Name = "typingPracticePanel";
            this.typingPracticePanel.Size = new System.Drawing.Size(600, 200);
            this.typingPracticePanel.TabIndex = 1;
            // 
            // virtualKeyboardPanel
            // 
            this.virtualKeyboardPanel.BackColor = System.Drawing.Color.Transparent;
            this.virtualKeyboardPanel.Location = new System.Drawing.Point(3, 203);
            this.virtualKeyboardPanel.Name = "virtualKeyboardPanel";
            this.virtualKeyboardPanel.Size = new System.Drawing.Size(600, 450);
            this.virtualKeyboardPanel.TabIndex = 0;
            // 
            // statisticsPanel
            // 
            this.statisticsPanel.BackColor = System.Drawing.Color.Transparent;
            this.statisticsPanel.Location = new System.Drawing.Point(0, 0);
            this.statisticsPanel.Name = "statisticsPanel";
            this.statisticsPanel.Size = new System.Drawing.Size(600, 450);
            this.statisticsPanel.TabIndex = 5;
            // 
            // MainForm
            // 
            this.BackgroundImage = global::_7typingAPP.Properties.Resources._18bf71_271830_1920_1080__1_;
            this.ClientSize = new System.Drawing.Size(600, 450);
            this.Controls.Add(this.statisticsPanel);
            this.Controls.Add(this.typingInstructionPanel);
            this.Controls.Add(this.typingPracticePanel);
            this.Controls.Add(this.modeSelectionPanel);
            this.Controls.Add(this.mainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Typing Trainer";
            this.typingPracticePanel.ResumeLayout(false);
            this.typingPracticePanel.PerformLayout();
            this.ResumeLayout(false);

        }
    }
}
#endregion