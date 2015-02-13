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

        public int ID { get; set; }

        public CharacterType type { get; set; }

        public WorkItem(string title, DateTime dateCreated, string priority, int id, CharacterType type)
        {
            Title = title;
            DateCreated = dateCreated;
            Priority = priority;
            ID = id;
            CharacterType = type;
        }

        public WorkItem()
        {

        }

        public enum CharacterType
        { 
            Bug, //0
            TaskTodo, //1
        } 


    }
}