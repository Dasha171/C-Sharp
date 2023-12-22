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
using System.Windows.Shapes;

namespace BooksWpf
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
            InitializeData();
        }
        private void InitializeData()
        {
            DatabaseHelper.InitializeDatabase();

            // Пример:
            departmentComboBox.ItemsSource = new List<string> { "Все отделы", "Ужасы", "Художественный", "Научный" };
            sectionComboBox.ItemsSource = new List<string> { "Все секции", "Русская литература", "Советская литература", "Художественная история" };
            publisherComboBox.ItemsSource = new List<string> { "Все издательства", "Питер", "Зарубеж" };
            authorComboBox.ItemsSource = new List<string> { "Все авторы", "Лев Толстой", "Леон Маркс", "Иван А.К.", "Михаил Б.", "Пушкин" };
            LoadBooks();
        }

        private void LoadBooks()
        {
            var departmentId = GetSelectedId(departmentComboBox);
            var sectionId = GetSelectedId(sectionComboBox);
            var publisherId = GetSelectedId(publisherComboBox);
            var authorId = GetSelectedId(authorComboBox);

            var books = DatabaseHelper.GetBooks(departmentId, sectionId, publisherId, authorId);

            dataGrid.ItemsSource = books;
        }

        private int GetSelectedId(ComboBox comboBox)
        {
            if (comboBox.SelectedIndex <= 0)
                return -1;

            return comboBox.SelectedIndex; // В этом примере предполагается, что индексы совпадают с идентификаторами.
        }

        private void FilterButton_Click(object sender, RoutedEventArgs e)
        {
            var selectedDepartmentId = GetSelectedId(departmentComboBox);
            var selectedSectionId = GetSelectedId(sectionComboBox);
            var selectedPublisherId = GetSelectedId(publisherComboBox);
            var selectedAuthorId = GetSelectedId(authorComboBox);

            var books = DatabaseHelper.GetBooks(selectedDepartmentId, selectedSectionId, selectedPublisherId, selectedAuthorId);

            dataGrid.ItemsSource = books;
        }
    }
}

