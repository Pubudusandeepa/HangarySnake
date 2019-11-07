namespace WindowsFormsApp2
{
    partial class frmSnake
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSnake));
            this.picGameBoard = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.imgList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picGameBoard)).BeginInit();
            this.SuspendLayout();
            // 
            // picGameBoard
            // 
            this.picGameBoard.Location = new System.Drawing.Point(67, 26);
            this.picGameBoard.Name = "picGameBoard";
            this.picGameBoard.Size = new System.Drawing.Size(420, 420);
            this.picGameBoard.TabIndex = 0;
            this.picGameBoard.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            // 
            // imgList1
            // 
            this.imgList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgList1.ImageStream")));
            this.imgList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imgList1.Images.SetKeyName(0, "bonus1.png");
            this.imgList1.Images.SetKeyName(1, "bonus2.png");
            this.imgList1.Images.SetKeyName(2, "bonus3.png");
            this.imgList1.Images.SetKeyName(3, "bonus4.png");
            this.imgList1.Images.SetKeyName(4, "snake_body.png");
            this.imgList1.Images.SetKeyName(5, "snake_head.png");
            this.imgList1.Images.SetKeyName(6, "wall.png");
            // 
            // frmSnake
            // 
            this.ClientSize = new System.Drawing.Size(568, 531);
            this.Controls.Add(this.picGameBoard);
            this.Name = "frmSnake";
            this.Load += new System.EventHandler(this.frmSnake_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.picGameBoard)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ImageList imgList;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.PictureBox picGameBoard;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ImageList imgList1;
    }
}

