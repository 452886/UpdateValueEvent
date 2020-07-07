using System;
class Program
{
    public static Action<int> myAction;
    public static int myInteger = 0;
    static void Main(string[] args)
    {
        myAction = showUpdateNotification;

        Console.WriteLine("Value before any changes: " + myInteger + "\n");

        UpdateIntEvent(ref myInteger, 5, myAction);
        Console.WriteLine("Value after first change: " + myInteger + "\n");

        UpdateIntEvent(ref myInteger, -10, myAction);
        Console.WriteLine("Value after second change: " + myInteger + "\n");
    }

    public static void UpdateIntEvent(ref int targetVariable, int addedValue, Action<int> pAction = null)
    {
        targetVariable += addedValue;
        pAction?.Invoke(targetVariable);
    }

    private static void showUpdateNotification(int pValue)
    {
        Console.WriteLine("The value has been updated to: " + pValue);
    }
}
