using System;
using System.Windows;
using System.Windows.Controls;
namespace Library
{

    public class MonitorPasswordProperty : BaseAttachProperty<MonitorPasswordProperty, bool>
    {
        public override void OnPropertyChange(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            PasswordBox passwordbox = (d as PasswordBox);
            if (passwordbox == null)
                return;

            passwordbox.PasswordChanged -= Passwordbox_PasswordChanged;

            if ((bool)e.NewValue)
            {
                passwordbox.PasswordChanged += Passwordbox_PasswordChanged;
            }

        }

        private void Passwordbox_PasswordChanged(object sender, RoutedEventArgs e)
        {
            HasTextProperty.SetValue(sender as PasswordBox, (sender as PasswordBox).SecurePassword.Length > 0);
        }
    }

    public class HasTextProperty : BaseAttachProperty<HasTextProperty, bool> { }


    
}
