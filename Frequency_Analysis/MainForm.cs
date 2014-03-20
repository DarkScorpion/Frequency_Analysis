//The MIT License
//(с) 2014 Александр Смит (https://github.com/DarkScorpion)
using System;
using System.IO;
using System.Linq;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

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
			double frequency;
			string AnalyzedText = richTextBox1.Text;
            var symbolsMap = from c in AnalyzedText
            	group c by c into g
            	let count = g.Count()
            	orderby count descending
            	select new
            	{
            		Value = g.Key,
            		Count = count,
            	};
            richTextBox2.Clear();
            richTextBox2.Text = "Cимвол:\t\tЧастота\t\tПроцент    \n";
            foreach (var count in symbolsMap)
            {
                frequency = Convert.ToDouble(count.Count)/AnalyzedText.Length;
                frequency = Math.Round(frequency,5);
                richTextBox2.Text += "    " + count.Value + "\t\t     " + 
                	count.Count + "\t\t " +frequency*100+"% \n";
            }
		}
		
		void LoadFileButtonClick(object sender, EventArgs e)
		{
 			if(openFileDialog1.ShowDialog() == DialogResult.OK)
   			{
  				StreamReader streamReader = new StreamReader(openFileDialog1.FileName);
  				richTextBox1.Text = streamReader.ReadToEnd();
  				streamReader.Close();
   			}
		}
	}
}
