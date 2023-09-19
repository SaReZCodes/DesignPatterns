using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Receivers
{
    public class Stereo
    {
        public void On()
        {
            Console.WriteLine("Stereo On");
        }
        public void Off()
        {
            Console.WriteLine("Stereo Off");
        }
        public void SetCD()
        {
            Console.WriteLine("Stereo is set for CD input");
        } 
        public void SetDVD()
        {
            Console.WriteLine("Stereo is set for DVD input");
        } 
        public void SetRadio()
        {
            Console.WriteLine("Stereo is set for Radio input");
        }  
        public void SetVolume(int volume)
        {
            Console.WriteLine($"Stereo Volume is  set to {volume}");
        }
    }
}
