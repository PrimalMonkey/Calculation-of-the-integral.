using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Практика
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            
            ToolStripMenuItem saveMenuItem = new ToolStripMenuItem("Сохранить");
            ToolStripMenuItem openMenuItem = new ToolStripMenuItem("Открыть");
            
            contextMenuStrip1.Items.AddRange(new[] { saveMenuItem, openMenuItem });
            
            textBox3.ContextMenuStrip = contextMenuStrip1;
            
            
            saveMenuItem.Click += saveMenuItem_Click;
            openMenuItem.Click += openMenuItem_Click;

            button1.Click += button1_Click;
            button4.Click += button4_Click;
            openFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            saveFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            
        }


        void saveMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;

            string filename = saveFileDialog1.FileName;
            string[] text = { textBox1.Text, textBox2.Text, textBox3.Text, textBox7.Text, textBox4.Text };
            File.WriteAllLines(filename, text);
            MessageBox.Show("Файл сохранен");
        }
        
        void openMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;

            string filename = openFileDialog1.FileName;

            string[] fileText = System.IO.File.ReadAllLines(filename);
            textBox1.Text = fileText[0];
            textBox2.Text = fileText[1];
            textBox3.Text = fileText[2];
            textBox7.Text = fileText[3];
            textBox4.Text = fileText[4];
            MessageBox.Show("Файл открыт");
        }

        static double integral(Func<double, double> f, double a, double b, int n)
        {
            double s = (f(a) + f(b)) / 2;
            double h = (b - a) / n;
            for (int i = 1;  i <= n - 1; i++)
            {
                s += f(a + i * h);
            }

            double result = h * s;
            /*var h = (b - a) / n;
            var sum = 0d;
            for (var i = 0; i < n; i++)
            {
                var x = a + i / 2d * h;
                sum += f(x);
            }

            var result = h * sum;*/
            return result;
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            
            string filename = saveFileDialog1.FileName;
            string[] text = { textBox1.Text, textBox2.Text, textBox3.Text, textBox7.Text, textBox4.Text};
            File.WriteAllLines(filename, text);
            MessageBox.Show("Файл сохранен");
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;

            string filename = openFileDialog1.FileName;

            string[] fileText = System.IO.File.ReadAllLines(filename);
            textBox1.Text = fileText[0];
            textBox2.Text = fileText[1];
            textBox3.Text = fileText[2];
            textBox7.Text = fileText[3];
            textBox4.Text = fileText[4];
            MessageBox.Show("Файл открыт");
        }

        // О программе
        private void button2_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show("Практика производственная: практика  по  получению  профессиональных  умений  и  опыта  профессиональной  деятельности (объектно-ориентированное программирование) Программа по расчету интеграла, создана Виговским Леонидом Александровичем, студентом группы №8311. 06.05.2020. Версия 1.1.");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try { double b = double.Parse(textBox1.Text); }

            catch (FormatException) { textBox1.Text = "Это не число!!!"; }


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try { double a = double.Parse(textBox2.Text); }

            catch (FormatException) { textBox2.Text = "Это не число!!!"; }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        // Результат интеграла
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        // Верхний предел
        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            MessageBox.Show("b = ");
        }
        // Нижний предел
        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            MessageBox.Show("a = ");
        }
        // Число прямоугольников
        private void textBox7_TextChanged(object sender, EventArgs e)
        {

            try { double n = double.Parse(textBox7.Text); }

            catch (FormatException) { textBox7.Text = "Это не число!!!"; }
            //string n = textBox7.Text;
            //if(textBox7.Text == "Это не число!!!")
            //textBox7.Text = "Это не число!!!";

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
        // Кнопка "Результат"
        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" || textBox2.Text != "" || textBox7.Text != "")
            {
                double f(double x) => Math.Pow(x, 3) - 5 * Math.Pow(x, 2) - 2 * x + 24;
                var result = integral(f, double.Parse(textBox2.Text), double.Parse(textBox1.Text), int.Parse(textBox7.Text));


                try
                {

                    int x = int.Parse(textBox4.Text);

                    if (x == 1)
                        textBox3.Text = result.ToString("F1");
                    else if (x == 2)
                        textBox3.Text = result.ToString("F2");
                    else if (x == 3)
                        textBox3.Text = result.ToString("F3");
                    else if (x == 4)
                        textBox3.Text = result.ToString("F4");
                    else if (x == 5)
                        textBox3.Text = result.ToString("F5");
                    else if (x == 6)
                        textBox3.Text = result.ToString("F6");
                    else if (x == 7)
                        textBox3.Text = result.ToString("F7");
                    else if (x == 8)
                        textBox3.Text = result.ToString("F8");
                    else if (x == 9)
                        textBox3.Text = result.ToString("F9");
                    else if (x == 10)
                        textBox3.Text = result.ToString("F10");
                    else
                    {
                        textBox3.Text = "Неверно введено количество знаков после запятой";
                    }



                }
                catch (FormatException) { textBox4.Text = "Это не число!!!"; }
            }
            else { textBox3.Text = "Ошибка! Возможно, вы ничего не ввели!"; }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = "b = ";
        }

        private void label2_Click(object sender, EventArgs e)
        {
            label2.Text = "a = ";
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Для начала работы введите данные в поля. При возникновении ошибки ввода, выделите текст ошибки в окне и напишите данные корректно. Для сохранения или открытия файла, воспользуйтесь соответствующими кнопками в верхней панели или нажмите правой кнопкой мыши на поле после знака 'равенства'");
        }

        /*private void button2_Paint(object sender, PaintEventArgs e)
        {
            //this.BackgroundImage = new Bitmap(@"C:\unnamed.jpg");
        }*/
    }

}



