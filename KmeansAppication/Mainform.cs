using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KmeansAppication
{

    public partial class Mainform : Form
    {
        int k, D;

        Clustering clus = new Clustering();
        Graphics g;
        Pen bkpen = new Pen(Color.Black);
        SolidBrush bBrush = new SolidBrush(Color.Black);

        public Mainform()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void set_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void Generate_Click(object sender, EventArgs e)
        {

        }

        int text_int(TextBox T)
        {
            return Convert.ToInt32(T.Text);
        }

        private void Generate_Click_1(object sender, EventArgs e)
        {
            if (text_int(cluster_box) <= text_int(set_box))
            {
                MessageBox.Show("            ERROR!!\n\n" + "클러스터의 갯수는 데이터 셋의 갯수보다 커야합니다!!!");
            }
            else
            {
                cluster_box.Enabled = false;
                set_box.Enabled = false;
                Generate.Enabled = false;
                k = text_int(cluster_box);
                D = text_int(set_box);
                clus.initializer(k, D);
                string item_;
                for (int i = 0; i < k; i++)
                {
                    item_ = "(" + clus.clusters[0][i].x + "," + clus.clusters[0][i].y + ")";
                    point_list.Items.Add(item_);
                }
                g = panel1.CreateGraphics();
                for (int i = 0; i < k; i++)
                {
                    Rectangle r = new Rectangle(clus.clusters[0][i].x * 4, clus.clusters[0][i].y * 4, 4, 4);
                    g.FillEllipse(bBrush, r);
                }
                //            item_ = "(" + clus.clusters[2][0].x + "," + clus.clusters[2][0].y + ")----------";
                //            point_list.Items.Add(item_);
            }
        }

        private void Process_Click(object sender, EventArgs e)
        {
            clus.comparing(D, k);
            string str;

            Color valuecolor;
            SolidBrush Vrush, Rush;
 
            g = panel1.CreateGraphics();
            for (int i = 1; i <= D; i++)
            {
                str = "data set " + i;
                point_list.Items.Add(str);
                valuecolor = Color.FromArgb((i * 26) % 255, (i * 81) % 255, (i * 110) % 255);
                Vrush = new SolidBrush(valuecolor);
                Rush = new SolidBrush(Color.PaleVioletRed);
                for (int j = 1; j < clus.clusters[i].Count ; j++)
                {
                    Rectangle r = new Rectangle(clus.clusters[i][j].x * 4, clus.clusters[i][j].y* 4, 4, 4);
                    g.FillEllipse(Vrush, r);
                    str = "("+ clus.clusters[i][j].x+","+ clus.clusters[i][j].y + ")";
                    point_list.Items.Add(str);
                }
 //               Rectangle rr = new Rectangle(clus.clusters[i][0].x * 4, clus.clusters[i][0].y * 4, 8, 8);
 //               g.FillEllipse(Rush, rr);

            }


            clus.setZero(D);




        }
        private void Cluster_box_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))    //숫자와 백스페이스를 제외한 나머지를 바로 처리
            {
                e.Handled = true;
            }
        }

        private void Set_box_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))    //숫자와 백스페이스를 제외한 나머지를 바로 처리
            {
                e.Handled = true;
            }
        }
    }
}
