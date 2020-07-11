namespace game
{
    partial class GameCaro
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.stop = new System.Windows.Forms.Button();
            this.run = new System.Windows.Forms.Button();
            this.Vol = new System.Windows.Forms.Button();
            this.Closebtn = new System.Windows.Forms.Button();
            this.Clientbtn = new System.Windows.Forms.Button();
            this.Serverbtn = new System.Windows.Forms.Button();
            this.pictureGame = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureGame)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.stop);
            this.panel1.Controls.Add(this.run);
            this.panel1.Controls.Add(this.Vol);
            this.panel1.Controls.Add(this.Closebtn);
            this.panel1.Controls.Add(this.Clientbtn);
            this.panel1.Controls.Add(this.Serverbtn);
            this.panel1.Controls.Add(this.pictureGame);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(796, 448);
            this.panel1.TabIndex = 0;
            // 
            // stop
            // 
            this.stop.BackColor = System.Drawing.Color.Aqua;
            this.stop.Location = new System.Drawing.Point(744, 401);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(44, 37);
            this.stop.TabIndex = 6;
            this.stop.UseVisualStyleBackColor = false;
            this.stop.Click += new System.EventHandler(this.stop_Click);
            // 
            // run
            // 
            this.run.BackColor = System.Drawing.Color.Aqua;
            this.run.Location = new System.Drawing.Point(695, 401);
            this.run.Name = "run";
            this.run.Size = new System.Drawing.Size(44, 37);
            this.run.TabIndex = 5;
            this.run.UseVisualStyleBackColor = false;
            this.run.Click += new System.EventHandler(this.run_Click);
            // 
            // Vol
            // 
            this.Vol.BackColor = System.Drawing.Color.Aqua;
            this.Vol.Location = new System.Drawing.Point(645, 401);
            this.Vol.Name = "Vol";
            this.Vol.Size = new System.Drawing.Size(44, 37);
            this.Vol.TabIndex = 4;
            this.Vol.UseVisualStyleBackColor = false;
            this.Vol.Click += new System.EventHandler(this.Vol_Click);
            // 
            // Closebtn
            // 
            this.Closebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Closebtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Closebtn.Location = new System.Drawing.Point(288, 340);
            this.Closebtn.Name = "Closebtn";
            this.Closebtn.Size = new System.Drawing.Size(232, 57);
            this.Closebtn.TabIndex = 3;
            this.Closebtn.Text = "Quit";
            this.Closebtn.UseVisualStyleBackColor = false;
            this.Closebtn.Click += new System.EventHandler(this.Closebtn_Click);
            // 
            // Clientbtn
            // 
            this.Clientbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Clientbtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clientbtn.Location = new System.Drawing.Point(288, 249);
            this.Clientbtn.Name = "Clientbtn";
            this.Clientbtn.Size = new System.Drawing.Size(232, 57);
            this.Clientbtn.TabIndex = 2;
            this.Clientbtn.Text = "Start - Client";
            this.Clientbtn.UseVisualStyleBackColor = false;
            this.Clientbtn.Click += new System.EventHandler(this.Clientbtn_Click);
            // 
            // Serverbtn
            // 
            this.Serverbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Serverbtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Serverbtn.Location = new System.Drawing.Point(288, 160);
            this.Serverbtn.Name = "Serverbtn";
            this.Serverbtn.Size = new System.Drawing.Size(232, 57);
            this.Serverbtn.TabIndex = 1;
            this.Serverbtn.Text = "Creat Game - Server";
            this.Serverbtn.UseVisualStyleBackColor = false;
            this.Serverbtn.Click += new System.EventHandler(this.Serverbtn_Click);
            // 
            // pictureGame
            // 
            this.pictureGame.Location = new System.Drawing.Point(0, 0);
            this.pictureGame.Name = "pictureGame";
            this.pictureGame.Size = new System.Drawing.Size(796, 448);
            this.pictureGame.TabIndex = 0;
            this.pictureGame.TabStop = false;
            // 
            // GameCaro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "GameCaro";
            this.Text = "GameCaro";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureGame)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Closebtn;
        private System.Windows.Forms.Button Clientbtn;
        private System.Windows.Forms.Button Serverbtn;
        private System.Windows.Forms.PictureBox pictureGame;
        private System.Windows.Forms.Button Vol;
        private System.Windows.Forms.Button stop;
        private System.Windows.Forms.Button run;
    }
}

