using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECS_2;
using NUnit.Framework;

namespace ECS2.Unit.Test
{
   [TestFixture]
   public class ECSUnitTest
   {
      public ECS _uut;
      public FakeHeater _FakeHeater;
      public FakeTempSensor _FakeTempSensor;

      [SetUp]
      public void SetUp()
      {
       _FakeHeater = new FakeHeater();
       _FakeTempSensor = new FakeTempSensor();
         _uut = new ECS(28,_FakeTempSensor,_FakeHeater);
      }

      [Test]

   }
}
