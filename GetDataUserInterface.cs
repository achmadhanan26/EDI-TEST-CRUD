using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserData
{
    [Serializable]
    public class UserData
    {
        int intUserId = 0;
        string szNamaLengkap = "";
        string szUserName = "";
        string szPassword = "";
        bool bStatus = false;

    }

    public interface IEDITGetDataUser
    {
        UserData getDataUser(int intUserId);
    }
}
