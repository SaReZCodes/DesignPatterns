using CompositePattern;

Menu menu = new Menu("P1", "test");
menu.Add(new MenuItem("i1", "sub", true, 1000));
menu.Add(new MenuItem("i2", "sub", false, 3000));
menu.Add(new MenuItem("i3", "sub", false, 4000));
menu.Add(new MenuItem("i4", "sub", true, 1500));
menu.Add(new Menu("P2", "test"));
menu.Add(new MenuItem("i1", "sub", true, 1000));
menu.Add(new MenuItem("i2", "sub", false, 3000));
string showMenu = menu.Show();
Console.WriteLine(showMenu);
Console.ReadKey();