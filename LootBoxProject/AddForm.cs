using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LootBoxProject
{
    public partial class FrmAddLootbox : Form
    {
        public FrmAddLootbox()
        {
            InitializeComponent();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void BtnAdd_Click(object sender, EventArgs e)
        {
            // Add Lootbox into database
            LootboxClass lb = new LootboxClass()
            {
                Theme = txtTheme.Text,
                Name = txtName.Text,
                Contents = txtContents.Text,
                Description = txtDescription.Text,
                Price = Convert.ToDouble(txtPrice.Text)
            };

            try
            {
                LootboxDB.Add(lb);
                MessageBox.Show("Lootbox added");
                Close();
            }
            catch
            {
                MessageBox.Show("Error, Try Again.");
            }
        }
    }
}
