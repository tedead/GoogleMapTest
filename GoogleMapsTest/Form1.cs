using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoogleMapsTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string googleSearch = txtSearch.Text;
            StringBuilder google = new StringBuilder();
            google.Append("https://www.google.com/maps/search/?api=1&query=");

            if(txtSearch.Text != string.Empty)
            {
                googleSearch = txtSearch.Text.Replace(" ", "+").Replace(",", "%2C");
                google.Append(googleSearch);
                string testResult = google.ToString();
                webGoogleMaps.Navigate(google.ToString());
            }
        }
    }
}
