using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TrainingPractice_2
{
    public partial class Form1 : Form
    {
        string puzzledWord = "";
        const int wordLength = 4;
        int stepCount = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<int> digits = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Random random = new Random();
            for (int i = 0; i < wordLength; i++)
            {
               int digitIndex = random.Next(0, digits.Count);

                puzzledWord += digits[digitIndex].ToString();

                digits.RemoveAt(digitIndex);
            }
            puzzledWordLabel.Text = puzzledWord;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userWord = userWordTextBox.Text;

            if (!IsValid(userWord))
            {
                return;
            }

            stepCount++;
            int bullsCount = CalculateBullsCount(userWord);
            int cowsCount = CalculateCowsCount(userWord);

            bullsCountLabel.Text = "Быков = " + bullsCount;
            cowsCountLabel.Text = "Коров = " + cowsCount;

            historyDataGridView.Rows.Add(stepCount, userWord, bullsCount, cowsCount);
        }

        private bool IsValid(string userWord)
        {
            if (userWord.Length != wordLength)
            {
                MessageBox.Show("Строка должна быть длиной 4!");
                return false;
            }
            
            for (int i = 0;i < wordLength;i++)
            {
                if (!char.IsDigit(userWord[i]))
                {
                    MessageBox.Show("Строка должна содержать ONLY BRO цифры!");
                    return false;
                }
            }

            for (int i = 0; i < userWord.Length;i++)
            {
                for (int j = i + 1; j < userWord.Length; j++)
                {
                    if (userWord[i] == userWord[j])
                    {
                        MessageBox.Show("Строка должна содержать уникальные цифры!");
                        return false;
                    }
                }
            }
            return true;
        }
        private int CalculateBullsCount(string userWord)
        {
            int bullsCount = 0;
            for (int i = 0;i < wordLength;i++)
            {
                if(puzzledWord[i] == userWord[i])
                {
                    bullsCount++;
                }
            }
            return bullsCount;
        }

        private int CalculateCowsCount(string userWord)
        {
            int cowsCount = 0;
            for (int i = 0; i < wordLength; i++)
            {
                for (int j = 0; j < wordLength; j++)
                {
                    if (i == j)
                        continue;
                    if(puzzledWord[i] == userWord[j])
                    {
                        cowsCount++;
                    }
                }
            }
            
            return cowsCount;
        }

    }
}
