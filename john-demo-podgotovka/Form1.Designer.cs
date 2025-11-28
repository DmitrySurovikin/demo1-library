namespace john_demo_podgotovka
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.booksDataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.addBookButton = new System.Windows.Forms.Button();
            this.yearAddNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.authorAddComboBox = new System.Windows.Forms.ComboBox();
            this.titleAddTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.deleteBookButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.findByAuthorButton = new System.Windows.Forms.Button();
            this.findByNameButton = new System.Windows.Forms.Button();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.booksDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.yearAddNumericUpDown)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // booksDataGridView
            // 
            this.booksDataGridView.AllowUserToAddRows = false;
            this.booksDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.booksDataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.booksDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.booksDataGridView.Location = new System.Drawing.Point(12, 50);
            this.booksDataGridView.MultiSelect = false;
            this.booksDataGridView.Name = "booksDataGridView";
            this.booksDataGridView.ReadOnly = true;
            this.booksDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.booksDataGridView.Size = new System.Drawing.Size(776, 157);
            this.booksDataGridView.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Honeydew;
            this.groupBox1.Controls.Add(this.addBookButton);
            this.groupBox1.Controls.Add(this.yearAddNumericUpDown);
            this.groupBox1.Controls.Add(this.authorAddComboBox);
            this.groupBox1.Controls.Add(this.titleAddTextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 213);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(372, 225);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Добавить книгу";
            // 
            // addBookButton
            // 
            this.addBookButton.BackColor = System.Drawing.Color.GreenYellow;
            this.addBookButton.Location = new System.Drawing.Point(222, 191);
            this.addBookButton.Name = "addBookButton";
            this.addBookButton.Size = new System.Drawing.Size(144, 28);
            this.addBookButton.TabIndex = 4;
            this.addBookButton.Text = "Добавить книгу/автора";
            this.addBookButton.UseVisualStyleBackColor = false;
            this.addBookButton.Click += new System.EventHandler(this.addBookButton_Click);
            // 
            // yearAddNumericUpDown
            // 
            this.yearAddNumericUpDown.Location = new System.Drawing.Point(181, 118);
            this.yearAddNumericUpDown.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.yearAddNumericUpDown.Name = "yearAddNumericUpDown";
            this.yearAddNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.yearAddNumericUpDown.TabIndex = 3;
            // 
            // authorAddComboBox
            // 
            this.authorAddComboBox.FormattingEnabled = true;
            this.authorAddComboBox.Location = new System.Drawing.Point(181, 90);
            this.authorAddComboBox.Name = "authorAddComboBox";
            this.authorAddComboBox.Size = new System.Drawing.Size(120, 21);
            this.authorAddComboBox.TabIndex = 2;
            // 
            // titleAddTextBox
            // 
            this.titleAddTextBox.Location = new System.Drawing.Point(181, 62);
            this.titleAddTextBox.Name = "titleAddTextBox";
            this.titleAddTextBox.Size = new System.Drawing.Size(120, 20);
            this.titleAddTextBox.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Год:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Автор:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Honeydew;
            this.groupBox2.Controls.Add(this.deleteBookButton);
            this.groupBox2.Controls.Add(this.resetButton);
            this.groupBox2.Controls.Add(this.findByAuthorButton);
            this.groupBox2.Controls.Add(this.findByNameButton);
            this.groupBox2.Controls.Add(this.searchTextBox);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(390, 213);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(398, 225);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Поиск и действия";
            // 
            // deleteBookButton
            // 
            this.deleteBookButton.BackColor = System.Drawing.Color.RosyBrown;
            this.deleteBookButton.Location = new System.Drawing.Point(289, 191);
            this.deleteBookButton.Name = "deleteBookButton";
            this.deleteBookButton.Size = new System.Drawing.Size(103, 28);
            this.deleteBookButton.TabIndex = 5;
            this.deleteBookButton.Text = "Удалить книгу";
            this.deleteBookButton.UseVisualStyleBackColor = false;
            this.deleteBookButton.Click += new System.EventHandler(this.deleteBookButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.BackColor = System.Drawing.Color.PaleTurquoise;
            this.resetButton.Location = new System.Drawing.Point(308, 118);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(68, 21);
            this.resetButton.TabIndex = 4;
            this.resetButton.Text = "Сбросить";
            this.resetButton.UseVisualStyleBackColor = false;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // findByAuthorButton
            // 
            this.findByAuthorButton.BackColor = System.Drawing.Color.PaleTurquoise;
            this.findByAuthorButton.Location = new System.Drawing.Point(175, 115);
            this.findByAuthorButton.Name = "findByAuthorButton";
            this.findByAuthorButton.Size = new System.Drawing.Size(110, 23);
            this.findByAuthorButton.TabIndex = 3;
            this.findByAuthorButton.Text = "Искать по автору";
            this.findByAuthorButton.UseVisualStyleBackColor = false;
            this.findByAuthorButton.Click += new System.EventHandler(this.findByAuthorButton_Click);
            // 
            // findByNameButton
            // 
            this.findByNameButton.BackColor = System.Drawing.Color.PaleTurquoise;
            this.findByNameButton.Location = new System.Drawing.Point(44, 115);
            this.findByNameButton.Name = "findByNameButton";
            this.findByNameButton.Size = new System.Drawing.Size(125, 23);
            this.findByNameButton.TabIndex = 2;
            this.findByNameButton.Text = "Искать по названию";
            this.findByNameButton.UseVisualStyleBackColor = false;
            this.findByNameButton.Click += new System.EventHandler(this.findByNameButton_Click);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(114, 62);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(185, 20);
            this.searchTextBox.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Поиск:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::john_demo_podgotovka.Properties.Resources._1486503771_book_books_education_library_reading_open_book_study_81275;
            this.pictureBox1.Location = new System.Drawing.Point(12, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 43);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.booksDataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "БИБЛИОТЕКА";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.booksDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.yearAddNumericUpDown)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView booksDataGridView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addBookButton;
        private System.Windows.Forms.NumericUpDown yearAddNumericUpDown;
        private System.Windows.Forms.ComboBox authorAddComboBox;
        private System.Windows.Forms.TextBox titleAddTextBox;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button deleteBookButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button findByAuthorButton;
        private System.Windows.Forms.Button findByNameButton;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

