using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace BookStoreLIB
{
    [TestClass]// White box testing A3
    public class UnitTest2
    {
        UserData userData = new UserData();
        string inputName, inputPassword;
        int actualUserId;

        [TestMethod]
        public void TestMethod1() //IF1 Empty [T] Empty [T]
        {
            //specify the value of test inputs
            inputName = "";
            inputPassword = "";
            //specify the value of expected outputs
            Boolean expectedReturn = false;
            int expectedUserId = -1;
            //obtain the actual outputs by calling the method under testing
            Boolean actualReturn = userData.LogIn(inputName, inputPassword);
            actualUserId = userData.UserID;
            //verify the result
            Assert.AreEqual(expectedReturn, actualReturn);
            Assert.AreEqual(expectedUserId, actualUserId);

        }
        [TestMethod]
        public void TestMethod2() //IF1 Empty[F] Empty [T]
        {
            //specify the value of test inputs
            inputName = "Simon31";
            inputPassword = "";
            //specify the value of expected outputs
            Boolean expectedReturn = false;
            int expectedUserId = 1;
            //obtain the actual outputs by calling the method under testing
            Boolean actualReturn = userData.LogIn(inputName, inputPassword);
            actualUserId = userData.UserID;
            //verify the result
            Assert.AreEqual(expectedReturn, actualReturn);
            Assert.AreEqual(expectedUserId, actualUserId);

        }
        [TestMethod]
        public void TestMethod3() //IF1 Empty[T] Empty[F]
        {
            //specify the value of test inputs
            inputName = "";
            inputPassword = "As1234";
            //specify the value of expected outputs
            Boolean expectedReturn = false;
            int expectedUserId = -1;
            //obtain the actual outputs by calling the method under testing
            Boolean actualReturn = userData.LogIn(inputName, inputPassword);
            actualUserId = userData.UserID;
            //verify the result
            Assert.AreEqual(expectedReturn, actualReturn);
            Assert.AreEqual(expectedUserId, actualUserId);

        }
        [TestMethod]
        public void TestMethod4() //IF2 Valid Username [F]
        {
            //specify the value of test inputs
            inputName = "mon123";
            inputPassword = "As1234";
            //specify the value of expected outputs
            Boolean expectedReturn = false;
            int expectedUserId = -1;
            //obtain the actual outputs by calling the method under testing
            Boolean actualReturn = userData.LogIn(inputName, inputPassword);
            actualUserId = userData.UserID;
            //verify the result
            Assert.AreEqual(expectedReturn, actualReturn);
            Assert.AreEqual(expectedUserId, actualUserId);

        }
        [TestMethod]
        public void TestMethod5() //IF3 Valid input [F]
        {
            //specify the value of test inputs
            inputName = "Simon31";
            inputPassword = "2$4739";
            //specify the value of expected outputs
            Boolean expectedReturn = false;
            int expectedUserId = 1;
            //obtain the actual outputs by calling the method under testing
            Boolean actualReturn = userData.LogIn(inputName, inputPassword);
            actualUserId = userData.UserID;
            //verify the result
            Assert.AreEqual(expectedReturn, actualReturn);
            Assert.AreEqual(expectedUserId, actualUserId);

        }
        [TestMethod]
        public void TestMethod6() //IF4 Corresponding Password [F]
        {
            //specify the value of test inputs
            inputName = "Simon31";
            inputPassword = "As3122";
            //specify the value of expected outputs
            Boolean expectedReturn = false;
            int expectedUserId = 1;
            //obtain the actual outputs by calling the method under testing
            Boolean actualReturn = userData.LogIn(inputName, inputPassword);
            actualUserId = userData.UserID;
            //verify the result
            Assert.AreEqual(expectedReturn, actualReturn);
            Assert.AreEqual(expectedUserId, actualUserId);

        }

    }
}
