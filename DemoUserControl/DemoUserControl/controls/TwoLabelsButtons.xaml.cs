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

namespace DemoUserControl.controls
{
    /// <summary>
    /// Interaction logic for TwoLabelsButtons.xaml
    /// </summary>
    public partial class TwoLabelsButtons : UserControl
    {
        public TwoLabelsButtons()
        {
            InitializeComponent();
        }

        #region TopText
        public static readonly DependencyProperty TopTextProperty = DependencyProperty.Register("TopText", typeof(String), typeof(TwoLabelsButtons), new PropertyMetadata(string.Empty, ValueChangedTop));
        private static void ValueChangedTop(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var control = d as TwoLabelsButtons;
            control.LabelTop.Content = e.NewValue;
        }
        public string TopText
        {
            get { return (string)GetValue(TopTextProperty); }
            set { SetValue(TopTextProperty, value); }
        }
        #endregion

        # region BottomText
        public static readonly DependencyProperty BottomTextProperty = DependencyProperty.Register("BottomText", typeof(String), typeof(TwoLabelsButtons), new PropertyMetadata(string.Empty, ValueChangedBottom));
        private static void ValueChangedBottom(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var control = d as TwoLabelsButtons;
            control.LabelBottom.Content = e.NewValue;
        }
        public string BottomText
        {
            get { return (string)GetValue(BottomTextProperty); }
            set { SetValue(BottomTextProperty, value); }
        }
        #endregion

        public event EventHandler Click;
        private void button_Click(object sender, RoutedEventArgs e)
        {
            Click?.Invoke(this, e);
        }
    }
}
