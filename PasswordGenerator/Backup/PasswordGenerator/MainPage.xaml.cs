using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;
using Skaggs.Utilities;
using Microsoft.Samples.WindowsPhoneCloud.StorageClient;
using Microsoft.Samples.Data.Services.Client;

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
            TableServiceContext tsc = new TableServiceContext("http://wakslab1.table.core.windows.net", new Microsoft.Samples.WindowsPhoneCloud.StorageClient.Credentials.StorageCredentialsAccountAndKey("wakslab1", "a6cxCi2PBeIVJSjvo6g5JvPY7vg804Nu6yXQoNP/LCnc1bJPe6rMqNsCju3el9AdcAaloM9ke474UfTfe+MWKg=="));
            CloudTableClient ctc = new CloudTableClient(tsc);
            ctc.CreateTableIfNotExist("NewTable1", delegate { result(); });
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