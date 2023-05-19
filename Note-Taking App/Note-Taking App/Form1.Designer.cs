namespace Note_Taking_App
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
            this.FLP = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.usr_notes = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.create_btn = new System.Windows.Forms.Button();
            this.intro_panel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.intro_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // FLP
            // 
            this.FLP.AutoSize = true;
            this.FLP.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.FLP.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.FLP.Location = new System.Drawing.Point(12, 370);
            this.FLP.Name = "FLP";
            this.FLP.Size = new System.Drawing.Size(0, 0);
            this.FLP.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.intro_panel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(912, 557);
            this.panel1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 31);
            this.label1.TabIndex = 5;
            this.label1.Text = "Note-Taking App";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Create your first note above!";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "No notes created yet!";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.usr_notes);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.create_btn);
            this.panel2.Location = new System.Drawing.Point(12, 88);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(888, 289);
            this.panel2.TabIndex = 7;
            // 
            // usr_notes
            // 
            this.usr_notes.BackColor = System.Drawing.Color.WhiteSmoke;
            this.usr_notes.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.usr_notes.ForeColor = System.Drawing.SystemColors.WindowText;
            this.usr_notes.Location = new System.Drawing.Point(12, 47);
            this.usr_notes.Multiline = true;
            this.usr_notes.Name = "usr_notes";
            this.usr_notes.Size = new System.Drawing.Size(857, 191);
            this.usr_notes.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(12, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Enter your note here";
            // 
            // create_btn
            // 
            this.create_btn.BackColor = System.Drawing.Color.RoyalBlue;
            this.create_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.create_btn.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.create_btn.ForeColor = System.Drawing.Color.White;
            this.create_btn.Location = new System.Drawing.Point(12, 244);
            this.create_btn.Name = "create_btn";
            this.create_btn.Size = new System.Drawing.Size(857, 33);
            this.create_btn.TabIndex = 3;
            this.create_btn.Text = "Create Note";
            this.create_btn.UseVisualStyleBackColor = false;
            // 
            // intro_panel
            // 
            this.intro_panel.BackColor = System.Drawing.Color.White;
            this.intro_panel.Controls.Add(this.label2);
            this.intro_panel.Controls.Add(this.label3);
            this.intro_panel.Location = new System.Drawing.Point(12, 383);
            this.intro_panel.Margin = new System.Windows.Forms.Padding(3, 3, 3, 15);
            this.intro_panel.Name = "intro_panel";
            this.intro_panel.Size = new System.Drawing.Size(888, 97);
            this.intro_panel.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(912, 557);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.FLP);
            this.Name = "Form1";
            this.Text = "NoteTaking App";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.intro_panel.ResumeLayout(false);
            this.intro_panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private FlowLayoutPanel FLP;
        private Panel panel1;
        private Label label1;
        public Panel panel2;
        public TextBox usr_notes;
        private Label label4;
        private Button create_btn;
        private Panel intro_panel;
        private Label label2;
        private Label label3;
    }
}