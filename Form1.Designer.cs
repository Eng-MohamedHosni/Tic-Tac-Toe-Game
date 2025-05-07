namespace Tic_Tac_Toe
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbTurn = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbWinner = new System.Windows.Forms.Label();
            this.btnRestartGame = new System.Windows.Forms.Button();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.siticoneCloseButton1 = new SiticoneNetFrameworkUI.SiticoneCloseButton();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pb9 = new System.Windows.Forms.PictureBox();
            this.pb2 = new System.Windows.Forms.PictureBox();
            this.pb3 = new System.Windows.Forms.PictureBox();
            this.pb6 = new System.Windows.Forms.PictureBox();
            this.pb5 = new System.Windows.Forms.PictureBox();
            this.pb4 = new System.Windows.Forms.PictureBox();
            this.pb7 = new System.Windows.Forms.PictureBox();
            this.pb8 = new System.Windows.Forms.PictureBox();
            this.pb1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlText;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(79, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tic-Tac-Toe Game";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlText;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(45, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 45);
            this.label2.TabIndex = 10;
            this.label2.Text = "Turn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(99, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 45);
            this.label3.TabIndex = 11;
            // 
            // lbTurn
            // 
            this.lbTurn.AutoSize = true;
            this.lbTurn.BackColor = System.Drawing.SystemColors.ControlText;
            this.lbTurn.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTurn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbTurn.Location = new System.Drawing.Point(45, 150);
            this.lbTurn.Name = "lbTurn";
            this.lbTurn.Size = new System.Drawing.Size(190, 45);
            this.lbTurn.TabIndex = 12;
            this.lbTurn.Text = "Player Turn";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ControlText;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(45, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 45);
            this.label5.TabIndex = 13;
            this.label5.Text = "Winner";
            // 
            // lbWinner
            // 
            this.lbWinner.AutoSize = true;
            this.lbWinner.BackColor = System.Drawing.SystemColors.Desktop;
            this.lbWinner.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWinner.ForeColor = System.Drawing.Color.Lime;
            this.lbWinner.Location = new System.Drawing.Point(45, 269);
            this.lbWinner.Name = "lbWinner";
            this.lbWinner.Size = new System.Drawing.Size(189, 45);
            this.lbWinner.TabIndex = 14;
            this.lbWinner.Tag = "5";
            this.lbWinner.Text = "In Progress";
            // 
            // btnRestartGame
            // 
            this.btnRestartGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestartGame.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestartGame.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRestartGame.Location = new System.Drawing.Point(40, 361);
            this.btnRestartGame.Name = "btnRestartGame";
            this.btnRestartGame.Size = new System.Drawing.Size(210, 63);
            this.btnRestartGame.TabIndex = 15;
            this.btnRestartGame.Text = "Restart Game";
            this.btnRestartGame.UseVisualStyleBackColor = true;
            this.btnRestartGame.Click += new System.EventHandler(this.button1_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this;
            // 
            // siticoneCloseButton1
            // 
            this.siticoneCloseButton1.BackColor = System.Drawing.Color.Transparent;
            this.siticoneCloseButton1.CountdownFont = new System.Drawing.Font("Segoe UI", 9F);
            this.siticoneCloseButton1.EnableSound = false;
            this.siticoneCloseButton1.IconColor = System.Drawing.Color.Red;
            this.siticoneCloseButton1.IconSize = 12;
            this.siticoneCloseButton1.IconThickness = 3;
            this.siticoneCloseButton1.Location = new System.Drawing.Point(798, -1);
            this.siticoneCloseButton1.Name = "siticoneCloseButton1";
            this.siticoneCloseButton1.Size = new System.Drawing.Size(40, 40);
            this.siticoneCloseButton1.TabIndex = 17;
            this.siticoneCloseButton1.Text = "siticoneCloseButton1";
            this.siticoneCloseButton1.TooltipText = "Close button";
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = this;
            // 
            // pictureBox10
            // 
            this.pictureBox10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox10.Image = global::Tic_Tac_Toe.Properties.Resources.Xo;
            this.pictureBox10.Location = new System.Drawing.Point(22, 19);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(51, 47);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox10.TabIndex = 16;
            this.pictureBox10.TabStop = false;
            // 
            // pb9
            // 
            this.pb9.BackColor = System.Drawing.Color.Transparent;
            this.pb9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb9.Image = global::Tic_Tac_Toe.Properties.Resources.question_mark_96;
            this.pb9.Location = new System.Drawing.Point(668, 354);
            this.pb9.Name = "pb9";
            this.pb9.Size = new System.Drawing.Size(121, 96);
            this.pb9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb9.TabIndex = 9;
            this.pb9.TabStop = false;
            this.pb9.Tag = "?";
            this.pb9.Click += new System.EventHandler(this.pb_Click);
            // 
            // pb2
            // 
            this.pb2.BackColor = System.Drawing.Color.Transparent;
            this.pb2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb2.Image = global::Tic_Tac_Toe.Properties.Resources.question_mark_96;
            this.pb2.Location = new System.Drawing.Point(501, 90);
            this.pb2.Name = "pb2";
            this.pb2.Size = new System.Drawing.Size(121, 96);
            this.pb2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb2.TabIndex = 8;
            this.pb2.TabStop = false;
            this.pb2.Tag = "?";
            this.pb2.Click += new System.EventHandler(this.pb_Click);
            // 
            // pb3
            // 
            this.pb3.BackColor = System.Drawing.Color.Transparent;
            this.pb3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb3.Image = global::Tic_Tac_Toe.Properties.Resources.question_mark_96;
            this.pb3.Location = new System.Drawing.Point(668, 90);
            this.pb3.Name = "pb3";
            this.pb3.Size = new System.Drawing.Size(121, 96);
            this.pb3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb3.TabIndex = 7;
            this.pb3.TabStop = false;
            this.pb3.Tag = "?";
            this.pb3.Click += new System.EventHandler(this.pb_Click);
            // 
            // pb6
            // 
            this.pb6.BackColor = System.Drawing.Color.Transparent;
            this.pb6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb6.Image = global::Tic_Tac_Toe.Properties.Resources.question_mark_96;
            this.pb6.Location = new System.Drawing.Point(668, 225);
            this.pb6.Name = "pb6";
            this.pb6.Size = new System.Drawing.Size(121, 96);
            this.pb6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb6.TabIndex = 6;
            this.pb6.TabStop = false;
            this.pb6.Tag = "?";
            this.pb6.Click += new System.EventHandler(this.pb_Click);
            // 
            // pb5
            // 
            this.pb5.BackColor = System.Drawing.Color.Transparent;
            this.pb5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb5.Image = global::Tic_Tac_Toe.Properties.Resources.question_mark_96;
            this.pb5.Location = new System.Drawing.Point(501, 225);
            this.pb5.Name = "pb5";
            this.pb5.Size = new System.Drawing.Size(121, 96);
            this.pb5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb5.TabIndex = 5;
            this.pb5.TabStop = false;
            this.pb5.Tag = "?";
            this.pb5.Click += new System.EventHandler(this.pb_Click);
            // 
            // pb4
            // 
            this.pb4.BackColor = System.Drawing.Color.Transparent;
            this.pb4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb4.Image = global::Tic_Tac_Toe.Properties.Resources.question_mark_96;
            this.pb4.Location = new System.Drawing.Point(344, 225);
            this.pb4.Name = "pb4";
            this.pb4.Size = new System.Drawing.Size(121, 96);
            this.pb4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb4.TabIndex = 4;
            this.pb4.TabStop = false;
            this.pb4.Tag = "?";
            this.pb4.Click += new System.EventHandler(this.pb_Click);
            // 
            // pb7
            // 
            this.pb7.BackColor = System.Drawing.Color.Transparent;
            this.pb7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb7.Image = global::Tic_Tac_Toe.Properties.Resources.question_mark_96;
            this.pb7.Location = new System.Drawing.Point(344, 354);
            this.pb7.Name = "pb7";
            this.pb7.Size = new System.Drawing.Size(121, 96);
            this.pb7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb7.TabIndex = 3;
            this.pb7.TabStop = false;
            this.pb7.Tag = "?";
            this.pb7.Click += new System.EventHandler(this.pb_Click);
            // 
            // pb8
            // 
            this.pb8.BackColor = System.Drawing.Color.Transparent;
            this.pb8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb8.Image = global::Tic_Tac_Toe.Properties.Resources.question_mark_96;
            this.pb8.Location = new System.Drawing.Point(501, 354);
            this.pb8.Name = "pb8";
            this.pb8.Size = new System.Drawing.Size(121, 96);
            this.pb8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb8.TabIndex = 2;
            this.pb8.TabStop = false;
            this.pb8.Tag = "?";
            this.pb8.Click += new System.EventHandler(this.pb_Click);
            // 
            // pb1
            // 
            this.pb1.BackColor = System.Drawing.Color.Transparent;
            this.pb1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb1.Image = global::Tic_Tac_Toe.Properties.Resources.question_mark_96;
            this.pb1.Location = new System.Drawing.Point(344, 90);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(121, 96);
            this.pb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb1.TabIndex = 1;
            this.pb1.TabStop = false;
            this.pb1.Tag = "?";
            this.pb1.Click += new System.EventHandler(this.pb_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(850, 494);
            this.Controls.Add(this.siticoneCloseButton1);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.btnRestartGame);
            this.Controls.Add(this.lbWinner);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbTurn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pb9);
            this.Controls.Add(this.pb2);
            this.Controls.Add(this.pb3);
            this.Controls.Add(this.pb6);
            this.Controls.Add(this.pb5);
            this.Controls.Add(this.pb4);
            this.Controls.Add(this.pb7);
            this.Controls.Add(this.pb8);
            this.Controls.Add(this.pb1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tic-Tac-Toe";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.pb_Click);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pb1;
        private System.Windows.Forms.PictureBox pb8;
        private System.Windows.Forms.PictureBox pb7;
        private System.Windows.Forms.PictureBox pb4;
        private System.Windows.Forms.PictureBox pb5;
        private System.Windows.Forms.PictureBox pb6;
        private System.Windows.Forms.PictureBox pb3;
        private System.Windows.Forms.PictureBox pb2;
        private System.Windows.Forms.PictureBox pb9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbTurn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbWinner;
        private System.Windows.Forms.Button btnRestartGame;
        private System.Windows.Forms.PictureBox pictureBox10;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private SiticoneNetFrameworkUI.SiticoneCloseButton siticoneCloseButton1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
    }
}

