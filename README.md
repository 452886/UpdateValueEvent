# UpdateValueEvent
A small piece of code that updates a local variable and invokes an event with that updated value.


I personally used this for a project where I wanted to update the UI according to whatever value my 'score' had.
In the code, I would have a public Action that any class could subscribe to. 
In my case, there was a Score_Manager that had a function UpdateUI(int newValue). Which was subscribed
to that public Action. Whenever I lost/earned points, UpdateIntEvent would be called using the public Action.
This would update the local variable, and update anything that was subscribed to that Action. (So in this case the UI)
