using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace BookStoreLIB
{
    [TestClass]
    public class UnitTest1
    {
        UserData userData = new UserData();
        string inputName, inputPassword;
        int actualUserId;

        [TestMethod] 
        public void TestMethod1() //Tests to see if it can accurately log someone in - True
        {
            //specify the value of test inputs
            inputName = "simon31";
            inputPassword = "as1234";
            //specify the value of expected outputs
            Boolean expectedReturn = true;
            int expectedUserId = 1;
            //obtain the actual outputs by calling the method under testing
            Boolean actualReturn = userData.LogIn(inputName, inputPassword);
            actualUserId = userData.UserID;
            //verify the result
            Assert.AreEqual(expectedReturn, actualReturn);
            Assert.AreEqual(expectedUserId, actualUserId);

        }
        [TestMethod]
        public void TestMethod2() //checks to see if it detects an empty password - False
        {
            //specify the value of test inputs
            inputName = "simon31";
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
        public void TestMethod3() //Checks for correct password - False
        {
            //specify the value of test inputs
            inputName = "simon31";
            inputPassword = "Sm1234";
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
        public void TestMethod4() //Tests if it notices invalid symbols - False
        {
            //specify the value of test inputs
            inputName = "simon31";
            inputPassword = "As1234-";
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
        public void TestMethod5() //Tests if it notices first character being a letter or not - False
        {
            //specify the value of test inputs
            inputName = "simon31";
            inputPassword = "1As1234";
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
        public void TestMethod6() //Tests if it notices wrong/invalid username - False
        {
            //specify the value of test inputs
            inputName = "imon31";
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
        public void TestMethod7() //Notices no username 
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
        public void TestMethod8() //Notices a lack of numbers
        {
            //specify the value of test inputs
            inputName = "Simon31";
            inputPassword = "abcdef";
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
        public void TestMethod9() //Tests if it notices aa lack of letters
        {
            //specify the value of test inputs
            inputName = "Simon31";
            inputPassword = "123456";
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
        public void TestMethod10() //Tests if it notices a too short password
        {
            //specify the value of test inputs
            inputName = "Simon31";
            inputPassword = "As12";
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
