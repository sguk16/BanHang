﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.cblist = new System.Windows.Forms.ComboBox();
            // 
            // cblist
            // 
            this.cblist.FormattingEnabled = true;
            cblist.Items.AddRange(ThietBiBUS.Loaitb());
            this.cblist.Location = new System.Drawing.Point(0, 36);
            this.cblist.Name = "cblist";
            this.cblist.Size = new System.Drawing.Size(121, 24);
            this.cblist.TabIndex = 4;
            this.Controls.Add(this.cblist);
            //datatable
            DataTable table = new DataTable();
            table.Columns.Add("Weight", typeof(int));
            table.Columns.Add("Name", typeof(string));
            table.Columns.Add("Breed", typeof(string));
            table.Columns.Add("Date", typeof(DateTime));
            object[] array = new object[4];
            array[0] = 7;
            array[1] = "Candy";
            array[2] = "Yorkshire Terrier";
            array[3] = DateTime.Now;
            table.Rows.Add(array);
        }
    }
}
