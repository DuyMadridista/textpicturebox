namespace textpicturebox
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            textBox1=new TextBox();
            textBox2=new TextBox();
            textBox3=new TextBox();
            label1=new Label();
            label2=new Label();
            label3=new Label();
            label4=new Label();
            iconButton2=new FontAwesome.Sharp.IconButton();
            panel1=new Panel();
            iconButton1=new FontAwesome.Sharp.IconButton();
            iconDropDownButton1=new FontAwesome.Sharp.IconDropDownButton();
            pictureBox1=new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            resources.ApplyResources(textBox1, "textBox1");
            textBox1.Name="textBox1";
            // 
            // textBox2
            // 
            resources.ApplyResources(textBox2, "textBox2");
            textBox2.Name="textBox2";
            textBox2.TextChanged+=textBox2_TextChanged;
            // 
            // textBox3
            // 
            resources.ApplyResources(textBox3, "textBox3");
            textBox3.Name="textBox3";
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.BackColor=Color.Transparent;
            label1.ForeColor=SystemColors.ActiveCaptionText;
            label1.Name="label1";
            label1.Click+=label1_Click;
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.ForeColor=SystemColors.ActiveCaptionText;
            label2.Name="label2";
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.ForeColor=SystemColors.ActiveCaptionText;
            label3.Name="label3";
            // 
            // label4
            // 
            label4.AccessibleRole=AccessibleRole.TitleBar;
            resources.ApplyResources(label4, "label4");
            label4.AutoEllipsis=true;
            label4.BackColor=Color.Cyan;
            label4.ForeColor=SystemColors.ActiveCaptionText;
            label4.Name="label4";
            label4.Click+=label4_Click;
            // 
            // iconButton2
            // 
            iconButton2.BackColor=SystemColors.ActiveCaption;
            iconButton2.IconChar=FontAwesome.Sharp.IconChar.CodeCompare;
            iconButton2.IconColor=Color.RoyalBlue;
            iconButton2.IconFont=FontAwesome.Sharp.IconFont.Solid;
            iconButton2.IconSize=40;
            resources.ApplyResources(iconButton2, "iconButton2");
            iconButton2.Name="iconButton2";
            iconButton2.UseVisualStyleBackColor=false;
            // 
            // panel1
            // 
            panel1.BackColor=Color.FromArgb(26, 25, 62);
            panel1.Controls.Add(pictureBox1);
            resources.ApplyResources(panel1, "panel1");
            panel1.Name="panel1";
            // 
            // iconButton1
            // 
            iconButton1.BackColor=Color.SpringGreen;
            iconButton1.Flip=FontAwesome.Sharp.FlipOrientation.Horizontal;
            resources.ApplyResources(iconButton1, "iconButton1");
            iconButton1.IconChar=FontAwesome.Sharp.IconChar.Computer;
            iconButton1.IconColor=Color.Black;
            iconButton1.IconFont=FontAwesome.Sharp.IconFont.Auto;
            iconButton1.Name="iconButton1";
            iconButton1.UseVisualStyleBackColor=false;
            // 
            // iconDropDownButton1
            // 
            iconDropDownButton1.IconChar=FontAwesome.Sharp.IconChar.None;
            iconDropDownButton1.IconColor=Color.Black;
            iconDropDownButton1.IconFont=FontAwesome.Sharp.IconFont.Auto;
            iconDropDownButton1.Name="iconDropDownButton1";
            resources.ApplyResources(iconDropDownButton1, "iconDropDownButton1");
            // 
            // pictureBox1
            // 
            pictureBox1.Image=Properties.Resources.real_madrid_8;
            resources.ApplyResources(pictureBox1, "pictureBox1");
            pictureBox1.Name="pictureBox1";
            pictureBox1.TabStop=false;
            // 
            // Form2
            // 
            AcceptButton=iconButton1;
            AutoScaleMode=AutoScaleMode.Inherit;
            resources.ApplyResources(this, "$this");
            BackColor=Color.RosyBrown;
            Controls.Add(label4);
            Controls.Add(iconButton1);
            Controls.Add(panel1);
            Controls.Add(iconButton2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            FormBorderStyle=FormBorderStyle.Fixed3D;
            MaximizeBox=false;
            Name="Form2";
            Load+=Form2_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private FontAwesome.Sharp.IconButton iconButton2;
        private Panel panel1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private PictureBox pictureBox1;
        private FontAwesome.Sharp.IconDropDownButton iconDropDownButton1;
    }
}