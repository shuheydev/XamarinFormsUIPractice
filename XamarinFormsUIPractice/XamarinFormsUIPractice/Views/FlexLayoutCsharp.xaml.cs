using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;
using System.Reflection;
using XamarinFormsUIPractice.Models;

namespace XamarinFormsUIPractice.Views
{
    public partial class FlexLayoutCsharp : ContentPage
    {
        //色リストを取得
        private IReadOnlyCollection<ColorInfo> _colorInfos { get; } =
            typeof(Color)
                .GetRuntimeFields()
                .Where(x => x.IsPublic && x.IsStatic && x.FieldType == typeof(Color))
                .Select(x => new ColorInfo
                {
                    Name = x.Name,
                    Color = (Color)x.GetValue(null),
                })
                .ToList();

        private Random _rand = new Random(DateTime.Now.Second);

        public FlexLayoutCsharp()
        {
            InitializeComponent();

            var flexLayout = new FlexLayout();
            flexLayout.Direction = FlexDirection.Row;
            flexLayout.Wrap = FlexWrap.Wrap;


            foreach (var i in Enumerable.Range(0, 35))
            {
                var colorInfo = _colorInfos.ElementAt(_rand.Next(_colorInfos.Count));

                flexLayout.Children.Add(new Label()
                {
                    Text = colorInfo.Name,
                    WidthRequest = 50,
                    HeightRequest = 50,
                    BackgroundColor = colorInfo.Color
                });
            }


            var scrollView=new ScrollView();

            scrollView.Content = flexLayout;
            this.Content = scrollView;
        }
    }
}
