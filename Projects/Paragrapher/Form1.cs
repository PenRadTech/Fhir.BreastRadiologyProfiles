using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paragrapher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tbInput_TextChanged(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            String text = this.tbInput.Text.Replace("\r", "");
            String[] lines = text.Split('\n');

            sb.AppendLine(".BiradHeader()");
            foreach (String line in lines)
            {
                sb.AppendLine($".BlockQuote(\"{FormatLine(line)}\")");
            }
            sb.AppendLine(".BiradFooter()");
            this.textBox2.Text = sb.ToString();
        }

        private String FormatLine(String text)
        {
            StringBuilder sb = new StringBuilder();

            Int32 i = 0;
            while (i < text.Length)
            {
                char c = text[i++];
                switch (c)
                {
                    case '\r':
                        break;

                    case '\"':
                    case '“':
                    case '”':
                        sb.Append("\\\"");
                        break;

                    case '\n':
                        return sb.ToString();

                    default:
                        sb.Append(c);
                        break;
                }
            }
            return sb.ToString();
        }
    }
}
