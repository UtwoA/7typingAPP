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

            int buttonWidth_mode = 85;
            int buttonHeight_mode = 30;
            int buttonLeft_mode = (this.ClientSize.Width - buttonWidth_mode) / 10;
            int startY_mode = 50;
            int buttonSpacing_mode = 20;

            this.discriprion.Text = "Выбор режима";
            this.discriprion.Location = new Point(buttonLeft_mode,startY_mode * 3 / 4);
            this.discriprion.Font = new Font("Arial", 18, FontStyle.Bold);
            this.discriprion.Size = new Size(this.ClientSize.Width, buttonHeight_mode);

            this.numPadModeButton.Text = "NumPad";
            this.numPadModeButton.Location = new System.Drawing.Point(buttonLeft_mode, startY_mode + buttonSpacing_mode + buttonHeight_mode);
            this.numPadModeButton.Size = new Size(buttonWidth_mode, buttonHeight_mode);
            numPadLabel.Text = "Режим только цифр для улучшения навыков работы с цифровой клавиатурой.";
            numPadLabel.Location = new Point(buttonLeft_mode + buttonWidth_mode + buttonSpacing_mode, startY_mode + buttonSpacing_mode + buttonHeight_mode + 7);
            numPadLabel.Size = new Size(this.ClientSize.Width, buttonHeight_mode);

            this.touchTypingModeButton.Text = "Touch Typing";
            this.touchTypingModeButton.Location = new System.Drawing.Point(buttonLeft_mode, startY_mode + (buttonSpacing_mode + buttonHeight_mode) * 2);
            this.touchTypingModeButton.Size = new Size(buttonWidth_mode, buttonHeight_mode);
            touchTyping.Text = "Режим бессмысленных комбинаций букв для развития навыков слепой печати.";
            touchTyping.Location = new Point(buttonLeft_mode + buttonWidth_mode + buttonSpacing_mode, startY_mode + (buttonSpacing_mode + buttonHeight_mode) * 2 + 7);
            touchTyping.Size = new Size(this.ClientSize.Width, buttonHeight_mode);

            this.blindTypingModeButton.Text = "Blind Typing";
            this.blindTypingModeButton.Location = new System.Drawing.Point(buttonLeft_mode, startY_mode + (buttonSpacing_mode + buttonHeight_mode) * 3);
            this.blindTypingModeButton.Size = new Size(buttonWidth_mode, buttonHeight_mode);
            blindTyping.Text = "Режим осмысленного текста для улучшения скорости и точности слепой печати.";
            blindTyping.Location = new Point(buttonLeft_mode + buttonWidth_mode + buttonSpacing_mode, startY_mode + (buttonSpacing_mode + buttonHeight_mode) * 3 + 7);
            blindTyping.Size = new Size(this.ClientSize.Width, buttonHeight_mode);

            this.fastTypingModeButton.Text = "Fast Typing";
            this.fastTypingModeButton.Location = new System.Drawing.Point(buttonLeft_mode, startY_mode + (buttonSpacing_mode + buttonHeight_mode) * 4);
            this.fastTypingModeButton.Size = new Size(buttonWidth_mode, buttonHeight_mode);
            fastTyping.Text = "Режим усложненного осмысленного текста для повышения скорости и точности печати.";
            fastTyping.Location = new Point(buttonLeft_mode + buttonWidth_mode + buttonSpacing_mode, startY_mode + (buttonSpacing_mode + buttonHeight_mode) * 4 + 7);
            fastTyping.Size = new Size(this.ClientSize.Width, buttonHeight_mode);

            this.typingTestsModeButton.Text = "Typing Tests";
            this.typingTestsModeButton.Location = new System.Drawing.Point(buttonLeft_mode, startY_mode + (buttonSpacing_mode + buttonHeight_mode) * 5);
            this.typingTestsModeButton.Size = new Size(buttonWidth_mode, buttonHeight_mode);
            typingTests.Text = "Режим тестов с оценкой навыков печати по завершении.";
            typingTests.Location = new Point(buttonLeft_mode + buttonWidth_mode + buttonSpacing_mode, startY_mode + (buttonSpacing_mode + buttonHeight_mode) * 5 + 7);
            typingTests.Size = new Size(this.ClientSize.Width, buttonHeight_mode);

            this.freeModeButton.Text = "Free Mode";
            this.freeModeButton.Location = new System.Drawing.Point(buttonLeft_mode, startY_mode + (buttonSpacing_mode + buttonHeight_mode) * 6);
            this.freeModeButton.Size = new Size(buttonWidth_mode, buttonHeight_mode);
            freeMode.Text = "Режим загрузки и пользовательского текста для адаптированных тренировок.";
            freeMode.Location = new Point(buttonLeft_mode + buttonWidth_mode + buttonSpacing_mode, startY_mode + (buttonSpacing_mode + buttonHeight_mode) * 6 + 7);
            freeMode.Size = new Size(this.ClientSize.Width, buttonHeight_mode);

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
