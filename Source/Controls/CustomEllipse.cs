using System.Globalization;
using System.Windows;
using System.Windows.Media;
namespace NSTest {
    public class CustomEllipse : FrameworkElement {
        #region methods
        protected override void OnRender(DrawingContext drawingContext) {
            FormattedText ft2;

            base.OnRender(drawingContext);

            FontFamily courier = new FontFamily("Courier New");
            Typeface courierTypeface = new Typeface(courier, FontStyles.Normal, FontWeights.Normal, FontStretches.Normal);
            ft2 = new FormattedText(
                "Test text",
                CultureInfo.CurrentCulture,
                FlowDirection.LeftToRight,
                courierTypeface,
                14.0,
                Brushes.Black);
            drawingContext.DrawText(ft2, new Point(10, 40));
            drawingContext.DrawRectangle(null, new Pen(Brushes.Blue, 1.0), new Rect(10, 40, ft2.WidthIncludingTrailingWhitespace, ft2.Height));
        } 
        #endregion
    }
}