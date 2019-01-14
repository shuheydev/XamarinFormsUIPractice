using Xamarin.Forms;

namespace XamarinFormsUIPractice.Views
{
    public partial class AbsoluteLayoutCsharp : ContentPage
    {
        public AbsoluteLayoutCsharp()
        {
            InitializeComponent();

            //アブソレートレイアウトの生成
            var absoluteLayout = new AbsoluteLayout();

            //ラベルの生成とレイアウトへの追加(Rectangle指定)
            var label1 = new Label { Text = "First", BackgroundColor = Color.FromHex("82DADA"), FontSize = 20 };
            absoluteLayout.Children.Add(label1, new Rectangle(20, 20, 200, 200));

            //ラベルの生成とレイアウトへの追加(Point指定)
            var label2 = new Label { Text = "Second", BackgroundColor = Color.FromHex("53CF9E"), FontSize = 20 };
            absoluteLayout.Children.Add(label2, new Point(200, 300));

            //ラベルの生成とレイアウトへの追加(SetLayoutBounds指定)
            var label3 = new Label { Text = "Third", BackgroundColor = Color.FromHex("EB6379"), FontSize = 20 };
            absoluteLayout.Children.Add(label3);
            AbsoluteLayout.SetLayoutBounds(label3, new Rectangle(30, 400, 250, 100));

            this.Content = absoluteLayout;
        }
    }
}
