using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Housame_Oueslati_SUN16_tenta.Models
{
    class VIPTicket : Ticket
    {
       public enum Level
        {
            NoVIP = 1,
            miniVIP,
            VIP,
            maxVIP
        }
        public Level VIPLevel { get; set; }

        public override string PrintInfo()
        {
            if((int)VIPLevel==1)
                return base.PrintInfo() + string.Format(" No VIP at this ticket");
            else
            return base.PrintInfo()+ string.Format(" with a VIP level : {0}", VIPLevel);
        }

    }
}
