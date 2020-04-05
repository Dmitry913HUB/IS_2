namespace IS_2
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.обновитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.labelINSERT = new System.Windows.Forms.Label();
            this.buttonINSERT = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox4INSERT = new System.Windows.Forms.TextBox();
            this.textBox3INSERT = new System.Windows.Forms.TextBox();
            this.textBox2INSERT = new System.Windows.Forms.TextBox();
            this.textBox1INSERT = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.labelUPDATE = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonUPDATE = new System.Windows.Forms.Button();
            this.textBox1UPDATE = new System.Windows.Forms.TextBox();
            this.textBox5UPDATE = new System.Windows.Forms.TextBox();
            this.textBox4UPDATE = new System.Windows.Forms.TextBox();
            this.textBox3UPDATE = new System.Windows.Forms.TextBox();
            this.textBox2UPDATE = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.labelDELETE = new System.Windows.Forms.Label();
            this.button2DELETE = new System.Windows.Forms.Button();
            this.button1DELETE = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox2DELETE = new System.Windows.Forms.TextBox();
            this.textBox1DELETE = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(467, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.обновитьToolStripMenuItem});
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.справкаToolStripMenuItem.Text = "Инструменты";
            // 
            // обновитьToolStripMenuItem
            // 
            this.обновитьToolStripMenuItem.Name = "обновитьToolStripMenuItem";
            this.обновитьToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.обновитьToolStripMenuItem.Text = "Обновить";
            this.обновитьToolStripMenuItem.Click += new System.EventHandler(this.обновитьToolStripMenuItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(467, 208);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.textBoxSearch);
            this.tabPage1.Controls.Add(this.buttonSearch);
            this.tabPage1.Controls.Add(this.listBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(459, 182);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "SELECT";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(3, 3);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(453, 147);
            this.listBox1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.labelINSERT);
            this.tabPage2.Controls.Add(this.buttonINSERT);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.textBox4INSERT);
            this.tabPage2.Controls.Add(this.textBox3INSERT);
            this.tabPage2.Controls.Add(this.textBox2INSERT);
            this.tabPage2.Controls.Add(this.textBox1INSERT);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(459, 182);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "INSERT";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // labelINSERT
            // 
            this.labelINSERT.AutoSize = true;
            this.labelINSERT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelINSERT.ForeColor = System.Drawing.Color.Red;
            this.labelINSERT.Location = new System.Drawing.Point(5, 13);
            this.labelINSERT.Name = "labelINSERT";
            this.labelINSERT.Size = new System.Drawing.Size(52, 16);
            this.labelINSERT.TabIndex = 9;
            this.labelINSERT.Text = "label12";
            this.labelINSERT.Visible = false;
            // 
            // buttonINSERT
            // 
            this.buttonINSERT.Location = new System.Drawing.Point(68, 146);
            this.buttonINSERT.Name = "buttonINSERT";
            this.buttonINSERT.Size = new System.Drawing.Size(115, 23);
            this.buttonINSERT.TabIndex = 8;
            this.buttonINSERT.Text = "Добавить";
            this.buttonINSERT.UseVisualStyleBackColor = true;
            this.buttonINSERT.Click += new System.EventHandler(this.buttonINSERT_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Группа";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Отчество";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Имя";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Фамилия";
            // 
            // textBox4INSERT
            // 
            this.textBox4INSERT.Location = new System.Drawing.Point(68, 114);
            this.textBox4INSERT.Name = "textBox4INSERT";
            this.textBox4INSERT.Size = new System.Drawing.Size(115, 20);
            this.textBox4INSERT.TabIndex = 3;
            // 
            // textBox3INSERT
            // 
            this.textBox3INSERT.Location = new System.Drawing.Point(68, 88);
            this.textBox3INSERT.Name = "textBox3INSERT";
            this.textBox3INSERT.Size = new System.Drawing.Size(115, 20);
            this.textBox3INSERT.TabIndex = 2;
            // 
            // textBox2INSERT
            // 
            this.textBox2INSERT.Location = new System.Drawing.Point(68, 62);
            this.textBox2INSERT.Name = "textBox2INSERT";
            this.textBox2INSERT.Size = new System.Drawing.Size(115, 20);
            this.textBox2INSERT.TabIndex = 1;
            // 
            // textBox1INSERT
            // 
            this.textBox1INSERT.Location = new System.Drawing.Point(68, 36);
            this.textBox1INSERT.Name = "textBox1INSERT";
            this.textBox1INSERT.Size = new System.Drawing.Size(115, 20);
            this.textBox1INSERT.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.labelUPDATE);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.buttonUPDATE);
            this.tabPage3.Controls.Add(this.textBox1UPDATE);
            this.tabPage3.Controls.Add(this.textBox5UPDATE);
            this.tabPage3.Controls.Add(this.textBox4UPDATE);
            this.tabPage3.Controls.Add(this.textBox3UPDATE);
            this.tabPage3.Controls.Add(this.textBox2UPDATE);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(459, 182);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "UPDATE";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // labelUPDATE
            // 
            this.labelUPDATE.AutoSize = true;
            this.labelUPDATE.ForeColor = System.Drawing.Color.Red;
            this.labelUPDATE.Location = new System.Drawing.Point(10, 8);
            this.labelUPDATE.Name = "labelUPDATE";
            this.labelUPDATE.Size = new System.Drawing.Size(25, 13);
            this.labelUPDATE.TabIndex = 11;
            this.labelUPDATE.Text = "111";
            this.labelUPDATE.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 136);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Группа";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 110);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Отчество";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Имя";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Фамилия";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "ID";
            // 
            // buttonUPDATE
            // 
            this.buttonUPDATE.Location = new System.Drawing.Point(74, 156);
            this.buttonUPDATE.Name = "buttonUPDATE";
            this.buttonUPDATE.Size = new System.Drawing.Size(100, 23);
            this.buttonUPDATE.TabIndex = 5;
            this.buttonUPDATE.Text = "Изменить";
            this.buttonUPDATE.UseVisualStyleBackColor = true;
            this.buttonUPDATE.Click += new System.EventHandler(this.buttonUPDATE_Click);
            // 
            // textBox1UPDATE
            // 
            this.textBox1UPDATE.Location = new System.Drawing.Point(74, 25);
            this.textBox1UPDATE.Name = "textBox1UPDATE";
            this.textBox1UPDATE.Size = new System.Drawing.Size(100, 20);
            this.textBox1UPDATE.TabIndex = 4;
            // 
            // textBox5UPDATE
            // 
            this.textBox5UPDATE.Location = new System.Drawing.Point(74, 129);
            this.textBox5UPDATE.Name = "textBox5UPDATE";
            this.textBox5UPDATE.Size = new System.Drawing.Size(100, 20);
            this.textBox5UPDATE.TabIndex = 3;
            // 
            // textBox4UPDATE
            // 
            this.textBox4UPDATE.Location = new System.Drawing.Point(74, 103);
            this.textBox4UPDATE.Name = "textBox4UPDATE";
            this.textBox4UPDATE.Size = new System.Drawing.Size(100, 20);
            this.textBox4UPDATE.TabIndex = 2;
            // 
            // textBox3UPDATE
            // 
            this.textBox3UPDATE.Location = new System.Drawing.Point(74, 77);
            this.textBox3UPDATE.Name = "textBox3UPDATE";
            this.textBox3UPDATE.Size = new System.Drawing.Size(100, 20);
            this.textBox3UPDATE.TabIndex = 1;
            // 
            // textBox2UPDATE
            // 
            this.textBox2UPDATE.Location = new System.Drawing.Point(74, 51);
            this.textBox2UPDATE.Name = "textBox2UPDATE";
            this.textBox2UPDATE.Size = new System.Drawing.Size(100, 20);
            this.textBox2UPDATE.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.labelDELETE);
            this.tabPage4.Controls.Add(this.button2DELETE);
            this.tabPage4.Controls.Add(this.button1DELETE);
            this.tabPage4.Controls.Add(this.label11);
            this.tabPage4.Controls.Add(this.textBox2DELETE);
            this.tabPage4.Controls.Add(this.textBox1DELETE);
            this.tabPage4.Controls.Add(this.label10);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(459, 182);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "DELETE";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // labelDELETE
            // 
            this.labelDELETE.AutoSize = true;
            this.labelDELETE.ForeColor = System.Drawing.Color.Red;
            this.labelDELETE.Location = new System.Drawing.Point(3, 18);
            this.labelDELETE.Name = "labelDELETE";
            this.labelDELETE.Size = new System.Drawing.Size(41, 13);
            this.labelDELETE.TabIndex = 6;
            this.labelDELETE.Text = "label12";
            this.labelDELETE.Visible = false;
            // 
            // button2DELETE
            // 
            this.button2DELETE.Location = new System.Drawing.Point(189, 69);
            this.button2DELETE.Name = "button2DELETE";
            this.button2DELETE.Size = new System.Drawing.Size(75, 23);
            this.button2DELETE.TabIndex = 5;
            this.button2DELETE.Text = "Удалить";
            this.button2DELETE.UseVisualStyleBackColor = true;
            // 
            // button1DELETE
            // 
            this.button1DELETE.Location = new System.Drawing.Point(189, 38);
            this.button1DELETE.Name = "button1DELETE";
            this.button1DELETE.Size = new System.Drawing.Size(75, 23);
            this.button1DELETE.TabIndex = 4;
            this.button1DELETE.Text = "Удалить";
            this.button1DELETE.UseVisualStyleBackColor = true;
            this.button1DELETE.Click += new System.EventHandler(this.button1DELETE_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 76);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 13);
            this.label11.TabIndex = 3;
            this.label11.Text = "Название";
            // 
            // textBox2DELETE
            // 
            this.textBox2DELETE.Location = new System.Drawing.Point(68, 69);
            this.textBox2DELETE.Name = "textBox2DELETE";
            this.textBox2DELETE.Size = new System.Drawing.Size(100, 20);
            this.textBox2DELETE.TabIndex = 2;
            // 
            // textBox1DELETE
            // 
            this.textBox1DELETE.Location = new System.Drawing.Point(68, 42);
            this.textBox1DELETE.Name = "textBox1DELETE";
            this.textBox1DELETE.Size = new System.Drawing.Size(100, 20);
            this.textBox1DELETE.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 49);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(18, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "ID";
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(364, 154);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(87, 23);
            this.buttonSearch.TabIndex = 1;
            this.buttonSearch.Text = "Поиск";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(3, 155);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(355, 20);
            this.textBoxSearch.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 232);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox textBox1INSERT;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button buttonINSERT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox4INSERT;
        private System.Windows.Forms.TextBox textBox3INSERT;
        private System.Windows.Forms.TextBox textBox2INSERT;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonUPDATE;
        private System.Windows.Forms.TextBox textBox1UPDATE;
        private System.Windows.Forms.TextBox textBox5UPDATE;
        private System.Windows.Forms.TextBox textBox4UPDATE;
        private System.Windows.Forms.TextBox textBox3UPDATE;
        private System.Windows.Forms.TextBox textBox2UPDATE;
        private System.Windows.Forms.Button button2DELETE;
        private System.Windows.Forms.Button button1DELETE;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox2DELETE;
        private System.Windows.Forms.TextBox textBox1DELETE;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label labelINSERT;
        private System.Windows.Forms.ToolStripMenuItem обновитьToolStripMenuItem;
        private System.Windows.Forms.Label labelUPDATE;
        private System.Windows.Forms.Label labelDELETE;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button buttonSearch;
    }
}

