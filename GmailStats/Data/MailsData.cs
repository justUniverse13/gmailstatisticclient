using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GmailStatsClient.Data
{
    public class MailsData
    {
        public PartOfDay Part { get; set; }
        public int Amount { get; set; }
    }

    public enum PartOfDay
    {
        Morning = 0,
        Afternoon = 1,
        Evening = 2
    }
}
