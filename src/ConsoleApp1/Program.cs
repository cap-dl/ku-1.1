using DMI;

var bookId = new BookId(23);
var libId = new LibraryId("GreatLibrary");
Console.WriteLine($"Book {bookId} is in a library, named {libId}");

ILibrariesManager mgr;
////mgr.ListBooksIds()