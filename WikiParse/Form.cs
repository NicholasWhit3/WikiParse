using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Xml;
using System.Text.RegularExpressions;

namespace WikiParse
{
    public partial class WikiParse : Form
    {
        public WikiParse()
        {
            InitializeCompent();
        }
        private void Input_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    var webclient = new WebClient();
                    string url = "https://en.wikipedia.org/w/api.php?format=xml&action=query&prop=extracts&titles=" + Input.Text + "&redirects=true";
                    var pagesource = webclient.DownloadString(url);

                    XmlDocument doc = new XmlDocument();
                    doc.LoadXml(pagesource);
                    var fnode = doc.GetElementsByTagName("extract")[0];
                    string ss = fnode.InnerText;
                    Regex regex = new Regex("\\<[^\\>]*\\>");
                    string.Format("Before:{0}", ss);
                    ss = regex.Replace(ss, string.Empty);

                    string result = string.Format(ss);

                    Output.Text = result;
                }
                catch
                {

                }
            }
        }
    }
}
