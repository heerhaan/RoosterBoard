using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Features.Calendar;

public class CalendarItemListResult
{
    public IEnumerable<CalendarItem> CalendarItems { get; set; } = Enumerable.Empty<CalendarItem>();

    public class CalendarItem
    {
        public long Id { get; set; }
    }
}
