using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;

namespace ToDataTableFunction
{
    public partial class Main : Form
    {
        private List<object> Users = new List<object>()
        {
            new User{ 
                Id = 1,
                Name = "Ali",
                Family = "Hosseini",
                Number = "09030422838"
            },
            new User{
                Id = 2,
                Name = "Mohammad Reza",
                Family = "NasrollahZade",
                Number = "09332621196"
            },
            new User{
                Id = 3,
                Name = "Danial",
                Family = "Asadi",
                Number = "09103618688"
            },
            new User{
                Id = 4,
                Name = "Zahra",
                Family = "Mirzaei",
                Number = "09123456789"
            },
        };

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Users.ToDataTable();
        }
    }
}
