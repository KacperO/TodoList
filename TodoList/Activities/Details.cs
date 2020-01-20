using Persistance;
using Persistance.Models;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using TodoList.Common;

namespace TodoList.Activities
{
    public static class Details
    {
        public static Panel panel;

        /// <summary>
        /// Creates new instance of clicked activity and attach it to panel with details
        /// </summary>
        /// <param name="activity"></param>
        public static void showDetails(Activity activity)
        {
            ActivityTab details = new ActivityTab(activity);

            details.AddContent(activity.Description, positionY: 45);

            details.Dock = DockStyle.Fill;
            details.Location = new Point(1, 1);
            details.Enabled = false;
            

            panel.Controls.Clear();
            panel.Controls.Add(details);
        }

        public static Activity GetActivity(int id, out Exception exception)
        {
            exception = null;

            try
            {
                using (DataContext dataContext = new DataContext())
                {
                    return dataContext.Activities.SingleOrDefault(x => x.Id == id);
                }

            } catch (Exception ex)
            {
                exception = ex;

                return null;
            }
            
        }
    }
}
