﻿using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;

namespace XamarinFormsUIPractice.ViewModels
{
	public class AbsoluteLayoutCsharpViewModel : BindableBase
	{
	    private string _title;

	    public string Title
	    {
	        get => _title;
	        set => SetProperty(ref _title, value);
	    }
        public AbsoluteLayoutCsharpViewModel()
        {
            Title = "AbsoluteLayoutCsharp";
        }
	}
}
