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
        public Button exitButton;
        public Label mainPanelText;
        public MainPanel()
        {
            mainPanelInitializeComponent();
        }
        public void mainPanelInitializeComponent()
        {
            this.startButton = new Button();
            this.statisticsButton = new Button();
            this.exitButton = new Button();

            this.mainPanelText = new Label();



            // Buttons configuration
            this.ClientSize = new System.Drawing.Size(600, 450); // ClientSize config from MainForm_config
            int buttonWidth = 150;
            int buttonHeight = 30;
            int buttonLeft = (this.ClientSize.Width - buttonWidth) / 2;
            int startY = 100;
            int buttonSpacing = 10;

            this.mainPanelText.Text = "7 typing App";
            this.mainPanelText.Location = new Point(0, startY / 2);
            this.mainPanelText.Font = new Font("Arial", 24, FontStyle.Bold);
            this.mainPanelText.TextAlign = ContentAlignment.TopCenter;
            this.mainPanelText.Size = new Size(this.ClientSize.Width, this.ClientSize.Height);


            this.startButton.Text = "Начать";
            this.startButton.Size = new Size(buttonWidth, buttonHeight);
            this.startButton.Location = new Point(buttonLeft, startY);

            this.statisticsButton.Text = "Статистика";
            this.statisticsButton.Size = new Size(buttonWidth, buttonHeight);
            this.statisticsButton.Location = new Point(buttonLeft, startY + buttonHeight + buttonSpacing);

            this.exitButton.Text = "Выход";
            this.exitButton.Size = new Size(buttonWidth, buttonHeight);
            this.exitButton.Location = new Point(buttonLeft, startY + 2 * (buttonHeight + buttonSpacing));

            this.Controls.Add(this.startButton);
            this.Controls.Add(this.statisticsButton);
            this.Controls.Add(this.exitButton);

            this.Controls.Add(this.mainPanelText);
        }

    }
}
