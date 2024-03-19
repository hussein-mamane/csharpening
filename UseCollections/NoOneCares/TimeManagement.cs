namespace UseCollections.NoOneCares;

public static class TimeManagement
{
    public static void RunCode()
    {
        var idkWhen = new DateOnly(2022,12,15);
        Console.WriteLine(idkWhen.DayOfWeek); //Wednesday
        var today = DateOnly.FromDateTime(DateTime.Now);
        Console.WriteLine(today);
        Console.WriteLine(DateTime.Today.Date); // still keeps time 00:00:00
        TimeSpan timeSpan = new TimeSpan(1, 0,0,0);
        var yesterdayByNow = DateTime.UtcNow - timeSpan;
        Console.WriteLine(yesterdayByNow);//Now and UtcNow give a good result, why ?
        Console.WriteLine(yesterdayByNow.Kind); //Local or Utc
        Console.WriteLine(yesterdayByNow.TimeOfDay);//with Time passed since Midnight i.e 13:16:42.9917694
        Console.Beep();
        Console.ReadKey();

    }
}