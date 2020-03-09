namespace KruskalVisualize
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
            this.kruskalTextBox = new System.Windows.Forms.TextBox();
            this.SaveButton1 = new System.Windows.Forms.Button();
            this.LoadButton1 = new System.Windows.Forms.Button();
            this.SaveButton2 = new System.Windows.Forms.Button();
            this.LoadButton2 = new System.Windows.Forms.Button();
            this.SaveButton3 = new System.Windows.Forms.Button();
            this.LoadButton3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Visualize = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.kruskalTextLabel = new System.Windows.Forms.Label();
            this.hintLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // kruskalTextBox
            // 
            this.kruskalTextBox.Location = new System.Drawing.Point(12, 133);
            this.kruskalTextBox.Multiline = true;
            this.kruskalTextBox.Name = "kruskalTextBox";
            this.kruskalTextBox.Size = new System.Drawing.Size(240, 483);
            this.kruskalTextBox.TabIndex = 0;
            this.kruskalTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // SaveButton1
            // 
            this.SaveButton1.Location = new System.Drawing.Point(258, 133);
            this.SaveButton1.Name = "SaveButton1";
            this.SaveButton1.Size = new System.Drawing.Size(48, 23);
            this.SaveButton1.TabIndex = 1;
            this.SaveButton1.Text = "Save";
            this.SaveButton1.UseVisualStyleBackColor = true;
            this.SaveButton1.Click += new System.EventHandler(this.SaveButton1_Click);
            // 
            // LoadButton1
            // 
            this.LoadButton1.Location = new System.Drawing.Point(353, 133);
            this.LoadButton1.Name = "LoadButton1";
            this.LoadButton1.Size = new System.Drawing.Size(48, 23);
            this.LoadButton1.TabIndex = 2;
            this.LoadButton1.Text = "Load";
            this.LoadButton1.UseVisualStyleBackColor = true;
            this.LoadButton1.Click += new System.EventHandler(this.LoadButton1_Click);
            // 
            // SaveButton2
            // 
            this.SaveButton2.Location = new System.Drawing.Point(258, 189);
            this.SaveButton2.Name = "SaveButton2";
            this.SaveButton2.Size = new System.Drawing.Size(48, 23);
            this.SaveButton2.TabIndex = 3;
            this.SaveButton2.Text = "Save";
            this.SaveButton2.UseVisualStyleBackColor = true;
            this.SaveButton2.Click += new System.EventHandler(this.SaveButton2_Click);
            // 
            // LoadButton2
            // 
            this.LoadButton2.Location = new System.Drawing.Point(353, 189);
            this.LoadButton2.Name = "LoadButton2";
            this.LoadButton2.Size = new System.Drawing.Size(48, 23);
            this.LoadButton2.TabIndex = 4;
            this.LoadButton2.Text = "Load";
            this.LoadButton2.UseVisualStyleBackColor = true;
            this.LoadButton2.Click += new System.EventHandler(this.LoadButton2_Click);
            // 
            // SaveButton3
            // 
            this.SaveButton3.Location = new System.Drawing.Point(258, 247);
            this.SaveButton3.Name = "SaveButton3";
            this.SaveButton3.Size = new System.Drawing.Size(48, 23);
            this.SaveButton3.TabIndex = 5;
            this.SaveButton3.Text = "Save";
            this.SaveButton3.UseVisualStyleBackColor = true;
            this.SaveButton3.Click += new System.EventHandler(this.SaveButton3_Click);
            // 
            // LoadButton3
            // 
            this.LoadButton3.Location = new System.Drawing.Point(353, 247);
            this.LoadButton3.Name = "LoadButton3";
            this.LoadButton3.Size = new System.Drawing.Size(48, 23);
            this.LoadButton3.TabIndex = 6;
            this.LoadButton3.Text = "Load";
            this.LoadButton3.UseVisualStyleBackColor = true;
            this.LoadButton3.Click += new System.EventHandler(this.LoadButton3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(312, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Save 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(312, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Save 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(312, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Save 3";
            // 
            // Visualize
            // 
            this.Visualize.Location = new System.Drawing.Point(353, 46);
            this.Visualize.Name = "Visualize";
            this.Visualize.Size = new System.Drawing.Size(75, 23);
            this.Visualize.TabIndex = 10;
            this.Visualize.Text = "Visualize";
            this.Visualize.UseVisualStyleBackColor = true;
            this.Visualize.Click += new System.EventHandler(this.Visualize_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(434, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(469, 410);
            this.panel1.TabIndex = 11;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // kruskalTextLabel
            // 
            this.kruskalTextLabel.AutoSize = true;
            this.kruskalTextLabel.Location = new System.Drawing.Point(431, 425);
            this.kruskalTextLabel.Name = "kruskalTextLabel";
            this.kruskalTextLabel.Size = new System.Drawing.Size(0, 13);
            this.kruskalTextLabel.TabIndex = 12;
            // 
            // hintLabel
            // 
            this.hintLabel.AutoSize = true;
            this.hintLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.hintLabel.Location = new System.Drawing.Point(13, 13);
            this.hintLabel.Name = "hintLabel";
            this.hintLabel.Size = new System.Drawing.Size(308, 120);
            this.hintLabel.TabIndex = 13;
            this.hintLabel.Text = "Format:\r\nnumber of vertices\r\nedges: node from, to, weight separated by semicolon " +
    "(;)\r\nExample;\r\n3\r\n0;1;4\r\n1;2;3\r\n2;0;5";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(915, 628);
            this.Controls.Add(this.hintLabel);
            this.Controls.Add(this.kruskalTextLabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Visualize);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LoadButton3);
            this.Controls.Add(this.SaveButton3);
            this.Controls.Add(this.LoadButton2);
            this.Controls.Add(this.SaveButton2);
            this.Controls.Add(this.LoadButton1);
            this.Controls.Add(this.SaveButton1);
            this.Controls.Add(this.kruskalTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox kruskalTextBox;
        private System.Windows.Forms.Button SaveButton1;
        private System.Windows.Forms.Button LoadButton1;
        private System.Windows.Forms.Button SaveButton2;
        private System.Windows.Forms.Button LoadButton2;
        private System.Windows.Forms.Button SaveButton3;
        private System.Windows.Forms.Button LoadButton3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Visualize;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label kruskalTextLabel;
        private System.Windows.Forms.Label hintLabel;
    }
}

