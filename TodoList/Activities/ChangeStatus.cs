using Persistance;
using Persistance.Models;
using System.Windows.Forms;
using TodoList.Util;

namespace TodoList.Activities
{
    public static class ChangeStatus
    {
        public static PanelRefresh PanelRefresh;
        public static bool Handler(Activity activity)
        {
            using (DataContext dataContext = new DataContext())
            {
                var newStatus = (activity.Status == Status.DoZrobienia) ? Status.Gotowe : Status.DoZrobienia;
                
                if (activity == null)
                    return false;

                activity.Status = newStatus;

                dataContext.Activities.Update(activity);
                dataContext.SaveChanges();
                    
            }

            PanelRefresh.Refresh();

            return true;
        }
    }
}
