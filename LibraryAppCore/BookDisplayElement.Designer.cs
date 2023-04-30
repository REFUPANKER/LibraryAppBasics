using System.Windows.Forms;

namespace LibraryAppCore
{
    partial class BookDisplayElement
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            BookImage = new PictureBox();
            BookName = new Label();
            LikeButton = new Button();
            DislikeButton = new Button();
            ((System.ComponentModel.ISupportInitialize)BookImage).BeginInit();
            SuspendLayout();
            // 
            // BookImage
            // 
            BookImage.BackColor = Color.FromArgb(80, 80, 80);
            BookImage.Cursor = Cursors.Hand;
            BookImage.Dock = DockStyle.Top;
            BookImage.Location = new Point(0, 0);
            BookImage.Margin = new Padding(0);
            BookImage.Name = "BookImage";
            BookImage.Size = new Size(250, 200);
            BookImage.TabIndex = 0;
            BookImage.TabStop = false;
            // 
            // BookName
            // 
            BookName.BackColor = Color.FromArgb(60, 60, 60);
            BookName.Dock = DockStyle.Top;
            BookName.ForeColor = Color.White;
            BookName.Location = new Point(0, 200);
            BookName.MaximumSize = new Size(250, 70);
            BookName.Name = "BookName";
            BookName.Size = new Size(250, 70);
            BookName.TabIndex = 1;
            BookName.Text = "BookName";
            // 
            // LikeButton
            // 
            LikeButton.BackColor = Color.FromArgb(45, 45, 45);
            LikeButton.FlatAppearance.BorderSize = 0;
            LikeButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 64, 64);
            LikeButton.FlatAppearance.MouseOverBackColor = Color.Gray;
            LikeButton.FlatStyle = FlatStyle.Flat;
            LikeButton.ForeColor = Color.White;
            LikeButton.Location = new Point(0, 270);
            LikeButton.Name = "LikeButton";
            LikeButton.Size = new Size(125, 30);
            LikeButton.TabIndex = 2;
            LikeButton.Text = "👍";
            LikeButton.UseVisualStyleBackColor = false;
            LikeButton.Click += LikeButton_Click;
            // 
            // DislikeButton
            // 
            DislikeButton.BackColor = Color.FromArgb(45, 45, 45);
            DislikeButton.FlatAppearance.BorderSize = 0;
            DislikeButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 64, 64);
            DislikeButton.FlatAppearance.MouseOverBackColor = Color.Gray;
            DislikeButton.FlatStyle = FlatStyle.Flat;
            DislikeButton.ForeColor = Color.White;
            DislikeButton.Location = new Point(125, 270);
            DislikeButton.Name = "DislikeButton";
            DislikeButton.Size = new Size(125, 30);
            DislikeButton.TabIndex = 3;
            DislikeButton.Text = "👎";
            DislikeButton.UseVisualStyleBackColor = false;
            DislikeButton.Click += DislikeButton_Click;
            // 
            // BookDisplayElement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(120, 120, 120);
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(DislikeButton);
            Controls.Add(LikeButton);
            Controls.Add(BookName);
            Controls.Add(BookImage);
            Location = new Point(10, 10);
            Margin = new Padding(10);
            Name = "BookDisplayElement";
            Size = new Size(250, 300);
            ((System.ComponentModel.ISupportInitialize)BookImage).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox BookImage;
        private Label BookName;
        private Button LikeButton;
        private Button DislikeButton;
    }
}
