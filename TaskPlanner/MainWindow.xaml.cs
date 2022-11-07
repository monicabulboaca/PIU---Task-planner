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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TaskPlanner
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private TaskPlannerWindow _taskPlannerWindow;
        private string _username;

        public MainWindow()
        {
            InitializeComponent();
            _taskPlannerWindow = new TaskPlannerWindow();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            _taskPlannerWindow.Show();
            _taskPlannerWindow.SetUsername(this._username);
            _taskPlannerWindow.ShowWelcomeUsernameLabel();
        }

        private void usernameInput_TextChanged(object sender, TextChangedEventArgs e)
        {
            _username = this.usernameInput.Text;
        }
    }
}
