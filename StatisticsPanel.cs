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
            // Initialize the label
            statisticsLabel = new Label
            {
                Text = "Статистика",
                Font = new Font("Arial", 16, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleCenter,
                Dock = DockStyle.Fill
            };

            // Initialize the speed chart label
            speedLabel = new Label
            {
                Text = "Скорость (нажатий в минуту)",
                TextAlign = ContentAlignment.MiddleCenter,
                Dock = DockStyle.Fill
            };

            // Initialize the accuracy chart label
            accuracyLabel = new Label
            {
                Text = "Точность (%)",
                TextAlign = ContentAlignment.MiddleCenter,
                Dock = DockStyle.Fill
            };

            // Initialize the pick mode label
            pickModeLabel = new Label
            {
                Text = "Количество упражнений в режимах:",
                TextAlign = ContentAlignment.MiddleLeft,
                Dock = DockStyle.Fill,
                AutoSize = true
            };

            // Initialize the speed chart
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

            // Initialize the accuracy chart
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

            // Initialize the close button
            closeStatisticsButton = new Button
            {
                Text = "Назад",
                Width = 85,
                Height = 30,
                Anchor = AnchorStyles.Bottom
            };

            // Initialize the TableLayoutPanel
            TableLayoutPanel layout = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                ColumnCount = 2,
                RowCount = 6
            };
            layout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30));
            layout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70));
            layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 40));
            layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20));
            layout.RowStyles.Add(new RowStyle(SizeType.Percent, 50));
            layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20));
            layout.RowStyles.Add(new RowStyle(SizeType.Percent, 50));
            layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 40)); // Row for the close button

            // Add controls to the TableLayoutPanel
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

            // Center the close button
            layout.SetCellPosition(closeStatisticsButton, new TableLayoutPanelCellPosition(1, 5));
            layout.SetColumnSpan(closeStatisticsButton, 2);

            // Add the layout to the panel
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
