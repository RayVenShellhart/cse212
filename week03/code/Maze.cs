/// <summary>
/// Defines a maze using a dictionary. The dictionary is provided by the
/// user when the Maze object is created. The dictionary will contain the
/// following mapping:
///
/// (x,y) : [left, right, up, down]
///
/// 'x' and 'y' are integers and represents locations in the maze.
/// 'left', 'right', 'up', and 'down' are boolean are represent valid directions
///
/// If a direction is false, then we can assume there is a wall in that direction.
/// If a direction is true, then we can proceed.  
///
/// If there is a wall, then throw an InvalidOperationException with the message "Can't go that way!".  If there is no wall,
/// then the 'currX' and 'currY' values should be changed.
/// </summary>
public class Maze
{
    private readonly Dictionary<ValueTuple<int, int>, bool[]> _mazeMap;
    private int _currX = 1;
    private int _currY = 1;



    private HashSet<(int, int)> mazeWalls = new HashSet<(int x, int y)>
        {
            (1, 3),
            (2, 5),
            (2, 6),
            (3, 1),
            (3, 2),
            (3, 3),
            (4, 2),
            (4, 5),
            (4, 6),
            (6, 2),
            (6, 4),
            (6, 5)
        };

    public Maze(Dictionary<ValueTuple<int, int>, bool[]> mazeMap)
    {
        _mazeMap = mazeMap;

        
    }

    // TODO Problem 4 - ADD YOUR CODE HERE
    /// <summary>
    /// Check to see if you can move left.  If you can, then move.  If you
    /// can't move, throw an InvalidOperationException with the message "Can't go that way!".
    /// </summary>
    public void MoveLeft()
    {
        

        if (_currX <= 1 || mazeWalls.Contains((_currX - 1, _currY)))
        {
            Console.WriteLine($"Left fail; X{_currX} Y{_currY}");
            throw new InvalidOperationException("Can't go that way!");
        }
        else
        {
            _currX--;
            Console.WriteLine($"Left good; X{_currX} Y{_currY}");
        }
    }

    /// <summary>
    /// Check to see if you can move right.  If you can, then move.  If you
    /// can't move, throw an InvalidOperationException with the message "Can't go that way!".
    /// </summary>
    public void MoveRight()
    {
        if (_currX >= 6 || mazeWalls.Contains((_currX + 1, _currY)))
        {
            Console.WriteLine($"right fail; X{_currX} Y{_currY}");
            throw new InvalidOperationException("Can't go that way!");
        }
        else
        {
            _currX++;
            Console.WriteLine($"right good; X{_currX} Y{_currY}");
        }
    }

    /// <summary>
    /// Check to see if you can move up.  If you can, then move.  If you
    /// can't move, throw an InvalidOperationException with the message "Can't go that way!".
    /// </summary>
    public void MoveUp()
    {
        
        if (_currY <= 1 || mazeWalls.Contains((_currX, _currY - 1)))
        {
            Console.WriteLine($"Up fail; X{_currX} Y{_currY}");
            throw new InvalidOperationException("Can't go that way!");
        }
        else
        {
            _currY--;
            Console.WriteLine($"Up Good; X{_currX} Y{_currY}");
        }
    }

    /// <summary>
    /// Check to see if you can move down.  If you can, then move.  If you
    /// can't move, throw an InvalidOperationException with the message "Can't go that way!".
    /// </summary>
    public void MoveDown()
    {
        
        if (_currY >= 6 || mazeWalls.Contains((_currX, _currY + 1)))
        {
            Console.WriteLine($"down fail; X{_currX} Y{_currY}");
            throw new InvalidOperationException("Can't go that way!");
        }
        else
        {
            _currY++;
            Console.WriteLine($"down good; X{_currX} Y{_currY}");
        }
    }

    public string GetStatus()
    {
        return $"Current location (x={_currX}, y={_currY})";
    }
}