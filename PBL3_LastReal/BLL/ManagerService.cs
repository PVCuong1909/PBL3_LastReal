using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PBL3_LastReal.BLL
{
    public class ManageService
    {
        private static ManageService instance;
        private ManageService() { }
        public static ManageService Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ManageService();
                }
                return instance;
            }
            private set { }
        }

        public void UpdateDB(string name, int quantityNeeded)
        {
            using (QuanLyNetDataContext db = new QuanLyNetDataContext())
            {
                Product pro = db.Products.Where(p => p.Name == name).First();
                pro.Quantity -= quantityNeeded;
                db.SubmitChanges();
                if(pro.Quantity == 0)
                {
                    db.Products.DeleteOnSubmit(pro);
                }
                db.SubmitChanges();
            }
        }

        public int getQuantity(string name) 
        {
            int count = 0;
            using (QuanLyNetDataContext db = new QuanLyNetDataContext())
            {
                count = (int)db.Products.Where(p => p.Name == name).First().Quantity;
            }
            return count;
        }

        public List<Product> GetProducts(string name) 
        {
            List<Product> products = new List<Product>();
            using (QuanLyNetDataContext db = new QuanLyNetDataContext())
            {
                products = db.Products.Where(p => p.Name.Contains(name)).ToList();
            }
            return products;
        }

        //public void UpdateSelectState(QuanLyNetDataContext db, Action<QuanLyNetDataContext> InitDGV, int pos)
        //{

        //    //var q1 = db.Products.Where(p => p.ID_Product == pos + 1).FirstOrDefault();
        //    //q1.SLDaDat++;

        //    //if (q1.Chose == false)
        //    //{
        //    //    q1.Chose = true;
        //    //    db.SubmitChanges();
        //    //    //InitDGV(db);
        //    //}

        //    //else
        //    //{

        //    //    q1.Chose = false;
        //    //    db.SubmitChanges();
        //    //    //InitDGV(db);
        //    //}
        //}
        //public void RemoveSelectState(QuanLyNetDataContext db, int index)
        //{
        //    //var query = db.Products.Where(p => p.ID_Product == index + 1).FirstOrDefault();
        //    //if (query.Chose == true)
        //    //{
        //    //    query.SLDaDat = 0;
        //    //    query.Chose = false;
        //    //    db.SubmitChanges();
        //    //}
        //}
        ////public IQueryable UpdateSelectedItem(QuanLyNetDataContext db, int index)
        ////{
        //////    var query2 = db.Products.Where(p => p.ID_Product == index + 1).FirstOrDefault();
        //////    db.SubmitChanges();
        //////    var query = db.Products.Where(p => p.Chose == true).Select(p => new { p.SLDaDat, p.pics, p.Name, p.price });
        //////    return query;
        ////}


        //public void Reset()
        //{
        //    //QuanLyNetDataContext db = new QuanLyNetDataContext();
        //    //var query = db.Products.Where(p => p.Chose == true).ToList();
        //    //for (int j = 0; j < query.Count; j++)
        //    //{
        //    //    query[j].SLDaDat = 0;
        //    //    db.SubmitChanges();
        //    //}
        //    //foreach (Product i in db.Products)
        //    //{
        //    //    if (i.Chose == true)
        //    //    {
        //    //        i.Chose = false;

        //    //        db.SubmitChanges();
        //    //    }
        //    //}

        //}
        //public void UpdateItemQuantity(QuanLyNetDataContext db)
        //{
        //    //var query = db.Products.Where(p => p.Chose == true).ToList();
        //    //for (int i = 0; i < query.Count; i++)
        //    //{
        //    //    query[i].Quantity -= query[i].SLDaDat;
        //    //}
        //    //db.SubmitChanges();

        //}
      


    }
}
