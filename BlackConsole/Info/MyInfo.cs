using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class MyInfo
{
    public int number = 50;

    public string TestInfo(string strName)
    {
        return "Test Info " + strName;
    }

    public int Number
    {
        get
        {
            return number;
        }
        set
        {
            number = value * 31;
        }
    }
}