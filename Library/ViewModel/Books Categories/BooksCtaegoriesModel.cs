using System.Collections.Generic;

namespace Library
{
    /// <summary>
    /// Class Contains All The Book Categories List To Be Used 
    /// With The Xaml File (The Slider) As Ressource for The Items
    /// </summary>
    public class BooksCtaegoriesModel
    {
        /// <summary>
        /// The List Of <see cref="BookCategoryItem"/>
        /// </summary>
        public List<BookCategoryItemModel> Items { get; set; }

        /// <summary>
        /// The Default Constructor
        /// </summary>
        /// <param name="items">List Of <see cref="BookCategoryItemModel"/> Element </param>
        public BooksCtaegoriesModel(List<BookCategoryItemModel> items)
        {
            Items = items;
        }
    }
}
