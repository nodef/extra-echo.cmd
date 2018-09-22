namespace App {
	class Params {

		// data
		/// <summary>
		/// Indicates whether escape sequences are to be expanded.
		/// </summary>
		public bool Expand;
		/// <summary>
		/// Indicates if there is supposed to be no newline at end.
		/// </summary>
		public bool NoNewline;
		/// <summary>
		/// Stores the actual value to be written.
		/// </summary>
		public string Value = "";


		// constructor
		/// <summary>
		/// Get parameters for input arguments.
		/// </summary>
		/// <param name="args">Input arguments.</param>
		public Params(string[] args) {
			for (int i = 0; i < args.Length; i++) {
				string a = args[i];
				if (a.StartsWith("--")) { SetOption(a.Substring(2, 1)); continue; }
				if (a.StartsWith("-")) { SetOption(a.Substring(1)); continue; }
				Value += a;
			}
		}


		// method
		/// <summary>
		/// Set options from option string.
		/// </summary>
		/// <param name="o">Option string.</param>
		public void SetOption(string o) {
			foreach(char c in o.ToLower()) {
				if (c == 'e') Expand = true;
				else if (c == 'n') NoNewline = true;
			}
		}
	}
}
