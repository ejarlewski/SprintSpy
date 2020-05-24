using SprintSpyApplication.SprintItemsDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tulpep.NotificationWindow;

namespace SprintSpyApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ShowNotificationButton_Click(object sender, EventArgs e)
        {
            ShowNotification();
        }

        private static void ShowNotification()
        {
            PopupNotifier popup = new PopupNotifier();
            popup.Image = Properties.Resources.info;
            popup.TitleText = "SprintSpy spies a change!";
            popup.ContentText = "Someone added a story to the current iteration";
            popup.Popup();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if(FormWindowState.Minimized == WindowState)
            {
                Hide();
            }
        }

        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
        }

        private void restoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
        }

        private void closeApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sprintItemsDataSet.Story' table. You can move, or remove it, as needed.
            this.storyTableAdapter.Fill(this.sprintItemsDataSet.Story);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TestAddRowButton_Click(object sender, EventArgs e)
        {
            int testIdentifier = 2;

            var reader = sprintItemsDataSet.Story.CreateDataReader();

            while (reader.Read())
            {
                if (testIdentifier == reader.GetFieldValue<int>(1))
                {
                    ShowNotification();
                }

            }
        }
    }
}
