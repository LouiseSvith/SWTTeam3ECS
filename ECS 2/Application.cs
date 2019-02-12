namespace ECS_2
{
    public class Application
    {
        public static void Main(string[] args)
        {
            Heater heater = new Heater();
            TempSensor tempSensor = new TempSensor();
           Window window = new Window();
            var ecs = new ECS(28, tempSensor, heater,window);

            ecs.Regulate();

            ecs.SetThreshold(20);

            ecs.Regulate();
        }
    }
}
