using System;
using System.Collections.Generic;
using System.Text;

namespace BreastRadiology.XUnitTests
{
    public class SEText
    {
        public String Text { get; set; }
        public String HRef { get; set; }
        public String Title { get; set; }

        public SEText(String text, String hRef = null, String title = null)
        {
            this.Text = text;
            this.HRef = hRef;
            this.Title = title;
        }

        public SEText()
        {
        }
    }
}