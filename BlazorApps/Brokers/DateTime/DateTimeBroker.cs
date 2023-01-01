using System;

namespace BlazorApps.Brokers.DateTime
{
    public class DateTimeBroker : IDateTimeBroker
    {
        public DateTimeOffset GetCurrentDateTime()
        {
            return DateTimeOffset.Now;
        }
    }
}
