public static class ArraySelector
{
    public static void Run()
    {
        var l1 = new[] { 1, 2, 3, 4, 5 };
        var l2 = new[] { 2, 4, 6, 8, 10};
        var select = new[] { 1, 1, 1, 2, 2, 1, 2, 2, 2, 1};
        var intResult = ListSelector(l1, l2, select);
        Console.WriteLine("<int[]>{" + string.Join(", ", intResult) + "}"); // <int[]>{1, 2, 3, 2, 4, 4, 6, 8, 10, 5}
    }

    private static int[] ListSelector(int[] list1, int[] list2, int[] select)
    {
        var returnList = new int[select.Length];
        var index1 = 0;
        var index2 = 0;
        var index = 0;
        var addNumber = 0;

        foreach (int number in select)
        {
            if (number == 1)
            {
                // Console.WriteLine("number = 1");
                // Console.WriteLine(list1[index1]);
                // returnList.Append(list1[index1]).ToArray();
                addNumber = list1[index1];
                index1 += 1;
            } else if (number == 2)
            {
                // Console.WriteLine("number = 2");
                // Console.WriteLine(list2[index2]);
                // returnList.Append(list2[index2]).ToArray();
                addNumber = list2[index2];
                index2 += 1;
            }

            returnList[index] = addNumber;
            index += 1;
        }

        return returnList;
    }
}