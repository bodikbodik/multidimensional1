using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multidimensional1Tasks.Tests
{
    [TestFixture]
    public class TaskTests
    {
        [Test]
        public void Task1_ReturnsCorrectValue()
        {
            List<int[,]> arrays = new List<int[,]>();

            arrays.Add(new int[,] { { 1, 0, -3 }, { 0, 7, -5 } });
            arrays.Add(new int[,] { { -1, 4 }, { 2, 3 } });
            arrays.Add(new int[,] { { -5, 1, -9 }, { -5, 13, -5 } });

            int[] expected = { 8, 9, 14 };

            for (int i = 0; i < expected.Length; i++)
            {
                var actual = Tasks.Task1(arrays[i]);
                Assert.AreEqual(expected[i], actual, "Task1 returns incorrect value.");
            }
        }

        [Test]
        public void Task2_ReturnsCorrectValue()
        {
            List<int[,]> arrays = new List<int[,]>();

            arrays.Add(new int[,] { { 1, 0, 6 },
                                    { 1, 3, 1 },
                                    { 4, 5 ,6 } });
            arrays.Add(new int[,] { { -1, 0, 3 },
                                     { 5, 9, 0 },
                                     { 4, 3, 6 } });
            arrays.Add(new int[,] { { 0, 1, 0 },
                                    { 14, 0, 3 },
                                    { 3, 5, 3 } });

            int[] expected = { 7, 3, 4 };

            for (int i = 0; i < expected.Length; i++)
            {
                var actual = Tasks.Task2(arrays[i]);
                Assert.AreEqual(expected[i], actual, "Task2 returns incorrect value.");
            }
        }

        [Test]
        public void Task3_ReturnsCorrectValue()
        {
            List<int[,]> arrays = new List<int[,]>();

            arrays.Add(new int[,] { { 2, 10, 51 },
                                    { 31, 33, 33 },
                                    { 31, 35 ,36 } });
            arrays.Add(new int[,] { { -11, 10, 13 },
                                     { 45, 49, 40 },
                                     { 44, 43, 43 } });
            arrays.Add(new int[,] { { 20, 21, 23 },
                                    { 54, 53, 53 },
                                    { 53, 55, 53 } });

            List<int[,]> expected = new List<int[,]>();

            expected.Add(new int[,] { { 2, 10, 51 },
                                    { 30, 32, 32 },
                                    { 29, 33 ,34 } });
            expected.Add(new int[,] { { -11, 10, 13 },
                                     { 44, 48, 39 },
                                     { 42, 41, 41 } });
            expected.Add(new int[,] { { 20, 21, 23 },
                                    { 53, 52, 52 },
                                    { 51, 53, 51 } });

            for (int i = 0; i < expected.Count; i++)
            {
                Tasks.Task3(arrays[i]);
                Assert.AreEqual(expected[i], arrays[i], "Task3 returns incorrect value.");
            }
        }
    }
}
