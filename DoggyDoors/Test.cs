using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoggyDoors
{
    class Test
    {
        /// <summary>
        /// First iteration test
        /// </summary>
        public void RunSimpleTest()
        {
            DogDoor door = new DogDoor();
            Remote remote = new Remote(door);

            Console.WriteLine("Dog barks!");
            remote.Pressbutton();
            Console.WriteLine("Dog went outside.");
            Console.WriteLine("Dog is done with it's business.");
            Console.WriteLine("Dog went inside.");
            try { System.Threading.Thread.Sleep(10000); } //Start alternate path where dogs gets locked outside
            catch { ArgumentOutOfRangeException e; }

            //System.Threading.Thread.Sleep(6000);//Ok I need this part, so it won't end prematurely
            Console.ReadKey(); //Or this
            //remote.Pressbutton(); Don't need this anymore since the door autocloses

        }
    }
}
