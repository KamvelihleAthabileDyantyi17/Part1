using System.Windows;
using System.Windows.Controls;
using Part1;

namespace ClaimsSystem  // Changed from Part1
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void NavButton_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button button && button.Tag is string pageName)
            {
                switch (pageName)
                {
                    case "DashboardPage":
                        MainFrame.Navigate(new DashboardPage());  // Changed to DashboardPage
                        break;
                    case "SubmitClaimPage":
                        MainFrame.Navigate(new SubmitClaimPage());
                        break;
                    case "AdminPage":
                        MainFrame.Navigate(new AdminPage());  // Changed to AdminPage
                        break;
                }
            }
        }

        public void SetUserRole(string role)
        {
            // Make sure these buttons exist in your XAML with these exact names
            SubmitClaimButton.Visibility = role == "Teacher" ? Visibility.Visible : Visibility.Collapsed;
            AdminButton.Visibility = role == "Admin" ? Visibility.Visible : Visibility.Collapsed;
        }
    }
}