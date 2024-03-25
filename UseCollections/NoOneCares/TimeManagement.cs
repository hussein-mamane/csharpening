using System.Runtime.InteropServices.JavaScript;

namespace UseCollections.NoOneCares;

public static class TimeManagement
{
    public static void RunCode()
    {
        var dateOnly = new DateOnly(2022,12,15);
        
        Console.WriteLine(dateOnly.DayOfWeek); //Wednesday
        var today = DateOnly.FromDateTime(DateTime.Now);
        Console.WriteLine(today);
        Console.WriteLine(DateTime.Today.Date); // still keeps time 00:00:00
        TimeSpan timeSpan = new TimeSpan(0, 5,0,0);//will be used as offset
        var yesterdayByNow = DateTime.UtcNow - timeSpan;
        Console.WriteLine(yesterdayByNow);//Now and UtcNow give a good result, why ?
        Console.WriteLine(yesterdayByNow.Kind); //Local or Utc
        Console.WriteLine(yesterdayByNow.TimeOfDay);//with Time passed since Midnight i.e 13:16:42.9917694
        Console.Beep();
        /*DateTime aTime = new DateTime();//01/01/0001 00:00:00
        Console.WriteLine(aTime);*/

        // var someTime = new JSType.Date();
        var timeOnly = new TimeOnly(09,24,45);
        // Offset must be within plus or minus 14 hours. (Parameter 'offset')
        DateTimeOffset someOffsetTime = new DateTimeOffset(today,timeOnly,timeSpan);//25/03/2024 09:24:45 +05:00, idk a usage ?
        Console.WriteLine(someOffsetTime);
        // Console.ReadKey();

    }
}