namespace Snake
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.pBoxGame = new System.Windows.Forms.PictureBox();
			this.btnStart = new System.Windows.Forms.Button();
			this.timerGame = new System.Windows.Forms.Timer(this.components);
			this.lblScore = new System.Windows.Forms.Label();
			this.btnExit = new System.Windows.Forms.Button();
			this.lblStart = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pBoxGame)).BeginInit();
			this.SuspendLayout();
			// 
			// pBoxGame
			// 
			this.pBoxGame.BackColor = System.Drawing.Color.Azure;
			this.pBoxGame.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pBoxGame.Location = new System.Drawing.Point(12, 12);
			this.pBoxGame.Name = "pBoxGame";
			this.pBoxGame.Size = new System.Drawing.Size(500, 450);
			this.pBoxGame.TabIndex = 0;
			this.pBoxGame.TabStop = false;
			this.pBoxGame.Paint += new System.Windows.Forms.PaintEventHandler(this.pBoxGame_Paint);
			// 
			// btnStart
			// 
			this.btnStart.BackColor = System.Drawing.Color.PowderBlue;
			this.btnStart.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnStart.Location = new System.Drawing.Point(551, 215);
			this.btnStart.Name = "btnStart";
			this.btnStart.Size = new System.Drawing.Size(146, 43);
			this.btnStart.TabIndex = 1;
			this.btnStart.Text = "Start";
			this.btnStart.UseVisualStyleBackColor = false;
			this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
			// 
			// timerGame
			// 
			this.timerGame.Tick += new System.EventHandler(this.timerGame_Tick);
			// 
			// lblScore
			// 
			this.lblScore.AutoSize = true;
			this.lblScore.Font = new System.Drawing.Font("Segoe Print", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblScore.Location = new System.Drawing.Point(563, 47);
			this.lblScore.Name = "lblScore";
			this.lblScore.Size = new System.Drawing.Size(114, 40);
			this.lblScore.TabIndex = 2;
			this.lblScore.Text = "Score: 0";
			// 
			// btnExit
			// 
			this.btnExit.BackColor = System.Drawing.Color.Crimson;
			this.btnExit.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnExit.Location = new System.Drawing.Point(551, 294);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(146, 43);
			this.btnExit.TabIndex = 3;
			this.btnExit.Text = "Exit";
			this.btnExit.UseVisualStyleBackColor = false;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// lblStart
			// 
			this.lblStart.AutoSize = true;
			this.lblStart.Font = new System.Drawing.Font("Segoe Print", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblStart.Location = new System.Drawing.Point(544, 109);
			this.lblStart.Name = "lblStart";
			this.lblStart.Size = new System.Drawing.Size(184, 40);
			this.lblStart.TabIndex = 4;
			this.lblStart.Text = "Move to start!";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.LightSteelBlue;
			this.ClientSize = new System.Drawing.Size(736, 475);
			this.Controls.Add(this.lblStart);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.lblScore);
			this.Controls.Add(this.btnStart);
			this.Controls.Add(this.pBoxGame);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.KeyPreview = true;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Snake";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
			((System.ComponentModel.ISupportInitialize)(this.pBoxGame)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pBoxGame;
		private System.Windows.Forms.Button btnStart;
		private System.Windows.Forms.Timer timerGame;
		private System.Windows.Forms.Label lblScore;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.Label lblStart;
	}
}

