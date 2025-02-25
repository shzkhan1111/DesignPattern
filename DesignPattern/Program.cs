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
using Models.PrototypeDesignPattern;
using Models.Proxy;
using System.ComponentModel.DataAnnotations;
using System.Data.Common;




Chatroom chatroom = new Chatroom();

User alice = new User("Alice");
User bob = new User("Bob");
User charlie = new User("Charlie");

chatroom.RegisterUser(alice);
chatroom.RegisterUser(bob);
chatroom.RegisterUser(charlie);

alice.SendMessageToUser("Hello Bob!", "Bob");
bob.SendMessageToUser("Hi Alice!", "Alice");
charlie.SendMessageToUser("Hey everyone!", "Alice");
alice.SendMessageToUser("How's it going?", "Charlie");

// Try sending a message to a non-existent user
alice.SendMessageToUser("Test message", "UnknownUser");