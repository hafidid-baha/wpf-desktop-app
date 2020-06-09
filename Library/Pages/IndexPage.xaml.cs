using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Library
{
    /// <summary>
    /// Interaction logic for IndexPage.xaml
    /// </summary>
    public partial class IndexPage : BasePage
    {
        public IndexPage()
        {
            InitializeComponent();

            //override the load animation
            LoadAnimation = PagesAnimationType.ScrollAndFadeInFromButtom;
            // create some items to test the xaml slider
            BooksCtaegoriesModel Categories = new BooksCtaegoriesModel(new List<BookCategoryItemModel>())
            {
                Items = new List<BookCategoryItemModel>()
                {
                    new BookCategoryItemModel("learn.jpg","ahmed"),
                    new BookCategoryItemModel("learn 2.png","Ousama"),
                    new BookCategoryItemModel("learn 3.jpg","said"),
                    new BookCategoryItemModel("learn 4.jpg","jalal"),
                    new BookCategoryItemModel("learn 5.jpg","mouhammed"),
                    new BookCategoryItemModel("learn 6.jpg","ahmed"),
                    new BookCategoryItemModel("learn 7.jpg","rabi3"),
                    new BookCategoryItemModel("learn 2.png","khalid"),
                    new BookCategoryItemModel("learn 3.jpg","raid"),
                    new BookCategoryItemModel("learn 5.jpg","rida"),
                    new BookCategoryItemModel("learn.jpg","ahmed"),
                    new BookCategoryItemModel("learn 2.png","Ousama"),
                    new BookCategoryItemModel("learn 3.jpg","said"),
                    new BookCategoryItemModel("learn 4.jpg","jalal"),
                    new BookCategoryItemModel("learn 5.jpg","mouhammed"),
                    new BookCategoryItemModel("learn 6.jpg","ahmed"),
                    new BookCategoryItemModel("learn 7.jpg","rabi3"),
                    new BookCategoryItemModel("learn 2.png","khalid"),
                    new BookCategoryItemModel("learn 3.jpg","raid"),
                    new BookCategoryItemModel("learn 5.jpg","rida")
                }
            };

            // add the items to the listbox items
            BooksCteagories.ItemsSource = Categories.Items;


        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            SliderScroller.PageRight();

        }

        private async void Button_Click_1(object sender, RoutedEventArgs e)
        {
            SliderScroller.PageLeft();
        }
    }
}
