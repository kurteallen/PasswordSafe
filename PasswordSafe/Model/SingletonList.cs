using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordSafe.Model
{
    public class SingletonList
    {
       private static SingletonList instance;
       private string passText = null;
       //BindingList automatically updates the list box when the list changes
       private static BindingList<Accounts> _list = null;

       

       private SingletonList()
       {
           if(_list == null)
               _list = new BindingList<Accounts>();
       }

       public static SingletonList Instance
       {
           get
           {
               if (instance == null)
                   lock (typeof(SingletonList))
                       instance = new SingletonList();
               return instance;
           }
       }

       public Boolean MyContains(string a) 
       {
           bool value = false;
           if (_list.Any(l => l.Account.Equals(a)))
               value = true;
           return value;
       }
       
        


       public Boolean add(Accounts a)
       {
           bool b = false;
           if (!_list.Any(l => l.Account.Equals(a.Account)))
           {
               _list.Add(a);
               b = true;
           }

           System.Console.WriteLine("This is the number of items " + _list.Count);
           return b;
       }
       
        public string PassText
       {
           get { return this.passText; }
           set { this.passText = value; }
       }
       
       public BindingList<Accounts> GetList
        {
            get
            {
                return _list;
            }
            set
            {
                _list = value;
            }
        }

    }
   
}
