﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AccountControl
{
	public class Role
	{
		public Role(string name)
		{
			Name = name;
		}
		public string Name { get; set; }
		public override string ToString()
		{
			return Name;
		}
	}
}