namespace Note_Taking_App
{
    partial class note
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(note));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.date = new System.Windows.Forms.Label();
            this.note_output = new System.Windows.Forms.Label();
            this.time = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.date);
            this.panel1.Controls.Add(this.note_output);
            this.panel1.Controls.Add(this.time);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(888, 99);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(815, 47);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(36, 28);
            this.button1.TabIndex = 4;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.date.Location = new System.Drawing.Point(12, 10);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(80, 17);
            this.date.TabIndex = 3;
            this.date.Text = "12/34/2012";
            // 
            // note_output
            // 
            this.note_output.AutoSize = true;
            this.note_output.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.note_output.Location = new System.Drawing.Point(12, 54);
            this.note_output.Name = "note_output";
            this.note_output.Size = new System.Drawing.Size(0, 15);
            this.note_output.TabIndex = 2;
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.time.Location = new System.Drawing.Point(89, 10);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(65, 17);
            this.time.TabIndex = 1;
            this.time.Text = "11:98:21";
            // 
            // note
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Location = new System.Drawing.Point(12, 370);
            this.Name = "note";
            this.Size = new System.Drawing.Size(888, 99);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label time;
        private System.Windows.Forms.Timer timer1;
        public Label note_output;
        private Label date;
        private Panel panel1;
        private Button button1;
    }
}
