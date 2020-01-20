using Persistance;
using System;

namespace TodoList.Activities
{
    public static class Delete
    {
        public static bool Handler(int activityId, out Exception exception)
        {
            exception = null;

            try
            {
                DeleteActivity(activityId, out exception);
                return true;
            }
            catch (Exception ex)
            {
                exception = ex;
                return false;
            }
        }

        private static void DeleteActivity(int activityId, out Exception exception)
        {
            exception = null;
            using (DataContext dataContext = new DataContext())
            {
                var activity = Details.GetActivity(activityId, out exception);

                dataContext.Activities.Remove(activity);

                dataContext.SaveChanges();
            }
        }
    }
}
