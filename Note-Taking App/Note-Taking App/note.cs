using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Note_Taking_App
{
    public partial class note : UserControl
    {
        public note()
        {
            InitializeComponent();
            date_time();

            note_output.Visible = true;
            
        }

        public void date_time()
        {
            date.Text = DateTime.Now.ToString("MM/dd/yyyy");
            time.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.Dispose();

        }
    }
}
