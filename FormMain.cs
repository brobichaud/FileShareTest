using System;
using System.IO;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Runtime.InteropServices;

namespace FileShareTest
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class FormMain : System.Windows.Forms.Form
	{
		private FileStream _fs = null;

		#region Form Controls

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txFile;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox cbAccessModes;
		private System.Windows.Forms.ComboBox cbShareModes;
		private System.Windows.Forms.ComboBox cbOpenModes;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button btOpen;
		private System.Windows.Forms.Button btClose;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label lbState;
		private System.Windows.Forms.ToolTip toolTip1;
		private System.ComponentModel.IContainer components;
		#endregion 

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txFile = new System.Windows.Forms.TextBox();
			this.cbAccessModes = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.cbShareModes = new System.Windows.Forms.ComboBox();
			this.cbOpenModes = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.btOpen = new System.Windows.Forms.Button();
			this.btClose = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.lbState = new System.Windows.Forms.Label();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(15, 20);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(78, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Test File:";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(15, 78);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(78, 23);
			this.label2.TabIndex = 0;
			this.label2.Text = "Access Mode:";
			// 
			// txFile
			// 
			this.txFile.Location = new System.Drawing.Point(96, 20);
			this.txFile.Name = "txFile";
			this.txFile.Size = new System.Drawing.Size(239, 20);
			this.txFile.TabIndex = 1;
			this.txFile.Text = "c:\\testfile.txt";
			// 
			// cbAccessModes
			// 
			this.cbAccessModes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbAccessModes.Location = new System.Drawing.Point(97, 75);
			this.cbAccessModes.Name = "cbAccessModes";
			this.cbAccessModes.Size = new System.Drawing.Size(132, 21);
			this.cbAccessModes.TabIndex = 2;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(15, 107);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(78, 23);
			this.label3.TabIndex = 0;
			this.label3.Text = "Share Mode:";
			// 
			// cbShareModes
			// 
			this.cbShareModes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbShareModes.Location = new System.Drawing.Point(97, 103);
			this.cbShareModes.Name = "cbShareModes";
			this.cbShareModes.Size = new System.Drawing.Size(132, 21);
			this.cbShareModes.TabIndex = 2;
			// 
			// cbOpenModes
			// 
			this.cbOpenModes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbOpenModes.Location = new System.Drawing.Point(97, 47);
			this.cbOpenModes.Name = "cbOpenModes";
			this.cbOpenModes.Size = new System.Drawing.Size(132, 21);
			this.cbOpenModes.TabIndex = 2;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(15, 49);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(78, 23);
			this.label4.TabIndex = 0;
			this.label4.Text = "Open Mode:";
			// 
			// btOpen
			// 
			this.btOpen.Location = new System.Drawing.Point(98, 139);
			this.btOpen.Name = "btOpen";
			this.btOpen.TabIndex = 3;
			this.btOpen.Text = "Open";
			this.btOpen.Click += new System.EventHandler(this.btOpen_Click);
			// 
			// btClose
			// 
			this.btClose.Location = new System.Drawing.Point(178, 139);
			this.btClose.Name = "btClose";
			this.btClose.TabIndex = 3;
			this.btClose.Text = "Close";
			this.btClose.Click += new System.EventHandler(this.btClose_Click);
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(14, 181);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(81, 23);
			this.label5.TabIndex = 0;
			this.label5.Text = "Current State:";
			// 
			// lbState
			// 
			this.lbState.Location = new System.Drawing.Point(103, 180);
			this.lbState.Name = "lbState";
			this.lbState.Size = new System.Drawing.Size(231, 46);
			this.lbState.TabIndex = 0;
			this.lbState.Text = "Closed";
			// 
			// FormMain
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(350, 240);
			this.Controls.Add(this.btOpen);
			this.Controls.Add(this.cbAccessModes);
			this.Controls.Add(this.txFile);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.cbShareModes);
			this.Controls.Add(this.cbOpenModes);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.btClose);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.lbState);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormMain";
			this.Text = "File Sharing Tester";
			this.Closing += new System.ComponentModel.CancelEventHandler(this.Form1_Closing);
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);

		}
		#endregion

		#region Construction

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new FormMain());
		}

		public FormMain()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}
		#endregion 

		private void Form1_Load(object sender, System.EventArgs e)
		{
			// load the lists
			cbOpenModes.Items.AddRange(Enum.GetNames(typeof(FileMode)));
			cbAccessModes.Items.AddRange(Enum.GetNames(typeof(FileAccess)));
			cbShareModes.Items.AddRange(Enum.GetNames(typeof(FileShare)));

			// select default values
			cbOpenModes.SelectedItem = FileMode.OpenOrCreate.ToString();
			cbAccessModes.SelectedItem = FileAccess.Read.ToString();
			cbShareModes.SelectedItem = FileShare.Read.ToString();

			txFile.Text = @"C:\TestFile.txt";
		}

		private void btOpen_Click(object sender, System.EventArgs e)
		{
			// determine modes
			FileMode openMode = (FileMode)Enum.Parse(typeof(FileMode), cbOpenModes.SelectedItem.ToString());
			FileAccess accessMode = (FileAccess)Enum.Parse(typeof(FileAccess), cbAccessModes.SelectedItem.ToString());
			FileShare shareMode = (FileShare)Enum.Parse(typeof(FileShare), cbShareModes.SelectedItem.ToString());

			// try opening the file
			try
			{
				CloseFile();  // first make sure it's closed
				_fs = new FileStream(txFile.Text, openMode, accessMode, shareMode);
				lbState.Text = string.Format("Open. OpenMode: {0}, AccessMode: {1}, ShareMode: {2}", openMode, accessMode, shareMode);
				toolTip1.SetToolTip(lbState, "");
			}
			catch (Exception exp)
			{
//				int error = GetLastError();
//				if ((error == 32) || (error == 127))
//				{
//					MessageBox.Show(this, "File Sharing violation.\n\n" + exp, "Open Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
//					return;
//				}

				string message = "Error opening file:\n\n" + exp;
				lbState.Text = "Open error";
				toolTip1.SetToolTip(lbState, message);
				MessageBox.Show(this, message, "Open Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		[DllImport("kernel32.dll", CharSet=CharSet.Auto)]
		internal static extern int GetLastError();
	
		private void btClose_Click(object sender, System.EventArgs e)
		{
			CloseFile();
		}

		private void Form1_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{
			CloseFile();
		}

		private void CloseFile()
		{
			lbState.Text = "Closed";
			toolTip1.SetToolTip(lbState, "");

			if (_fs != null)
			{
				try
				{
					_fs.Close();
					_fs = null;
					lbState.Text = "Closed";
					toolTip1.SetToolTip(lbState, "");
				}
				catch (Exception exp)
				{
					string message = "Error closing file:\n\n" + exp;
					lbState.Text = "Close Error";
					toolTip1.SetToolTip(lbState, message);
					MessageBox.Show(this, message, "Close Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}
	}
}
