using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GridGui.UI
{
    public partial class Form1 : Form
    {
        private const string FamilyName = "Segoe UI";

        public Form1()
        {
            InitializeComponent();

           tabcontrol.DrawItem += new DrawItemEventHandler(tabControl1_DrawItem);
        }



        private void tabControl1_DrawItem(Object sender, System.Windows.Forms.DrawItemEventArgs e)
        {
            Graphics g = e.Graphics;
            Brush _textBrush;
            //TabPage tabConrtol1;

            // Get the item from the collection.
            TabPage _tabPage = tabcontrol.TabPages[e.Index];

            // Get the real bounds for the tab rectangle.
            Rectangle _tabBounds = tabcontrol.GetTabRect(e.Index);
            //Rectangle _tab1 = tabcontrol.TabPages[0].BackgroundImage = Image.FromFile("Flash.png");

            if (e.State == DrawItemState.Selected)
            {

                // Draw a different background color, and don't paint a focus rectangle.
                _textBrush = new SolidBrush(Color.Black);
                //Color color = System.Drawing.ColorTranslator.FromHtml("#c3c8cd");
                g.FillRectangle(brush: Brushes.LightSlateGray, rect: e.Bounds);
                //g.FillRectangle(BackgroundImage.PixelFormat("Flash.png");
                //this.BackColor = Color.LightSlateGray;
                //this.TransparencyKey = Color.LightSlateGray;
                //tabControl1.TabPages[0].BackgroundImage = Image.FromFile(fileName);

            }
            else
            {
                _textBrush = new System.Drawing.SolidBrush(e.ForeColor);
                    e.DrawBackground();  
            }

            // Use our own font.
            Font _tabFont = new Font(FamilyName, (float)18.0, FontStyle.Bold, GraphicsUnit.Pixel);

            // Assign the ImageList control to WinTab
            //this.tabcontrol.ImageList = this.imageList1;
            // Add image to a tab in WinTab by setting the index of the image in ImageList control
            //this.tabcontrol.Tabs[0].Appearance.Image = 0;

            // Draw string. Center the text.
            StringFormat _stringFlags = new StringFormat();
            _stringFlags.Alignment = StringAlignment.Near;
            _stringFlags.LineAlignment = StringAlignment.Near;
            g.DrawString(_tabPage.Text, _tabFont, _textBrush, _tabBounds, new StringFormat(_stringFlags));
        }






        private void toolStripContainer1_ContentPanel_Load(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel9_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void tabcontrol_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
    
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }
    }

        
}

