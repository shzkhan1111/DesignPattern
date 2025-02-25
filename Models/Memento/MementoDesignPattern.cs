using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Memento
{
    public class TextEditor
    {
        private string _text;
        private int _cursorPosition;
        private int _scrollPosition;

        public void SetText(string text)
        {
            _text = text;
        }
        public void SetCursorPosition(int position)
        {
            _cursorPosition = position;
        }

        public void SetScrollPosition(int position)
        {
            _scrollPosition = position;
        }
        //save returns state into the history 
        public EditorMemento Save()
        {
            return new EditorMemento(_text, _cursorPosition, _scrollPosition);
        }
        // Restore the state from a memento
        public void Restore(EditorMemento memento)
        {
            _text = memento.GetText();
            _cursorPosition = memento.GetCursorPosition();
            _scrollPosition = memento.GetScrollPosition();
        }
        // Display the current state
        public void DisplayState()
        {
            Console.WriteLine($"Text: {_text}, Cursor Position: {_cursorPosition}, Scroll Position: {_scrollPosition}");
        }


    }

    //memento object
    public class EditorMemento
    {
        //once set cannot be modified exposed method to return ibject 
        private readonly string _text;
        private readonly int _cursorPosition;
        private readonly int _scrollPosition;

        public EditorMemento(string text, int cursorPosition, int scrollPosition)
        {
            _text = text;
            _cursorPosition = cursorPosition;
            _scrollPosition = scrollPosition;
        }

        // Only the originator can access these methods
        public string GetText()
        {
            return _text;
        }

        public int GetCursorPosition()
        {
            return _cursorPosition;
        }

        public int GetScrollPosition()
        {
            return _scrollPosition;
        }
    }


    //care taker
    public class History
    {
        private readonly Stack<EditorMemento> _mementos = new Stack<EditorMemento>();

        public void Push(EditorMemento memento)
        {
            _mementos.Push(memento);
        }

        public EditorMemento Pop()
        {
            if (_mementos.Count > 0)
            {
                return _mementos.Pop();
            }
            throw new InvalidOperationException("No mementos available to restore.");
        }
    }

}
