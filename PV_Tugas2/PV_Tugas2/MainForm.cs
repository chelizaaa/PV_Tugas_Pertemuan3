/*
 * Created by SharpDevelop.
 * User: Lenovo
 * Date: 3/1/2022
 * Time: 9:17 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace PV_Tugas2
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void ButtonTambahClick(object sender, EventArgs e)
		{
			listBox.Items.Add(textBoxInput.Text);
			textBoxInput.Clear();
		}
		
		void ButtonHapusClick(object sender, EventArgs e)
		{
			listBox.Items.RemoveAt(listBox.SelectedIndex);
		}
	}
}