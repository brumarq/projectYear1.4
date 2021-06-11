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

        void getOrderStatus(Table table, int count)
        {
            OrderItem_Service orderItem_Service = new OrderItem_Service();
            PictureBox[,] listOfTableStatus = new PictureBox[,] { { pctT1_FoodStatus, pctT1_DrinkStatus }, { pctT2_FoodStatus, pctT2_DrinkStatus }, { pctT3_FoodStatus, pctT3_DrinkStatus }, { pctT4_FoodStatus, pctT4_DrinkStatus }, { pctT5_FoodStatus, pctT5_DrinkStatus }, { pctT6_FoodStatus, pctT6_DrinkStatus }, { pctT7_FoodStatus, pctT7_DrinkStatus }, { pctT8_FoodStatus, pctT8_DrinkStatus }, { pctT9_FoodStatus, pctT9_DrinkStatus }, { pctT10_FoodStatus, pctT10_DrinkStatus } };

            List<OrderItem> listOfDrinkStatus = orderItem_Service.getDrinksStatus(table.TableID);
            List<OrderItem> listOfFoodStatus = orderItem_Service.getFoodStatus(table.TableID);

            List<List<OrderItem>> foodAndDrink = new List<List<OrderItem>>();

            foodAndDrink.Add(listOfDrinkStatus);
            foodAndDrink.Add(listOfFoodStatus);


            int foodOrDrink = 0;
            foreach (List<OrderItem> orderType in foodAndDrink)
            {
                State? status = null;
                foreach (OrderItem item in orderType)
                {
                    if (item.State == State.served && (status != State.ready || status != State.loading))
                    {
                        status = State.served;
                        listOfTableStatus[count, foodOrDrink].Show();

                        if (foodOrDrink == 0)
                            listOfTableStatus[count, foodOrDrink].Image = ChapeauxUI.Properties.Resources.food_served1;
                        else
                            listOfTableStatus[count, foodOrDrink].Image = ChapeauxUI.Properties.Resources.drinks_served1;

                    }
                    else if (item.State == State.ready && status != State.loading)
                    {
                        status = State.ready;
                        listOfTableStatus[count, foodOrDrink].Show();

                        if (foodOrDrink == 0)
                            listOfTableStatus[count, foodOrDrink].Image = ChapeauxUI.Properties.Resources.food_ReadyToBeServed1;
                        else
                            listOfTableStatus[count, foodOrDrink].Image = ChapeauxUI.Properties.Resources.drinks_ReadyToBeServed1;
                    }
                    else if (item.State == State.loading)
                    {
                        status = State.loading;
                        listOfTableStatus[count, foodOrDrink].Show();

                        if (foodOrDrink == 0)
                            listOfTableStatus[count, foodOrDrink].Image = ChapeauxUI.Properties.Resources.food_beingPrepared1;
                        else
                            listOfTableStatus[count, foodOrDrink].Image = ChapeauxUI.Properties.Resources.drinks_beingPrepared1;
                    }
                }

                foodOrDrink++;
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginScreen loginScreen = new LoginScreen();
            loginScreen.Show();
            this.Close();
        }

        private void btnTable1_Click(object sender, EventArgs e)
        {
            int tableNumber = int.Parse(sender.ToString().Substring(35));
            TableDetails tableDetails = new TableDetails(loggedUser, tableNumber);
            tableDetails.Show();
            this.Close();
        }
    }
}
