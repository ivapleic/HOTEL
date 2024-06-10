//using System;
//using System.Collections.Generic;
//using System.Drawing;
//using System.Windows.Forms;

//namespace HotelApp.forms_items
//{
//    public class DropDownMenu
//    {
//        private readonly Button parentButton;
//        private readonly List<string> subMenuItems;
//        private readonly Panel menuPanel;

      

//        private void ParentButton_Click(object sender, EventArgs e)
//        {
//            for (int i = 0; i < this.subMenuItems.Count; i++)
//            {
//                MessageBox.Show($"{subMenuItems[i]}");
//            }
          
//            //ToggleMenu();
//        }

//        //private void ToggleMenu()
//        //{
//        //    if (menuPanel.Visible)
//        //    {
//        //        menuPanel.Visible = false;
//        //    }
//        //    else
//        //    {
//        //        ShowMenu();
//        //    }
//        //}

//        //private void ShowMenu()
//        //{
//        //    int x = parentButton.Left; // X početak panela će biti isti kao X početak gumba
//        //    int y = menuPanel.Height; // Y početak panela bit će ispod gumba

//        //    menuPanel.Location = new Point(x, y);
//        //    menuPanel.Width = parentButton.Width; // Širina panela bit će ista kao i širina gumba
//        //    parentButton.Parent.Controls.Add(menuPanel);
//        //    menuPanel.BringToFront();
//        //    menuPanel.Visible = true;
//        //}

//        //private void InitializeSubMenuItems()
//        //{
//        //    int top = 0;
//        //    foreach (var item in subMenuItems)
//        //    {
//        //        Button subButton = new Button
//        //        {
//        //            Text = item,
//        //            Size = new Size(200, 30),
//        //            Location = new Point(0, top),
//        //            FlatStyle = FlatStyle.Flat, // Postavite stil gumba na Flat kako biste uklonili okvir
//        //            TextAlign = ContentAlignment.MiddleLeft, // Poravnanje teksta s lijeve strane
//        //        };
//        //        subButton.Click += SubButton_Click;
//        //        menuPanel.Controls.Add(subButton);
//        //        top += 30;
//        //    }
//        //}

//        //private void SubButton_Click(object sender, EventArgs e)
//        //{
//        //    Button clickedButton = sender as Button;
//        //    menuPanel.Visible = false;
//        //    // Placeholder za budući event handler
//        //    MessageBox.Show($"{clickedButton.Text} clicked!");
//        //}

//        //public Panel GetMenuPanel()
//        //{
//        //    return menuPanel;
//        //}
//    }
//}
