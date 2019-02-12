using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECS_2
{
    public interface ITempSensor
    {
        int GetTemp();

        bool RunSelfTest();
    }
}
