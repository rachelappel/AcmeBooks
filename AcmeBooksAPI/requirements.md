## Bookstore 
This app helps to locate and sell books in a small local bookstore.

## Functional requirements

Book locator:

This app locates books in a bookstore.
Books are stored in the bookstore in sections.
The sections are labelled by their genre.
Each genre (section) is partitioned into subsections labelled as follows: A-E, F-J, K-O, P-T, U-Z
The subsection that contains the last initial of the author is where the book goes.
The format of the labels are {Genre} {Subsection}
For example: "To Kill a Mockingbird" by Harper Lee goes in Fiction K-O.

Customer behaviors:

In-store customers may buy multiple books, but they are generally several different single titles.
In-store customers are about 75% of our sales.
Sometimes, we run sales on individual books.
Schools, universities, businesses, and book clubs also purchase books and make the other 25%.
We offer bulk pricing. Tax applies to these customers: individuals, businesses, and book clubs. Schools are tax-exempt.

Pricing:

The price calculator uses the following pricing:
0-10 books, no discount.
11-25 books get a 10% discount
25-50 books get a 15% discount
50+ books get a 20% discount

## Data & Non functional requirements

* Genre - Represents a book's genre. 
  * Properties: Id, title, description, books in genre.
* Book - Represents a book in the bookstore. 
  * Properties: Id, title, ISBN, author, publish date, language. 
* Author - Represents the author of the book.
  * Properties: Id, first name, last name, biography, birthdate, email.
* Language - Represents the language a book is written in.
  * Should be an Enum, filled with the following: English, German, Chinese, Spanish, Japanese, Hindi, Vietnamese, Swahili, Polish, Russian.

Relationships:
* 1 to many, Genre-Books. 1 genre has many books. 
* 1 to many, Author-Books. 1 author has many books.
* Add necessary EF Core properties for relationships into the classes.

Rules:
* Create file names for each class that match the name of the class.
* Add EF Core Validation attributes as needed. Use a RegEx validator for email.
* Include SQLite specific attributes where needed.
* Include AcmeBooks.Models namespace

## Prompts

Generate a DBContext using the SqlLite provider and override the ctor. Include the Author, Book, and Genre classes from the Models folder.

Override `OnModelCreating` method and create seed data for 5 classic literature authors, 5 books, and 10 genres. Use real authors, books, and genres.

Create the stub for a GET action method called LocateBook that accepts a string.
The string is the book title.

Query the book by its whole or part of its title. Note the last initial of the author.
Also note the genre of the book. Call the BookLocator.Locate service.
Pass in the genre and initial and use the return value to write the message "The book is located in {return value}"

## Code

protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    => optionsBuilder.UseSqlite(@"Data Source=AcmeBooks.sqlite");

----

var book = await _context.Books
.Include(b => b.Author)
.Include(b => b.Genre)
.FirstOrDefaultAsync(b => b.Title.Contains(title));

if (book == null)
{
    return NotFound();
}

string authorInitial = book.Author.LastName.Substring(0, 1);
string genreTitle = book.Genre.Title;

string location = BookLocator.LocateBook(book.Genre.Title, authorInitial);

return Ok(new { Message = $"The book is located in {location}" });