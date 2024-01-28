public class Word{
    private string _wordText;
    private string _originalText;
    private bool _hidden;
    public Word(string WordText, bool Hidden)
    {
        _hidden = Hidden;
        _originalText = WordText;
        _wordText = WordText;
    }
    public void HideWord()
    {
        _wordText = new string('_', _wordText.Length);
        _hidden = true;

    }
    public void ShowWord()
    {
        _wordText = _originalText;
        _hidden = false;
    }
    public bool DetermineIfHidden()
    {
        return _hidden;
    }
    public string GetWordText()
    {
        return _wordText;
    }
}