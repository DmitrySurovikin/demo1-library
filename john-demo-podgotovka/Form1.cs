using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace john_demo_podgotovka
{
    public partial class Form1 : Form
    {
        
        private readonly BookManager _bookManager;

        public Form1()
        {
            InitializeComponent();
            _bookManager = new BookManager();
            RefreshGrid(_bookManager.FindBookByName(searchTextBox.Text));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RefreshGrid();
            LoadAuthors();
        }


        private void addBookButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(titleAddTextBox.Text) || string.IsNullOrWhiteSpace(authorAddComboBox.Text))
            {
                MessageBox.Show("Название и автор не могут быть пустыми.", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Оборачиваем в try-catch для отладки возможных ошибок с БД
            try
            {
                _bookManager.AddBook(titleAddTextBox.Text, (int)yearAddNumericUpDown.Value, authorAddComboBox.Text);

                MessageBox.Show("Книга успешно добавлена!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

                RefreshGrid();
                LoadAuthors();

                titleAddTextBox.Clear();
                authorAddComboBox.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка при добавлении: {ex.Message}", "Ошибка базы данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void deleteBookButton_Click(object sender, EventArgs e)
        {
            if (booksDataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Пожалуйста, выберите книгу для удаления.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var selectedRow = booksDataGridView.SelectedRows[0];
            var bookId = (Guid)selectedRow.Cells["Id"].Value;
            var bookTitle = selectedRow.Cells["Title"].Value.ToString();

            var result = MessageBox.Show($"Удалить книгу '{bookTitle}'?", "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                _bookManager.RemoveBook(bookId);
                RefreshGrid();
                LoadAuthors();
            }
        }

        private void findByNameButton_Click(object sender, EventArgs e)
        {
            RefreshGrid(_bookManager.FindBookByName(searchTextBox.Text));
        }

        private void findByAuthorButton_Click(object sender, EventArgs e)
        {
            RefreshGrid(_bookManager.FindBookByAuthor(searchTextBox.Text));
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            searchTextBox.Clear();
            RefreshGrid();
        }


        private void RefreshGrid(List<Book> books = null)
        {
            booksDataGridView.DataSource = books ?? _bookManager.GetAllBooks();

            if (booksDataGridView.Columns.Count > 0)
            {
                booksDataGridView.Columns["Title"].HeaderText = "Название";
                booksDataGridView.Columns["AuthorName"].HeaderText = "Автор";
                booksDataGridView.Columns["PublicationYear"].HeaderText = "Год";

                booksDataGridView.Columns["Id"].Visible = false;
                booksDataGridView.Columns["AuthorId"].Visible = false;
            }
        }

        private void LoadAuthors()
        {
            authorAddComboBox.DataSource = _bookManager.GetAllAuthors();
            authorAddComboBox.DisplayMember = "Name";
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
