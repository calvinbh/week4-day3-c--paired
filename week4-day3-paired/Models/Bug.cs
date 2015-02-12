using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace week4_day3_paired.Models
{
    public class Bug : WorkItem
    {
        public string StepsToReproduce { get; set; }

        public Bug(string Title, DateTime DateCreated, int Priority)
            :base(Title, DateCreated, Priority)
    }
}