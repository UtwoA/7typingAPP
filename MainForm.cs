using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.Serialization.Formatters.Binary;

namespace _7typingAPP
{
    public partial class MainForm : Form
    {
        private MainPanel mainPanel;
        private ModeSelectionPanel modeSelectionPanel;
        private TypingInstructionPanel typingInstructionPanel;

        private TypingPracticePanel_visual typingPracticePanelVisual;
        private TypingPracticePanel_back typingPracticePanelBack;

        private VirtualKeyboardPanel_visual virtualKeyboardPanelVisual;
        private VirtualKeyboardPanel_back virtualKeyboardPanelBack;

        private StatisticsPanel_visual statisticsPanelVisual;
        private StatisticsPanel_back statisticsPanelBack;

        private Starter starter;

        private Stopwatch stopwatch;
        private int correctChars;
        private int incorrectChars;

        public MainForm()
        {
            InitializeComponent();
            CenterToScreen();
            startProgramm();
            statisticsPanelBack.LoadStatistics();
        }

        public void startProgramm()
        {
            this.mainPanel.Visible = true;
            this.modeSelectionPanel.Visible = false;
            this.typingInstructionPanel.Visible = false;
            this.typingPracticePanelVisual.Visible = false;
            this.statisticsPanelVisual.Visible = false;

            this.virtualKeyboardPanelVisual.Visible = false;

            mainPanel.startButton.Click += new EventHandler(StartButton_Click);
            mainPanel.statisticsButton.Click += new EventHandler(StatisticsButton_Click);
            mainPanel.exitButton.Click += new EventHandler(ExitButton_Click);

            statisticsPanelVisual.closeStatisticsButton.Click += new EventHandler(CloseStatisticsButton_Click);

            modeSelectionPanel.numPadModeButton.Click += new EventHandler(NumPadModeButton_Click);
            modeSelectionPanel.touchTypingModeButton.Click += new EventHandler(TouchTypingModeButton_Click);
            modeSelectionPanel.blindTypingModeButton.Click += new EventHandler(BlindTypingModeButton_Click);
            modeSelectionPanel.fastTypingModeButton.Click += new EventHandler(FastTypingModeButton_Click);
            modeSelectionPanel.typingTestsModeButton.Click += new EventHandler(TypingTestsModeButton_Click);
            modeSelectionPanel.freeModeButton.Click += new EventHandler(FreeModeButton_Click);

            modeSelectionPanel.backButtonModeSelectionToMain.Click += new EventHandler(BackButtonModeSelectionToMain_Click);

            typingInstructionPanel.nextButton.Click += new EventHandler(NextButton_Click);
            typingInstructionPanel.backButtonToModeSelection.Click += new EventHandler(backButtonToModeSelection);

            typingPracticePanelVisual.backButtonToInstruction.Click += new EventHandler(BackButtonToInstruction_Click);
        }

        // MAIN PANEL METHODS
        private void StartButton_Click(object sender, EventArgs e)
        {
            this.mainPanel.Visible = false;
            this.modeSelectionPanel.Visible = true;
        }

        private void StatisticsButton_Click(object sender, EventArgs e)
        {
            this.mainPanel.Visible = false;
            this.statisticsPanelVisual.Visible = true;
            statisticsPanelBack.UpdateStatistics(statisticsPanelVisual, statisticsPanelBack.speedHistory, statisticsPanelBack.accuracyHistory, statisticsPanelBack.modeCounts);
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // STATISTICS PANEL METHODS
        private void CloseStatisticsButton_Click(object sender, EventArgs e)
        {
            this.statisticsPanelVisual.Visible = false;
            this.mainPanel.Visible = true;
        }

        // MODE SELECTION PANEL METHODS
        private void NumPadModeButton_Click(object sender, EventArgs e)
        {
            starter.StartNumPadMode();
        }

        private void TouchTypingModeButton_Click(object sender, EventArgs e)
        {
            starter.StartTouchTypingMode();
        }

        private void BlindTypingModeButton_Click(object sender, EventArgs e)
        {
            starter.StartBlindTypingMode();
        }

        private void FastTypingModeButton_Click(object sender, EventArgs e)
        {
            starter.StartFastTypingMode();
        }

        private void TypingTestsModeButton_Click(object sender, EventArgs e)
        {
            starter.StartTypingTestsMode();
        }

        private void FreeModeButton_Click(object sender, EventArgs e)
        {
            starter.StartFreeMode();
        }

        private void BackButtonModeSelectionToMain_Click(object sender, EventArgs e)
        {
            this.modeSelectionPanel.Visible = false;
            this.mainPanel.Visible = true;
            this.typingInstructionPanel.Visible = false;
        }

        // TYPING INSTRUCTION PANEL METHODS
        private void StartTypingPractice(string instructions)
        {
            this.modeSelectionPanel.Visible = false;
            this.typingInstructionPanel.Visible = true;
            typingInstructionPanel.instructionLabel.Text = instructions;
            typingInstructionPanel.instructionPictureBox.Image = Image.FromFile("picture.jpg");
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            this.typingInstructionPanel.Visible = false;
            this.Controls.Add(virtualKeyboardPanelVisual);
            this.virtualKeyboardPanelVisual.Visible = true;
            this.typingPracticePanelVisual.Visible = true;

            typingPracticePanelVisual.currentCharIndex = 0;

            typingPracticePanelBack.CompareUserInputWithExpectedText();
            typingPracticePanelVisual.typingTextBox.Clear();

            typingPracticePanelBack.stopwatch = Stopwatch.StartNew();
            correctChars = 0;
            incorrectChars = 0;
        }

        private void backButtonToModeSelection(object sender, EventArgs e)
        {
            this.typingPracticePanelVisual.Visible = false;
            this.modeSelectionPanel.Visible = true;
            typingPracticePanelVisual.typingTextBox.Clear();
        }

        // TYPING PRACTICE PANEL METHODS
        private void BackButtonToInstruction_Click(object sender, EventArgs e)
        {
            this.typingPracticePanelVisual.Visible = false;
            this.typingInstructionPanel.Visible = true;
            typingPracticePanelVisual.typingTextBox.Clear();
        }

        [Serializable]
        public class TypingStatistics
        {
            public List<double> Speeds { get; set; }
            public List<double> Accuracies { get; set; }
            public Dictionary<string, int> ModeCounts { get; set; }
        }
    }
}
