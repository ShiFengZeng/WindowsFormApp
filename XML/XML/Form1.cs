using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Web;
namespace XML
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox1.ScrollBars = ScrollBars.Vertical;
            textBox1.WordWrap = true;
        }

        private void format_button_Click(object sender, EventArgs e)
        {
            string s = textBox1.Text.Trim().ToString();
            //s = FilterXmlErrorCode(s);
            s = PrettyXML(s);
            textBox1.Clear();
            textBox1.Text = s;
        }        
        private string PrettyXML(string XMLString)
        {
            StringWriter sw = new StringWriter();
            XmlTextWriter xw = new XmlTextWriter(sw);
            xw.Formatting = Formatting.Indented;
            xw.Indentation = 4;
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(XMLString);
            doc.Save(xw);
            return sw.ToString();
        }
        
    }
}
