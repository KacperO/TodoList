namespace TodoList
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelTodoList = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxTitle = new System.Windows.Forms.TextBox();
            this.dateTimePickerAddActivity = new System.Windows.Forms.DateTimePicker();
            this.btnAddNewActivity = new System.Windows.Forms.Button();
            this.CalendarFilter = new System.Windows.Forms.MonthCalendar();
            this.txtBoxDescription = new System.Windows.Forms.TextBox();
            this.panelDetails = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.panelDoneList = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnRestore = new System.Windows.Forms.Button();
            this.panelEdit = new System.Windows.Forms.Panel();
            this.btnSaveEdit = new System.Windows.Forms.Button();
            this.dateTimePickerEditActivity = new System.Windows.Forms.DateTimePicker();
            this.txtBoxDescriptionEdit = new System.Windows.Forms.TextBox();
            this.txtBoxTitleEdit = new System.Windows.Forms.TextBox();
            this.panelEdit.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTodoList
            // 
            this.panelTodoList.AutoScroll = true;
            this.panelTodoList.BackColor = System.Drawing.SystemColors.Control;
            this.panelTodoList.Location = new System.Drawing.Point(359, 49);
            this.panelTodoList.Name = "panelTodoList";
            this.panelTodoList.Size = new System.Drawing.Size(239, 347);
            this.panelTodoList.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(359, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Do zrobienia";
            // 
            // txtBoxTitle
            // 
            this.txtBoxTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxTitle.Location = new System.Drawing.Point(359, 471);
            this.txtBoxTitle.Name = "txtBoxTitle";
            this.txtBoxTitle.PlaceholderText = "Tytuł";
            this.txtBoxTitle.Size = new System.Drawing.Size(239, 23);
            this.txtBoxTitle.TabIndex = 5;
            // 
            // dateTimePickerAddActivity
            // 
            this.dateTimePickerAddActivity.Location = new System.Drawing.Point(359, 442);
            this.dateTimePickerAddActivity.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerAddActivity.Name = "dateTimePickerAddActivity";
            this.dateTimePickerAddActivity.Size = new System.Drawing.Size(239, 23);
            this.dateTimePickerAddActivity.TabIndex = 6;
            // 
            // btnAddNewActivity
            // 
            this.btnAddNewActivity.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAddNewActivity.FlatAppearance.BorderSize = 0;
            this.btnAddNewActivity.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAddNewActivity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewActivity.Location = new System.Drawing.Point(359, 402);
            this.btnAddNewActivity.Name = "btnAddNewActivity";
            this.btnAddNewActivity.Size = new System.Drawing.Size(239, 34);
            this.btnAddNewActivity.TabIndex = 7;
            this.btnAddNewActivity.Text = "Dodaj";
            this.btnAddNewActivity.UseVisualStyleBackColor = true;
            this.btnAddNewActivity.Click += new System.EventHandler(this.btnAddNewActivity_Click);
            // 
            // CalendarFilter
            // 
            this.CalendarFilter.Location = new System.Drawing.Point(27, 49);
            this.CalendarFilter.Name = "CalendarFilter";
            this.CalendarFilter.TabIndex = 8;
            this.CalendarFilter.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.CalendarFilter_DateChanged);
            // 
            // txtBoxDescription
            // 
            this.txtBoxDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxDescription.Location = new System.Drawing.Point(359, 500);
            this.txtBoxDescription.Multiline = true;
            this.txtBoxDescription.Name = "txtBoxDescription";
            this.txtBoxDescription.PlaceholderText = "Wprowadź krótki opis";
            this.txtBoxDescription.Size = new System.Drawing.Size(239, 53);
            this.txtBoxDescription.TabIndex = 9;
            // 
            // panelDetails
            // 
            this.panelDetails.Location = new System.Drawing.Point(27, 266);
            this.panelDetails.Name = "panelDetails";
            this.panelDetails.Size = new System.Drawing.Size(269, 81);
            this.panelDetails.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(27, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 25);
            this.label3.TabIndex = 13;
            this.label3.Text = "Szczegóły";
            // 
            // btnEdit
            // 
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Location = new System.Drawing.Point(162, 353);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(134, 38);
            this.btnEdit.TabIndex = 0;
            this.btnEdit.Text = "Edytuj";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Location = new System.Drawing.Point(27, 353);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(134, 38);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.Text = "Usuń";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // panelDoneList
            // 
            this.panelDoneList.AutoScroll = true;
            this.panelDoneList.BackColor = System.Drawing.SystemColors.Control;
            this.panelDoneList.Location = new System.Drawing.Point(637, 49);
            this.panelDoneList.Name = "panelDoneList";
            this.panelDoneList.Size = new System.Drawing.Size(239, 347);
            this.panelDoneList.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(640, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Gotowe";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "Kliknij w tytuł aktywności";
            // 
            // btnRestore
            // 
            this.btnRestore.FlatAppearance.BorderSize = 0;
            this.btnRestore.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnRestore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestore.Location = new System.Drawing.Point(308, 60);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(31, 26);
            this.btnRestore.TabIndex = 15;
            this.btnRestore.Text = "R";
            this.btnRestore.UseVisualStyleBackColor = true;
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // panelEdit
            // 
            this.panelEdit.Controls.Add(this.btnSaveEdit);
            this.panelEdit.Controls.Add(this.dateTimePickerEditActivity);
            this.panelEdit.Controls.Add(this.txtBoxDescriptionEdit);
            this.panelEdit.Controls.Add(this.txtBoxTitleEdit);
            this.panelEdit.Location = new System.Drawing.Point(27, 397);
            this.panelEdit.Name = "panelEdit";
            this.panelEdit.Size = new System.Drawing.Size(269, 156);
            this.panelEdit.TabIndex = 16;
            this.panelEdit.Visible = false;
            // 
            // btnSaveEdit
            // 
            this.btnSaveEdit.FlatAppearance.BorderSize = 0;
            this.btnSaveEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSaveEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveEdit.Location = new System.Drawing.Point(12, 5);
            this.btnSaveEdit.Name = "btnSaveEdit";
            this.btnSaveEdit.Size = new System.Drawing.Size(239, 33);
            this.btnSaveEdit.TabIndex = 10;
            this.btnSaveEdit.Text = "Zapisz";
            this.btnSaveEdit.UseVisualStyleBackColor = true;
            this.btnSaveEdit.Click += new System.EventHandler(this.btnSaveEdit_Click);
            // 
            // dateTimePickerEditActivity
            // 
            this.dateTimePickerEditActivity.Location = new System.Drawing.Point(12, 45);
            this.dateTimePickerEditActivity.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerEditActivity.Name = "dateTimePickerEditActivity";
            this.dateTimePickerEditActivity.Size = new System.Drawing.Size(239, 23);
            this.dateTimePickerEditActivity.TabIndex = 6;
            // 
            // txtBoxDescriptionEdit
            // 
            this.txtBoxDescriptionEdit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxDescriptionEdit.Location = new System.Drawing.Point(12, 103);
            this.txtBoxDescriptionEdit.Multiline = true;
            this.txtBoxDescriptionEdit.Name = "txtBoxDescriptionEdit";
            this.txtBoxDescriptionEdit.PlaceholderText = "Wprowadź krótki opis";
            this.txtBoxDescriptionEdit.Size = new System.Drawing.Size(239, 53);
            this.txtBoxDescriptionEdit.TabIndex = 9;
            // 
            // txtBoxTitleEdit
            // 
            this.txtBoxTitleEdit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxTitleEdit.Location = new System.Drawing.Point(12, 74);
            this.txtBoxTitleEdit.Name = "txtBoxTitleEdit";
            this.txtBoxTitleEdit.PlaceholderText = "Tytuł";
            this.txtBoxTitleEdit.Size = new System.Drawing.Size(239, 23);
            this.txtBoxTitleEdit.TabIndex = 5;
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(914, 593);
            this.Controls.Add(this.panelEdit);
            this.Controls.Add(this.btnRestore);
            this.Controls.Add(this.panelDetails);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panelDoneList);
            this.Controls.Add(this.CalendarFilter);
            this.Controls.Add(this.txtBoxDescription);
            this.Controls.Add(this.txtBoxTitle);
            this.Controls.Add(this.panelTodoList);
            this.Controls.Add(this.dateTimePickerAddActivity);
            this.Controls.Add(this.btnAddNewActivity);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Todo List";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panelEdit.ResumeLayout(false);
            this.panelEdit.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panelTodoList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxTitle;
        private System.Windows.Forms.DateTimePicker dateTimePickerAddActivity;
        private System.Windows.Forms.Button btnAddNewActivity;
        private System.Windows.Forms.MonthCalendar CalendarFilter;
        private System.Windows.Forms.TextBox txtBoxDescription;
        private System.Windows.Forms.Panel panelDetails;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Panel panelDoneList;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnRestore;
        private System.Windows.Forms.Panel panelEdit;
        private System.Windows.Forms.DateTimePicker dateTimePickerEditActivity;
        private System.Windows.Forms.TextBox txtBoxDescriptionEdit;
        private System.Windows.Forms.TextBox txtBoxTitleEdit;
        private System.Windows.Forms.Button btnSaveEdit;
    }
}

