namespace Lab4
{
    partial class FormLR4
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Read_button = new System.Windows.Forms.Button();
            this.Download_time_label = new System.Windows.Forms.Label();
            this.Save_time_label = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox_find_word = new System.Windows.Forms.TextBox();
            this.Find_word_label = new System.Windows.Forms.Label();
            this.Search_word_button = new System.Windows.Forms.Button();
            this.listBox_finded_word = new System.Windows.Forms.ListBox();
            this.Close_form_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_searching_time = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Read_button
            // 
            this.Read_button.Location = new System.Drawing.Point(13, 13);
            this.Read_button.Name = "Read_button";
            this.Read_button.Size = new System.Drawing.Size(160, 51);
            this.Read_button.TabIndex = 0;
            this.Read_button.Text = "Чтение файла";
            this.Read_button.UseVisualStyleBackColor = true;
            this.Read_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // Download_time_label
            // 
            this.Download_time_label.AutoSize = true;
            this.Download_time_label.Location = new System.Drawing.Point(270, 16);
            this.Download_time_label.Name = "Download_time_label";
            this.Download_time_label.Size = new System.Drawing.Size(124, 13);
            this.Download_time_label.TabIndex = 1;
            this.Download_time_label.Text = "Время загрузки файла";
            // 
            // Save_time_label
            // 
            this.Save_time_label.AutoSize = true;
            this.Save_time_label.Location = new System.Drawing.Point(270, 53);
            this.Save_time_label.Name = "Save_time_label";
            this.Save_time_label.Size = new System.Drawing.Size(137, 13);
            this.Save_time_label.TabIndex = 2;
            this.Save_time_label.Text = "Время сохранения файла";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(434, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(202, 20);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(434, 50);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(202, 20);
            this.textBox2.TabIndex = 4;
            // 
            // textBox_find_word
            // 
            this.textBox_find_word.Location = new System.Drawing.Point(13, 214);
            this.textBox_find_word.Name = "textBox_find_word";
            this.textBox_find_word.Size = new System.Drawing.Size(159, 20);
            this.textBox_find_word.TabIndex = 5;
            // 
            // Find_word_label
            // 
            this.Find_word_label.AutoSize = true;
            this.Find_word_label.Location = new System.Drawing.Point(13, 195);
            this.Find_word_label.Name = "Find_word_label";
            this.Find_word_label.Size = new System.Drawing.Size(159, 13);
            this.Find_word_label.TabIndex = 6;
            this.Find_word_label.Text = "Поле ввода слова для поиска";
            // 
            // Search_word_button
            // 
            this.Search_word_button.Location = new System.Drawing.Point(248, 184);
            this.Search_word_button.Name = "Search_word_button";
            this.Search_word_button.Size = new System.Drawing.Size(146, 50);
            this.Search_word_button.TabIndex = 7;
            this.Search_word_button.Text = "Найти слово";
            this.Search_word_button.UseVisualStyleBackColor = true;
            this.Search_word_button.Click += new System.EventHandler(this.Search_word_button_Click);
            // 
            // listBox_finded_word
            // 
            this.listBox_finded_word.FormattingEnabled = true;
            this.listBox_finded_word.Location = new System.Drawing.Point(13, 256);
            this.listBox_finded_word.Name = "listBox_finded_word";
            this.listBox_finded_word.Size = new System.Drawing.Size(381, 186);
            this.listBox_finded_word.TabIndex = 8;
            // 
            // Close_form_button
            // 
            this.Close_form_button.Location = new System.Drawing.Point(468, 389);
            this.Close_form_button.Name = "Close_form_button";
            this.Close_form_button.Size = new System.Drawing.Size(168, 52);
            this.Close_form_button.TabIndex = 9;
            this.Close_form_button.Text = "Закрыть форму";
            this.Close_form_button.UseVisualStyleBackColor = true;
            this.Close_form_button.Click += new System.EventHandler(this.Close_form_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(434, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Время поиска слова";
            // 
            // textBox_searching_time
            // 
            this.textBox_searching_time.Location = new System.Drawing.Point(437, 214);
            this.textBox_searching_time.Name = "textBox_searching_time";
            this.textBox_searching_time.Size = new System.Drawing.Size(199, 20);
            this.textBox_searching_time.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 450);
            this.Controls.Add(this.textBox_searching_time);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Close_form_button);
            this.Controls.Add(this.listBox_finded_word);
            this.Controls.Add(this.Search_word_button);
            this.Controls.Add(this.Find_word_label);
            this.Controls.Add(this.textBox_find_word);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Save_time_label);
            this.Controls.Add(this.Download_time_label);
            this.Controls.Add(this.Read_button);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Read_button;
        private System.Windows.Forms.Label Download_time_label;
        private System.Windows.Forms.Label Save_time_label;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox_find_word;
        private System.Windows.Forms.Label Find_word_label;
        private System.Windows.Forms.Button Search_word_button;
        private System.Windows.Forms.ListBox listBox_finded_word;
        private System.Windows.Forms.Button Close_form_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_searching_time;
    }
}

