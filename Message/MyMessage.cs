﻿using CommunityToolkit.Mvvm.Messaging.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temp.Message
{
    public class MyMessage:ValueChangedMessage<int>
    {
        private int count;

        public MyMessage(int value) : base(value)
        {
        }

        public int Count { get => count; set => count = value; }
    }
}
