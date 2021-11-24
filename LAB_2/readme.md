> # *Creational Design Patterns*
>
> 
>
> Puscas Dumitru, FAF-192

The main purpose of this laboratory work was to study and practice some of the structural patterns from the following list:

**Adapter** is a structural design pattern that allows objects with incompatible interfaces to collaborate.

**Bridge** is a structural design pattern that lets you split a large class or a set of closely related classes into two separate hierarchies—abstraction and implementation—which can be developed independently of each other.

**Composite** is a structural design pattern that lets you compose objects into tree structures and then work with these structures as if they were individual objects.

**Decorator** is a structural design pattern that lets you attach new behaviors to objects by placing these objects inside special wrapper objects that contain the behaviors.

**Facade** is a structural design pattern that provides a simplified interface to a library, a framework, or any other complex set of classes.

**Flyweight** is a structural design pattern that lets you fit more objects into the available amount of RAM by sharing common parts of state between multiple objects instead of keeping all of the data in each object.

**Proxy** is a structural design pattern that lets you provide a substitute or placeholder for another object. A proxy controls access to the original object, allowing you to perform something either before or after the request gets through to the original object.

​	The following patterns have been implemented into the project of the previous laboratory work: Facade, Decorator and Bridge. 

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

​	The `VehicleDiscount` class represents the implementation of the 'decorator' pattern. In this case it wraps the Vehicle by setting a dicount to its price, if it's Black Friday

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

​	The `Diagnostics` class implements the Bridge pattern. The usage of this pattern is demonstrated by different bridge implementer classes, which make the functionality of Vehicle objects independent from interface implementer classes.



