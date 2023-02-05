
namespace LearningDesignPatterns
{
    public class Singleton
    {
        private static Singleton instance;
        private static readonly object LockObject = new object();

        public Singleton()
        {

        }

        public static Singleton Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (LockObject)
                    {
                        instance ??= new Singleton();
                    }
                }
                return instance;
            }
            
        }
        public void PrintMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
