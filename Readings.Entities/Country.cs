﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Readings.Entities
{
	public class Country: IEntity
	{
		public int Id { get; set; }
		public int Num { get; set; }
	}
}
