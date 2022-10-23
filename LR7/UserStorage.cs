using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR7
{
    internal class UserStorage
    {
        private Dictionary<AuthorizeInfo, UserInfo> data;

        public UserStorage()
        {
            data= new Dictionary<AuthorizeInfo, UserInfo>();
            data.Add(new AuthorizeInfo("Lera", "1"), new UserInfo("Oskokova V.E.", "oskolkova@mail.ru","Stavropol"));
            data.Add(new AuthorizeInfo("Vova", "2"), new UserInfo("Nekrut V.S.", "NekrutVS@mail.ru", "Stavropol"));
            data.Add(new AuthorizeInfo("Adam", "3"), new UserInfo("Zaigov A.D.", "ZaigovAD@yandex.ru", "Moscow"));
        }

        public UserInfo GetUser(AuthorizeInfo ob)
        {
            if(data.ContainsKey(ob)) return data[ob];
            else return null;
        }
    }
}
