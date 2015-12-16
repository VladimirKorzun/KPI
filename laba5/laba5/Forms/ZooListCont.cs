using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using laba5.Controller;
using laba5.Forms;
using laba5.Observer;

namespace laba5
{
    public partial class ZooListCont : Form
    {
        private CityCont cityController;
        public CountChecker countChecker;
        private int zooListIndex;
        public ZooListCont()
        {
            InitializeComponent();
            cityController = new CityCont();
            zooListIndex = -1;
            countChecker = new CountChecker();
            ZooList.DataSource = cityController.list;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            zooListIndex = ZooList.SelectedIndex;
        }

        private void ZooCreator_Click(object sender, EventArgs e)
        {
            /*if (!CheckFieldEmpty())
            {
                cityController.CreateAZoo(ZooName.Text);
                AddToListBox(ZooName.Text);
                RefreshTheFields();
                countChecker.IncrementTheCount();
            }*/
        }
        
        private bool CheckFieldEmpty()
        {
            if(ZooName.Text == "")
            {
                zooNameLabel.Text = "Enter the name, please!";
                return true;
            }
            return false;
        }

        private void AddToListBox(string item)
        {
            ZooList.Items.Add(item);
        }

        private void RemoveFromListBox()
        {
            if(zooListIndex != -1)
            {
                countChecker.DecrementTheCount();
                ZooList.Items.RemoveAt(zooListIndex);
            }
        }

        private void RefreshTheFields()
        {
            ZooName.Clear();
            zooNameLabel.Text = "Enter the name";
        }

        private void ZooRemover_Click(object sender, EventArgs e)
        {
            cityController.DestroyTheZoo(zooListIndex);
            RemoveFromListBox();
        }

        private void ZooOpener_Click(object sender, EventArgs e)
        {
            if (zooListIndex != -1)
            {
                AnimalControllForm zooWindow = new AnimalControllForm(cityController.GetZoo(zooListIndex), ZooList.Items.Count);
                countChecker.RegisterSubject(zooWindow);
                zooWindow.Show();
            }
        }
    }
}
