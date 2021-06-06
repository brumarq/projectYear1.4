using ChapeauUI;
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

            State? drinkStatus = null;
            foreach (OrderItem drink in listOfDrinkStatus)
            {
                if (drink.State == State.served && (drinkStatus != State.ready || drinkStatus != State.loading))
                {
                    drinkStatus = State.served;
                    listOfTableStatus[count, 0].Show();
                    listOfTableStatus[count, 0].Image = ChapeauxUI.Properties.Resources.drinks_served1;
                }
                else if (drink.State == State.ready && drinkStatus != State.loading)
                {
                    drinkStatus = State.ready;
                    listOfTableStatus[count, 0].Show();
                    listOfTableStatus[count, 0].Image = ChapeauxUI.Properties.Resources.drinks_ReadyToBeServed1;
                }
                else if (drink.State == State.loading)
                {
                    drinkStatus = State.loading;
                    listOfTableStatus[count, 0].Show();
                    listOfTableStatus[count, 0].Image = ChapeauxUI.Properties.Resources.drinks_beingPrepared1;
                }
            }

            State? foodStatus = null;
            foreach (OrderItem food in listOfFoodStatus)
            {
                if (food.State == State.served && (foodStatus != State.ready || foodStatus != State.loading))
                {
                    foodStatus = State.served;
                    listOfTableStatus[count, 1].Show();
                    listOfTableStatus[count, 1].Image = ChapeauxUI.Properties.Resources.food_served1;
                }
                else if (food.State == State.ready && foodStatus != State.loading)
                {
                    foodStatus = State.ready;
                    listOfTableStatus[count, 1].Show();
                    listOfTableStatus[count, 1].Image = ChapeauxUI.Properties.Resources.food_ReadyToBeServed1;
                }
                else if (food.State == State.loading)
                {
                    foodStatus = State.loading;
                    listOfTableStatus[count, 1].Show();
                    listOfTableStatus[count, 1].Image = ChapeauxUI.Properties.Resources.food_beingPrepared1;
                }
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginScreen loginScreen = new LoginScreen();
            loginScreen.Show();
            this.Close();
        }

        private void tableClicked(int tableNumber)
        {
            TableDetails tableDetails = new TableDetails(loggedUser, tableNumber);
            tableDetails.Show();
            this.Close();
        }

        private void btnTable1_Click(object sender, EventArgs e)
        {
            tableClicked(1);
        }

        private void btnTable2_Click(object sender, EventArgs e)
        {
            tableClicked(2);
        }

        private void btnTable3_Click(object sender, EventArgs e)
        {
            tableClicked(3);
        }

        private void btnTable4_Click(object sender, EventArgs e)
        {
            tableClicked(4);
        }

        private void btnTable5_Click(object sender, EventArgs e)
        {
            tableClicked(5);
        }

        private void btnTable6_Click(object sender, EventArgs e)
        {
            tableClicked(6);
        }

        private void btnTable7_Click(object sender, EventArgs e)
        {
            tableClicked(7);
        }

        private void btnTable8_Click(object sender, EventArgs e)
        {
            tableClicked(8);
        }

        private void btnTable9_Click(object sender, EventArgs e)
        {
            tableClicked(9);
        }

        private void btnTable10_Click(object sender, EventArgs e)
        {
            tableClicked(10);
        }
    }
}
