using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.Sqlite;
using System.Data.SQLite;

namespace BooksWpf
{
    public class DatabaseHelper
    {
        private const string ConnectionString = "Data Source=MyDatabase.db;Version=3;";

        public static void InitializeDatabase()
        {
            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();

                // Создание таблиц и других структур базы данных
                using (var command = new SQLiteCommand(
                    "CREATE TABLE IF NOT EXISTS Books (Id INTEGER PRIMARY KEY AUTOINCREMENT, Title TEXT, DepartmentId INT, SectionId INT, PublisherId INT, AuthorId INT);",
                    connection))
                {
                    command.ExecuteNonQuery();
                }

                // Добавление тестовых данных, например:
                using (var command = new SQLiteCommand(
                    "INSERT INTO Books (Title, DepartmentId, SectionId, PublisherId, AuthorId) VALUES ('Смерть', 2, 2, 1, 1);",
                    connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }

        public static List<Book> GetBooks(int departmentId, int sectionId, int publisherId, int authorId)
        {
            var books = new List<Book>();

            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();

                var query = "SELECT * FROM Books WHERE (@DepartmentId = -1 OR DepartmentId = @DepartmentId)" +
                            " AND (@SectionId = -1 OR SectionId = @SectionId)" +
                            " AND (@PublisherId = -1 OR PublisherId = @PublisherId)" +
                            " AND (@AuthorId = -1 OR AuthorId = @AuthorId);";

                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@DepartmentId", departmentId);
                    command.Parameters.AddWithValue("@SectionId", sectionId);
                    command.Parameters.AddWithValue("@PublisherId", publisherId);
                    command.Parameters.AddWithValue("@AuthorId", authorId);

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var book = new Book
                            {
                                Id = reader.GetInt32(0),
                                Title = reader.GetString(1),
                                DepartmentId = reader.GetInt32(2),
                                SectionId = reader.GetInt32(3),
                                PublisherId = reader.GetInt32(4),
                                AuthorId = reader.GetInt32(5)
                            };

                            books.Add(book);
                        }
                    }
                }
            }

            return books;
        }
    }
}
