using System;
using System.Windows.Forms;

namespace Frequency_Analysis
{

	internal sealed class Program
	{
		//Program entry point.
		[STAThread]
		private static void Main(string[] args)
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainForm());
		}
		
	}
}
