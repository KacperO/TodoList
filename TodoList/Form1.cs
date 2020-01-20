using Microsoft.EntityFrameworkCore;
using Persistance;
using Persistance.Models;
using System;
using System.Linq;
using System.Windows.Forms;
using TodoList.Activities;
using TodoList.Util;

namespace TodoList
{
    public partial class MainForm : Form
    {
        TextBoxValidate validator = new TextBoxValidate();
        PanelRefresh panelRefresh;
        Exception exception;
        public MainForm()
        {
            InitializeComponent();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            Details.panel = panelDetails;

            panelRefresh = new PanelRefresh(panelTodoList, panelDoneList);
            ChangeStatus.PanelRefresh = panelRefresh;

            dateTimePickerAddActivity.MinDate = DateTime.Today;
            dateTimePickerEditActivity.MinDate = DateTime.Today;


            using (var context = new DataContext())
            {
                try
                {
                    context.Database.Migrate();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database problem: " + ex);
                }
            }

            panelRefresh.Refresh();


            List notifications = new List();
            notifications.SoonActivitesNotification().ForEach(x => x.Show());
        }
        private void btnAddNewActivity_Click(object sender, EventArgs e)
        {
            if (validator.Validate(txtBoxTitle) && validator.Validate(txtBoxDescription))
            {
               if ( Add.NewActivity(txtBoxTitle.Text, txtBoxDescription.Text, dateTimePickerAddActivity.Value, panelRefresh) )
                {
                    txtBoxTitle.Text = string.Empty;
                    txtBoxDescription.Text = string.Empty;
                    dateTimePickerAddActivity.Value = DateTime.Today;
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var controls = panelDetails.Controls.Cast<Control>();

            

            if (controls.Any())
            {
                var confirmResult = MessageBox.Show("Jesteś pewien, że chcesz usunąć tą aktywność?",
                                     "Potwierdź",
                                     MessageBoxButtons.YesNo);

                if (confirmResult == DialogResult.Yes)
                {
                    if (Delete.Handler(Convert.ToInt32(controls.First().Name), out exception) && exception == null)
                    {
                        panelDetails.Controls.Clear();
                        panelEdit.Visible = false;

                        panelRefresh.Refresh();
                    }
                    else
                        exception = null;
                }
            }
        }

        private void CalendarFilter_DateChanged(object sender, DateRangeEventArgs e)
        {
            panelRefresh.Refresh(CalendarFilter.SelectionRange.Start);
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            panelRefresh.Refresh(null);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var controls = panelDetails.Controls.Cast<Control>();

            if (controls.Any())
            {
                panelEdit.Visible = !panelEdit.Visible;

                Activity choosenActivity = Details.GetActivity(Convert.ToInt32(controls.First().Name), out exception);

                if (exception == null)
                {
                    txtBoxTitleEdit.Text = choosenActivity.Title;
                    txtBoxDescriptionEdit.Text = choosenActivity.Description;
                    dateTimePickerEditActivity.Value = choosenActivity.Date;
                }
                else
                    exception = null;
            }
        }

        private void btnSaveEdit_Click(object sender, EventArgs e)
        {
            var controls = panelDetails.Controls.Cast<Control>();

            if (validator.Validate(txtBoxTitleEdit) && validator.Validate(txtBoxDescriptionEdit))
            {
                var editedActivity = Edit.EditHandler(Convert.ToInt32(controls.First().Name), txtBoxTitleEdit.Text, txtBoxDescriptionEdit.Text, dateTimePickerEditActivity.Value,out exception);
                
                if (exception == null)
                {
                    panelEdit.Visible = false;
                    panelRefresh.Refresh();
                    Details.showDetails(editedActivity);
                    MessageBox.Show("Pomyślnie edytowano");
                }
                else
                    exception = null;
            }   
        }
    }
}
