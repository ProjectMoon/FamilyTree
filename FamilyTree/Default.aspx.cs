
using System;
using System.Web;
using System.Web.UI;
using System.Data;
using MySql.Data.MySqlClient;

namespace FamilyTree
{
	
	
	public partial class Default : System.Web.UI.Page
	{
		
		public virtual void button1Clicked(object sender, EventArgs args)
		{
			button1.Text = "You clicked me";
			
			DataBaseFilter dbFilter = new DataBaseFilter("Server=localhost; Database=FamilyTree; User ID=paul; Password=");
			DataTable dbTable = dbFilter.ReadQuery("SELECT First_Name, Last_Name FROM Person");
			dgPeople.DataSource = dbTable;
			dgPeople.DataBind();
		}
	}
}
