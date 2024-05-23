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
    public partial class SettingsPanel : Panel
    {
        private Label windowSizeLabel;
        private ComboBox windowSizeComboBox;
        private Label volumeLabel;
        private TrackBar volumeTrackBar;
        public Button saveSettingsButton;

        // Event handlers
        public event EventHandler WindowSizeChanged;
        public event EventHandler VolumeChanged;
        public SettingsPanel()
        {
            settingsPanellInitializeComponent();
            InitializeEventHandlers();
        }
        public void settingsPanellInitializeComponent()
        {
            this.windowSizeLabel = new Label();
            this.windowSizeComboBox = new ComboBox();
            this.volumeLabel = new Label();
            this.volumeTrackBar = new TrackBar();
            this.saveSettingsButton = new Button();

            this.ClientSize = new System.Drawing.Size(600, 450); // ClientSize config from MainForm_config

            int buttonWidth_mode = 85;
            int buttonHeight_mode = 30;
            int buttonLeft_mode = (this.ClientSize.Width - buttonWidth_mode) / 5;
            int startY_mode = 50;
            int buttonSpacing_mode = 20;

            this.Dock = DockStyle.Fill;

            this.windowSizeLabel.Text = "Размер окна:";
            this.windowSizeLabel.Location = new System.Drawing.Point(20, 20);

            this.windowSizeComboBox.Items.AddRange(new object[] { "800x600", "1024x768", "1280x1024", "Fullscreen" });
            this.windowSizeComboBox.Location = new System.Drawing.Point(120, 20);

            this.volumeLabel.Text = "Громкость:";
            this.volumeLabel.Location = new System.Drawing.Point(20, 60);

            this.volumeTrackBar.Location = new System.Drawing.Point(120, 60);
            this.volumeTrackBar.Minimum = 0;
            this.volumeTrackBar.Maximum = 100;

            this.saveSettingsButton.Text = "Сохранить";
            this.saveSettingsButton.Location = new System.Drawing.Point((this.ClientSize.Width - buttonWidth_mode) / 2, startY_mode + (buttonSpacing_mode + buttonHeight_mode) * 7);
            this.saveSettingsButton.Size = new Size(buttonWidth_mode, buttonHeight_mode);

            this.Controls.Add(this.windowSizeLabel);
            this.Controls.Add(this.windowSizeComboBox);
            this.Controls.Add(this.volumeLabel);
            this.Controls.Add(this.volumeTrackBar);
            this.Controls.Add(this.saveSettingsButton);
        }

        private void InitializeEventHandlers()
        {
            // Window size combobox event handler
            windowSizeComboBox.SelectedIndexChanged += (sender, e) =>
            {
                // Raise the WindowSizeChanged event
                WindowSizeChanged?.Invoke(this, EventArgs.Empty);
            };

            // Volume trackbar event handler
            volumeTrackBar.Scroll += (sender, e) =>
            {
                // Raise the VolumeChanged event
                VolumeChanged?.Invoke(this, EventArgs.Empty);
            };
        }

        // Additional properties to get the selected window size and volume
        public string SelectedWindowSize
        {
            get { return windowSizeComboBox.SelectedItem.ToString(); }
        }

        public int SelectedVolume
        {
            get { return volumeTrackBar.Value; }
        }
    }
}
