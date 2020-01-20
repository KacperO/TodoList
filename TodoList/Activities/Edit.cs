using Persistance;
using Persistance.Models;
using System;
using System.Windows.Forms;

namespace TodoList.Activities
{
    public static class Edit
    {
        public static Activity EditHandler(int id, string title, string description, DateTime date, out Exception exception)
        {
            exception = null;
            try
            {
                using (DataContext dataContext = new DataContext())
                {
                    var activity = Details.GetActivity(id, out exception);

                    activity.Title = title;
                    activity.Description = description;
                    activity.Date = date.Date;

                    dataContext.Activities.Update(activity);
                    dataContext.SaveChanges();

                    return activity;
                }
            } catch (Exception ex)
            {
                MessageBox.Show("DB problem: " + ex);
                exception = ex;
                return null;
            }
        }
    }
}
