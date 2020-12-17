using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalc.Tests
{
    [TestClass()]
    public class SimpleCalcTests
    {
        [TestMethod()]
        public void AddTest1()
        {
            Calculator.Models.SimpleCalc simpleCalc = new Calculator.Models.SimpleCalc();
           decimal res= simpleCalc.Add(5,10);
            Assert.AreEqual(res,15);
        }
        [TestMethod()]
        public void AddTest2()
        {
            Calculator.Models.SimpleCalc simpleCalc = new Calculator.Models.SimpleCalc();
            decimal res = simpleCalc.Add(10, 10);
            Assert.AreEqual(res, 20);
        }
        [TestMethod()]
        public void AddTest3()
        {
            Calculator.Models.SimpleCalc simpleCalc = new Calculator.Models.SimpleCalc();
            decimal res = simpleCalc.Add(19, 10);
            Assert.AreEqual(res, 20);
        }
        [TestMethod()]
        public void AddTest4()
        {
            Calculator.Models.SimpleCalc simpleCalc = new Calculator.Models.SimpleCalc();
            decimal res = simpleCalc.Add(11, 10);
            Assert.AreEqual(res, 21);
        }

        public void AddTest5()
        {
            Calculator.Models.SimpleCalc simpleCalc = new Calculator.Models.SimpleCalc();
            decimal res = simpleCalc.Add(11, 10);
            Assert.AreEqual(res, 21);
        }

        public void AddTest6()
        {
            Calculator.Models.SimpleCalc simpleCalc = new Calculator.Models.SimpleCalc();
            decimal res = simpleCalc.Add(11, 10);
            Assert.AreEqual(res, 21);
        }

        public void AddTest7()
        {
            Calculator.Models.SimpleCalc simpleCalc = new Calculator.Models.SimpleCalc();
            decimal res = simpleCalc.Add(11, 10);
            Assert.AreEqual(res, 21);
        }

        public void AddTest8()
        {
            Calculator.Models.SimpleCalc simpleCalc = new Calculator.Models.SimpleCalc();
            decimal res = simpleCalc.Add(11, 10);
            Assert.AreEqual(res, 21);
        }

        public void AddTest9()
        {
            Calculator.Models.SimpleCalc simpleCalc = new Calculator.Models.SimpleCalc();
            decimal res = simpleCalc.Add(11, 10);
            Assert.AreEqual(res, 21);
        }

        public void AddTest10()
        {
            Calculator.Models.SimpleCalc simpleCalc = new Calculator.Models.SimpleCalc();
            decimal res = simpleCalc.Add(11, 10);
            Assert.AreEqual(res, 21);
        }


        [TestMethod()]
        public void SubTest1()
        {
            Calculator.Models.SimpleCalc simpleCalc = new Calculator.Models.SimpleCalc();
            decimal res = simpleCalc.Sub(5, 10);
            Assert.Equals(res,-5);
        }
        [TestMethod()]
        public void SubTest2()
        {
            Calculator.Models.SimpleCalc simpleCalc = new Calculator.Models.SimpleCalc();
            decimal res = simpleCalc.Sub(0, 0);
            Assert.AreEqual(res,0);
        }

        [TestMethod()]
        public void SubTest3()
        {
            Calculator.Models.SimpleCalc simpleCalc = new Calculator.Models.SimpleCalc();
            decimal res = simpleCalc.Sub(5, 10);
            Assert.AreEqual(res, -5);
        }

        [TestMethod()]
        public void SubTest4()
        {
            Calculator.Models.SimpleCalc simpleCalc = new Calculator.Models.SimpleCalc();
            decimal res = simpleCalc.Sub(5, 10);
            Assert.AreEqual(res, -5);
        }

        [TestMethod()]
        public void SubTest5()
        {
            Calculator.Models.SimpleCalc simpleCalc = new Calculator.Models.SimpleCalc();
            decimal res = simpleCalc.Sub(5, 10);
            Assert.AreEqual(res, -5);
        }
        [TestMethod()]
        public void SubTest6()
        {
            Calculator.Models.SimpleCalc simpleCalc = new Calculator.Models.SimpleCalc();
            decimal res = simpleCalc.Sub(5, 10);
            Assert.AreEqual(res, -5);
        }
        [TestMethod()]
        public void SubTest7()
        {
            Calculator.Models.SimpleCalc simpleCalc = new Calculator.Models.SimpleCalc();
            decimal res = simpleCalc.Sub(5, 10);
            Assert.AreEqual(res, -5);
        }
        [TestMethod()]
        public void SubTest8()
        {
            Calculator.Models.SimpleCalc simpleCalc = new Calculator.Models.SimpleCalc();
            decimal res = simpleCalc.Sub(5, 10);
            Assert.AreEqual(res, -5);
        }
        [TestMethod()]
        public void SubTest9()
        {
            Calculator.Models.SimpleCalc simpleCalc = new Calculator.Models.SimpleCalc();
            decimal res = simpleCalc.Sub(5, 10);
            Assert.AreEqual(res, -5);
        }
        [TestMethod()]
        public void SubTest10()
        {
            Calculator.Models.SimpleCalc simpleCalc = new Calculator.Models.SimpleCalc();
            decimal res = simpleCalc.Sub(5, 10);
            Assert.AreEqual(res, -5);
        }

        [TestMethod()]
        public void MultTest1()
        {
            Calculator.Models.SimpleCalc simpleCalc = new Calculator.Models.SimpleCalc();
            decimal res = simpleCalc.Mult(5, 10);
            Assert.AreEqual(res, 50);

            
        }

       
        [TestMethod()]
        public void MultTest2()
        {
            Calculator.Models.SimpleCalc simpleCalc = new Calculator.Models.SimpleCalc();
            decimal res = simpleCalc.Mult(10, 10);
            Assert.AreEqual(res, 100);


        }
        [TestMethod()]
        public void MultTest3()
        {
            Calculator.Models.SimpleCalc simpleCalc = new Calculator.Models.SimpleCalc();
            decimal res = simpleCalc.Mult(5, 10);
            Assert.AreEqual(res, 50);


        }
        [TestMethod()]
        public void MultTest4()
        {
            Calculator.Models.SimpleCalc simpleCalc = new Calculator.Models.SimpleCalc();
            decimal res = simpleCalc.Mult(5, 10);
            Assert.AreEqual(res, 50);


        }
        public void MultTest5()
        {
            Calculator.Models.SimpleCalc simpleCalc = new Calculator.Models.SimpleCalc();
            decimal res = simpleCalc.Mult(5, 10);
            Assert.AreEqual(res, 50);


        }
        public void MultTest6()
        {
            Calculator.Models.SimpleCalc simpleCalc = new Calculator.Models.SimpleCalc();
            decimal res = simpleCalc.Mult(5, 10);
            Assert.AreEqual(res, 50);


        }
        public void MultTest7()
        {
            Calculator.Models.SimpleCalc simpleCalc = new Calculator.Models.SimpleCalc();
            decimal res = simpleCalc.Mult(5, 10);
            Assert.AreEqual(res, 50);


        }
        public void MultTest8()
        {
            Calculator.Models.SimpleCalc simpleCalc = new Calculator.Models.SimpleCalc();
            decimal res = simpleCalc.Mult(5, 10);
            Assert.AreEqual(res, 50);


        }
        public void MultTest9()
        {
            Calculator.Models.SimpleCalc simpleCalc = new Calculator.Models.SimpleCalc();
            decimal res = simpleCalc.Mult(5, 10);
            Assert.AreEqual(res, 50);


        }
        public void MultTest10()
        {
            Calculator.Models.SimpleCalc simpleCalc = new Calculator.Models.SimpleCalc();
            decimal res = simpleCalc.Mult(5, 10);
            Assert.AreEqual(res, 50);


        }

        [TestMethod()]
        public void DivTest1()
        {
            Calculator.Models.SimpleCalc simpleCalc = new Calculator.Models.SimpleCalc();
            decimal res = simpleCalc.Div(10, 0);

            Assert.Fail();
        }
        [TestMethod()]
        public void DivTest2()
        {
            Calculator.Models.SimpleCalc simpleCalc = new Calculator.Models.SimpleCalc();
            decimal res = simpleCalc.Div(10, 10);

            Assert.AreEqual(res,1);
        }
        [TestMethod()]
        public void DivTest3()
        {
            Calculator.Models.SimpleCalc simpleCalc = new Calculator.Models.SimpleCalc();
            decimal res = simpleCalc.Div(10, 0);

            Assert.Fail();
        }
        [TestMethod()]
        public void DivTest4()
        {
            Calculator.Models.SimpleCalc simpleCalc = new Calculator.Models.SimpleCalc();
            decimal res = simpleCalc.Div(10, 0);

            Assert.Fail();
        }
        [TestMethod()]
        public void DivTest5()
        {
            Calculator.Models.SimpleCalc simpleCalc = new Calculator.Models.SimpleCalc();
            decimal res = simpleCalc.Div(10, 0);

            Assert.Fail();
        }
        [TestMethod()]
        public void DivTest6()
        {
            Calculator.Models.SimpleCalc simpleCalc = new Calculator.Models.SimpleCalc();
            decimal res = simpleCalc.Div(10, 10);

            Assert.AreEqual(res, 1);
        }
        [TestMethod()]
        public void DivTest7()
        {
            Calculator.Models.SimpleCalc simpleCalc = new Calculator.Models.SimpleCalc();
            decimal res = simpleCalc.Div(10, 10);

            Assert.AreEqual(res, 1);
        }
        [TestMethod()]
        public void DivTest8()
        {
            Calculator.Models.SimpleCalc simpleCalc = new Calculator.Models.SimpleCalc();
            decimal res = simpleCalc.Div(10, 10);

            Assert.AreEqual(res, 1);
        }
        [TestMethod()]
        public void DivTest9()
        {
            Calculator.Models.SimpleCalc simpleCalc = new Calculator.Models.SimpleCalc();
            decimal res = simpleCalc.Div(10, 10);

            Assert.AreEqual(res, 1);
        }
        [TestMethod()]
        public void DivTest10()
        {
            Calculator.Models.SimpleCalc simpleCalc = new Calculator.Models.SimpleCalc();
            decimal res = simpleCalc.Div(10, 10);

            Assert.AreEqual(res, 1);

        }

        [TestMethod()]
        public void OperatorSwitchTestAdd()
        {
            Calculator.Models.SimpleCalc simpleCalc = new Calculator.Models.SimpleCalc();
            decimal res = simpleCalc.OperatorSwitch("Add", 5, 10);
            Assert.AreEqual(res,15);
        }
        [TestMethod()]
        public void OperatorSwitchTestSub()
        {
            Calculator.Models.SimpleCalc simpleCalc = new Calculator.Models.SimpleCalc();
            decimal res = simpleCalc.OperatorSwitch("Subtract", 5, 10);
            Assert.AreEqual(res, -5);
        }
        [TestMethod()]
        public void OperatorSwitchTestMult()
        {
            Calculator.Models.SimpleCalc simpleCalc = new Calculator.Models.SimpleCalc();
            decimal res = simpleCalc.OperatorSwitch("Multiply", 5, 10);
            Assert.AreEqual(res, 50);
        }
        [TestMethod()]
        public void OperatorSwitchTestDiv()
        {
            Calculator.Models.SimpleCalc simpleCalc = new Calculator.Models.SimpleCalc();
            decimal res = simpleCalc.OperatorSwitch("Divide", 5, 10);
            Assert.AreEqual(res, 0.5);
        }
    }
}