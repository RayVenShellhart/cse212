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

        if (value < Data)
        {
            // Insert to the left
            if (Left is null)
                Left = new Node(value);
            else
                Left.Insert(value);
        }
        else if (value > Data)
        {
            // Insert to the right
            if (Right is null)
                Right = new Node(value);
            else
                Right.Insert(value);
        }
    }

    public bool Contains(int value)
    {
        // TODO Start Problem 2
        if (value == Data)
        {
            return true;
        }
        else if (value < Data)
        {
            if (Left is null)
            {
                return false;
            }
            else
            {
                return Left.Contains(value);
            }
        }
        else if (value > Data)
        {
            if (Right is null)
                return false;
            else
                return Right.Contains(value);
        }
        else
        {
            return false;
        }
    }

    public int GetHeight()
    {
        int leftBranch = (Left == null) ? 0 : Left.GetHeight();
        int rightBranch = (Right == null) ? 0 : Right.GetHeight();

        if (leftBranch > rightBranch)
        {
            return 1 + leftBranch;
        }
        else
        {
            return 1 + rightBranch;
        }
    }
}