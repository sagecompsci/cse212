//
// var bob = new Person("Bob", 2);
// var tim = new Person("Tim", 5);
// var sue = new Person("Sue", 3);
//
// Person[] expectedResult = [bob, tim, sue, bob, tim, sue, tim, sue, tim, tim];
//
// var players = new TakingTurnsQueue();
// players.AddPerson(bob.Name, bob.Turns);
// players.AddPerson(tim.Name, tim.Turns);
// players.AddPerson(sue.Name, sue.Turns);
//
// while (players.Length > 0)
// {
//  var person = players.GetNextPerson();
// }



var bob = new PriorityItem("Bob", 1);
var sally = new PriorityItem("Sally", 2);
var tim = new PriorityItem("Tim", 2);
var john = new PriorityItem("John", 4);
var mary = new PriorityItem("Mary", 3);

var priorityQueue = new PriorityQueue();
priorityQueue.Enqueue(bob.Value, bob.Priority);
priorityQueue.Enqueue(sally.Value, sally.Priority);
priorityQueue.Enqueue(tim.Value, tim.Priority);
priorityQueue.Enqueue(john.Value, john.Priority);
priorityQueue.Enqueue(mary.Value, mary.Priority);

while (priorityQueue.Length > 0)
{
    var person = priorityQueue.Dequeue();
}