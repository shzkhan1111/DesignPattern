using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.CommandDesignPattern
{
    public interface ICommand
    {
        void Execute(string s);
    }


    public class TextEditor
    {
        private string _clipboard;

        public void Copy(string s)
        {
            Console.WriteLine("Copying text...");
            _clipboard = s;
        }

        public void Paste()
        {
            Console.WriteLine($"Pasting text: {_clipboard}");
        }
    }
    //create concrete command
    public class CopyCommand : ICommand
    {
        private TextEditor textEditor;
        public CopyCommand(TextEditor editor)
        {
            textEditor = editor;
        }
        public void Execute(string s)
        {
            textEditor.Copy(s);
        }
    }

    public class PasteCommand : ICommand
    {
        private TextEditor textEditor;
        public PasteCommand(TextEditor editor)
        {
            textEditor = editor;
        }
        public void Execute(string s)
        {
            textEditor.Paste();
        }
    }

    public class Button
    {
        private ICommand _command;
        public Button(ICommand command)
        {
            _command = command;
        }
        public void click(string s) 
        {
            Console.WriteLine("Button clicked!");
            _command.Execute(s);
        }

    }
}
