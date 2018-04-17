using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoSellingMachine
{
    public partial class Form1 : Form
    {
        Coke coke = new Coke();
        Soda soda = new Soda();
        Pocari pocari = new Pocari();
        Guest guest = new Guest();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            coke_num.Text = coke.ToString();
            soda_num.Text = soda.ToString();
            pocari_num.Text = pocari.ToString();
            change.Text = guest.ToString();
        }

        private void Pay_Click(object sender, EventArgs e)
        {
            StartOrStop.Text = "Start"; // 지불버튼을 누르는 순간 기계 작동
            groupBox1.Enabled = true; // 기계가 작동하면서 컨트롤을 사용할 수 있게 함
            guest.change = int.Parse(money.Text);
            change.Text = guest.change.ToString();
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void Complite_Click(object sender, EventArgs e)
        {
            StartOrStop.Text = "Stop";
            groupBox1.Enabled = false;
            MessageBox.Show(print_bill(), "영수증", MessageBoxButtons.OK);
            guest.Initialize();
        }

        private string print_bill()
        {
            return "영 수 증\n" + "콜라 " + guest.coke + "개\n" + "사이다 " + guest.soda + "개\n" +
                "포카리스웨트 " + guest.pocari + "개\n" + "거스름돈 " + guest.change + "원";
        }

        private void Select_Coke_Click(object sender, EventArgs e)
        {
            coke_num_TextChanged(sender, e);
            coke_num.Text = (coke.count--).ToString();
        }

        private void Select_Soda_Click(object sender, EventArgs e)
        {
            soda_num_TextChanged(sender, e);
            soda_num.Text = (soda.count--).ToString();
        }

        private void Select_Pocari_Click(object sender, EventArgs e)
        {
            pocari_num_TextChanged(sender, e);
            pocari_num.Text = (pocari.count--).ToString();
        }

        private void coke_num_TextChanged(object sender, EventArgs e)
        {
            
            guest.coke++;
            guest.change -= coke.price;
            change_TextChanged(sender, e);
        }

        private void soda_num_TextChanged(object sender, EventArgs e)
        {
            
            guest.soda++;
            guest.change -= soda.price;
            change_TextChanged(sender, e);
        }

        private void pocari_num_TextChanged(object sender, EventArgs e)
        {
            
            guest.pocari++;
            guest.change -= pocari.price;
            change_TextChanged(sender, e);
        }

        private void change_TextChanged(object sender, EventArgs e)
        {
            change.Text = guest.change.ToString();
        }
    }
}
