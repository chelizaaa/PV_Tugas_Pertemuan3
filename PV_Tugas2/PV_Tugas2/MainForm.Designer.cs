/*
 * Created by SharpDevelop.
 * User: Lenovo
 * Date: 3/1/2022
 * Time: 9:17 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace PV_Tugas2
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
			this.buttonTambah = new System.Windows.Forms.Button();
			this.labelTitle = new System.Windows.Forms.Label();
			this.textBoxInput = new System.Windows.Forms.TextBox();
			this.buttonHapus = new System.Windows.Forms.Button();
			this.listBox = new System.Windows.Forms.ListBox();
			this.SuspendLayout();
			// 
			// buttonTambah
			// 
			this.buttonTambah.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonTambah.Location = new System.Drawing.Point(40, 80);
			this.buttonTambah.Name = "buttonTambah";
			this.buttonTambah.Size = new System.Drawing.Size(75, 26);
			this.buttonTambah.TabIndex = 0;
			this.buttonTambah.Text = "Tambah";
			this.buttonTambah.UseVisualStyleBackColor = true;
			this.buttonTambah.Click += new System.EventHandler(this.ButtonTambahClick);
			// 
			// labelTitle
			// 
			this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelTitle.Location = new System.Drawing.Point(12, 12);
			this.labelTitle.Name = "labelTitle";
			this.labelTitle.Size = new System.Drawing.Size(260, 23);
			this.labelTitle.TabIndex = 1;
			this.labelTitle.Text = "Input Daftar Barang";
			this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// textBoxInput
			// 
			this.textBoxInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxInput.Location = new System.Drawing.Point(42, 50);
			this.textBoxInput.Name = "textBoxInput";
			this.textBoxInput.Size = new System.Drawing.Size(200, 22);
			this.textBoxInput.TabIndex = 2;
			// 
			// buttonHapus
			// 
			this.buttonHapus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonHapus.Location = new System.Drawing.Point(167, 80);
			this.buttonHapus.Name = "buttonHapus";
			this.buttonHapus.Size = new System.Drawing.Size(75, 26);
			this.buttonHapus.TabIndex = 4;
			this.buttonHapus.Text = "Hapus";
			this.buttonHapus.UseVisualStyleBackColor = true;
			this.buttonHapus.Click += new System.EventHandler(this.ButtonHapusClick);
			// 
			// listBox
			// 
			this.listBox.FormattingEnabled = true;
			this.listBox.Location = new System.Drawing.Point(40, 120);
			this.listBox.Name = "listBox";
			this.listBox.Size = new System.Drawing.Size(202, 121);
			this.listBox.TabIndex = 6;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 261);
			this.Controls.Add(this.listBox);
			this.Controls.Add(this.buttonHapus);
			this.Controls.Add(this.textBoxInput);
			this.Controls.Add(this.labelTitle);
			this.Controls.Add(this.buttonTambah);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Daftar Barang";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.ListBox listBox;
		private System.Windows.Forms.Button buttonHapus;
		private System.Windows.Forms.TextBox textBoxInput;
		private System.Windows.Forms.Label labelTitle;
		private System.Windows.Forms.Button buttonTambah;
	}
}
