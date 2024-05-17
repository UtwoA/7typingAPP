using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

            this.ClientSize = new System.Drawing.Size(600, 450); // ClientSize config from MainForm_config
            int buttonWidth = 150;
            int buttonHeight = 30;
            int buttonLeft = (this.ClientSize.Width - buttonWidth) / 2;
            int startY = 100;
            int buttonSpacing = 10;

            this.instructionLabel.Location = new Point(20, 20);
            this.instructionLabel.Size = new System.Drawing.Size(100, 50);

            this.nextButton.Text = "Далее";
            this.nextButton.Size = new Size(buttonWidth, buttonHeight);
            this.nextButton.Location = new System.Drawing.Point((ClientSize.Width - nextButton.Width) / 4 * 3, this.ClientSize.Height - nextButton.Height * 2);

            this.instructionPictureBox.Size = new Size(this.ClientSize.Width, this.ClientSize.Height / 3 * 2);
            this.instructionPictureBox.Location = new Point(0, this.ClientSize.Height / 3 - nextButton.Height * 3);
            this.instructionPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;


            this.backButtonToModeSelection.Size = new Size(buttonWidth, buttonHeight);
            this.backButtonToModeSelection.Text = "НАЗАД";
            this.backButtonToModeSelection.Location = new System.Drawing.Point((ClientSize.Width - nextButton.Width) / 4, this.ClientSize.Height - nextButton.Height * 2);

            this.Controls.Add(this.instructionLabel);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.backButtonToModeSelection);
            this.Controls.Add(this.instructionPictureBox);


        }
    }
}
