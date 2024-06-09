using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace _7typingAPP
{
    public partial class TypingInstructionPanel : Panel
    {
        public Label instructionLabel;
        public Button nextButton;
        public Button backButtonToModeSelection;
        public PictureBox instructionPictureBox;

        public TypingInstructionPanel()
        {
            typingInstructionPanelInitializationcomponents();
        }
        public void typingInstructionPanelInitializationcomponents()
        {
            this.instructionLabel = new Label();
            this.nextButton = new Button();
            this.instructionPictureBox = new PictureBox();
            this.backButtonToModeSelection = new Button();

            this.ClientSize = new System.Drawing.Size(600, 450);
            int buttonWidth = 150;
            int buttonHeight = 30;
            int buttonLeft = (this.ClientSize.Width - buttonWidth) / 2;

            this.instructionLabel.Location = new Point(20, 3);
            this.instructionLabel.Size = new System.Drawing.Size(580, 110);
            this.instructionLabel.Font = new Font("Arial", 11, FontStyle.Regular);
            this.instructionLabel.ForeColor = Color.FromArgb(209, 208, 123);

            this.nextButton.Text = "Далее";
            this.nextButton.Size = new Size(buttonWidth, buttonHeight);
            this.nextButton.Location = new System.Drawing.Point((ClientSize.Width - nextButton.Width) / 4 * 3, this.ClientSize.Height - nextButton.Height * 3 / 2);
            this.nextButton.Font = new Font("Arial", 9, FontStyle.Bold);
            this.nextButton.ForeColor = Color.FromArgb(28, 64, 56);

            this.instructionPictureBox.Size = new Size(this.ClientSize.Width, this.ClientSize.Height / 3 * 2);
            this.instructionPictureBox.Location = new Point(0, 105);
            this.instructionPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            
            this.backButtonToModeSelection.Size = new Size(buttonWidth, buttonHeight);
            this.backButtonToModeSelection.Text = "Назад";
            this.backButtonToModeSelection.Location = new System.Drawing.Point((ClientSize.Width - nextButton.Width) / 4, this.ClientSize.Height - nextButton.Height * 3 / 2);
            this.backButtonToModeSelection.Font = new Font("Arial", 9, FontStyle.Bold);
            this.backButtonToModeSelection.ForeColor = Color.FromArgb(28, 64, 56);

            this.Controls.Add(this.instructionLabel);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.backButtonToModeSelection);
            this.Controls.Add(this.instructionPictureBox);


        }
    }
    public class Starter
    {
        private Panel modeSelectionPanel;
        private Panel typingInstructionPanel;
        private Label instructionLabel;
        private PictureBox instructionPictureBox;
        private TypingPracticePanel_visual typingPracticePanelVisual;
        private StatisticsPanel_back statisticsPanelBack;

        public Starter(Panel modeSelectionPanel, Panel typingInstructionPanel, Label instructionLabel, PictureBox instructionPictureBox, TypingPracticePanel_visual typingPracticePanelVisual, StatisticsPanel_back statisticsPanelBack)
        {
            this.modeSelectionPanel = modeSelectionPanel;
            this.typingInstructionPanel = typingInstructionPanel;
            this.instructionLabel = instructionLabel;
            this.instructionPictureBox = instructionPictureBox;
            this.typingPracticePanelVisual = typingPracticePanelVisual;
            this.statisticsPanelBack = statisticsPanelBack;
        }

        public void StartNumPadMode()
        {
            StartTypingPractice("NumPad Mode\r\nВ этом режиме пользователю будут представлены для ввода только цифры. Это идеальный выбор для тех, кто хочет улучшить свои навыки ввода чисел на цифровой клавиатуре. Этот режим поможет повысить точность и скорость работы с цифрами, что полезно для выполнения бухгалтерских задач, работы с таблицами и других действий, требующих ввода чисел.");
            string[] TextList = File.ReadAllLines("Texts/NumPad.txt");
            List<string> practiceTexts = TextList.ToList();
            typingPracticePanelVisual.selectText(practiceTexts);
            statisticsPanelBack.IncrementModeCount("NumPad Mode");
        }
        public void StartTouchTypingMode()
        {
            StartTypingPractice("Touch Typing\r\nВ этом режиме пользователю будут представлены для ввода комбинации букв, не имеющих смысла. Основная цель данного режима — развить навыки слепой печати и улучшить координацию пальцев. Ввод бессмысленных буквенных комбинаций помогает пользователю сосредоточиться на механике печати, не отвлекаясь на смысл текста.");
            string[] TextList = File.ReadAllLines("Texts/Touch Typing.txt");
            List<string> practiceTexts = TextList.ToList();
            typingPracticePanelVisual.selectText(practiceTexts);
            statisticsPanelBack.IncrementModeCount("Touch Typing");
        }
        public void StartBlindTypingMode()
        {
            StartTypingPractice("Blind Typing\r\nВ этом режиме пользователю будут представлены для ввода осмысленный текст. Это может быть статья, рассказ или отрывок из книги. Цель этого режима — улучшить навыки слепой печати осмысленного текста, что помогает развивать память пальцев и увеличивает общую скорость печати, а также улучшает навыки восприятия и ввода текста.");
            string[] TextList = File.ReadAllLines("Texts/Blind Typing.txt");
            List<string> practiceTexts = TextList.ToList();
            typingPracticePanelVisual.selectText(practiceTexts);
            statisticsPanelBack.IncrementModeCount("Blind Typing");
        }

        public void StartFastTypingMode()
        {
            StartTypingPractice("Fast Typing\r\nВ этом режиме пользователю будут представлены для ввода усложненный осмысленный текст. Тексты могут содержать сложные слова, знаки препинания и цифры. Цель данного режима — максимально увеличить скорость nпечати при сохранении точности. Этот режим идеален для тех, кто хочет продвинуть свои навыки на новый уровень и научиться быстро и точно печатать сложные тексты.");
            string[] TextList = File.ReadAllLines("Texts/Fast Typing.txt");
            List<string> practiceTexts = TextList.ToList();
            typingPracticePanelVisual.selectText(practiceTexts);
            statisticsPanelBack.IncrementModeCount("Fast Typing");
        }

        public void StartTypingTestsMode()
        {
            StartTypingPractice("Typing Tests\r\nВ этом режиме пользователю будут представлены для ввода несвязанные предложения. Каждое упражнение имеет определенное время и сложность, по окончании которого пользователь получает оценку своих навыков.");
            string[] TextList = File.ReadAllLines("Texts/Typing Tests.txt");
            List<string> practiceTexts = TextList.ToList();
            typingPracticePanelVisual.selectText(practiceTexts);
            statisticsPanelBack.IncrementModeCount("Typing Tests");
        }

        public void StartFreeMode()
        {
            StartTypingPractice("Free Mode\r\nВ этом режиме пользователь может свободно печатать любой текст.");
            typingPracticePanelVisual.selectText(new List<string> { "Набирайте что угодно!                                                                                                                                                                                                                                                                                                                                                                                         " });
            statisticsPanelBack.IncrementModeCount("Free Mode");
        }
        private void StartTypingPractice(string instructions)
        {
            this.modeSelectionPanel.Visible = false;
            this.typingInstructionPanel.Visible = true;
            instructionLabel.Text = instructions;
            instructionPictureBox.Image = Image.FromFile("picture.jpg");
        }
    }
}
