﻿using ChapeauxLogic;
using ChapeauxModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChapeauxUI
{
    public partial class KitchenDisplay : Form
    {
        private Item item;
        private User user;

        public KitchenDisplay(User user)
        {
            this.user = user;
            InitializeComponent();
            DisplayForUser();
        }
  
        private void DisplayForUser()
        {
            if (user.Role == Role.Chef)
            {
                ShowPanel("Kitchen");
                ShowRunningKitchenOrder();
            }

            else if (user.Role == Role.Bartender)
            {
                ShowPanel("Bar");
                ShowRunningBarOrder();
            }

        }

        private void ShowPanel(string panelName)
        {
            HideAllPanels();

            if (panelName == "Kitchen")
            {
                pnlKitchenDisplay.Show();
            }

            else if (panelName == "Bar")
            {
                pnlBarmanDisplay.Show();
            }
        }

        private void HideAllPanels()
        {
            pnlBarmanDisplay.Hide();
            pnlKitchenDisplay.Hide();
        }

        private void ShowRunningBarOrder()
        {
            pnlKitchenDisplay.Hide();

            pnlBarmanDisplay.Show();
            try
            {
                listViewBarmanDisplay.Clear();


                //Change to OrderItems
                Item_Service itemservice = new Item_Service();
                List<Item> itemlist = itemservice.GetItems();
                foreach (Item item in itemlist)
                {
                    ListViewItem list = new ListViewItem(item.ItemID.ToString());
                    list.SubItems.Add(item.Name.ToString());
                    list.SubItems.Add(item.Price.ToString());
                    list.SubItems.Add(item.Stock.ToString());
                    list.SubItems.Add(item.Category.ToString());
                    list.SubItems.Add(item.VATRate.ToString());

                    listViewBarmanDisplay.Items.Add(list);
                }
            }
            catch (Exception exc)
            {

                MessageBox.Show(exc.Message);
            }
        }
        private void ShowRunningKitchenOrder()
        {
            pnlBarmanDisplay.Hide();

            pnlKitchenDisplay.Show();
            try
            {
                //Change to OrderItems
                listViewTableKitchen.Clear();
                Item_Service itemservice = new Item_Service();
                List<Item> itemlist = itemservice.GetItems();

                foreach (Item item in itemlist)
                {
                    ListViewItem list = new ListViewItem(item.ItemID.ToString());
                    list.SubItems.Add(item.Name.ToString());
                    list.SubItems.Add(item.Price.ToString());
                    list.SubItems.Add(item.Stock.ToString());
                    list.SubItems.Add(item.Category.ToString());
                    list.SubItems.Add(item.VATRate.ToString());

                    listViewBarmanDisplay.Items.Add(list);
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void KitchenDisplay_Load(object sender, EventArgs e)
        {

        }

        private void FrameBoxKitchen_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void lblUserName_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listViewKitchenOrdersDetail.SelectedItems.Count != 1)
            {
                return;
            }
        }

        private void listViewTableKitchen_SelectedIndexChanged(object sender, EventArgs e)
        {
            item = new Item
            {
                ItemID = Convert.ToInt32(listViewTableKitchen.SelectedItems[0].SubItems[0].Text),
                Name = "",
                Price = Convert.ToInt32(listViewTableKitchen.SelectedItems[0].SubItems[0].Text),
                Stock = Convert.ToInt32(listViewTableKitchen.SelectedItems[0].SubItems[0].Text),
                Category = "",
                VATRate = Convert.ToInt32(listViewTableKitchen.SelectedItems[0].SubItems[0].Text),
                menuType = true
            };
        }

        private void btnOrderReadyToBeServed_Click_1(object sender, EventArgs e)
        {

        }
    }
}
