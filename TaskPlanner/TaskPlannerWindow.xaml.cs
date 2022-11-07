using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace TaskPlanner
{
    /// <summary>
    /// Interaction logic for TaskPlannerWindow.xaml
    /// </summary>
    public partial class TaskPlannerWindow : Window
    {
        private string _username;

        public TaskPlannerWindow()
        {
            InitializeComponent();
        }

        public void SetUsername(string username)
        {
            _username = username;
        }

        public void ShowWelcomeUsernameLabel()
        {
            this.welcomeUsernameLabel.Content = "Welcome, " + this._username + "!";
        }
    }
}
