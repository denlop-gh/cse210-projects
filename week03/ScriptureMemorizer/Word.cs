using System;

    public class Word
    {
        public string _text { get; set; }
        public bool _isHidden { get; set; }

        public Word(string text)
        {
            _text = text;
            _isHidden = false;
        }

        public void Hide()
        {
            _isHidden = true;
        }
        
        public void Show()
        {
            _isHidden = false;
        }

        public bool IsHidden()
        {
            return _isHidden;
        }

    public string GetDisplayText()
        {
            return _isHidden ? new string('_', _text.Length) : _text;
        }
    }