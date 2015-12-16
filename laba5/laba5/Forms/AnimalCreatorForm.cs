using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba5.Forms
{
    public partial class AnimalCreatorForm : Form
    {
        private AnimalControllForm form;
        public AnimalCreatorForm(AnimalControllForm form)
        {
            this.form = form;
            InitializeComponent();
        }

        private void AnimalCreateButton_Click(object sender, EventArgs e)
        {
            if(animalName.Text != "" && AnimalComment.Text != "")
            {
                form.zooController.AddAnAnimal(animalName.Text, Convert.ToInt32(AnimalAge.Text), AnimalComment.Text);
            }
            this.RefreshForms();
        }

        private void RefreshForms()
        {
            form.Show();
            form.RefreshTheList();
            this.Close();
        }
    }
}
