namespace DMI
{
	[StronglyTypedId(
		backingType: StronglyTypedIdBackingType.Long,
		generateJsonConverter: false)]
	public partial struct BookId { }


	[StronglyTypedId(
		backingType: StronglyTypedIdBackingType.String,
		generateJsonConverter: false)]
	public partial struct LibraryId { }
}
