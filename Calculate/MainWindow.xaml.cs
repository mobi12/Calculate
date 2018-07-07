using Calculate.CalculateObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using static Calculate.CalculateObject.OpreatorFactory;

namespace Calculate
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void num1_Click(object sender, RoutedEventArgs e)
        {
            answerWindow.Text += 1;
        }

        private void num2_Click(object sender, RoutedEventArgs e)
        {
            answerWindow.Text += 2;
        }

        private void num3_Click(object sender, RoutedEventArgs e)
        {
            answerWindow.Text += 3;
        }

        private void num4_Click(object sender, RoutedEventArgs e)
        {
            answerWindow.Text += 4;
        }

        private void num5_Click(object sender, RoutedEventArgs e)
        {
            answerWindow.Text += 5;
        }

        private void num6_Click(object sender, RoutedEventArgs e)
        {
            answerWindow.Text += 6;
        }

        private void num7_Click(object sender, RoutedEventArgs e)
        {
            answerWindow.Text += 7;
        }

        private void num8_Click(object sender, RoutedEventArgs e)
        {
            answerWindow.Text += 8;
        }

        private void num9_Click(object sender, RoutedEventArgs e)
        {
            answerWindow.Text += 9;
        }

        private void clear_Click(object sender, RoutedEventArgs e)
        {
            answerWindow.Text = String.Empty;
        }

        private void add_Click(object sender, RoutedEventArgs e)
        {
            int isNumber = 0;
            int.TryParse($"{answerWindow.Text[answerWindow.Text.Length - 1]}", out isNumber);

            if (isNumber > 0)
            {
                answerWindow.Text += '+';
            }
            else
            {
                throw new Exception("谁会在运算符号之后跟运算符号？");
            }
        }

        private void sub_Click(object sender, RoutedEventArgs e)
        {
            int isNumber = 0;
            int.TryParse($"{answerWindow.Text[answerWindow.Text.Length - 1]}", out isNumber);

            if (isNumber > 0)
            {
                answerWindow.Text += '-';
            }
            else
            {
                throw new Exception("谁会在运算符号之后跟运算符号？");
            }
        }

        private void mul_Click(object sender, RoutedEventArgs e)
        {
            int isNumber = 0;
            int.TryParse($"{answerWindow.Text[answerWindow.Text.Length - 1]}", out isNumber);

            if (isNumber > 0)
            {
                answerWindow.Text += 'x';
            }
            else
            {
                throw new Exception("谁会在运算符号之后跟运算符号？");
            }
        }

        private void div_Click(object sender, RoutedEventArgs e)
        {
            int isNumber = 0;
            int.TryParse($"{answerWindow.Text[answerWindow.Text.Length - 1]}", out isNumber);

            if (isNumber > 0)
            {
                answerWindow.Text += '÷';
            }
            else
            {
                throw new Exception("谁会在运算符号之后跟运算符号？");
            }
        }

        private void about_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("我的计算器");
        }

        private void num0_Click(object sender, RoutedEventArgs e)
        {
            answerWindow.Text += 0;
        }

        private void result_Click(object sender, RoutedEventArgs e)
        {
            int isNumber = 0;
            double result = 0;
            char[] splitRules = { '+', '-', 'x', '÷' };
            string[] number = answerWindow.Text.Split(splitRules);
            double[] numberElement = new double[number.Length];
            List<char> tokenList = new List<char>();

            if (answerWindow.Text == String.Empty)
            {
                throw new Exception("空的你让人家怎么算啊？");
            }

            for (int i = 0; i < number.Length; i++)
            {
                numberElement[i] = int.Parse(number[i]);
            }

            for (int i = 0; i < answerWindow.Text.Length; i++)
            {
                int.TryParse($"{answerWindow.Text[i]}", out isNumber);

                if (isNumber == 0)
                {
                    tokenList.Add(answerWindow.Text[i]);
                }
            }

            for (int i = 0; i < tokenList.Count; i++)
            {
                Opreator temp = OpreatorFactory.CreateOpreator(tokenList[i]);
                temp.Number1 = numberElement[i];
                temp.Number2 = numberElement[i + 1];
                numberElement[i + 1] = temp.GetResult();
                result = numberElement[i + 1];
            }

            answerWindow.Text = result.ToString();
        }
    }
}