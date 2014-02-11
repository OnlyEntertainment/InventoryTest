using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace InventoryTest
{
    public partial class Form1 : Form
    {
        private struct InventoryEntry
        {
            public Item item;
            public int quantity;
            public float gewichtGesamt;
            public float wertGesamt;
            public float quality;
        }

        Dictionary<int, Item> itemList = new Dictionary<int, Item>();

        //Dictionary<String, Item> inventory = new Dictionary<String, Item>();
        List<InventoryEntry> inventory = new List<InventoryEntry>();

        //InventoryEntry[] inventory = new InventoryEntry[2]();

        ToolTip inventoryToolTip = new ToolTip();

        //Item in Aushwal == ITEMNAME#ID
        int naechsteID = 0;

        private string configFilePath = Application.StartupPath + "\\config.xml";

        public Form1()
        {
            InitializeComponent();
            cbItems.Items.Clear();
            cbItems.SelectedIndex = cbItems.Items.Add("-NewItem-");
            btnXMLLoad_Click(null, null);

            inventoryToolTip.ReshowDelay = 0;
            inventoryToolTip.AutomaticDelay = 0;
            inventoryToolTip.AutoPopDelay = 2000;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (tbID.Text == "")
            {
                itemList.Add(naechsteID, new Item(naechsteID, tbName.Text, (float)nudGewicht.Value, ENUMS.ITEMSLOT.Undefined, (float)nudValue.Value, true, (float)nudQuality.Value));

                cbItems.SelectedIndex = cbItems.Items.Add(tbName.Text + "#" + naechsteID.ToString());
                naechsteID++;
            }
            else //Bestehendes Item
            {
                int posDelimiter = cbItems.Text.LastIndexOf("#");
                string id = cbItems.Text.Substring(posDelimiter + 1, cbItems.Text.Length - (posDelimiter + 1));

                //Item item = ItemList[int.Parse(id)];
                itemList[int.Parse(id)].name = tbName.Text;
                itemList[int.Parse(id)].id = int.Parse(tbID.Text);
                itemList[int.Parse(id)].gewicht = itemList[int.Parse(id)].gewichtGesamt = (float)nudGewicht.Value;
                itemList[int.Parse(id)].wert = (float)nudValue.Value;
                itemList[int.Parse(id)].quality = (float)nudQuality.Value;


                cbItems.Items.RemoveAt(cbItems.SelectedIndex);
                cbItems.SelectedIndex = cbItems.Items.Add(tbName.Text + "#" + tbID.Text);

            }
        }

        private void cbItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            int posDelimiter = cbItems.Text.LastIndexOf("#");
            if (posDelimiter >= 0)
            {
                string id = cbItems.Text.Substring(posDelimiter + 1, cbItems.Text.Length - (posDelimiter + 1));
                Item item = itemList[int.Parse(id)];

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
            sliderQuality.Value = (int)(nudQuality.Value * 100);
        }

        private void sliderQuality_Scroll(object sender, EventArgs e)
        {
            nudQuality.Value = (decimal)((float)sliderQuality.Value / 100.0f);
        }

        private void btnXMLSave_Click(object sender, EventArgs e)
        {

            XmlDocument xmlDoc = new XmlDocument();
            XmlNode xmlDocNode = xmlDoc.CreateElement("Inventory_Test");

            XmlNode xmlRoot = xmlDoc.CreateElement("Items");
            XmlNode xmlChild;

            foreach (Item item in itemList.Values)
            {
                xmlChild = xmlDoc.CreateElement(item.name);
                //xmlChild.InnerText = item.id.ToString();

                xmlChild.Attributes.Append(xmlDoc.CreateAttribute("ID")).InnerText = item.id.ToString();
                xmlChild.Attributes.Append(xmlDoc.CreateAttribute("Weight")).InnerText = item.gewicht.ToString();
                xmlChild.Attributes.Append(xmlDoc.CreateAttribute("Value")).InnerText = item.wert.ToString();
                xmlChild.Attributes.Append(xmlDoc.CreateAttribute("Quality")).InnerText = item.quality.ToString();
                xmlRoot.AppendChild(xmlChild);
            }
            xmlDocNode.AppendChild(xmlRoot);

            xmlDoc.AppendChild(xmlDocNode);
            Console.WriteLine("Config File = " + configFilePath);
            xmlDoc.Save(configFilePath);



        }

        private void btnXMLLoad_Click(object sender, EventArgs e)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(configFilePath);

            XmlNode xmlDocNode = xmlDoc.GetElementsByTagName("Inventory_Test")[0];
            Item item;

            itemList.Clear();
            naechsteID = 0;

            foreach (XmlNode xmlRoot in xmlDocNode.ChildNodes)
            {
                foreach (XmlNode xmlChild in xmlRoot.ChildNodes)
                {
                    if (xmlRoot.Name == "Items")
                    {
                        int itemID = int.Parse(xmlChild.Attributes["ID"].InnerText);

                        if (itemID > naechsteID) naechsteID = itemID;
                        item = new Item(itemID, xmlChild.Name);
                        item.gewichtGesamt = item.gewicht = float.Parse(xmlChild.Attributes["Weight"].InnerText);
                        item.wert = float.Parse(xmlChild.Attributes["Value"].InnerText);
                        item.quality = float.Parse(xmlChild.Attributes["Quality"].InnerText);

                        itemList.Add(itemID, item);
                        cbItems.Items.Add(item.name + "#" + itemID.ToString());
                    }
                    else
                    {
                        switch (xmlRoot.Name + "-" + xmlChild.Name)
                        {

                        }
                    }
                    cbItems.SelectedIndex = naechsteID;
                }
            }
        }



        private void btnItemAdd_Click(object sender, EventArgs e)
        {
            if (tbID.Text != "")
            {

                InventoryEntry invEntry;
                for (int i = 0; i < inventory.Count; i++)
                //foreach (InventoryEntry invEntry in inventory)
                {
                    if (inventory[i].item.id.ToString() == tbID.Text && inventory[i].quality == (float)nudQuality.Value)
                    {
                        invEntry = inventory[i];
                        invEntry.quantity++;
                        invEntry.gewichtGesamt = invEntry.item.gewicht * invEntry.quantity;
                        invEntry.wertGesamt = (invEntry.item.wert * invEntry.quantity)*((float)nudQuality.Value / 100.0f);
                        inventory[i] = invEntry;
                        RefreshInventoryView();
                        return;
                    }
                }

                Item item = itemList[int.Parse(tbID.Text)];
                invEntry = new InventoryEntry();
                invEntry.item = item;
                invEntry.quantity = 1;
                invEntry.gewichtGesamt = item.gewicht;
                invEntry.wertGesamt = item.wert *((float)nudQuality.Value/100.0f);
                invEntry.quality = (float)nudQuality.Value;
                inventory.Add(invEntry);

                //if (inventory.ContainsKey(tbID.Text + "#" + nudQuality.Value.ToString())) //Quantity + 1
                //{

                //    inventory[tbID.Text + "#" + nudQuality.Value.ToString()].quantity++;
                //}
                //else
                //{
                //    Item item = itemList[int.Parse(tbID.Text)];
                //    item.quality = (float)(nudQuality.Value);
                //    inventory.Add(tbID.Text + "#" + nudQuality.Value.ToString(), item);
                //}
                RefreshInventoryView();
            }

        }

        private void RefreshInventoryView()
        {
            dgInventory.Rows.Clear();

            for (int i = 0; i < inventory.Count; i++)
            {
                DataGridViewRow row = dgInventory.Rows[dgInventory.Rows.Add()];

                row.Cells[dgInventoryID.Name].Value = i.ToString();
                row.Cells[dgInventoryName.Name].Value = inventory[i].item.name;
                row.Cells[dgInventoryQuantity.Name].Value = inventory[i].quantity;

                //row.Cells[dgInventoryID.Name].Value = item.id.ToString() + "#" + item.quality.ToString();
                //row.Cells[dgInventoryName.Name].Value = item.name.ToString();
                //row.Cells[dgInventoryQuantity.Name].Value = item.quantity.ToString();
            }

        }

        private void dgInventory_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {

            dgInventory.ShowCellToolTips = false;
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                int id = int.Parse(dgInventory.Rows[e.RowIndex].Cells[dgInventoryID.Name].Value.ToString());
                DataGridViewCell curCell = dgInventory.Rows[e.RowIndex].Cells[e.ColumnIndex];
                InventoryEntry invEntry = inventory[id];
                //curCell.ToolTipText =
                //    invEntry.item.name + "\n" +
                //    "Qualität = " + invEntry.quality.ToString() + "\n" +
                //    "Wert = " + invEntry.wertGesamt.ToString() + "(" + invEntry.item.wert.ToString() + ")\n" +
                //    "Gewicht = " + invEntry.gewichtGesamt.ToString() + "(" + invEntry.item.gewicht.ToString() + ")\n";


                inventoryToolTip.SetToolTip(dgInventory,
                    invEntry.item.name + "\n" +
                    "Qualität = " + invEntry.quality.ToString() + "\n" +
                    "Anzahl = " + invEntry.quantity.ToString() + "\n" +
                    "Wert = " + invEntry.wertGesamt.ToString("0.##") + "(" + invEntry.item.wert.ToString() + ")\n" +
                    "Gewicht = " + invEntry.gewichtGesamt.ToString() + "(" + invEntry.item.gewicht.ToString() + ")\n");
            }
            Console.WriteLine("Enter: " + e.RowIndex.ToString());


            //    dgInventory.ShowCellToolTips = false;
            //    if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            //    {
            //        String id = dgInventory.Rows[e.RowIndex].Cells[dgInventoryID.Name].Value.ToString();
            //        DataGridViewCell curCell = dgInventory.Rows[e.RowIndex].Cells[e.ColumnIndex];
            //        Item item = inventory[id];
            //        curCell.ToolTipText =
            //            item.name + "\n" +
            //            "Wert = " + item.wert.ToString() + "\n" +
            //            "Qualität = " + item.quality.ToString() + "\n" +
            //            "Gewicht = " + item.gewicht.ToString() + "\n" +
            //            "GewichtGes = " + (item.gewicht * item.quantity).ToString();


            //        inventoryToolTip.SetToolTip(dgInventory, item.name + "\n" +
            //"Wert = " + item.wert.ToString() + "\n" +
            //"Qualität = " + item.quality.ToString() + "\n" +
            //"Gewicht = " + item.gewicht.ToString() + "\n" +
            //"GewichtGes = " + (item.gewicht * item.quantity).ToString());
            //    }
            //    Console.WriteLine("Enter: " + e.RowIndex.ToString());

        }

        private void dgInventory_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            ItemToolTip.ShowAlways = false;
            Console.WriteLine("Leave: " + e.RowIndex.ToString());
        }


    }
}
