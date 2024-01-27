public class Scripture{
    private List<Word> _words;
    private Reference _reference;
    List<int> chosenIndexList = new();
    public Scripture(List<Word> Words, Reference Reference)
    {
        _words = Words;
        _reference = Reference;
    }
    public void HideRandomWords()
    {
        Random random = new();
        int randomIndex = random.Next(0, _words.Count);

        while(chosenIndexList.Contains(randomIndex))
        {
            randomIndex = random.Next(0, _words.Count);
        }
        
            chosenIndexList.Add(randomIndex);
            Word selectedWord = _words[randomIndex];
            selectedWord.HideWord(); 
    }
    public string GetScriptureText()
    {
        string scriptureText = string.Join(" ", _words.Select(word => word.GetWordText()));
        return $"{_reference.GetReferenceText()}: {scriptureText}";
    }
    public bool DetermineIfCompletelyHidden()
    {
        bool allWordsHidden = true;

        foreach(Word word in _words)
        {
            bool hiddenStatus = word.DetermineIfHidden();
            if (hiddenStatus == false)
            {
                allWordsHidden = false;
            }
        }

        return allWordsHidden;
    } 
}