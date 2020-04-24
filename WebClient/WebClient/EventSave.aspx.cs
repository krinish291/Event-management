using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebClient
{
    public partial class EventSave : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = "Your Message Appear Here";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ServiceReference1.Event E = new ServiceReference1.Event();
            E.Name = Name.Text;
            E.Strength = Convert.ToInt32(Strength.Text);
            E.Organizer_name = organizer.Text;
            E.Event_date =Convert.ToDateTime( Event_date.Text);
            E.Discription = dis.Text;
            E.Duraction = Convert.ToInt32(Duraction.Text);
            E.Registration_date = Convert.ToDateTime(Registration_date.Text);
            E.ContactNo = ContactNo.Text;
            E.is_group = Convert.ToBoolean(is_group.Checked);

            ServiceReference1.Service1Client sc = new ServiceReference1.Service1Client();
            ID.Text =sc.SaveEvent(E).ToString();
            Label1.Text = "Event Details Successfully Added with Id "+ID.Text;
            
            Name.Text = " ";
            Strength.Text = " ";
            organizer.Text = " ";
            Event_date.Text = " ";
            dis.Text = " ";
            Duraction.Text = " ";
            Registration_date.Text = " ";
            ContactNo.Text = " ";
            is_group.Checked = false;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            ServiceReference1.Service1Client sc = new ServiceReference1.Service1Client();
            ServiceReference1.Event E = sc.Show_event(Convert.ToInt32(ID.Text));
            if (E.Name== null)
            {
                Label1.Text = "Event Not Found";
                Name.Text = " ";
                Strength.Text = " ";
                organizer.Text = " ";
                Event_date.Text = " ";
                dis.Text = " ";
                Duraction.Text =" ";
                Registration_date.Text = " ";
                ContactNo.Text =" ";
                is_group.Checked = E.is_group;
            }
            else
            {
                Name.Text = E.Name;
                Strength.Text = E.Strength.ToString();
                organizer.Text = E.Organizer_name;
                Event_date.Text = E.Event_date.ToShortDateString();
                dis.Text = E.Discription;
                Duraction.Text = E.Duraction.ToString();
                Registration_date.Text = E.Registration_date.ToShortDateString();
                ContactNo.Text = E.ContactNo;
                is_group.Checked = E.is_group;
                Label1.Text = "Event Successfully Retrieved";
            }
            

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            ServiceReference1.Service1Client sc = new ServiceReference1.Service1Client();
            string E = sc.DeleteEvent(Convert.ToInt32(ID.Text));
            Label1.Text = "Event Successfully Deleted";
            Name.Text = " ";
            Strength.Text = " ";
            organizer.Text = " ";
            Event_date.Text = " ";
            dis.Text = " ";
            Duraction.Text = " ";
            Registration_date.Text = " ";
            ContactNo.Text = " ";
            is_group.Checked = false;
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            ServiceReference1.Event E = new ServiceReference1.Event();
            E.Id = Convert.ToInt32(ID.Text);
            E.Name = Name.Text;
            E.Strength = Convert.ToInt32(Strength.Text);
            E.Organizer_name = organizer.Text;
            E.Event_date = Convert.ToDateTime(Event_date.Text);
            E.Discription = dis.Text;
            E.Duraction = Convert.ToInt32(Duraction.Text);
            E.Registration_date = Convert.ToDateTime(Registration_date.Text);
            E.ContactNo = ContactNo.Text;
            E.is_group = Convert.ToBoolean(is_group.Checked);

            ServiceReference1.Service1Client sc = new ServiceReference1.Service1Client();
            sc.UpdateEvent(E);
            Label1.Text = "Event Update Successfully";
            Name.Text = " ";
            Strength.Text = " ";
            organizer.Text = " ";
            Event_date.Text = " ";
            dis.Text = " ";
            Duraction.Text = " ";
            Registration_date.Text = " ";
            ContactNo.Text = " ";
            is_group.Checked = false;
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            Name.Text = " ";
            Strength.Text = " ";
            organizer.Text = " ";
            Event_date.Text = " ";
            dis.Text = " ";
            Duraction.Text = " ";
            Registration_date.Text = " ";
            ContactNo.Text = " ";
            is_group.Checked = false;
            ID.Text = " ";

        }
    }
}