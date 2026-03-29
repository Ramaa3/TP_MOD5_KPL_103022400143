using System;
using System.Collections.Generic;
using System.Text;

namespace TP_MODUL5_103022401043
{
    internal class HaloGeneric{

        // Method generic
        public void SapaUser<T>(T user){
            Console.WriteLine("Halo user " + user);
        }

    }
}
