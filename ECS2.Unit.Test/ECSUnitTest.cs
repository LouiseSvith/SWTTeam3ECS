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
      public ECS uut;
      public FakeHeater FakeHeater;
      public FakeTempSensor FakeTempSensor;

      [SetUp]
      public void SetUp()
      {
       FakeHeater = new FakeHeater();
       FakeTempSensor = new FakeTempSensor();
         uut = new ECS(28,FakeTempSensor,FakeHeater);
      }

      [Test]
      public void uutRegulate_ThresHold28_SensorValue25_HeaterIsOn()
      {
         uut.Regulate();
         Assert.That(FakeHeater.Tjek, Is.True);
      }

      [Test]
      public void uutRegulate_ThresHold23_SensorValue25_HeaterIsOff()
      {
         uut.SetThreshold(23);
         uut.Regulate();
         Assert.That(FakeHeater.Tjek, Is.False);
      }
   }
}
