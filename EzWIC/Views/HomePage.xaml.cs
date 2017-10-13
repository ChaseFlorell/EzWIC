using Xamarin.Forms;

namespace EzWIC.Views
{
    public partial class HomePage
    {
        public HomePage()
        {
            InitializeComponent();
            BindingContext = this;
        }

		void FoodList_Clicked(object sender, System.EventArgs e)
		{
			//throw new NotImplementedException();
		}
		void WICCard_Clicked(object sender, System.EventArgs e)
		{
			//throw new NotImplementedException();
		}
		
        /// <summary>
        /// example of how to do Command binding instead of a click handler
        /// </summary>
        public Command<object> FoodSearchCommand => new Command<object>(p =>
        {
            // throw new NotImpelementedExceptoin
        });
    }
}
