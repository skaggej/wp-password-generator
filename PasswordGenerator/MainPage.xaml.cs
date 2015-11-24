using System;
using System.Windows;
using Microsoft.Phone.Controls;
using Skaggs.Utilities;

namespace PasswordGenerator
{
    public partial class About : PhoneApplicationPage
    {
        public About()
        {
            InitializeComponent();
        }

        private void bGeneratePassword_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                bool? requiresNumber = cbNumber.IsChecked;
                bool? requiresSpecialCharacter = cbSpecialCharacter.IsChecked;
                int minLength = Convert.ToInt32(tbMinimumLength.Text);
                int maxLength = Convert.ToInt32(tbMaximumLength.Text);
                tbPassword.Text = RandomPassword.Generate(minLength, maxLength, requiresNumber.Value, requiresSpecialCharacter.Value);
            }
            catch
            {
                MessageBox.Show("Invalid Number");
                return;
            }
        }

        private void result()
        {
        }
    }
}