// See https://aka.ms/new-console-template for more information



int CalcHowManyDays(string date_str) {
    int res = int.MaxValue;
    DateTime result;
    if (DateTime.TryParse(date_str, out result)) {
        DateTime today = DateTime.Now;
        TimeSpan span = today - result.AddMonths(3);
        Console.WriteLine(span.ToString());
        res = span.Days;
        Console.WriteLine($"The date {date_str} is {res} days away.");
    }

    return res;
}

CalcHowManyDays("1/1 2025");