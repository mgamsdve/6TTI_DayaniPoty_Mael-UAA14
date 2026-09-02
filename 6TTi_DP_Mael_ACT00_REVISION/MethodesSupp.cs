namespace _6TTi_DP_Mael_ACT00_REVISION;

public static class MethodesSuppupp
{
    public static double LireDouble(string question)
    {
        double resultat;
        do
        {
            Console.WriteLine(question);
        }
        while (!double.TryParse(Console.ReadLine(), out resultat));

        return resultat;
    }

    public static void PersonnaliserConsole(string couleurFondUser, string couleurPoliceUser)
    {
        Console.BackgroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), couleurFondUser, true);
        Console.ForegroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), couleurPoliceUser, true);

        Console.Clear();
    }
}
