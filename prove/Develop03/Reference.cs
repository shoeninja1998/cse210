public class Reference{
    private string _book;
    private int _chapterNumber;
    private int _verseNumber;
    private int _endVerseNumber;
    public Reference(string Book, int ChapterNumber, int VerseNumber)
    {
        _book = Book;
        _chapterNumber = ChapterNumber;
        _verseNumber = VerseNumber;
    }
    public Reference(string Book, int ChapterNumber, int VerseNumber, int EndVerseNumber)
    {
        _book = Book;
        _chapterNumber = ChapterNumber;
        _verseNumber = VerseNumber;
        _endVerseNumber = EndVerseNumber;
    }
    public string GetReferenceText()
    {
        return $"{_book} {_chapterNumber}:{_verseNumber}";
    }
    public string GetMultipleReferenceText()
    {
        return $"{_book} {_chapterNumber}:{_verseNumber}-{_endVerseNumber}";
    }
    
}