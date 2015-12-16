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

namespace laba5.Forms
{
    public partial class AnimalIndivid : Form
    {
        public AnimalIndivid(int index, ZooCont controller)
        {
            InitializeComponent();
            animalNameTextBox.Text = controller.ReturnZoo().ElementAt(index).Name;
            animalCommentBox.Text = controller.ReturnZoo().ElementAt(index).Comment;
        }

    }
}
