using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Room : Form
    {
        public Room()
        {
            InitializeComponent();
        }

        private void btnNewRoom_Click(object sender, EventArgs e)
        {
            RoomCreate roomCreate = new RoomCreate();
            this.Hide();
            roomCreate.ShowDialog();
        }
    }
}
