using MindBoxTestTask;
using System;
using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        /// <summary>
        /// ��������� ������� �����
        /// </summary>
        [Fact]
        public void CalculateSpace_Circle_AreExpected()
        {
            var circle = new Circle(5);
            Assert.Equal(78.539, circle.CalculateSpace(), 3);
        }
        /// <summary>
        /// ��������� ������� ������������
        /// </summary>
        [Fact]
        public void CalculateSpace_Triangular_AreExpected()
        {
            var triangular = new Triangular(5, 5, 5);
            Assert.Equal(10.825, triangular.CalculateSpace(), 3);
        }
        /// <summary>
        /// ���������, ��� ����������� �������������
        /// </summary>
        [Fact]
        public void IsRightTriangular_Triangular_AreExpected()
        {
            var triangular = new Triangular(4, 3, 5);
            Assert.True(triangular.IsRightTriangular());
        }

        /// <summary>
        /// ���������, ��� ����������� �� �������������
        /// </summary>
        [Fact]
        public void IsRightTriangular_Triangular_AreNotExpected()
        {
            var triangular = new Triangular(4, 3, 6);
            Assert.False(triangular.IsRightTriangular());
        }
    }
}
