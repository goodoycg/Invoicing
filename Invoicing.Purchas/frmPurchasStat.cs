using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Invoicing.Purchas
{
    public partial class frmPurchasStat : Form
    {
        public frmPurchasStat()
        {
            InitializeComponent();
            //
            //
        }

        private void frmPurchasStat_Load(object sender, EventArgs e)
        {
            //设置图表的数据源
            string s1 = "SELECT typename as 商品类别,sum(incount*inprice) as 金额 from Purchas,goodstype where purchas.typeno=goodstype.typeno group by goodstype.typename";
            chart1.DataSource = Invoicing.Common.Foundation.ReadDataSet(s1).Tables[0];
            //设置图表Y轴对应项
            chart1.Series[0].YValueMembers = "金额";
            //设置图表X轴对应项
            chart1.Series[0].XValueMember = "商品类别";


            //设置图表的数据源
            string s2 = "SELECT t as 进货年月 ,sum(incount*inprice) as 金额 from (select incount,inprice,cstr(year(cdate(intime)))+'-'+cstr(month(cdate(intime))) as t from Purchas) group by t";
            chart2.DataSource = Invoicing.Common.Foundation.ReadDataSet(s2).Tables[0];
            //设置图表Y轴对应项
            chart2.Series[0].YValueMembers = "金额";
            //设置图表X轴对应项
            chart2.Series[0].XValueMember = "进货年月";

        //    //90%是y轴数据的话：
        //for (int i = 0; i < Chart1.Series[0].Points.Count; i++)
        //{
        //    if (Convert.ToDouble(Chart1.Series[0].Points[i].YValues[0]) > 0.90)
        //    {
        //        Chart1.Series[0].Points[i].Color = System.Drawing.Color.Red;
        //    }
        //}


        }
    }
}
