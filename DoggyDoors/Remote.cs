using System;
using System.Timers;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoggyDoors
{
    class Remote
    {
        private DogDoor door;

        public Remote(DogDoor _door)
        {
            door = _door;
        }

        public void Pressbutton()
        {
            Console.WriteLine("Pressing remote control button...");
            //I think the DogDoor should be handling it's open/close logic
            if (door.IsOpen) door.Close();
            else door.Open();

            Timer timer = new Timer(5000);
            timer.Elapsed += new ElapsedEventHandler(AutoCloseDoor);
            timer.Start();
    
            //timer.Close();//From what I've read, this will make the GC more effective
        }
        void AutoCloseDoor(object source, ElapsedEventArgs e)
        {
            //Console.WriteLine("kwik" + e.SignalTime);
            door.Close();
        }
     



    }
}
