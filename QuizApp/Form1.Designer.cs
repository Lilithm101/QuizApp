namespace QuizApp
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
            rbAns2 = new RadioButton();
            rbAns1 = new RadioButton();
            rbAns3 = new RadioButton();
            lbl1 = new Label();
            rbAns4 = new RadioButton();
            groupBox1 = new GroupBox();
            NxtBtn = new Button();
            questlbl = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // rbAns2
            // 
            rbAns2.AutoSize = true;
            rbAns2.Location = new Point(23, 58);
            rbAns2.Name = "rbAns2";
            rbAns2.Size = new Size(94, 19);
            rbAns2.TabIndex = 0;
            rbAns2.TabStop = true;
            rbAns2.Text = "radioButton1";
            rbAns2.UseVisualStyleBackColor = true;
            // 
            // rbAns1
            // 
            rbAns1.AutoSize = true;
            rbAns1.Location = new Point(23, 33);
            rbAns1.Name = "rbAns1";
            rbAns1.Size = new Size(94, 19);
            rbAns1.TabIndex = 1;
            rbAns1.TabStop = true;
            rbAns1.Text = "radioButton2";
            rbAns1.UseVisualStyleBackColor = true;
            // 
            // rbAns3
            // 
            rbAns3.AutoSize = true;
            rbAns3.Location = new Point(23, 83);
            rbAns3.Name = "rbAns3";
            rbAns3.Size = new Size(94, 19);
            rbAns3.TabIndex = 2;
            rbAns3.TabStop = true;
            rbAns3.Text = "radioButton3";
            rbAns3.UseVisualStyleBackColor = true;
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Location = new Point(59, 56);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(38, 15);
            lbl1.TabIndex = 3;
            lbl1.Text = "label1";
            lbl1.Click += label1_Click;
            // 
            // rbAns4
            // 
            rbAns4.AutoSize = true;
            rbAns4.Location = new Point(23, 108);
            rbAns4.Name = "rbAns4";
            rbAns4.Size = new Size(94, 19);
            rbAns4.TabIndex = 4;
            rbAns4.TabStop = true;
            rbAns4.Text = "radioButton4";
            rbAns4.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbAns4);
            groupBox1.Controls.Add(rbAns2);
            groupBox1.Controls.Add(rbAns1);
            groupBox1.Controls.Add(rbAns3);
            groupBox1.Location = new Point(59, 102);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 156);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Svar";
            // 
            // NxtBtn
            // 
            NxtBtn.Location = new Point(473, 235);
            NxtBtn.Name = "NxtBtn";
            NxtBtn.Size = new Size(75, 23);
            NxtBtn.TabIndex = 6;
            NxtBtn.Text = "button1";
            NxtBtn.UseVisualStyleBackColor = true;
            // 
            // questlbl
            // 
            questlbl.AutoSize = true;
            questlbl.Location = new Point(473, 22);
            questlbl.Name = "questlbl";
            questlbl.Size = new Size(38, 15);
            questlbl.TabIndex = 7;
            questlbl.Text = "label1";
            questlbl.Click += label1_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 270);
            Controls.Add(questlbl);
            Controls.Add(NxtBtn);
            Controls.Add(groupBox1);
            Controls.Add(lbl1);
            Margin = new Padding(2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton rbAns2;
        private RadioButton rbAns1;
        private RadioButton rbAns3;
        private Label lbl1;
        private RadioButton rbAns4;
        private GroupBox groupBox1;
        private Button NxtBtn;
        private Label questlbl;
    }
}
