using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Library
{
    /// <summary>
    /// <see cref="BaseAttachProperty{Parnet, Property}"/> Makes You Create New Attached Properties With Less Fort
    /// </summary>
    /// <typeparam name="Parnet">Owner Class</typeparam>
    /// <typeparam name="Property">Type Of Our Property</typeparam>
    public abstract class BaseAttachProperty<Parnet, Property>
        where Parnet : BaseAttachProperty<Parnet, Property>, new()
    {
        #region Public Property
        /// <summary>
        /// An Instanse Of This Class To Access To
        /// Author Static Feilds
        /// </summary>
        public static BaseAttachProperty<Parnet, Property> Instance { get; private set; } = new Parnet();
        #endregion

        #region Attached Property
        /// <summary>
        /// Gets Value Of The Attched Property
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static Property GetValue(DependencyObject obj) => (Property)obj.GetValue(ValueProperty); 

        /// <summary>
        /// Sets The Attached Property And Change His Old Value  
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="value"></param>
        public static void SetValue(DependencyObject obj, Property value) => obj.SetValue(ValueProperty, value); 

        /// <summary>
        /// The Actual Attched Property
        /// </summary>
        public static readonly DependencyProperty ValueProperty =
            DependencyProperty.RegisterAttached("Value", typeof(Property), typeof(BaseAttachProperty<Parnet, Property>), new PropertyMetadata(new PropertyChangedCallback(OnValueChanged)));
        #endregion

        #region Event Method
        /// <summary>
        /// CallBack Methods Fird Whene The Property Has been Modified
        /// </summary>
        /// <param name="d"></param>
        /// <param name="e"></param>
        private static void OnValueChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            // Fire Your Own Logic
            Instance.OnPropertyChange(d, e);
        }

        /// <summary>
        /// Overide This To Apply New Events To The Propert Change Time 
        /// </summary>
        /// <param name="d"></param>
        /// <param name="e"></param>
        public virtual void OnPropertyChange(DependencyObject d, DependencyPropertyChangedEventArgs e) { } 
        #endregion

    }
}
