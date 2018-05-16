using StrongTypeSession.Models;
using System;
using System.Web.UI;

namespace StrongTypeSession
{
    public partial class Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Member.Current.Name = "Vincent";
            Member.Current.Age++;

            Response.Write($"Name:{Member.Current.Name}, Age:{Member.Current.Age}");
        }
    }
}