using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace _7typingAPP
{
    public partial class StatisticsPanel : Panel
    {
        public Button closeStatisticsButton;
        private Chart speedChart;
        private Chart accuracyChart;
        private Label statisticsLabel;
        private Label speedLabel;
        private Label accuracyLabel;
        private Label pickModeLabel;

        public StatisticsPanel()
        {
            this.statisticsLabel = new Label();
            this.statisticsLabel.Text = "Статистика";
            this.statisticsLabel.Font = new Font("Arial", 16, FontStyle.Bold);
            this.statisticsLabel.TextAlign = ContentAlignment.MiddleCenter;
            this.statisticsLabel.Dock = DockStyle.Fill;
            this.statisticsLabel.ForeColor = Color.FromArgb(28, 64, 56);

            this.speedLabel = new Label();
            this.speedLabel.Text = "Скорость (нажатий в минуту)";
            this.speedLabel.Font = new Font("Arial", 12, FontStyle.Regular);
            this.speedLabel.TextAlign = ContentAlignment.MiddleCenter;
            this.speedLabel.Dock = DockStyle.Fill;
            this.speedLabel.ForeColor = Color.FromArgb(209, 208, 123);

            this.accuracyLabel = new Label();
            this.accuracyLabel.Text = "Точность (%)";
            this.accuracyLabel.Font = new Font("Arial", 12, FontStyle.Regular);
            this.accuracyLabel.TextAlign = ContentAlignment.MiddleCenter;
            this.accuracyLabel.Dock = DockStyle.Fill;
            this.accuracyLabel.ForeColor = Color.FromArgb(209, 208, 123);

            this.pickModeLabel = new Label();
            this.pickModeLabel.Text = "Количество упражнений в режимах:";
            this.pickModeLabel.Font = new Font("Arial", 12, FontStyle.Regular);
            this.pickModeLabel.TextAlign = ContentAlignment.MiddleLeft;
            this.pickModeLabel.Dock = DockStyle.Fill;
            this.pickModeLabel.ForeColor = Color.FromArgb(209, 208, 123);

            // График скорости
            speedChart = new Chart
            {
                Dock = DockStyle.Fill,
                Height = 100
            };
            speedChart.ChartAreas.Add(new ChartArea("SpeedChartArea"));
            speedChart.Series.Add(new Series("Speed")
            {
                ChartType = SeriesChartType.Line
            });
            // График точности
            accuracyChart = new Chart
            {
                Dock = DockStyle.Fill,
                Height = 100
            };
            accuracyChart.ChartAreas.Add(new ChartArea("AccuracyChartArea"));
            accuracyChart.Series.Add(new Series("Accuracy")
            {
                ChartType = SeriesChartType.Line
            });

            this.closeStatisticsButton = new Button();
            this.closeStatisticsButton.Text = "Назад";
            this.closeStatisticsButton.Width = 85;
            this.closeStatisticsButton.Height = 30;
            this.closeStatisticsButton.Anchor = AnchorStyles.Bottom;
            this.closeStatisticsButton.Font = new Font("Arial", 12, FontStyle.Bold);
            this.closeStatisticsButton.ForeColor = Color.FromArgb(28, 64, 56);

            // Разметка таблицей
            TableLayoutPanel layout = new TableLayoutPanel();

            layout.Dock = DockStyle.Fill;
            layout.ColumnCount = 2;
            layout.RowCount = 6;

            layout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30));
            layout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70));
            layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 40));
            layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20));
            layout.RowStyles.Add(new RowStyle(SizeType.Percent, 50));
            layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20));
            layout.RowStyles.Add(new RowStyle(SizeType.Percent, 50));
            layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 40)); // Строка для кнопки "Назад"

            layout.Controls.Add(statisticsLabel, 0, 0);
            layout.SetColumnSpan(statisticsLabel, 2);
            layout.Controls.Add(speedLabel, 0, 1);
            layout.Controls.Add(speedChart, 0, 2);
            layout.Controls.Add(accuracyLabel, 0, 3);
            layout.Controls.Add(accuracyChart, 0, 4);
            layout.Controls.Add(pickModeLabel, 1, 0);
            layout.SetRowSpan(pickModeLabel, 5);
            layout.Controls.Add(closeStatisticsButton, 0, 5);
            layout.SetColumnSpan(closeStatisticsButton, 2);

            // Центрирование кнопки "Назад"
            layout.SetCellPosition(closeStatisticsButton, new TableLayoutPanelCellPosition(1, 5));
            layout.SetColumnSpan(closeStatisticsButton, 2);

            // Добавляем разметку
            Controls.Add(layout);
        }

        public void UpdateStatistics(List<double> speeds, List<double> accuracies, Dictionary<string, int> modeCounts)
        {
            speedChart.Series["Speed"].Points.Clear();
            accuracyChart.Series["Accuracy"].Points.Clear();

            for (int i = 0; i < speeds.Count; i++)
            {
                speedChart.Series["Speed"].Points.AddXY(i + 1, speeds[i]);
                accuracyChart.Series["Accuracy"].Points.AddXY(i + 1, accuracies[i]);
            }

            pickModeLabel.Text = "Количество упражнений в режимах:\n";
            foreach (var mode in modeCounts)
            {
                pickModeLabel.Text += $"{mode.Key}: {mode.Value}\n";
            }
            pickModeLabel.Text = pickModeLabel.Text.Replace("\n", "\n\n");
        }
    }
}
