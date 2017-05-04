﻿using System;

namespace DotnetSpider.Extension.Model.Attribute
{
	[AttributeUsage(AttributeTargets.Property, AllowMultiple = true)]
	public class LinkedUrl : System.Attribute
	{
		public string[] Extras { get; set; }

		internal string PropertyName { get; set; }
	}
}