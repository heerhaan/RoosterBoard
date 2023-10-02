using Infrastructure.Data;
using Shared.Features.Calendar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Features.Calendar;

public class List
{
    private readonly ApplicationDbContext _context;

    public List(ApplicationDbContext context)
    {
        _context = context;
    }

    public CalendarItemListResult GetItems()
    {
        return new CalendarItemListResult();
    }
}
