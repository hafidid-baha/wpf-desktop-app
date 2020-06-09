using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Animation;

namespace Library
{
    /// <summary>
    /// Helper Class Provades The Animate Method
    /// To Animate <see cref="BasePage"/> Instances
    /// </summary>
    public static class StoryBoardHelper
    {
        /// <summary>
        /// Get Your StoryBoard Ready For The Animations
        /// </summary>
        /// <param name="sb">The StoryBoad Object</param>
        /// <param name="animation">Animation Objects <list type="table"><see cref="Animatable"/></list></param>
        /// <param name="page"><see cref="BasePage"/> Instance</param>
        /// <returns></returns>
        public static async Task Animate(this Storyboard sb,Animatable[] animation,BasePage page)
        {

            Storyboard.SetTargetProperty(animation[0], new PropertyPath("Margin"));
            sb.Children.Add(animation[0] as ThicknessAnimation);

            sb.Begin(page);

            Storyboard.SetTargetProperty(animation[1], new PropertyPath("Opacity"));
            sb.Children.Add(animation[1] as DoubleAnimation);

            sb.Begin(page);
            page.Visibility = Visibility.Visible;

            await Task.Delay(TimeSpan.FromSeconds(0.5f));
        } 
    }
}
