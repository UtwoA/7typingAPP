﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace _7typingAPP
{
    public partial class VirtualKeyboardPanel : Panel
    {
        private Dictionary<char, Button> keyboardButtons = new Dictionary<char, Button>();
        private Dictionary<char, Color> keysColors = new Dictionary<char, Color>();

        public VirtualKeyboardPanel()
        {
            VirtualKeyboardPanelInitializeComponent();
        }

        private void VirtualKeyboardPanelInitializeComponent()
        {
            CreateVirtualKeyboard();
        }

        public void CreateVirtualKeyboard()
        {
            this.ClientSize = new Size(600, 450);
            this.Location = new Point(10, 200);
            this.SuspendLayout();

            string[] keyboardLayout = {
        "Ё1234567890-=",
        "ЙЦУКЕНГШЩЗХЪ",
        "ФЫВАПРОЛДЖЭ",
        "ЯЧСМИТЬБЮ."
    };

            int keySize = 40;
            int spacingX = 2;
            int spacingY = 2;

            for (int row = 0; row < keyboardLayout.Length; row++)
            {
                for (int col = 0; col < keyboardLayout[row].Length; col++)
                {
                    Button keyButton = new Button();
                    keyButton.Text = keyboardLayout[row][col].ToString();
                    keyButton.Size = new Size(keySize, keySize);
                    int x = col * (keySize + spacingX);
                    int y = row * (keySize + spacingY);
                    // Добавляем смещение, чтобы кнопки располагались как на реальной клавиатуре
                    if (row == 1)
                    {
                        x += spacingX * col + row * 60; // Смещение по горизонтали
                        y += spacingY * row; // Смещение по вертикали
                    }
                    else if (row == 2)
                    {
                        x += spacingX * col + row * 35; // Смещение по горизонтали
                        y += spacingY * row; // Смещение по вертикали
                    }
                    else if (row == 3)
                    {
                        x += spacingX * col + row * 30; // Смещение по горизонтали
                        y += spacingY * row; // Смещение по вертикали
                    }
                    keyButton.Location = new Point(x, y);

                    keyButton.BackColor = GetKeyColor(keyButton.Text);
                    keyboardButtons[keyboardLayout[row][col]] = keyButton;
                    keysColors[keyboardLayout[row][col]] = keyButton.BackColor;

                    this.Controls.Add(keyButton);
                }
            }
        }



        public Color GetKeyColor(string key)
        {
            Console.WriteLine("key was decolored");

            if ("Ё1ЙФЯ".Contains(key)) return Color.Beige;
            if ("2ЦЫЧ".Contains(key)) return Color.LightBlue;
            if ("3УВС".Contains(key)) return Color.Green;
            if ("4КАМ56ЕПИ".Contains(key)) return Color.Red;
            if ("7НГРОТЬ".Contains(key)) return Color.Purple;
            if ("8ШЛБ".Contains(key)) return Color.Gray;
            if ("9ЩДЮ".Contains(key)) return Color.LightYellow;
            if ("0ЗХЪЖЭ.-=".Contains(key)) return Color.Pink;
            return Color.LightGray;
        }

    }
}