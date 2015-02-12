using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace week4_day3_paired.Models
{
    public class TaskTodo : WorkItem
    {
        public string Description { get; set; }

        public TaskTodo(string title, DateTime dateCreated, string priority)
            :base(title, dateCreated, priority)
        {
            Description = Description;
        }
    }
}