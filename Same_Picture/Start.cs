using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Same_Picture
{
    public partial class Start : Form
    {
        Form1 f1;
        public Start()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex < 0)
            {
                MessageBox.Show("모드를 선택하세요");
            }
            else
            {
                MessageBox.Show("게임을 시작합니다.");
            }
            
            f1 = new Form1(comboBox1.SelectedIndex);
            f1.ShowDialog();
            this.Close();
        }
    }
}
