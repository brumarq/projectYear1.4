# Chapeaux to-do list

### General

- [ ] the system must be intuitive so new employees will have no troubles using it;
- [ ] performed actions of restaurant employees with the system should be logged (e.g. when taking an order);
- [ ] logging in with a simple (4-digit) code is sufficient, logging off should also be possible of course;

### Restaurant overview

- [ ] there must be a restaurant overview displaying all tables with an indication ‘free’ or ‘occupied’ (text or icon or color or ...); 
- [ ] in this overview one can also see (for each table)if an order is running at the moment, and the waiting time for the order (text or icon or color or ...);

### Taking orders

- [ ] restaurant employees should be able to add new order items (drinks and food) at a table in a userfriendly and efficient way; items of the menus (lunch, dinner, drinks) should be selectable via a ‘menu tree’ (e.g. ‘dinner’ ‘desserts’ ‘dame blanche’);
- [ ] when taking orders the chance of making mistakes should be minimized;
- [ ] if a menu item (drink or food) is added to the same order multiple times, then these items must be grouped (item occurs only once in the order with correct count);
- [ ] when taking an order a comment can be added for each item (like ‘rare’ for a steak);
- [ ] if a drink or food item is not available (out of stock) then the restaurant employee (taking an order) will be informed/notified;
- [ ] it should be easy to change an (incorrect) order: single items of an order can be changed and removed, and a whole order can be removed at once;
- [ ] when taking an order the stock of the ordered items must be decreased;

### Bar overview

- [ ] in the bar the running drink orders are displayed automatically;
- [ ] bar personnel should be able to filter the drink orders: only display the running orders, or only display the finished orders of today;
- [ ] after preparing an order (of a table) bar personnel can change the state of the order to ‘ready’, so a restaurant employee will know that the drinks can be delivered at the table;

### Kitchen overview

- [ ] in the kitchen the running food orders are displayed automatically;
- [ ] kitchen personnel should be able to filter the food orders: only display the running orders, or only display the finished orders of today;
- [ ] after preparing an order (of a table) kitchen personnel can change the state of the order to ‘ready’, so a restaurant employee will know that the food can be delivered at the table;

### Payment

- [ ] restaurant personnel can lookup an order (of a specific table) and view all order items (drinks and food) and the total amount and VAT-value;
- [ ] restaurant personnel should be able to add a comment to an order (e.g. a complaint of a customer, or a compliment for the chef);
- [ ] it should be possible to select the method of payment (creditcard, pin, cash);
- [ ] the method of payment and the amount payed (containing a possible tip) must be
       stored in the database;

### Management

- [ ] the items of the menus can be modified (change/delete existing items, add new items);
- [ ] existing employees can be changed (name, login code, ...) and deleted; new employees can be added;
- [ ] the stock of menu items (food and drinks) can be chanded (increase/decrease);
- [ ] an overview is available containing incomes and current stock of all items (bar and kitchen);


