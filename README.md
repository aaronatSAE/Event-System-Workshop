# Event-System-Workshop

How do event-based systems work again?

I'm glad you asked!

An event is something that scripts can listen for in order to activate functionality.

A class (that is, a script) "subscribes" to an event call with the += operator
and unsubscribes to an event call with the -= operator
(which means that it listens for, or stops listening for, an event call).

An operator is a kind of 'symbol,' just like +, -, +=, >, <=, etc,
and holds a specific functionality.

In this case, the += and -= operators start and stop the class from listening to specific event calls.

This means the class will "listen" for a specific event to be called.
When the event is called, the class will run the assigned method, and functionality will happen!

Imagine you walk into a room of friends. You tell some friends "When you hear me yell out Hello, jump up!"
Some of your friends are now subscribed to the "Hello!" event.
When you call out "Hello!", those friends will jump.

That could look like this, in code:

void OnEnable()
{
     EventManager.OnHearHello += JumpUp;
}

Take WaterGun.cs for example:

void OnEnable()
{
     EventManager.OnMouseClick += ShootWater;
}

WaterGun.cs is listening for the OnMouseClick event and will call ShootWater when it hears it.
The script starts and stops listening for the OnMouseClick event with the OnEnable and OnDisable methods.
When the event is called (in the GameManager script, actually) it will call the ShootWater method.

We must make sure that if a class starts listening (with +=) it will also stop listening (with -=).
If you don't put in corresponding unsubscriptions, then errors and even memory leaks could occur.

For the above example in WaterGun.cs, we just need to put this in afterwards:

void OnDisable()
{
     EventManager.OnMouseClick -= ShootWater;
}

And there you have it! Look through the rest of this example if you'd like to see more.
