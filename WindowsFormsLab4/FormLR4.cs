﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace Lab4
{
    public partial class FormLR4 : Form
    {
        public FormLR4()
        {
            InitializeComponent();
            this.Text = "Открытие файла и поиск слова --- Мирсонов РТ5-31Б";
        }

        List<string> list = new List<string>();//список

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

        private void Close_form_button_Click(object sender, EventArgs e)//кнопка закрытия формы
        {
            this.Close();
        }

        private void Search_word_button_Click(object sender, EventArgs e)//кнопка поиска слова
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
                this.textBox_searching_time.Text = SearchTime.Elapsed.ToString();//вывод времени поиска в определенный для этого textBox_searching_time

                this.listBox_finded_word.BeginUpdate();//начало обновления данных списка
                this.listBox_finded_word.Items.Clear();//очитска результатов предыдущего поиска
                foreach (string str in tempList)//перечисление слов из временного списка найденных слов
                {
                    this.listBox_finded_word.Items.Add(str);//добавление подходящего слова в список listBox_finded_word
                }
                this.listBox_finded_word.EndUpdate();//завершение обновления данных
            }
            else//если слово не введено или данные из файла не считаны
            {
                MessageBox.Show("Необходимо выбрать файл и ввести слово для поиска");
            }
        }

        private void textBox_find_word_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
