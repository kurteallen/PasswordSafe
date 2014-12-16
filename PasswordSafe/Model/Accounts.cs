using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordSafe.Model
{
    [Serializable]
    public class Accounts : IAccounts, IComparable<Accounts>, IComparer<Accounts>
    {
        #region IAccounts Members
        private string account;
        private string userName;
        private string password;
        private string notes;

        public Accounts()
        {
        }

        public Accounts(string account, string userName, string password, string notes)
        {
            this.account = account;
            this.userName = userName;
            this.password = password;
            this.notes = notes;
        }

        public Accounts(Accounts a)
        {
            this.account = a.account;
            this.userName = a.userName;
            this.password = a.password;
            this.notes = a.notes;
        }


        public string Account
        {
            get
            {
                return this.account;

            }
            set
            {
                this.account = value;
            }
        }

        public string UserName
        {
            get
            {
                return this.userName;
            }
            set
            {
                this.userName = value;
            }
        }

        public string Password
        {
            get
            {
                return password;
            }
            set
            {
                this.password = value;
            }
        }

        public string Notes
        {
            get
            {
                return notes;
            }
            set
            {
                this.notes = value;
            }
        }
        
        #endregion

        public int CompareTo(Accounts other)
        {
           
            return String.Compare(this.Account, other.Account);
        }

        
        public int Compare(Accounts x, Accounts y)
        {
           return (x.Account.CompareTo(y.Account));
        }

      
    }
}
