using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new()
        {
            _title = "Curing the Blind",
            _author = "MrBeast",
            _length = 600
        };
        Video video2 = new()
        {
            _title = "Unlocking the Secrets of the Universe",
            _author = "Celeste Maxwell",
            _length = 745
        };
        Video video3 = new()
        {
            _title = "Artificial Intelligence will CHANGE OUR LIVES!",
            _author = "notarobot",
            _length = 529
        };
        Comment comment1 = new()
        {
            _name = "Adventurer91",
            _text = "Can't wait for more content like this!"
        };
        Comment comment2 = new()
        {
            _name = "Zephyr",
            _text = "Nice"
        };
        Comment comment3 = new()
        {
            _name = "GameMasterPro123",
            _text = "nerd"
        };
    }
}