using System;
using System.Collections.Generic;
using System.Text;

namespace taksi
{
    class Objek
    {
        string nama;
        int nomor;
        int duty;

        public void DriverName()
        {
            Console.WriteLine("Driver Name : Corona");
        }

        public void OnDuty()
        {
            Console.WriteLine("On Duty : Yes");
        }

        public void NumberOfPpassenger()
        {
            Console.WriteLine("Number Of Passenger : 10");
        }

        public void PickUpPassenger()
        {
            Console.WriteLine("Corona Sedang Menjemput Penumpang");
        }

        public void DropOffPasengger()
        {
            Console.WriteLine("Corona Sedang Mengantar Penumpang");
        }


    }
}
