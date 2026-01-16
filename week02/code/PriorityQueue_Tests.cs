using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: See if The top priority is returned
    // Expected Result: "Top priority"
    // Defect(s) Found: None
    public void TestPriorityQueue_1()
    {


        var priorityQueue = new PriorityQueue();

        priorityQueue.Enqueue("TopPriority", 12);
        priorityQueue.Enqueue("NotPriority1", 1);
        priorityQueue.Enqueue("NotPriority2", 2);
        priorityQueue.Enqueue("NotPriority3", 3);
        priorityQueue.Enqueue("NotPriority4", 4);

        var value = priorityQueue.Dequeue();

        Console.WriteLine(value);
        Assert.AreEqual("TopPriority", value);
    }

    [TestMethod]
    // Scenario: See if the first one is collected if two values hold the same value
    // Expected Result: "Top Priority"
    /* Defect(s) Found: The for loop would check and grab a more farther back rather than the first one. 
    Changing "index < _queue.Count - 1" to "index >= _queue.Count - 1" fixed it. */
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();

        priorityQueue.Enqueue("TopPriority", 12);
        priorityQueue.Enqueue("NotPriority1", 12);
        priorityQueue.Enqueue("NotPriority2", 2);
        priorityQueue.Enqueue("NotPriority3", 3);
        priorityQueue.Enqueue("NotPriority4", 4);

        var value = priorityQueue.Dequeue();

        Console.WriteLine(value);
        Assert.AreEqual("TopPriority", value);
    }

    [TestMethod]
    // Scenario: See if The top priority is removed from queue. Also tells me if they are bieng enqueued right
    // Expected Result: [NotPriority1 (Pri:1), NotPriority2 (Pri:2), NotPriority3 (Pri:3), NotPriority4 (Pri:4)]
    // Defect(s) Found: The code did not remove the top priority value. I added a line that would: _queue.RemoveAt(highPriorityIndex);
    public void TestPriorityQueue_3()
    {


        var priorityQueue = new PriorityQueue();

        priorityQueue.Enqueue("TopPriority", 12);
        priorityQueue.Enqueue("NotPriority1", 1);
        priorityQueue.Enqueue("NotPriority2", 2);
        priorityQueue.Enqueue("NotPriority3", 3);
        priorityQueue.Enqueue("NotPriority4", 4);

        var value = priorityQueue.Dequeue();

        Console.WriteLine(value);

        Assert.AreEqual("[NotPriority1 (Pri:1), NotPriority2 (Pri:2), NotPriority3 (Pri:3), NotPriority4 (Pri:4)]", priorityQueue.ToString());
        Console.WriteLine(priorityQueue.ToString());
    }

    [TestMethod]
    // Scenario: See if The top priority is removed when multiple share same value insuring multiple are not removed
    // Expected Result: [NotPriority1 (Pri:1), NotPriority2 (Pri:2), NotPriority3 (Pri:3), NotPriority4 (Pri:4)]
    // Defect(s) Found: None
    public void TestPriorityQueue_4()
    {


        var priorityQueue = new PriorityQueue();

        priorityQueue.Enqueue("TopPriority", 12);
        priorityQueue.Enqueue("NotPriority1", 12);
        priorityQueue.Enqueue("NotPriority2", 2);
        priorityQueue.Enqueue("NotPriority3", 3);
        priorityQueue.Enqueue("NotPriority4", 4);

        var value = priorityQueue.Dequeue();

        Console.WriteLine(value);

        Assert.AreEqual("[NotPriority1 (Pri:12), NotPriority2 (Pri:2), NotPriority3 (Pri:3), NotPriority4 (Pri:4)]", priorityQueue.ToString());
        Console.WriteLine(priorityQueue.ToString());
    }

    [TestMethod]
    // Scenario: See if The error exception is thrown
    // Expected Result: "The queue is empty."
    // Defect(s) Found: None, This one always worked for me.
    public void TestPriorityQueue_5()
    {


        var priorityQueue = new PriorityQueue();

        try
        {
            priorityQueue.Dequeue();
            Assert.Fail("Exception Should have been thrown");
        }
        catch (InvalidOperationException e)
        {
            Assert.AreEqual("The queue is empty.", e.Message);
            Console.WriteLine(e.Message);
        }
        catch (AssertFailedException)
        {
            throw;
        }
        catch (Exception e)
        {
            Assert.Fail(
                 string.Format("Unexpected exception of type {0} caught: {1}",
                                e.GetType(), e.Message)
            );
        }
    }
}