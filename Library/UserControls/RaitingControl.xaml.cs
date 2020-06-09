using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Library
{
    /// <summary>
    /// RaitinCommand Ui Class
    /// Contain All The Methods And Properties 
    /// That The User RaitingContol Needs To Work Proffectly
    /// </summary>
    public partial class RaitingControl : UserControl
    {
        
        #region Pupblic Properties
        /// <summary>
        /// RatingLavel Property Controls 
        /// The Satrs Number Should Be Filled
        /// Or UnFilled
        /// </summary>
        public int RatingLavel
        {
            get { return (int)GetValue(RatingLavelProperty); }
            set { SetValue(RatingLavelProperty, value); }
        }

        // Using a DependencyProperty as the backing store for RatingLavel.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty RatingLavelProperty =
            DependencyProperty.Register("RatingLavel", typeof(int), typeof(RaitingControl), new PropertyMetadata(0)); 
        #endregion

        #region Costructor
        /// <summary>
        /// Default Constructor
        /// </summary>
        public RaitingControl()
        {
            InitializeComponent();
        }
        #endregion

        #region Private Helper Methods
        /// <summary>
        /// Methods To Fill The Stars Properly
        /// </summary>
        private void Rating1()
        {
            star1.Fill = new SolidColorBrush(Colors.Yellow);
            star2.Fill = new SolidColorBrush(Colors.Transparent);
            star3.Fill = new SolidColorBrush(Colors.Transparent);
            star4.Fill = new SolidColorBrush(Colors.Transparent);
            star5.Fill = new SolidColorBrush(Colors.Transparent);
        }

        private void Rating2()
        {
            star1.Fill = new SolidColorBrush(Colors.Yellow);
            star2.Fill = new SolidColorBrush(Colors.Yellow);
            star3.Fill = new SolidColorBrush(Colors.Transparent);
            star4.Fill = new SolidColorBrush(Colors.Transparent);
            star5.Fill = new SolidColorBrush(Colors.Transparent);
        }

        private void Rating3()
        {
            star1.Fill = new SolidColorBrush(Colors.Yellow);
            star2.Fill = new SolidColorBrush(Colors.Yellow);
            star3.Fill = new SolidColorBrush(Colors.Yellow);
            star4.Fill = new SolidColorBrush(Colors.Transparent);
            star5.Fill = new SolidColorBrush(Colors.Transparent);
        }

        private void Rating4()
        {
            star1.Fill = new SolidColorBrush(Colors.Yellow);
            star2.Fill = new SolidColorBrush(Colors.Yellow);
            star3.Fill = new SolidColorBrush(Colors.Yellow);
            star4.Fill = new SolidColorBrush(Colors.Yellow);
            star5.Fill = new SolidColorBrush(Colors.Transparent);
        }

        private void Rating5()
        {
            star1.Fill = new SolidColorBrush(Colors.Yellow);
            star2.Fill = new SolidColorBrush(Colors.Yellow);
            star3.Fill = new SolidColorBrush(Colors.Yellow);
            star4.Fill = new SolidColorBrush(Colors.Yellow);
            star5.Fill = new SolidColorBrush(Colors.Yellow);
        }
        #endregion

        #region Events
        /// <summary>
        /// the userContorl Loaded Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            // check for selected Items 
            if (RatingLavel == 0)
            {
                this.Visibility = Visibility.Hidden;
                return;
            }
            Visibility = Visibility.Visible;

            // apply the fill for all stars
            switch (RatingLavel)
            {
                case 1:
                    Rating1();
                    break;
                case 2:
                    Rating2();
                    break;
                case 3:
                    Rating3();
                    break;
                case 4:
                    Rating4();
                    break;
                case 5:
                    Rating5();
                    break;
            }

        } 
        #endregion
    }
}
