using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECS_2;

namespace ECS2.Unit.Test
{
  public class FakeHeater : IHeater
   {
      public bool Tjek { private set; get; }
     void IHeater.TurnOn()
     {
        Tjek = true;
     }

      void IHeater.TurnOff()
      {
         Tjek = false;
      }

      bool IHeater.RunSelfTest()
      {
         throw new NotImplementedException();
      }
   }
}
