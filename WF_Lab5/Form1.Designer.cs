namespace Lab5
{
	partial class Form1
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
			this.button1 = new System.Windows.Forms.Button();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.Save_time_label = new System.Windows.Forms.Label();
			this.Download_time_label = new System.Windows.Forms.Label();
			this.Find_word_label = new System.Windows.Forms.Label();
			this.textBox_find_word = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.buttonExact = new System.Windows.Forms.Button();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.labelMaxNechet = new System.Windows.Forms.Label();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.buttonApprox = new System.Windows.Forms.Button();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.button2 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(16, 15);
			this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(216, 73);
			this.button1.TabIndex = 0;
			this.button1.Text = "Чтение файла";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(755, 57);
			this.textBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(288, 22);
			this.textBox2.TabIndex = 8;
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(755, 11);
			this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(288, 22);
			this.textBox1.TabIndex = 7;
			// 
			// Save_time_label
			// 
			this.Save_time_label.AutoSize = true;
			this.Save_time_label.Location = new System.Drawing.Point(536, 60);
			this.Save_time_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Save_time_label.Name = "Save_time_label";
			this.Save_time_label.Size = new System.Drawing.Size(182, 17);
			this.Save_time_label.TabIndex = 6;
			this.Save_time_label.Text = "Время сохранения файла:";
			// 
			// Download_time_label
			// 
			this.Download_time_label.AutoSize = true;
			this.Download_time_label.Location = new System.Drawing.Point(536, 15);
			this.Download_time_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Download_time_label.Name = "Download_time_label";
			this.Download_time_label.Size = new System.Drawing.Size(162, 17);
			this.Download_time_label.TabIndex = 5;
			this.Download_time_label.Text = "Время загрузки файла:";
			this.Download_time_label.Click += new System.EventHandler(this.Download_time_label_Click);
			// 
			// Find_word_label
			// 
			this.Find_word_label.AutoSize = true;
			this.Find_word_label.Location = new System.Drawing.Point(20, 140);
			this.Find_word_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Find_word_label.Name = "Find_word_label";
			this.Find_word_label.Size = new System.Drawing.Size(208, 17);
			this.Find_word_label.TabIndex = 10;
			this.Find_word_label.Text = "Поле ввода слова для поиска:";
			// 
			// textBox_find_word
			// 
			this.textBox_find_word.Location = new System.Drawing.Point(20, 164);
			this.textBox_find_word.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.textBox_find_word.Name = "textBox_find_word";
			this.textBox_find_word.Size = new System.Drawing.Size(211, 22);
			this.textBox_find_word.TabIndex = 9;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(536, 166);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(159, 17);
			this.label3.TabIndex = 12;
			this.label3.Text = "Время четкого поиска:";
			// 
			// buttonExact
			// 
			this.buttonExact.Location = new System.Drawing.Point(285, 114);
			this.buttonExact.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.buttonExact.Name = "buttonExact";
			this.buttonExact.Size = new System.Drawing.Size(231, 74);
			this.buttonExact.TabIndex = 11;
			this.buttonExact.Text = "Четкий поиск";
			this.buttonExact.UseVisualStyleBackColor = true;
			this.buttonExact.Click += new System.EventHandler(this.buttonExact_Click);
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(755, 162);
			this.textBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(288, 22);
			this.textBox3.TabIndex = 13;
			// 
			// labelMaxNechet
			// 
			this.labelMaxNechet.AutoSize = true;
			this.labelMaxNechet.Location = new System.Drawing.Point(20, 220);
			this.labelMaxNechet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.labelMaxNechet.Name = "labelMaxNechet";
			this.labelMaxNechet.Size = new System.Drawing.Size(199, 34);
			this.labelMaxNechet.TabIndex = 14;
			this.labelMaxNechet.Text = "Максимальное расстояние\r\nдля нечеткого поиска слова:\r\n";
			this.labelMaxNechet.Click += new System.EventHandler(this.label1_Click);
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(16, 256);
			this.textBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(215, 22);
			this.textBox4.TabIndex = 15;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(16, 415);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(175, 17);
			this.label4.TabIndex = 17;
			this.label4.Text = "Время нечеткого поиска:";
			// 
			// buttonApprox
			// 
			this.buttonApprox.Location = new System.Drawing.Point(16, 305);
			this.buttonApprox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.buttonApprox.Name = "buttonApprox";
			this.buttonApprox.Size = new System.Drawing.Size(212, 78);
			this.buttonApprox.TabIndex = 16;
			this.buttonApprox.Text = "Нечеткий поиск";
			this.buttonApprox.UseVisualStyleBackColor = true;
			this.buttonApprox.Click += new System.EventHandler(this.buttonApprox_Click);
			// 
			// textBox5
			// 
			this.textBox5.Location = new System.Drawing.Point(16, 434);
			this.textBox5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.textBox5.Name = "textBox5";
			this.textBox5.Size = new System.Drawing.Size(215, 22);
			this.textBox5.TabIndex = 18;
			// 
			// listBox1
			// 
			this.listBox1.FormattingEnabled = true;
			this.listBox1.ItemHeight = 16;
			this.listBox1.Location = new System.Drawing.Point(315, 204);
			this.listBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(728, 276);
			this.listBox1.TabIndex = 12;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(867, 489);
			this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(184, 50);
			this.button2.TabIndex = 12;
			this.button2.Text = "Закрыть форму";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1069, 554);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.listBox1);
			this.Controls.Add(this.textBox5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.buttonApprox);
			this.Controls.Add(this.textBox4);
			this.Controls.Add(this.labelMaxNechet);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.buttonExact);
			this.Controls.Add(this.Find_word_label);
			this.Controls.Add(this.textBox_find_word);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.Save_time_label);
			this.Controls.Add(this.Download_time_label);
			this.Controls.Add(this.button1);
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label Save_time_label;
		private System.Windows.Forms.Label Download_time_label;
		private System.Windows.Forms.Label Find_word_label;
		private System.Windows.Forms.TextBox textBox_find_word;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button buttonExact;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.Label labelMaxNechet;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button buttonApprox;
		private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.Button button2;
	}
}

