using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoggyDoors
{
    class DogDoor
    {
        private bool isOpen;
        internal bool IsOpen
        {
            get { return isOpen; }
            set { isOpen = value; }
        }

        public DogDoor()
        {
            isOpen = false;
        }

        public void Open()
        {
            Console.WriteLine("The dog door opens.");
            isOpen = true;
        }
        public void Close()
        {
            Console.WriteLine("The dog door closes.");
            isOpen = false;
        }


    }
}
