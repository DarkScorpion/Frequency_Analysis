using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;

namespace Frequency_Analysis
{

	public partial class MainForm : Form
	{
		public MainForm()
		{
			// The InitializeComponent() call is required for Windows Forms designer support.
			InitializeComponent();
			// TODO: Add constructor code after the InitializeComponent() call.
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			string AnalyzedText = richTextBox1.Text;
            var x = from c in AnalyzedText
                    group c by c into g
                    let count = g.Count()
                    orderby g.Key ascending
                    select new
                    {
                        Value = g.Key,
                        Count = count,
                    };
            richTextBox2.Clear();
            richTextBox2.Text = "символ:\t\tчастота\t\tпроцент    \n\r";
            foreach (var count in x)
            {
                double frequency = Convert.ToDouble(count.Count)/AnalyzedText.Length;
                frequency = Math.Round(frequency,5);
                richTextBox2.Text += "    " + count.Value + "\t\t     " + 
                	count.Count + "\t\t " +frequency*100+"% \n\r";
            }
		}
	}
}
