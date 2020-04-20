using System;
using NUnit;
using NUnit.Framework;

namespace IP_Address_Validator
{
    [TestFixture]
    public class IP_Address_Validator
    {
        [Test]
        public void IPv4_Address1ShouldReturnTrue()
        {
            //arrange
            var ipAddress= "1.1.1.1";
            //act
            var expected = true;
            var actual = ValidateIpv4Address(ipAddress);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void IPv4_Address2ShouldReturnTrue()
        {
            //arrange
            var ipAddress = "192.168.1.1";
            //act
            var expected = true;
            var actual = ValidateIpv4Address(ipAddress);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void IPv4_Address3ShouldReturnTrue()
        {
            //arrange
            var ipAddress = "10.0.0.1";
            //act
            var expected = true;
            var actual = ValidateIpv4Address(ipAddress);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void IPv4_Address4ShouldReturnTrue()
        {
            //arrange
            var ipAddress = "127.0.0.1";
            //act
            var expected = true;
            var actual = ValidateIpv4Address(ipAddress);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void IPv4_Address5ShouldReturnFalse()
        {
            //arrange
            var ipAddress = "0.0.0.0";
            //act
            var expected = false;
            var actual = ValidateIpv4Address(ipAddress);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void IPv4_Address6ShouldReturnFalse ()
        {
            //arrange
            var ipAddress = "255.255.255.255";
            //act
            var expected = false;
            var actual = ValidateIpv4Address(ipAddress);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void IPv4_Address7ShouldReturnFalse()
        {
            //arrange
            var ipAddress = "1.1.1.0";
            //act
            var expected = false;
            var actual = ValidateIpv4Address(ipAddress);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void IPv4_Address8ShouldReturnFalse()
        {
            //arrange
            var ipAddress = "10.0.1";
            //act
            var expected = false;
            var actual = ValidateIpv4Address(ipAddress);

            //assert
            Assert.AreEqual(expected, actual);
        }

        private bool ValidateIpv4Address(string ipAddress)
        {
            
            string lastThreeDigits = ipAddress.Substring(ipAddress.Length - 3);
            char lastDigitIp = Convert.ToChar(lastThreeDigits[2]);

            if (lastThreeDigits.Contains("255") || lastDigitIp == '0'|| ipAddress.Split('.').Length < 4 )
                return false;
            else
                return true;
        }
    }
}
