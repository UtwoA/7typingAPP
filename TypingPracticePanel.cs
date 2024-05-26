﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace _7typingAPP
{
    public partial class TypingPracticePanel : Panel
    {
        public Label inputTextLabel;
        public TextBox typingTextBox;
        public Button backButtonToInstruction;
        public char currentChar;
        public int currentCharIndex;
        public string practiceText;
        public string userInput;

        Random random = new Random();


        public TypingPracticePanel()
        {
            typingPracticePanelInitializationComponents();
        }
        public void typingPracticePanelInitializationComponents()
        {
            this.inputTextLabel = new Label();
            this.typingTextBox = new TextBox();
            this.backButtonToInstruction = new Button();

            this.ClientSize = new System.Drawing.Size(600, 150);
            int buttonWidth = 150;
            int buttonHeight = 30;

            this.inputTextLabel.Location = new System.Drawing.Point(20, 25);
            this.inputTextLabel.Size = new System.Drawing.Size(560, 50);
            this.inputTextLabel.TextAlign = ContentAlignment.MiddleCenter;
            this.inputTextLabel.Font = new Font("Arial", 11, FontStyle.Bold);
            this.inputTextLabel.ForeColor = Color.FromArgb(28, 64, 56);

            this.typingTextBox.Location = new System.Drawing.Point(20, 80);
            this.typingTextBox.Size = new System.Drawing.Size(560, 50);
            this.typingTextBox.Multiline = true;

            this.backButtonToInstruction.Text = "К инструкции";
            this.backButtonToInstruction.Size = new System.Drawing.Size(buttonWidth, buttonHeight);
            this.backButtonToInstruction.Location = new System.Drawing.Point((ClientSize.Width - backButtonToInstruction.Width) / 2, 150);
            this.backButtonToInstruction.Font = new Font("Arial", 9, FontStyle.Bold);
            this.backButtonToInstruction.ForeColor = Color.FromArgb(28, 64, 56);

            this.Controls.Add(this.inputTextLabel);
            this.Controls.Add(this.typingTextBox);
            this.Controls.Add(this.backButtonToInstruction);
        }
        public void selectText(List<string> textsList)
        {
            this.practiceText = textsList[random.Next(textsList.Count)];
            inputTextLabel.Text = practiceText;
            currentChar = practiceText[0];
        }
    }
}
