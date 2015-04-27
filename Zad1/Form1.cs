using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Zad1
{
    public partial class Form1 : Form
    {
        private List<object> zab = new List<object>();
        private int i = 0;
        private TextBox objTextBox;
        private string name = "";
        private int Rise;
        private int Dive;
        private int Accelerate;
        private NumericUpDown objRise;
        private NumericUpDown objAccelerate;
        private NumericUpDown objDive;
        private object selecteditem;
        public Form1()
        {
            InitializeComponent();
            List<object> listazabaweka = new List<object>();



        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void buttonNowaZabawka_Click(object sender, EventArgs e)
        {




            int selectedIndex = comboBoxListaMozliwychZabawek.SelectedIndex;
            Object selectedItem = comboBoxListaMozliwychZabawek.SelectedItem;

            if (name.Length == 0)
            {
                MessageBox.Show("Nadaj nazwe zabawki");
            }
            else
            {

                switch (selectedItem.ToString())
                {
                    case "Car":

                        Car car = new Car(name);
                        zab.Add(car);
                        Console.Out.Write("Added car: " + car.getName());
                        comboBoxZZabawkami.Items.Insert(i, name);
                        i++;

                        break;

                    case "Computer":
                        Computer computer = new Computer(name);
                        zab.Add(computer);
                        Console.Out.Write("Added car: " + computer.getName());
                        comboBoxZZabawkami.Items.Insert(i, name);
                        i++;
                        break;

                    case "Dino":
                        Dino Dino = new Dino(name);
                        zab.Add(Dino);
                        Console.Out.Write("Added car: " + Dino.getName());
                        comboBoxZZabawkami.Items.Insert(i, name);
                        i++;

                        break;
                    case "Plane":
                        Plane Plane = new Plane(name);
                        zab.Add(Plane);
                        Console.Out.Write("Added car: " + Plane.getName());
                        comboBoxZZabawkami.Items.Insert(i, name);
                        i++;

                        break;
                    case "Submarine":
                        Submarine Submarine = new Submarine(name);
                        zab.Add(Submarine);
                        Console.Out.Write("Added car: " + Submarine.getName());
                        comboBoxZZabawkami.Items.Insert(i, name);
                        i++;

                        break;
                }
            }

        }

        private void buttonZamienParametry_Click(object sender, EventArgs e)
        {
            
            int selectedIndex = comboBoxZZabawkami.SelectedIndex;            
            selecteditem = zab[selectedIndex];

            

            if (selecteditem is Car)
            {
                try
                {
                    ((Car)selecteditem).AccelerateChangeTo((int)objAccelerate.Value);
                    textBoxActualAccelerate.Text = objAccelerate.Value.ToString();
                    textBoxActualDive.Text = "Brak";
                    textBoxActualRise.Text = "Brak";

                }
                catch (NullReferenceException)
                {
                    ((Car)selecteditem).AccelerateChangeTo(0);
                    textBoxActualAccelerate.Text = "0";
                    textBoxActualDive.Text = "Brak";
                    textBoxActualRise.Text = "Brak";

                }
                
            }
            else if (selecteditem is Plane)
            {
                try
                {
                    ((Plane)selecteditem).AccelerateChangeTo((int)objAccelerate.Value);
                    textBoxActualAccelerate.Text = objAccelerate.Value.ToString();

                    textBoxActualRise.Text = "Brak";
                    textBoxActualDive.Text = "Brak";
                }
                catch (NullReferenceException)
                {
                    ((Plane)selecteditem).AccelerateChangeTo(0);
                    textBoxActualAccelerate.Text = "0";
                    textBoxActualRise.Text = "Brak";
                    textBoxActualDive.Text = "Brak";
                }
            }
            else if(selecteditem is Submarine)
            {
                try
                {
                    ((Submarine)selecteditem).AccelerateChangeTo((int)objAccelerate.Value);
                    textBoxActualAccelerate.Text = objAccelerate.Value.ToString();

                    ((Submarine)selecteditem).DiveChangeTo((int)objDive.Value);
                    textBoxActualDive.Text = objDive.Value.ToString();

                    
                    textBoxActualRise.Text = "Brak";


                }
                catch (NullReferenceException)
                {
                    ((Submarine)selecteditem).AccelerateChangeTo(0);
                    textBoxActualAccelerate.Text = "0";

                    ((Submarine)selecteditem).DiveChangeTo(0);
                    textBoxActualDive.Text = "0";
                    
                    textBoxActualRise.Text = "Brak";

                }


            }
            else if (selecteditem is Dino)
            {

                try {
                ((Dino)selecteditem).RiseChangeTo((int)objDive.Value);
                textBoxActualDive.Text = objDive.Value.ToString();

                textBoxActualAccelerate.Text = "Brak";
                textBoxActualDive.Text = "Brak";

            }catch(NullReferenceException){
                ((Dino)selecteditem).RiseChangeTo(0);
                textBoxActualAccelerate.Text = "0";

                textBoxActualDive.Text = "Brak";
                textBoxActualAccelerate.Text = "Brak";

            }

            }
            else if (selecteditem is Computer) {
                textBoxActualDive.Text = "Brak";
                textBoxActualAccelerate.Text = "Brak";
                textBoxActualRise.Text = "Brak";
            
            }
            else
            {
                MessageBox.Show("What is wrong? Baby don't hurt me...");
            }



            


        }

        private void buttonParametry_Click(object sender, EventArgs e)
        {


        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            selecteditem = sender;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Nazwa zabawki
            objTextBox = (TextBox)sender;
            name = objTextBox.Text;
        }

        private void numericUpDownRise_ValueChanged(object sender, EventArgs e)
        {
            objRise = (NumericUpDown)sender;

        }

        private void numericUpDownAccelerate_ValueChanged(object sender, EventArgs e)
        {
            objAccelerate = (NumericUpDown)sender;

        }

        private void numericUpDownDive_ValueChanged(object sender, EventArgs e)
        {
            objDive = (NumericUpDown)sender;
        }
    }
}
