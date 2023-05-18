using ProjectPatterns;

// Singleton are global that changes

Singleton.Current.SomeProperty = "Example"; // Create an object
Singleton.Current.OtherProperty = "Other property example"; // Set the OtherProperty

Singleton.Current.SomeMethod(); // Call SomeMethod() For the first object

Singleton.New("Another object");
Singleton.Current.SomeMethod(); // OtherProperty will be null, because New creates another object

// ONLY ONE OBJECT SINGLETON CAN BE ACTIVE

// Builder Example
ProductBuilder pb = new ProductBuilder();

pb.AddString("Xis")
    .AddString("de")
    .AddNumber(123456)
    .AddMany("Product Builder", 5);

Product product = pb.Build();

BetterProductBuilder bpb = new BetterProductBuilder();
pb.AddString("Xisdezin")
    .AddString(" Outra String")
    .AddNumber(987654)
    .AddMany("Better Product Builder", 2);

product = bpb.Build();

// Controller Example

Console.WriteLine(Flyweight.Matrix);
Console.WriteLine(Flyweight.ObjectA);
// You can't create another Matrix and there's only 1 object Matrix
//Controller.Matrix = new double[][];
Console.WriteLine(Flyweight.Matrix);
