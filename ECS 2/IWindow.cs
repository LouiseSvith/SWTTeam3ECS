using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECS_2
{
  public interface IWindow
   {
      void Open();
      void Close();
      bool RunSelfTest();
   } 
}
