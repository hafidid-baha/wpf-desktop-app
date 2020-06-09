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
    /// This Class Contain All the Animation That Used To Animate <see cref="BasePage"/>
    /// </summary>
    public static class PageAnimations
    {
        #region Page Animation Helper Methods
        /// <summary>
        /// Animation To Be used On the Page In The OnLoad Event
        /// </summary>
        /// <param name="page"><see cref="BasePage"/> The Page To Be Affected With the Animation</param>
        public static async Task AnimateIn(this BasePage page)
        {
            var storybord = new Storyboard();
            switch (page.LoadAnimation)
            {
                case PagesAnimationType.ScrollAndFadeInFromButtom:
                    await storybord.Animate(ScrollAndFadeInFromButtom(page, 0.5f, 1), page);
                    break;

                case PagesAnimationType.ScrollAndFadeInFromRigth:
                    await storybord.Animate(ScrollAndFadeInFromRight(page, 0.5f, 1), page);
                    break;
            }
        }

        /// <summary>
        /// Animation To Be Used On The Page On The Unload Event
        /// </summary>
        /// <param name="page"><see cref="BasePage"/> The Page To Be Affected With the Animation</param>
        public static async Task AnimateOut(this BasePage page)
        {
            switch (page.UnloadAnimation)
            {
                case PagesAnimationType.ScrollAndFadeOutFromLeft:
                    var storybord = new Storyboard();
                    await storybord.Animate(ScrollAndFadeOutFromLeft(page, 0.2f, 0.2f), page);
                    break;
            }
        }
        #endregion

        #region Load Animation Methods
        /// <summary>
        /// enter form the buttom of the page with fade in animation
        /// </summary>
        /// <param name="page"><see cref="BasePage"/> Instance</param>
        /// <param name="duration">Time That The Animation Should Take To End</param>
        /// <param name="ratio">The DecelerationRatio Between 0 and 1</param>
        /// <returns><see cref="Animatable[]"/></returns>
        public static Animatable[] ScrollAndFadeInFromButtom(BasePage page, float duration, float ratio)
        {
            return new Animatable[] {
                new ThicknessAnimation()
                {
                    From = new Thickness(0, page.WindowWidth, 0, -page.WindowWidth),
                    To = new Thickness(0),
                    Duration = new Duration(TimeSpan.FromSeconds(duration)),
                    DecelerationRatio = ratio

                },
                new DoubleAnimation() {
                    From = 0,
                    To = 1,
                    Duration = new Duration(TimeSpan.FromSeconds(duration)),
                    DecelerationRatio = ratio
                }
                };
        }


        /// <summary>
        /// enter form the Right of the page with fade in animation
        /// </summary>
        /// <param name="page"><see cref="BasePage"/> Instance</param>
        /// <param name="duration">Time That The Animation Should Take To End</param>
        /// <param name="ratio">The DecelerationRatio Between 0 and 1</param>
        /// <returns><see cref="Animatable[]"/></returns>
        public static Animatable[] ScrollAndFadeInFromRight(BasePage page, float duration, float ratio)
        {
            return new Animatable[] {
            new ThicknessAnimation()
            {
                From = new Thickness(page.WindowWidth,0, -page.WindowWidth,0),
                To = new Thickness(0),
                Duration = new Duration(TimeSpan.FromSeconds(duration)),
                DecelerationRatio = ratio

            },
            new DoubleAnimation()
            {
                From = 0,
                To = 1,
                Duration = new Duration(TimeSpan.FromSeconds(duration)),
                DecelerationRatio = ratio
            }

            };
        }
        
        #endregion

        #region UnLoad Methods

        /// <summary>
        /// Leave form the Left of the page with fade in animation
        /// </summary>
        /// <param name="page"><see cref="BasePage"/> Instance</param>
        /// <param name="duration">Time That The Animation Should Take To End</param>
        /// <param name="ratio">The DecelerationRatio Between 0 and 1</param>
        /// <returns><see cref="Animatable[]"/></returns>
        public static Animatable[] ScrollAndFadeOutFromLeft(BasePage page, float duration, float ratio)
        {
            return new Animatable[] {
            new ThicknessAnimation()
            {
                To = new Thickness(-page.WindowWidth,0, page.WindowWidth,0),
                From = new Thickness(0),
                Duration = new Duration(TimeSpan.FromSeconds(duration)),
                DecelerationRatio = ratio

            },
            new DoubleAnimation()
            {
                From = 1,
                To = 0,
                Duration = new Duration(TimeSpan.FromSeconds(duration)),
                DecelerationRatio = ratio
            }

            };
        }

        #endregion
    }
}
