using Xamarin.Forms;

namespace XamarinFormsUIPractice.Views
{
    public partial class RelativeLayoutCsharp : ContentPage
    {
        public RelativeLayoutCsharp()
        {
            InitializeComponent();

            var relativeLayout = new RelativeLayout();

            var label1 = new Label()
            {
                Text = "label1",
                BackgroundColor = Color.FromHex("82DADA"),
                FontSize = 60,
            };
            relativeLayout.Children.Add(label1,
                Constraint.Constant(30),//x座標は固定
                Constraint.RelativeToParent(parent => parent.Height / 2)//y座標は親要素(RelativeLayout)との相対位置との
                );

            var label2 = new Label
            {
                Text = "label2",
                BackgroundColor = Color.FromHex("53CF9E"),
                FontSize = 40
            };
            relativeLayout.Children.Add(label2,
                Constraint.Constant(100),//x座標は固定
                //y座標はlabel1の20下
                Constraint.RelativeToView(label1, (parent, sibling) => sibling.Y + sibling.Height + 20)
                );

            var label3 = new Label()
            {
                Text = "label3",
                BackgroundColor = Color.Orchid,
                FontSize=50,
            };
            relativeLayout.Children.Add(label3,
                Constraint.RelativeToView(label2,(parent,sibling)=>sibling.X-50),
                Constraint.RelativeToView(label2,(parent,sibling)=>sibling.Y+20)
                );



            this.Content = relativeLayout;
        }
    }
}
