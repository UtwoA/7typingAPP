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
    public partial class ModeSelectionPanel : Panel
    {
        public Button numPadModeButton;
        public Button touchTypingModeButton;
        public Button blindTypingModeButton;
        public Button fastTypingModeButton;
        public Button typingTestsModeButton;
        public Button freeModeButton;
        public Button backButtonModeSelectionToMain;

        public ModeSelectionPanel()
        {
            modeSelectionPanelInitializationcomponents();
        }
        public void modeSelectionPanelInitializationcomponents()
        {
            this.numPadModeButton = new Button();
            this.touchTypingModeButton = new Button();
            this.blindTypingModeButton = new Button();
            this.fastTypingModeButton = new Button();
            this.typingTestsModeButton = new Button();
            this.freeModeButton = new Button();
            this.backButtonModeSelectionToMain = new Button();

            Label numPadLabel = new Label();
            Label touchTyping = new Label();
            Label blindTyping = new Label();
            Label fastTyping = new Label();
            Label typingTests = new Label();
            Label freeMode = new Label();


            this.ClientSize = new System.Drawing.Size(600, 450); // ClientSize config from MainForm_config

            int buttonWidth_mode = 85;
            int buttonHeight_mode = 30;
            int buttonLeft_mode = (this.ClientSize.Width - buttonWidth_mode) / 5;
            int startY_mode = 50;
            int buttonSpacing_mode = 20;

            this.numPadModeButton.Text = "NumPad";
            this.numPadModeButton.Location = new System.Drawing.Point(buttonLeft_mode, startY_mode + buttonSpacing_mode + buttonHeight_mode);
            this.numPadModeButton.Size = new Size(buttonWidth_mode, buttonHeight_mode);
            numPadLabel.Text = "Text 1";
            numPadLabel.Location = new Point(buttonLeft_mode + buttonWidth_mode + buttonSpacing_mode, startY_mode + buttonSpacing_mode + buttonHeight_mode + 7);

            this.touchTypingModeButton.Text = "Touch Typing";
            this.touchTypingModeButton.Location = new System.Drawing.Point(buttonLeft_mode, startY_mode + (buttonSpacing_mode + buttonHeight_mode) * 2);
            this.touchTypingModeButton.Size = new Size(buttonWidth_mode, buttonHeight_mode);
            touchTyping.Text = "Text 1";
            touchTyping.Location = new Point(buttonLeft_mode + buttonWidth_mode + buttonSpacing_mode, startY_mode + (buttonSpacing_mode + buttonHeight_mode) * 2 + 7);

            this.blindTypingModeButton.Text = "Blind Typing";
            this.blindTypingModeButton.Location = new System.Drawing.Point(buttonLeft_mode, startY_mode + (buttonSpacing_mode + buttonHeight_mode) * 3);
            this.blindTypingModeButton.Size = new Size(buttonWidth_mode, buttonHeight_mode);
            blindTyping.Text = "Text 1";
            blindTyping.Location = new Point(buttonLeft_mode + buttonWidth_mode + buttonSpacing_mode, startY_mode + (buttonSpacing_mode + buttonHeight_mode) * 3 + 7);

            this.fastTypingModeButton.Text = "Fast Typing";
            this.fastTypingModeButton.Location = new System.Drawing.Point(buttonLeft_mode, startY_mode + (buttonSpacing_mode + buttonHeight_mode) * 4);
            this.fastTypingModeButton.Size = new Size(buttonWidth_mode, buttonHeight_mode);
            fastTyping.Text = "Text 1";
            fastTyping.Location = new Point(buttonLeft_mode + buttonWidth_mode + buttonSpacing_mode, startY_mode + (buttonSpacing_mode + buttonHeight_mode) * 4 + 7);

            this.typingTestsModeButton.Text = "Typing Tests";
            this.typingTestsModeButton.Location = new System.Drawing.Point(buttonLeft_mode, startY_mode + (buttonSpacing_mode + buttonHeight_mode) * 5);
            this.typingTestsModeButton.Size = new Size(buttonWidth_mode, buttonHeight_mode);
            typingTests.Text = "Text 1";
            typingTests.Location = new Point(buttonLeft_mode + buttonWidth_mode + buttonSpacing_mode, startY_mode + (buttonSpacing_mode + buttonHeight_mode) * 5 + 7);

            this.freeModeButton.Text = "Free Mode";
            this.freeModeButton.Location = new System.Drawing.Point(buttonLeft_mode, startY_mode + (buttonSpacing_mode + buttonHeight_mode) * 6);
            this.freeModeButton.Size = new Size(buttonWidth_mode, buttonHeight_mode);
            freeMode.Text = "Text 1";
            freeMode.Location = new Point(buttonLeft_mode + buttonWidth_mode + buttonSpacing_mode, startY_mode + (buttonSpacing_mode + buttonHeight_mode) * 6 + 7);

            this.backButtonModeSelectionToMain.Location = new System.Drawing.Point((this.ClientSize.Width - buttonWidth_mode) / 2, startY_mode + (buttonSpacing_mode + buttonHeight_mode) * 7);
            this.backButtonModeSelectionToMain.Size = new Size(buttonWidth_mode, buttonHeight_mode);
            this.backButtonModeSelectionToMain.Text = "НАЗАД";

            this.Controls.Add(this.numPadModeButton);
            this.Controls.Add(this.touchTypingModeButton);
            this.Controls.Add(this.blindTypingModeButton);
            this.Controls.Add(this.fastTypingModeButton);
            this.Controls.Add(this.typingTestsModeButton);
            this.Controls.Add(this.freeModeButton);
            this.Controls.Add(this.backButtonModeSelectionToMain);

            this.Controls.Add(numPadLabel);
            this.Controls.Add(touchTyping);
            this.Controls.Add(blindTyping);
            this.Controls.Add(fastTyping);
            this.Controls.Add(typingTests);
            this.Controls.Add(freeMode);

        }
    }
}
