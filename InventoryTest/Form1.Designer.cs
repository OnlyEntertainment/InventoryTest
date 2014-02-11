namespace InventoryTest
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnSave = new System.Windows.Forms.Button();
            this.cbItems = new System.Windows.Forms.ComboBox();
            this.tbID = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nudGewicht = new System.Windows.Forms.NumericUpDown();
            this.nudValue = new System.Windows.Forms.NumericUpDown();
            this.sliderQuality = new System.Windows.Forms.TrackBar();
            this.nudQuality = new System.Windows.Forms.NumericUpDown();
            this.dgInventory = new System.Windows.Forms.DataGridView();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.ItemToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.btnXMLSave = new System.Windows.Forms.Button();
            this.btnXMLLoad = new System.Windows.Forms.Button();
            this.btnItemAdd = new System.Windows.Forms.Button();
            this.dgInventoryID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgInventoryQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgInventoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.nudGewicht)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderQuality)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuality)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgInventory)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(515, 275);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(203, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cbItems
            // 
            this.cbItems.FormattingEnabled = true;
            this.cbItems.Location = new System.Drawing.Point(564, 59);
            this.cbItems.Name = "cbItems";
            this.cbItems.Size = new System.Drawing.Size(121, 21);
            this.cbItems.Sorted = true;
            this.cbItems.TabIndex = 1;
            this.cbItems.SelectedIndexChanged += new System.EventHandler(this.cbItems_SelectedIndexChanged);
            // 
            // tbID
            // 
            this.tbID.Enabled = false;
            this.tbID.Location = new System.Drawing.Point(691, 59);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(27, 20);
            this.tbID.TabIndex = 2;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(564, 86);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(121, 20);
            this.tbName.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(512, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(512, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Gewicht";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(512, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Wert";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(512, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Qualität";
            // 
            // nudGewicht
            // 
            this.nudGewicht.DecimalPlaces = 2;
            this.nudGewicht.Location = new System.Drawing.Point(565, 112);
            this.nudGewicht.Name = "nudGewicht";
            this.nudGewicht.Size = new System.Drawing.Size(120, 20);
            this.nudGewicht.TabIndex = 11;
            // 
            // nudValue
            // 
            this.nudValue.DecimalPlaces = 2;
            this.nudValue.Location = new System.Drawing.Point(565, 138);
            this.nudValue.Name = "nudValue";
            this.nudValue.Size = new System.Drawing.Size(120, 20);
            this.nudValue.TabIndex = 12;
            // 
            // sliderQuality
            // 
            this.sliderQuality.Cursor = System.Windows.Forms.Cursors.Default;
            this.sliderQuality.LargeChange = 500;
            this.sliderQuality.Location = new System.Drawing.Point(564, 193);
            this.sliderQuality.Maximum = 10000;
            this.sliderQuality.Name = "sliderQuality";
            this.sliderQuality.Size = new System.Drawing.Size(120, 45);
            this.sliderQuality.SmallChange = 100;
            this.sliderQuality.TabIndex = 14;
            this.sliderQuality.TickStyle = System.Windows.Forms.TickStyle.None;
            this.sliderQuality.Value = 10000;
            this.sliderQuality.Scroll += new System.EventHandler(this.sliderQuality_Scroll);
            // 
            // nudQuality
            // 
            this.nudQuality.DecimalPlaces = 2;
            this.nudQuality.Location = new System.Drawing.Point(565, 167);
            this.nudQuality.Name = "nudQuality";
            this.nudQuality.Size = new System.Drawing.Size(120, 20);
            this.nudQuality.TabIndex = 15;
            this.nudQuality.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudQuality.ValueChanged += new System.EventHandler(this.nudQuality_ValueChanged);
            // 
            // dgInventory
            // 
            this.dgInventory.AllowUserToAddRows = false;
            this.dgInventory.AllowUserToDeleteRows = false;
            this.dgInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgInventory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgInventoryID,
            this.dgInventoryQuantity,
            this.dgInventoryName});
            this.dgInventory.Location = new System.Drawing.Point(12, 12);
            this.dgInventory.Name = "dgInventory";
            this.dgInventory.ReadOnly = true;
            this.dgInventory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgInventory.Size = new System.Drawing.Size(494, 315);
            this.dgInventory.TabIndex = 16;
            this.dgInventory.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgInventory_CellMouseEnter);
            this.dgInventory.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgInventory_CellMouseLeave);
            // 
            // btnXMLSave
            // 
            this.btnXMLSave.Location = new System.Drawing.Point(515, 304);
            this.btnXMLSave.Name = "btnXMLSave";
            this.btnXMLSave.Size = new System.Drawing.Size(100, 23);
            this.btnXMLSave.TabIndex = 17;
            this.btnXMLSave.Text = "XML Save";
            this.btnXMLSave.UseVisualStyleBackColor = true;
            this.btnXMLSave.Click += new System.EventHandler(this.btnXMLSave_Click);
            // 
            // btnXMLLoad
            // 
            this.btnXMLLoad.Location = new System.Drawing.Point(618, 304);
            this.btnXMLLoad.Name = "btnXMLLoad";
            this.btnXMLLoad.Size = new System.Drawing.Size(100, 23);
            this.btnXMLLoad.TabIndex = 18;
            this.btnXMLLoad.Text = "XML Load";
            this.btnXMLLoad.UseVisualStyleBackColor = true;
            this.btnXMLLoad.Click += new System.EventHandler(this.btnXMLLoad_Click);
            // 
            // btnItemAdd
            // 
            this.btnItemAdd.Location = new System.Drawing.Point(515, 244);
            this.btnItemAdd.Name = "btnItemAdd";
            this.btnItemAdd.Size = new System.Drawing.Size(203, 23);
            this.btnItemAdd.TabIndex = 19;
            this.btnItemAdd.Text = "Add Item";
            this.btnItemAdd.UseVisualStyleBackColor = true;
            this.btnItemAdd.Click += new System.EventHandler(this.btnItemAdd_Click);
            // 
            // dgInventoryID
            // 
            this.dgInventoryID.HeaderText = "ID";
            this.dgInventoryID.Name = "dgInventoryID";
            this.dgInventoryID.ReadOnly = true;
            this.dgInventoryID.Width = 50;
            // 
            // dgInventoryQuantity
            // 
            this.dgInventoryQuantity.HeaderText = "#";
            this.dgInventoryQuantity.Name = "dgInventoryQuantity";
            this.dgInventoryQuantity.ReadOnly = true;
            this.dgInventoryQuantity.Width = 25;
            // 
            // dgInventoryName
            // 
            this.dgInventoryName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgInventoryName.HeaderText = "Name";
            this.dgInventoryName.Name = "dgInventoryName";
            this.dgInventoryName.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 604);
            this.Controls.Add(this.btnItemAdd);
            this.Controls.Add(this.btnXMLLoad);
            this.Controls.Add(this.btnXMLSave);
            this.Controls.Add(this.dgInventory);
            this.Controls.Add(this.nudQuality);
            this.Controls.Add(this.sliderQuality);
            this.Controls.Add(this.nudValue);
            this.Controls.Add(this.nudGewicht);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.cbItems);
            this.Controls.Add(this.btnSave);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudGewicht)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderQuality)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuality)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgInventory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cbItems;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudGewicht;
        private System.Windows.Forms.NumericUpDown nudValue;
        private System.Windows.Forms.TrackBar sliderQuality;
        private System.Windows.Forms.NumericUpDown nudQuality;
        private System.Windows.Forms.DataGridView dgInventory;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.ToolTip ItemToolTip;
        private System.Windows.Forms.Button btnXMLSave;
        private System.Windows.Forms.Button btnXMLLoad;
        private System.Windows.Forms.Button btnItemAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgInventoryID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgInventoryQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgInventoryName;
    }
}

