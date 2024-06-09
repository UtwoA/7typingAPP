using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace _7typingAPP
{
    public partial class TypingPracticePanel_visual : Panel
    {
        public Label inputTextLabel;
        public TextBox typingTextBox;
        public Button backButtonToInstruction;
        public char currentChar;
        public int currentCharIndex;
        public string practiceText;
        public string userInput;
        Random random = new Random();

        public TypingPracticePanel_visual()
        {
            typingPracticePanelInitializationComponents();
        }
        public void typingPracticePanelInitializationComponents()
        {
            this.inputTextLabel = new Label();
            this.typingTextBox = new TextBox();
            this.backButtonToInstruction = new Button();

            this.ClientSize = new System.Drawing.Size(600, 150);
            int buttonWidth = 150;
            int buttonHeight = 30;

            this.inputTextLabel.Location = new System.Drawing.Point(20, 25);
            this.inputTextLabel.Size = new System.Drawing.Size(560, 50);
            this.inputTextLabel.TextAlign = ContentAlignment.MiddleCenter;
            this.inputTextLabel.Font = new Font("Arial", 11, FontStyle.Bold);
            this.inputTextLabel.ForeColor = Color.FromArgb(28, 64, 56);

            this.typingTextBox.Location = new System.Drawing.Point(20, 80);
            this.typingTextBox.Size = new System.Drawing.Size(560, 50);
            this.typingTextBox.Multiline = true;

            this.backButtonToInstruction.Text = "К инструкции";
            this.backButtonToInstruction.Size = new System.Drawing.Size(buttonWidth, buttonHeight);
            this.backButtonToInstruction.Location = new System.Drawing.Point((ClientSize.Width - backButtonToInstruction.Width) / 2, 150);
            this.backButtonToInstruction.Font = new Font("Arial", 9, FontStyle.Bold);
            this.backButtonToInstruction.ForeColor = Color.FromArgb(28, 64, 56);

            this.Controls.Add(this.inputTextLabel);
            this.Controls.Add(this.typingTextBox);
            this.Controls.Add(this.backButtonToInstruction);
        }
        public void selectText(List<string> textsList)
        {
            Random rand = new Random();
            int index = rand.Next(textsList.Count);
            this.inputTextLabel.Text = textsList[index];
        }
    }
    public partial class TypingPracticePanel_back
    { 
        private TypingPracticePanel_visual typingPracticePanelVisual;
        private VirtualKeyboardPanel_visual virtualKeyboardPanelVisual;
        private VirtualKeyboardPanel_back virtualKeyboardPanelBack;
        public Stopwatch stopwatch;
        private int correctChars;
        private int incorrectChars;

        public TypingPracticePanel_back(TypingPracticePanel_visual typingPracticePanelVisual, VirtualKeyboardPanel_visual virtualKeyboardPanelVisual, VirtualKeyboardPanel_back virtualKeyboardPanelBack, Stopwatch stopwatch)
        {
            this.typingPracticePanelVisual = typingPracticePanelVisual;
            this.virtualKeyboardPanelVisual = virtualKeyboardPanelVisual;
            this.virtualKeyboardPanelBack = virtualKeyboardPanelBack;
            this.stopwatch = stopwatch;

            this.typingPracticePanelVisual.typingTextBox.TextChanged += new EventHandler(TypingTextBox_TextChanged);
        }

        public void CompareUserInputWithExpectedText()
        {
            string userInput = typingPracticePanelVisual.typingTextBox.Text;
            string expectedText = typingPracticePanelVisual.inputTextLabel.Text;

            if (typingPracticePanelVisual.currentCharIndex < expectedText.Length)
            {
                char expectedChar = char.ToLower(expectedText[typingPracticePanelVisual.currentCharIndex]);
                if (userInput.Length > 0 && char.ToLower(userInput[userInput.Length - 1]) == expectedChar)
                {
                    typingPracticePanelVisual.currentCharIndex++;
                    correctChars++;
                    UpdateVirtualKeyboardHighlighting(userInput, expectedText);
                }
                else
                {
                    incorrectChars++;
                    UpdateVirtualKeyboardHighlighting(userInput, expectedText, true);
                }
            }

            if (userInput.Length == expectedText.Length)
            {
                stopwatch.Stop();
                double elapsedSeconds = stopwatch.Elapsed.TotalSeconds;
                int totalChars = correctChars + incorrectChars;
                double accuracy = ((double)correctChars / totalChars) * 100;
                double speed = (correctChars / elapsedSeconds) * 60;

                MessageBox.Show($"Упражнение завершено!\nВаша точность: {accuracy:F2}%\nСкорость ввода: {speed:F2} нажатий в минуту");
                totalChars = 0;
                correctChars = 0;
                incorrectChars = 0;
                typingPracticePanelVisual.typingTextBox.Clear();
                typingPracticePanelVisual.currentCharIndex = 0;

                foreach (Control control in virtualKeyboardPanelVisual.Controls)
                {
                    if (control is Button button)
                    {
                        button.BackColor = VirtualKeyboardPanel_back.GetKeyColor(button.Text);
                    }
                }
            }
        }

        private void UpdateVirtualKeyboardHighlighting(string userInput, string textToType, bool isError = false)
        {

            if (typingPracticePanelVisual.currentCharIndex >= textToType.Length)
            {

                return; // Выход из метода, если индекс выходит за пределы строки
            }

            char nextCharToType = char.ToLower(textToType[typingPracticePanelVisual.currentCharIndex]);
            char lastCharTyped;

            if (userInput.Length > 0)
            {
                lastCharTyped = char.ToLower(userInput[userInput.Length - 1]);
            }
            else
            {
                lastCharTyped = '\0';
            }

            foreach (Control control in virtualKeyboardPanelVisual.Controls)
            {
                if (control is Button button)
                {
                    char keyChar = char.ToLower(button.Text[0]);

                    if (keyChar == lastCharTyped && isError)
                    {
                        button.BackColor = Color.Red; // Подсвечиваем красным, если ошибка
                    }
                    else if (keyChar == nextCharToType)
                    {
                        button.BackColor = Color.Aqua; // Подсвечиваем желтым следующую букву для ввода
                    }
                    else
                    {
                        button.BackColor = VirtualKeyboardPanel_back.GetKeyColor(button.Text); // Восстанавливаем исходный цвет остальных клавиш
                    }
                }
            }
            // Подсвечиваем первую букву, если это начальная загрузка текста
            if (typingPracticePanelVisual.currentCharIndex == 0 && !string.IsNullOrEmpty(textToType))
            {
                HighlightFirstChar(textToType);
            }
        }
        private void HighlightFirstChar(string textToType)
        {
            if (textToType.Length >= 0)
            {
                char firstCharToType = char.ToLower(textToType[0]);

                foreach (Control control in virtualKeyboardPanelVisual.Controls)
                {
                    if (control is Button button)
                    {
                        char keyChar = char.ToLower(button.Text[0]);
                        if (keyChar == firstCharToType)
                        {
                            button.BackColor = Color.Aqua; // Подсвечиваем первый символ
                        }
                        else
                        {
                            button.BackColor = VirtualKeyboardPanel_back.GetKeyColor(button.Text); // Восстанавливаем исходный цвет остальных клавиш
                        }
                    }
                }
            }
        }
        private void TypingTextBox_TextChanged(object sender, EventArgs e)
        {
            CompareUserInputWithExpectedText();
        }
    }
}
