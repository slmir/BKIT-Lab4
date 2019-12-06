using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using DistanceLib;

namespace Lab5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "Мирсонов РТ5-31Б --- Лабораторная работа №5";
        }

        List<string> list = new List<string>();//список

        private void Download_time_label_Click(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)//кнопка чтения
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.Filter = "текстовые файлы|*.txt";//свойство Filter содержит список расширений файлов
            if (fd.ShowDialog() == DialogResult.OK)//ShowDialog производит открытие диалогового окна
            {
                Stopwatch DownloadTimer = new Stopwatch();//объявляется и запускается таймер загрузки файла
                Stopwatch SaveTimer = new Stopwatch();
                DownloadTimer.Start();
                SaveTimer.Start();
                string text = File.ReadAllText(fd.FileName);//содержимое файла считывается в виде переменной text типа string. Свойство fd.FileName возвращает путь и имя файла
                DownloadTimer.Stop();
                char[] razdelSimbols = new char[] { ' ', '.', ',', '!', '?', '/', '\t', '\n' };//массив символов для разделения слов при чтении файла
                string[] textArray = text.Split(razdelSimbols);//массив слов файла, произведенный методом разделения Split на основе разделительных символов
                foreach (string strTemp in textArray)
                {
                    string str = strTemp.Trim();//для корректной работы удаляем пробелы в начале и конце файла
                    if (list.Contains(str) != true)//если строка не содержится в списке
                        list.Add(str);//добавление строки в список
                }
                SaveTimer.Stop();
                this.textBox1.Text = DownloadTimer.Elapsed.ToString();//время загрузки
                this.textBox2.Text = SaveTimer.Elapsed.ToString();//время сохранения
            }
            else//если пользователь не выбрал текстовый файл
            {
                MessageBox.Show("Необходимо выбрать файл");
            }
        }

        private void button2_Click(object sender, EventArgs e)//закрытие формы
        {
            this.Close();
        }

        private void buttonExact_Click(object sender, EventArgs e)//четкий поиск слова
        {
            string Find_word = this.textBox_find_word.Text.Trim();//слово для поиска - набор символов, введенных в окно для ввода слова для поиска textBox_find_word
            if (!string.IsNullOrWhiteSpace(Find_word) && list.Count > 0)//если данное поле не пусто и прочитаны данные из файла
            {
                string wordUpp = Find_word.ToUpper();//введеное для поиска слово Find_word переводится в верхний регистр для более легкого поиска
                List<string> tempList = new List<string>();//временный список найденных слов
                Stopwatch SearchTime = new Stopwatch();//объявляем время поиска слова
                SearchTime.Start();
                foreach (string str in list)//перебор всех слов в списке list
                {
                    if (str.ToUpper().Contains(wordUpp))//если текущее рассматриваемое слово содержит введеное для поиска слово Find_word как подстроку
                    {
                        tempList.Add(str);//добавление слова во временный список найденных слов
                    }
                }
                SearchTime.Stop();
                this.textBox3.Text = SearchTime.Elapsed.ToString();//вывод времени поиска в определенный для этого textBox_searching_time

                this.listBox1.BeginUpdate();//начало обновления данных списка
                this.listBox1.Items.Clear();//очитска результатов предыдущего поиска
                foreach (string str in tempList)//перечисление слов из временного списка найденных слов
                {
                    this.listBox1.Items.Add(str);//добавление подходящего слова в список listBox_finded_word
                }
                this.listBox1.EndUpdate();//завершение обновления данных
            }
            else//если слово не введено или данные из файла не считаны
            {
                MessageBox.Show("Необходимо выбрать файл и ввести слово для поиска");
            }
        }

		public void buttonApprox_Click(object sender, EventArgs e)//нечеткий поиск слова
		{
			string word_nechet = this.textBox_find_word.Text.Trim();//слово для нечеткого поиска
			if (!string.IsNullOrWhiteSpace(word_nechet) && list.Count > 0)//если строка для ввода слова не пуста
			{
				int maxDist;//максимальное расстояние для нечеткого поиска
				if (!int.TryParse(this.textBox4.Text.Trim(), out maxDist))//если не указано максимальное расстояние
				{
					MessageBox.Show("Необходимо указать максимальное расстояние");
					return;
				}
				if (maxDist < 1 || maxDist > 5)//указание диапазона для максимального расстояния
				{
					MessageBox.Show("Максимальное расстояние должно быть в диапазоне от 1 до 5");
					return;
				}
				string wordword_nechetUpper = word_nechet.ToUpper();//перевод слово, поиск которого будет производится в верхний регистр
				List<Tuple<string, int>> tempList = new List<Tuple<string, int>>();//список для временного хранения найденных слов
				Stopwatch nechetSearchTime = new Stopwatch();//время нечетког поиска
				nechetSearchTime.Start();
				foreach (string str in list)//в списке слов(строк) рассматривая каждое слово вычисляем расстояние Дамерау-Левенштейна для текущего слова и введенного в окно нечеткого поиска
				{
					int dist = Damerau_Livenshtein_distance.Distance(str.ToUpper(), wordword_nechetUpper);//расстояние мужду ними по описанной в классе из библиотеки классов DistanceLib

					//Если расстояние меньше порогового, то слово добавляется в результат
					if (dist <= maxDist)//если расстояние в пределах порогового
					{
						tempList.Add(new Tuple<string, int>(str, dist));//добавление в временный список текущего солва, так как оно удовлетворяет улсовиям нечеткого поиска
					}
				}
				nechetSearchTime.Stop();
				this.textBox5.Text = nechetSearchTime.Elapsed.ToString();//вывод времени нечеткого поиска
				this.listBox1.BeginUpdate();
				this.listBox1.Items.Clear();//очитска списка в окне
				foreach (var x in tempList)//вывод результатов
				{
					string temp = x.Item1 + " ( расстояние = " + x.Item2.ToString() + " )";
					this.listBox1.Items.Add(temp);
				}
				this.listBox1.EndUpdate();
			}
			else
			{
				MessageBox.Show("Необходимо выбрать файл и ввести слово для поиска");
			}
		}
	}
}
