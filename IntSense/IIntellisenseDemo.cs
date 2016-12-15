using System;
using System.Runtime.InteropServices;

namespace IntDemo
{
    [InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

    public interface IIntellisenseDemo
    {
        int NumberBy3 { get; set; }
        int NumberBy2 { get; set; }
        string TestString(string name);
    }
}
