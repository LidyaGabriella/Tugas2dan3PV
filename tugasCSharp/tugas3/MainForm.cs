using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace tugas3
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
		
		void MainForm_Load(object sender, EventArgs e)
		{
			dataNama.Text = "";
			dataAlamat.Text = "";
			dataLahir.Text = "";
			dataKelamin.Text = "";
		}
		
		void BtSimpan_Click(object sender, EventArgs e)
		{
			//menampilkan Nama, Alamat, Tgl. Lahir
			dataNama.Text = tbNama.Text;
			dataAlamat.Text = tbAlamat.Text;
			dataLahir.Text = dtLahir.Text;
			
			//menampilkan jenis kelamin
			if(rbLaki.Checked == true)
			{
				dataKelamin.Text = rbLaki.Text;
			}
			else
			{
				dataKelamin.Text = rbPerempuan.Text;
			}
			
			//menampilkan data hobi
			lbHobi.Items.Clear();
			int nomor = 0;
			foreach(string hobi in cbHobi.CheckedItems)
			{
				nomor++;
				lbHobi.Items.Add(nomor + ". " + hobi);
			}
		}
		
		void BtReset_Click(object sender, EventArgs e)
		{
			dataNama.Text = "";
			dataAlamat.Text = "";
			dataLahir.Text = "";
			dataKelamin.Text = "";
			lbHobi.Items.Clear();
		}
	}
}
