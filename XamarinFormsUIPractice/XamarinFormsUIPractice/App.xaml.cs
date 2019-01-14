using Prism;
using Prism.Ioc;
using XamarinFormsUIPractice.ViewModels;
using XamarinFormsUIPractice.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace XamarinFormsUIPractice
{
    public partial class App
    {
        /* 
         * The Xamarin Forms XAML Previewer in Visual Studio uses System.Activator.CreateInstance.
         * This imposes a limitation in which the App class must have a default constructor. 
         * App(IPlatformInitializer initializer = null) cannot be handled by the Activator.
         */
        public App() : this(null) { }

        public App(IPlatformInitializer initializer) : base(initializer) { }

        protected override async void OnInitialized()
        {
            InitializeComponent();

            await NavigationService.NavigateAsync("NavigationPage/MainPage");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<MainPage, MainPageViewModel>();
            containerRegistry.RegisterForNavigation<AbsoluteLayoutCsharp, AbsoluteLayoutCsharpViewModel>();
            containerRegistry.RegisterForNavigation<AbsoluteLayoutXaml, AbsoluteLayoutXamlViewModel>();
            containerRegistry.RegisterForNavigation<StackLayoutCsharp, StackLayoutCsharpViewModel>();
            containerRegistry.RegisterForNavigation<StackLayoutXaml, StackLayoutXamlViewModel>();
            containerRegistry.RegisterForNavigation<GridCsharp, GridCsharpViewModel>();
            containerRegistry.RegisterForNavigation<GridXaml, GridXamlViewModel>();
            containerRegistry.RegisterForNavigation<RelativeLayoutCsharp, RelativeLayoutCsharpViewModel>();
            containerRegistry.RegisterForNavigation<RelativeLayoutXaml, RelativeLayoutXamlViewModel>();
            containerRegistry.RegisterForNavigation<FlexLayoutCsharp, FlexLayoutCsharpViewModel>();
            containerRegistry.RegisterForNavigation<FlexLayoutXaml, FlexLayoutXamlViewModel>();
        }
    }
}
