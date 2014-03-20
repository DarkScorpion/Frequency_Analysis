/*
 * Created by SharpDevelop.
 * User: Admin
 * Date: 26.02.2014
 * Time: 15:43
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Frequency_Analysis
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.richTextBox2 = new System.Windows.Forms.RichTextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.LoadFileButton = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.richTextBox3 = new System.Windows.Forms.RichTextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// richTextBox1
			// 
			this.richTextBox1.Location = new System.Drawing.Point(12, 41);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(283, 96);
			this.richTextBox1.TabIndex = 0;
			this.richTextBox1.Text = "";
			// 
			// richTextBox2
			// 
			this.richTextBox2.Location = new System.Drawing.Point(308, 41);
			this.richTextBox2.Name = "richTextBox2";
			this.richTextBox2.Size = new System.Drawing.Size(264, 245);
			this.richTextBox2.TabIndex = 1;
			this.richTextBox2.Text = "";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(157, 292);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(107, 37);
			this.button1.TabIndex = 2;
			this.button1.Text = "Провести анализ теста";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(85, 2);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(142, 36);
			this.label1.TabIndex = 3;
			this.label1.Text = "Анализируймый текст";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.Filter = "(*.txt)|*.txt";
			// 
			// LoadFileButton
			// 
			this.LoadFileButton.Location = new System.Drawing.Point(35, 293);
			this.LoadFileButton.Name = "LoadFileButton";
			this.LoadFileButton.Size = new System.Drawing.Size(101, 36);
			this.LoadFileButton.TabIndex = 4;
			this.LoadFileButton.Text = "Загрузить из файла";
			this.LoadFileButton.UseVisualStyleBackColor = true;
			this.LoadFileButton.Click += new System.EventHandler(this.LoadFileButtonClick);
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(367, 9);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(162, 23);
			this.label2.TabIndex = 5;
			this.label2.Text = "Статистика";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// richTextBox3
			// 
			this.richTextBox3.Location = new System.Drawing.Point(12, 166);
			this.richTextBox3.Name = "richTextBox3";
			this.richTextBox3.Size = new System.Drawing.Size(283, 120);
			this.richTextBox3.TabIndex = 6;
			this.richTextBox3.Text = "";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(85, 140);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(142, 23);
			this.label3.TabIndex = 7;
			this.label3.Text = "Дешифровка";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(591, 341);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.richTextBox3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.LoadFileButton);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.richTextBox2);
			this.Controls.Add(this.richTextBox1);
			this.Name = "MainForm";
			this.Text = "Частотный Анализ";
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.RichTextBox richTextBox3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button LoadFileButton;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.RichTextBox richTextBox2;
		private System.Windows.Forms.RichTextBox richTextBox1;
	}
}
