using System;
using Microsoft.Maui.Controls.Xaml.Internals;

using EObject = ElmSharp.EvasObject;

namespace Microsoft.Maui.Controls.Compatibility.Platform.Tizen
{
	class NativeValueConverterService : INativeValueConverterService
	{
		public bool ConvertTo(object value, Type toType, out object nativeValue)
		{
			Hosting.MauiAppBuilderExtensions.CheckForCompatibility();
			nativeValue = null;
			if ((value is EObject) && toType.IsAssignableFrom(typeof(View)))
			{
				nativeValue = ((EObject)value).ToView();
				return true;
			}
			return false;
		}
	}
}
