using AA.Common;
using AA.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AA.Common.Tests
{

    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClass]
    public class GuardTests
    {
        [TestMethod]
        public void Guard_AgainstNull_MustPassInputStringThatIsNotEmptyOrNull()
        {
            // arrange
            string item = "my item";
            string testString = "I am not null or empty";

            // act
            Guard.AgainstNull(item, testString);

            // assert
            // not required
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Account number is null or empty.")]
        public void Guard_AgainstNull_MustFailInputStringThatIsNull()
        {
            // arrange
            // none required    

            // act
            Account account = new Account(null);

            // assert
            // none required
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Account number is null or empty.")]
        public void Guard_AgainstNull_MustFailInputStringThatIsEmpty()
        {
            // arrange
            string emptyString = "";

            // act
            Account account = new Account(emptyString);

            // assert
            // none required
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Account number is null or empty.")]
        public void Guard_AgainstNullEmptyWhiteSpace
            ()
        {
            // arrange
            string whiteSpace = " ";

            // act
            Account account = new Account(whiteSpace);

            // assert
            // none required
        }

        [TestMethod]
        public void Guard_AgainstIncorrectLength_CorrectLength()
        {
            // arrange
            string item = "my item";
            string rightLength = "12";

            // act
            Guard.AgainstIncorrectLength(item, rightLength, 2);
            
            // assert
            // not required
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Account number is too long.")]
        public void Guard_AgainstIncorrectLength_LengthTooLong()
        {
            // arrange
            string item = "my item";
            string inputString = "12";

            // act
            Guard.AgainstIncorrectLength(item, inputString, 1);

            // assert
            // not required
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Account number is too short.")]
        public void Guard_AgainstIncorrectLength_LengthTooShort()
        {
            // arrange
            string item = "my item";
            string inputString = "12";

            // act
            Guard.AgainstIncorrectLength(item, inputString, 3);

            // assert
            // not required
        }
    }
}
