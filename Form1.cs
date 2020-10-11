using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeZoneApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            string city; //to hold the city name
            
            // if an item is selected (selectIndex) the index value is 0 or greater,
            // hence, if it is selected it is different (!=) of -1
            if (cityListBox.SelectedIndex != -1)
            {
                // get the selected item
                city = cityListBox.SelectedItem.ToString();
                
                //determine the city zone.
                switch (city)
                {
                    case "Honolulu":
                        timeZoneLabel.Text = "Hawaii-Aleutian";
                        break;
                    case "San Francisco":
                        timeZoneLabel.Text = "Pacific";
                        break;
                    case "Minneapolis":
                        timeZoneLabel.Text = "Central";
                        break;
                    case "New York":
                        timeZoneLabel.Text = "Eastern";
                        break;
                    case "Denver":
                        timeZoneLabel.Text = "Mountain";
                        break;
                }
            }
            else
                // no city was selected
                MessageBox.Show("Select a city.");
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //close the app
            this.Close();
        }
    }
}
