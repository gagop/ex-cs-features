namespace CsExamples.CsVersion1;

//Delegates - callbacks vs Events - notifications, publish/subscriber pattern
/*
 * Events in C# are a special type of multicast delegate that can be used to provide notifications.
 * They are a way for a class or object to notify other classes or objects when something of interest occurs.
 * The key idea behind events is the publisher/subscriber model,
 * where the publisher raises an event, and the subscribers handle the event.
 *
 * Purpose: Delegates are general-purpose, type-safe function pointers used to encapsulate a method call.
 * Events, on the other hand, are a specific use case of delegates, designed for implementing
 * event-driven programming by enabling a class to notify other classes of occurrences.
 *
 * Access Modifiers: Delegates can be invoked by any object that holds a reference to them, much like any other method.
 * Events restrict how they can be used: only the class that declares an event can invoke it.
 * This encapsulation helps in managing the event subscription and invocation process,
 * ensuring that events can only be raised by the defining class.
 *
 * Subscription Model: While delegates can be used to implement a similar publish/subscribe model by allowing multiple methods to be attached
 * and invoked, events are specifically designed for this model.
 * Events provide a more structured and safer way to manage subscriptions, as they prevent subscribers from inadvertently
 * removing other subscriptions or invoking the event delegate directly.
 *
 * Syntax and Use Case: Events are typically used in scenarios where an action taken by one object needs to be communicated to one or more other objects,
 * without the need for the originating object to know about the specific methods that need to be called.
 * Delegates are more versatile and can be used in a broader range of scenarios, including but not limited to the event subscription model.
 * 
 */
public delegate void SendMessageNotification(string message);

public class Student
{
    public string Name { get; set; }
    public List<string> Courses { get; set; }
    public event SendMessageNotification NotifySubscribers;

    public void DoSthToNotifySubscribers()
    {
        //This way we can notify all the listeners
        NotifySubscribers?.Invoke("Student has done something");
    }
}

public class Examples3 {

    public void Notify(string message)
    {
        Console.WriteLine(message);
    }
    
    public void Run()
    {
        var st = new Student();
        st.NotifySubscribers+=Notify; //Added 1st listener
        st.NotifySubscribers+=(msg)=>Console.WriteLine(msg); //Added 2nd listener as lambda
    }
    
}
