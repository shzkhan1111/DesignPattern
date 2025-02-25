using DesignPattern.DesignPattern;
using Models;
using Models.Adapter;
using Models.builder;
using Models.ChainOfResposibility;
using Models.CommandDesignPattern;
using Models.CompositeDesignPattern;
using Models.DecoratorDesignPatterb;
using Models.Enums;
using Models.Facade;
using Models.FlyWeight;
using Models.IteratorDEsignPattern;
using Models.Memento;
using Models.PrototypeDesignPattern;
using Models.Proxy;
using System.ComponentModel.DataAnnotations;
using System.Data.Common;




// Create the originator and caretaker
Models.Memento.TextEditor editor = new Models.Memento.TextEditor();
History history = new History();

editor.SetText("Hello");
editor.SetCursorPosition(5);
editor.SetScrollPosition(0);
editor.DisplayState();
//save the history
history.Push(editor.Save());

editor.SetText("Hello World");
editor.SetCursorPosition(11);
editor.SetScrollPosition(0);
editor.DisplayState();
history.Push(editor.Save());

editor.Restore(history.Pop());
editor.DisplayState();


editor.Restore(history.Pop());
editor.DisplayState();
