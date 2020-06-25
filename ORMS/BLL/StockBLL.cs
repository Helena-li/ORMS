using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ORMS.DAL;

// subject in observer pattern
namespace ORMS.BLL
{
    // use delegate as the IObservers
    // claim
    public delegate void NotifyEventDelegate(object sender);
    //observer -- publisher
    public class StockBLL
    {
        //create event
        public event NotifyEventDelegate NotifyEventHandler;
        // manage the subscribers list
        public int StockID { get; set; }
        public StockBLL(int id)
        {
            this.StockID = id;
        }
        // maintain the observers list
        public void AddObserver(NotifyEventDelegate ob)
        {
            NotifyEventHandler += ob;
        }
        public void RemoveObserver(NotifyEventDelegate ob)
        {
            NotifyEventHandler -= ob;
        }

        // notify
        public void Update()
        {
            if (NotifyEventHandler!=null)
            {
                NotifyEventHandler(this);
            }
        }
        ////RecordBLL ctr = new RecordBLL();
        ////StockDAL stockDAL = new StockDAL();
        ////internal void reduceStock(OrderItem orderItem)
        ////{
        ////    var itemsID = ctr.getStockItemsForMenu(orderItem.MenuID);
        ////    var quan = orderItem.Quantity;
        ////    foreach (var stockItem in itemsID)
        ////    {
        ////        Inventory inventory = stockDAL.getItem(stockItem);
        ////        inventory.RestockQuantity -= quan;
        ////        stockDAL.updateItem(inventory);
        ////        if (inventory.RestockQuantity == 0)
        ////        {
        ////            // raise or fire the event 
        ////            NotifyEventHandler(inventory.StockID);
        ////            //    disableOrderStatus(inventory.StockID);
        ////            //    List<string> lackStocks= notifyStockMange(inventory.StockID);
        ////        }
        ////    }
    }
    // might delete under codes
    //public class StockBLLPublisher:StockBLL
    //{
    //    public StockBLLPublisher(int id):base(id)
    //    {
    //    }
    //}

    //ORMSDBDataContext db = new ORMSDBDataContext();
    //OrderBLL orderBLL = new OrderBLL();
    //
    //MenuDAL menuDAL = new MenuDAL();

    //public List<string> lackStocks;
    ////sigleton 显示 增加 减少 缺失的stock

    //public void addOrder(OrderItem orderItem)
    //{
    //    bool addResult = addOrderItem(orderItem);
    //    if (addResult)
    //    {
    //        //orderDateGridView(orderID);
    //    }

    //}
    //internal bool addOrderItem(OrderItem orderItem)
    //{
    //    bool checkResult = checkStocksForAMenu(orderItem.Quantity, orderItem.MenuID);
    //    if (checkResult)
    //    {
    //        OrderItemDAL oiDAL = new OrderItemDAL();
    //        oiDAL.addItem(orderItem);
    //        reduceStock(orderItem);
    //        return true;
    //    }
    //    else return false;
    //}
    //internal bool checkStocksForAMenu(int quantity, int menuID)
    //{
    //    List<int> stockItemsID = getStockItemsForMenu(menuID);

    //    foreach (var item in stockItemsID)
    //    {
    //        int stockQuan = getStockQuantityByID(item);
    //        if (stockQuan < quantity)
    //        {
    //            return false;
    //        }
    //    }
    //    return true;
    //}
    //internal List<int> getStockItemsForMenu(int menuID)
    //{
    //    var stocksList = from l in db.MenuItems
    //                     where l.MenuID == menuID
    //                     select l.ItemID;
    //    return stocksList.ToList();
    //}

    //internal int getStockQuantityByID(int id)
    //{
    //    return db.Inventories.First(b => b.StockID == id).RestockQuantity;
    //}
    //internal void reduceStock(OrderItem orderItem)
    //{
    //    var itemsID = getStockItemsForMenu(orderItem.MenuID);
    //    var quan = orderItem.Quantity;
    //    foreach (var stockItem in itemsID)
    //    {
    //        Inventory inventory = stockDAL.getItem(stockItem);
    //        inventory.RestockQuantity -= quan;
    //        stockDAL.updateItem(inventory);
    //        if (inventory.RestockQuantity == 0)
    //        {
    //            //observer 2
    //            disableOrderStatus(inventory.StockID);
    //            //observer 1
    //            loadMessage();
    //        }
    //    }
    //}


    ////observer 2
    //private void disableOrderStatus(int stockID)
    //{
    //    var menuIDList = from l in db.MenuItems
    //                     where l.ItemID == stockID
    //                     select l.MenuID;
    //    foreach (var item in menuIDList)
    //    {
    //        Menu menu = menuDAL.getItem(item);
    //        menu.OrderStatus = false;
    //        menuDAL.updateItem(menu);
    //    }
    //}
    ////observer 1
    ////label of menu
    ////public void printNotify()
    ////{
    ////    if (lackStocks.Count>0)
    ////    {
    ////        string a = null;
    ////        foreach (var item in lackStocks)
    ////        {
    ////            a = a + item + " ";
    ////        }
    ////        //label.text=a;
    ////    }
    ////}

    //private void loadMessage()
    //{
    //    var stockList = from l in db.Inventories
    //                    where l.RestockQuantity == 0
    //                    select l.StockName;
    //    List<string> a = stockList.ToList();

    //    if (a.Count>0)
    //    {
    //        // inventory load的时候先messagebox
    //    }
    //}
}



