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
            getTableStatus();
        }

        #region Buttons
        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginScreen loginScreen = new LoginScreen();
            loginScreen.Show();
            this.Close();
        }

        private void btnTable1_Click(object sender, EventArgs e)
        {
            // Get the button ID from the sender text
            int tableNumber = int.Parse(sender.ToString().Substring(35));

            // Open a new table details with the retrieved table number
            TableDetails tableDetails = new TableDetails(loggedUser, tableNumber);
            tableDetails.Show();
            this.Close();
        }
        #endregion


        #region Table status and Order status update methods
        void getTableStatus()
        {
            Table_Service table_service = new Table_Service();
            List<Table> listOfTables = table_service.getAllTables();

            Button[] listOfTableButtons = { btnTable1, btnTable2, btnTable3, btnTable4, btnTable5, btnTable6, btnTable7, btnTable8, btnTable9, btnTable10 };

            int count = 0;
            // Iterate through every table, and use the listOfTableButtons to get the table status
            foreach (Table table in listOfTables)
            {
                if (table.Status == Status.Occupied)
                {
                    listOfTableButtons[count].BackgroundImage = ChapeauxUI.Properties.Resources.table_occupied;
                    getOrderStatus(table); // After getting table status, get the Order status
                }
                else if (table.Status == Status.Late)
                {
                    listOfTableButtons[count].BackgroundImage = ChapeauxUI.Properties.Resources.table_late;
                    getOrderStatus(table); // After getting table status, get the Order status
                }

                count++;
            }
        }

        void getOrderStatus(Table table)
        {
            int tableId = table.TableID;

            OrderItem_Service orderItem_Service = new OrderItem_Service();
            List<OrderItem> listOfDrinkStatus = orderItem_Service.getDrinksStatus(tableId);
            List<OrderItem> listOfFoodStatus = orderItem_Service.getFoodStatus(tableId);

            // Array with food and drink icons name, for every table
            PictureBox[,] FoodAndDrinksIcons = new PictureBox[,] { { pctT1_FoodStatus, pctT1_DrinkStatus }, 
                                                                  { pctT2_FoodStatus, pctT2_DrinkStatus }, 
                                                                  { pctT3_FoodStatus, pctT3_DrinkStatus }, 
                                                                  { pctT4_FoodStatus, pctT4_DrinkStatus }, 
                                                                  { pctT5_FoodStatus, pctT5_DrinkStatus }, 
                                                                  { pctT6_FoodStatus, pctT6_DrinkStatus }, 
                                                                  { pctT7_FoodStatus, pctT7_DrinkStatus }, 
                                                                  { pctT8_FoodStatus, pctT8_DrinkStatus }, 
                                                                  { pctT9_FoodStatus, pctT9_DrinkStatus }, 
                                                                  { pctT10_FoodStatus, pctT10_DrinkStatus } 
                                                                };

            // List of Drink and Food
            List<List<OrderItem>> foodAndDrink = new List<List<OrderItem>>();
            foodAndDrink.Add(listOfDrinkStatus);
            foodAndDrink.Add(listOfFoodStatus);

            int foodOrDrink = 0; // This is used to decide if we need the food icons or drink icons
            tableId = --tableId; // Changed this to use in the array

            // Iterate through Food and Drink, it first will go through food Drink Items and then Food Items
            foreach (List<OrderItem> orderType in foodAndDrink)
            {
                State? previousItemsState = null;
                foreach (OrderItem item in orderType)
                {
                    //Show specific standard food or drink icon
                    FoodAndDrinksIcons[tableId, foodOrDrink].Show();

                    // Checking if the icon should be shown as served
                    if (item.State == State.served && (previousItemsState != State.ready || previousItemsState != State.loading))
                    {
                        previousItemsState = State.served;

                        // Change icon to served
                        if (foodOrDrink == 0)
                            FoodAndDrinksIcons[tableId, foodOrDrink].Image = ChapeauxUI.Properties.Resources.food_served1;
                        else
                            FoodAndDrinksIcons[tableId, foodOrDrink].Image = ChapeauxUI.Properties.Resources.drinks_served1;

                    }
                    // Checking if the icon should be shown as Ready
                    else if (item.State == State.ready && previousItemsState != State.loading)
                    {
                        previousItemsState = State.ready;
                        FoodAndDrinksIcons[tableId, foodOrDrink].Show();

                        // Change icon to ready
                        if (foodOrDrink == 0)
                            FoodAndDrinksIcons[tableId, foodOrDrink].Image = ChapeauxUI.Properties.Resources.food_ReadyToBeServed1;
                        else
                            FoodAndDrinksIcons[tableId, foodOrDrink].Image = ChapeauxUI.Properties.Resources.drinks_ReadyToBeServed1;
                    }
                    // Checking if the icon should be shown as Loading
                    else if (item.State == State.loading)
                    {
                        previousItemsState = State.loading;
                        FoodAndDrinksIcons[tableId, foodOrDrink].Show();

                        // Change icon to loading
                        if (foodOrDrink == 0)
                            FoodAndDrinksIcons[tableId, foodOrDrink].Image = ChapeauxUI.Properties.Resources.food_beingPrepared1;
                        else
                            FoodAndDrinksIcons[tableId, foodOrDrink].Image = ChapeauxUI.Properties.Resources.drinks_beingPrepared1;
                    }
                }
                foodOrDrink++;
            }
        }
        #endregion
    }
}
        