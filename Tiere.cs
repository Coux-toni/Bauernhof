using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bauernhof
{
    public class Tiere
    {
		private string _tierart = "";

		public string Tierart
		{
			get { return _tierart; }
			set
			{
				if (value != _tierart)
				{ _tierart = value; }
			}
		}
		public Tiere(string name)
		{
			this.Tierart = name;
		}

	}
}
