using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseLog_Conjuntos.Entities
{
    class CourseLog
    {
        public int Registration { get; set; }

        public CourseLog(int registration)
        {
            Registration = registration;
        }

        public override int GetHashCode()
        {
            return Registration.GetHashCode();
        }

        public override bool Equals(object obj)
        {
           if(!(obj is CourseLog))
            {
                return false;
            }
            CourseLog other = obj as CourseLog;
            return Registration.Equals(other.Registration);
        }
    }
}
