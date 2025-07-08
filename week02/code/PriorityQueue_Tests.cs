using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: 
    // Expected Result: 
    // Defect(s) Found: 
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
    // Scenario: 
    // Expected Result: 
    // Defect(s) Found: 
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