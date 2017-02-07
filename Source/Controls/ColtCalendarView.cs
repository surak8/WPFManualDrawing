using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Reflection;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace NSTest {
    public class ColtCalendarView : FrameworkElement {

        public ColtCalendarView() {
            Logger.log(MethodBase.GetCurrentMethod());
            BackColor = defaultBackColor;
            PenColor = defaultPenColor;
            defaultDayWidth = defaultdefaultDayWidth;
            maxEventsPerDay = defaultmaxEventsPerDay;
            numWeeksToDisplay = defaultnumWeeksToDisplay;
            this.Font = defaultFont;
            this.fontSize = defaultfontSize;
        }

        // Property-name: BackColor
        // Property-type: Color
        // Owning-class:  ColtCalendarView

        #region support for property BackColor
        /// <summary>dependency property</summary>
        /// <remarks><para></para></remarks>
        /// <seealso name="ev_BackColor"/>
        /// <seealso name="Color"/>
        /// <seealso name="ColtCalendarView"/>
        /// <seealso name="defaultBackColor"/>
        /// <seealso name="whenBackColorChanged"/>
        /// <seealso name="coerceBackColorValue"/>
        public static readonly DependencyProperty dp_BackColor = DependencyProperty.Register(
           "dp_BackColor",
           typeof(Color),
           typeof(ColtCalendarView),
            new FrameworkPropertyMetadata(
                defaultBackColor,
                FrameworkPropertyMetadataOptions.AffectsRender,
                new PropertyChangedCallback(whenBackColorChanged),
                new CoerceValueCallback(coerceBackColorValue)));

        /// <summary>dependency event</summary>
        /// <remarks><para></para></remarks>
        /// <seealso name="dp_BackColor"/>
        /// <seealso name="BackColorChanged"/>
        /// <seealso name="ColtCalendarView"/>
        public static readonly RoutedEvent ev_BackColor = EventManager.RegisterRoutedEvent(
            "BackColorChanged",
             RoutingStrategy.Bubble,
             typeof(RoutedPropertyChangedEventHandler<Color>),
             typeof(ColtCalendarView));

        /// <summary>forward a new value to the control, when changed in the Property window.</summary>
        /// <remarks><para></para></remarks>
        /// <seealso name="ColtCalendarView"/>
        /// <seealso name="ColtCalendarView.onBackColorValueChanged"/>
        static void whenBackColorChanged(DependencyObject d, DependencyPropertyChangedEventArgs e) {
            RoutedPropertyChangedEventArgs<Color> e2 = new RoutedPropertyChangedEventArgs<Color>(
                (Color) e.OldValue,
                (Color) e.NewValue, ev_BackColor);
            ((ColtCalendarView) d).onBackColorValueChanged(e2);
        }

        /// <summary>An event-handler to connect</summary>
        /// <remarks><para></para></remarks>
        /// <seealso name="ev_BackColor"/>
        public event RoutedPropertyChangedEventHandler<Color> BackColorChanged {
            add { AddHandler(ev_BackColor, value); }
            remove { RemoveHandler(ev_BackColor, value); }
        }

        /// <summary>An event-handler to connect</summary>
        /// <remarks><para></para></remarks>
        protected virtual void onBackColorValueChanged(RoutedPropertyChangedEventArgs<Color> args) {
            RaiseEvent(args);
        }

        /// <summary>Attempt to convert a value into the required property-type (Color).</summary>
        /// <remarks><para></para></remarks>
        static object coerceBackColorValue(DependencyObject d, object baseValue) {
            return (Color) baseValue;
        }

        /// <summary>The default-value to be applied to BackColor, through dp_BackColor.</summary>
        /// <remarks><para></para></remarks>
        static Color defaultBackColor = Colors.Transparent;

        /// <summary>The property being exposed to the outside world.</summary>
        /// <remarks><para></para></remarks>
        [Description("description of BackColor [Color]"), Category("Appearance")]
        public Color BackColor {
            get { return (Color) GetValue(dp_BackColor); }
            set { SetValue(dp_BackColor, value); }
        }
        #endregion support for property BackColor

        // Property-name: PenColor
        // Property-type: Color
        // Owning-class:  ColtCalendarView
        #region support for property PenColor
        /// <summary>dependency property</summary>
        /// <remarks><para></para></remarks>
        /// <seealso name="ev_PenColor"/>
        /// <seealso name="Color"/>
        /// <seealso name="ColtCalendarView"/>
        /// <seealso name="defaultPenColor"/>
        /// <seealso name="whenPenColorChanged"/>
        /// <seealso name="coercePenColorValue"/>
        public static readonly DependencyProperty dp_PenColor = DependencyProperty.Register(
           "dp_PenColor",
           typeof(Color),
           typeof(ColtCalendarView),
            new FrameworkPropertyMetadata(
                defaultPenColor,
                FrameworkPropertyMetadataOptions.AffectsRender,
                new PropertyChangedCallback(whenPenColorChanged),
                new CoerceValueCallback(coercePenColorValue)));

        /// <summary>dependency event</summary>
        /// <remarks><para></para></remarks>
        /// <seealso name="dp_PenColor"/>
        /// <seealso name="PenColorChanged"/>
        /// <seealso name="ColtCalendarView"/>
        public static readonly RoutedEvent ev_PenColor = EventManager.RegisterRoutedEvent(
            "PenColorChanged",
             RoutingStrategy.Bubble,
             typeof(RoutedPropertyChangedEventHandler<Color>),
             typeof(ColtCalendarView));

        /// <summary>forward a new value to the control, when changed in the Property window.</summary>
        /// <remarks><para></para></remarks>
        /// <seealso name="ColtCalendarView"/>
        /// <seealso name="ColtCalendarView.onPenColorValueChanged"/>
        static void whenPenColorChanged(DependencyObject d, DependencyPropertyChangedEventArgs e) {
            RoutedPropertyChangedEventArgs<Color> e2 = new RoutedPropertyChangedEventArgs<Color>(
                (Color) e.OldValue,
                (Color) e.NewValue, ev_PenColor);
            ((ColtCalendarView) d).onPenColorValueChanged(e2);
        }

        /// <summary>An event-handler to connect</summary>
        /// <remarks><para></para></remarks>
        /// <seealso name="ev_PenColor"/>
        public event RoutedPropertyChangedEventHandler<Color> PenColorChanged {
            add { AddHandler(ev_PenColor, value); }
            remove { RemoveHandler(ev_PenColor, value); }
        }

        /// <summary>An event-handler to connect</summary>
        /// <remarks><para></para></remarks>
        protected virtual void onPenColorValueChanged(RoutedPropertyChangedEventArgs<Color> args) {
            RaiseEvent(args);
        }

        /// <summary>Attempt to convert a value into the required property-type (Color).</summary>
        /// <remarks><para></para></remarks>
        static object coercePenColorValue(DependencyObject d, object baseValue) {
            return (Color) baseValue;
        }

        /// <summary>The default-value to be applied to PenColor, through dp_PenColor.</summary>
        /// <remarks><para></para></remarks>
        static Color defaultPenColor = Colors.Black;

        /// <summary>The property being exposed to the outside world.</summary>
        /// <remarks><para></para></remarks>
        [Description("description of PenColor [Color]"), Category("Appearance")]
        public Color PenColor {
            get {
                return (Color) GetValue(dp_PenColor);
            }
            set { SetValue(dp_PenColor, value); }
        }
        #endregion support for property PenColor

        // Property-name: defaultDayWidth
        // Property-type: int
        // Owning-class:  ColtCalendarView
        #region support for property defaultDayWidth
        /// <summary>dependency property</summary>
        /// <remarks><para></para></remarks>
        /// <seealso name="ev_defaultDayWidth"/>
        /// <seealso name="int"/>
        /// <seealso name="ColtCalendarView"/>
        /// <seealso name="defaultdefaultDayWidth"/>
        /// <seealso name="whendefaultDayWidthChanged"/>
        /// <seealso name="coercedefaultDayWidthValue"/>
        public static readonly DependencyProperty dp_defaultDayWidth = DependencyProperty.Register(
           "dp_defaultDayWidth",
           typeof(int),
           typeof(ColtCalendarView),
            new FrameworkPropertyMetadata(
                defaultdefaultDayWidth,
                FrameworkPropertyMetadataOptions.AffectsRender,
                new PropertyChangedCallback(whendefaultDayWidthChanged),
                new CoerceValueCallback(coercedefaultDayWidthValue)));

        /// <summary>dependency event</summary>
        /// <remarks><para></para></remarks>
        /// <seealso name="dp_defaultDayWidth"/>
        /// <seealso name="defaultDayWidthChanged"/>
        /// <seealso name="ColtCalendarView"/>
        public static readonly RoutedEvent ev_defaultDayWidth = EventManager.RegisterRoutedEvent(
            "defaultDayWidthChanged",
             RoutingStrategy.Bubble,
             typeof(RoutedPropertyChangedEventHandler<int>),
             typeof(ColtCalendarView));

        /// <summary>forward a new value to the control, when changed in the Property window.</summary>
        /// <remarks><para></para></remarks>
        /// <seealso name="ColtCalendarView"/>
        /// <seealso name="ColtCalendarView.ondefaultDayWidthValueChanged"/>
        static void whendefaultDayWidthChanged(DependencyObject d, DependencyPropertyChangedEventArgs e) {
            RoutedPropertyChangedEventArgs<int> e2 = new RoutedPropertyChangedEventArgs<int>(
                (int) e.OldValue,
                (int) e.NewValue, ev_defaultDayWidth);
            ((ColtCalendarView) d).ondefaultDayWidthValueChanged(e2);
        }

        /// <summary>An event-handler to connect</summary>
        /// <remarks><para></para></remarks>
        /// <seealso name="ev_defaultDayWidth"/>
        public event RoutedPropertyChangedEventHandler<int> defaultDayWidthChanged {
            add { AddHandler(ev_defaultDayWidth, value); }
            remove { RemoveHandler(ev_defaultDayWidth, value); }
        }

        /// <summary>An event-handler to connect</summary>
        /// <remarks><para></para></remarks>
        protected virtual void ondefaultDayWidthValueChanged(RoutedPropertyChangedEventArgs<int> args) {
            RaiseEvent(args);
        }

        /// <summary>Attempt to convert a value into the required property-type (int).</summary>
        /// <remarks><para></para></remarks>
        static object coercedefaultDayWidthValue(DependencyObject d, object baseValue) {
            return (int) baseValue;
        }

        /// <summary>The default-value to be applied to defaultDayWidth, through dp_defaultDayWidth.</summary>
        /// <remarks><para></para></remarks>
        static int defaultdefaultDayWidth = 20;

        /// <summary>The property being exposed to the outside world.</summary>
        /// <remarks><para></para></remarks>
        [Description("description of defaultDayWidth [int]"), Category("Appearance")]
        public int defaultDayWidth {
            get { return (int) GetValue(dp_defaultDayWidth); }
            set { SetValue(dp_defaultDayWidth, value); }
        }
        #endregion support for property defaultDayWidth

        // Property-name: maxEventsPerDay
        // Property-type: int
        // Owning-class:  ColtCalendarView
        #region support for property maxEventsPerDay
        /// <summary>dependency property</summary>
        /// <remarks><para></para></remarks>
        /// <seealso name="ev_maxEventsPerDay"/>
        /// <seealso name="int"/>
        /// <seealso name="ColtCalendarView"/>
        /// <seealso name="defaultmaxEventsPerDay"/>
        /// <seealso name="whenmaxEventsPerDayChanged"/>
        /// <seealso name="coercemaxEventsPerDayValue"/>
        public static readonly DependencyProperty dp_maxEventsPerDay = DependencyProperty.Register(
           "dp_maxEventsPerDay",
           typeof(int),
           typeof(ColtCalendarView),
            new FrameworkPropertyMetadata(
                defaultmaxEventsPerDay,
                FrameworkPropertyMetadataOptions.AffectsRender,
                new PropertyChangedCallback(whenmaxEventsPerDayChanged),
                new CoerceValueCallback(coercemaxEventsPerDayValue)));

        /// <summary>dependency event</summary>
        /// <remarks><para></para></remarks>
        /// <seealso name="dp_maxEventsPerDay"/>
        /// <seealso name="maxEventsPerDayChanged"/>
        /// <seealso name="ColtCalendarView"/>
        public static readonly RoutedEvent ev_maxEventsPerDay = EventManager.RegisterRoutedEvent(
            "maxEventsPerDayChanged",
             RoutingStrategy.Bubble,
             typeof(RoutedPropertyChangedEventHandler<int>),
             typeof(ColtCalendarView));

        /// <summary>forward a new value to the control, when changed in the Property window.</summary>
        /// <remarks><para></para></remarks>
        /// <seealso name="ColtCalendarView"/>
        /// <seealso name="ColtCalendarView.onmaxEventsPerDayValueChanged"/>
        static void whenmaxEventsPerDayChanged(DependencyObject d, DependencyPropertyChangedEventArgs e) {
            RoutedPropertyChangedEventArgs<int> e2 = new RoutedPropertyChangedEventArgs<int>(
                (int) e.OldValue, (int) e.NewValue, ev_maxEventsPerDay);
            ((ColtCalendarView) d).onmaxEventsPerDayValueChanged(e2);
        }

        /// <summary>An event-handler to connect</summary>
        /// <remarks><para></para></remarks>
        /// <seealso name="ev_maxEventsPerDay"/>
        public event RoutedPropertyChangedEventHandler<int> maxEventsPerDayChanged {
            add { AddHandler(ev_maxEventsPerDay, value); }
            remove { RemoveHandler(ev_maxEventsPerDay, value); }
        }

        /// <summary>An event-handler to connect</summary>
        /// <remarks><para></para></remarks>
        protected virtual void onmaxEventsPerDayValueChanged(RoutedPropertyChangedEventArgs<int> args) {
            RaiseEvent(args);
        }

        /// <summary>Attempt to convert a value into the required property-type (int).</summary>
        /// <remarks><para></para></remarks>
        static object coercemaxEventsPerDayValue(DependencyObject d, object baseValue) {
            return (int) baseValue;
        }

        /// <summary>The default-value to be applied to maxEventsPerDay, through dp_maxEventsPerDay.</summary>
        /// <remarks><para></para></remarks>
        static int defaultmaxEventsPerDay = 3;

        /// <summary>The property being exposed to the outside world.</summary>
        /// <remarks><para></para></remarks>
        [Description("description of maxEventsPerDay [int]"), Category("Appearance")]
        public int maxEventsPerDay {
            get {
                return (int) GetValue(dp_maxEventsPerDay);
            }
            set { SetValue(dp_maxEventsPerDay, value); }
        }
        #endregion support for property maxEventsPerDay

        // Property-name: numWeeksToDisplay
        // Property-type: int
        // Owning-class:  ColtCalendarView
        #region support for property numWeeksToDisplay
        /// <summary>dependency property</summary>
        /// <remarks><para></para></remarks>
        /// <seealso name="ev_numWeeksToDisplay"/>
        /// <seealso name="int"/>
        /// <seealso name="ColtCalendarView"/>
        /// <seealso name="defaultnumWeeksToDisplay"/>
        /// <seealso name="whennumWeeksToDisplayChanged"/>
        /// <seealso name="coercenumWeeksToDisplayValue"/>

        public static readonly DependencyProperty dp_numWeeksToDisplay = DependencyProperty.Register(
           "dp_numWeeksToDisplay",
           typeof(int),
           typeof(ColtCalendarView),
            new FrameworkPropertyMetadata(
                defaultnumWeeksToDisplay,
                FrameworkPropertyMetadataOptions.AffectsRender,
                new PropertyChangedCallback(whennumWeeksToDisplayChanged),
                new CoerceValueCallback(coercenumWeeksToDisplayValue)));

        /// <summary>dependency event</summary>
        /// <remarks><para></para></remarks>
        /// <seealso name="dp_numWeeksToDisplay"/>
        /// <seealso name="numWeeksToDisplayChanged"/>
        /// <seealso name="ColtCalendarView"/>
        public static readonly RoutedEvent ev_numWeeksToDisplay = EventManager.RegisterRoutedEvent(
            "numWeeksToDisplayChanged",
             RoutingStrategy.Bubble,
             typeof(RoutedPropertyChangedEventHandler<int>),
             typeof(ColtCalendarView));

        /// <summary>forward a new value to the control, when changed in the Property window.</summary>
        /// <remarks><para></para></remarks>
        /// <seealso name="ColtCalendarView"/>
        /// <seealso name="ColtCalendarView.onnumWeeksToDisplayValueChanged"/>
        static void whennumWeeksToDisplayChanged(DependencyObject d, DependencyPropertyChangedEventArgs e) {
            RoutedPropertyChangedEventArgs<int> e2 = new RoutedPropertyChangedEventArgs<int>(
                (int) e.OldValue, (int) e.NewValue, ev_numWeeksToDisplay);
            ((ColtCalendarView) d).onnumWeeksToDisplayValueChanged(e2);
        }

        /// <summary>An event-handler to connect</summary>
        /// <remarks><para></para></remarks>
        /// <seealso name="ev_numWeeksToDisplay"/>
        public event RoutedPropertyChangedEventHandler<int> numWeeksToDisplayChanged {
            add { AddHandler(ev_numWeeksToDisplay, value); }
            remove { RemoveHandler(ev_numWeeksToDisplay, value); }
        }

        /// <summary>An event-handler to connect</summary>
        /// <remarks><para></para></remarks>
        protected virtual void onnumWeeksToDisplayValueChanged(RoutedPropertyChangedEventArgs<int> args) {
            RaiseEvent(args);
        }

        /// <summary>Attempt to convert a value into the required property-type (int).</summary>
        /// <remarks><para></para></remarks>
        static object coercenumWeeksToDisplayValue(DependencyObject d, object baseValue) {
            return (int) baseValue;
        }

        /// <summary>The default-value to be applied to numWeeksToDisplay, through dp_numWeeksToDisplay.</summary>
        /// <remarks><para></para></remarks>
        static int defaultnumWeeksToDisplay = 4;

        /// <summary>The property being exposed to the outside world.</summary>
        /// <remarks><para></para></remarks>
        [Description("description of numWeeksToDisplay [int]"), Category("Appearance")]
        public int numWeeksToDisplay {
            get {
                return (int) GetValue(dp_numWeeksToDisplay);
            }
            set { SetValue(dp_numWeeksToDisplay, value); }
        }
        #endregion support for property numWeeksToDisplay

        // Property-name: Font
        // Property-type: FontFamily
        // Owning-class:  ColtCalendarView
        #region support for property Font
        /// <summary>dependency property</summary>
        /// <remarks><para></para></remarks>
        /// <seealso name="ev_Font"/>
        /// <seealso name="FontFamily"/>
        /// <seealso name="ColtCalendarView"/>
        /// <seealso name="defaultFont"/>
        /// <seealso name="whenFontChanged"/>
        /// <seealso name="coerceFontValue"/>
        public static readonly DependencyProperty dp_Font = DependencyProperty.Register(
           "dp_Font",
           typeof(FontFamily),
           typeof(ColtCalendarView),
            new FrameworkPropertyMetadata(
                defaultFont,
                FrameworkPropertyMetadataOptions.AffectsRender,
                new PropertyChangedCallback(whenFontChanged),
                new CoerceValueCallback(coerceFontValue)));

        /// <summary>dependency event</summary>
        /// <remarks><para></para></remarks>
        /// <seealso name="dp_Font"/>
        /// <seealso name="FontChanged"/>
        /// <seealso name="ColtCalendarView"/>
        public static readonly RoutedEvent ev_Font = EventManager.RegisterRoutedEvent(
            "FontChanged",
             RoutingStrategy.Bubble,
             typeof(RoutedPropertyChangedEventHandler<FontFamily>),
             typeof(ColtCalendarView));

        /// <summary>forward a new value to the control, when changed in the Property window.</summary>
        /// <remarks><para></para></remarks>
        /// <seealso name="ColtCalendarView"/>
        /// <seealso name="ColtCalendarView.onFontValueChanged"/>
        static void whenFontChanged(DependencyObject d, DependencyPropertyChangedEventArgs e) {
            RoutedPropertyChangedEventArgs<FontFamily> e2 = new RoutedPropertyChangedEventArgs<FontFamily>(
                (FontFamily) e.OldValue, (FontFamily) e.NewValue, ev_Font);
            ((ColtCalendarView) d).onFontValueChanged(e2);
        }

        /// <summary>An event-handler to connect</summary>
        /// <remarks><para></para></remarks>
        /// <seealso name="ev_Font"/>
        public event RoutedPropertyChangedEventHandler<FontFamily> FontChanged {
            add { AddHandler(ev_Font, value); }
            remove { RemoveHandler(ev_Font, value); }
        }

        /// <summary>An event-handler to connect</summary>
        /// <remarks><para></para></remarks>
        protected virtual void onFontValueChanged(RoutedPropertyChangedEventArgs<FontFamily> args) {
            RaiseEvent(args);
        }

        /// <summary>Attempt to convert a value into the required property-type (FontFamily).</summary>
        /// <remarks><para></para></remarks>
        static object coerceFontValue(DependencyObject d, object baseValue) {
            return (FontFamily) baseValue;
        }

        /// <summary>The default-value to be applied to Font, through dp_Font.</summary>
        /// <remarks><para></para></remarks>
        static FontFamily defaultFont = new FontFamily("Courier New");

        /// <summary>The property being exposed to the outside world.</summary>
        /// <remarks><para></para></remarks>
        [Description("description of Font [FontFamily]"), Category("Appearance")]
        public FontFamily Font {
            get {
                return (FontFamily) GetValue(dp_Font);
            }
            set { SetValue(dp_Font, value); }
        }
        #endregion support for property Font

        // Property-name: fontSize
        // Property-type: int
        // Owning-class:  ColtCalendarView
        #region support for property fontSize
        /// <summary>dependency property</summary>
        /// <remarks><para></para></remarks>
        /// <seealso name="ev_fontSize"/>
        /// <seealso name="int"/>
        /// <seealso name="ColtCalendarView"/>
        /// <seealso name="defaultfontSize"/>
        /// <seealso name="whenfontSizeChanged"/>
        /// <seealso name="coercefontSizeValue"/>
        public static readonly DependencyProperty dp_fontSize = DependencyProperty.Register(
           "dp_fontSize",
           typeof(int),
           typeof(ColtCalendarView),
            new FrameworkPropertyMetadata(
                defaultfontSize,
                FrameworkPropertyMetadataOptions.AffectsRender,
                new PropertyChangedCallback(whenfontSizeChanged),
                new CoerceValueCallback(coercefontSizeValue)));

        /// <summary>dependency event</summary>
        /// <remarks><para></para></remarks>
        /// <seealso name="dp_fontSize"/>
        /// <seealso name="fontSizeChanged"/>
        /// <seealso name="ColtCalendarView"/>
        public static readonly RoutedEvent ev_fontSize = EventManager.RegisterRoutedEvent(
            "fontSizeChanged",
             RoutingStrategy.Bubble,
             typeof(RoutedPropertyChangedEventHandler<int>),
             typeof(ColtCalendarView));

        /// <summary>forward a new value to the control, when changed in the Property window.</summary>
        /// <remarks><para></para></remarks>
        /// <seealso name="ColtCalendarView"/>
        /// <seealso name="ColtCalendarView.onfontSizeValueChanged"/>
        static void whenfontSizeChanged(DependencyObject d, DependencyPropertyChangedEventArgs e) {
            RoutedPropertyChangedEventArgs<int> e2 = new RoutedPropertyChangedEventArgs<int>(
                (int) e.OldValue, (int) e.NewValue, ev_fontSize);
            ((ColtCalendarView) d).onfontSizeValueChanged(e2);
        }

        /// <summary>An event-handler to connect</summary>
        /// <remarks><para></para></remarks>
        /// <seealso name="ev_fontSize"/>
        public event RoutedPropertyChangedEventHandler<int> fontSizeChanged {
            add { AddHandler(ev_fontSize, value); }
            remove { RemoveHandler(ev_fontSize, value); }
        }

        /// <summary>An event-handler to connect</summary>
        /// <remarks><para></para></remarks>
        protected virtual void onfontSizeValueChanged(RoutedPropertyChangedEventArgs<int> args) {
            RaiseEvent(args);
        }

        /// <summary>Attempt to convert a value into the required property-type (int).</summary>
        /// <remarks><para></para></remarks>
        static object coercefontSizeValue(DependencyObject d, object baseValue) {
            return (int) baseValue;
        }

        /// <summary>The default-value to be applied to fontSize, through dp_fontSize.</summary>
        /// <remarks><para></para></remarks>
        static int defaultfontSize = 14;

        /// <summary>The property being exposed to the outside world.</summary>
        /// <remarks><para></para></remarks>
        [Description("description of fontSize [int]"), Category("Appearance")]
        public int fontSize {
            get {
                return (int) GetValue(dp_fontSize);
            }
            set { SetValue(dp_fontSize, value); }
        }
        #endregion support for property fontSize


        const double headerHeight = 0;

        protected override Size MeasureOverride(Size availableSize) {
            Size ret = base.MeasureOverride(availableSize);
            double fheight;

            if (HorizontalAlignment == HorizontalAlignment.Stretch)
                ret.Width = availableSize.Width;
            else
                ret.Width = Width = 7 * defaultDayWidth;
            if (VerticalAlignment == VerticalAlignment.Stretch) {
                fheight = Math.Ceiling(this.fontSize * this.Font.LineSpacing);
                ret.Height = (maxEventsPerDay + 1) * fheight * numWeeksToDisplay;

            } else
                ret.Height = 100;
            // What week are we in.
            DateTime dt = DateTime.Now;
            if (ret.Height < 1)
                ret.Height = 100;
            Logger.log(MethodBase.GetCurrentMethod(), "returning " + ret);
            return ret;
        }

        protected override Size ArrangeOverride(Size finalSize) {
            Size ret = base.ArrangeOverride(finalSize);
            Logger.log(MethodBase.GetCurrentMethod(), "returning " + ret);
            return ret;
        }

        protected override void OnRender(DrawingContext drawingContext) {
            Brush bgBrush, fgBrush;
            Pen fgPen;
            Rect rbounds;
            double rh, cw;

            Logger.log(MethodBase.GetCurrentMethod(), "RenderSize=" + RenderSize);
            rbounds = new Rect(RenderSize);

            base.OnRender(drawingContext);

            bgBrush = new SolidColorBrush(BackColor);
            fgBrush = new SolidColorBrush(PenColor);
            fgPen = new Pen(fgBrush, 1);
            drawingContext.DrawRectangle(bgBrush, fgPen, rbounds);
            rh = (RenderSize.Height - headerHeight) / this.numWeeksToDisplay;
            cw = RenderSize.Width / 7;

            for (int i = 0; i < 7; i++)
                drawingContext.DrawLine(fgPen,
                    new Point(i * cw, headerHeight),
                    new Point(i * cw, RenderSize.Height));

            for (int i = 0; i < this.numWeeksToDisplay; i++)
                drawingContext.DrawLine(fgPen,
                    new Point(0, headerHeight + (i * rh)),
                    new Point(RenderSize.Width, headerHeight + (i * rh)));
            // draw the current month.
            DateTime now = DateTime.Now, dtStart;
            int subDays = 0;
            switch (now.DayOfWeek) {
                case DayOfWeek.Sunday: subDays = 0; break;
                case DayOfWeek.Monday: subDays = 1; break;
                case DayOfWeek.Tuesday: subDays = 2; break;
                case DayOfWeek.Wednesday: subDays = 3; break;
                case DayOfWeek.Thursday: subDays = 4; break;
                case DayOfWeek.Friday: subDays = 5; break;
                case DayOfWeek.Saturday: subDays = 6; break;
            }
            dtStart = now;
            if (subDays > 0)
                dtStart = now.AddDays(-subDays);

            string currMonth = now.ToString("MMM");
            CultureInfo ci = CultureInfo.CurrentUICulture;
            Typeface tfNormal, tfBold;
            FormattedText ft;

            tfNormal = new Typeface(Font, FontStyles.Normal, FontWeights.Normal, FontStretches.Normal);
            tfBold = new Typeface(Font, FontStyles.Normal, FontWeights.Bold, FontStretches.Normal);
            drawingContext.DrawText(
                new FormattedText(currMonth, ci,
                FlowDirection.LeftToRight,
                tfBold,
                this.fontSize, fgBrush),
                new Point(2, 2));

            for (int i = 0; i < this.numWeeksToDisplay; i++) {
                for (int j = 0; j < 7; j++) {
                    if (dtStart.Day == 1) {
                        drawingContext.DrawText(
                            new FormattedText(dtStart.ToString("MMM"), ci,
                            FlowDirection.LeftToRight,
                            tfBold,
                            this.fontSize, fgBrush),
                            new Point(2+j*cw, i*rh+2));

                    }
                    ft = new FormattedText(dtStart.ToString("dd"),
                      ci, FlowDirection.LeftToRight,
                      tfNormal, fontSize, fgBrush);
                    drawingContext.DrawText(ft, 
                        new Point((j + 1) * cw - ft.Width-2, i * rh+2));
                    dtStart = dtStart.AddDays(1);
                }
            }
        }
    }
}