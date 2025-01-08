﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assignment_04.Part_02_Q03
{
    internal class SmsNotificationService : INotificationService
    {
        public void SendNotification(string recipient, string message)
        {
            Console.WriteLine($"SMS sent to {recipient}: {message}");
        }
    }
}
