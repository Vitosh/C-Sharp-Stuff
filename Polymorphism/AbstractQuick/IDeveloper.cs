using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractQuick
{
    public interface IDeveloper
    {
        string Name { get; }
        int Salary { get; }
        string PresentYourself();
    }
}
