namespace _1projetoWF
{
    partial class TelaAluno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaAluno));
            dataGridView1=new DataGridView();
            button1=new Button();
            label1=new Label();
            pictureBox1=new PictureBox();
            label2=new Label();
            label3=new Label();
            label4=new Label();
            checkedListBox1=new CheckedListBox();
            pictureBox2=new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode=DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location=new Point(3, 33);
            dataGridView1.Name="dataGridView1";
            dataGridView1.RowHeadersWidth=51;
            dataGridView1.RowTemplate.Height=29;
            dataGridView1.Size=new Size(493, 351);
            dataGridView1.TabIndex=0;
            dataGridView1.CellContentClick+=dataGridView1_CellContentClick;
            // 
            // button1
            // 
            button1.Cursor=Cursors.Hand;
            button1.Font=new Font("Arial Black", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor=Color.FromArgb(128, 128, 255);
            button1.Location=new Point(197, 401);
            button1.Name="button1";
            button1.Size=new Size(73, 37);
            button1.TabIndex=1;
            button1.Text="SAIR";
            button1.UseVisualStyleBackColor=true;
            button1.Click+=button1_Click;
            // 
            // label1
            // 
            label1.AutoSize=true;
            label1.Location=new Point(260, -76);
            label1.Name="label1";
            label1.Size=new Size(0, 20);
            label1.TabIndex=19;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor=Color.FromArgb(255, 192, 255);
            pictureBox1.Image=Properties.Resources.tinywow_change_bg_photo_28005809;
            pictureBox1.Location=new Point(491, 12);
            pictureBox1.Name="pictureBox1";
            pictureBox1.Size=new Size(337, 275);
            pictureBox1.SizeMode=PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex=20;
            pictureBox1.TabStop=false;
            pictureBox1.Click+=pictureBox1_Click;
            // 
            // label2
            // 
            label2.AutoSize=true;
            label2.Font=new Font("Arial", 10.8F, FontStyle.Bold|FontStyle.Italic, GraphicsUnit.Point);
            label2.Location=new Point(560, 31);
            label2.Name="label2";
            label2.Size=new Size(195, 21);
            label2.TabIndex=21;
            label2.Text="Andamento do curso ";
            // 
            // label3
            // 
            label3.AutoSize=true;
            label3.Font=new Font("Arial", 9F, FontStyle.Bold|FontStyle.Italic, GraphicsUnit.Point);
            label3.Location=new Point(605, 55);
            label3.Name="label3";
            label3.Size=new Size(101, 17);
            label3.TabIndex=22;
            label3.Text=" % Concluído";
            // 
            // label4
            // 
            label4.AutoSize=true;
            label4.Font=new Font("Arial", 10.8F, FontStyle.Bold|FontStyle.Italic, GraphicsUnit.Point);
            label4.Location=new Point(140, 9);
            label4.Name="label4";
            label4.Size=new Size(173, 21);
            label4.TabIndex=23;
            label4.Text="Dados dos ALunos";
            // 
            // checkedListBox1
            // 
            checkedListBox1.BackColor=Color.FromArgb(255, 192, 255);
            checkedListBox1.BorderStyle=BorderStyle.None;
            checkedListBox1.Cursor=Cursors.Hand;
            checkedListBox1.Font=new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            checkedListBox1.ForeColor=Color.FromArgb(128, 128, 255);
            checkedListBox1.FormattingEnabled=true;
            checkedListBox1.Items.AddRange(new object[] { "Entregar cópia dos documentos", "Fazer a atividade de BD", "Entregar os slides", "Reserva livro na Biblioteca" });
            checkedListBox1.Location=new Point(513, 274);
            checkedListBox1.Name="checkedListBox1";
            checkedListBox1.Size=new Size(299, 110);
            checkedListBox1.TabIndex=24;
            // 
            // pictureBox2
            // 
            pictureBox2.Image=Properties.Resources.Wonder_Learners___Biology_Class;
            pictureBox2.Location=new Point(160, 190);
            pictureBox2.Name="pictureBox2";
            pictureBox2.Size=new Size(408, 343);
            pictureBox2.SizeMode=PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex=25;
            pictureBox2.TabStop=false;
            pictureBox2.Click+=pictureBox2_Click;
            // 
            // TelaAluno
            // 
            AutoScaleDimensions=new SizeF(8F, 20F);
            AutoScaleMode=AutoScaleMode.Font;
            BackColor=Color.FromArgb(255, 192, 255);
            ClientSize=new Size(800, 450);
            Controls.Add(checkedListBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            FormBorderStyle=FormBorderStyle.Fixed3D;
            Icon=(Icon)resources.GetObject("$this.Icon");
            Name="TelaAluno";
            StartPosition=FormStartPosition.CenterScreen;
            Text="Portal do Aluno";
            TopMost=true;
            Load+=TelaAluno_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button1;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label3;
        private Label label4;
        private CheckedListBox checkedListBox1;
        private PictureBox pictureBox2;
    }
}