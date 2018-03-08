namespace WindowsFormsApp1
{
    partial class MoviePics
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
            this.moviePic = new System.Windows.Forms.PictureBox();
            this.movieTitle = new System.Windows.Forms.TextBox();
            this.movieInfo = new System.Windows.Forms.TextBox();
            this.prefButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.userName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.moviePic)).BeginInit();
            this.SuspendLayout();
            // 
            // moviePic
            // 
            this.moviePic.Location = new System.Drawing.Point(12, 38);
            this.moviePic.Name = "moviePic";
            this.moviePic.Size = new System.Drawing.Size(183, 224);
            this.moviePic.TabIndex = 0;
            this.moviePic.TabStop = false;
            // 
            // movieTitle
            // 
            this.movieTitle.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movieTitle.Location = new System.Drawing.Point(225, 53);
            this.movieTitle.Name = "movieTitle";
            this.movieTitle.Size = new System.Drawing.Size(291, 33);
            this.movieTitle.TabIndex = 1;
            // 
            // movieInfo
            // 
            this.movieInfo.Location = new System.Drawing.Point(225, 92);
            this.movieInfo.Name = "movieInfo";
            this.movieInfo.Size = new System.Drawing.Size(568, 20);
            this.movieInfo.TabIndex = 2;
            // 
            // prefButton
            // 
            this.prefButton.Location = new System.Drawing.Point(225, 12);
            this.prefButton.Name = "prefButton";
            this.prefButton.Size = new System.Drawing.Size(131, 23);
            this.prefButton.TabIndex = 3;
            this.prefButton.Text = "Set Preferences";
            this.prefButton.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(362, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Edit User";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // userName
            // 
            this.userName.Location = new System.Drawing.Point(12, 12);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(183, 20);
            this.userName.TabIndex = 5;
            // 
            // MoviePics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 307);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.prefButton);
            this.Controls.Add(this.movieInfo);
            this.Controls.Add(this.movieTitle);
            this.Controls.Add(this.moviePic);
            this.Name = "MoviePics";
            this.Text = "MoviePics";
            ((System.ComponentModel.ISupportInitialize)(this.moviePic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox moviePic;
        private System.Windows.Forms.TextBox movieTitle;
        private System.Windows.Forms.TextBox movieInfo;
        private System.Windows.Forms.Button prefButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox userName;
    }
}