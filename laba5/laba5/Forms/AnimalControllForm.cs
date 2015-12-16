using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using laba5.Model;
using laba5.Controller;
using laba5.Observer;

namespace laba5.Forms
{
    public partial class AnimalControllForm : Form, IObserver
    {
        public ZooCont zooController;
        private int animalIndex;
        public AnimalControllForm(Zoo zoo, int countofZoos)
        {
            zooController = new ZooCont(zoo);
            InitializeComponent();
            ZooNameTextBox.Text = zoo.Name;
            animalIndex = -1;
            ZoosCountTextBox.Text = countofZoos.ToString();
        }

        private void AnimalAdd_Click(object sender, EventArgs e)
        {
            AnimalCreatorForm animalCreator = new AnimalCreatorForm(this);
            animalCreator.Show();
            this.Hide();
        }
        
        public void RefreshTheList()
        {
            AnimalListBox.Items.Clear();
            animalIndex = -1;
            foreach(Animal animal in zooController.ReturnZoo())
            {
                AnimalListBox.Items.Add(animal.Name);
            }
        }

        private void AnimalDelete_Click(object sender, EventArgs e)
        {
            if(animalIndex != -1)
            {
                zooController.DeleteAnAnimal(animalIndex);
                RefreshTheList();
            }
        }

        private void AnimalListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            animalIndex = AnimalListBox.SelectedIndex;
        }

        private void AnimalShowButton_Click(object sender, EventArgs e)
        {
            if (animalIndex != -1)
            {
                AnimalIndivid animalForm = new AnimalIndivid(animalIndex, zooController);
                animalForm.Show();
            }
        }

        public void UpdateCount(int count)
        {
            SetTextToBox(count);
        }
        
        private void SetTextToBox(int count)
        {
            ZoosCountTextBox.Text = count.ToString();
        }
    }
}
