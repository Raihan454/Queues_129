﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queues_129
{
    class Program
    {
        int FRONT, REAR, max = 5;
        int[] queue_array = new int[5];

        public Program()
        {
            /*Initializing the values of the variables REARand FRONT to -1 to indicate that
             * the queue is initially empty.*/
            FRONT = -1;
            REAR = -1;
        }
        static void Main(string[] args)
        {
        }
    }
}
