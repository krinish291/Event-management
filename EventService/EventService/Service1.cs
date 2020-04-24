using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace EventService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Service1 : IService1
    {
        
        public Event Show_event(int Id)
        {
            Event E = new Event();
            string cs = @"Data Source=(localdb)\ProjectsV13;Initial Catalog=Event;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "Select * From Event Where Id=@Id";
                SqlParameter parameterId = new SqlParameter();
                parameterId.ParameterName = "@Id";
                parameterId.Value = Id;
                cmd.Parameters.Add(parameterId);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    E.Id = Convert.ToInt32(reader["Id"]);
                    E.Name = reader["Name"].ToString();
                    E.Strength = Convert.ToInt32(reader["Strength"]);
                    E.is_group = Convert.ToBoolean(reader["is_group"]);
                    E.Event_date = Convert.ToDateTime(reader["Event_date"]);
                    E.Organizer_name = reader["Organizer_name"].ToString();
                    E.Discription = reader["Discription"].ToString();
                    E.Duraction = Convert.ToInt32(reader["Duraction"]);
                    E.Registration_date = Convert.ToDateTime(reader["Registration_date"]);
                    E.ContactNo = reader["ContactNo"].ToString();
                }
            }
            return E;
        }

        public int SaveEvent(Event e)
        {
            int i = 0;
            string cs = @"Data Source=(localdb)\ProjectsV13;Initial Catalog=Event;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "Insert into Event(Name,Strength,is_group,Event_date,Organizer_name,Discription,Duraction,Registration_date,ContactNo ) values (@Name,@Strength,@is_group,@Event_date,@Organizer_name,@Discription,@Duraction,@Registration_date,@ContactNo);SELECT SCOPE_IDENTITY()";
                cmd.Parameters.AddWithValue("@Name", e.Name);
                cmd.Parameters.AddWithValue("@Strength", e.Strength);
                cmd.Parameters.AddWithValue("@Event_date", e.Event_date);
                cmd.Parameters.AddWithValue("@is_group", e.is_group);
                cmd.Parameters.AddWithValue("@Organizer_name", e.Organizer_name);
                cmd.Parameters.AddWithValue("@Discription", e.Discription);
                cmd.Parameters.AddWithValue("@Duraction", e.Duraction);
                cmd.Parameters.AddWithValue("@Registration_date", e.Registration_date);
                cmd.Parameters.AddWithValue("@ContactNo", e.ContactNo);
                con.Open();
                //cmd.ExecuteNonQuery();
                int modified = Convert.ToInt32(cmd.ExecuteScalar());

                if (con.State == System.Data.ConnectionState.Open) con.Close();
                return modified;
            }
   
        }

        public void UpdateEvent(Event e) 
        {

            string cs = @"Data Source=(localdb)\ProjectsV13;Initial Catalog=Event;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "update Event set Name = @Name ,Strength = @Strength,is_group = @is_group ,Event_date = @Event_date,Organizer_name = @Organizer_name,Discription = @Discription,Duraction = @Duraction,Registration_date = @Registration_date,ContactNo = @ContactNo  Where Id = @Id";
                cmd.Parameters.AddWithValue("@Id", e.Id);
                cmd.Parameters.AddWithValue("@Name", e.Name);
                cmd.Parameters.AddWithValue("@Strength", e.Strength);
                cmd.Parameters.AddWithValue("@Event_date", e.Event_date);
                cmd.Parameters.AddWithValue("@is_group", e.is_group);
                cmd.Parameters.AddWithValue("@Organizer_name", e.Organizer_name);
                cmd.Parameters.AddWithValue("@Discription", e.Discription);
                cmd.Parameters.AddWithValue("@Duraction", e.Duraction);
                cmd.Parameters.AddWithValue("@Registration_date", e.Registration_date);
                cmd.Parameters.AddWithValue("@ContactNo", e.ContactNo);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }

        }

        public string DeleteEvent(int Id)
        {
            Event E = new Event();
            string cs = @"Data Source=(localdb)\ProjectsV13;Initial Catalog=Event;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "delete from Event where ID=@Id";
                cmd.Parameters.AddWithValue("@ID", Id);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
            return "record delete successfully";
        }

        public DataSet Events()
        {
            SqlConnection con = new SqlConnection(@"Data Source=(localdb)\ProjectsV13;Initial Catalog=Event;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from Event", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            cmd.ExecuteNonQuery();
            con.Close();
            return ds;
        }
    }
}
