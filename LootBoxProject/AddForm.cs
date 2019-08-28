using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LootBoxProject
{
    public partial class FrmAddUpdate : Form
    {
        private LootboxClass existingLootbox;
        public FrmAddUpdate(LootboxClass lb = null)
        {
            InitializeComponent();
            existingLootbox = lb;
            if(lb != null)
            {
                btnAdd.Text = "Update lootbox";

                Text = "Updating Lootbox: " + lb.LootboxID;

                txtTheme.Text = existingLootbox.Theme;
                txtName.Text = existingLootbox.Name;
                txtContents.Text = existingLootbox.Contents;
                txtDescription.Text = existingLootbox.Description;
                txtPrice.Text = existingLootbox.Price.ToString();
            }

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
                if(existingLootbox != null)
                {
                    lb.LootboxID = existingLootbox.LootboxID;
                    LootboxDB.Update(lb);
                    MessageBox.Show("Lootbox Updated!");
                }
                else
                {
                    LootboxDB.Add(lb);
                    MessageBox.Show("Lootbox added!");
                }
                Close();
            }
            catch(SqlException)
            {
                MessageBox.Show("Error, Try Again.");
            }
        }

        private void FrmAddUpdate_Load(object sender, EventArgs e)
        {

        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
