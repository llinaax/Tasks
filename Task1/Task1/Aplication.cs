using System.Xml;

namespace Task1;

public class Aplication
{
    RestaurantManagment restaurantManagment = new RestaurantManagment();

    public void Starting()
    {
        restaurantManagment.PrintInstructions();
    }

    public void Asking()
    {
        var i = true;
        while (i)
        {
            Console.WriteLine("Press the button that you need:");
            var ask = Convert.ToInt32(Console.ReadLine());

            switch (ask)
            {
                case 1:

                    restaurantManagment.AddNewDish();
                    Console.WriteLine("____");
                    Console.WriteLine("MENU");
                    Console.WriteLine("____");

                    restaurantManagment.PrintMenu();

                    break;
                case 2:

                    restaurantManagment.AddNewIngredient();
                    Console.WriteLine("___________");
                    Console.WriteLine("Ingredients");
                    Console.WriteLine("___________");

                    restaurantManagment.PrintIngredients();

                    break;
                case 3:

                    restaurantManagment.AddNewOrder();
                    Console.WriteLine("______");
                    Console.WriteLine("Orders");
                    Console.WriteLine("______");

                    restaurantManagment.PrintNewOrder();

                    break;
                case 4:
                    Staff staff = new Staff();

                    restaurantManagment.AddNewEmployee();
                    Console.WriteLine("_____");
                    Console.WriteLine("Employee");
                    Console.WriteLine("_____");

                    restaurantManagment.PrintNewEmployee();
                    break;
                case 5:

                    restaurantManagment.AddNewTable();
                    Console.WriteLine("_____");
                    Console.WriteLine("Table");
                    Console.WriteLine("_____");

                    restaurantManagment.PrintNewTable();
                    break;
                case 6:

                    restaurantManagment.AddNewVisitor();
                    Console.WriteLine("_______");
                    Console.WriteLine("Visitor");
                    Console.WriteLine("_______");

                    restaurantManagment.PrintNewVisitor();
                    break;
                case 7:
                    Console.WriteLine("Staff");
                    restaurantManagment.PrintNewEmployee();
                    break;
                case 8:
                    Console.WriteLine("Visitors");
                    restaurantManagment.PrintNewVisitor();
                    break;
                case 9:
                    i = false;
                    break;
            }
        }
    }
}