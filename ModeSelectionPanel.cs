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
        public Label discriprion;

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
            this.discriprion = new Label();

            Label numPadLabel = new Label();
            Label touchTyping = new Label();
            Label blindTyping = new Label();
            Label fastTyping = new Label();
            Label typingTests = new Label();
            Label freeMode = new Label();


            this.ClientSize = new System.Drawing.Size(600, 450); // ClientSize config from MainForm_config

            int buttonWidth_mode = 90;
            int buttonHeight_mode = 30;
            int buttonLeft_mode = (this.ClientSize.Width - buttonWidth_mode) / 10;
            int startY_mode = 50;
            int buttonSpacing_mode = 20;

            this.discriprion.Text = "Выбор режима";
            this.discriprion.Location = new Point(buttonLeft_mode,startY_mode * 3 / 4);
            this.discriprion.Font = new Font("Arial", 18, FontStyle.Bold);
            this.discriprion.Size = new Size(this.ClientSize.Width, buttonHeight_mode);
            this.discriprion.ForeColor = Color.FromArgb(28, 64, 56);

            this.numPadModeButton.Text = "NumPad";
            this.numPadModeButton.Location = new System.Drawing.Point(buttonLeft_mode, startY_mode + buttonSpacing_mode + buttonHeight_mode);
            this.numPadModeButton.Size = new Size(buttonWidth_mode, buttonHeight_mode);
            this.numPadModeButton.Font = new Font("Arial", 9, FontStyle.Bold);
            this.numPadModeButton.ForeColor = Color.FromArgb(28, 64, 56);

            numPadLabel.Text = "Улучшение навыков работы с цифровой клавиатурой";
            numPadLabel.Location = new Point(buttonLeft_mode + buttonWidth_mode + buttonSpacing_mode, startY_mode + buttonSpacing_mode + buttonHeight_mode + 7);
            numPadLabel.Size = new Size(this.ClientSize.Width, buttonHeight_mode);
            numPadLabel.Font = new Font("Arial", 12, FontStyle.Regular);
            numPadLabel.ForeColor = Color.FromArgb(209, 208, 123);

            this.touchTypingModeButton.Text = "Touch Typing";
            this.touchTypingModeButton.Location = new System.Drawing.Point(buttonLeft_mode, startY_mode + (buttonSpacing_mode + buttonHeight_mode) * 2);
            this.touchTypingModeButton.Size = new Size(buttonWidth_mode, buttonHeight_mode);
            this.touchTypingModeButton.Font = new Font("Arial", 9, FontStyle.Bold);
            this.touchTypingModeButton.ForeColor = Color.FromArgb(28, 64, 56);

            touchTyping.Text = "Комбинации букв не имеющие смысла";
            touchTyping.Location = new Point(buttonLeft_mode + buttonWidth_mode + buttonSpacing_mode, startY_mode + (buttonSpacing_mode + buttonHeight_mode) * 2 + 7);
            touchTyping.Size = new Size(this.ClientSize.Width, buttonHeight_mode);
            touchTyping.Font = new Font("Arial", 12, FontStyle.Regular);
            touchTyping.ForeColor = Color.FromArgb(209, 208, 123);

            this.blindTypingModeButton.Text = "Blind Typing";
            this.blindTypingModeButton.Location = new System.Drawing.Point(buttonLeft_mode, startY_mode + (buttonSpacing_mode + buttonHeight_mode) * 3);
            this.blindTypingModeButton.Size = new Size(buttonWidth_mode, buttonHeight_mode);
            this.blindTypingModeButton.Font = new Font("Arial", 9, FontStyle.Bold);
            this.blindTypingModeButton.ForeColor = Color.FromArgb(28, 64, 56);
            blindTyping.Text = "Режим ввода осмысленного текста";
            blindTyping.Location = new Point(buttonLeft_mode + buttonWidth_mode + buttonSpacing_mode, startY_mode + (buttonSpacing_mode + buttonHeight_mode) * 3 + 7);
            blindTyping.Size = new Size(this.ClientSize.Width, buttonHeight_mode);
            blindTyping.Font = new Font("Arial", 12, FontStyle.Regular);
            blindTyping.ForeColor = Color.FromArgb(209, 208, 123);

            this.fastTypingModeButton.Text = "Fast Typing";
            this.fastTypingModeButton.Location = new System.Drawing.Point(buttonLeft_mode, startY_mode + (buttonSpacing_mode + buttonHeight_mode) * 4);
            this.fastTypingModeButton.Size = new Size(buttonWidth_mode, buttonHeight_mode);
            this.fastTypingModeButton.Font = new Font("Arial", 9, FontStyle.Bold);
            this.fastTypingModeButton.ForeColor = Color.FromArgb(28, 64, 56);

            fastTyping.Text = "Усложненный режим ввода осмысленного текста";
            fastTyping.Location = new Point(buttonLeft_mode + buttonWidth_mode + buttonSpacing_mode, startY_mode + (buttonSpacing_mode + buttonHeight_mode) * 4 + 7);
            fastTyping.Size = new Size(this.ClientSize.Width, buttonHeight_mode);
            fastTyping.Font = new Font("Arial", 12, FontStyle.Regular);
            fastTyping.ForeColor = Color.FromArgb(209, 208, 123);

            this.typingTestsModeButton.Text = "Typing Tests";
            this.typingTestsModeButton.Location = new System.Drawing.Point(buttonLeft_mode, startY_mode + (buttonSpacing_mode + buttonHeight_mode) * 5);
            this.typingTestsModeButton.Size = new Size(buttonWidth_mode, buttonHeight_mode);
            this.typingTestsModeButton.Font = new Font("Arial", 9, FontStyle.Bold);
            this.typingTestsModeButton.ForeColor = Color.FromArgb(28, 64, 56);

            typingTests.Text = "Режим ввода слов, не имеющих связи между собой";
            typingTests.Location = new Point(buttonLeft_mode + buttonWidth_mode + buttonSpacing_mode, startY_mode + (buttonSpacing_mode + buttonHeight_mode) * 5 + 7);
            typingTests.Size = new Size(this.ClientSize.Width, buttonHeight_mode);
            typingTests.Font = new Font("Arial", 12, FontStyle.Regular);
            typingTests.ForeColor = Color.FromArgb(209, 208, 123);

            this.freeModeButton.Text = "Free Mode";
            this.freeModeButton.Location = new System.Drawing.Point(buttonLeft_mode, startY_mode + (buttonSpacing_mode + buttonHeight_mode) * 6);
            this.freeModeButton.Size = new Size(buttonWidth_mode, buttonHeight_mode);
            this.freeModeButton.Font = new Font("Arial", 9, FontStyle.Bold);
            this.freeModeButton.ForeColor = Color.FromArgb(28, 64, 56);

            freeMode.Text = "Режим свободного ввода";
            freeMode.Location = new Point(buttonLeft_mode + buttonWidth_mode + buttonSpacing_mode, startY_mode + (buttonSpacing_mode + buttonHeight_mode) * 6 + 7);
            freeMode.Size = new Size(this.ClientSize.Width, buttonHeight_mode);
            freeMode.Font = new Font("Arial", 12, FontStyle.Regular);
            freeMode.ForeColor = Color.FromArgb(209, 208, 123);

            this.backButtonModeSelectionToMain.Location = new System.Drawing.Point((this.ClientSize.Width - buttonWidth_mode) / 2, startY_mode + (buttonSpacing_mode + buttonHeight_mode) * 7);
            this.backButtonModeSelectionToMain.Size = new Size(buttonWidth_mode, buttonHeight_mode);
            this.backButtonModeSelectionToMain.Text = "Назад";
            this.backButtonModeSelectionToMain.Font = new Font("Arial", 9, FontStyle.Bold);
            this.backButtonModeSelectionToMain.ForeColor = Color.FromArgb(28, 64, 56);


            this.Controls.Add(this.numPadModeButton);
            this.Controls.Add(this.touchTypingModeButton);
            this.Controls.Add(this.blindTypingModeButton);
            this.Controls.Add(this.fastTypingModeButton);
            this.Controls.Add(this.typingTestsModeButton);
            this.Controls.Add(this.freeModeButton);
            this.Controls.Add(this.backButtonModeSelectionToMain);

            this.Controls.Add(this.discriprion);

            this.Controls.Add(numPadLabel);
            this.Controls.Add(touchTyping);
            this.Controls.Add(blindTyping);
            this.Controls.Add(fastTyping);
            this.Controls.Add(typingTests);
            this.Controls.Add(freeMode);

        }
    }
}
