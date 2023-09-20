> # *Design Patterns*
>
> 
>
> 

The main purpose of this laboratory is to study and practice some of the creational, structural and behavioral programming design patterns. 

### **Creational design patterns**

Creational patterns provide various object creation mechanisms, which increase flexibility and reuse of existing code.

**Singleton** is a creational design pattern that restricts the instantiation of a class to one "single" instance. This is useful when exactly one object is needed to coordinate actions across the system.

For the sample project the following patterns have been implemented: Singleton, Builder and Factory Method. The Singleton class is represented by the `RandomNonBuyers` class, which creates a simple simulation of some clients in the shop that are not going to purchase anything.

```c#
public static RandomNonBuyers GetRandomNonBuyers()
{
         
    if (instance == null)
    {
        lock (locker)
        {
            if (instance == null)
            {
               instance = new RandomNonBuyers();
            }
        }
    }
    return instance;
}
```
**Builder** is a creational design pattern designed to provide a flexible solution to various object creation problems in object-oriented programming. The intent of the Builder design pattern is to separate the construction of a complex object from its representation.

The `VehicleBuilder` represents the builder class for `Vehicle` and is used to instantiate different types of vehicles in a much easier way than the straightforward one. All the classes involved can be found in the 'Builders' folder.

```c#
builder = new ScooterBuilder();
shop.Construct(builder);

builder = new MotorCycleBuilder();
shop.Construct(builder);
            
builder = new CarBuilder();
shop.Construct(builder);
```

**Factory method** is a creational pattern that uses factory methods to deal with the problem of creating objects without having to specify the exact class of the object that will be created. This is done by creating objects by calling a factory method—either specified in an interface and implemented by child classes, or implemented in a base class and optionally overridden by derived classes—rather than by calling a constructor.

The `Document` class implements the simple Factory method, which creates a new instance of a concreate product by a given parameter, either it is a Credit or a simple PaymentCheck. All the classes involved can be found in the 'FactoryStuff' folder.

```c#

doc = new PaymentCheck();
doc.ListPages();
            
doc = new Credit();
doc.ListPages();

```


### **Structural design patterns**

Structural patterns are concerned with how classes and objects are composed to form larger structures. Structural class patterns use inheritance to compose interfaces or implementations. As a simple example, consider how multiple inheritance mixes two or more classes into one.

**Facade** is a structural design pattern that provides a simplified interface to a library, a framework, or any other complex set of classes.

The Facade class is represented by the `Cashier` class, which creates a simple interface which allows the client code to be much cleaner

```c#
if(vehType == "scooter")
{
  builder = new ScooterBuilder("scooter", 1300, new SimpleAnalysis());
  shop.Construct(builder);
  builder.Vehicle.Show();
  doc = new PaymentCheck();
  doc.ListPages();
}

..code for other types of vehicle
```

**Decorator** is a structural design pattern that lets you attach new behaviors to objects by placing these objects inside special wrapper objects that contain the behaviors.

The `VehicleDiscount` class represents the implementation of the 'decorator' pattern. In this case it wraps the Vehicle by setting a dicount to its price, if it's Black Friday

```c#
class VehicleDiscount
{
    protected Vehicle discountedVehicle;
    float discount;

    public VehicleDiscount(Vehicle discountedVehicle, float discount)
    {
         this.discountedVehicle = discountedVehicle;
         this.discount = discount;
    }

    public void ShowDiscount()
    {
         discountedVehicle.Price *= discount;
         Console.WriteLine($"This vehicle has been discounted by {discount * 100}%, the final price is {discountedVehicle.Price}$");
    }
}

---------------------------

if(vehType == "scooter")
{
    builder = new ScooterBuilder("scooter", 1300, new SimpleAnalysis());
    shop.Construct(builder);

    if(isBlackFriday)
    {
         vehicleDiscount = new VehicleDiscount(builder.Vehicle, 0.5f);
         vehicleDiscount.ShowDiscount();
    }

    builder.Vehicle.Show();
    doc = new PaymentCheck();
    doc.ListPages();
}
```

**Bridge** is a structural design pattern that lets you split a large class or a set of closely related classes into two separate hierarchies—abstraction and implementation—which can be developed independently of each other.

The `Diagnostics` class implements the Bridge pattern. The usage of this pattern is demonstrated by different bridge implementer classes, which make the functionality of Vehicle objects independent from the interface implementer classes.

### **Behavioral design patterns**

Behavioral design patterns are design patterns that identify common communication patterns among objects. By doing so, these patterns increase flexibility in carrying out communication.

**Strategy** is a behavioral design pattern that lets you define a family of algorithms, put each of them into a separate class, and make their objects interchangeable.

In order to implement the 'Strategy' pattern the: 'ICheck' interface was created(which is common to all variants of the algorithm), 'CheckContext' class which establishes the needed algorithm and the concrete classes 'JuridicCheck' and 'PhysicalCheck' for juridic and physical persons respectively. The context itself is being created in the 'Cashier' class and the execution is started also in this class.

```c#

cashier.Checkout("scooter", "juridic");
cashier.Checkout("car", "physical");
cashier.Checkout("motorcycle", "physical");

----

if(strategy == "juridic")
{
    context.Strategy = new JuridicCheck();
}


else if (strategy == "physical")
{
    context.Strategy = new PhysicalCheck();
}

context.ExecuteStrategy();

```


