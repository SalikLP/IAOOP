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
using Lesson01;

namespace CalcGUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private double operand1;
        private double operand2;
        private string operate;
        private bool first;
        private ICalculator calc;
        public MainWindow()
        {
            calc = new Calculator();
            first = true;
            InitializeComponent();
            textBox.Text = "";
        }
        private void button1_Click(object sender, RoutedEventArgs e)
        {
            op(1.0);
        }
        private void button2_Click(object sender, RoutedEventArgs e)
        {
            op(2.0);
        }
        

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            op(3.0);
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            op(4.0);
        }

        private void button6_Click(object sender, RoutedEventArgs e)
        {
            op(6.0);
        }

        private void button7_Click(object sender, RoutedEventArgs e)
        {
            op(7.0);
        }

        private void button9_Click(object sender, RoutedEventArgs e)
        {
            op(9.0);
        }


        private void Button0_Click(object sender, RoutedEventArgs e)
        {
            op(0.0);
        }

        private void buttonMul_Click(object sender, RoutedEventArgs e)
        {
            operate = "*";
            first = false;
            operand1 = double.Parse(textBox.Text);
            textBox.Text = "";
        }

        private void buttonDiv_Click(object sender, RoutedEventArgs e)
        {
            operate = "/";
            first = false;
            operand1 = double.Parse(textBox.Text);
            textBox.Text = "";
        }

        private void buttonSub_Click(object sender, RoutedEventArgs e)
        {
            operate = "-";
            first = false;
            operand1 = double.Parse(textBox.Text);
            textBox.Text = "";
        }

        private void buttonAdd_Click(object sender, RoutedEventArgs e)
        {
            operate = "+";
            first = false;
            operand1 = double.Parse(textBox.Text);
            textBox.Text = "";
        }

        private void button8_Click(object sender, RoutedEventArgs e)
        {
            op(8.0);
        }

        private void button5_Click(object sender, RoutedEventArgs e)
        {
           op(5.0);
        }
        private void op(double operand)
        {
            if (first)
            {
               textBox.Text += operand.ToString();
            }
            else
            {
                textBox.Text += operand.ToString();
            }
        }

        private void ButtonEq_Click(object sender, RoutedEventArgs e)
        {
            operand2 = double.Parse(textBox.Text);
            var result = 0.0;
            switch (operate)
            {
                case "+":
                    result = calc.Add(operand1, operand2);
                    break;
                case "-":
                    result = calc.Sub(operand1, operand2);
                    break;
                case "/":
                    result = calc.Divide(operand1, operand2);
                    break;
                case "*":
                    result = calc.Mutiply(operand1, operand2);
                    break;
            }
            textBox.Text = result.ToString();
            first = true;
            operand1 = 0.0;
            operand2 = 0.0;
        }
    }
    
}
