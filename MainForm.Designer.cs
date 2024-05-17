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
            this.mainPanel = new _7typingAPP.MainPanel();
            this.modeSelectionPanel = new _7typingAPP.ModeSelectionPanel();
            this.typingInstructionPanel = new _7typingAPP.TypingInstructionPanel();
            this.typingPracticePanel = new _7typingAPP.TypingPracticePanel();
            this.virtualKeyboardPanel = new _7typingAPP.VirtualKeyboardPanel();
            this.statisticsPanel = new _7typingAPP.StatisticsPanel();
            this.settingsPanel = new _7typingAPP.SettingsPanel();
            this.typingPracticePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(600, 450);
            this.mainPanel.TabIndex = 4;
            // 
            // modeSelectionPanel
            // 
            this.modeSelectionPanel.Location = new System.Drawing.Point(0, 0);
            this.modeSelectionPanel.Name = "modeSelectionPanel";
            this.modeSelectionPanel.Size = new System.Drawing.Size(600, 450);
            this.modeSelectionPanel.TabIndex = 3;
            // 
            // typingInstructionPanel
            // 
            this.typingInstructionPanel.Location = new System.Drawing.Point(0, 0);
            this.typingInstructionPanel.Name = "typingInstructionPanel";
            this.typingInstructionPanel.Size = new System.Drawing.Size(600, 450);
            this.typingInstructionPanel.TabIndex = 2;
            // 
            // typingPracticePanel
            // 
            this.typingPracticePanel.Controls.Add(this.virtualKeyboardPanel);
            this.typingPracticePanel.Location = new System.Drawing.Point(0, 0);
            this.typingPracticePanel.Name = "typingPracticePanel";
            this.typingPracticePanel.Size = new System.Drawing.Size(600, 200);
            this.typingPracticePanel.TabIndex = 1;
            // 
            // virtualKeyboardPanel
            // 
            this.virtualKeyboardPanel.Location = new System.Drawing.Point(3, 203);
            this.virtualKeyboardPanel.Name = "virtualKeyboardPanel";
            this.virtualKeyboardPanel.Size = new System.Drawing.Size(600, 450);
            this.virtualKeyboardPanel.TabIndex = 0;
            // 
            // statisticsPanel
            // 
            this.statisticsPanel.Location = new System.Drawing.Point(0, 0);
            this.statisticsPanel.Name = "statisticsPanel";
            this.statisticsPanel.Size = new System.Drawing.Size(600, 450);
            this.statisticsPanel.TabIndex = 5;
            // 
            // settingsPanel
            // 
            this.settingsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.settingsPanel.Location = new System.Drawing.Point(0, 0);
            this.settingsPanel.Name = "settingsPanel";
            this.settingsPanel.Size = new System.Drawing.Size(600, 450);
            this.settingsPanel.TabIndex = 6;
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(600, 450);
            this.Controls.Add(this.typingPracticePanel);
            this.Controls.Add(this.typingInstructionPanel);
            this.Controls.Add(this.modeSelectionPanel);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.statisticsPanel);
            this.Controls.Add(this.settingsPanel);
            this.Name = "MainForm";
            this.Text = "Typing Trainer";
            this.typingPracticePanel.ResumeLayout(false);
            this.typingPracticePanel.PerformLayout();
            this.ResumeLayout(false);

        }
    }
}
#endregion