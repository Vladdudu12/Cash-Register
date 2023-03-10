using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Store
{
   
    public partial class ProductForm : Form
    {
        MySqlConnection con = new MySqlConnection("Server=localhost;Database=db_store;user=root;Pwd=Steaua123!@?");
        MySqlCommand cmd;
        MySqlDataReader dr;
        public ProductForm()
        {
            InitializeComponent();
        }

        private void textBoxPriceNoVAT_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void buttonProdUpdate_Click(object sender, EventArgs e)
        {
            string prodName = textBoxProdName.Text;
            string measureUnit = textBoxMeasureUnit.Text;
            string priceWVAT = textBoxPriceWVAT.Text;
            string priceNoVAT = textBoxPriceNoVAT.Text;
            string prodDescription = textBoxProdDescription.Text;
            int vatType = comboBoxVatType.SelectedIndex;
            if(prodName == string.Empty)
            {
                MessageBox.Show("nume lipsa");
                return;
            }
            else if(measureUnit == string.Empty)
            {
                MessageBox.Show("unitate de masura lipsa");
                return;
            }
            else if(priceWVAT == string.Empty)
            {
                MessageBox.Show("pret lipsa");
                return;
            }
            else
            {
                cmd = new MySqlCommand();
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "insert into products(name, fullPrice, price, vatType, measureUnit, description) values ( prodName  + Convert.ToDouble(priceWVAT) + Convert.ToDouble(priceNoVAT) + vatType + measureUnit + prodDescription )";
                try
                {
                    dr = cmd.ExecuteReader();
                    MessageBox.Show("saved");
                    this.Dispose();
                    while (dr.Read())
                    {
                    }
                }
                catch (Exception es)
                {
                    MessageBox.Show(es.Message);
                }
                con.Close();
            }
            //update product tables
            //db connection close


            //default value pt vat Type
            //calcul automat pret cu/fara TVA
            
        }

        private void textBoxProdName_TextChanged(object sender, EventArgs e)
        {

        }

        private void ProductForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db_storeDataSet.vat_types' table. You can move, or remove it, as needed.
            this.vat_typesTableAdapter.Fill(this.db_storeDataSet.vat_types);

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.vat_typesTableAdapter.FillBy(this.db_storeDataSet.vat_types);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
