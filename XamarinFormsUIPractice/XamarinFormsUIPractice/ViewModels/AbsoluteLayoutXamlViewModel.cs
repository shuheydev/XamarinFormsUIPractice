using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using Xamarin.Forms;

namespace XamarinFormsUIPractice.ViewModels
{
	public class AbsoluteLayoutXamlViewModel : BindableBase
	{
	    private string _title;
	    public string Title
	    {
	        get => _title;
	        set => SetProperty(ref _title, value);
	    }

        public AbsoluteLayoutXamlViewModel()
        {
            Title = "AbsoluteLayoutXaml";
        }
	}
}
