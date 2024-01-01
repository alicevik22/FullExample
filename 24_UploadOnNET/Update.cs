using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace _24_UploadOnNET {
    class Update {

    }
    class Internet {
        public static bool Ok() {
            try {
                Dns.GetHostEntry("dotnet.beget.tech");
                return true;
            } catch {
                return false;
            }
        }
    }
}
