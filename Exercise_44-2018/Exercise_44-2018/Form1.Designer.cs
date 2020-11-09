namespace Exercise_44_2018
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.labelName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtIndex = new System.Windows.Forms.TextBox();
            this.labelIndex = new System.Windows.Forms.Label();
            this.labelPoints = new System.Windows.Forms.Label();
            this.txtPoint = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(428, 55);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(239, 229);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(139, 55);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(39, 15);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(139, 73);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 23);
            this.txtName.TabIndex = 2;
            // 
            // txtIndex
            // 
            this.txtIndex.Location = new System.Drawing.Point(139, 174);
            this.txtIndex.Name = "txtIndex";
            this.txtIndex.Size = new System.Drawing.Size(100, 23);
            this.txtIndex.TabIndex = 2;
            // 
            // labelIndex
            // 
            this.labelIndex.AutoSize = true;
            this.labelIndex.Location = new System.Drawing.Point(140, 133);
            this.labelIndex.Name = "labelIndex";
            this.labelIndex.Size = new System.Drawing.Size(35, 15);
            this.labelIndex.TabIndex = 3;
            this.labelIndex.Text = "Index";
            this.labelIndex.Click += new System.EventHandler(this.label3_Click);
            // 
            // labelPoints
            // 
            this.labelPoints.AutoSize = true;
            this.labelPoints.Location = new System.Drawing.Point(139, 242);
            this.labelPoints.Name = "labelPoints";
            this.labelPoints.Size = new System.Drawing.Size(40, 15);
            this.labelPoints.TabIndex = 4;
            this.labelPoints.Text = "Points";
            // 
            // txtPoint
            // 
            this.txtPoint.Location = new System.Drawing.Point(139, 284);
            this.txtPoint.Name = "txtPoint";
            this.txtPoint.Size = new System.Drawing.Size(100, 23);
            this.txtPoint.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(188, 346);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "ADD";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtPoint);
            this.Controls.Add(this.labelPoints);
            this.Controls.Add(this.labelIndex);
            this.Controls.Add(this.txtIndex);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtIndex;
        private System.Windows.Forms.Label labelIndex;
        private System.Windows.Forms.Label labelPoints;
        private System.Windows.Forms.TextBox txtPoint;
        private System.Windows.Forms.Button button1;
    }
}

