using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Diagnostics;
using Microsoft.VisualBasic;

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
        Random random = new Random();

        // Variables for tracking typing performance
        private Stopwatch stopwatch;
        private int correctChars;
        private int incorrectChars;

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
            this.virtualKeyboardPanel.Visible = false;

            mainPanel.startButton.Click += new EventHandler(StartButton_Click);
            mainPanel.statisticsButton.Click += new EventHandler(StatisticsButton_Click);
            mainPanel.exitButton.Click += new EventHandler(ExitButton_Click);

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

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
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
            StartTypingPractice("NumPad Mode\r\nВ этом режиме пользователю будут представлены для ввода только цифры. Это идеальный выбор для тех, \nкто хочет улучшить свои навыки ввода чисел на цифровой клавиатуре. Этот режим поможет повысить точность \nи скорость работы с цифрами, что полезно для выполнения бухгалтерских задач, работы с таблицами и других действий, требующих ввода чисел.");
            string[] TextList = File.ReadAllLines("C:/folder/NumPad.txt");
            List<string> practiceTexts = TextList.ToList();
            typingPracticePanel.selectText(practiceTexts);
        }

        private void TouchTypingModeButton_Click(object sender, EventArgs e)
        {
            StartTypingPractice("Touch Typing\r\nВ этом режиме пользователю будут представлены для ввода комбинации букв, не имеющих смысла. \nОсновная цель данного режима — развить навыки слепой печати и улучшить координацию пальцев. Ввод бессмысленных буквенных комбинаций помогает пользователю сосредоточиться на механике печати, не отвлекаясь на смысл текста.");
            string[] TextList = File.ReadAllLines("C:/folder/Touch Typing.txt");
            List<string> practiceTexts = TextList.ToList();
            typingPracticePanel.selectText(practiceTexts);
        }

        private void BlindTypingModeButton_Click(object sender, EventArgs e)
        {
            StartTypingPractice("Blind Typing\r\nВ этом режиме пользователю будут представлены для ввода осмысленный текст. Это может быть статья, \nрассказ или отрывок из книги. Цель этого режима — улучшить навыки слепой печати осмысленного текста, \nчто помогает развивать память пальцев и увеличивает общую скорость печати, а также улучшает навыки восприятия и ввода текста.");
            string[] TextList = File.ReadAllLines("C:/folder/Blind Typing.txt");
            List<string> practiceTexts = TextList.ToList();
            typingPracticePanel.selectText(practiceTexts);
        }

        private void FastTypingModeButton_Click(object sender, EventArgs e)
        {
            StartTypingPractice("Fast Typing\r\nВ этом режиме пользователю будут представлены для ввода усложненный осмысленный текст. Тексты могут \nсодержать сложные слова, знаки препинания и цифры. Цель данного режима — максимально увеличить \nскорость nпечати при сохранении точности. Этот режим идеален для тех, кто хочет продвинуть свои навыки на новый уровень и научиться быстро и точно печатать сложные тексты.");
            string[] TextList = File.ReadAllLines("C:/folder/Fast Typing.txt");
            List<string> practiceTexts = TextList.ToList();
            typingPracticePanel.selectText(practiceTexts);
        }

        private void TypingTestsModeButton_Click(object sender, EventArgs e)
        {
            StartTypingPractice("Typing Tests\r\nВ этом режиме пользователю будут представлены для ввода тесты. Каждый тест имеет определенное время \nи сложность, по окончании которого пользователь получает оценку своих навыков. Это помогает объективно \nоценить свои возможности и прогресс в обучении, а также выявить слабые стороны, требующие доработки.");
            string[] TextList = File.ReadAllLines("C:/folder/Typing Tests.txt");
            List<string> practiceTexts = TextList.ToList();
            typingPracticePanel.selectText(practiceTexts);
        }

        private void FreeModeButton_Click(object sender, EventArgs e)
        {
            StartTypingPractice("Free Mode\r\nВ этом режиме пользователь может загрузить свой файл с текстом, после чего вводить его. Это позволяет \nтренироваться на тех текстах, которые наиболее актуальны для пользователя. Можно загрузить любой текст: \nстатьи, рабочие документы, учебные материалы и другие. Такой режим предоставляет максимальную гибкость в обучении и позволяет адаптировать тренировки под индивидуальные нужды пользователя.");
            string[] TextList = File.ReadAllLines("C:/folder/Free Mode.txt");
            List<string> practiceTexts = TextList.ToList();
            typingPracticePanel.selectText(practiceTexts);
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

        private void NextButton_Click(object sender, EventArgs e)
        {
            // Создаем экземпляр виртуальной клавиатуры
            this.typingInstructionPanel.Visible = false;

            this.Controls.Add(virtualKeyboardPanel);

            this.virtualKeyboardPanel.Visible = true;
            this.typingPracticePanel.Visible = true;

            typingPracticePanel.currentCharIndex = 0; // Сброс индекса символа перед началом

            CompareUserInputWithExpectedText();
            typingPracticePanel.typingTextBox.Clear(); // Сброс текста перед началом

            // Start timing and reset counters
            stopwatch = Stopwatch.StartNew();
            correctChars = 0;
            incorrectChars = 0;
        }

        private void backButtonToModeSelection(object sender, EventArgs e)
        {
            this.typingPracticePanel.Visible = false;
            this.modeSelectionPanel.Visible = true;
            CompareUserInputWithExpectedText();

            typingPracticePanel.typingTextBox.Clear(); // Сброс текста при возврате к выбору режима
        }

        // TYPING PRACTICE PANEL METHODS
        private void BackButtonToInstruction_Click(object sender, EventArgs e)
        {
            this.typingPracticePanel.Visible = false;
            this.typingInstructionPanel.Visible = true;
            typingPracticePanel.typingTextBox.Clear(); // Сброс текста при возврате к инструкции
        }

        private void HighlightFirstChar(string textToType)
        {
            if (textToType.Length >= 0)
            {
                char firstCharToType = char.ToLower(textToType[0]);

                foreach (Control control in virtualKeyboardPanel.Controls)
                {
                    if (control is Button button)
                    {
                        char keyChar = char.ToLower(button.Text[0]);
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
        public void CompareUserInputWithExpectedText()
        {
            string userInput = typingPracticePanel.typingTextBox.Text;
            string expectedText = typingPracticePanel.inputTextLabel.Text;

            if (typingPracticePanel.currentCharIndex < expectedText.Length)
            {
                char expectedChar = char.ToLower(expectedText[typingPracticePanel.currentCharIndex]);
                if (userInput.Length > 0 && char.ToLower(userInput[userInput.Length - 1]) == expectedChar)
                {
                    typingPracticePanel.currentCharIndex++;
                    correctChars++;
                    UpdateVirtualKeyboardHighlighting(userInput, expectedText);
                }
                else
                {
                    incorrectChars++;
                    // Подсветить красным неверную букву и желтым следующую букву
                    UpdateVirtualKeyboardHighlighting(userInput, expectedText, true);
                }
            }

            if (userInput.Length == expectedText.Length)
            {
                stopwatch.Stop();
                double elapsedSeconds = stopwatch.Elapsed.TotalSeconds;
                int totalChars = correctChars + incorrectChars;
                double accuracy = ((double)correctChars / totalChars) * 100;
                double speed = (correctChars / elapsedSeconds) * 60; // characters per minute (CPM)

                MessageBox.Show($"Example complete\nYour accuracy: {accuracy:F2}%\nYour speed: {speed:F2} CPM");
                this.typingPracticePanel.Visible = false;
                this.modeSelectionPanel.Visible = true;
                typingPracticePanel.typingTextBox.Clear();
                typingPracticePanel.currentCharIndex = 0; // Сброс индекса символа
                foreach (Control control in virtualKeyboardPanel.Controls)
                {
                    if (control is Button button)
                    {
                        button.BackColor = virtualKeyboardPanel.GetKeyColor(button.Text); // Восстанавливаем исходный цвет остальных клавиш
                    }
                }
            }
        }

        // Метод для обновления подсветки клавиш на виртуальной клавиатуре
        private void UpdateVirtualKeyboardHighlighting(string userInput, string textToType, bool isError = false)
        {
            
            if (typingPracticePanel.currentCharIndex >= textToType.Length)
            {
                
                return; // Выход из метода, если индекс выходит за пределы строки
            }

            char nextCharToType = char.ToLower(textToType[typingPracticePanel.currentCharIndex]);
            char lastCharTyped = userInput.Length > 0 ? char.ToLower(userInput[userInput.Length - 1]): '\0';

            foreach (Control control in virtualKeyboardPanel.Controls)
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
                        button.BackColor = virtualKeyboardPanel.GetKeyColor(button.Text); // Восстанавливаем исходный цвет остальных клавиш
                    }
                }
            }
            // Подсвечиваем желтым первую букву, если это начальная загрузка текста
            if (typingPracticePanel.currentCharIndex == 0 && !string.IsNullOrEmpty(textToType))
            {
                HighlightFirstChar(textToType);
            }
        }

        // Обработчик события изменения текста в typingTextBox
        private void TypingTextBox_TextChanged(object sender, EventArgs e)
        {
            CompareUserInputWithExpectedText();
        }
    }
}
