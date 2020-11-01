using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Study1.Common
{
    public class PasswordHelp
    {
        public static readonly DependencyProperty PasswordProperty = /*创建依赖属性*/
            DependencyProperty.RegisterAttached("Password", typeof(string), typeof(PasswordHelp),
                new FrameworkPropertyMetadata("", new PropertyChangedCallback(OnPropertyChanged)));

        public static string GetPassword(DependencyObject d)
        {
            return d.GetValue(PasswordProperty).ToString();
        }

        public static void SetPassword(DependencyObject d, string value)
        {
            d.SetValue(PasswordProperty, value);
        }

        public static readonly DependencyProperty AttachProperty = /*创建依赖属性*/
            DependencyProperty.RegisterAttached("Attach", typeof(bool), typeof(PasswordHelp),
                new FrameworkPropertyMetadata(default(bool), new PropertyChangedCallback(OnAttachChanged)));

        public static string GetAttach(DependencyObject d)
        {
            return d.GetValue(AttachProperty).ToString();
        }

        public static void SetAttach(DependencyObject d, string  value)
        {
            d.SetValue(AttachProperty, value);
        }

        static bool _isUpdating = false;

        private static void OnPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            PasswordBox password = d as PasswordBox;
            password.PasswordChanged -= Password_PasswordChanged;
            if (!_isUpdating)
                password.Password = e.NewValue?.ToString();
            password.PasswordChanged += Password_PasswordChanged;
        }

        private static void OnAttachChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            PasswordBox password = d as PasswordBox;
            password.PasswordChanged += Password_PasswordChanged;
        }

        private static void Password_PasswordChanged(object sender, RoutedEventArgs e)
        {
            PasswordBox passwordBox = sender as PasswordBox;
            _isUpdating = true;
            SetPassword(passwordBox, passwordBox.Password);
            _isUpdating = false;
        }

        //public static readonly DependencyProperty PasswordPropert =
        //    DependencyProperty.RegisterAttached("Password", typeof(string), typeof(PasswordHelp),
        //        new FrameworkPropertyMetadata("", new PropertyChangedCallback(OnpropertyChanged)));
        //public static string GetPassword(DependencyObject d)
        //{
        //    return d.GetValue(PasswordPropert).ToString();
        //}
        //public static void SetPassword(DependencyObject d, string value)
        //{
        //    d.SetValue(PasswordPropert, value);
        //}

        //public static readonly DependencyProperty AttachPropert =
        //    DependencyProperty.RegisterAttached("Attach", typeof(bool), typeof(PasswordHelp),
        //        new FrameworkPropertyMetadata("", new PropertyChangedCallback(OnAttached)));
        //public static string GetAttach(DependencyObject d)
        //{
        //    return d.GetValue(AttachPropert).ToString();
        //}
        //public static void SetAttach(DependencyObject d, string value)
        //{
        //    d.SetValue(AttachPropert, value);
        //}

        //static bool _IsUpdating = false;

        //private static void OnpropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        //{

        //    PasswordBox password = d as PasswordBox;
        //    password.PasswordChanged -= password_PasswordChanged;
        //    if (!_IsUpdating)
        //        password.Password = e.NewValue.ToString();
        //    password.PasswordChanged += password_PasswordChanged;
        //}
        //private static void OnAttached(DependencyObject d, DependencyPropertyChangedEventArgs e)
        //{
        //    PasswordBox password = d as PasswordBox;
        //    password.PasswordChanged += password_PasswordChanged;
        //}

        //private static void password_PasswordChanged(object sender, RoutedEventArgs e)
        //{
        //    PasswordBox passwordBox = sender as PasswordBox;
        //    _IsUpdating = true;
        //    SetPassword(passwordBox, passwordBox.Password);
        //    _IsUpdating = false;
        //}
    }
}
