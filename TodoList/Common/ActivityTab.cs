using Persistance.Models;
using System;
using System.Drawing;
using System.Windows.Forms;
using TodoList.Activities;

namespace TodoList.Common
{
    public class ActivityTab : GroupBox
    {
        public Activity activity;
        public ActivityTab(Activity activity)
        {
            this.activity = activity;

            this.Name = activity.Id.ToString();
            this.Height = 55;
            this.Text = activity.Date.ToString("dd/MM/yyyy");
            this.ForeColor = activity.Date < DateTime.Today ? Color.Red : Color.Black;

            AddContent(activity.Title, bold: true);
        }


        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);

            ChangeStatus.Handler(this.activity);
        }


        public void AddContent(string content, int positionY = 23, bool bold = false)
        {
            Label contentLabel = new Label { Text = content };

            contentLabel.AutoSize = true;

            contentLabel.Font = new Font(contentLabel.Font, bold ? FontStyle.Bold : FontStyle.Regular);
            contentLabel.Location = new Point(20, positionY);
            contentLabel.Cursor = Cursors.Hand;

            contentLabel.Click += new EventHandler(this.LabelClick);

            this.Controls.Add(contentLabel);
        }

        protected void LabelClick(object sender, EventArgs e)
        {
            Details.showDetails(activity);
        }
    }
}
