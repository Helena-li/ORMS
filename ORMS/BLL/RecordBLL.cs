using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ORMS.DAL;
using System.Data.Linq.SqlClient;
using ORMS.PL_view;

namespace ORMS.BLL
{
    class RecordBLL
    {
        ORMSDBDataContext db = new ORMSDBDataContext();
        EmployeeDAL emp = new EmployeeDAL();
        MenuDAL menuDAL = new MenuDAL();
        TableDAL tableDAL = new TableDAL();
        OrderDAL orderDAL = new OrderDAL();
        OrderItemDAL oiDAL = new OrderItemDAL();
        PayrollDAL payDAL = new PayrollDAL();
        InvoiceDAL invoiceDAL = new InvoiceDAL();
        SupplierDAL supplierDAL = new SupplierDAL();
        OrderBLL orderBLL = new OrderBLL();
        StockDAL stockDAL = new StockDAL();
        MenuItemDAL mid = new MenuItemDAL();
        SupplierInventoryDAL siDAL = new SupplierInventoryDAL();

        // CRUD employee
        #region employee
        public int addStaff(Employee nw)
        {
            /* Store the MD5 of password */
            LoginBLL l = new LoginBLL();
            string password = l.GetMd5Hash(nw.Password);
            nw.Password = password;

            return emp.addItem(nw);
        }


        internal void updateEmployee(Employee employee)
        {
            LoginBLL l = new LoginBLL();
            string password = l.GetMd5Hash(employee.Password);
            employee.Password = password;
            emp.updateItem(employee);
        }

        public Employee getStaff(int pid)
        {
            return emp.getItem(pid);
        }

        internal void deleteEmployee(int bid)
        {
            emp.deleteItem(bid);
        }

        public bool checkStaff(int uid, string password, string type)
        {
            LoginBLL l = new LoginBLL();
            string passwordMD5 = l.GetMd5Hash(password);
            var staff = from u in db.Employees
                        where u.EmployeeID == uid && u.Password == passwordMD5
                        && u.RoleType == type
                        select u;
            if (staff.Any(u => u.EmployeeID == uid))
                return true;
            return false;
        }


        internal object getEmployeeListByName(string name)
        {
            string pattern1 = "%" + name + "%";
            var EmployeeList = from l in db.Employees
                               where SqlMethods.Like(l.Name, pattern1)
                               select new
                               {
                                   EmployeeID = l.EmployeeID,
                                   Name = l.Name,
                                   Address = l.Address,
                                   DoB = l.DoB,
                                   Email = l.Email,
                                   Phone = l.Phone,
                                   WorkType = l.WorkType,
                                   RoleType = l.RoleType,
                                   Password = l.Password
                               };
            return EmployeeList.Distinct();
        }

        internal object getEmployeeList()
        {
            var EmployeeList = from l in db.Employees
                               select new
                               {
                                   EmployeeID = l.EmployeeID,
                                   Name = l.Name,
                                   Address = l.Address,
                                   DoB = l.DoB,
                                   Email = l.Email,
                                   Phone = l.Phone,
                                   WorkType = l.WorkType,
                                   RoleType = l.RoleType,
                                   Password = l.Password
                               };
            return EmployeeList.Distinct();
        }


        #endregion

        // CRUD menu and items for a menu
        #region menu
        internal object getMenuList()
        {
            var MenuList = from l in db.Menus
                           where l.OrderStatus == true
                           select new
                           {
                               MenuID = l.MenuID,
                               Name = l.Name,
                               Type = l.Type,
                               Price = l.Price,
                               OrderStatus = l.OrderStatus
                           };
            return MenuList.Distinct();
        }
        internal object getAllMenuList()
        {
            var MenuList = from l in db.Menus
                           select new
                           {
                               MenuID = l.MenuID,
                               Name = l.Name,
                               Type = l.Type,
                               Price = l.Price,
                               OrderStatus = l.OrderStatus
                           };
            return MenuList.Distinct();
        }

        internal object getMenuListById(int uid)
        {
            var MenuList = from l in db.Menus
                           where l.MenuID == uid
                           select new
                           {
                               MenuID = l.MenuID,
                               Name = l.Name,
                               Type = l.Type,
                               Price = l.Price,
                               OrderStatus = l.OrderStatus
                           };
            return MenuList.Distinct();
        }


        internal object getMenuListByName(string name)
        {
            string pattern1 = "%" + name + "%";

            var MenuList = from l in db.Menus
                           where SqlMethods.Like(l.Name, pattern1)
                           select new
                           {
                               MenuID = l.MenuID,
                               Name = l.Name,
                               Type = l.Type,
                               Price = l.Price,
                               OrderStatus = l.OrderStatus
                           };
            return MenuList.Distinct();
        }


        internal void addMenu(Menu menu)
        {
            menuDAL.addItem(menu);
        }

        internal void updateMenu(Menu menu)
        {
            menuDAL.updateItem(menu);
        }

        internal void deleteMenu(int bid)
        {
            menuDAL.deleteItem(bid);
        }

        internal object getMenuItemsListByID(int uid)
        {
            var ItemList = from l in db.MenuItems
                           where l.MenuID == uid
                           select new
                           {
                               ID = l.ID,
                               MenuID = l.MenuID,
                               ItemID = l.ItemID,
                               Name = l.Inventory.StockName
                           };
            return ItemList.Distinct();
        }

        internal void addMenuItems(MenuItem item)
        {
            mid.addItem(item);
        }

        internal void updateMenuItems(MenuItem item)
        {
            mid.updateItem(item);
        }


        internal void deleteMenuItems(int bid)
        {
            mid.deleteItem(bid);
        }


        #endregion

        // CRUD order and order items for a menu
        // CRUD table
        // observer pattern here
        #region order

        internal object getTableList()
        {
            var tableList = from l in db.TableNumbers
                            select new
                            {
                                TableID = l.TableID,
                                Status = l.Status
                            };
            return tableList.Distinct();
        }

        internal void updateTable(TableNumber tn)
        {
            tableDAL.updateItem(tn);
        }

        internal object getOrderList()
        {

            var orderlist = from l in db.Orders
                            select new
                            {
                                OrderID = l.OrderID,
                                TableID = l.TableID,
                                OrderStatus = l.OrderStatus,
                                EmployeeID = l.EmployeeID
                            };
            return orderlist.Distinct();
        }

        internal int addOrder(Order order)
        {
            return orderDAL.addItem(order);
        }

        internal object getOrderListById(int uid)
        {
            var orderList = from l in db.Orders
                            where l.TableID == uid
                            select new
                            {
                                OrderID = l.OrderID,
                                TableID = l.TableID,
                                OrderStatus = l.OrderStatus,
                                EmployeeID = l.EmployeeID
                            };
            return orderList.Distinct();
        }

        internal object getOrderItemListById(int id)
        {
            var orderList = from l in db.OrderItems
                            where l.OrderID == id
                            select new
                            {
                                ID = l.ID,
                                MenuID = l.MenuID,
                                MenuName = l.Menu.Name,
                                Quantity = l.Quantity,
                                Price=l.Menu.Price,
                                OrderID = l.OrderID
                            };
            return orderList.Distinct();
        }

        // this check stock status
        // add and update will reduce stocks
        internal void reduceStock(OrderItem orderItem)
        {
            var itemsID = orderBLL.getStockItemsForMenu(orderItem.MenuID);
            var quan = orderItem.Quantity;
            // use iterator
            foreach (var stockItem in itemsID)
            {
                Inventory inventory = stockDAL.getItem(stockItem);
                inventory.RestockQuantity -= quan;
                stockDAL.updateItem(inventory);
                // observer pattern
                // get the status
                if (inventory.RestockQuantity == 0)
                {
                    // raise or fire the event 
                    fireObserverEvent(inventory.StockID);
                }
            }
        }

        // invoke event
        private void fireObserverEvent(int stockID)
        {
            StockBLL stockBll = new StockBLL(stockID);

            InventoryForm invform = new InventoryForm();
            OrderBLL orderBLL = new OrderBLL();

            stockBll.AddObserver(new NotifyEventDelegate(invform.ReceiveAndNotify));
            stockBll.AddObserver(new NotifyEventDelegate(orderBLL.ReceiveAndNotify));
            stockBll.Update();
        }
        
        // add order need to check the restore and reduce restore
        internal bool addOrderItem(OrderItem orderItem)
        {
            bool checkResult = orderBLL.checkStocksForAMenu(orderItem.Quantity, orderItem.MenuID);
            if (checkResult)
            {
                oiDAL.addItem(orderItem);
                reduceStock(orderItem);
                return true;
            }
            else return false;
        }

        // update order need to recover and reduce the restore 
        internal bool updateOrderItem(OrderItem oi)
        {
            bool checkResult = orderBLL.checkStocksForAMenu(oi.Quantity, oi.MenuID);
            if (checkResult)
            {
                OrderItem iniOrderItem = oiDAL.getItem(oi.ID);
                recoverStockItems(iniOrderItem);
                
                oiDAL.updateItem(oi);
                reduceStock(oi);
                return true;
            }
            else return false;

        }

        private void recoverStockItems(OrderItem iniOrderItem)
        {
            var itemsID = orderBLL.getStockItemsForMenu(iniOrderItem.MenuID);
            var quan = iniOrderItem.Quantity;
            foreach (var stockItem in itemsID)
            {
                Inventory inventory = stockDAL.getItem(stockItem);
                //var iniQuantity = inventory.RestockQuantity;
                inventory.RestockQuantity += quan;
                updateStock(inventory);
                //stockDAL.updateItem(inventory);
            }
        }

        internal void deleteOrderItem(int bid)
        {
            OrderItem iniOrderItem = oiDAL.getItem(bid);
            recoverStockItems(iniOrderItem);
            oiDAL.deleteItem(bid);
        }

        //internal object getOrderItemByMenuId(int orderId, int id)
        //{
        //    var orderList = from l in db.OrderItems
        //                    where (l.OrderID == orderId) && (l.MenuID == id)
        //                    select new
        //                    {
        //                        ID = l.ID,
        //                        MenuID = l.MenuID,
        //                        MenuName = l.Menu.Name,
        //                        Quantity = l.Quantity,
        //                        OrderID = l.OrderID
        //                    };
        //    return orderList.Distinct();
        //}

        // close order and update table status
        internal void closeOrder(Order order)
        {
            orderDAL.updateItem(order);
            TableNumber tn = new TableNumber();
            tn.TableID = order.TableID;
            tn.Status = "Available";
            tableDAL.updateItem(tn);

        }

        // generate invoice, calc invoice and save
        internal Invoice generateInvoice(int orderID)
        {
            Invoice invoice = new Invoice();
            invoice.Time = DateTime.Today;
            invoice.OrderID = orderID;
            invoice.TotalPrice = CalcInvoice(orderID);
            invoiceDAL.addItem(invoice);
            return invoice;
        }

        // from order id get order items and calc total price
        private double CalcInvoice(int orderID)
        {
            //var orderItems = getOrderItemListById(order.OrderID);
            var orderItems = from l in db.OrderItems
                             where l.OrderID == orderID
                             select new
                             {
                                 ID = l.ID,
                                 MenuID = l.MenuID,
                                 MenuName = l.Menu.Name,
                                 Quantity = l.Quantity,
                                 OrderID = l.OrderID,
                                 Price = l.Menu.Price
                             };
            double totalPrice = 0;
            foreach (var item in orderItems)
            {
                totalPrice += item.Quantity * item.Price;
            }
            return totalPrice;
        }

        #endregion

        // CRUD payroll 
        #region payroll
        internal object getPayrollList()
        {
            var payrollList = from l in db.Payrolls
                              select new
                              {
                                  SalaryID = l.SalaryID,
                                  EmployeeID = l.EmployeeID,
                                  OverHours = l.OverHours,
                                  WorkHours = l.WorkHours,
                                  PaymentStart = l.PaymentStart,
                                  PaymentEnd = l.PaymentEnd,
                                  HourlySalary = l.HourlySalary,
                                  OverTimeSalaryRate = l.OverTimeHourlyRate,
                                  TotalSalary = l.TotalSalary,
                                  Tax = l.Tax
                              };
            return payrollList.Distinct();
        }

        internal int addPayment(Payroll pay)
        {
            PayrollBLL payrollBLL;
            EmployeeDAL empDAL = new EmployeeDAL();
            Employee emp = empDAL.getItem(pay.EmployeeID);
            if (emp.WorkType == "Full time")
            {
                payrollBLL = new FulltimePayrollBLL();
                pay.TotalSalary = payrollBLL.CalcSalary(pay);
                pay.Tax = payrollBLL.CalcTax(pay.TotalSalary);
            }
            else
            {
                payrollBLL = new ParttimePayrollBLL();
                pay.TotalSalary = payrollBLL.CalcSalary(pay);
                pay.Tax = payrollBLL.CalcTax(pay.TotalSalary);
            }
            return payDAL.addItem(pay);
        }

        internal object getPayrollListByID(int id)
        {
            var payrollList = from l in db.Payrolls
                              where l.EmployeeID == id
                              select new
                              {
                                  SalaryID = l.SalaryID,
                                  EmployeeID = l.EmployeeID,
                                  OverHours = l.OverHours,
                                  WorkHours = l.WorkHours,
                                  PaymentStart = l.PaymentStart,
                                  PaymentEnd = l.PaymentEnd,
                                  HourlySalary = l.HourlySalary,
                                  OverTimeSalaryRate = l.OverTimeHourlyRate,
                                  TotalSalary = l.TotalSalary,
                                  Tax = l.Tax
                              };
            return payrollList.Distinct();
        }

        internal void updatePayment(Payroll pay)
        {
            PayrollBLL payrollBLL;
            EmployeeDAL empDAL = new EmployeeDAL();
            Employee emp = empDAL.getItem(pay.EmployeeID);
            if (emp.WorkType == "Full time")
            {
                payrollBLL = new FulltimePayrollBLL();
                pay.TotalSalary = payrollBLL.CalcSalary(pay);
                pay.Tax = payrollBLL.CalcTax(pay.TotalSalary);
            }
            else
            {
                payrollBLL = new ParttimePayrollBLL();
                pay.TotalSalary = payrollBLL.CalcSalary(pay);
                pay.Tax = payrollBLL.CalcTax(pay.TotalSalary);
            }
            payDAL.updateItem(pay);
        }

        internal void deletePayroll(int bid)
        {
            payDAL.deleteItem(bid);
        }
        #endregion


        internal object getStockListByID(int stockID)
        {
            var stockList = from l in db.SupplierInventories
                            where l.ItemID == stockID
                            select new
                            {
                                ID = l.ID,
                                StockID = l.ItemID,
                                SupplierID = l.SupplierID,
                                Supplier = l.Supplier.SupplierName
                            };
            return stockList.Distinct();
        }

        // CRUD supplier and CRUD supplier for inventory 
        #region supplier
        internal object getSupplierList()
        {
            var supplierList = from l in db.Suppliers
                               select new
                               {
                                   SupplierID = l.SupplierID,
                                   SupplierName = l.SupplierName,
                                   Address = l.Address,
                                   Phone = l.Phone
                               };
            return supplierList.Distinct();
        }

        internal object getSupplierListtByID(int id)
        {
            var supplierList = from l in db.Suppliers
                               where l.SupplierID == id
                               select new
                               {
                                   SupplierID = l.SupplierID,
                                   SupplierName = l.SupplierName,
                                   Address = l.Address,
                                   Phone = l.Phone
                               };
            return supplierList.Distinct();
        }

        internal int addSupplier(Supplier supplier)
        {
            return supplierDAL.addItem(supplier);
        }

        internal void updateSupplier(Supplier supplier)
        {
            supplierDAL.updateItem(supplier);
        }

        internal void deleteSupplier(int bid)
        {
            supplierDAL.deleteItem(bid);
        }


        internal int addSupplierInventory(SupplierInventory si)
        {
            return siDAL.addItem(si);
        }

        internal void updateSupplierInventory(SupplierInventory si)
        {
            siDAL.updateItem(si);
        }

        internal void deleteSupplierInventory(int bid)
        {
            siDAL.deleteItem(bid);
        }
        #endregion

        // CRUD Stock
        #region stock

        //
        internal void updateStock(Inventory inventory)
        {
            // whether the pass stock quantity=0
            bool emptyCheck = db.Inventories.Any(x => x.StockID == inventory.StockID && x.RestockQuantity == 0);
            stockDAL.updateItem(inventory);
            /* if quantity=0, find related menu. 
            if all the stock item for the menu is not 0, enable the menu status*/
            if (emptyCheck)
            {
                // get the menu effected by the stock
                List<int> relatedMenuID = findRelatedMenu(inventory.StockID);
                if (relatedMenuID.Count == 0)
                {
                    return;
                }
                foreach (var menuID in relatedMenuID)
                {
                    // find the menu's items to check their quantity
                    List<int> stocks = orderBLL.getStockItemsForMenu(menuID);
                    foreach (var stock in stocks)
                    {
                        bool quantityCheck = db.Inventories.Any(x =>
                        x.StockID == stock && x.RestockQuantity == 0);
                        if (quantityCheck)
                        {
                            return;
                        }
                    }
                    changeMenuStatus(menuID);
                }
            }

        }

        private void changeMenuStatus(int menuID)
        {
            Menu menu = menuDAL.getItem(menuID);
            menu.OrderStatus = true;
            menuDAL.updateItem(menu);
        }

        private List<int> findRelatedMenu(int stockID)
        {
            var stockList = from l in db.MenuItems
                            where l.ItemID == stockID
                            select l.MenuID;
            return stockList.ToList();
        }

        internal object getInventoryListByID(int id)
        {
            var stockList = from l in db.Inventories
                            where l.StockID == id
                            select new
                            {
                                StockID = l.StockID,
                                StockName = l.StockName,
                                RestockQuantity = l.RestockQuantity,
                                ConductTime = l.ConductTime,
                                EmployeeID = l.EmployeeID,
                                MaximumQuantity = l.MaxQuantity
                            };
            return stockList.Distinct();
        }

        internal object getInventoryList()
        {
            var stockList = from l in db.Inventories
                            select new
                            {
                                StockID = l.StockID,
                                StockName = l.StockName,
                                RestockQuantity = l.RestockQuantity,
                                ConductTime = l.ConductTime,
                                EmployeeID = l.EmployeeID,
                                MaximumQuantity=l.MaxQuantity
                            };
            return stockList.Distinct();
        }

        internal object getInventoryRestoreList()
        {
            var stockList = from l in db.Inventories
                            select new
                            {
                                StockID = l.StockID,
                                RestockQuantity = l.MaxQuantity - l.RestockQuantity
                            };
            return stockList.Distinct();
        }

        internal int addStock(Inventory inventory)
        {
            return stockDAL.addItem(inventory);
        }

        internal void deleteStock(int bid)
        {
            stockDAL.deleteItem(bid);
        }


        internal List<string> getEmptyStock()
        {
            var stockList = from l in db.Inventories
                            where l.RestockQuantity == 0
                            select l.StockName;
            return stockList.ToList();
        }

        internal List<string> getEmptyStock(int id)
        {
            var stockList = from l in db.Inventories
                            where l.StockID == id && (l.RestockQuantity == 0)
                            select l.StockName;
            return stockList.ToList();
        }

        #endregion

        //report
        internal object getMenuByCategory(string category)
        {
            var menuList = from l in db.Menus
                            where l.Type == category
                            select new
                            {
                                MenuID = l.MenuID,
                                Name = l.Name,
                                Price = l.Price,
                                OrderStatus = l.OrderStatus,
                                Type=l.Type
                            };
            return menuList.Distinct();

        }

        internal object getStockByName(string name)
        {
            string pattern1 = "%" + name + "%";
            var InventoryList = from l in db.Inventories
                               where SqlMethods.Like(l.StockName, pattern1)
                               select new
                               {
                                   StockID = l.StockID,
                                   StockName = l.StockName,
                                   RestockQuantity = l.RestockQuantity,
                                   ConductTime = l.ConductTime,
                                   EmployeeID = l.EmployeeID
                               };
            return InventoryList.Distinct();
        }

        internal object getSalesByTime(DateTime invoiceTime)
        {
            var invoiceList = from l in db.Invoices
                           where l.Time <= invoiceTime
                           select new
                           {
                               InvoiceID = l.InvoiceID,
                               OrderID = l.OrderID,
                               TotalPrice = l.TotalPrice,
                               Time = l.Time
                           };
            return invoiceList.Distinct();
        }

        internal object getPayrollsByTime(DateTime payrollTime)
        {
            var payrollList = from l in db.Payrolls
                              where l.PaymentEnd <= payrollTime
                              select new
                              {
                                  SalaryID = l.SalaryID,
                                  EmployeeID = l.EmployeeID,
                                  TotalSalary = l.TotalSalary,
                                  Tax = l.Tax
                              };
            return payrollList.Distinct();
        }
    }
}