namespace cars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What type of car do you want? (budget/medium/luxury)");
            string carType = Console.ReadLine().ToLower();

            switch (carType)
            {
                case "budget":
                    Budget_Car budgetCar = new Budget_Car();
                    budgetCar.Show();
                    break;
                case "medium":
                    Medium_Car mediumCar = new Medium_Car();
                    mediumCar.Show();
                    break;
                case "luxury":
                    Luxury_Car luxuryCar = new Luxury_Car();
                    luxuryCar.Show();
                    break;
                default:
                    Console.WriteLine("Invalid car type.");
                    break;
            }

            Console.ReadLine();
        }
    }
}