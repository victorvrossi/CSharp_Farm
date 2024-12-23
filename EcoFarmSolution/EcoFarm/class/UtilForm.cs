﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoFarm.@class
{
    public class UtilForm
    {
        private Form activeForm;
        public void openForm(Panel desktop, Form filho, object sender)
        {
            if (activeForm != null) activeForm.Close();

            activeForm = filho;
            filho.TopLevel = false;
            filho.FormBorderStyle = FormBorderStyle.None;
            filho.Dock = DockStyle.Fill;
            desktop.Controls.Add(filho);
            desktop.Tag = filho;
            filho.ClientSize = desktop.ClientSize;
            filho.BringToFront();
            filho.Show();


        }

    }
}
