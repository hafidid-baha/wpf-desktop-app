namespace Library
{
    /// <summary>
    /// Enum That Detrmine The Page Load And Unload Animation Type
    /// </summary>
    public enum PagesAnimationType
    {
        None = 0,
        /// <summary>
        /// Load Animations Type
        /// </summary>
        ScrollAndFadeInFromRigth =1,
        ScrollAndFadeInFromLeft =2,
        ScrollAndFadeInFromButtom = 3,
        ScrollAndFadeInFromTop = 4,

        /// <summary>
        /// Unload page Animations Type
        /// </summary>
        ScrollAndFadeOutFromRight = 6,
        ScrollAndFadeOutFromLeft = 7,
        ScrollAndFadeOutFromTop = 8,
        ScrollAndFadeOutFromButton = 9
    }
}
