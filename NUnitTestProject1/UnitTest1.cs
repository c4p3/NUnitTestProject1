using NUnit.Framework;
/*
 * Made by Caja & Nicklas for SoftDevTest19
 * Check out the "about.txt" file for more info!
 */
namespace Tests
{
    //
    public class Tests
    {
        //All the tests. Does the input grade equals 
        //the correct value in the new scale?
        [Test]
        public void TestGrade13()
        {       
            var result = ConvertGrade(13);
            Assert.AreEqual(result, 12);
        }
        [Test]
        public void TestGrade11()
        {
            var result = ConvertGrade(11);
            Assert.AreEqual(result, 12);
        }
        [Test]
        public void TestGrade10()
        {
            var result = ConvertGrade(10);
            Assert.AreEqual(result, 10);
        }
        [Test]
        public void TestGrade9()
        {
            var result = ConvertGrade(9);
            Assert.AreEqual(result, 7);
        }
        [Test]
        public void TestGrade8()
        {
            var result = ConvertGrade(8);
            Assert.AreEqual(result, 7);
        }
        [Test]
        public void TestGrade7()
        {
            var result = ConvertGrade(7);
            Assert.AreEqual(result, 4);
        }
        [Test]
        public void TestGrade6()
        {
            var result = ConvertGrade(6);
            Assert.AreEqual(result, 02);
        }
        [Test]
        public void TestGrade5()
        {
            var result = ConvertGrade(6);
            Assert.AreEqual(result, 02);
        }
        [Test]
        public void TestGrade03()
        {
            var result = ConvertGrade(03);
            Assert.AreEqual(result, 00);
        }
        [Test]
        public void TestGrade00()
        {
            var result = ConvertGrade(00);
            Assert.AreEqual(result, -3);
        }
        //This test shows that it uses the ConvertGrade method
        //since input and result in NOT equal. 
        [Test]
        public void TestGradeFails()
        {
            int result = ConvertGrade(13);
            Assert.AreNotEqual(result, 13);
        }

        //Our test logic. If input is 13, it should return 12. 
        public int ConvertGrade(int a)
        {
            switch (a)
            {
                case 13:
                case 11: 
                    return 12;
                case 10:
                    return 10;
                case 9:
                case 8:
                    return 7;
                case 7:
                    return 4;
                case 6:
                    return 02;
                case 5:
                case 03:
                    return 00;
                case 00:
                    return -3;
                default:
                    break;
            }

            return -1;
        }

    }
}
