using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuadrigaCX_TestApp
{
    public partial class frmObjectVisualizer : Form
    {
        public frmObjectVisualizer()
        {
            InitializeComponent();
        }

        public frmObjectVisualizer(Object inObj)
        {
            InitializeComponent();

            if (inObj.GetType().Namespace == "System.Collections.Generic")
            {
                //List<Object> lo = (List<Object>) inObj;
                //this.Text = lo[0].GetType().ToString();
                DataGridView dgv = new DataGridView();
                dgv.DataSource = inObj;
                dgv.Dock = DockStyle.Fill;
                this.Controls.Add(dgv);
            }
            else
            {
                this.Text = inObj.GetType().ToString();
                FlowLayoutPanel flp = new FlowLayoutPanel();
                flp.Dock=DockStyle.Fill;
                this.Controls.Add(flp);
                foreach (PropertyInfo property in inObj.GetType().GetProperties())
                {
                    //if (property.PropertyType == typeof (Decimal) 
                    //    || property.PropertyType == typeof(String)
                    //    || property.PropertyType == typeof(DateTime))
                    
                    //else 
                    
                    
                    if (property.PropertyType.ToString().Contains("Collection"))
                    {
                        DataGridView dgv = new DataGridView();
                        dgv.DataSource = property.GetValue(inObj);
                        flp.Controls.Add(dgv);
                    }
                    else
                    {
                        Label lbl = new Label();
                        lbl.Text = property.Name;
                        flp.Controls.Add(lbl);

                        TextBox txt = new TextBox();
                        txt.Text = property.GetValue(inObj).ToString();
                        flp.Controls.Add(txt);
                    }
                }
            }
        }
    }
}
