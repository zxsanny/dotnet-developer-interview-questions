#dotnet-developer-interview-questions

A list of helpful .net related questions, you can use it to interview potential candidates or test yourself.


## Junior dev questions

```
class Animal
{
}
```


1. What is string? struct or class? What is intern pool?
 (```
var x = "some";var y = "so" + "me"; //is this different strings or no? 
```)
* Differences between String and StringBuilder. When to use what and why?
* Differences between struct and class, reverences and values types
* What is static constructor? When it invokes?
* What is boxing?
* What is interface, differences between interfaces and abstract classes
* What is virtual methods?, polymorphism?
* Meaning of access modifiers, protected internal access modifier
* Have C# objects destructor?
* What is GC? What is IDisposable? Is GC call Dispose() when you  
* Differences between Singleton and Static class. Your attitude to the singletons
* What is AppDomain?
* What is Generic classes? Constrains in delegates, covariance, contravariance
* What is delegate, multicast delegate, differences between events and delegates?
* Linq - task with Users - get users to add, remove, update on LINQ

## Middle dev questions
1. What is ORM, pros/cons, which ORM you are using? (Linq, NHibernate, EntityFramework)
* Do you use NuGet? Are you create your own NuGet server?
* What is Dependency Injection, used frameworks (Unity, Autofac)
* Thread synchronization methods, (lock, ReadWriteLockSlim)
* TDD concept, Mocking, used frameworks (Nunit, Microsoft Test, Moq, NSubstitute)
* Does C# classes have destructor?
* Do you use DDD?
