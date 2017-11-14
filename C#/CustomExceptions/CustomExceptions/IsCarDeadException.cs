using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomExceptions
{
    public class IsCarDeadException:Exception
    {
        public IsCarDeadException()
    {
    }

    public IsCarDeadException(string message)
        : base(message)
    {
    }

    }

}
