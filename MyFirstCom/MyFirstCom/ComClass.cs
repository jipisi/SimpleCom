using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace MyFirstCom
{
    [Guid("DEA10720-E600-4712-8A92-411B4E77D0FD"),ClassInterface(ClassInterfaceType.None),ComSourceInterfaces(typeof(MyCom_Events))]
    public class ComClass : MyCom_Interface
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

    }
}
