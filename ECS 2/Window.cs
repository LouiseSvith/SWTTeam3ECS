﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECS_2
{
  public class Window : IWindow
   {
      public void Open()
      {
         System.Console.WriteLine("Window is open");
      }

      public void Close()
      {
         System.Console.WriteLine("Window is closed");
      }

      public bool RunSelfTest()
      {
         return true;
      }
   }
}
