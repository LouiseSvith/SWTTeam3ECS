using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECS_2;

namespace ECS2.Unit.Test
{
  public class FakeTempSensor : ITempSensor
   {
      
      public int GetTemp()
      {
         return 25;
      }

      public bool RunSelfTest()
      {
         return true;
      }
   }
}
