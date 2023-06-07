using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBL3_LastReal.DTO;


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
            using (QL_QuanNetEntities db = new QL_QuanNetEntities())
            {
                Product pro = db.Products.Where(p => p.Name == name).First();
                pro.Quantity -= quantityNeeded;
                db.SaveChanges();
                if(pro.Quantity == 0)
                {
                    db.Products.Remove(pro);
                }
                db.SaveChanges();
            }
        }

        public int getQuantity(string name) 
        {
            int count = 0;
            using (QL_QuanNetEntities db = new QL_QuanNetEntities())
            {
                count = (int)db.Products.Where(p => p.Name == name).First().Quantity;
            }
            return count;
        }

        public List<Product> GetProducts(string name) 
        {
            List<Product> products = new List<Product>();
            using (QL_QuanNetEntities db = new QL_QuanNetEntities())
            {
                products = db.Products.Where(p => p.Name.Contains(name)).ToList();
            }
            return products;
        }

        public int GetProductIdByName(string name)
        {
             int id = 0; 
             using (QL_QuanNetEntities db = new QL_QuanNetEntities())
            {
                id = (int) db.Products.Where(p => p.Name == name).FirstOrDefault().ID_Product;
            }

            return id;
        }
        public Product GetProduct(int id)
        {
            QL_QuanNetEntities db = new QL_QuanNetEntities();
            Product product = new Product();
            product = db.Products.Where(p => p.ID_Product == id).FirstOrDefault();
            return product;
        }
        public Product GetProduct(string name)
        {
            QL_QuanNetEntities db = new QL_QuanNetEntities();
            Product product = new Product();
            product = db.Products.Where(p => p.Name == name).FirstOrDefault();
            return product;
        }
        public int GetIdPrice(int IPrice,int Eprice)
        {
            int id = 0;
            using (QL_QuanNetEntities db = new QL_QuanNetEntities())
            {
                 var query = db.Products.Where(p => p.Price.ImPrice == IPrice && p.Price.ExPrice == Eprice).FirstOrDefault();
                id = (int)query.ID_Price;
            }
            return id; 

        }

        public void addProduct(Product product)
        {
            using (QL_QuanNetEntities db = new QL_QuanNetEntities())
            {
                db.Products.Add(product);
                db.SaveChanges();
            }
        }

        public void UpdateSanPham(params string[] infor)
        {
            int inf = Convert.ToInt32(infor[0]);
             using (QL_QuanNetEntities db = new QL_QuanNetEntities())
            {
                Product product = db.Products.Where(p => p.ID_Product == inf).FirstOrDefault();
                product.Name = infor[1];
                product.Quantity =Convert.ToInt32(infor[2]);
                product.ID_Price = Convert.ToInt32(infor[3]);
                //product.Path = infor[4];
                db.SaveChanges();
            }
        }

        public void DeleteProduct(int Id)
        {
             using(QL_QuanNetEntities db = new QL_QuanNetEntities())
            {
                Product product = db.Products.Where(p => p.ID_Product == Id ).FirstOrDefault();
                db.Products.Remove(product);
                db.SaveChanges();
            }
        }
     
        public List<Product> SearchProduct(string name )
        {
            List<Product> pro = new List<Product>();
            QL_QuanNetEntities db = new QL_QuanNetEntities();
                pro= db.Products.
                    Where(p => p.Name.Contains(name)).ToList();
                return pro;
        }
    }
}
