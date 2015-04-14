using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ScoresWare_Desktop
{
    public class UserManager
    {
        public int current_UID = -1;
        public string current_username = "";
        private bool login = false;

        public void Login() {
            this.login = true;
        }

        public void Logout()
        {
            this.login = false;
            this.current_UID = 0;
            this.current_username = "";
        }

        public bool getLoginStatus()
        {
            return this.login;
        }
    }
}
