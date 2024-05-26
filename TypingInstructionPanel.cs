﻿using System.Drawing;
using System.Windows.Forms;

namespace _7typingAPP
{
    public partial class TypingInstructionPanel : Panel
    {
        public Label instructionLabel;
        public Button nextButton;
        public Button backButtonToModeSelection;
        public PictureBox instructionPictureBox;

        public TypingInstructionPanel()
        {
            typingInstructionPanelInitializationcomponents();
        }
        public void typingInstructionPanelInitializationcomponents()
        {
            this.instructionLabel = new Label();
            this.nextButton = new Button();
            this.instructionPictureBox = new PictureBox();
            this.backButtonToModeSelection = new Button();

            this.ClientSize = new System.Drawing.Size(600, 450);
            int buttonWidth = 150;
            int buttonHeight = 30;
            int buttonLeft = (this.ClientSize.Width - buttonWidth) / 2;

            this.instructionLabel.Location = new Point(20, 3);
            this.instructionLabel.Size = new System.Drawing.Size(580, 110);
            this.instructionLabel.Font = new Font("Arial", 11, FontStyle.Regular);
            this.instructionLabel.ForeColor = Color.FromArgb(209, 208, 123);

            this.nextButton.Text = "Далее";
            this.nextButton.Size = new Size(buttonWidth, buttonHeight);
            this.nextButton.Location = new System.Drawing.Point((ClientSize.Width - nextButton.Width) / 4 * 3, this.ClientSize.Height - nextButton.Height * 3 / 2);
            this.nextButton.Font = new Font("Arial", 9, FontStyle.Bold);
            this.nextButton.ForeColor = Color.FromArgb(28, 64, 56);

            this.instructionPictureBox.Size = new Size(this.ClientSize.Width, this.ClientSize.Height / 3 * 2);
            this.instructionPictureBox.Location = new Point(0, 105);
            this.instructionPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            
            this.backButtonToModeSelection.Size = new Size(buttonWidth, buttonHeight);
            this.backButtonToModeSelection.Text = "Назад";
            this.backButtonToModeSelection.Location = new System.Drawing.Point((ClientSize.Width - nextButton.Width) / 4, this.ClientSize.Height - nextButton.Height * 3 / 2);
            this.backButtonToModeSelection.Font = new Font("Arial", 9, FontStyle.Bold);
            this.backButtonToModeSelection.ForeColor = Color.FromArgb(28, 64, 56);

            this.Controls.Add(this.instructionLabel);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.backButtonToModeSelection);
            this.Controls.Add(this.instructionPictureBox);


        }
    }
}
