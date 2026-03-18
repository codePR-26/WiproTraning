using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    internal class ConditionalMessage
    {
        private string Message;
        public ConditionalMessage(string gender)
        {
            Message = gender;
        }
        public string Greeting()
        {
            if (Message == "Male")
            {
                return "Hello, Sir!";
            }
            else if (Message == "Female")
            {
                return "Hello, Ma'am!";
            }
            else
            {
                return "Hello!";
            }
        }

    }
}