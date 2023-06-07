using PBL3_LastReal.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3_LastReal.BLL
{
    public class ManageOrder
    {
        private static ManageOrder instance;
        private ManageOrder() { }
        public static ManageOrder Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ManageOrder();
                }
                return instance;
            }
            private set { }
        }
        public List<OrderService> getAllOrder()
        {
            List<OrderService> list = new List<OrderService>();
            using (QL_QuanNetEntities db = new QL_QuanNetEntities())
            {
                list = db.OrderServices.ToList();
            }
            return list;
        }
        public OrderService GetOrder(int id_com, DateTime timeOrder) 
        {
            OrderService ord = new OrderService();
            using (QL_QuanNetEntities db = new QL_QuanNetEntities())
            {
                foreach (var item in db.OrderServices)
                {
                    if (item.ID_Computer == id_com && item.OrderTime.ToString() == timeOrder.ToString())
                    {
                        ord = item;
                        break;
                    }
                }
            }
            return ord;
        }
        public OrderService GetOrder(int id_ord)
        {
            OrderService ord = new OrderService();
            using (QL_QuanNetEntities db = new QL_QuanNetEntities())
            {
                ord = db.OrderServices.Where(p => p.ID_Order == id_ord).First();
            }
            return ord;
        }
        public List<DetailOrder> getDetailOrder(int id_ord)
        {
            QL_QuanNetEntities db = new QL_QuanNetEntities();
            List<DetailOrder> list = new List<DetailOrder>();
            list = db.DetailOrders.Where(p => p.ID_Order == id_ord).ToList();
            return list;
        }
        public void addOrder(OrderService order)
        {
            using (QL_QuanNetEntities db = new QL_QuanNetEntities())
            {
                db.OrderServices.Add(order);
                db.SaveChanges();
            }
        }
        public void removeOrder(OrderService order) 
        {
            using (QL_QuanNetEntities db = new QL_QuanNetEntities())
            {
                OrderService ord = db.OrderServices.Where(p => p.ID_Order == order.ID_Order).First();
                db.OrderServices.Remove(ord);
                db.SaveChanges();
            }
        }
       
        public void addDetailOrder(DetailOrder detail)
        {
            using (QL_QuanNetEntities db = new QL_QuanNetEntities())
            {
                db.DetailOrders.Add(detail);
                db.SaveChanges();
            }
        }
        public void removeDetailOrder(DetailOrder detail)
        {
            using (QL_QuanNetEntities db = new QL_QuanNetEntities())
            {
                DetailOrder dOrder = db.DetailOrders.Where(p => p.ID_DetailOrder == detail.ID_DetailOrder).First();
                db.DetailOrders.Remove(dOrder);
                db.SaveChanges();
            }
        }
    }
}
