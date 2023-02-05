
namespace LearningDesignPatterns
{
    public class FurnitureFactory
    {
        // Interface for the abstract factory
        public interface IFurnitureFactory
        {
            IModernFurniture GetModernFurniture();
            IVictorianFurniture GetVictorianFurniture();
        }

        // Interface for product A
        public interface IModernFurniture
        {
            string UsefulFunctionA();
        }

        // Interface for product B
        public interface IVictorianFurniture
        {
            string UsefulFunctionB();
            string AnotherUsefulFunctionB(IModernFurniture collaborator);
        }

        // Concrete factory 1
        public class Chair : IFurnitureFactory
        {
            public IModernFurniture GetModernFurniture()
            {
                return new ConcreteProductA1();
            }

            public IVictorianFurniture GetVictorianFurniture()
            {
                return new ConcreteProductB1();
            }
        }

        // Concrete factory 2
        public class ConcreteFactory2 : IFurnitureFactory
        {
            public IModernFurniture GetModernFurniture()
            {
                return new ConcreteProductA2();
            }

            public IVictorianFurniture GetVictorianFurniture()
            {
                return new ConcreteProductB2();
            }
        }

        // Concrete product A1
        public class ConcreteProductA1 : IModernFurniture
        {
            public string UsefulFunctionA()
            {
                return "The result of the product A1.";
            }
        }

        // Concrete product A2
        public class ConcreteProductA2 : IModernFurniture
        {
            public string UsefulFunctionA()
            {
                return "The result of the product A2.";
            }
        }

        // Concrete product B1
        public class ConcreteProductB1 : IVictorianFurniture
        {
            public string UsefulFunctionB()
            {
                return "The result of the product B1.";
            }

            public string AnotherUsefulFunctionB(IModernFurniture collaborator)
            {
                var result = collaborator.UsefulFunctionA();
                return $"The result of the B1 collaborating with the ({result})";
            }
        }

        // Concrete product B2
        public class ConcreteProductB2 : IVictorianFurniture
        {
            public string UsefulFunctionB()
            {
                return "The result of the product B2.";
            }

            public string AnotherUsefulFunctionB(IModernFurniture collaborator)
            {
                var result = collaborator.UsefulFunctionA();
                return $"The result of the B2 collaborating with the ({result})";
            }
        }

        // Client code
        class Client
        {
            public void Main()
            {
                IFurnitureFactory factory = new Chair();
                IModernFurniture productA = factory.GetModernFurniture();
                IVictorianFurniture productB = factory.GetVictorianFurniture();
                Console.WriteLine(productB.UsefulFunctionB());
                Console.WriteLine(productB.AnotherUsefulFunctionB(productA));
            }


        }
    }
}