using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace THA_W5_Cevin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public List<string> listproduct = new List<string>();
        public List<string> listcategory = new List<string>();
        private void Form1_Load(object sender, EventArgs e)
        {
            this.cbFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            produkset();
            categoryset();
        }

        public void prodcol()
        {
            DataTable dt = new DataTable();
            dt.Columns.Clear();
            dt.Columns.Add("ID Product");
            dt.Columns.Add("Nama Produk");
            dt.Columns.Add("Harga");
            dt.Columns.Add("Stock");
            dt.Columns.Add("ID Category");
            this.dgProduct.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;

            string[] splitted;
            foreach (string add in listproduct)
            {
                splitted = add.Split('+');
                dt.Rows.Add(splitted[0], splitted[1], splitted[2], splitted[3], splitted[4]);
            }
            dgProduct.DataSource = dt;
        }

        public void prodcolfilter()
        {
            DataTable dt = new DataTable();
            dt.Columns.Clear();
            dt.Columns.Add("ID Product");
            dt.Columns.Add("Nama Produk");
            dt.Columns.Add("Harga");
            dt.Columns.Add("Stock");
            dt.Columns.Add("ID Category");
            this.dgProduct.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;


            string[] splitted;
            if (cbFilter.Text != null)
            {
                foreach (string add in listproduct)
                {
                    splitted = add.Split('+');
                    if (splitted[1].Contains(cbFilter.Text))
                    {
                        dt.Rows.Add(splitted[0], splitted[1], splitted[2], splitted[3], splitted[4]);
                    }
                }
                dgProduct.DataSource = dt;
            }
        }
        public void catcol()
        {
            DataTable dt = new DataTable();
            dt.Columns.Clear();
            dt.Columns.Clear();
            dt.Columns.Add("ID Category");
            dt.Columns.Add("Nama Kategori");
            this.dgCategory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;

            string[] splitted;
            foreach (string add in listcategory)
            {
                splitted = add.Split('+');
                dt.Rows.Add(splitted[0], splitted[1]);
            }
            dgCategory.DataSource = dt;
        }

        public void produkset()
        {
            string ketprod;

            ketprod = "J001+Jas Hitam+100000+10+C1";

            listproduct.Add(ketprod);

            ketprod = "T001+T-Shirt Black Pink+70000+20+C2";

            listproduct.Add(ketprod);

            ketprod = "T002+T-Shirt Obsessive+75000+16+C2";

            listproduct.Add(ketprod);

            ketprod = "R001+Rok mini+82000+26+C3";

            listproduct.Add(ketprod);

            ketprod = "J002+Jeans Biru+90000+5+C4";

            listproduct.Add(ketprod);

            ketprod = "C001+Celana Pendek Coklat+60000+11+C4";

            listproduct.Add(ketprod);

            ketprod = "C002+Cawat Blink-blink+1000000+1+C5";

            listproduct.Add(ketprod);

            ketprod = "R002+Rocca Shirt+50000+8+C2";

            listproduct.Add(ketprod);

            prodcol();
        }

        public void categoryset()
        {
            string set;

            set = "C1+Jas";

            listcategory.Add(set);

            set = "C2+T-Shirt";

            listcategory.Add(set);

            set = "C3+Rok";

            listcategory.Add(set);

            set = "C4+Celana";

            listcategory.Add(set);

            set = "C5+Cawat";

            listcategory.Add(set);


            catcol();
        }

        public void filterset()
        {
            string[] splitted;
            foreach (string add in listcategory)
            {
                splitted = add.Split('+');
                cbFilter.Items.Add(splitted[1]);
            }
        }

        private void btAll_Click(object sender, EventArgs e)
        {
            prodcol();
        }

        private void btFilter_Click(object sender, EventArgs e)
        {
            cbFilter.Enabled = true;
            cbFilter.Items.Clear();
            filterset();
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilter.Text != "")
            {
                prodcolfilter();
            }
        }
    }
}
