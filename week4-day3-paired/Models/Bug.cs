using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace week4_day3_paired.Models
{
    public class Bug : WorkItem
    {
        public string StepsToReproduce { get; set; }

        public Bug(string title, DateTime dateCreated, string priority, int id)
            :base(title, dateCreated, priority, id, CharacterType.Bug)
        {
            StepsToReproduce = StepsToReproduce;
        }
    }
}