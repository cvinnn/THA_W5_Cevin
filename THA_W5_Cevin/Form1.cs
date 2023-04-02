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
            filterset();
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
                cbCategory.Items.Add(splitted[1]);
            }
        }

        public string codegetter()
        {
            char codename;
            int codelast = 0;
            string codeorder;
            string finalcode = "";
            string[] codelist;
            List<string> codelistorder = new List<string>();
            codename = txtNamaProd.Text.ToUpper().ToCharArray()[0];

            foreach (string code in listproduct)
            {
                codelist = code.Split('+');
                if (codelist[0].Contains(codename))
                {
                    codelistorder.Add(codelist[0]);
                }
            }

            if (codelistorder.Count == 0)
            {
                codelistorder.Add(codename.ToString());
            }

            codeorder = codelistorder[codelistorder.Count - 1];
            codelast = Convert.ToInt32(codeorder.Substring(1));

            switch(codelast.ToString().Length)
            {
                case 1:
                    finalcode = $"{codename}00{codelast + 1}";
                    break;

                case 2:
                    finalcode = $"{codename}0{codelast + 1}";
                    break;

                case 3:
                    finalcode = $"{codename}{codelast + 1}";
                    break;
            }
            return finalcode;
        }

        public string catgetter()
        {
            string idcategory = "";
            string[] splitter;
            foreach(string cat in listcategory)
            {
                splitter = cat.Split('+');
                if (cbCategory.Text.Equals(splitter[1]))
                {
                    idcategory = splitter[0];
                }
            }

            return idcategory;
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

        private void btAddProduct_Click(object sender, EventArgs e)
        {
            if (txtNamaProd.Text != "" && cbCategory.Text != "" && txtHarga.Text != "" && txtStock.Text != "")
            {
                string code = codegetter();
                string category = catgetter();
                listproduct.Add($"{code.ToString()}+{txtNamaProd.Text}+{txtHarga.Text}+{txtStock.Text}+{category.ToString()}");
                produkset();
            }
        }

        private void txtHarga_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < txtHarga.Text.Length; i++)
            {
                int c = txtHarga.Text[i];
                if (c < '0' || c > '9')
                {
                    txtHarga.Text = txtHarga.Text.Remove(i);
                }
            }
        }

        private void txtStock_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < txtStock.Text.Length; i++)
            {
                int c = txtStock.Text[i];
                if (c < '0' || c > '9')
                {
                    txtStock.Text = txtStock.Text.Remove(i);
                }
            }
        }

        private void btAddCategory_Click(object sender, EventArgs e)
        {
            int num;
            string order = "";
            string[] splitter;
            List<string> categories = new List<string>();
            if (txtNamaCat.Text != "")
            {
                foreach (string code in listcategory)
                {
                    splitter = code.Split('+');
                    categories.Add(splitter[1]);
                    order = splitter[0];
                }
                
                if (!categories.Contains(txtNamaCat.Text))
                {
                    num = Convert.ToInt32(order.Substring(1));
                    listcategory.Add($"C{num + 1}+{txtNamaCat.Text}");
                    catcol();
                }
                else
                {
                    MessageBox.Show("Udah ada");
                }
            }
        }

        private void btRemoveCategory_Click(object sender, EventArgs e)
        {
            int order = 0;
            string[] splitter;
            List<string> removedlist = new List<string>();
            if (txtNamaCat.Text != "")
            {
                foreach (string code in listcategory)
                {
                    splitter = code.Split('+');
                    if (splitter[1] == txtNamaCat.Text)
                    {
                        order = Convert.ToInt32(splitter[0].Substring(1));
                    }
                }
                listcategory.Remove($"C{order}+{txtNamaCat.Text}");

                foreach (string code in listproduct)
                {
                    splitter = code.Split('+');
                    if (splitter[4] == $"C{order}")
                    {
                        removedlist.Add(code);
                    }
                }
                foreach (string removed in removedlist)
                {
                    listproduct.Remove(removed);
                }
                catcol();
                prodcol();
            }
        }

        private void dgCategory_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string index;

            index = dgCategory.CurrentRow.Cells[1].Value.ToString();
            txtNamaCat.Text = index;
        }

        private void dgProduct_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string nama;
            string harga;
            string cat = "";
            string id;
            string stock;
            string[] splitter;

            nama = dgProduct.CurrentRow.Cells[1].Value.ToString();
            harga = dgProduct.CurrentRow.Cells[2].Value.ToString();
            id = dgProduct.CurrentRow.Cells[4].Value.ToString();
            stock = dgProduct.CurrentRow.Cells[3].Value.ToString();

            txtNamaProd.Text = nama;
            txtHarga.Text = harga;

            foreach (string code in listcategory)
            {
                splitter = code.Split('+');
                if (splitter[0] == id)
                {
                    cat = splitter[1];
                }
            }
            cbCategory.Text = cat;
            txtStock.Text = stock;

        }

        private void btRemoveProduct_Click(object sender, EventArgs e)
        {
            string code = dgProduct.CurrentRow.Cells[0].Value.ToString();
            string id = dgProduct.CurrentRow.Cells[4].Value.ToString();
            string removed = $"{code}+{txtNamaProd.Text}+{txtHarga.Text}+{txtStock.Text}+{id}";

            foreach (string remove in listproduct)
            {
                if (remove == removed)
                {
                    listproduct.Remove(remove);
                    break;
                }
            }
            prodcol();
        }

        private void btEditProduct_Click(object sender, EventArgs e)
        {
            string cat;
            string id = "";
            string[] splitter;

            string code = dgProduct.CurrentRow.Cells[0].Value.ToString();

            cat = cbCategory.Text;

            foreach (string idprod in listcategory)
            {
                splitter = idprod.Split('+');
                if (splitter[1] == cat)
                {
                    id = splitter[0];
                }
            }

            string update = $"{code}+{txtNamaProd.Text}+{txtHarga.Text}+{txtStock.Text}+{id}";

            for (int i = 0; i < listproduct.Count; i++)
            {
                splitter = listproduct[i].Split('+');

                if (splitter[0] == code)
                {
                    listproduct[i] = update;
                    break;
                }
            }
            prodcol();
        }
    }
}
