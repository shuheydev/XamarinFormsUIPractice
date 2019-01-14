using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;

namespace XamarinFormsUIPractice.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        public MainPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "Main Page";
        }

        //画面側からCommandのパラメータとして遷移先を受け渡すように実装
        public Command<string> NavigateCommand=>
        new Command<string>(
            name=>this.NavigationService.NavigateAsync(name));

    }
}
