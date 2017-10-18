using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvigilonProject.BuisnessLayer.Model
{
    public interface IAddIP
    {
        List<IpModelBl> ReadIp();
        void RemoveIp(string ips);
    }
}
