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
        private NumericUpDown objRise;
        private NumericUpDown objAccelerate;
        private NumericUpDown objDive;
        private object selecteditem;
        private ComboBox cmb;
        private int selectedToyIndex;
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
                        car.AccelerateChangeTo(0);
                        zab.Add(car);
                        
                        comboBoxZZabawkami.Items.Insert(i,(i+1)+") Car "+ name);
                        i++;

                        break;

                    case "Computer":
                        Computer computer = new Computer(name);
                        zab.Add(computer);

                        comboBoxZZabawkami.Items.Insert(i, (i + 1) + ") Computer " + name);
                        i++;
                        break;

                    case "Dino":
                        Dino Dino = new Dino(name);
                        zab.Add(Dino);

                        comboBoxZZabawkami.Items.Insert(i, (i + 1) + ") Dino " + name);
                        i++;

                        break;
                    case "Plane":
                        Plane Plane = new Plane(name);
                        zab.Add(Plane);

                        comboBoxZZabawkami.Items.Insert(i, (i + 1) + ") Plane " + name);
                        i++;

                        break;
                    case "Submarine":
                        Submarine Submarine = new Submarine(name);
                        zab.Add(Submarine);

                        comboBoxZZabawkami.Items.Insert(i, (i + 1) + ") Submarine " + name);
                        i++;

                        break;
                }
            }

        }

        private void buttonZamienParametry_Click(object sender, EventArgs e)
        {
            
            int selectedIndex = comboBoxZZabawkami.SelectedIndex;            
            selecteditem = zab[selectedIndex];

            if (selecteditem is IAccelerate)
            {
                selecteditem = (IAccelerate) selecteditem;
                textBoxActualAccelerate.Text = objAccelerate.Value.ToString();
            }
            else if (selecteditem is IDive)
            {
                selecteditem = (IDive)selecteditem;
                textBoxActualDive.Text = objAccelerate.Value.ToString();
            }
            else if (selecteditem is IRise)
            {
                selecteditem = (IRise)selecteditem;
                textBoxActualRise.Text = objAccelerate.Value.ToString();
            }


            /*
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


*/
            


        }

        private void buttonParametry_Click(object sender, EventArgs e)
        {


        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            cmb = (ComboBox)sender;
            selectedToyIndex = cmb.SelectedIndex;
            selecteditem = zab[selectedToyIndex];
            textBoxActualDive.Text = "Brak";
            textBoxActualAccelerate.Text = "Brak";
            textBoxActualRise.Text = "Brak";
            if (selecteditem is IAccelerate)
            {
                var thingVar = (IAccelerate)selecteditem;
                textBoxActualAccelerate.Text = thingVar.getAccelerate().ToString();
            }

            if (selecteditem is IDive)
            {
                var thingVar = (IDive)selecteditem;
                textBoxActualDive.Text = thingVar.getDive().ToString();

            }

            if (selecteditem is IRise)
            {
                var thingVar = (IRise)selecteditem;
                textBoxActualRise.Text = thingVar.getRise().ToString();
            } 
         
            



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
          
            int value = 0;
            if (objRise.Text.Length != 0)
            {
                value = Int32.Parse(objRise.Text);
            }

            if (selecteditem != null)
            {
                selecteditem= zab[selectedToyIndex];

                if (selecteditem is IRise)
                {
                    var thingVar = (IRise)selecteditem;
                    thingVar.RiseChangeTo(value);
                    textBoxActualRise.Text  = value.ToString();
                }

            }

        }

        

        private void numericUpDownAccelerate_ValueChanged(object sender, EventArgs e)
        {
            objAccelerate = (NumericUpDown)sender;
          
            int value = 0;
            if (objAccelerate.Text.Length != 0)
            {
                value = Int32.Parse(objAccelerate.Text);
            }

            if (selecteditem != null)
            {
                selecteditem= zab[selectedToyIndex];

                if (selecteditem is IAccelerate)
                {
                    var thingVar = (IAccelerate)selecteditem;
                    thingVar.AccelerateChangeTo(value);
                    textBoxActualAccelerate.Text = value.ToString();
                }

            }

        }

        private void numericUpDownDive_ValueChanged(object sender, EventArgs e)
        {
            objDive = (NumericUpDown)sender;
            int value = 0;
            if (objDive.Text.Length != 0)
            {
                value = Int32.Parse(objDive.Text);
            }

            if (selecteditem != null)
            {
                selecteditem = zab[selectedToyIndex];

                if (selecteditem is IDive)
                {
                    var thingVar = (IDive)selecteditem;
                    thingVar.DiveChangeTo(value);
                    textBoxActualDive.Text = value.ToString();
                }

            }
        }

        private void textBoxActualAccelerate_TextChanged(object sender, EventArgs e)
        {
        }

        private void comboBoxZZabawkami_SelectedValueChanged(object sender, EventArgs e)
        {
          
        }
    }
}
