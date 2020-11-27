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

namespace Lab3
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void btnTasks_Click(object sender, RoutedEventArgs e)
        {
            int N = Convert.ToInt32(textBox1.Text);
            int count = 0;
            int summa = 0;
            int sr = 0;
            int percent = Convert.ToInt32(textBox1.Text);
            int Z = Convert.ToInt32(textBox3.Text);
            double sr2 = 0;
            string star = "";
            int[] array = new int[N];
            Random random = new Random();
            listBox1.SelectionMode = System.Windows.Controls.SelectionMode.Multiple;
            listBox1.SelectedIndex = -1;
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox1.Items.Add(" ");
            for (int indexArray = 0; indexArray < N; indexArray++)
            {
                array[indexArray] = 5 + random.Next(30);
                listBox1.Items.Add(array[indexArray]);
            }
            for (int indexArray = 1; indexArray < N - 1; indexArray++)
            {
                if (array[indexArray] > array[indexArray - 1] && array[indexArray] > array[indexArray + 1])
                {
                    count++;
                }
            }
            listBox2.Items.Add("Задание 1");
            for (int indexArray = 0; indexArray < N; indexArray++)
            {
                for (int j = 0; j < array[indexArray]; j++)
                { 
                    star = star + "■";
                }
                listBox2.Items.Add(star);
                star = "";
            }
            listBox2.Items.Add("[--------------------------------------------------------------------------------------------]");
            listBox2.Items.Add("Задание 2");
            count = 0;
            for (int indexArray = 1; indexArray < N - 1; indexArray++)
            {
                if (array[indexArray] < array[indexArray - 1] && array[indexArray] < array[indexArray + 1])
                {
                    count++;
                }
            }
            if (array[0] < array[N - 1] && array[0] < array[1]) { count++; }
            if (array[N - 1] < array[0] && array[N - 1] < array[N - 2]) { count++; }
            if (count > 0)
            {
                listBox2.Items.Add("Кол-во элементов меньших своих соседей: " + count);
            }
            else
            {
                listBox2.Items.Add("Нет элементов, удовлетворяющих условию");
            }
            listBox2.Items.Add("[--------------------------------------------------------------------------------------------]");
            count = 0;
            listBox2.Items.Add("Задание 4");
            count = 0;
            for (int indexArray = 1; indexArray < N - 1; indexArray++)
            {
                if (array[indexArray] > array[indexArray - 1] && array[indexArray] < array[indexArray + 1])
                {
                    count++;
                }
            }
            if (array[0] > array[N - 1] && array[0] < array[1]) { count++; }
            if (array[N - 1] < array[0] && array[N - 1] > array[N - 2]) { count++; }
            if (count > 0)
            {
                listBox2.Items.Add("Кол-во элементов: " + count);
            }
            else
            {
                listBox2.Items.Add("Нет элементов, удовлетворяющих условию");
            }
            listBox2.Items.Add("[--------------------------------------------------------------------------------------------]");
            listBox2.Items.Add("Задание 7");
            for (int indexArray = 0; indexArray < N; indexArray++)
            {
                summa = array[indexArray] + summa;
            }
            sr = summa / N;
            for (int indexArray = 0; indexArray < N; indexArray++)
            {
                sr2 = sr2 + (Math.Abs(array[indexArray] - sr) / N);
            }
            for (int indexArray = 0; indexArray < N; indexArray++)
            {
                if (Math.Abs(array[indexArray] - sr2) > sr2 / 2)
                {
                    array[indexArray] = sr;
                }
                listBox2.Items.Add(array[indexArray]);
            }
            listBox2.Items.Add("[--------------------------------------------------------------------------------------------]");
            listBox2.Items.Add("Задание 8");
            sr2 = 0;
            for (int indexArray = 0; indexArray < N; indexArray++)
            {
                summa = array[indexArray] + summa;
            }
            sr = summa / N;
            for (int indexArray = 0; indexArray < N; indexArray++)
            {
                sr2 = sr2 + (Math.Abs(array[indexArray] - sr) / N);
            }
            sr2 = (((double) sr2 / 100) * percent) * 10;
            for (int indexArray = 0; indexArray < N; indexArray++)
            {
                if (Math.Abs(array[indexArray] - sr2) > sr2 / 2)
                {
                    array[indexArray] = sr;
                }
                listBox2.Items.Add(array[indexArray]);
            }
            listBox2.Items.Add("[--------------------------------------------------------------------------------------------]");
            listBox2.Items.Add("Задание 9");
            sr2 = 0;
            for (int indexArray = 0; indexArray < N; indexArray++)
            {
                summa = array[indexArray] + summa;
            }
            sr = summa / N;
            for (int indexArray = 0; indexArray < N; indexArray++)
            {
                sr2 = sr2 + (Math.Abs(array[indexArray] - sr) / N);
            }
            sr2 = (((double)sr2 / 100) * percent) * 10;
            for (int indexArray = 0; indexArray < N; indexArray++)
            {
                if (Math.Abs(array[indexArray] - sr2) > sr2 / 2)
                {
                    array[indexArray] = Z;
                }
                listBox2.Items.Add(array[indexArray]);
            }
            listBox2.Items.Add("[--------------------------------------------------------------------------------------------]");
            listBox2.Items.Add("Задание 3");
            sr = 0;
            for (int indexArray = 0; indexArray < N; indexArray++)
            {
                summa = array[indexArray] + summa;
            }
            summa = summa / 2;
            listBox2.Items.Add(summa + " сумма");
            sr = summa / N;
            listBox2.Items.Add(sr + " среднее значение");
            for (int indexArray = 0; indexArray < N; indexArray++)
            {
                Array.Sort(array);
                if (array[indexArray] > sr)
                {
                    listBox2.Items.Add(array[indexArray] + " минимальное больше среднего");
                    break;
                }
            }
            listBox2.Items.Add("[--------------------------------------------------------------------------------------------]");
            listBox2.Items.Add("Задание 5");
            for (int indexArray = 0; indexArray < N; indexArray++)
            {
                if (indexArray == N)
                {
                    indexArray = 0;
                }
                listBox2.Items.Add(array[indexArray]);
            }
            listBox2.Items.Add("[--------------------------------------------------------------------------------------------]");
            listBox2.Items.Add("Задание 6");
            for (int indexArray = 0; indexArray < N; indexArray++)
            {

                listBox2.Items.Add(array[indexArray]);
            }

            listBox2.Items.Add("-----");
            for (int indexArray = 0; indexArray < N; indexArray++)
            {
                array[indexArray] = array[indexArray] - sr;

                listBox2.Items.Add(array[indexArray]);
            }

        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

    }
}
