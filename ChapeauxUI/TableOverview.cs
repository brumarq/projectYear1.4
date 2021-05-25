using ChapeauxLogic;
using ChapeauxModel;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ChapeauxUI
{
    public partial class TableOverviewForm : Form
    {
        User loggedUser;
        public TableOverviewForm(User user)
        {
            loggedUser = user;
            InitializeComponent();
        }

        private void TableOverviewForm_Load(object sender, EventArgs e)
        {
            lblUserFullName.Text = $"{loggedUser.FirstName} {loggedUser.LastName}";

            Table_Service table_service = new Table_Service();
            
            List<Table> listOfTables = table_service.getAllTables();
            Button[] listOfTableButtons = { btnTable1, btnTable2, btnTable3, btnTable4, btnTable5, btnTable6, btnTable7, btnTable8, btnTable9, btnTable10 };
            int count = 0;
            foreach (Table table in listOfTables)
            {
                if (table.Status == Status.Occupied)
                {
                    listOfTableButtons[count].BackgroundImage = ChapeauxUI.Properties.Resources.table_occupied;
                    getOrderStatus(table, count);
                }
                else if (table.Status == Status.Late)
                {
                    listOfTableButtons[count].BackgroundImage = ChapeauxUI.Properties.Resources.table_late;
                    getOrderStatus(table, count);
                }

                count++;
            }
        }

        void getOrderStatus( Table table, int count) 
        {
            OrderItem_Service orderItem_Service = new OrderItem_Service();
            PictureBox[,] listOfTableStatus = new PictureBox[,] { { pctT1_DrinkStatus, pctT1_FoodStatus }, { pctT2_DrinkStatus, pctT2_FoodStatus }, { pctT3_DrinkStatus, pctT3_FoodStatus }, { pctT4_DrinkStatus, pctT4_FoodStatus }, { pctT5_DrinkStatus, pctT5_FoodStatus }, { pctT6_DrinkStatus, pctT6_FoodStatus }, { pctT7_DrinkStatus, pctT7_FoodStatus }, { pctT8_DrinkStatus, pctT8_FoodStatus }, { pctT9_DrinkStatus, pctT9_FoodStatus }, { pctT10_DrinkStatus, pctT10_FoodStatus } };

            List<OrderItem> listOfDrinkStatus = orderItem_Service.getDrinksStatus(table.TableID);
            List<OrderItem> listOfFoodStatus = orderItem_Service.getFoodStatus(table.TableID);

            string drinkStatus = "";
            foreach (OrderItem drink in listOfDrinkStatus)
            {
                if (drink.State == "served" && (drinkStatus != "ready" || drinkStatus != "loading"))
                {
                    drinkStatus = "served";
                    listOfTableStatus[count, 0].Show();
                    listOfTableStatus[count, 0].Image = ChapeauxUI.Properties.Resources.drinks_served1;
                }
                else if (drink.State == "ready" && drinkStatus != "loading")
                {
                    drinkStatus = "ready";
                    listOfTableStatus[count, 0].Show();
                    listOfTableStatus[count, 0].Image = ChapeauxUI.Properties.Resources.drinks_ReadyToBeServed1;
                }
                else if (drink.State == "loading")
                {
                    drinkStatus = "loading";
                    listOfTableStatus[count, 0].Show();
                    listOfTableStatus[count, 0].Image = ChapeauxUI.Properties.Resources.drinks_beingPrepared1;
                }
            }

            string foodStatus = "";
            foreach (OrderItem food in listOfFoodStatus)
            {
                if (food.State == "served" && (foodStatus != "ready" || foodStatus != "loading"))
                {
                    foodStatus = "served";
                    listOfTableStatus[count, 1].Show();
                    listOfTableStatus[count, 1].Image = ChapeauxUI.Properties.Resources.food_served1;
                }
                else if (food.State == "ready" && foodStatus != "loading")
                {
                    foodStatus = "ready";
                    listOfTableStatus[count, 1].Show();
                    listOfTableStatus[count, 1].Image = ChapeauxUI.Properties.Resources.food_ReadyToBeServed1;
                }
                else if (food.State == "loading")
                {
                    foodStatus = "loading";
                    listOfTableStatus[count, 1].Show();
                    listOfTableStatus[count, 1].Image = ChapeauxUI.Properties.Resources.food_beingPrepared1;
                }
            }
        }

    }
}
