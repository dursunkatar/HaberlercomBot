using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HaberlerComBOT
{
    public partial class MainFrm : Form
    {
        private readonly List<CuffNews> cuffs = NewsManager.Cuffs;
       
        public MainFrm()
        {
            InitializeComponent();
            listView.MultiSelect = false;
        }

        private void MainFrm_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < cuffs.Count; i++)
            {
                var lvi = new ListViewItem();
                lvi.Text = i.ToString();
                lvi.SubItems.Add(cuffs[i].Title);
                listView.Items.Add(lvi);
            }
        }

        private void listView_Click(object sender, EventArgs e)
        {
            if (listView.SelectedItems.Count == 1)
            {
                int index = int.Parse(listView.SelectedItems[0].Text);
                lblDetail.Text = cuffs[index].Detail;
                pictureBox.ImageLocation = cuffs[index].ImageUrl;
            }
        }

        private void menuHakkinda_Click(object sender, EventArgs e)
        {
            new FrmAbout().Show();
        }
    }
}
