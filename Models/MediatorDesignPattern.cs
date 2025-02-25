using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    //chatroom as mediator 
    //use has mediator object 

    //chatroom has a list of users 
    public interface IChatroom
    {
        void RegisterUser(User user);
        void SendMessage(string message , string userid);
    }
    public class User
    {
        public string ID { get; }
        private IChatroom _chatroom;
        public User(string id)
        {
            ID = id;
        }

        public void SetChatroom(IChatroom chatroom)
        {
            _chatroom = chatroom;
        }
        public void SendMessageToUser(string userid, string message)
        {
            Console.WriteLine($"Sending Message to {userid}");
            _chatroom.SendMessage(message, userid);
        }

        public void Recieve(string message)
        {
            Console.WriteLine($"{ID} message recieve {message}");
        }
    }

    public class Chatroom : IChatroom
    {
        private readonly Dictionary<string, User> _users = new Dictionary<string, User>(); 
        public void RegisterUser(User user)
        {
            if (!_users.ContainsKey(user.ID))
            {
                _users[user.ID] = user;
                //this user now as the below chatroom assinged 
                user.SetChatroom(this);

            }

        }

        

        public void SendMessage( string userid , string message)
        {
            if (_users.ContainsKey(userid))
            {
                Console.WriteLine($"Message received by {userid}: {message}");
                _users[userid].Recieve(message);
            }
            else
            {
                Console.WriteLine($"User {userid} not found.");
            }
        }
    }


}
