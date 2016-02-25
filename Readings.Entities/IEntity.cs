using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Readings.Entities
{
	public interface IEntity
	{
		int Id { get; set; }
		int Num { get; set; }
	}
}
