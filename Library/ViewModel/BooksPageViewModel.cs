using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Library
{
    /// <summary>
    /// <see cref="BooksPageViewModel"/> Conatin All Properties That The books Page Needs To Work
    /// </summary>
    public class BooksPageViewModel :BaseViewModel
    {
        #region Public Proprties
        /// <summary>
        /// List Of <see cref="Book"/>
        /// </summary>
        public List<Book> Items { get; set; }
        #endregion

        #region Events
        /// <summary>
        /// Command That Fired Whene The ListBox.SelectionChanged
        /// Event Is Fired
        /// </summary>
        public ICommand SelectionChange { get; set; }
        

        #endregion

        #region Costructor
        public BooksPageViewModel()
        {
            
            Items = new List<Book>()
            {
                new Book
                {
                    Title = "The End Of World",
                    Author = "Hafid Id-baha",
                    Isbn = "125-479564654",
                    Rate = 3,
                    Image = "learn 2.png",
                    Desc = "this Is A small Description About This book Just To Test How This Things Works To Make This AppLication Very Famous You Need To Look At The End of The Ages"
                },
                new Book
                {
                    Title = "Eges Of The End",
                    Author = "Hafid Id-baha",
                    Isbn = "125-479564654",
                    Rate = 5,
                    Image = "learn 5.jpg",
                    Desc = "this Is A small Description About This book Just To Test How This Things Works To Make This AppLication Very Famous You Need To Look At The End of The Ages"
                },
                new Book
                {
                    Title = "How To Be Reach",
                    Author = "Hafid Id-baha",
                    Isbn = "125-479564654",
                    Rate = 3,
                    Image = "learn 4.jpg",
                    Desc = "this Is A small Description About This book Just To Test How This Things Works To Make This AppLication Very Famous You Need To Look At The End of The Ages"
                },
                new Book
                {
                    Title = "The Edges",
                    Author = "Hafid Id-baha",
                    Isbn = "125-479564654",
                    Rate = 2,
                    Image = "learn 3.jpg",
                    Desc = "this Is A small Description About This book Just To Test How This Things Works To Make This AppLication Very Famous You Need To Look At The End of The Ages"
                },
            };
            // Instantiat the selectChang Command
            SelectionChange = new RelyCommandWithParameter((obj) => {
                if (obj == null)
                    return;
                // trigger the ui Loaded event of the RaitingControl 
                (obj as RaitingControl).UserControl_Loaded(null, null);
                
            });
        }

       

        #endregion

    }
}
