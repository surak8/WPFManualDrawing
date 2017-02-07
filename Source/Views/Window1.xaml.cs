using System.Globalization;
using System.Windows;
using System.Windows.Media;
namespace NSTest {
    public partial class Window1 : Window {
        #region ctor
        public Window1() {
            InitializeComponent();
        }
        #endregion
        #region methods
        void OnReWrite(object sender, RoutedEventArgs e) {
            customElement.Text = "New Text";
        }
        void OnErase(object sender, RoutedEventArgs e) {
            customElement.Text = "";
        }

        #endregion
    }
    public class CustomeElement : FrameworkElement {
        #region fields
        public static readonly DependencyProperty TextProperty;

        #endregion
        #region cctor
        static CustomeElement() {
            TextProperty = DependencyProperty.Register("Text", typeof(string), typeof(CustomeElement),
                new FrameworkPropertyMetadata(
                "Default Text"
                ,
                FrameworkPropertyMetadataOptions.SubPropertiesDoNotAffectRender | FrameworkPropertyMetadataOptions.AffectsRender
                ));
        }
        #endregion
        #region properties
        public string Text {
            get { return (string)GetValue(TextProperty); }
            set { SetValue(TextProperty, value); }
        }

        #endregion
        #region methods
        protected override void OnRender(DrawingContext dc) {
            string text = this.Text;
            FontFamily courier = new FontFamily("Courier New");
            Typeface courierTypeface = new Typeface(courier, FontStyles.Normal, FontWeights.Normal, FontStretches.Normal);

            FormattedText formattedText = new FormattedText(text,
                CultureInfo.CurrentCulture,
                FlowDirection.LeftToRight,
                courierTypeface,
                14.0,
                Brushes.Black);
            dc.DrawText(formattedText, new Point(40, 100));
        }
        #endregion
    }
}
