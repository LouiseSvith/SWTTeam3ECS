using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECS_2;

namespace ECS2.Unit.Test
{
   public class FakeWindow : IWindow
   {
      public bool Tjek { private set; get; }
      public void Open()
      {
         Tjek = true;
      }

      public void Close()
      {
         Tjek = false;
      }

      public bool RunSelfTest()
      {
         return true;
      }
   }
}
