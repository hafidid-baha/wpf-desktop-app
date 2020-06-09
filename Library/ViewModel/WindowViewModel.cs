using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Library
{
    /// <summary>
    /// The Main Window View Mode
    /// Contain All the Changed Property's In The Main Window
    /// </summary>
    public class WindowViewModel : BaseViewModel
    {
        #region Private Propertys
        /// <summary>
        /// Window Title Height 
        /// </summary>
        private int captionHeight { get; set; } = 60;
        private GridLength gridCaptionHeight { get; set; } = new GridLength(60);
        /// <summary>
        /// Window Corner Raduis
        /// </summary>
        private CornerRadius cornerRaduis { get; set; } = new CornerRadius(10);
        /// <summary>
        /// The Window resizeBorder Thekness
        /// </summary>
        private Thickness resizeBorder { get; set; } = new Thickness(10);
        /// <summary>
        /// the Outer border Pading
        /// </summary>
        private Thickness outerPadding { get; set; } = new Thickness(10);
        /// <summary>
        /// The Main Window Height
        /// </summary>
        private int windowheight { get; set; } = 600;
        /// <summary>
        /// the Main Window Width
        /// </summary>
        private int windowWidth { get; set; } = 920;
        /// <summary>
        /// The main Window Min Height 
        /// </summary>
        private int minWindowHeight { get; set; }
        /// <summary>
        /// The Main Window Min Width
        /// </summary>
        private int minWindowWidth { get; set; }

        #endregion

        #region Public Property
        /// <summary>
        /// The Window Ho Uses These Model View Class
        /// </summary>
        public Window window { get; set; }

        public int CaptionHeight
        {
            get { return captionHeight; }
            set
            {
                if (captionHeight == value)
                    return;

                captionHeight = value;
            }
        }
        public GridLength GridCaptionHeight
        {
            get { return gridCaptionHeight; }
            set {
                if (gridCaptionHeight == value)
                    return;

                gridCaptionHeight = value;
            }
        }

        public Thickness OuterPadding
        {
            get { return outerPadding; }
            set
            {
                if (outerPadding == value)
                {
                    outerPadding = value;
                }
            }
        }

        public Thickness ResizeBorder
        {
            get { return resizeBorder; }
            set
            {
                if (resizeBorder == value)
                    return;

                resizeBorder = value;
            }
        }

        public CornerRadius Corners
        {
            get { return cornerRaduis; }
            set
            {
                if (cornerRaduis == value)
                    return;

                cornerRaduis = value;
            }
        }

        public int WindowWidth {
            get { return windowWidth; }
            set
            {
                if (windowWidth == value)
                    return;
                windowWidth = value;
            } }

        public int WindowHeight
        {
            get { return WindowHeight; }
            set
            {
                if (WindowHeight == value)
                    return;

                WindowHeight = value;
            }
        }

        public int MinWindowHeight
        {
            get { return minWindowHeight; }
            set
            {
                if (minWindowHeight == value)
                    return;
                minWindowHeight = value;
            }
        }

        public int MinWindowWidth
        {
            get { return minWindowWidth; }
            set
            {
                if (minWindowWidth == value)
                    return;
                minWindowWidth = value;
            }
        }

        public ApplicationPages CurrentPage { get; set; } = ApplicationPages.Login;
        #endregion

        #region Constrtuctor

        public WindowViewModel(Window mWind)
        {
            window = mWind;

            // Istantiat Ths Window Command 
            CloseCommand = new RelyCommand(() => { window.Close(); });
            MinumizeCommand = new RelyCommand(() => { window.WindowState = WindowState.Minimized; });
            OnChangePage = new RelyCommandWithParameter((param) => {ChangePage(param);});
        }

        #endregion

        #region Commands
        /// <summary>
        /// The CLose Command That colses The Main Window
        /// </summary>
        public ICommand CloseCommand { get; set; }
        /// <summary>
        /// The Command That Makes The Main Window MinuMized
        /// </summary>
        public ICommand MinumizeCommand { get; set; }
        /// <summary>
        /// Command Used By Toolbar Buttons To Chnage The View Page
        /// </summary>
        public ICommand OnChangePage { get; set; }

        #endregion

        #region Events Methods
        /// <summary>
        /// Change The Current View Page
        /// </summary>
        /// <param name="param">Orderd View Page</param>
        private void ChangePage(object param)
        {
            switch ((string)param)
            {
                case "Login":
                    CurrentPage = ApplicationPages.Login;
                    break;

                case "Index":
                    CurrentPage = ApplicationPages.Index;
                    break;

                case "Books":
                    CurrentPage = ApplicationPages.Books;
                    break;
                default:
                    break;
            }
        } 
        #endregion

    }
}
