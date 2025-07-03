// Arrays.MultiplesOf(3, 5);
var data = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
Arrays.RotateListRight(data, 2);


public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // TODO Problem 1 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.
        // first we need a for loop that will execute the code the same number of times at the length input
        // then each time we run the code we need to multiple the number input
        // the for loop i will need to start at 1, then we can multiply the number by i each time,
        // so the code will multiply by 1, and then 2, 3, 4 and so on until we reach the length input number
        // and we also need the array that will hold the numbers, and each
        // time the code is run we need to add to the array using an index of i-1

        var multiples = new double[length];
        for (int i = 1; i <= length; i++)
        {
            multiples[i - 1] = number * i;
        }
        

        return multiples; // replace this return statement with your own
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.
        // first we need a for loop that will run the number of times as the amount input
        // for each loop, we need to insert the value of the last index into the beginning of the list
        // then we need to remove the last index

        for (int i = 0; i < amount; i++)
        {
            var index = data.Count - 1;
            var num = data[index];
            data.Remove(num);
            data.Insert(0, num);
        }

        for (int i = 0; i < data.Count; i++)
        {
            Console.WriteLine(data[i]);
        }
    }
}
