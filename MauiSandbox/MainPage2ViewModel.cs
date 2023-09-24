using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiSandbox
{
	public partial class MainPage2ViewModel : ViewModelBase
	{
		private static int _INSTANCE_COUNT = 0;
		private int _instanceNo;


		public MainPage2ViewModel() 
		{
			_instanceNo = ++_INSTANCE_COUNT;
		}


		public string HelloText => $"{_instanceNo}: Hello, World! Say 'hi' to the robot!";
		public override string Title => "Main Page 2";


		[RelayCommand]
		private async Task DoNavigate() => await Shell.Current.GoToAsync("//MainPage");
	}
}
