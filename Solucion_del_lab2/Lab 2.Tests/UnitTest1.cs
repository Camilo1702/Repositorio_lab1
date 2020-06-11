using System;
using Lab_2.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PreParcial1.Tests
{
    [TestClass]
    public class UnitTestFriend
    {
        [TestMethod]
        public void TestMethodGetFriends()
        {
            //arrange
            FriendsController friendcontroller = new FriendsController();
            //act
            var friends = friendcontroller.GetFriends();
            //assert
            Assert.IsNotNull(friends);


        }
    }
}
