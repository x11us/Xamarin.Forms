//
// XamlFilePathAttribute.cs
//
// Author:
//       Stephane Delcroix <stephane@mi8.be>
//
// Copyright (c) 2016 mobile inception
//

using System;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace Xamarin.Forms.Xaml
{

	[AttributeUsage(AttributeTargets.Class, Inherited = false)]
	public sealed class XamlFilePathAttribute : Attribute
	{
		public XamlFilePathAttribute([CallerFilePath] string filePath = "")
		{
		}
	}
}