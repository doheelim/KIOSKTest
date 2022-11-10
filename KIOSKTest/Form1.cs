using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KIOSKTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            menuBindingSource.Add(new Product()
            {
                Name = "아메리카노",
                Price = 2500
            });

            Product newItem = new Product();
            newItem.Price = 3000;
            newItem.Name = "아이스아메리카노";
            menuBindingSource.Add(newItem);

        }

        private void addMenu_Click(object sender, EventArgs e)
        {
            orderBindingSource.Add(menuBox.SelectedItem);
        }

        private void delMenu_Click(object sender, EventArgs e)
        {
            orderBindingSource.RemoveAt(orderBox.SelectedIndex);
        }

        private void payBtn_Click(object sender, EventArgs e)
        {
            int sum = 0;

            for (int i = 0; i < orderBindingSource.Count; i++)
            {
                sum += ((Product)orderBindingSource[i]).Price;
            }
            MessageBox.Show("총 " + sum + "원 입니다.");
            
            orderBindingSource.Clear();
        }
    }
}
