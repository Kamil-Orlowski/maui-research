using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MauiSandbox
{
	public abstract class ViewModelBase : BindableObject
	{
		public virtual string Title { get; } = "<UNTITLED>";
	}
}
