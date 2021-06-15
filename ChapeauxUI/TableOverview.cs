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

            Button[] listOfTableButtons = { btnTable1, btnTable2, btnTable3,
                                            btnTable4, btnTable5, btnTable6,
                                            btnTable7, btnTable8, btnTable9,
                                            btnTable10
                                          };

            // Get a list of all the orderItems status and the Order they belong to
            OrderItem_Service orderItem_Service = new OrderItem_Service();
            List<List<Tuple<OrderItem, Order>>> listOfDrinkAndFoodStatus = new List<List<Tuple<OrderItem, Order>>>();
            listOfDrinkAndFoodStatus.Add(orderItem_Service.GetAllFoodStatus());
            listOfDrinkAndFoodStatus.Add(orderItem_Service.GetAllDrinksStatus());

            int count = 0;
            // Iterate through every table, and use the listOfTableButtons to get the table status
            foreach (Table table in listOfTables)
            {
                if (table.Status == Status.Occupied)
                {
                    listOfTableButtons[count].BackgroundImage = ChapeauxUI.Properties.Resources.table_occupied;
                    getOrderStatus(table, listOfDrinkAndFoodStatus); // After getting table status, get the Order status
                }
                else if (table.Status == Status.Free)
                {
                    listOfTableButtons[count].BackgroundImage = ChapeauxUI.Properties.Resources.table_free;
                    getOrderStatus(table, listOfDrinkAndFoodStatus); // After getting table status, get the Order status
                }

                    count++;
            }
        }

        void getOrderStatus(Table table, List<List<Tuple<OrderItem, Order>>> listOfDrinkAndFoodStatus)
        {
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

            int foodOrDrink = 0; // This is used to decide if we need the drink icons or food icons, start with food

            // Iterate through Food and Drink list
            foreach (List<Tuple<OrderItem, Order>> orderType in listOfDrinkAndFoodStatus)
            {
                State? previousItemsState = null;
                int previousOrderID = -1; // This will allow the program to know if the order is different than before

                foreach (Tuple<OrderItem, Order> tuple in orderType)
                {
                    //Checking if the order is different than before
                    if (previousOrderID != tuple.Item2.OrderID)
                    {
                        // Change the variable to the new orderId and reset the state
                        previousOrderID = tuple.Item2.OrderID;
                        previousItemsState = null;
                    }

                    // This variable is used to choose which table the needed icon belongs to
                    int tableID = tuple.Item2.TableID - 1;

                    //Show specific standard food or drink icon
                    FoodAndDrinksIcons[tableID, foodOrDrink].Show();

                    // Checking if the icon should be shown as served
                    if (tuple.Item1.State == State.served && (previousItemsState != State.ready && previousItemsState != State.loading))
                    {
                        previousItemsState = State.served;

                        // Change icon to served
                        if (foodOrDrink == 0)
                            FoodAndDrinksIcons[tableID, foodOrDrink].Image = ChapeauxUI.Properties.Resources.food_served1;
                        else
                            FoodAndDrinksIcons[tableID, foodOrDrink].Image = ChapeauxUI.Properties.Resources.drinks_served1;

                    }
                    // Checking if the icon should be shown as Ready
                    else if (tuple.Item1.State == State.ready && previousItemsState != State.loading)
                    {
                        previousItemsState = State.ready;

                        // Change icon to ready
                        if (foodOrDrink == 0)
                            FoodAndDrinksIcons[tableID, foodOrDrink].Image = ChapeauxUI.Properties.Resources.food_ReadyToBeServed1;
                        else
                            FoodAndDrinksIcons[tableID, foodOrDrink].Image = ChapeauxUI.Properties.Resources.drinks_ReadyToBeServed1;
                    }
                    // Checking if the icon should be shown as Loading
                    else if (tuple.Item1.State == State.loading)
                    {
                        previousItemsState = State.loading;

                        // Change icon to loading
                        if (foodOrDrink == 0)
                            FoodAndDrinksIcons[tableID, foodOrDrink].Image = ChapeauxUI.Properties.Resources.food_beingPrepared1;
                        else
                            FoodAndDrinksIcons[tableID, foodOrDrink].Image = ChapeauxUI.Properties.Resources.drinks_beingPrepared1;
                    }
                }
                foodOrDrink++; // Continue with drink icons
            }
        }
        #endregion

        private void loadingTimer_Tick(object sender, EventArgs e)
        {
            getTableStatus();
        }
    }
}