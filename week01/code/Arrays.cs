using Microsoft.VisualBasic;

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

        // creating new fixed array to store multiples. The array size is determined by the int length variable
        var multiples = new double[length];

        /* A loop to multiply the number against i which is a int declared at the beginning. If i is not the 
        correct length i is increased by one and the loop runs again */
        for (int i = 0;  i < length; i++)
        {

            // getting new mulitple by multiplying the number by a new number which is the i variable increased by one
            var result = number * (i + 1);

            // to add multiple to list by using i to decide where the multiple goes
            multiples[i] = result;
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
        /*  variable to get the numbers need to br moved by using GetRange to establish what numbers need to be pulled from where. 
        I used count to determine the length of the array then subtracted the amount from it to find where the index was and then used
        the amount to grab the numbers requested*/
        var numbers = data.GetRange(data.Count - amount, amount);
        // inserting the numbers the variable retrieved into the beginning by using InsertRange to shove them in the beggining
        data.InsertRange(0, numbers);
        // Used RemovedRange as the numbers the variable retrieved were still at the requested location
        data.RemoveRange(data.Count - amount, amount);
    }
}
