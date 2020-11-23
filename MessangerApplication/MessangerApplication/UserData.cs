using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessangerApplication
{
    class UserData
    {
        private string userId;

        public string getUserId()
        {
            return userId;
        }

        public void setUserId(string userId)
        {
            this.userId = userId;
        }
    }
}
