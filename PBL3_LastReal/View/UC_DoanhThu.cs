using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using PBL3_LastReal.BLL;
using PBL3_LastReal.DTO;
namespace PBL3_LastReal
{
    public partial class UC_DoanhThu : UserControl
    {
        List<DataPoint> points = new List<DataPoint>();
        List<DataPoint> points2 = new List<DataPoint>();
        List<DataPoint> points3 = new List<DataPoint>();

        List<int> HourDV = new List<int>();
        List<int> HourMay = new List<int>();
        public UC_DoanhThu()
        {
            InitializeComponent();
            newGUI(DateTime.Now.ToString("yyyy-MM-dd"));
            GUI3();
         
        }
 


       
        //public void GUI2()
        //{
          
        //    //ManageProfit.Instance.EndDay2();
        //    QuanLyNetDataContext db = new QuanLyNetDataContext();

        //    var query2 = db.Bills.Where(p => p.Type == 1).ToList();
        //    chart1.Series["TienMay"].Points.AddXY(0, 0);
        //    for (int i = 1; i <= query2.Count; i++)
        //    {
        //        chart1.Series["TienMay"].Points.AddXY(i, query2[i-1].Money);

        //    }

        //}

        //public void GUI()
        //{
        //    QuanLyNetDataContext db = new QuanLyNetDataContext();
        //    var query = db.Bills.Where(p => p.Type == 0 ).ToList();
        //    int count = 0;
        //    chart1.Series["DichVu"].Points.AddXY(0, 0);

        //    for (int i = 0; i < query.Count; i++)
        //    {

        //        if (ManageProfit.Instance.check((DateTime)query[i].Date) == true )
        //        {

        //            //ManageProfit.Instance.EndDay();
        //            count++;
        //            //chart1.Series["DichVu"].Points.AddXY(((DateTime)query[i].Date).ToString("HH:mm:ss"), query[i].Money);
        //            chart1.Series["DichVu"].Points.AddXY(count, query[i].Money);

        //            //if(ManageProfit.Instance.check((DateTime)query2[pos].Date) == true)
        //            //{
        //            //    query2[pos].DichVu += query[i].Money;
        //            //    db.SubmitChanges();
        //            //}
        //            //else
        //            //{
        //            //    pos++; 
        //            //}
        //            //query2[count - 1].DichVu += query[i].Money;
        //        }

        //    }

        //}
     

        public void  newGUI(string date)

        {
            DateTime loadedDate = DateTime.ParseExact(date, "yyyy-MM-dd", null);
            QuanLyNetDataContext db = new QuanLyNetDataContext();
            for (int i =0;i<=11;i++)
            {
                HourDV.Add(0);
                HourMay.Add(0);
            }
          
            DateTime dm = DateTime.Now.Date;
            var query = db.Bills.Where(p => p.Date <= loadedDate.Date.AddDays(1) && p.Date >= loadedDate.Date).ToList();
            int pos = 0;
            for(int i = 0; i<=22;i+=2)
            {
                var querybill = query.Where(p => p.Date.Value.CompareTo(loadedDate.Date.AddHours(i)) >= 0 && p.Date.Value.CompareTo(loadedDate.Date.AddHours(i + 2)) <= 0).ToList();
                foreach (var item in querybill)
                {
                    if (item.Type == 0)
                    {
                        HourDV[pos] += (int)item.Money;
                    }
                    else if (item.Type == 1)
                    {
                        HourMay[pos] += (int)item.Money;
                    }
                }
                pos++;
           

            }
     
            int count2 = 0;
         
            
            for (int i = 0; i <= 24; i+=2 )
            {
                if(i == 0)
                {
                    chart1.Series["DichVu"].Points.AddXY(0, 0);
                    chart1.Series["TienMay"].Points.AddXY(0, 0);
                }
             
                else
                {
                    chart1.Series["DichVu"].Points.AddXY(i, HourDV[count2]);
                    chart1.Series["TienMay"].Points.AddXY(i, HourMay[count2]);
                    count2++;
                }
       
            }
       


        }
        void setValues(String month)
        {
           
            QuanLyNetDataContext db = new QuanLyNetDataContext();
            int monthNumber = DateTime.ParseExact(month, "MMMM", CultureInfo.CurrentCulture).Month; 

            points = new List<DataPoint>();
            points2 = new List<DataPoint>();
            points3 = new List<DataPoint>();
          
            DateTime dm = new DateTime(DateTime.Now.Year, monthNumber, 1);
      
            int count = 0;
            var query = db.Bill_Thangs.Where(p => p.Date >= dm).ToList();
         
             
                for (int i = 0; i < DateTime.DaysInMonth(DateTime.Now.Year, monthNumber); i++)
                {

                    if (dm.AddDays(i).ToString("MM:dd") == (Convert.ToDateTime(query[count].Date).ToString("MM:dd")))
                    {
                        points.Add(new DataPoint(dm.AddDays(i).ToOADate(), (double)query[count].DichVu));
                        points2.Add(new DataPoint(dm.AddDays(i).ToOADate(), (double)query[count].TienMay));
                        points3.Add(new DataPoint(dm.AddDays(i).ToOADate(), (double)query[count].LuongNhanVien));
                        count++;
                        if (count == query.Count)
                        {
                            count--;
                        }
                    }
                    else
                    {
                        points.Add(new DataPoint(dm.AddDays(i).ToOADate(), 0));
                        points2.Add(new DataPoint(dm.AddDays(i).ToOADate(), 0));
                        points3.Add(new DataPoint(dm.AddDays(i).ToOADate(), 0));
                    }

                }
        }
        public void GUI3()
        {
            Chart chart = chart2;
            Series s = chart.Series[0];
            Series s2 = chart.Series[1];
            Series s3 = chart.Series[2];

            s.ChartType = SeriesChartType.Line;
            s.XValueType = ChartValueType.DateTime;
            s.YValueType = ChartValueType.Double;

            s2.ChartType = SeriesChartType.Line;
            s2.XValueType = ChartValueType.DateTime;
            s2.YValueType = ChartValueType.Double;

            s3.ChartType = SeriesChartType.Line;
            s3.XValueType = ChartValueType.DateTime;
            s3.YValueType = ChartValueType.Double;
            if (cbb.SelectedItem == null)
            {
                //foreach(var item in cbb.Items)
                //{
                //     if(item.ToString() == DateTime.Now.ToString("MMMM"))
                //    {

                //    }
                //}
                cbb.SelectedIndex = 0;
                setValues(cbb.SelectedItem.ToString());
            }
            else
            {
                setValues(cbb.SelectedItem.ToString());
            }

            Axis ax = chart.ChartAreas[0].AxisX;
            Axis ay = chart.ChartAreas[0].AxisY;
            ax.Interval = 1;
     
            ax.IntervalType = DateTimeIntervalType.Days;
            ax.LabelStyle.Format = "dd";

            //s.Points.Clear();
            foreach (var dp in points) s.Points.Add(dp);
            foreach (var dp in points2) s2.Points.Add(dp);
            foreach (var dp in points3) s3.Points.Add(dp);
       
            ax.Minimum = points.Min(x => x.XValue);
            ax.Maximum = points.Max(x => x.XValue);


        }

   

        private void btn_TongKet_Click_1(object sender, EventArgs e)
        {
            //ManageProfit.Instance.EndDay();

            //using (QuanLyNetDataContext db = new QuanLyNetDataContext())
            //{
            //    var query = db.Bill_Thangs.Where(p => p.Id_Bill2 > 0).ToList();

            //    for (int i = 0; i < query.Count; i++)
            //    {

            //            MessageBox.Show(((DateTime)query[i].Date).ToString("MMMM"));
            //        MessageBox.Show(cbb.SelectedItem.ToString());
            //    }
            //}
            //var query = db.Bill_Thangs.Where(p => p.Id_Bill2 > 0).ToList();


            //for (int i = 0; i < query.Count; i++)
            //{
            //    MessageBox.Show(((DateTime)query[i].Date).ToString("yyyy-MM-dd").ToString());

            //}
            //var Bill_Thang = db.Bill_Thangs.Where(p => p.Date <= DateTime.Now).ToList();

            //MessageBox.Show(Bill_Thang[0].Date.ToString());

            //var Bill_Thang = db.Bill_Thangs.Where(p => p.Date >= DateTime.Today.AddDays(1)).ToList();

            //MessageBox.Show(Bill_Thang.Count.ToString());

            //var Bill_Thang = db.Bill_Thangs.Where(p => p.Id_Bill2 > 0).ToList();

            //if (Bill_Thang[Bill_Thang.Count - 1].Date < DateTime.Now)
            //{
            //    MessageBox.Show("true");
            //}

            //MessageBox.Show(DateTime.Now.ToString());

            //QuanLyNetDataContext db = new QuanLyNetDataContext();
            //string first = cbb.SelectedItem.ToString();
            ////var query = db.Bill_Thangs.Where(p => ((DateTime)p.Date).ToString("MMMM") == cbb.SelectedItem.ToString()).ToList();
            //var query = db.Bill_Thangs.Where(p => string.Format("MMMM", ((DateTime)p.Date)) == first).ToList();
            //MessageBox.Show(query.Count.ToString());

            MessageBox.Show(HourMay.Count.ToString());

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (QuanLyNetDataContext db = new QuanLyNetDataContext())
            {
                var query = db.Bill_Thangs.Where(p => p.Id_Bill2 > 0).ToList();

                for(int i = 0; i < query.Count;i++)
                {
                    if (ManageProfit.Instance.checkMonth((DateTime)query[i].Date, cbb.SelectedItem.ToString() ) == true  )
                    {
                        setValues(cbb.SelectedItem.ToString());
                        GUI3();
                    }
                }
            }
        }

        private void chart2_Click(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            MessageBox.Show(dateTimePicker1.Value.ToString("yyyy-MM-dd"));
            foreach (var series in chart1.Series)
            {
                series.Points.Clear();
            }
            for (int i = 0; i <= 11; i++)
            {
                HourDV[i] = 0;
                HourMay[i] = 0;
            }
            newGUI(dateTimePicker1.Value.ToString("yyyy-MM-dd"));
        }
    }
}
