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
    public partial class MainPanel : Panel
    {
        public Button startButton;
        public Button statisticsButton;
        public Button settingsButton;
        public Button exitButton;
        public MainPanel()
        {
            mainPanelInitializeComponent();
        }
        public void mainPanelInitializeComponent()
        {
            this.startButton = new Button();
            this.statisticsButton = new Button();
            this.settingsButton = new Button();
            this.exitButton = new Button();

            // Buttons configuration
            this.ClientSize = new System.Drawing.Size(600, 450); // ClientSize config from MainForm_config
            int buttonWidth = 150;
            int buttonHeight = 30;
            int buttonLeft = (this.ClientSize.Width - buttonWidth) / 2;
            int startY = 100;
            int buttonSpacing = 10;

            this.startButton.Text = "НАЧАТЬ";
            this.startButton.Size = new Size(buttonWidth, buttonHeight);
            this.startButton.Location = new Point(buttonLeft, startY);

            this.statisticsButton.Text = "СТАТИСТИКА";
            this.statisticsButton.Size = new Size(buttonWidth, buttonHeight);
            this.statisticsButton.Location = new Point(buttonLeft, startY + buttonHeight + buttonSpacing);

            this.settingsButton.Text = "НАСТРОЙКИ";
            this.settingsButton.Size = new Size(buttonWidth, buttonHeight);
            this.settingsButton.Location = new Point(buttonLeft, startY + 2 * (buttonHeight + buttonSpacing));

            this.exitButton.Text = "ВЫХОД";
            this.exitButton.Size = new Size(buttonWidth, buttonHeight);
            this.exitButton.Location = new Point(buttonLeft, startY + 3 * (buttonHeight + buttonSpacing));

            this.Controls.Add(this.startButton);
            this.Controls.Add(this.statisticsButton);
            this.Controls.Add(this.settingsButton);
            this.Controls.Add(this.exitButton);
        }

    }
}
