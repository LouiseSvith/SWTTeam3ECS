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
         
      }

      public bool RunSelfTest()
      {
         throw new NotImplementedException();
      }
   }
}
