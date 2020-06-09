namespace Library
{
    /// <summary>
    /// Class Describes And Contain All The Book Propertys And Methods
    /// </summary>
    public class Book
    {
        #region Public Properties
        /// <summary>
        /// Title Of The Book
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// Author Of The Book
        /// </summary>
        public string Author { get; set; }
        /// <summary>
        /// Isbn Of The Book
        /// </summary>
        public string Isbn { get; set; }
        /// <summary>
        /// Number Of Stars For The Book
        /// </summary>
        public int Rate { get; set; } 
        /// <summary>
        /// The Book cover Image
        /// </summary>
        public string Image { get; set; }
        /// <summary>
        /// The Book Small Description
        /// </summary>
        public string Desc { get; set; }
        #endregion
    }
}
