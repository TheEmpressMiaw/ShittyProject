﻿using System;
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
    public partial class Reservation : Form
    {
        public Reservation()
        {
            InitializeComponent();
        }

        private void btnNewRes_Click(object sender, EventArgs e)
        {
            ReservationCreate reservationCreate = new ReservationCreate();
            this.Hide();
            reservationCreate.ShowDialog();
        }
    }
}
