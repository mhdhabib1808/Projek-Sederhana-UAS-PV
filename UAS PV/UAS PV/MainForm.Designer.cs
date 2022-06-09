/*
 * Created by SharpDevelop.
 * User: ACER
 * Date: 09/06/2022
 * Time: 13:11
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace UAS_PV
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.insertBtn = new System.Windows.Forms.Button();
			this.Nama = new System.Windows.Forms.TextBox();
			this.Harga = new System.Windows.Forms.TextBox();
			this.Jenis = new System.Windows.Forms.ComboBox();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(29, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(329, 50);
			this.label1.TabIndex = 0;
			this.label1.Text = "Gudang Kulkas";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(29, 76);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "Nama";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(29, 123);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 2;
			this.label3.Text = "Harga";
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(29, 179);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 3;
			this.label4.Text = "Jenis Kulkas\r\n";
			// 
			// insertBtn
			// 
			this.insertBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.insertBtn.Location = new System.Drawing.Point(57, 231);
			this.insertBtn.Name = "insertBtn";
			this.insertBtn.Size = new System.Drawing.Size(266, 46);
			this.insertBtn.TabIndex = 4;
			this.insertBtn.Text = "Insert To Database";
			this.insertBtn.UseVisualStyleBackColor = true;
			this.insertBtn.Click += new System.EventHandler(this.Button1Click);
			// 
			// Nama
			// 
			this.Nama.Location = new System.Drawing.Point(158, 76);
			this.Nama.Name = "Nama";
			this.Nama.Size = new System.Drawing.Size(121, 26);
			this.Nama.TabIndex = 5;
			// 
			// Harga
			// 
			this.Harga.Location = new System.Drawing.Point(158, 123);
			this.Harga.Name = "Harga";
			this.Harga.Size = new System.Drawing.Size(121, 26);
			this.Harga.TabIndex = 6;
			// 
			// Jenis
			// 
			this.Jenis.FormattingEnabled = true;
			this.Jenis.Items.AddRange(new object[] {
									"Side By Side",
									"Top Freezer",
									"Showcase"});
			this.Jenis.Location = new System.Drawing.Point(158, 174);
			this.Jenis.Name = "Jenis";
			this.Jenis.Size = new System.Drawing.Size(121, 28);
			this.Jenis.TabIndex = 7;
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(29, 302);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowTemplate.Height = 28;
			this.dataGridView1.Size = new System.Drawing.Size(329, 150);
			this.dataGridView1.TabIndex = 8;
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1CellContentClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(388, 464);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.Jenis);
			this.Controls.Add(this.Harga);
			this.Controls.Add(this.Nama);
			this.Controls.Add(this.insertBtn);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "MainForm";
			this.Text = "UAS PV";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.ComboBox Jenis;
		private System.Windows.Forms.TextBox Harga;
		private System.Windows.Forms.TextBox Nama;
		private System.Windows.Forms.Button insertBtn;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}
