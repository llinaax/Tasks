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
        }
    }
}