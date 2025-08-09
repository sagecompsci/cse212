public class Node
{
    public int Data { get; set; }
    public Node? Right { get; private set; }
    public Node? Left { get; private set; }

    public Node(int data)
    {
        this.Data = data;
    }

    public void Insert(int value)
    {
        // TODO Start Problem 1
        if (value != Data)
        {
            if (value < Data)
            {
                // Insert to the left
                if (Left is null)
                    Left = new Node(value);
                else
                    Left.Insert(value);
            }
            else
            {
                // Insert to the right
                if (Right is null)
                    Right = new Node(value);
                else
                    Right.Insert(value);
            }
            
        }

    }

    public bool Contains(int value)
    {
        // TODO Start Problem 2
        if (value == Data)
        {
            return true;
        }
        
        if (value < Data)
        {
            if (Left is not null)
            {
                return Left.Contains(value);
            }

        }
        else
        {
            if (Right is not null)
            {
                return Right.Contains(value);
            }
        }
        
        return false;
    }

    public int GetHeight(int height = 0, int currHeight = 1)
    {
        // TODO Start Problem 4

        if (currHeight > height)
        {
            height = currHeight;
        }

        var options = new List<Node>() { Right, Left };
        for (var i = 0; i < options.Count; i++)
        {
            if (options[i] is not null)
            {
                currHeight += 1;
                return options[i].GetHeight(height, currHeight);
            }
        }

        return height; // Replace this line with the correct return statement(s)
    }
}