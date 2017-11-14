using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace MyFirstCom
{
    [Guid("DF884273-95A1-410d-8CD5-0B69D610BBAF")]
    public interface MyCom_Interface
    {
        [DispId(1)]
        int Add(int a, int b);
    }

    [Guid("C1942A47-7967-4648-B531-F3C694D442BE"), InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]
    public interface MyCom_Events
    {

    }


}
