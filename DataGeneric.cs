using System;
using System.Collections.Generic;
using System.Text;

namespace TP_MODUL5_103022401043
{
    internal class DataGeneric<T>{

            // Property generic
            public T Data{ get; set; }

            // Constructor
            public DataGeneric(T data)
            {
                Data = data;
            }

            // Method untuk print data
            public void PrintData()
            {
                Console.WriteLine("Data yang tersimpan adalah: " + Data);
            }
        

    }
}
