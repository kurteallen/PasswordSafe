using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PasswordSafe.Model;
using PasswordSafe;
using System.ComponentModel;
using PasswordSafe.View;

namespace PasswordSafe.Controller
{
    public class PasswordSafeController
    {

        
        AccountEntryView accountEntryView;
        DialogBox dialogBoxView;
       
        

       

        //Control section for the Account view list
        public PasswordSafeController(AccountEntryView accountEntryView)
        {
             this.accountEntryView = accountEntryView;
            
        }

        //Control section for the Password dialog box
        public PasswordSafeController(DialogBox dialogBoxView)
        {
             this.dialogBoxView = dialogBoxView;
            
        }

        public Boolean VerifyPassword(string password)
        {
            bool value = false;
            if(password.Equals("sunpack"))
                value = true;
            return value;
        }

        public String SaveAccount(string account, string userName, string password, string notes)
        {
            String s = "";
            Accounts a = new Accounts(account.Trim(),  userName,  password,  notes.Trim());
            
            if(!SingletonList.Instance.MyContains(a.Account))
                s = "Account already exists";
            
            
            return s;
        }

        public BindingList<Accounts> GetList()
        {
            return SingletonList.Instance.GetList;
        
        }
         
    }
}
