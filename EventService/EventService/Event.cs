using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventService
{
    public class Event
    {
        private int _id;
        private string _Name;
        private int _Strength;
        private bool _is_group;
        private string _Organizer_name;
        private DateTime _Event_date;
        private string _Discription;
        private int _Duraction;
        private DateTime _Registration_date;
        private string _ContactNo;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        public int Strength
        {
            get { return _Strength; }
            set { _Strength = value; }
        }

        public bool is_group
        {
            get { return _is_group; }
            set { _is_group = value; }
        }

        public string Organizer_name
        {
            get { return _Organizer_name; }
            set { _Organizer_name = value; }
        }

        public DateTime Event_date
        {
            get { return _Event_date; }
            set { _Event_date = value; }
        }

        public string Discription
        {
            get { return _Discription; }
            set { _Discription = value; }
        }

        public int Duraction
        {
            get { return _Duraction; }
            set { _Duraction = value; }
        }

        public DateTime Registration_date
        {
            get { return _Registration_date; }
            set { _Registration_date = value; }
        }

        public string ContactNo
        {
            get { return _ContactNo; }
            set { _ContactNo = value; }
        }
    }


}
