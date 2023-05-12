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

        public int GetProductIdByName(string name)
        {
             int id = 0; 
             using (QuanLyNetDataContext db = new QuanLyNetDataContext())
            {
                id = (int) db.Products.Where(p => p.Name == name).FirstOrDefault().ID_Product;
            }

            return id;
        }
        public Product GetProduct(int id)
        {
            QuanLyNetDataContext db = new QuanLyNetDataContext();
            Product product = new Product();

                product = db.Products.Where(p => p.ID_Product == id).FirstOrDefault();
                return product;
        }
        public int GetIdPrice(int IPrice,int Eprice)
        {
            int id = 0;
            using (QuanLyNetDataContext db =new QuanLyNetDataContext())
            {
                 var query = db.Products.Where(p => p.Price.ImPrice == IPrice && p.Price.ExPrice == Eprice).FirstOrDefault();
                id = (int)query.ID_Price;
            }
            return id; 

        }

        public void addProduct(Product product )
        {
             using (QuanLyNetDataContext db = new QuanLyNetDataContext())
            {
                db.Products.InsertOnSubmit(product);
                db.SubmitChanges();
            }
        }

        public void UpdateSanPham(params string[] infor)
        {
             using(QuanLyNetDataContext db = new QuanLyNetDataContext())
            {
                Product product = db.Products.Where(p => p.ID_Product == Convert.ToInt32(infor[0])).FirstOrDefault();
                product.Name = infor[1];
                product.Quantity =Convert.ToInt32(infor[2]);
                product.ID_Price = Convert.ToInt32(infor[3]);
                //product.Path = infor[4];
                db.SubmitChanges();
            }
        }

        public void DeleteProduct(int Id)
        {
             using(QuanLyNetDataContext db =new QuanLyNetDataContext())
            {
                Product product = db.Products.Where(p => p.ID_Product == Id ).FirstOrDefault();
                db.Products.DeleteOnSubmit(product);
                db.SubmitChanges();
            }
        }
     
        public IQueryable SearchProduct(string name )
        {
            QuanLyNetDataContext db = new QuanLyNetDataContext();
                var query = db.Products.
                    Where(p => p.Name.Contains(name)).
                    Select(p => new
                    {
                        //p.pics,
                        p.Name,
                        p.Quantity,
                        p.Price.ImPrice,
                        p.Price.ExPrice
                    });

                return query;
        }


    }
}
