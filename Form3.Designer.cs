namespace textpicturebox
{
    partial class Form3
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
            textBox1=new TextBox();
            textBox2=new TextBox();
            textBox3=new TextBox();
            button2=new Button();
            dataGridView1=new DataGridView();
            Column1=new DataGridViewTextBoxColumn();
            Column2=new DataGridViewComboBoxColumn();
            Column3=new DataGridViewButtonColumn();
            label1=new Label();
            label2=new Label();
            label3=new Label();
            iconButton1=new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location=new Point(94, 49);
            textBox1.Name="textBox1";
            textBox1.Size=new Size(230, 27);
            textBox1.TabIndex=0;
            // 
            // textBox2
            // 
            textBox2.Location=new Point(503, 53);
            textBox2.Name="textBox2";
            textBox2.Size=new Size(134, 27);
            textBox2.TabIndex=1;
            // 
            // textBox3
            // 
            textBox3.Location=new Point(94, 141);
            textBox3.Name="textBox3";
            textBox3.Size=new Size(230, 27);
            textBox3.TabIndex=2;
            // 
            // button2
            // 
            button2.Location=new Point(503, 133);
            button2.Name="button2";
            button2.Size=new Size(134, 35);
            button2.TabIndex=4;
            button2.Text="Tạo kết nối";
            button2.UseVisualStyleBackColor=true;
            button2.Click+=button2_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode=DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode=DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3 });
            dataGridView1.Location=new Point(12, 211);
            dataGridView1.Name="dataGridView1";
            dataGridView1.RowHeadersVisible=false;
            dataGridView1.RowHeadersWidth=51;
            dataGridView1.RowTemplate.Height=29;
            dataGridView1.Size=new Size(749, 193);
            dataGridView1.TabIndex=5;
            // 
            // Column1
            // 
            Column1.FillWeight=56.7091637F;
            Column1.HeaderText="Log";
            Column1.MinimumWidth=6;
            Column1.Name="Column1";
            // 
            // Column2
            // 
            Column2.AutoSizeMode=DataGridViewAutoSizeColumnMode.None;
            Column2.FillWeight=240.641708F;
            Column2.HeaderText="State";
            Column2.MinimumWidth=6;
            Column2.Name="Column2";
            Column2.Resizable=DataGridViewTriState.True;
            Column2.SortMode=DataGridViewColumnSortMode.Automatic;
            Column2.Width=125;
            // 
            // Column3
            // 
            Column3.AutoSizeMode=DataGridViewAutoSizeColumnMode.None;
            Column3.DataPropertyName="dav";
            Column3.FillWeight=2.64912534F;
            Column3.HeaderText="Terminate";
            Column3.MinimumWidth=6;
            Column3.Name="Column3";
            Column3.Resizable=DataGridViewTriState.True;
            Column3.SortMode=DataGridViewColumnSortMode.Automatic;
            Column3.Text="Terminate";
            Column3.UseColumnTextForButtonValue=true;
            Column3.Width=150;
            // 
            // label1
            // 
            label1.AutoSize=true;
            label1.Location=new Point(21, 56);
            label1.Name="label1";
            label1.Size=new Size(21, 20);
            label1.TabIndex=9;
            label1.Text="IP";
            // 
            // label2
            // 
            label2.AutoSize=true;
            label2.Location=new Point(16, 148);
            label2.Name="label2";
            label2.Size=new Size(72, 20);
            label2.TabIndex=10;
            label2.Text="Mật Khẩu";
            // 
            // label3
            // 
            label3.AutoSize=true;
            label3.Location=new Point(418, 56);
            label3.Name="label3";
            label3.Size=new Size(35, 20);
            label3.TabIndex=11;
            label3.Text="Port";
            // 
            // iconButton1
            // 
            iconButton1.BackColor=Color.GreenYellow;
            iconButton1.IconChar=FontAwesome.Sharp.IconChar.CodeCompare;
            iconButton1.IconColor=Color.Black;
            iconButton1.IconFont=FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize=30;
            iconButton1.Location=new Point(294, 139);
            iconButton1.Name="iconButton1";
            iconButton1.Size=new Size(30, 30);
            iconButton1.TabIndex=12;
            iconButton1.UseCompatibleTextRendering=true;
            iconButton1.UseVisualStyleBackColor=false;
            // 
            // Form3
            // 
            AutoScaleDimensions=new SizeF(8F, 20F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(800, 450);
            Controls.Add(iconButton1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(button2);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name="Form3";
            Text="Form3";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button button2;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewComboBoxColumn Column2;
        private DataGridViewButtonColumn Column3;
        private Label label1;
        private Label label2;
        private Label label3;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}