> # *Creational Design Patterns*
>
> 
>
> Puscas Dumitru, FAF-192

The main purpose of this laboratory work was to study and practice some of the creational patterns from the following list:

**Singleton** is a creational design pattern that restricts the instantiation of a class to one "single" instance. This is useful when exactly one object is needed to coordinate actions across the system.

**Builder** is a creational design pattern designed to provide a flexible solution to various object creation problems in object-oriented programming. The intent of the Builder design pattern is to separate the construction of a complex object from its representation.

**Prototype** is a creational design pattern used when the type of objects to create is determined by a prototypical instance, which is cloned to produce new objects. This pattern is used to avoid subclasses of an object creator in the client application.

**Factory method** is a creational pattern that uses factory methods to deal with the problem of creating objects without having to specify the exact class of the object that will be created. This is done by creating objects by calling a factory method—either specified in an interface and implemented by child classes, or implemented in a base class and optionally overridden by derived classes—rather than by calling a constructor.

**Abstract Factory** is a creational design pattern, which provides a way to encapsulate a group of individual factories that have a common theme without specifying their concrete classes.

​	For the sample project the following patterns have been implemented: Singleton, Builder and Factory Method. The Singleton class is represented by the `RandomNonBuyers` class, which creates a simple simulation of some clients in the shop that are not going to purchase anything.

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

​	The `VehicleBuilder` represents the builder class for `Vehicle` and is used to instantiate different types of vehicles in a much easier way than the straightforward one. All the classes involved can be found in the 'Builders' folder.

```c#
builder = new ScooterBuilder();
shop.Construct(builder);

builder = new MotorCycleBuilder();
shop.Construct(builder);
            
builder = new CarBuilder();
shop.Construct(builder);
```

​	The `Document` class implements the simple Factory method, which creates a new instance of a concreate product by a given parameter, either it is a Credit or a simple PaymentCheck. All the classes involved can be found in the 'FactoryStuff' folder.

```c#

doc = new PaymentCheck();
doc.ListPages();
            
doc = new Credit();
doc.ListPages();

```

The result of some basic client code:


![png](https://github.com/PuscasDumitru/FAF.TMPS16.1-Labs/blob/main/LAB_1/screen.png)
