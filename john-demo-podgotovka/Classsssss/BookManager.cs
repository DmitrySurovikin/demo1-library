using john_demo_podgotovka;
using Npgsql;
using System;
using System.Collections.Generic;

public class BookManager
{
    private const string ConnectionString = "Host=localhost;Username=postgres;Password=1234;Database=books";

    #region Публичные методы из ТЗ

    public void AddBook(string title, int year, string authorName)
    {
        using (var connection = new NpgsqlConnection(ConnectionString))
        {
            connection.Open();
            Guid authorId = GetOrAddAuthor(authorName, connection);

            var sql = "INSERT INTO Books (Id, Title, PublicationYear, AuthorId) VALUES (@Id, @Title, @Year, @AuthorId)";
            using (var cmd = new NpgsqlCommand(sql, connection))
            {
                cmd.Parameters.AddWithValue("Id", Guid.NewGuid());
                cmd.Parameters.AddWithValue("Title", title);
                cmd.Parameters.AddWithValue("Year", year);
                cmd.Parameters.AddWithValue("AuthorId", authorId);
                cmd.ExecuteNonQuery();
            }
        }
    }


    public void RemoveBook(Guid bookId)
    {
        using (var connection = new NpgsqlConnection(ConnectionString))
        {
            connection.Open();
            var sql = "DELETE FROM Books WHERE Id = @Id";
            using (var cmd = new NpgsqlCommand(sql, connection))
            {
                cmd.Parameters.AddWithValue("Id", bookId);
                cmd.ExecuteNonQuery();
            }
        }
    }


    public List<Book> FindBookByName(string title)
    {
        return GetBooksWithCondition("WHERE b.Title ILIKE @SearchQuery", $"%{title}%");
    }


    public List<Book> FindBookByAuthor(string authorName)
    {
        return GetBooksWithCondition("WHERE a.Name ILIKE @SearchQuery", $"%{authorName}%");
    }


    public List<Book> GetAllBooks()
    {
        return GetBooksWithCondition("");
    }

    #endregion

    #region Вспомогательные методы (для UI и внутренней логики)


    public List<Author> GetAllAuthors()
    {
        var authors = new List<Author>();
        using (var connection = new NpgsqlConnection(ConnectionString))
        {
            connection.Open();
            var sql = "SELECT Id, Name FROM Authors ORDER BY Name";
            using (var cmd = new NpgsqlCommand(sql, connection))
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    authors.Add(new Author { Id = reader.GetGuid(0), Name = reader.GetString(1) });
                }
            }
        }
        return authors;
    }

    private Guid GetOrAddAuthor(string authorName, NpgsqlConnection connection)
    {
        var sqlFind = "SELECT Id FROM Authors WHERE Name ILIKE @Name LIMIT 1";
        using (var cmdFind = new NpgsqlCommand(sqlFind, connection))
        {
            cmdFind.Parameters.AddWithValue("Name", authorName.Trim());
            var result = cmdFind.ExecuteScalar();
            if (result != null) return (Guid)result;
        }

        var newAuthorId = Guid.NewGuid();
        var sqlInsert = "INSERT INTO Authors (Id, Name) VALUES (@Id, @Name)";
        using (var cmdInsert = new NpgsqlCommand(sqlInsert, connection))
        {
            cmdInsert.Parameters.AddWithValue("Id", newAuthorId);
            cmdInsert.Parameters.AddWithValue("Name", authorName.Trim());
            cmdInsert.ExecuteNonQuery();
        }
        return newAuthorId;
    }

    private List<Book> GetBooksWithCondition(string whereClause, string searchQuery = "")
    {
        var books = new List<Book>();
        using (var connection = new NpgsqlConnection(ConnectionString))
        {
            connection.Open();
            var sql = $@"SELECT b.Id, b.Title, a.Name, b.PublicationYear, b.AuthorId 
                         FROM Books b LEFT JOIN Authors a ON b.AuthorId = a.Id 
                         {whereClause} 
                         ORDER BY b.Title";

            using (var cmd = new NpgsqlCommand(sql, connection))
            {
                if (!string.IsNullOrEmpty(whereClause))
                {
                    cmd.Parameters.AddWithValue("SearchQuery", searchQuery);
                }
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        books.Add(new Book
                        {
                            Id = reader.GetGuid(0),
                            Title = reader.GetString(1),
                            AuthorName = reader.IsDBNull(2) ? "N/A" : reader.GetString(2),
                            PublicationYear = reader.GetInt32(3),
                            AuthorId = reader.GetGuid(4)
                        });
                    }
                }
            }
        }
        return books;
    }

    #endregion
}