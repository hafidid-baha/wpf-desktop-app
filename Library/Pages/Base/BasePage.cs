using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Animation;

namespace Library
{
    public class BasePage:Page
    {
        #region Public Properties
        /// <summary>
        /// load Animation To Be Applayed To This Page Whene The Load Event Is Triggered
        /// </summary>
        public PagesAnimationType LoadAnimation { get; set; } = PagesAnimationType.ScrollAndFadeInFromRigth;
        /// <summary>
        /// Unload Animation To Be Applayed to This Page Whene The Unload Event Is Triggered
        /// </summary>
        public PagesAnimationType UnloadAnimation { get; set; } = PagesAnimationType.ScrollAndFadeOutFromLeft;


        #endregion

        #region Constructor
        public BasePage()
        {
            // Make Your Page Invisible
            this.Visibility = Visibility.Collapsed;

            // the Load Event
            this.Loaded += BasePage_Loaded;
        }


        #endregion

        #region Events
        private async void BasePage_Loaded(object sender, RoutedEventArgs e)
        {
            this.AnimateIn();
        }
        #endregion

    }
}
