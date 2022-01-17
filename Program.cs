Console.WriteLine("What is your name?");
string Name = Console.ReadLine();
ConsoleApp1.Character Player1 = new ConsoleApp1.Character();
Player1.Name = Name;

//Items
List<ConsoleApp1.Item> itemList1 = new List<ConsoleApp1.Item>();
ConsoleApp1.Item Sword = new ConsoleApp1.Item("sword","It's quite sharp");
itemList1.Add(Sword);

List<ConsoleApp1.Item> itemList2 = new List<ConsoleApp1.Item>();
ConsoleApp1.Item Toaster = new ConsoleApp1.Item("toaster", "Portable and high-powered");
itemList2.Add(Toaster);
ConsoleApp1.Item Bagel = new ConsoleApp1.Item("bagel", "Everything");
itemList2.Add(Bagel);

List<ConsoleApp1.Item> itemList3 = new List<ConsoleApp1.Item>();

List<ConsoleApp1.Item> itemList4 = new List<ConsoleApp1.Item>();

//Rooms
ConsoleApp1.Room room1 = new ConsoleApp1.Room("Entrance", "You find yourself in a grand entrance. A doorway leads to the north and a large staircase leads upstairs.", itemList1, null, null, null, null, null, null);
ConsoleApp1.Room room2 = new ConsoleApp1.Room("Kitchen", "This must be the kitchen. The owner of this house must love carbs! There is bread and bagels in every cabinet!", itemList2, null, null, null, null, null, null);
ConsoleApp1.Room room3 = new ConsoleApp1.Room("Living Room", "A large orange cat is sprawling across a plush green couch in a ray of sun. Better not disturb him.", itemList3, null, null, null, null, null, null);
ConsoleApp1.Room room4 = new ConsoleApp1.Room("Hallway", "You are in a long hallway. The walls are covered in old paintings. Hundreds of bowls of fruit and misc portraits stare down at you.", itemList4, null, null, null, null, null, null);

room1.MoveNorth = room2;
room1.MoveUp = room4;
room1.inventory = itemList1;

room2.MoveSouth = room1;
room2.MoveEast = room3;
room2.inventory = itemList2;

room3.inventory = itemList3;
room3.MoveWest = room2;

room4.inventory = itemList4;
room4.MoveDown = room1;



List<ConsoleApp1.Item> inventory = new List<ConsoleApp1.Item>();
Player1.inventory = inventory;
Player1.Location = room1;

Console.WriteLine("Hello " + Player1.Name);

for (; ; ) {
    Console.Write(">");
    string Input = Console.ReadLine().ToLower();

    //List of Inputs
    if (Input == "exit")
    {
        break;
    }
    if (Input == "help")
    {
        Console.WriteLine("exit, examine (x), inv (i), pick up, room, look (l), north, south, east, west, up, down");
    }
    if (Input == "inv" || Input == "i")
    {
        foreach (ConsoleApp1.Item Item in inventory)
        {
            Console.WriteLine(Item.Name);
        }

    }
    if (Input.StartsWith("pick up"))
    {
        string[] split = Input.Split(' ');
        for (int i = 0; i < Player1.Location.inventory.Count; i++)
        {
            ConsoleApp1.Item item = Player1.Location.inventory[i];
            if (item.Name == split[2])
            {
                Player1.PickUp(item);
                Player1.Location.Drop(item);
            }
        }
    }
    if (Input == "north" || Input == "south" || Input =="west" || Input =="east" || Input == "up" || Input == "down")
    {
        string moveResult = Player1.Move(Input);
        Console.WriteLine(moveResult);
    }
    if (Input == "room")
    {
        Console.WriteLine(Player1.Location.Name);
    }
    if (Input == "look" || Input =="l")
    {
        Console.WriteLine(Player1.Location.Description);
        Console.WriteLine("You see: ");
        foreach (ConsoleApp1.Item Item in Player1.Location.inventory)
        {
            Console.WriteLine(Item.Name + " ");
           
        }
    }
    if (Input.StartsWith("examine")||Input.StartsWith("x"))
    {
        string[] split = Input.Split(' ');
        foreach (ConsoleApp1.Item Item in Player1.inventory)
        {
            if (Item.Name == split[1])
            {
                Console.WriteLine(Item.Description);
            }
        }
    }
}