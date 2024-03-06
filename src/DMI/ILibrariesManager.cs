namespace DMI
{
	public interface ILibrariesManager
	{
		IEnumerable<BookId> ListBooksIds(LibraryId libraryId);

	}
}
