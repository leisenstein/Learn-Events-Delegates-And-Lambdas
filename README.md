# Learn-Events-Delegates-And-Lambdas
From PluralSight C# Events, Delegates and Lambdas

Module 1 - Events, Delegates, and Event Handlers

Events - A notification that goes to a subscriber (Button_Click)

Mouse press triggers a click event.
Multiple objects can listen to an event by subscribing
Events pass EventArgs (event data)
Button has x-pos, y-pos



Delegates - pipeline between event and event handler
Specialized class that is called a "Function Pointer"
Delegates take data from Event to EventHandler (Function/Method)

EventHandler - method that receives and processes data from delegaete
Normally, two Parameters (object sender, EventArgs e)



Module 2 - Creating Delegates
public delegate void WorkPerformedHandler(int hours, WorkType workType);

A delegate is the blueprint for a method (method pointer) where data is going to get dumped into.
A delegate takes data to a method handler.

The delegate signature must be matched by the Handler method.
public void Manager_WorkPerformed(int workHours, WorkType wType) {
   Console.WriteLine("WorkPerformed1 called");
}

To hook up the Handler, new the delegate and pass the method name
WorkPerformedHandler del1 = new WorkPerformedHandler(Manager_WorkPerformed);

Invoke the delgate
del1(5, WorkType.Golf);




















