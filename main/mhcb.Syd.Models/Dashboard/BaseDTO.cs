using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace mhcb.Syd.Models.Dashboard
{
    public class BaseDTO
    {
        public BaseDTO()
        {
        }

        //**************************************************************
        // Need to append to each entity for display / debug
        //**************************************************************
        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendFormat("Type: {0}\n", this.GetType().Name);

            PropertyInfo[] props = this.GetType().GetProperties();

            // using array for each
            Array.ForEach(props.ToArray(), prop => builder.AppendFormat("{0} : {1}",
                    prop.Name,
                    prop.GetValue(this, null) == null ? "<empty>\n" : prop.GetValue(this, null).ToString() + "\n"));

            return builder.ToString();
        }
    }
}
