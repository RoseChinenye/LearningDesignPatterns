

namespace LearningDesignPatterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var SingleInstance = Singleton.Instance;
            //SingleInstance.PrintMessage("Message");
           
            new Client().Main();
            
        }
    }
    
}