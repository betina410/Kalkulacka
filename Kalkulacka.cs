using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalkulackaApp
{
	/// <summary>
	/// Reprezentuje jednoduchou kalkulačku
	/// </summary>
	public class Kalkulacka
	{

		/// <summary>
		/// Sečte 2 čísla
		/// </summary>
		/// <param name="a">První číslo</param>
		/// <param name="b">Druhé číslo</param>
		/// <returns>Součet 2 čísel</returns>
		public double Secti(double a, double b)
		{
			return a + b;
		}

		/// <summary>
		/// Odečte 2 čísla
		/// </summary>
		/// <param name="a">První číslo</param>
		/// <param name="b">Druhé číslo</param>
		/// <returns>Rozdíl 2 čísel</returns>
		public double Odecti(double a, double b)
		{
			return a - b;
		}

		/// <summary>
		/// Vynásobí 2 čísla
		/// </summary>
		/// <param name="a">První číslo</param>
		/// <param name="b">Druhé číslo</param>
		/// <returns>Součin 2 čísel</returns>
		public double Vynasob(double a, double b)
		{
			return a * b;
		}

		/// <summary>
		/// Vydělí 2 čísla
		/// </summary>
		/// <param name="a">První číslo</param>
		/// <param name="b">Druhé číslo</param>
		/// <returns>Podíl 2 čísel</returns>
		public double Vydel(double a, double b)
		{
			if (b == 0)
				throw new ArgumentException("Nulou nelze dělit!");
			return a / b;
			//return 1;
		}

	}
}

