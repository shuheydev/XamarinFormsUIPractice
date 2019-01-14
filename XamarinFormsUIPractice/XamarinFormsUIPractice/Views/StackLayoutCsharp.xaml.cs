using Xamarin.Forms;

namespace XamarinFormsUIPractice.Views
{
    public partial class StackLayoutCsharp : ContentPage
    {
        public StackLayoutCsharp()
        {
            InitializeComponent();

            var stackLayout = new StackLayout();
            stackLayout.Orientation = StackOrientation.Vertical;
            stackLayout.Padding = new Thickness(10, 10, 10, 10);
            stackLayout.Spacing = 5;
            stackLayout.Children.Add(new Label
            {
                FontSize = 30,
                Text = "First",
                HeightRequest = 100,
                BackgroundColor = Color.FromHex("82DADA"),
            });
            stackLayout.Children.Add(new Label()
            {
                FontSize = 30,
                Text = "Second",
                //VerticalOptions = LayoutOptions.FillAndExpand,//縦方向に余白を最大限に利用する
                HorizontalOptions = LayoutOptions.EndAndExpand,
                //HeightRequest = 200,
                BackgroundColor = Color.FromHex("53CF9E"),
            });
            stackLayout.Children.Add(new Label()
            {
                FontSize = 30,
                Text = "Third",
                HeightRequest = 300,
                BackgroundColor = Color.FromHex("EB6379"),
            });
            stackLayout.Children.Add(new Label()
            {
                FontSize = 30,
                Text = "Forth",
                HeightRequest = 400,
                BackgroundColor = Color.FromHex("53CF9E"),
            });
            stackLayout.Children.Add(new Label()
            {
                FontSize = 30,
                Text = "Fifth",
                HeightRequest = 500,
                BackgroundColor = Color.FromHex("EB6379"),
            });

            var stackLayout2=new StackLayout();
            stackLayout2.Orientation = StackOrientation.Horizontal;
            stackLayout2.Padding=new Thickness(0);
            stackLayout2.Spacing = 0;
            stackLayout2.Children.Add(new Label
            {
                Text = "Sixth",
                WidthRequest = 50,
                BackgroundColor = Color.Bisque,
            });
            stackLayout2.Children.Add(new Label
            {
                Text = "Seventh",
                HorizontalOptions = LayoutOptions.FillAndExpand,
                BackgroundColor = Color.Orange,
            });
            stackLayout2.Children.Add(new Label
            {
                Text = "Eighth",
                WidthRequest = 50,
                BackgroundColor = Color.Aquamarine,
            });

            stackLayout.Children.Add(stackLayout2);

            this.Content = stackLayout;
        }
    }
}
