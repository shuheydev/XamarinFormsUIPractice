using Xamarin.Forms;

namespace XamarinFormsUIPractice.Views
{
    public partial class GridCsharp : ContentPage
    {
        public GridCsharp()
        {
            InitializeComponent();

            var grid=new Grid()
            {
                Padding = new Thickness(10,10,10,10),
                RowSpacing = 10,
                ColumnSpacing = 5,

                RowDefinitions =
                {
                    new RowDefinition(){Height = GridLength.Auto},
                    new RowDefinition(){Height = new GridLength(100,GridUnitType.Star)},//最低100、残り全部
                },
                ColumnDefinitions =
                {
                    new ColumnDefinition(){Width = GridLength.Auto},
                    new ColumnDefinition(){Width=new GridLength(100,GridUnitType.Absolute)},//100固定
                    new ColumnDefinition(){Width = new GridLength(10,GridUnitType.Star)},//最低10、残り全部
                }
            };

            //１列目にラベルを追加
            grid.Children.Add(new Label { Text = "1-1", BackgroundColor = Color.Red, }, 0, 0);//１列目で左から１カラム目
            grid.Children.Add(new Label { Text = "1-2", BackgroundColor = Color.Blue }, 1, 0);//１列目で左から２カラム目
            grid.Children.Add(new Label { Text = "1-3", BackgroundColor = Color.Green }, 2, 0);//１列目で左から３カラム目
            //２列目にラベルを追加
            grid.Children.Add(new Label { Text = "2-1", BackgroundColor = Color.Yellow }, 0, 2, 1, 2); //２列目で左から１~２カラム
            grid.Children.Add(new Label { Text = "2-2", BackgroundColor = Color.Purple }, 2, 1);//２列目で左から３カラム目


            this.Content = grid;
        }
    }
}
