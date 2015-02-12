using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace week4_day3_paired.Models
{
    public abstract class WorkItem
    {
        public string Title { get; set; }
        public DateTime DateCreated { get; set; }

        public string Priority { get; set; }

        public WorkItem(string title, DateTime dateCreated, string priority)
        {
            Title = title;
            DateCreated = dateCreated;
            Priority = priority;

        }
/*
        public enum CharacterType
        { 
            Low, //0
            Medium, //1
            High //2
        } 
 */ 

    }
}