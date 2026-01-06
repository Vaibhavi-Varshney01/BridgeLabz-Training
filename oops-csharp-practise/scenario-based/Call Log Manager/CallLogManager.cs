class CallLogManager
{
    CallLog[] logs = new CallLog[10];
    int count = 0;

    public void AddCallLog(CallLog log)
    {
        logs[count++] = log;
    }

    public void SearchByKeyword(string keyword)
    {
        foreach (var log in logs)
        {
            if (log != null && log.Message.Contains(keyword))
                Console.WriteLine(log.PhoneNumber + " : " + log.Message);
        }
    }

    public void FilterByTime(DateTime start, DateTime end)
    {
        foreach (var log in logs)
        {
            if (log != null && log.TimeStamp >= start && log.TimeStamp <= end)
                Console.WriteLine(log.PhoneNumber + " : " + log.TimeStamp);
        }
    }
}
