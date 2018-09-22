using System;
using System.Text.RegularExpressions;

namespace App {
	class Program {

		// static method
		/// <summary>
		/// One of the most vital ingredients to keep a
		/// relationship going is a capacity for humour.
		/// : The School of Life
		/// </summary>
		/// <param name="args">Input arguments.</param>
		static void Main(string[] args) {
			Params p = new Params(args);
			string v = p.Value;
			if (p.Expand) v = Unescape(v);
			if (!p.NoNewline) v += '\n';
			Console.Write(v);
		}

		/// <summary>
		/// Unescape a C-escaped string.
		/// </summary>
		/// <param name="v">Escaped string.</param>
		/// <returns>Unescaped string.</returns>
		private static string Unescape(string v) {
			return Regex.Unescape(v.Replace("\\-", "-"));
		}
	}
}
