using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Xamarin.Forms;
using XamarinFormsUIPractice.Models;

namespace XamarinFormsUIPractice.ViewModels
{
	public class FlexLayoutXamlViewModel : BindableBase
	{
	    private string _title;
	    public string Title
	    {
	        get => _title;
	        set => SetProperty(ref _title, value);
	    }

	    public IReadOnlyCollection<ColorInfo> ColorInfos { get; } =
	        typeof(Color)
	            .GetRuntimeFields()
	            .Where(x => x.IsPublic && x.IsStatic && x.FieldType == typeof(Color))
	            .Select(x => new ColorInfo { Name = x.Name, Color = (Color)x.GetValue(null) })
	            .ToList();

        public FlexLayoutXamlViewModel()
        {
            Title = "FlexLayoutXaml";
        }
	}
}
