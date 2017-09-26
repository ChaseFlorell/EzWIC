using System;
using Xamarin.Forms;

namespace EzWIC.Views.Layouts
{
    public partial class HomeButton : AbsoluteLayout
    {
        private TapGestureRecognizer _tapped => new TapGestureRecognizer { Command = new Command(RaiseClicked) };
        public HomeButton()
        {
            InitializeComponent();
            btnBox.BindingContext = this;
            btnImage.BindingContext = this;
            btnLabel.BindingContext = this;
            GestureRecognizers.Add(_tapped);
        }

        protected override void OnPropertyChanged(string propertyName = null)
        {
            base.OnPropertyChanged(propertyName);
            if(propertyName == "BackgroundColor" && BackgroundColor != Color.Transparent){
                ButtonBackgroundColor = BackgroundColor;
                BackgroundColor = Color.Transparent;
            }
        }

        ~HomeButton()
        {
            GestureRecognizers.Remove(_tapped);
        }

        public static readonly BindableProperty CornerRadiusProperty = BindableProperty.Create(nameof(CornerRadius),
                typeof(double),
                typeof(HomeButton),
                -1d);

        /// <summary>
        /// CornerRadius summary. This is a bindable property. Default value is -1
        /// </summary>
        public double CornerRadius
        {
            get { return (double)GetValue(CornerRadiusProperty); }
            set { SetValue(CornerRadiusProperty, value); }
        }

        public static readonly BindableProperty TextProperty = BindableProperty.Create(nameof(Text),
                typeof(string),
                typeof(HomeButton),
                default(string));

        /// <summary>
        /// Text summary. This is a bindable property. Default value is default(string)
        /// </summary>
        public string Text
        {
            get { return (string)GetValue(TextProperty); }
            set { SetValue(TextProperty, value); }
        }

        public static readonly BindableProperty ImageProperty = BindableProperty.Create(nameof(Image),
                typeof(ImageSource),
                typeof(HomeButton),
                default(ImageSource));

        /// <summary>
        /// Image summary. This is a bindable property. Default value is default(ImageSource)
        /// </summary>
        public ImageSource Image
        {
            get { return (ImageSource)GetValue(ImageProperty); }
            set { SetValue(ImageProperty, value); }
        }

        public static readonly BindableProperty BorderRadiusProperty = BindableProperty.Create(nameof(BorderRadius),
                typeof(double),
                typeof(HomeButton),
                0d);

        /// <summary>
        /// BorderRadius summary. This is a bindable property. Default value is 0
        /// </summary>
        public double BorderRadius
        {
            get { return (double)GetValue(BorderRadiusProperty); }
            set { SetValue(BorderRadiusProperty, value); }
        }

        public static readonly BindableProperty ButtonBackgroundColorProperty = BindableProperty.Create(nameof(BackgroundColor),
                typeof(Color),
                typeof(HomeButton),
                Color.Default);

        /// <summary>
        /// BackgroundColor summary. This is a bindable property. Default value is default(PropertyType)
        /// </summary>
        public Color ButtonBackgroundColor
        {
            get { return (Color)GetValue(BackgroundColorProperty); }
            set { SetValue(BackgroundColorProperty, value); }
        }


        public event EventHandler Clicked;
        private void RaiseClicked() => Clicked?.Invoke(this, EventArgs.Empty);
    }
}
