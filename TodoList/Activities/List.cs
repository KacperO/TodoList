using Persistance;
using Persistance.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using TodoList.Common;
using NotiSharp;

namespace TodoList.Activities
{
    public class List
    {
        /// <summary>
        /// Method load activites with choosen status and returns as a list of created component - ActivityTab
        /// </summary>
        /// <param name="status"></param>
        /// <param name="dateTime">Optional parameter, if contains value - returns activities only with specific date</param>
        /// <returns></returns>
        public List<GroupBox> Load(Status status, DateTime? dateTime = null)
        {
            List<GroupBox> activitiesList = new List<GroupBox>();

            using (DataContext dataContext = new DataContext())
            {
                int positionY = 1;

                foreach(var activity in Activities(status, dateTime))
                {

                    ActivityTab activityTab = new ActivityTab(activity);
                    
                    activityTab.Location = new Point(activityTab.Location.X, positionY);
                    positionY = activityTab.Location.Y + activityTab.Height;


                    activitiesList.Add(activityTab);
                }
            }

            return activitiesList;
        }

        private List<Activity> Activities(Status status, DateTime? dateTime = null)
        {
            
            using (DataContext dataContext = new DataContext())
            {
                var activities = dataContext.Activities.Where(x => x.Status == status).ToList();

                if (dateTime != null)
                    activities = activities.Where(x => x.Date == dateTime).ToList();

                return activities;
            }
        }

        public List<Popup> SoonActivitesNotification()
        {
            List<Popup> notifications = new List<Popup>();

            foreach (var activity in Activities(Status.DoZrobienia, DateTime.Today.AddDays(1).Date))
            {
                Popup popup = new Popup();
                popup.SetText($"Zblizajaca sie aktywnosc ({activity.Date.ToString("dd/MM/yyyy")}) - {activity.Title}");

                notifications.Add(popup);
            }

            return notifications;    
        }
    }
}
