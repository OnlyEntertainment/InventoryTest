using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryTest
{
    public partial class Form1 : Form
    {

        Dictionary<int, Item> ItemList = new Dictionary<int, Item>();
        //Item in Aushwal == ITEMNAME#ID
        int naechsteID = 0;

        public Form1()
        {
            InitializeComponent();
            cbItems.Items.Clear();
            cbItems.SelectedIndex =  cbItems.Items.Add("-NewItem-");

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (tbID.Text == "")
            {
                ItemList.Add(naechsteID, new Item(naechsteID, tbName.Text, (float)nudGewicht.Value, ENUMS.ITEMSLOT.Undefined, (float)nudValue.Value, true, (float)nudQuality.Value));

                cbItems.SelectedIndex = cbItems.Items.Add(tbName.Text + "#" + naechsteID.ToString());
                naechsteID++;
            }
            else //Bestehendes Item
            {
                int posDelimiter = cbItems.Text.LastIndexOf("#");
                string id = cbItems.Text.Substring(posDelimiter + 1, cbItems.Text.Length - (posDelimiter + 1));

                //Item item = ItemList[int.Parse(id)];
                ItemList[int.Parse(id)].name = tbName.Text;
                ItemList[int.Parse(id)].id = int.Parse(tbID.Text);
                ItemList[int.Parse(id)].gewicht = ItemList[int.Parse(id)].gewichtGesamt = (float)nudGewicht.Value;
                ItemList[int.Parse(id)].wert = (float)nudValue.Value;
                ItemList[int.Parse(id)].quality = (float)nudQuality.Value));


                cbItems.Items.RemoveAt(cbItems.SelectedIndex);
                cbItems.SelectedIndex = cbItems.Items.Add(tbName.Text + "#" + tbID.Text);

            }
        }

        private void cbItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            int posDelimiter = cbItems.Text.LastIndexOf("#") ;
            if (posDelimiter >= 0)
            {
                string id = cbItems.Text.Substring(posDelimiter + 1, cbItems.Text.Length - (posDelimiter + 1));
                Item item = ItemList[int.Parse(id)];

                tbName.Text = item.name;
                tbID.Text = item.id.ToString();
                nudGewicht.Value = (decimal)item.gewicht;
                nudQuality.Value = (decimal)item.quality;
                nudValue.Value = (decimal)item.wert;
                    


            }
            else //New Item
            {
                tbName.Text = "";
                tbID.Text = "";
                nudGewicht.Value = 1;
                nudQuality.Value = 100;
                nudValue.Value = 1;

            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tbQuality_KeyDown(object sender, KeyEventArgs e)
        {
            //switch (e.KeyCode)
            //{ 
            //    case Keys.D0:
            //    case Keys.D1:
            //    case Keys.D2:
            //    case Keys.D3:
            //    case Keys.D4:
            //    case Keys.D5:
            //    case Keys.D6:
            //    case Keys.D7:
            //    case Keys.D8:
            //    case Keys.D9:

            //        break;
            //    default:
            //        if (tbQuality.Text.Length == 1)
            //        {tbQuality.Text = "";}
            //        else
            //        {
            //        tbQuality.Text = tbQuality.Text.Substring(0,tbQuality.Text.Length-1);
            //        }
            //        break;
            //}

        }

        private void nudQuality_ValueChanged(object sender, EventArgs e)
        {
            sliderQuality.Value = (int)(nudQuality.Value*100);
        }

        private void sliderQuality_Scroll(object sender, EventArgs e)
        {
            nudQuality.Value = (decimal)((float)sliderQuality.Value / 100.0f);
        }
    }
}
