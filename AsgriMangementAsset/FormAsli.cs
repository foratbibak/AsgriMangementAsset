using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AsgriMangementAsset.AssetForms;
using ManagementDataLayer.Repositories;
using ManagementDataLayer.Services;

namespace AsgriMangementAsset
{
    public partial class FormAsli : Form
    {
        IAssetRepository assetRepository;
        public FormAsli()
        {
            InitializeComponent();
            assetRepository = new AssetRepository();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormAsset frm=new FormAsset();
            frm.ShowDialog();

        }
    }
}
