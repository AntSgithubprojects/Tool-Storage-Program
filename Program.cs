using System;
using ToolLibrary;

namespace CustCollectionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                          
                ToolData[] gardening = new ToolData[5];
                gardening[0] = new ToolData("Spade", " |Used for digging| ", 5);
                gardening[1] = new ToolData("Wheel Barrow", " |Used to carry dirt| ", 2);
                gardening[2] = new ToolData("N/A", "", 0);
                gardening[3] = new ToolData("N/A", "", 0);
                gardening[4] = new ToolData("N/A", "", 0);
                ToolData[] flooring = new ToolData[5];
                flooring[0] = new ToolData("Tiles", " |Used to tile the floor| ", 3);
                flooring[1] = new ToolData("Wood Plank", " |Used to place wood flooring| ", 0);
                flooring[2] = new ToolData("N/A", "", 0);
                flooring[3] = new ToolData("N/A", "", 0);
                flooring[4] = new ToolData("N/A", "", 0);
                ToolData[] fencing = new ToolData[5];
                fencing[0] = new ToolData("Metal", " |Metal Colorbond Fence| ", 2);
                fencing[1] = new ToolData("Wood", " |Wood plank fence| ", 10);
                fencing[2] = new ToolData("N/A", "", 0);
                fencing[3] = new ToolData("N/A", "", 0);
                fencing[4] = new ToolData("N/A", "", 0);
                ToolData[] measuring = new ToolData[5];
                measuring[0] = new ToolData("Tape Measure", " |Length of tape for measuring| ", 3);
                measuring[1] = new ToolData("Ruler", " |Wood stick for measuring| ", 0);
                measuring[2] = new ToolData("N/A", "", 0);
                measuring[3] = new ToolData("N/A", "", 0);
                measuring[4] = new ToolData("N/A", "", 0);
                ToolData[] cleaning = new ToolData[5];
                cleaning[0] = new ToolData("Sponge", " |Sponge material for cleaning vehicles| ", 30);
                cleaning[1] = new ToolData("Window Cleaner", " |Tool used for cleaning windows| ", 4);
                cleaning[2] = new ToolData("N/A", "", 0);
                cleaning[3] = new ToolData("N/A", "", 0);
                cleaning[4] = new ToolData("N/A", "", 0);
                ToolData[] painting = new ToolData[5];
                painting[0] = new ToolData("Paint Brush", " |Dip in paint and brush on surface| ", 10);
                painting[1] = new ToolData("Paint Roller", " |Used for painting large surfaces| ", 0);
                painting[2] = new ToolData("N/A", "", 0);
                painting[3] = new ToolData("N/A", "", 0);
                painting[4] = new ToolData("N/A", "", 0);
                ToolData[] electronic = new ToolData[5];
                electronic[0] = new ToolData("Speaker", " |Audio Speaker for playing music| ", 5);
                electronic[1] = new ToolData("Computer", " |Laptop for rent| ", 0);
                electronic[2] = new ToolData("N/A", "", 0);
                electronic[3] = new ToolData("N/A", "", 0);
                electronic[4] = new ToolData("N/A", "", 0);
                ToolData[] electricity = new ToolData[5];
                electricity[0] = new ToolData("Extension Cord", " |10m extension cord| ", 0);
                electricity[1] = new ToolData("Power Point", " |Equipment for installing a power point| ", 2);
                electricity[2] = new ToolData("N/A", "", 0);
                electricity[3] = new ToolData("N/A", "", 0);
                electricity[4] = new ToolData("N/A", "", 0);
                ToolData[] automotive = new ToolData[5];
                automotive[0] = new ToolData("Battery Charger", " |Used for charging car battery| ", 1);
                automotive[1] = new ToolData("Wheel", " |Used as emergency spare tyre| ", 1);
                automotive[2] = new ToolData("N/A", "", 0);
                automotive[3] = new ToolData("N/A", "", 0);
                automotive[4] = new ToolData("N/A", "", 0);

                Customer[] customers = new Customer[5];
                customers[0] = new Customer("", "", 0, "");
                customers[1] = new Customer("", "", 0, "");
                customers[2] = new Customer("", "", 0, "");
                customers[3] = new Customer("", "", 0, "");
                customers[4] = new Customer("", "", 0, "");

                int i = 0;
                int x = 2; //Tool Array 
                int y = 0; //Customer Array
                while (i == 0)
                {
                    {
                        Console.Clear();
                        Console.WriteLine("|Please input either 1 or 2|" +
                            "\n1 If you would like to read tool description, add new tools, or return leased tools. " +
                            "\n2 If you would like to lend tools." +
                            "\n3 If you would like to see the customers that are currently leasing tools.");
                        int toolSelect = Convert.ToInt32(Console.ReadLine());
                        if (toolSelect == 1)
                        {
                            //add tools
                            //
                            {
                                Console.WriteLine("\nWhat category of tool would you like to open?\n" +
                                    "\nThe layout of tools is: Name of tool  | Tool Description | Amount in storage");
                                Console.WriteLine("\n Option 0 = gardening \n Option 1 = Flooring \n Option 2 = fencing \n Option 3 = measuring \n option 4 = cleaning \n option 5 = painting \n option 6 = electronic" +
                                    "\n option 7 = electricity \n option 8 = automotive");
                            }
                            int toolAdd = Convert.ToInt32(Console.ReadLine());
                            if (toolAdd == 0)
                            {
                                Console.Clear();
                                foreach (var ToolName in gardening)
                                {
                                    Console.WriteLine(ToolName.ToString());
                                }
                                Console.WriteLine("If the tool you would like to add/return is listed press 1, otherwise press 2 to add new type.");
                                int toolReturn = Convert.ToInt32(Console.ReadLine());
                                if (toolReturn == 1)
                                {
                                    Console.Clear();
                                    Console.WriteLine(gardening[0].toolname + " input 0 to add +1 to inventory");
                                    Console.WriteLine(gardening[1].toolname + " input 1 to add +1 to inventory");
                                    Console.WriteLine(gardening[2].toolname + " input 2 to add +1 to inventory");
                                    Console.WriteLine(gardening[3].toolname + " input 3 to add +1 to inventory");
                                    Console.WriteLine(gardening[4].toolname + " input 4 to add +1 to inventory");
                                    {
                                        int addTool = Convert.ToInt32(Console.ReadLine());
                                        gardening[addTool].storage++;
                                        foreach (var item in gardening)
                                        {
                                            Console.WriteLine(item.ToString());
                                        }
                                    }
                                }
                                if (toolReturn == 2)
                                {
                                    Console.WriteLine("Please type tool name & enter + type brief description and enter + type the quantity you're adding and enter.");

                                    gardening[x].toolname = Console.ReadLine();
                                    gardening[x].tooldescription = Console.ReadLine();
                                    gardening[x].storage = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine(gardening[x]);
                                    x++;
                                }
                            }
                            if (toolAdd == 1)
                            {
                                Console.Clear();
                                foreach (var item in flooring)
                                {
                                    Console.WriteLine(item.ToString());
                                }
                                Console.WriteLine("If the tool you would like to add/return is listed press 1, otherwise press 2 to add new type.");
                                int toolReturn = Convert.ToInt32(Console.ReadLine());
                                if (toolReturn == 1)
                                {
                                    Console.Clear();
                                    Console.WriteLine(flooring[0].toolname + " input 0 to add +1 to inventory");
                                    Console.WriteLine(flooring[1].toolname + " input 1 to add +1 to inventory");
                                    Console.WriteLine(flooring[2].toolname + " input 2 to add +1 to inventory");
                                    Console.WriteLine(flooring[3].toolname + " input 3 to add +1 to inventory");
                                    Console.WriteLine(flooring[4].toolname + " input 4 to add +1 to inventory");
                                    {
                                        int addTool = Convert.ToInt32(Console.ReadLine());
                                        flooring[addTool].storage++;
                                        foreach (var item in flooring)
                                        {
                                            Console.WriteLine(item.ToString());
                                        }
                                    }
                                }
                                if (toolReturn == 2)
                                {
                                    Console.WriteLine("Please type tool name & enter + type brief description and enter + type the quantity you're adding and enter.");

                                    flooring[x].toolname = Console.ReadLine();
                                    flooring[x].tooldescription = Console.ReadLine();
                                    flooring[x].storage = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine(flooring[x]);
                                    x++;
                                }
                            }
                            if (toolAdd == 2)
                            {
                                Console.Clear();
                                foreach (var item in fencing)
                                {
                                    Console.WriteLine(item.ToString());
                                }
                                Console.WriteLine("If the tool you would like to add/return is listed press 1, otherwise press 2 to add new type.");
                                int toolReturn = Convert.ToInt32(Console.ReadLine());
                                if (toolReturn == 1)
                                {
                                    Console.Clear();
                                    Console.WriteLine(fencing[0].toolname + " input 0 to add +1 to inventory");
                                    Console.WriteLine(fencing[1].toolname + " input 1 to add +1 to inventory");
                                    Console.WriteLine(fencing[2].toolname + " input 2 to add +1 to inventory");
                                    Console.WriteLine(fencing[3].toolname + " input 3 to add +1 to inventory");
                                    Console.WriteLine(fencing[4].toolname + " input 4 to add +1 to inventory");
                                    {
                                        int addTool = Convert.ToInt32(Console.ReadLine());
                                        fencing[addTool].storage++;
                                        foreach (var item in fencing)
                                        {
                                            Console.WriteLine(item.ToString());
                                        }
                                    }
                                }
                                if (toolReturn == 2)
                                {
                                    Console.WriteLine("Please type tool name & enter + type brief description and enter + type the quantity you're adding and enter.");

                                    fencing[x].toolname = Console.ReadLine();
                                    fencing[x].tooldescription = Console.ReadLine();
                                    fencing[x].storage = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine(fencing[x]);
                                    x++;
                                }
                            }
                            if (toolAdd == 3)
                            {
                                Console.Clear();
                                foreach (var item in measuring)
                                {
                                    Console.WriteLine(item.ToString());
                                }
                                Console.WriteLine("If the tool you would like to add/return is listed press 1, otherwise press 2 to add new type.");
                                int toolReturn = Convert.ToInt32(Console.ReadLine());
                                if (toolReturn == 1)
                                {
                                    Console.Clear();
                                    Console.WriteLine(measuring[0].toolname + " input 0 to add +1 to inventory");
                                    Console.WriteLine(measuring[1].toolname + " input 1 to add +1 to inventory");
                                    Console.WriteLine(measuring[2].toolname + " input 2 to add +1 to inventory");
                                    Console.WriteLine(measuring[3].toolname + " input 3 to add +1 to inventory");
                                    Console.WriteLine(measuring[4].toolname + " input 4 to add +1 to inventory");
                                    {
                                        int addTool = Convert.ToInt32(Console.ReadLine());
                                        measuring[addTool].storage++;
                                        foreach (var item in measuring)
                                        {
                                            Console.WriteLine(item.ToString());
                                        }
                                    }
                                }
                                if (toolReturn == 2)
                                {
                                    Console.WriteLine("Please type tool name & enter + type brief description and enter + type the quantity you're adding and enter.");

                                    measuring[x].toolname = Console.ReadLine();
                                    measuring[x].tooldescription = Console.ReadLine();
                                    measuring[x].storage = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine(measuring[x]);
                                    x++;
                                }
                            }
                            if (toolAdd == 4)
                            {
                                Console.Clear();
                                foreach (var item in cleaning)
                                {
                                    Console.WriteLine(item.ToString());
                                }
                                Console.WriteLine("If the tool you would like to add/return is listed press 1, otherwise press 2 to add new type.");
                                int toolReturn = Convert.ToInt32(Console.ReadLine());
                                if (toolReturn == 1)
                                {
                                    Console.Clear();
                                    Console.WriteLine(cleaning[0].toolname + " input 0 to add +1 to inventory");
                                    Console.WriteLine(cleaning[1].toolname + " input 1 to add +1 to inventory");
                                    Console.WriteLine(cleaning[2].toolname + " input 2 to add +1 to inventory");
                                    Console.WriteLine(cleaning[3].toolname + " input 3 to add +1 to inventory");
                                    Console.WriteLine(cleaning[4].toolname + " input 4 to add +1 to inventory");
                                    {
                                        int addTool = Convert.ToInt32(Console.ReadLine());
                                        cleaning[addTool].storage++;
                                        foreach (var item in cleaning)
                                        {
                                            Console.WriteLine(item.ToString());
                                        }
                                    }
                                }
                                if (toolReturn == 2)
                                {
                                    Console.WriteLine("Please type tool name & enter + type brief description and enter + type the quantity you're adding and enter.");

                                    cleaning[x].toolname = Console.ReadLine();
                                    cleaning[x].tooldescription = Console.ReadLine();
                                    cleaning[x].storage = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine(cleaning[x]);
                                    x++;
                                }
                            }
                            if (toolAdd == 5)
                            {
                                Console.Clear();
                                foreach (var item in painting)
                                {
                                    Console.WriteLine(item.ToString());
                                }
                                Console.WriteLine("If the tool you would like to add/return is listed press 1, otherwise press 2 to add new type.");
                                int toolReturn = Convert.ToInt32(Console.ReadLine());
                                if (toolReturn == 1)
                                {
                                    Console.Clear();
                                    Console.WriteLine(painting[0].toolname + " input 0 to add +1 to inventory");
                                    Console.WriteLine(painting[1].toolname + " input 1 to add +1 to inventory");
                                    Console.WriteLine(painting[2].toolname + " input 2 to add +1 to inventory");
                                    Console.WriteLine(painting[3].toolname + " input 3 to add +1 to inventory");
                                    Console.WriteLine(painting[4].toolname + " input 4 to add +1 to inventory");
                                    {
                                        int addTool = Convert.ToInt32(Console.ReadLine());
                                        painting[addTool].storage++;
                                        foreach (var item in painting)
                                        {
                                            Console.WriteLine(item.ToString());
                                        }
                                    }
                                }
                                if (toolReturn == 2)
                                {
                                    Console.WriteLine("Please type tool name & enter + type brief description and enter + type the quantity you're adding and enter.");

                                    painting[x].toolname = Console.ReadLine();
                                    painting[x].tooldescription = Console.ReadLine();
                                    painting[x].storage = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine(painting[x]);
                                    x++;
                                }
                            }
                            if (toolAdd == 6)
                            {
                                Console.Clear();
                                foreach (var item in electronic)
                                {
                                    Console.WriteLine(item.ToString());
                                }
                                Console.WriteLine("If the tool you would like to add/return is listed press 1, otherwise press 2 to add new type.");
                                int toolReturn = Convert.ToInt32(Console.ReadLine());
                                if (toolReturn == 1)
                                {
                                    Console.Clear();
                                    Console.WriteLine(electronic[0].toolname + " input 0 to add +1 to inventory");
                                    Console.WriteLine(electronic[1].toolname + " input 1 to add +1 to inventory");
                                    Console.WriteLine(electronic[2].toolname + " input 2 to add +1 to inventory");
                                    Console.WriteLine(electronic[3].toolname + " input 3 to add +1 to inventory");
                                    Console.WriteLine(electronic[4].toolname + " input 4 to add +1 to inventory");
                                    {
                                        int addTool = Convert.ToInt32(Console.ReadLine());
                                        electronic[addTool].storage++;
                                        foreach (var item in electronic)
                                        {
                                            Console.WriteLine(item.ToString());
                                        }
                                    }
                                }
                                if (toolReturn == 2)
                                {
                                    Console.WriteLine("Please type tool name & enter + type brief description and enter + type the quantity you're adding and enter.");

                                    electronic[x].toolname = Console.ReadLine();
                                    electronic[x].tooldescription = Console.ReadLine();
                                    electronic[x].storage = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine(electronic[x]);
                                    x++;
                                }
                            }
                            if (toolAdd == 7)
                            {
                                Console.Clear();
                                foreach (var item in electricity)
                                {
                                    Console.WriteLine(item.ToString());
                                }
                                Console.WriteLine("If the tool you would like to add/return is listed press 1, otherwise press 2 to add new type.");
                                int toolReturn = Convert.ToInt32(Console.ReadLine());
                                if (toolReturn == 1)
                                {
                                    Console.Clear();
                                    Console.WriteLine(electricity[0].toolname + " input 0 to add +1 to inventory");
                                    Console.WriteLine(electricity[1].toolname + " input 1 to add +1 to inventory");
                                    Console.WriteLine(electricity[2].toolname + " input 2 to add +1 to inventory");
                                    Console.WriteLine(electricity[3].toolname + " input 3 to add +1 to inventory");
                                    Console.WriteLine(electricity[4].toolname + " input 4 to add +1 to inventory");
                                    {
                                        int addTool = Convert.ToInt32(Console.ReadLine());
                                        electricity[addTool].storage++;
                                        foreach (var item in electricity)
                                        {
                                            Console.WriteLine(item.ToString());
                                        }
                                    }
                                }
                                if (toolReturn == 2)
                                {
                                    Console.WriteLine("Please type tool name & enter + type brief description and enter + type the quantity you're adding and enter.");

                                    electricity[x].toolname = Console.ReadLine();
                                    electricity[x].tooldescription = Console.ReadLine();
                                    electricity[x].storage = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine(electricity[x]);
                                    x++;
                                }
                            }
                            if (toolAdd == 8)
                            {
                                Console.Clear();
                                foreach (var item in automotive)
                                {
                                    Console.WriteLine(item.ToString());
                                }
                                Console.WriteLine("If the tool you would like to add/return is listed press 1, otherwise press 2 to add new type.");
                                int toolReturn = Convert.ToInt32(Console.ReadLine());
                                if (toolReturn == 1)
                                {
                                    Console.Clear();
                                    Console.WriteLine(automotive[0].toolname + " input 0 to add +1 to inventory");
                                    Console.WriteLine(automotive[1].toolname + " input 1 to add +1 to inventory");
                                    Console.WriteLine(automotive[2].toolname + " input 2 to add +1 to inventory");
                                    Console.WriteLine(automotive[3].toolname + " input 3 to add +1 to inventory");
                                    Console.WriteLine(automotive[4].toolname + " input 4 to add +1 to inventory");
                                    {
                                        int addTool = Convert.ToInt32(Console.ReadLine());
                                        automotive[addTool].storage++;
                                        foreach (var item in automotive)
                                        {
                                            Console.WriteLine(item.ToString());
                                        }
                                    }
                                }
                                if (toolReturn == 2)
                                {
                                    Console.WriteLine("Please type tool name & enter + type brief description and enter + type the quantity you're adding and enter.");

                                    automotive[x].toolname = Console.ReadLine();
                                    automotive[x].tooldescription = Console.ReadLine();
                                    automotive[x].storage = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine(automotive[x]);
                                    x++;
                                }
                            }
                            Console.WriteLine("Would you like to return to the menu? \n 0 = YES    1 = NO");
                            i = Convert.ToInt32(Console.ReadLine());
                        }


                        //remove tool
                        //
                        if (toolSelect == 2)
                        {
                            {
                                Console.WriteLine("What category of tool would you like to lend?");
                                Console.WriteLine("\n Option 0 = gardening \n Option 1 = Flooring \n Option 2 = fencing \n Option 3 = measuring \n option 4 = cleaning \n option 5 = painting \n option 6 = electronic" +
                                    "\n option 7 = electricity \n option 8 = automotive");
                            }
                            int toolLend = Convert.ToInt32(Console.ReadLine());
                            if (toolLend == 0)
                            {
                                Console.Clear();
                                Console.WriteLine("To rent tools please enter your details. \nPlease enter your last name, enter + first name, enter + mobile number, enter.");
                                customers[y].lastname = Console.ReadLine();
                                customers[y].firstname = Console.ReadLine();
                                customers[y].mobile = Convert.ToInt32(Console.ReadLine());
                                foreach (var item in gardening)
                                {
                                    Console.WriteLine(item.ToString());
                                }
                                Console.WriteLine(customers[y] + "What tool would you like to lend?\n");
                                Console.WriteLine("0 " + gardening[0].toolname);
                                Console.WriteLine("1 " + gardening[1].toolname);
                                Console.WriteLine("2 " + gardening[2].toolname);
                                Console.WriteLine("3 " + gardening[3].toolname);
                                Console.WriteLine("4 " + gardening[4].toolname);
                                int toolRemove = Convert.ToInt32(Console.ReadLine());
                                gardening[toolRemove].storage--;
                                customers[y].tool = gardening[toolRemove].toolname;
                                y++;
                                Console.WriteLine("New balance: " + gardening[toolRemove].toolname + " " + gardening[toolRemove].storage);
                            }
                            if (toolLend == 1)
                            {
                                Console.Clear();
                                Console.WriteLine("To rent tools please enter your details. \nPlease enter your last name, enter + first name, enter + mobile number, enter.");
                                customers[y].lastname = Console.ReadLine();
                                customers[y].firstname = Console.ReadLine();
                                customers[y].mobile = Convert.ToInt32(Console.ReadLine());
                                foreach (var item in flooring)
                                {
                                    Console.WriteLine(item.ToString());
                                }
                                Console.WriteLine(customers[y] + "What tool would you like to lend?\n");
                                Console.WriteLine("0 " + flooring[0].toolname);
                                Console.WriteLine("1 " + flooring[1].toolname);
                                Console.WriteLine("2 " + flooring[2].toolname);
                                Console.WriteLine("3 " + flooring[3].toolname);
                                Console.WriteLine("4 " + flooring[4].toolname);
                                int toolRemove = Convert.ToInt32(Console.ReadLine());
                                flooring[toolRemove].storage--;
                                customers[y].tool = flooring[toolRemove].toolname;
                                y++;
                                Console.WriteLine("New balance: " + flooring[toolRemove].toolname + " " + flooring[toolRemove].storage);

                            }
                            if (toolLend == 2)
                            {
                                Console.Clear();
                                Console.WriteLine("To rent tools please enter your details. \nPlease enter your last name, enter + first name, enter + mobile number, enter.");
                                customers[y].lastname = Console.ReadLine();
                                customers[y].firstname = Console.ReadLine();
                                customers[y].mobile = Convert.ToInt32(Console.ReadLine());
                                foreach (var item in fencing)
                                {
                                    Console.WriteLine(item.ToString());
                                }
                                Console.WriteLine(customers[y] + "What tool would you like to lend?\n");
                                Console.WriteLine("0 " + fencing[0].toolname);
                                Console.WriteLine("1 " + fencing[1].toolname);
                                Console.WriteLine("2 " + fencing[2].toolname);
                                Console.WriteLine("3 " + fencing[3].toolname);
                                Console.WriteLine("4 " + fencing[4].toolname);
                                int toolRemove = Convert.ToInt32(Console.ReadLine());
                                fencing[toolRemove].storage--;
                                customers[y].tool = fencing[toolRemove].toolname;
                                y++;
                                Console.WriteLine("New balance: " + fencing[toolRemove].toolname + " " + fencing[toolRemove].storage);

                            }
                            if (toolLend == 3)
                            {
                                Console.Clear();
                                Console.WriteLine("To rent tools please enter your details. \nPlease enter your last name, enter + first name, enter + mobile number, enter.");
                                customers[y].lastname = Console.ReadLine();
                                customers[y].firstname = Console.ReadLine();
                                customers[y].mobile = Convert.ToInt32(Console.ReadLine());
                                foreach (var item in measuring)
                                {
                                    Console.WriteLine(item.ToString());
                                }
                                Console.WriteLine(customers[y] + "What tool would you like to lend?\n");
                                Console.WriteLine("0 " + measuring[0].toolname);
                                Console.WriteLine("1 " + measuring[1].toolname);
                                Console.WriteLine("2 " + measuring[2].toolname);
                                Console.WriteLine("3 " + measuring[3].toolname);
                                Console.WriteLine("4 " + measuring[4].toolname);
                                int toolRemove = Convert.ToInt32(Console.ReadLine());
                                measuring[toolRemove].storage--;
                                customers[y].tool = measuring[toolRemove].toolname;
                                y++;
                                Console.WriteLine("New balance: " + measuring[toolRemove].toolname + " " + measuring[toolRemove].storage);
                            }
                            if (toolLend == 4)
                            {
                                Console.Clear();
                                Console.WriteLine("To rent tools please enter your details. \nPlease enter your last name, enter + first name, enter + mobile number, enter.");
                                customers[y].lastname = Console.ReadLine();
                                customers[y].firstname = Console.ReadLine();
                                customers[y].mobile = Convert.ToInt32(Console.ReadLine());
                                foreach (var item in cleaning)
                                {
                                    Console.WriteLine(item.ToString());
                                }
                                Console.WriteLine(customers[y] + "What tool would you like to lend?\n");
                                Console.WriteLine("0 " + cleaning[0].toolname);
                                Console.WriteLine("1 " + cleaning[1].toolname);
                                Console.WriteLine("2 " + cleaning[2].toolname);
                                Console.WriteLine("3 " + cleaning[3].toolname);
                                Console.WriteLine("4 " + cleaning[4].toolname);
                                int toolRemove = Convert.ToInt32(Console.ReadLine());
                                cleaning[toolRemove].storage--;
                                customers[y].tool = cleaning[toolRemove].toolname;
                                y++;
                                Console.WriteLine("New balance: " + cleaning[toolRemove].toolname + " " + cleaning[toolRemove].storage);
                            }
                            if (toolLend == 5)
                            {
                                Console.Clear();
                                Console.WriteLine("To rent tools please enter your details. \nPlease enter your last name, enter + first name, enter + mobile number, enter.");
                                customers[y].lastname = Console.ReadLine();
                                customers[y].firstname = Console.ReadLine();
                                customers[y].mobile = Convert.ToInt32(Console.ReadLine());
                                foreach (var item in painting)
                                {
                                    Console.WriteLine(item.ToString());
                                }
                                Console.WriteLine(customers[y] + "What tool would you like to lend?\n");
                                Console.WriteLine("0 " + painting[0].toolname);
                                Console.WriteLine("1 " + painting[1].toolname);
                                Console.WriteLine("2 " + painting[2].toolname);
                                Console.WriteLine("3 " + painting[3].toolname);
                                Console.WriteLine("4 " + painting[4].toolname);
                                int toolRemove = Convert.ToInt32(Console.ReadLine());
                                painting[toolRemove].storage--;
                                customers[y].tool = painting[toolRemove].toolname;
                                y++;
                                Console.WriteLine("New balance: " + painting[toolRemove].toolname + " " + painting[toolRemove].storage);
                            }
                            if (toolLend == 6)
                            {
                                Console.Clear();
                                Console.WriteLine("To rent tools please enter your details. \nPlease enter your last name, enter + first name, enter + mobile number, enter.");
                                customers[y].lastname = Console.ReadLine();
                                customers[y].firstname = Console.ReadLine();
                                customers[y].mobile = Convert.ToInt32(Console.ReadLine());
                                foreach (var item in electronic)
                                {
                                    Console.WriteLine(item.ToString());
                                }
                                Console.WriteLine(customers[y] + "What tool would you like to lend?\n");
                                Console.WriteLine("0 " + electronic[0].toolname);
                                Console.WriteLine("1 " + electronic[1].toolname);
                                Console.WriteLine("2 " + electronic[2].toolname);
                                Console.WriteLine("3 " + electronic[3].toolname);
                                Console.WriteLine("4 " + electronic[4].toolname);
                                int toolRemove = Convert.ToInt32(Console.ReadLine());
                                electronic[toolRemove].storage--;
                                customers[y].tool = electronic[toolRemove].toolname;
                                y++;
                                Console.WriteLine("New balance: " + electronic[toolRemove].toolname + " " + electronic[toolRemove].storage);
                            }
                            if (toolLend == 7)
                            {
                                Console.Clear();
                                Console.WriteLine("To rent tools please enter your details. \nPlease enter your last name, enter + first name, enter + mobile number, enter.");
                                customers[y].lastname = Console.ReadLine();
                                customers[y].firstname = Console.ReadLine();
                                customers[y].mobile = Convert.ToInt32(Console.ReadLine());
                                foreach (var item in electricity)
                                {
                                    Console.WriteLine(item.ToString());
                                }
                                Console.WriteLine(customers[y] + "What tool would you like to lend?\n");
                                Console.WriteLine("0 " + electricity[0].toolname);
                                Console.WriteLine("1 " + electricity[1].toolname);
                                Console.WriteLine("2 " + electricity[2].toolname);
                                Console.WriteLine("3 " + electricity[3].toolname);
                                Console.WriteLine("4 " + electricity[4].toolname);
                                int toolRemove = Convert.ToInt32(Console.ReadLine());
                                electricity[toolRemove].storage--;
                                customers[y].tool = electricity[toolRemove].toolname;
                                y++;
                                Console.WriteLine("New balance: " + electricity[toolRemove].toolname + " " + electricity[toolRemove].storage);
                            }
                            if (toolLend == 8)
                            {
                                Console.Clear();
                                Console.WriteLine("To rent tools please enter your details. \nPlease enter your last name, enter + first name, enter + mobile number, enter.");
                                customers[y].lastname = Console.ReadLine();
                                customers[y].firstname = Console.ReadLine();
                                customers[y].mobile = Convert.ToInt32(Console.ReadLine());
                                foreach (var item in automotive)
                                {
                                    Console.WriteLine(item.ToString());
                                }
                                Console.WriteLine(customers[y] + "What tool would you like to lend?\n");

                                Console.WriteLine("0 " + automotive[0].toolname);
                                Console.WriteLine("1 " + automotive[1].toolname);
                                Console.WriteLine("2 " + automotive[2].toolname);
                                Console.WriteLine("3 " + automotive[3].toolname);
                                Console.WriteLine("4 " + automotive[4].toolname);
                                int toolRemove = Convert.ToInt32(Console.ReadLine());
                                automotive[toolRemove].storage--;
                                customers[y].tool = automotive[toolRemove].toolname;
                                Console.WriteLine("New balance: " + automotive[toolRemove].toolname + " " + automotive[toolRemove].storage);
                                y++;
                            }
                            Console.WriteLine("Would you like to return to the menu? \n 0 = YES    1 = NO");
                            i = Convert.ToInt32(Console.ReadLine());
                        }
                        //customer details
                        //
                        if (toolSelect == 3)
                        {
                            {
                                Console.WriteLine(customers[0] + customers[0].tool + "\n");
                                Console.WriteLine(customers[1] + customers[1].tool + "\n");
                                Console.WriteLine(customers[2] + customers[2].tool + "\n");
                                Console.WriteLine(customers[3] + customers[3].tool + "\n");
                                Console.WriteLine(customers[4] + customers[4].tool + "\n");
                            }
                            Console.WriteLine("Would you like to return to the menu? \n 0 = YES    1 = NO");
                            i = Convert.ToInt32(Console.ReadLine());
                        }
                    }
                }
            }
        }
    }
}



