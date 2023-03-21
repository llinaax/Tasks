using System.Xml;

namespace Task1;

public class Aplication
{
    RestaurantManagment restaurantManagment = new RestaurantManagment();

    public void Starting()
    {
        restaurantManagment.PrintInstructions();
    }
}