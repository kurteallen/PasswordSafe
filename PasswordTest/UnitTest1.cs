using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PasswordSafe;
using PasswordSafe.Model;

namespace PasswordTest
{
    [TestClass]
    public class UnitTest1
    {
        
        [TestMethod]
        public void ListSizeAddandRemove()
        {
            //arrange
            
            Accounts account = new Accounts("GMAIL",  "sunpack@rocketmail.com",  "sunpack", "this is the note");
            int expected  = 1;
            
            //act
            SingletonList.Instance.GetList.Add(account);

            //assert

            Assert.AreEqual(expected, SingletonList.Instance.GetList.Count, "Account Size incorrect");
        }

        [TestMethod]
        public void ListSizeAddandRemove2000()
        {
            //arrange
            Accounts[] j = new Accounts[2000];
            int expected = 2000;

            //act

            for (int i = 0; i < 2000; i++)
            {
                j[i] = new Accounts();
                j[i].Account = i.ToString();
                SingletonList.Instance.GetList.Add(j[i]);
            }

            //assert
            Assert.AreEqual(expected, SingletonList.Instance.GetList.Count);
                
                
        }
    }
}
