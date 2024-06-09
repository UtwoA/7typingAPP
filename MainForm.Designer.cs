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
            this.statisticsPanelVisual = new _7typingAPP.StatisticsPanel_visual();
            this.statisticsPanelBack = new _7typingAPP.StatisticsPanel_back();
            this.virtualKeyboardPanelVisual = new _7typingAPP.VirtualKeyboardPanel_visual();
            this.virtualKeyboardPanelBack = new _7typingAPP.VirtualKeyboardPanel_back();
            this.modeSelectionPanel = new _7typingAPP.ModeSelectionPanel();
            this.mainPanel = new _7typingAPP.MainPanel();
            this.typingInstructionPanel = new _7typingAPP.TypingInstructionPanel();
            this.typingPracticePanelVisual = new TypingPracticePanel_visual();
            this.typingPracticePanelBack = new TypingPracticePanel_back(this.typingPracticePanelVisual, this.virtualKeyboardPanelVisual, this.virtualKeyboardPanelBack, this.stopwatch);
            this.starter = new Starter(this.modeSelectionPanel, this.typingInstructionPanel, this.typingInstructionPanel.instructionLabel, this.typingInstructionPanel.instructionPictureBox, this.typingPracticePanelVisual, this.statisticsPanelBack);

            this.SuspendLayout();
            this.typingPracticePanelVisual.SuspendLayout();
            this.virtualKeyboardPanelVisual.SuspendLayout();
            // 
            // statisticsPanel
            // 
            this.statisticsPanelVisual.BackColor = System.Drawing.Color.Transparent;
            this.statisticsPanelVisual.Location = new System.Drawing.Point(0, 0);
            this.statisticsPanelVisual.Name = "statisticsPanel";
            this.statisticsPanelVisual.Size = new System.Drawing.Size(600, 450);
            this.statisticsPanelVisual.TabIndex = 5;
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
            this.typingPracticePanelVisual.BackColor = System.Drawing.Color.Transparent;
            this.typingPracticePanelVisual.Controls.Add(this.virtualKeyboardPanelVisual);
            this.typingPracticePanelVisual.Location = new System.Drawing.Point(0, 0);
            this.typingPracticePanelVisual.Name = "typingPracticePanel";
            this.typingPracticePanelVisual.Size = new System.Drawing.Size(600, 200);
            this.typingPracticePanelVisual.TabIndex = 1;
            // 
            // virtualKeyboardPanel
            // 
            this.virtualKeyboardPanelVisual.BackColor = System.Drawing.Color.Transparent;
            this.virtualKeyboardPanelVisual.Location = new System.Drawing.Point(3, 203);
            this.virtualKeyboardPanelVisual.Name = "virtualKeyboardPanel";
            this.virtualKeyboardPanelVisual.Size = new System.Drawing.Size(600, 450);
            this.virtualKeyboardPanelVisual.TabIndex = 0;
            this.ResumeLayout(false);
            // 
            // modeSelectionPanel
            // 
            this.modeSelectionPanel.BackColor = System.Drawing.Color.Transparent;
            this.modeSelectionPanel.Location = new System.Drawing.Point(0, 0);
            this.modeSelectionPanel.Name = "modeSelectionPanel";
            this.modeSelectionPanel.Size = new System.Drawing.Size(600, 450);
            this.modeSelectionPanel.TabIndex = 3;
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.Transparent;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(600, 450);
            this.mainPanel.TabIndex = 4;
            // 
            // MainForm
            // 
            this.BackgroundImage = global::_7typingAPP.Properties.Resources._18bf71_271830_1920_1080__1_;
            this.ClientSize = new System.Drawing.Size(600, 450);
            this.Controls.Add(this.statisticsPanelVisual);
            this.Controls.Add(this.typingInstructionPanel);
            this.Controls.Add(this.virtualKeyboardPanelVisual);
            this.Controls.Add(this.typingPracticePanelVisual);
            this.Controls.Add(this.modeSelectionPanel);
            this.Controls.Add(this.mainPanel);
            // Добавление виртуальной клавиатуры и панели набора текста в форму
            this.Controls.Add(this.virtualKeyboardPanelVisual);
            this.Controls.Add(this.typingPracticePanelVisual);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "7 Typing App";
            this.typingPracticePanelVisual.ResumeLayout(false);
            this.typingPracticePanelVisual.PerformLayout();
            this.ResumeLayout(false);

        }
    }
}
#endregion