namespace KelimeOgren
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.label1 = new System.Windows.Forms.Label();
			this.TxtEnglish = new System.Windows.Forms.TextBox();
			this.TxtTurkish = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.LblKelime = new System.Windows.Forms.Label();
			this.LblTimer = new System.Windows.Forms.Label();
			this.LblCounter = new System.Windows.Forms.Label();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.BtnGoster = new System.Windows.Forms.Button();
			this.BtnPas = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(13, 32);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(66, 19);
			this.label1.TabIndex = 0;
			this.label1.Text = "İngilizce:";
			// 
			// TxtEnglish
			// 
			this.TxtEnglish.Location = new System.Drawing.Point(95, 29);
			this.TxtEnglish.Name = "TxtEnglish";
			this.TxtEnglish.Size = new System.Drawing.Size(234, 27);
			this.TxtEnglish.TabIndex = 1;
			// 
			// TxtTurkish
			// 
			this.TxtTurkish.Location = new System.Drawing.Point(95, 62);
			this.TxtTurkish.Name = "TxtTurkish";
			this.TxtTurkish.Size = new System.Drawing.Size(234, 27);
			this.TxtTurkish.TabIndex = 1;
			this.TxtTurkish.TextChanged += new System.EventHandler(this.TxtTurkish_TextChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 65);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(55, 19);
			this.label2.TabIndex = 0;
			this.label2.Text = "Türkçe:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(460, 32);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(41, 19);
			this.label3.TabIndex = 2;
			this.label3.Text = "Süre:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(449, 65);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(52, 19);
			this.label4.TabIndex = 2;
			this.label4.Text = "Doğru:";
			// 
			// LblKelime
			// 
			this.LblKelime.AutoSize = true;
			this.LblKelime.Location = new System.Drawing.Point(91, 96);
			this.LblKelime.Name = "LblKelime";
			this.LblKelime.Size = new System.Drawing.Size(49, 19);
			this.LblKelime.TabIndex = 2;
			this.LblKelime.Text = "label3";
			this.LblKelime.Visible = false;
			// 
			// LblTimer
			// 
			this.LblTimer.AutoSize = true;
			this.LblTimer.Location = new System.Drawing.Point(523, 32);
			this.LblTimer.Name = "LblTimer";
			this.LblTimer.Size = new System.Drawing.Size(25, 19);
			this.LblTimer.TabIndex = 2;
			this.LblTimer.Text = "90";
			// 
			// LblCounter
			// 
			this.LblCounter.AutoSize = true;
			this.LblCounter.Location = new System.Drawing.Point(523, 65);
			this.LblCounter.Name = "LblCounter";
			this.LblCounter.Size = new System.Drawing.Size(17, 19);
			this.LblCounter.TabIndex = 2;
			this.LblCounter.Text = "0";
			// 
			// timer1
			// 
			this.timer1.Interval = 1000;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// BtnGoster
			// 
			this.BtnGoster.Location = new System.Drawing.Point(335, 63);
			this.BtnGoster.Name = "BtnGoster";
			this.BtnGoster.Size = new System.Drawing.Size(75, 26);
			this.BtnGoster.TabIndex = 3;
			this.BtnGoster.Text = "Göster";
			this.BtnGoster.UseVisualStyleBackColor = true;
			this.BtnGoster.Click += new System.EventHandler(this.button1_Click);
			// 
			// BtnPas
			// 
			this.BtnPas.BackColor = System.Drawing.Color.Yellow;
			this.BtnPas.Location = new System.Drawing.Point(336, 29);
			this.BtnPas.Name = "BtnPas";
			this.BtnPas.Size = new System.Drawing.Size(74, 28);
			this.BtnPas.TabIndex = 4;
			this.BtnPas.Text = "Pas";
			this.BtnPas.UseVisualStyleBackColor = false;
			this.BtnPas.Click += new System.EventHandler(this.BtnPas_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.CornflowerBlue;
			this.ClientSize = new System.Drawing.Size(582, 127);
			this.Controls.Add(this.BtnPas);
			this.Controls.Add(this.BtnGoster);
			this.Controls.Add(this.LblKelime);
			this.Controls.Add(this.LblCounter);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.LblTimer);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.TxtTurkish);
			this.Controls.Add(this.TxtEnglish);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "Form1";
			this.Text = "Kelime Öğren";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox TxtEnglish;
		private System.Windows.Forms.TextBox TxtTurkish;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label LblKelime;
		private System.Windows.Forms.Label LblTimer;
		private System.Windows.Forms.Label LblCounter;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Button BtnGoster;
		private System.Windows.Forms.Button BtnPas;
	}
}

