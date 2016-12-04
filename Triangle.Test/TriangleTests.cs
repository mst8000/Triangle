using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Triangle.Tests
{

    [TestClass()]
    public class TriangleTests
    {

        //{}
        [TestMethod()]
        public void AllNullTest()
        {
            var args = new string[] { };

            int result; //結果を格納する変数
            bool wasThrown = false;

            var triangle = new Triangle();
            try
            {
                triangle.CheckArgs(args);

                //引数を整数値に変換
                int a = int.Parse(args[0]);
                int b = int.Parse(args[1]);
                int c = int.Parse(args[2]);

                //三角形判定
                result = triangle.TriangleType(a, b, c);
            }
            catch (IndexOutOfRangeException)
            {
                wasThrown = true;
            }

            Assert.IsTrue(wasThrown);
        }

        //{6}
        [TestMethod()]
        public void Null2Test()
        {
            var args = new string[] { "6" };

            int result; //結果を格納する変数
            bool wasThrown = false;

            var triangle = new Triangle();
            try
            {
                triangle.CheckArgs(args);

                //引数を整数値に変換
                int a = int.Parse(args[0]);
                int b = int.Parse(args[1]);
                int c = int.Parse(args[2]);

                //三角形判定
                result = triangle.TriangleType(a, b, c);
            }
            catch (IndexOutOfRangeException)
            {
                wasThrown = true;
            }

            Assert.IsTrue(wasThrown);
        }

        //{6, 6}
        [TestMethod()]
        public void Null1Test()
        {
            var args = new string[] { "6", "6" };

            int result; //結果を格納する変数
            bool wasThrown = false;

            var triangle = new Triangle();
            try
            {
                triangle.CheckArgs(args);

                //引数を整数値に変換
                int a = int.Parse(args[0]);
                int b = int.Parse(args[1]);
                int c = int.Parse(args[2]);

                //三角形判定
                result = triangle.TriangleType(a, b, c);
            }
            catch (IndexOutOfRangeException)
            {
                wasThrown = true;
            }

            Assert.IsTrue(wasThrown);
        }

        //{0, 0, 0}
        [TestMethod()]
        public void AllZeroTest()
        {
            var args = new string[] { "0", "0", "0" };

            int result; //結果を格納する変数
            bool wasThrown = false;

            var triangle = new Triangle();
            try
            {
                triangle.CheckArgs(args);

                //引数を整数値に変換
                int a = int.Parse(args[0]);
                int b = int.Parse(args[1]);
                int c = int.Parse(args[2]);

                //三角形判定
                result = triangle.TriangleType(a, b, c);
            }
            catch (ArgumentOutOfRangeException)
            {
                wasThrown = true;
            }

            Assert.IsTrue(wasThrown);
        }

        //{6, 6, 0}
        [TestMethod()]
        public void Zero1Test1()
        {
            var args = new string[] { "6", "6", "0" };

            int result; //結果を格納する変数
            bool wasThrown = false;

            var triangle = new Triangle();
            try
            {
                triangle.CheckArgs(args);

                //引数を整数値に変換
                int a = int.Parse(args[0]);
                int b = int.Parse(args[1]);
                int c = int.Parse(args[2]);

                //三角形判定
                result = triangle.TriangleType(a, b, c);
            }
            catch (ArgumentOutOfRangeException)
            {
                wasThrown = true;
            }

            Assert.IsTrue(wasThrown);
        }

        //{6, 0, 6}
        [TestMethod()]
        public void Zero1Test2()
        {
            var args = new string[] { "6", "0", "6" };

            int result; //結果を格納する変数
            bool wasThrown = false;

            var triangle = new Triangle();
            try
            {
                triangle.CheckArgs(args);

                //引数を整数値に変換
                int a = int.Parse(args[0]);
                int b = int.Parse(args[1]);
                int c = int.Parse(args[2]);

                //三角形判定
                result = triangle.TriangleType(a, b, c);
            }
            catch (ArgumentOutOfRangeException)
            {
                wasThrown = true;
            }

            Assert.IsTrue(wasThrown);
        }

        //{0, 6, 6}
        [TestMethod()]
        public void Zero1Test3()
        {
            var args = new string[] { "0", "6", "6" };

            int result; //結果を格納する変数
            bool wasThrown = false;

            var triangle = new Triangle();
            try
            {
                triangle.CheckArgs(args);

                //引数を整数値に変換
                int a = int.Parse(args[0]);
                int b = int.Parse(args[1]);
                int c = int.Parse(args[2]);

                //三角形判定
                result = triangle.TriangleType(a, b, c);
            }
            catch (ArgumentOutOfRangeException)
            {
                wasThrown = true;
            }

            Assert.IsTrue(wasThrown);
        }

        //{-1, -1, -1}
        [TestMethod()]
        public void AllMinusTest()
        {
            var args = new string[] { "-1", "-1", "-1" };

            int result; //結果を格納する変数
            bool wasThrown = false;

            var triangle = new Triangle();
            try
            {
                triangle.CheckArgs(args);

                //引数を整数値に変換
                int a = int.Parse(args[0]);
                int b = int.Parse(args[1]);
                int c = int.Parse(args[2]);

                //三角形判定
                result = triangle.TriangleType(a, b, c);
            }
            catch (ArgumentOutOfRangeException)
            {
                wasThrown = true;
            }

            Assert.IsTrue(wasThrown);
        }

        //{6, 6, -1}
        [TestMethod()]
        public void Minus1Test1()
        {
            var args = new string[] { "6", "6", "-1" };

            int result; //結果を格納する変数
            bool wasThrown = false;

            var triangle = new Triangle();
            try
            {
                triangle.CheckArgs(args);

                //引数を整数値に変換
                int a = int.Parse(args[0]);
                int b = int.Parse(args[1]);
                int c = int.Parse(args[2]);

                //三角形判定
                result = triangle.TriangleType(a, b, c);
            }
            catch (ArgumentOutOfRangeException)
            {
                wasThrown = true;
            }

            Assert.IsTrue(wasThrown);
        }

        //{6, -1, 6}
        [TestMethod()]
        public void Minus1Test2()
        {
            var args = new string[] { "6", "-1", "6" };

            int result; //結果を格納する変数
            bool wasThrown = false;

            var triangle = new Triangle();
            try
            {
                triangle.CheckArgs(args);

                //引数を整数値に変換
                int a = int.Parse(args[0]);
                int b = int.Parse(args[1]);
                int c = int.Parse(args[2]);

                //三角形判定
                result = triangle.TriangleType(a, b, c);
            }
            catch (ArgumentOutOfRangeException)
            {
                wasThrown = true;
            }

            Assert.IsTrue(wasThrown);
        }

        //{-1, 6, 6}
        [TestMethod()]
        public void Minus1Test3()
        {
            var args = new string[] { "-1", "6", "6" };

            int result; //結果を格納する変数
            bool wasThrown = false;

            var triangle = new Triangle();
            try
            {
                triangle.CheckArgs(args);

                //引数を整数値に変換
                int a = int.Parse(args[0]);
                int b = int.Parse(args[1]);
                int c = int.Parse(args[2]);

                //三角形判定
                result = triangle.TriangleType(a, b, c);
            }
            catch (ArgumentOutOfRangeException)
            {
                wasThrown = true;
            }

            Assert.IsTrue(wasThrown);
        }

        //{a, a, a}
        [TestMethod()]
        public void AllCharTest1()
        {
            var args = new string[] { "a", "a", "a" };

            int result; //結果を格納する変数
            bool wasThrown = false;

            var triangle = new Triangle();
            try
            {
                triangle.CheckArgs(args);

                //引数を整数値に変換
                int a = int.Parse(args[0]);
                int b = int.Parse(args[1]);
                int c = int.Parse(args[2]);

                //三角形判定
                result = triangle.TriangleType(a, b, c);
            }
            catch (ArgumentException)
            {
                wasThrown = true;
            }

            Assert.IsTrue(wasThrown);
        }

        //{6, 6, a}
        [TestMethod()]
        public void Char1Test1()
        {
            var args = new string[] { "6", "6", "a" };

            int result; //結果を格納する変数
            bool wasThrown = false;

            var triangle = new Triangle();
            try
            {
                triangle.CheckArgs(args);

                //引数を整数値に変換
                int a = int.Parse(args[0]);
                int b = int.Parse(args[1]);
                int c = int.Parse(args[2]);

                //三角形判定
                result = triangle.TriangleType(a, b, c);
            }
            catch (ArgumentException)
            {
                wasThrown = true;
            }

            Assert.IsTrue(wasThrown);
        }

        //{6, a, 6}
        [TestMethod()]
        public void Char1Test2()
        {
            var args = new string[] { "6", "a", "6" };

            int result; //結果を格納する変数
            bool wasThrown = false;

            var triangle = new Triangle();
            try
            {
                triangle.CheckArgs(args);

                //引数を整数値に変換
                int a = int.Parse(args[0]);
                int b = int.Parse(args[1]);
                int c = int.Parse(args[2]);

                //三角形判定
                result = triangle.TriangleType(a, b, c);
            }
            catch (ArgumentException)
            {
                wasThrown = true;
            }

            Assert.IsTrue(wasThrown);
        }

        //{a, 6, 6}
        [TestMethod()]
        public void Char1Test3()
        {
            var args = new string[] { "a", "6", "6" };

            int result; //結果を格納する変数
            bool wasThrown = false;

            var triangle = new Triangle();
            try
            {
                triangle.CheckArgs(args);

                //引数を整数値に変換
                int a = int.Parse(args[0]);
                int b = int.Parse(args[1]);
                int c = int.Parse(args[2]);

                //三角形判定
                result = triangle.TriangleType(a, b, c);
            }
            catch (ArgumentException)
            {
                wasThrown = true;
            }

            Assert.IsTrue(wasThrown);
        }

        //{6, 4, 2}
        [TestMethod()]
        public void BeLineTest1()
        {
            var args = new string[] { "6", "4", "2" };

            int result; //結果を格納する変数
            bool wasThrown = false;

            var triangle = new Triangle();
            try
            {
                triangle.CheckArgs(args);

                //引数を整数値に変換
                int a = int.Parse(args[0]);
                int b = int.Parse(args[1]);
                int c = int.Parse(args[2]);

                //三角形判定
                result = triangle.TriangleType(a, b, c);
            }
            catch (ArgumentException)
            {
                wasThrown = true;
            }

            Assert.IsTrue(wasThrown);
        }

        //{2, 6, 4}
        [TestMethod()]
        public void BeLineTest2()
        {
            var args = new string[] { "2", "6", "4" };

            int result; //結果を格納する変数
            bool wasThrown = false;

            var triangle = new Triangle();
            try
            {
                triangle.CheckArgs(args);

                //引数を整数値に変換
                int a = int.Parse(args[0]);
                int b = int.Parse(args[1]);
                int c = int.Parse(args[2]);

                //三角形判定
                result = triangle.TriangleType(a, b, c);
            }
            catch (ArgumentException)
            {
                wasThrown = true;
            }

            Assert.IsTrue(wasThrown);
        }

        //{4, 2, 6}
        [TestMethod()]
        public void BeLineTest3()
        {
            var args = new string[] { "4", "2", "6" };

            int result; //結果を格納する変数
            bool wasThrown = false;

            var triangle = new Triangle();
            try
            {
                triangle.CheckArgs(args);

                //引数を整数値に変換
                int a = int.Parse(args[0]);
                int b = int.Parse(args[1]);
                int c = int.Parse(args[2]);

                //三角形判定
                result = triangle.TriangleType(a, b, c);
            }
            catch (ArgumentException)
            {
                wasThrown = true;
            }

            Assert.IsTrue(wasThrown);
        }

        //{6, 3, 1}
        [TestMethod()]
        public void ShorterTest1()
        {
            var args = new string[] { "6", "3", "1" };

            int result; //結果を格納する変数
            bool wasThrown = false;

            var triangle = new Triangle();
            try
            {
                triangle.CheckArgs(args);

                //引数を整数値に変換
                int a = int.Parse(args[0]);
                int b = int.Parse(args[1]);
                int c = int.Parse(args[2]);

                //三角形判定
                result = triangle.TriangleType(a, b, c);
            }
            catch (ArgumentException)
            {
                wasThrown = true;
            }

            Assert.IsTrue(wasThrown);
        }

        //{1, 6, 3}
        [TestMethod()]
        public void ShorterTest2()
        {
            var args = new string[] { "1", "6", "3" };

            int result; //結果を格納する変数
            bool wasThrown = false;

            var triangle = new Triangle();
            try
            {
                triangle.CheckArgs(args);

                //引数を整数値に変換
                int a = int.Parse(args[0]);
                int b = int.Parse(args[1]);
                int c = int.Parse(args[2]);

                //三角形判定
                result = triangle.TriangleType(a, b, c);
            }
            catch (ArgumentException)
            {
                wasThrown = true;
            }

            Assert.IsTrue(wasThrown);
        }

        //{3, 1, 6}
        [TestMethod()]
        public void ShorterTest3()
        {
            var args = new string[] { "3", "1", "6" };

            int result; //結果を格納する変数
            bool wasThrown = false;

            var triangle = new Triangle();
            try
            {
                triangle.CheckArgs(args);

                //引数を整数値に変換
                int a = int.Parse(args[0]);
                int b = int.Parse(args[1]);
                int c = int.Parse(args[2]);

                //三角形判定
                result = triangle.TriangleType(a, b, c);
            }
            catch (ArgumentException)
            {
                wasThrown = true;
            }

            Assert.IsTrue(wasThrown);
        }

        //{1, 1, 1}
        [TestMethod()]
        public void EquilateralTest()
        {
            var args = new string[] { "1", "1", "1" };

            int result = -1; //結果を格納する変数

            var triangle = new Triangle();

            triangle.CheckArgs(args);

            //引数を整数値に変換
            int a = int.Parse(args[0]);
            int b = int.Parse(args[1]);
            int c = int.Parse(args[2]);

            //三角形判定
            result = triangle.TriangleType(a, b, c);

            Assert.AreEqual(3, result);
        }

        //{6, 6, 4}
        [TestMethod()]
        public void IsoscelesTest1()
        {
            var args = new string[] { "6", "6", "4" };

            int result = -1; //結果を格納する変数

            var triangle = new Triangle();

            triangle.CheckArgs(args);

            //引数を整数値に変換
            int a = int.Parse(args[0]);
            int b = int.Parse(args[1]);
            int c = int.Parse(args[2]);

            //三角形判定
            result = triangle.TriangleType(a, b, c);

            Assert.AreEqual(2, result);
        }

        //{6, 4, 6}
        [TestMethod()]
        public void IsoscelesTest2()
        {
            var args = new string[] { "6", "4", "6" };

            int result = -1; //結果を格納する変数

            var triangle = new Triangle();

            triangle.CheckArgs(args);

            //引数を整数値に変換
            int a = int.Parse(args[0]);
            int b = int.Parse(args[1]);
            int c = int.Parse(args[2]);

            //三角形判定
            result = triangle.TriangleType(a, b, c);

            Assert.AreEqual(2, result);
        }

        //{4, 6, 6}
        [TestMethod()]
        public void IsoscelesTest3()
        {
            var args = new string[] { "4", "6", "6" };

            int result = -1; //結果を格納する変数

            var triangle = new Triangle();

            triangle.CheckArgs(args);

            //引数を整数値に変換
            int a = int.Parse(args[0]);
            int b = int.Parse(args[1]);
            int c = int.Parse(args[2]);

            //三角形判定
            result = triangle.TriangleType(a, b, c);

            Assert.AreEqual(2, result);
        }

        //{6, 4, 3}
        [TestMethod()]
        public void ScaleneTest()
        {
            var args = new string[] { "6", "4", "3" };

            int result = -1; //結果を格納する変数

            var triangle = new Triangle();

            triangle.CheckArgs(args);

            //引数を整数値に変換
            int a = int.Parse(args[0]);
            int b = int.Parse(args[1]);
            int c = int.Parse(args[2]);

            //三角形判定
            result = triangle.TriangleType(a, b, c);

            Assert.AreEqual(1, result);
        }
    }
}