﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Android.Text;
using Android.Widget;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Handlers;
using Xunit;

namespace Microsoft.Maui.DeviceTests
{
	public partial class LabelTests
	{
		TextView GetPlatformLabel(LabelHandler labelHandler) =>
			labelHandler.PlatformView;

		TextUtils.TruncateAt GetPlatformLineBreakMode(LabelHandler labelHandler) =>
			GetPlatformLabel(labelHandler).Ellipsize;

		int GetPlatformMaxLines(LabelHandler labelHandler) =>
			GetPlatformLabel(labelHandler).MaxLines;
	}
}
