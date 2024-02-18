using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new()
        {
            new()
            {
                _title = "Curing the Blind",
                _author = "MrBeast",
                _length = 600,
                _comments = new()
                {
                    new()
                    {
                        _name = "Adventurer91",
                        _text = "Can't wait for more content like this!"
                    },
                    new()
                    {
                        _name = "Zephyr",
                        _text = "Nice"
                    },
                    new()
                    {
                        _name = "GameMasterPro123",
                        _text = "nerd"
                    }
                }
            },
            new()
            {
                _title = "Unlocking the Secrets of the Universe",
                _author = "Celeste Maxwell",
                _length = 745,
                _comments = new()
                {
                    new()
                    {
                        _name = "Adventurer91",
                        _text = "Can't wait for more content like this!"
                    },
                    new()
                    {
                        _name = "Zephyr",
                        _text = "Nice"
                    },
                    new()
                    {
                        _name = "GameMasterPro123",
                        _text = "nerd"
                    }
                }
            },
            new()
            {
                _title = "Artificial Intelligence will CHANGE OUR LIVES!",
                _author = "notarobot",
                _length = 529,
                _comments = new()
                {
                    new()
                    {
                        _name = "Adventurer91",
                        _text = "Can't wait for more content like this!"
                    },
                    new()
                    {
                        _name = "Zephyr",
                        _text = "Nice"
                    },
                    new()
                    {
                        _name = "GameMasterPro123",
                        _text = "nerd"
                    }
                }
            }
        };

        foreach(Video video in videos)
        {
            video.DisplayVideoInfo();
            foreach(Comment comment in video._comments)
            {
                comment.DisplayComment();
            }
        }
    }
}