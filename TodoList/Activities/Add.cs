using Persistance;
using System;
using Persistance.Models;
using TodoList.Util;

namespace TodoList.Activities
{
    public static class Add
    { 
        public static bool NewActivity(string title, string description, DateTime date, PanelRefresh panelRefresh)
        {
            bool success = false;
            using (DataContext dataContext = new DataContext())
            {
                Activity newActivity = new Activity(
                    title, 
                    description, 
                    date.Date);

                dataContext.Add(newActivity);

                if (dataContext.SaveChanges() > 0)
                    success = true;

                
            }

            panelRefresh.Refresh();

            return success;
        }
    }
}
