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
        private static int move = 0;

        private TextBox textBox;

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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            move += 10;
            this.btnAddCard.Margin = new Thickness(53, 67 + move, 0, 0);
            this.listGrid.Height += 10;
            this.rectangleList.Height += 10;

            this.textBox = new TextBox();
            textBox.Margin = new Thickness(53, 67, 0, 0);
        }
    }
}
