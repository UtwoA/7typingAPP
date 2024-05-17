﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _7typingAPP
{
    public partial class MainForm : Form
    {

        private MainPanel mainPanel;
        private ModeSelectionPanel modeSelectionPanel;
        private TypingInstructionPanel typingInstructionPanel;
        private TypingPracticePanel typingPracticePanel;
        private VirtualKeyboardPanel virtualKeyboardPanel;
        private StatisticsPanel statisticsPanel;
        private SettingsPanel settingsPanel;
        Random random = new Random();
        int indexSymbol = 0;
        public MainForm()
        {
            InitializeComponent();
            CenterToScreen();
            startProgramm();
        }
        public void startProgramm()
        {
            this.mainPanel.Visible = true;
            this.modeSelectionPanel.Visible = false;
            this.typingInstructionPanel.Visible = false;
            this.typingPracticePanel.Visible = false;
            this.statisticsPanel.Visible = false;
            this.settingsPanel.Visible = false;
            this.virtualKeyboardPanel.Visible = false;

            mainPanel.startButton.Click += new EventHandler(StartButton_Click);
            mainPanel.statisticsButton.Click += new EventHandler(StatisticsButton_Click);
            mainPanel.settingsButton.Click += new EventHandler(SettingsButton_Click);
            mainPanel.exitButton.Click += new EventHandler(ExitButton_Click);

            settingsPanel.saveSettingsButton.Click += new EventHandler(SaveSettingsButton_Click);

            statisticsPanel.closeStatisticsButton.Click += new EventHandler(CloseStatisticsButton_Click);

            modeSelectionPanel.numPadModeButton.Click += new EventHandler(NumPadModeButton_Click);
            modeSelectionPanel.touchTypingModeButton.Click += new EventHandler(TouchTypingModeButton_Click);
            modeSelectionPanel.blindTypingModeButton.Click += new EventHandler(BlindTypingModeButton_Click);
            modeSelectionPanel.fastTypingModeButton.Click += new EventHandler(FastTypingModeButton_Click);
            modeSelectionPanel.typingTestsModeButton.Click += new EventHandler(TypingTestsModeButton_Click);
            modeSelectionPanel.freeModeButton.Click += new EventHandler(FreeModeButton_Click);

            modeSelectionPanel.backButtonModeSelectionToMain.Click += new EventHandler(BackButtonModeSelectionToMain_Click);

            typingInstructionPanel.nextButton.Click += new EventHandler(NextButton_Click);
            typingInstructionPanel.backButtonToModeSelection.Click += new EventHandler(backButtonToModeSelection);

            typingPracticePanel.backButtonToInstruction.Click += new EventHandler(BackButtonToInstruction_Click);
            typingPracticePanel.typingTextBox.TextChanged += new EventHandler(TypingTextBox_TextChanged);
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
            this.statisticsPanel.Visible = true;
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            this.mainPanel.Visible = false;
            this.settingsPanel.Visible = true;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // SETTINGS PANEL METHODS
        private void SaveSettingsButton_Click(object sender, EventArgs e)
        {
            // Save settings logic
            this.settingsPanel.Visible = false;
            this.mainPanel.Visible = true;
        }

        // STATISTICS PANEL METHODS
        private void CloseStatisticsButton_Click(object sender, EventArgs e)
        {
            this.statisticsPanel.Visible = false;
            this.mainPanel.Visible = true;
        }

        // MODE SELECTION PANEL METHODS
        private void NumPadModeButton_Click(object sender, EventArgs e)
        {
            StartTypingPractice("NumPad Mode Instructions");
            string[] TextList = File.ReadAllLines("C:/folder/NumPad.txt");
            List<string> practiceTexts = TextList.ToList();
            typingPracticePanel.selectText(practiceTexts);

        }

        private void TouchTypingModeButton_Click(object sender, EventArgs e)
        {
            StartTypingPractice("Touch Typing Mode Instructions");
        }

        private void BlindTypingModeButton_Click(object sender, EventArgs e)
        {
            StartTypingPractice("Blind Typing Mode Instructions");
        }

        private void FastTypingModeButton_Click(object sender, EventArgs e)
        {
            StartTypingPractice("Fast Typing Mode Instructions");
        }

        private void TypingTestsModeButton_Click(object sender, EventArgs e)
        {
            StartTypingPractice("Typing Tests Mode Instructions");
        }

        private void FreeModeButton_Click(object sender, EventArgs e)
        {
            StartTypingPractice("Free Mode Instructions");
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
            typingInstructionPanel.instructionPictureBox.Image = Image.FromFile("C:/folder/picture.jpg");

        }

        private void NextButton_Click(object sender, EventArgs e) // INSTR > PRACTICE
        {
            virtualKeyboardPanel = new VirtualKeyboardPanel();
            this.typingInstructionPanel.Visible = false;

            this.Controls.Add(virtualKeyboardPanel);

            this.virtualKeyboardPanel.Visible = true;
            this.typingPracticePanel.Visible = true;

            HighlightFirstChar();
        }
        private void backButtonToModeSelection(object sender, EventArgs e)
        {
            this.typingPracticePanel.Visible = false;
            this.modeSelectionPanel.Visible = true;
        }
        // TYPING PRACTICE PANEL METHODS
        private void BackButtonToInstruction_Click(object sender, EventArgs e)
        {
            this.typingPracticePanel.Visible = false;
            this.typingInstructionPanel.Visible = true;
        }

        private void HighlightFirstChar()
        {
            Console.WriteLine("key was colored");
            string expectedText = typingPracticePanel.practiceText;

            if (!string.IsNullOrEmpty(expectedText))
            {
                char firstCharToType = char.ToLower(expectedText[0]);

                foreach (Control control in virtualKeyboardPanel.Controls)
                {
                    if (control is Button button)
                    {
                        char keyChar = char.ToLower(button.Text[0]); // Получаем символ клавиши (предполагаем, что текст кнопки - это один символ)
                        if (keyChar == firstCharToType)
                        {
                            button.BackColor = Color.Yellow; // Подсвечиваем желтым первый символ
                        }
                        else
                        {
                            button.BackColor = virtualKeyboardPanel.GetKeyColor(button.Text); // Восстанавливаем исходный цвет остальных клавиш
                        }
                    }
                }
            }
        }


        // Метод для посимвольного сравнения введенного слова с inputTextLabel
        private void CompareUserInputWithExpectedText()
        {
            string userInput = typingPracticePanel.typingTextBox.Text;
            string expectedText = typingPracticePanel.inputTextLabel.Text;

            if (typingPracticePanel.currentCharIndex < expectedText.Length)
            {
                char expectedChar = char.ToLower(expectedText[typingPracticePanel.currentCharIndex]);
                if (userInput.Length > 0 && char.ToLower(userInput[userInput.Length - 1]) == expectedChar)
                {
                    typingPracticePanel.currentCharIndex++;
                    UpdateVirtualKeyboardHighlighting(userInput, expectedText);
                }
                else
                {
                    typingPracticePanel.currentCharIndex++;
                    UpdateVirtualKeyboardHighlighting(userInput, expectedText, true);
                }
            }
            int accuracy = 12;
            int speed = 52;
            if (userInput.Length == expectedText.Length)
            {
                MessageBox.Show($"Example complete\nYour accuracy: {accuracy}%\nYour speed: {speed} cps");
                this.typingPracticePanel.Visible = false;
                this.modeSelectionPanel.Visible = true;
                typingPracticePanel.typingTextBox.Clear();
            }
        }

        // Метод для обновления подсветки клавиш на виртуальной клавиатуре
        private void UpdateVirtualKeyboardHighlighting(string userInput, string textToType, bool isError = false)
        {
            // Проверяем, что currentCharIndex не выходит за пределы строки textToType
            if (typingPracticePanel.currentCharIndex >= textToType.Length)
            {
                return; // Выход из метода, если индекс выходит за пределы строки
            }
            // Получаем следующую букву, которую пользователь должен ввести
            char nextCharToType = char.ToLower(textToType[typingPracticePanel.currentCharIndex]);
            char lastCharTyped = userInput.Length > 0 ? char.ToLower(userInput[userInput.Length - 1]) : '\0';

            // Перебираем клавиши на виртуальной клавиатуре
            foreach (Control control in virtualKeyboardPanel.Controls)
            {
                if (control is Button button)
                {
                    char keyChar = char.ToLower(button.Text[0]); // Получаем символ клавиши (предполагаем, что текст кнопки - это один символ)

                    if (keyChar == lastCharTyped && isError)
                    {
                        button.BackColor = Color.Red; // Подсвечиваем красным, если ошибка
                    }
                    else if (keyChar == nextCharToType && !isError)
                    {
                        button.BackColor = Color.Yellow; // Подсвечиваем желтым следующую букву для ввода
                    }
                    else
                    {
                        button.BackColor = virtualKeyboardPanel.GetKeyColor(button.Text); // Восстанавливаем исходный цвет остальных клавиш
                    }
                }
            }
        }

        // Обработчик события изменения текста в typingTextBox
        private void TypingTextBox_TextChanged(object sender, EventArgs e)
        {
            CompareUserInputWithExpectedText();
        }

    }
}
