using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ORMS.DAL;
// observer
namespace ORMS.BLL
{
    class OrderBLL
    {
        ORMSDBDataContext db = new ORMSDBDataContext();
        //RecordBLL ctr = new RecordBLL();
        MenuDAL menuDAL = new MenuDAL();

        // check the stock if customer can order the quantity
        internal bool checkStocksForAMenu(int quantity, int menuID)
        {
            List<int> stockItemsID = getStockItemsForMenu(menuID);
            
            foreach (var item in stockItemsID)
            {
                int stockQuan = getStockQuantityByID(item);
                if (stockQuan < quantity)
                {
                    return false;
                }
            }
            return true;
        }

        // combine order, menu and inventory
        // get all stock items ID for the menu
        internal List<int> getStockItemsForMenu(int menuID)
        {
            var stocksList = from l in db.MenuItems
                             where l.MenuID == menuID
                             select l.ItemID;
            return stocksList.ToList();
        }

        // get quantity for a stock item
        internal int getStockQuantityByID(int id)
        {
            return db.Inventories.First(b => b.StockID == id).RestockQuantity;
        }

        // change the order status to disable for the menu items related to specific stock
        private void disableOrderStatus(int stockID)
        {
            var menuIDList = from l in db.MenuItems
                             where l.ItemID == stockID
                             select l.MenuID;
            // use iterator
            foreach (var item in menuIDList)
            {
                Menu menu = menuDAL.getItem(item);
                menu.OrderStatus = false;
                menuDAL.updateItem(menu);
            }
        }

        // observer pattern
        // update status by observer
        public void ReceiveAndNotify(object obj)
        {
            StockBLL sbp = obj as StockBLL;
            if (sbp != null)
            {
                disableOrderStatus(sbp.StockID);
            }
        }
    }
}
