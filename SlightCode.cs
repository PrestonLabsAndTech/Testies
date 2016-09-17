using System;
using System.Drawing;
using System.Windows.Forms;
using Testies.Properties;

namespace Testies
{
    public partial class SlightCode : Form
    {
        private Image irfPic;
        private Image irfPicH;
        private Image linkPic;
        private Image linkPicH;
        private Image snmpPic;
        private Image snmpPicH;

        public SlightCode()
        {
            irfPic = Resources.IRF;
            irfPicH = Resources.IRF_HL;
            linkPic = Resources.Link_Agg2;
            linkPicH = Resources.Link_Agg_HL;
            snmpPic = Resources.SNMP;
            snmpPicH = Resources.SNMP_HL;
            InitializeComponent();
            irfButton.ImageAlign = ContentAlignment.MiddleCenter;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void irfButton_Click(object sender, EventArgs e)
        {
        }

        private void irfButton_MouseEnter(object sender, EventArgs e)
        {
            irfButton.Image = irfPicH;
        }

        private void irfButton_MouseLeave(object sender, EventArgs e)
        {
            irfButton.Image = irfPic;
        }

        private void linkAggButton_MouseLeave(object sender, EventArgs e)
        {
            linkAggButton.Image = linkPic;
        }

        private void linkAggButton_MouseEnter(object sender, EventArgs e)
        {
            linkAggButton.Image = linkPicH;
        }

        private void snmpButton_MouseEnter(object sender, EventArgs e)
        {
            snmpButton.Image = snmpPicH;
        }

        private void snmpButton_MouseLeave(object sender, EventArgs e)
        {
            snmpButton.Image = snmpPic;
        }
    }
}
