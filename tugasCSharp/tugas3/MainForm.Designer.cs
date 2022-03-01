/*
 * Created by SharpDevelop.
 * User: USER
 * Date: 3/1/2022
 * Time: 11:55 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace tugas3
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btSimpan = new System.Windows.Forms.Button();
			this.cbHobi = new System.Windows.Forms.CheckedListBox();
			this.tbAlamat = new System.Windows.Forms.TextBox();
			this.rbPerempuan = new System.Windows.Forms.RadioButton();
			this.rbLaki = new System.Windows.Forms.RadioButton();
			this.dtLahir = new System.Windows.Forms.DateTimePicker();
			this.tbNama = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.btReset = new System.Windows.Forms.Button();
			this.lbHobi = new System.Windows.Forms.ListBox();
			this.dataAlamat = new System.Windows.Forms.Label();
			this.dataKelamin = new System.Windows.Forms.Label();
			this.dataLahir = new System.Windows.Forms.Label();
			this.dataNama = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btSimpan);
			this.groupBox1.Controls.Add(this.cbHobi);
			this.groupBox1.Controls.Add(this.tbAlamat);
			this.groupBox1.Controls.Add(this.rbPerempuan);
			this.groupBox1.Controls.Add(this.rbLaki);
			this.groupBox1.Controls.Add(this.dtLahir);
			this.groupBox1.Controls.Add(this.tbNama);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(339, 324);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "FORM";
			// 
			// btSimpan
			// 
			this.btSimpan.Location = new System.Drawing.Point(236, 267);
			this.btSimpan.Name = "btSimpan";
			this.btSimpan.Size = new System.Drawing.Size(75, 23);
			this.btSimpan.TabIndex = 11;
			this.btSimpan.Text = "Simpan";
			this.btSimpan.UseVisualStyleBackColor = true;
			this.btSimpan.Click += new System.EventHandler(this.BtSimpan_Click);
			// 
			// cbHobi
			// 
			this.cbHobi.BackColor = System.Drawing.Color.Cyan;
			this.cbHobi.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.cbHobi.CheckOnClick = true;
			this.cbHobi.FormattingEnabled = true;
			this.cbHobi.Items.AddRange(new object[] {
									"Membaca",
									"Olahraga",
									"Travelling",
									"Seni"});
			this.cbHobi.Location = new System.Drawing.Point(102, 171);
			this.cbHobi.Name = "cbHobi";
			this.cbHobi.Size = new System.Drawing.Size(209, 90);
			this.cbHobi.TabIndex = 10;
			// 
			// tbAlamat
			// 
			this.tbAlamat.Location = new System.Drawing.Point(102, 137);
			this.tbAlamat.Name = "tbAlamat";
			this.tbAlamat.Size = new System.Drawing.Size(209, 23);
			this.tbAlamat.TabIndex = 9;
			// 
			// rbPerempuan
			// 
			this.rbPerempuan.Location = new System.Drawing.Point(102, 106);
			this.rbPerempuan.Name = "rbPerempuan";
			this.rbPerempuan.Size = new System.Drawing.Size(104, 23);
			this.rbPerempuan.TabIndex = 8;
			this.rbPerempuan.TabStop = true;
			this.rbPerempuan.Text = "Perempuan";
			this.rbPerempuan.UseVisualStyleBackColor = true;
			// 
			// rbLaki
			// 
			this.rbLaki.Location = new System.Drawing.Point(102, 83);
			this.rbLaki.Name = "rbLaki";
			this.rbLaki.Size = new System.Drawing.Size(104, 23);
			this.rbLaki.TabIndex = 7;
			this.rbLaki.TabStop = true;
			this.rbLaki.Text = "Laki Laki";
			this.rbLaki.UseVisualStyleBackColor = true;
			// 
			// dtLahir
			// 
			this.dtLahir.Location = new System.Drawing.Point(102, 57);
			this.dtLahir.Name = "dtLahir";
			this.dtLahir.Size = new System.Drawing.Size(209, 23);
			this.dtLahir.TabIndex = 6;
			// 
			// tbNama
			// 
			this.tbNama.Location = new System.Drawing.Point(102, 30);
			this.tbNama.Name = "tbNama";
			this.tbNama.Size = new System.Drawing.Size(209, 23);
			this.tbNama.TabIndex = 5;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(6, 171);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(81, 23);
			this.label5.TabIndex = 4;
			this.label5.Text = "Hobi";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(6, 137);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(81, 23);
			this.label4.TabIndex = 3;
			this.label4.Text = "Alamat";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(6, 83);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(81, 23);
			this.label3.TabIndex = 2;
			this.label3.Text = "J. Kelamin";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(6, 57);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(81, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "Tgl. Lahir";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(6, 30);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(81, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Nama";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.btReset);
			this.groupBox2.Controls.Add(this.lbHobi);
			this.groupBox2.Controls.Add(this.dataAlamat);
			this.groupBox2.Controls.Add(this.dataKelamin);
			this.groupBox2.Controls.Add(this.dataLahir);
			this.groupBox2.Controls.Add(this.dataNama);
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Controls.Add(this.label7);
			this.groupBox2.Controls.Add(this.label8);
			this.groupBox2.Controls.Add(this.label9);
			this.groupBox2.Controls.Add(this.label10);
			this.groupBox2.Location = new System.Drawing.Point(359, 12);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(339, 324);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "DATA";
			// 
			// btReset
			// 
			this.btReset.Location = new System.Drawing.Point(234, 267);
			this.btReset.Name = "btReset";
			this.btReset.Size = new System.Drawing.Size(75, 23);
			this.btReset.TabIndex = 15;
			this.btReset.Text = "Reset";
			this.btReset.UseVisualStyleBackColor = true;
			this.btReset.Click += new System.EventHandler(this.BtReset_Click);
			// 
			// lbHobi
			// 
			this.lbHobi.BackColor = System.Drawing.Color.Cyan;
			this.lbHobi.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.lbHobi.FormattingEnabled = true;
			this.lbHobi.ItemHeight = 15;
			this.lbHobi.Location = new System.Drawing.Point(115, 135);
			this.lbHobi.Name = "lbHobi";
			this.lbHobi.Size = new System.Drawing.Size(194, 90);
			this.lbHobi.TabIndex = 14;
			// 
			// dataAlamat
			// 
			this.dataAlamat.Location = new System.Drawing.Point(115, 109);
			this.dataAlamat.Name = "dataAlamat";
			this.dataAlamat.Size = new System.Drawing.Size(81, 23);
			this.dataAlamat.TabIndex = 13;
			this.dataAlamat.Text = "Alamat";
			// 
			// dataKelamin
			// 
			this.dataKelamin.Location = new System.Drawing.Point(115, 83);
			this.dataKelamin.Name = "dataKelamin";
			this.dataKelamin.Size = new System.Drawing.Size(81, 23);
			this.dataKelamin.TabIndex = 12;
			this.dataKelamin.Text = "J. Kelamin";
			// 
			// dataLahir
			// 
			this.dataLahir.Location = new System.Drawing.Point(115, 57);
			this.dataLahir.Name = "dataLahir";
			this.dataLahir.Size = new System.Drawing.Size(81, 23);
			this.dataLahir.TabIndex = 11;
			this.dataLahir.Text = "Tgl. Lahir";
			// 
			// dataNama
			// 
			this.dataNama.Location = new System.Drawing.Point(115, 30);
			this.dataNama.Name = "dataNama";
			this.dataNama.Size = new System.Drawing.Size(81, 23);
			this.dataNama.TabIndex = 10;
			this.dataNama.Text = "Nama";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(6, 135);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(81, 23);
			this.label6.TabIndex = 9;
			this.label6.Text = "Hobi :";
			this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(6, 109);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(81, 23);
			this.label7.TabIndex = 8;
			this.label7.Text = "Alamat :";
			this.label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(6, 83);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(81, 23);
			this.label8.TabIndex = 7;
			this.label8.Text = "J. Kelamin :";
			this.label8.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(6, 57);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(81, 23);
			this.label9.TabIndex = 6;
			this.label9.Text = "Tgl. Lahir :";
			this.label9.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// label10
			// 
			this.label10.Location = new System.Drawing.Point(6, 30);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(81, 23);
			this.label10.TabIndex = 5;
			this.label10.Text = "Nama :";
			this.label10.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Cyan;
			this.ClientSize = new System.Drawing.Size(710, 348);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Font = new System.Drawing.Font("Imprint MT Shadow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.Name = "MainForm";
			this.Text = "tugas3";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label dataNama;
		private System.Windows.Forms.Label dataLahir;
		private System.Windows.Forms.Label dataKelamin;
		private System.Windows.Forms.Label dataAlamat;
		private System.Windows.Forms.ListBox lbHobi;
		private System.Windows.Forms.Button btReset;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox tbNama;
		private System.Windows.Forms.DateTimePicker dtLahir;
		private System.Windows.Forms.RadioButton rbLaki;
		private System.Windows.Forms.RadioButton rbPerempuan;
		private System.Windows.Forms.TextBox tbAlamat;
		private System.Windows.Forms.CheckedListBox cbHobi;
		private System.Windows.Forms.Button btSimpan;
		private System.Windows.Forms.GroupBox groupBox1;
	}
}
