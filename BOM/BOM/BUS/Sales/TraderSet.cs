using BOM.DAO;
using dllPackager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BOM.BUS.Sales
{
    public partial class TraderSet : Form
    {
        
        TraderSetDao tsd;
        public TraderSet()
        {
            InitializeComponent();            
            tsd = new TraderSetDao();
        }
        DataTable offLst;
        DataTable proTypeLst;
        private void TraderSet_Load(object sender, EventArgs e)
        {
            offLst = new DataTable();
            offLst = tsd.OffList();

            foreach (DataRow item in offLst.Rows)
            {
                comboOffList.Items.Add(item["Off_Name"].ToString());
                
            }

            proTypeLst = new DataTable();
            proTypeLst = tsd.proTypeList();
            foreach (DataRow item in proTypeLst.Rows)
            {
                comboProTypeList.Items.Add(item["Mat_Type_Category"]);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (txtOffName.Text != "" && txtOwnerName.Text != "" && txtOffAddr.Text != "" && txtManager.Text != "" && txtManagerMobile.Text != "")
            {
                label18.Visible = label19.Visible = label20.Visible = label21.Visible = label22.Visible = false;
                MessageBox.Show(tsd.OffInsert(txtOffName.Text, txtOwnerName.Text, txtOffAddr.Text, txtManager.Text, txtManagerMobile.Text, txtOffMobile.Text));
            }
            else
            {
                label18.Visible = label19.Visible = label20.Visible = label21.Visible = label22.Visible = true;
            }
                
            
        }
        int offNo;
        int typeNo;
        private void button3_Click(object sender, EventArgs e)
        {            
            offNo = Int32.Parse(offLst.Rows[OffIndexNo]["Off_No"].ToString());
            typeNo= Int32.Parse(proTypeLst.Rows[typeindexNo]["Mat_Type_No"].ToString());

            MessageBox.Show(tsd.MatInsert(typeNo, txtManufactur.Text, txtMatName.Text, Int32.Parse(txtMatPrice.Text), txtMatLevel.Text, Int32.Parse(txtMatEa.Text), offNo));
        }

        int OffIndexNo;
        private void comboOffList_SelectedIndexChanged(object sender, EventArgs e)
        {
            OffIndexNo = Int32.Parse(comboOffList.SelectedIndex.ToString());           
        }
        int typeindexNo;
        private void comboProTypeList_SelectedIndexChanged(object sender, EventArgs e)
        {
            typeindexNo = Int32.Parse(comboProTypeList.SelectedIndex.ToString());
        }
    }
}
