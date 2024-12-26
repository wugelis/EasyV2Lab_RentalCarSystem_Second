using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyArchitectV2Lab.AuthExtensions.Models
{
    public interface IAccountEnt
    {
        int Id { get; set; }
        string UserID { get; set; }
        string Password { get; set; }
        string AID { get; set; }
        string MobilePhone { get; set; }
        string ChtName { get; set; }
    }
}
