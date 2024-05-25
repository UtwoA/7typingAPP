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
    public partial class StatisticsPanel : Panel
    {
        private Label statisticsLabel;
        public Button closeStatisticsButton;
        public StatisticsPanel()
        {
            statisticsPanelInitializationcomponents();
        }
        public void statisticsPanelInitializationcomponents()
        {
            this.statisticsLabel = new Label();
            this.closeStatisticsButton = new Button();

            this.ClientSize = new System.Drawing.Size(600, 450); // ClientSize config from MainForm_config

            int buttonWidth_mode = 85;
            int buttonHeight_mode = 30;
            int buttonLeft_mode = (this.ClientSize.Width - buttonWidth_mode) / 5;
            int startY_mode = 50;
            int buttonSpacing_mode = 20;

            this.statisticsLabel.Text = "Ваши результаты:";
            this.statisticsLabel.Location = new System.Drawing.Point(20, 20);
            this.statisticsLabel.Size = new System.Drawing.Size(360, 200);

            this.closeStatisticsButton.Location = new System.Drawing.Point((this.ClientSize.Width - buttonWidth_mode) / 2, startY_mode + (buttonSpacing_mode + buttonHeight_mode) * 7);
            this.closeStatisticsButton.Size = new Size(buttonWidth_mode, buttonHeight_mode);
            this.closeStatisticsButton.Text = "Назад";


            this.Controls.Add(this.statisticsLabel);
            this.Controls.Add(this.closeStatisticsButton);
        }
    }
}
