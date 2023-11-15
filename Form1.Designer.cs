namespace textpicturebox
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel2=new Panel();
            pictureBox1=new PictureBox();
            iconButton1=new FontAwesome.Sharp.IconButton();
            iconButton2=new FontAwesome.Sharp.IconButton();
            iconButton3=new FontAwesome.Sharp.IconButton();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor=SystemColors.ActiveCaption;
            panel2.BackgroundImageLayout=ImageLayout.None;
            panel2.Controls.Add(iconButton3);
            panel2.Controls.Add(iconButton2);
            panel2.Controls.Add(iconButton1);
            panel2.Dock=DockStyle.Bottom;
            panel2.Location=new Point(0, 456);
            panel2.Name="panel2";
            panel2.Size=new Size(800, 35);
            panel2.TabIndex=1;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock=DockStyle.Fill;
            pictureBox1.Image=(Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location=new Point(0, 0);
            pictureBox1.Name="pictureBox1";
            pictureBox1.Size=new Size(800, 456);
            pictureBox1.SizeMode=PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex=0;
            pictureBox1.TabStop=false;
            pictureBox1.Click+=pictureBox1_Click;
            // 
            // iconButton1
            // 
            iconButton1.Anchor=AnchorStyles.Bottom;
            iconButton1.BackColor=SystemColors.ButtonFace;
            iconButton1.IconChar=FontAwesome.Sharp.IconChar.MicrophoneSlash;
            iconButton1.IconColor=Color.Black;
            iconButton1.IconFont=FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize=40;
            iconButton1.Location=new Point(313, -1);
            iconButton1.Name="iconButton1";
            iconButton1.Size=new Size(52, 35);
            iconButton1.TabIndex=4;
            iconButton1.UseVisualStyleBackColor=false;
            iconButton1.Click+=iconButton1_Click;
            // 
            // iconButton2
            // 
            iconButton2.Anchor=AnchorStyles.Bottom;
            iconButton2.IconChar=FontAwesome.Sharp.IconChar.Cancel;
            iconButton2.IconColor=Color.Black;
            iconButton2.IconFont=FontAwesome.Sharp.IconFont.Auto;
            iconButton2.IconSize=25;
            iconButton2.ImageAlign=ContentAlignment.MiddleLeft;
            iconButton2.Location=new Point(414, 1);
            iconButton2.Name="iconButton2";
            iconButton2.Size=new Size(101, 34);
            iconButton2.TabIndex=5;
            iconButton2.Text="Terminate";
            iconButton2.TextAlign=ContentAlignment.MiddleRight;
            iconButton2.UseVisualStyleBackColor=true;
            // 
            // iconButton3
            // 
            iconButton3.Anchor=AnchorStyles.Bottom|AnchorStyles.Right;
            iconButton3.IconChar=FontAwesome.Sharp.IconChar.Comments;
            iconButton3.IconColor=Color.Black;
            iconButton3.IconFont=FontAwesome.Sharp.IconFont.Auto;
            iconButton3.IconSize=40;
            iconButton3.Location=new Point(704, 0);
            iconButton3.Name="iconButton3";
            iconButton3.Size=new Size(95, 33);
            iconButton3.TabIndex=6;
            iconButton3.UseVisualStyleBackColor=true;
            // 
            // Form1
            // 
            AutoScaleDimensions=new SizeF(8F, 20F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(800, 491);
            Controls.Add(pictureBox1);
            Controls.Add(panel2);
            Name="Form1";
            Text="Form1";
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton iconButton2;
    }
}