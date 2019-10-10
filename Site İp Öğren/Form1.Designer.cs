namespace Site_İp_Öğren
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
            this.label1 = new System.Windows.Forms.Label();
            this.sitetext = new System.Windows.Forms.TextBox();
            this.iptext = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ipögren = new System.Windows.Forms.Button();
            this.ipkaydet = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(8, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Site";
            // 
            // sitetext
            // 
            this.sitetext.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sitetext.Location = new System.Drawing.Point(11, 31);
            this.sitetext.Name = "sitetext";
            this.sitetext.Size = new System.Drawing.Size(233, 22);
            this.sitetext.TabIndex = 0;
            this.sitetext.Text = "www.google.com";
            this.sitetext.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // iptext
            // 
            this.iptext.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.iptext.Location = new System.Drawing.Point(11, 80);
            this.iptext.Name = "iptext";
            this.iptext.Size = new System.Drawing.Size(233, 22);
            this.iptext.TabIndex = 1;
            this.iptext.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.iptext_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(8, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Site İp";
            // 
            // ipögren
            // 
            this.ipögren.Location = new System.Drawing.Point(11, 113);
            this.ipögren.Name = "ipögren";
            this.ipögren.Size = new System.Drawing.Size(113, 28);
            this.ipögren.TabIndex = 2;
            this.ipögren.Text = "İp Öğren";
            this.ipögren.UseVisualStyleBackColor = true;
            this.ipögren.Click += new System.EventHandler(this.ipögren_Click);
            // 
            // ipkaydet
            // 
            this.ipkaydet.Location = new System.Drawing.Point(131, 113);
            this.ipkaydet.Name = "ipkaydet";
            this.ipkaydet.Size = new System.Drawing.Size(113, 28);
            this.ipkaydet.TabIndex = 3;
            this.ipkaydet.Text = "Kaydet";
            this.ipkaydet.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView1.Location = new System.Drawing.Point(250, 31);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(348, 110);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Site";
            this.columnHeader1.Width = 172;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "İp";
            this.columnHeader2.Width = 155;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Papyrus", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(411, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Powered By DeadSound";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 5;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(608, 151);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.ipkaydet);
            this.Controls.Add(this.ipögren);
            this.Controls.Add(this.iptext);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sitetext);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox sitetext;
        private System.Windows.Forms.TextBox iptext;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ipögren;
        private System.Windows.Forms.Button ipkaydet;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer1;
    }
}

