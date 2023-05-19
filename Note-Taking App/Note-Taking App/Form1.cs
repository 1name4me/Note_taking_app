using System.Drawing.Drawing2D;
using System.IO;

namespace Note_Taking_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void display_notes()
        {
            if (usr_notes.Text != "")
            {
                intro_panel.Dispose();
                intro_panel.Controls.Clear();

                note notes = new note();

                FLP.Controls.Add(notes);

                notes.note_output.Text = usr_notes.Text;
                
                
            }
            
        }

        private void create_btn_Click(object sender, EventArgs e)
        {
            display_notes();
            usr_notes.Text = "";
        }

     
    }
}