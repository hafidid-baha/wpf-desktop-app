
namespace Library
{
    /// <summary>
    /// Class to Map Each <see cref=""/>
    /// </summary>
    public class BookCategoryItemModel
    {
        /// <summary>
        /// The Constructor With Some Enteries
        /// </summary>
        /// <param name="ItemImgPath">The item Image Path</param>
        /// <param name="itemTitle">The Item Title</param>
        public BookCategoryItemModel(string ItemImgPath,string itemTitle)
        {
            Image = ItemImgPath;
            Title = itemTitle;
        }
        /// <summary>
        /// The Default Constructor
        /// </summary>
        public BookCategoryItemModel()
        {

        }
        /// <summary>
        /// The Image Path Of The Item
        /// </summary>
        public string Image { get; set; }
        /// <summary>
        /// The Title Of the Item
        /// </summary>
        public string Title { get; set; }
    }
}
