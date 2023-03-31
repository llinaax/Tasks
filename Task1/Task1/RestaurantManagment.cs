namespace Task1;

public class RestaurantManagment
{
    List<Menu> menus = new List<Menu>();
    List<Ingredients> ingredients = new List<Ingredients>();
    List<Orders> orders = new List<Orders>();
    List<Staff> staff = new List<Staff>();
    List<Table> tables = new List<Table>();
    List<Visitors> visitors = new List<Visitors>();
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
            foreach (var m in menus)
            {
                Console.WriteLine($"Name: {m.Dish}");
                Console.WriteLine($"Price: {m.Price}");
                Console.WriteLine($"Ingredients: {m.Inredients}\n");
            }
        }

        public void AddNewDish()
        {
    
            menus.Add(Menu.CreateDish());
        }
        
        public void PrintIngredients()
        {
            foreach (var n in ingredients)
            {
                Console.WriteLine($"Name: {n.Name}");
                Console.WriteLine($"Price: {n.Price}\n");
            }
        }

        public void AddNewIngredient()
        {
            ingredients.Add(Ingredients.CreateIngredients());
        }
        

        public void AddNewOrder()
        {
        
            orders.Add(Orders.CreateNewOrder());
        }

        public void PrintNewOrder()
        {
            foreach (var o in orders)
            {
                Console.WriteLine($"Your dish: {o.Dishes}");
                Console.WriteLine($"Your total price: {o.Prices}");
            }
        }

        public void AddNewEmployee()
        {
    
            staff.Add(Staff.CreateEmployee());
        }

        public void PrintNewEmployee()
        {
            foreach (var s in staff)
            {
                Console.WriteLine($"Employee's name: {s.Name}");
                Console.WriteLine($"Employee's number: {s.Number}");
            }
        }

        public void AddNewTable()
        {
            tables.Add(Table.CreateTable());
        }

        public void PrintNewTable()
        {
            foreach (var t in tables)
            {
                Console.WriteLine($"Table number: {t.Number}");
                Console.WriteLine($"Table seats: {t.Seats}");
            }
        }

        public void AddNewVisitor()
         {
             visitors.Add(Visitors.CreateVisitor());
         }
         public void PrintNewVisitor()
         {
             foreach (var v in visitors)
             {
                 Console.WriteLine($"Visitor's name: {v.Name}");
                 Console.WriteLine($"Visitor's number: {v.Number}");
             }
         }

}