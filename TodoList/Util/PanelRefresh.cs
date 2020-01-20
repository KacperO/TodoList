using Persistance.Models;
using System;
using System.Windows.Forms;
using TodoList.Activities;

namespace TodoList.Util
{
    public class PanelRefresh
    {
        private List activities;

        public Panel panelTodo;
        public Panel panelDone;

        public PanelRefresh(Panel panelTodo, Panel panelDone)
        {
            this.panelTodo = panelTodo;
            this.panelDone = panelDone;

            activities = new List();
        }

        public void Refresh(DateTime? dateTime = null)
        {

            panelTodo.Controls.Clear();
            panelTodo.Controls.AddRange(activities.Load(Status.DoZrobienia, dateTime: dateTime).ToArray());


            panelDone.Controls.Clear();
            panelDone.Controls.AddRange(activities.Load(Status.Gotowe).ToArray());
        }
    }
}
