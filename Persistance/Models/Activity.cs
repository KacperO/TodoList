using System;

namespace Persistance.Models
{
    public class Activity
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public Status Status { get; set; }

        public Activity(string title, string description, DateTime date)
        {
            Title = title;
            Description = description;
            Date = date;
            Status = Status.DoZrobienia;
        }
    }
}
