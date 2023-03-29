namespace Task1;

public class RestaurantManagment
{
    List<Menu> Menus = new List<Menu>();

    List<Ingredients> Ingredients = new List<Ingredients>();

    List<Orders> Orders = new List<Orders>();

    List<Staff> Staff = new List<Staff>();

    List<Table> Tables = new List<Table>();

    List<Visitors> Visitors = new List<Visitors>();

    List<string> Instructions = new List<string>()
        {
            "1.For adding a new dish press '1'",
            "2.For adding new ingredient press '2'",
            "3.For making new order press '3'",
            "4.For adding a new employee press '4'",
            "5.For adding a new table press '5'",
            "6.For adding new visitor press '6'",
            "7.To view all staff '7'", 
            "8.To view all visitors press '8'\n",
            "9.To stop doing any actions press '9'",
            
        };

        public void PrintInstructions()
        {
            Console.WriteLine("____________");
            Console.WriteLine("Instructions");
            Console.WriteLine("____________");
            foreach (var el in Instructions)
            {
                Console.WriteLine(el);
            }

        }

        public void PrintMenu()
        {
            foreach (var m in Menus)
            {
                Console.WriteLine($"Name: {m.Dish}");
                Console.WriteLine($"Price: {m.Price}");
                Console.WriteLine($"Ingredients: {m.Inredients}\n");
            }
        }

        public void AddNewDish()
        {
            Menu menu = new Menu();
            Menus.Add(menu.CreateDish());
        }
        
        public void PrintIngredients()
        {
            foreach (var n in Ingredients)
            {
                Console.WriteLine($"Name: {n.Name}");
                Console.WriteLine($"Price: {n.Price}\n");
            }
        }

        public static void AddNewIngredient()
        {
            Ingredients ingredients = new Ingredients();
            Ingredients.Add(ingredients.CreateIngredients());
        }
        

        public void AddNewOrder()
        {
            Orders orders = new Orders();
            Orders.Add(orders.CreateNewOrder());
        }

        public void PrintNewOrder()
        {
            foreach (var o in Orders)
            {
                Console.WriteLine($"Your dish: {o.Dishes}");
                Console.WriteLine($"Your total price: {o.Prices}");
            }
        }

        public void AddNewEmployee()
        {
            Staff staff = new Staff();
            Staff.Add(staff.CreateEmployee());
        }

        public void PrintNewEmployee()
        {
            foreach (var s in Staff)
            {
                Console.WriteLine($"Employee's name: {s.Name}");
                Console.WriteLine($"Employee's number: {s.Number}");
            }
        }

        public void AddNewTable()
        {
            Table tables = new Table();
            Tables.Add(tables.CreateTable());
        }

        public void PrintNewTable()
        {
            foreach (var t in Tables)
            {
                Console.WriteLine($"Table number: {t.Number}");
                Console.WriteLine($"Table seats: {t.Seats}");
            }
        }

        public void AddNewVisitor()
         {
             Visitors visitors = new Visitors();
             Visitors.Add(visitors.CreateVisitor());
         }
         public void PrintNewVisitor()
         {
             foreach (var v in Visitors)
             {
                 Console.WriteLine($"Visitor's name: {v.Name}");
                 Console.WriteLine($"Visitor's number: {v.Number}");
             }
         }

}