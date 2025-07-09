using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Create a queue with the following people and priority: Bob(5), Sally(2), Tim(4), John(6), Mary(2)
    // and empty the queue in order of priority, if priority is tied then the person who comes earlier in the queue
    // should be removed first
    // Expected Result: John, Bob, Tim, Sally, Mary
    // Defect(s) Found: Dequeue was not removing people from the queue and was not checking the priority of the last
    // person in the queue
    
    public void TestPriorityQueue_1()
    {
        var bob = new PriorityItem("Bob", 5);
        var sally = new PriorityItem("Sally", 2);
        var tim = new PriorityItem("Tim", 4);
        var john = new PriorityItem("John", 6);
        var mary = new PriorityItem("Mary", 2);
        
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue(bob.Value, bob.Priority);
        priorityQueue.Enqueue(sally.Value, sally.Priority);
        priorityQueue.Enqueue(tim.Value, tim.Priority);
        priorityQueue.Enqueue(john.Value, john.Priority);
        priorityQueue.Enqueue(mary.Value, mary.Priority);

        PriorityItem[] expectedResults = [john, bob, tim, sally, mary];

        int i = 0;
        while (priorityQueue.Length > 0)
        {
            if (i >= expectedResults.Length)
            {
                Assert.Fail("Queue should have run out of items by now");
            }

            var person = priorityQueue.Dequeue();
            Assert.AreEqual(expectedResults[i].Value, person);
            i++;
        }
    }

    [TestMethod]
    // Scenario: Create a queue with the following people and priority: Bob(1), Sally(2), Tim(2), John(4), Mary(3)
    // and empty the queue in order of priority, if priority is tied then the person who comes earlier in the queue
    // should be removed first
    // Expected Result: Bob, Sally, Tim, Mary, John
    // Defect(s) Found: Dequeue was not removing people from the queue and was not checking the priority of the last
    // person in the queue
    public void TestPriorityQueue_2()
    {
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

        PriorityItem[] expectedResults = [john, mary, sally, tim, bob];

        int i = 0;
        while (priorityQueue.Length > 0)
        {
            if (i >= expectedResults.Length)
            {
                Assert.Fail("Queue should have run out of items by now");
            }

            var person = priorityQueue.Dequeue();
            Assert.AreEqual(expectedResults[i].Value, person);
            i++;
        }
    }

    // Add more test cases as needed below.
}