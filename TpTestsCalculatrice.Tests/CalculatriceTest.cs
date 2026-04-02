using Microsoft.VisualStudio.TestTools.UnitTesting;
using TpTestsCalculatrice.App;

namespace TpTestsCalculatrice.Tests;

[TestClass]
public class CalculatriceTests
{
    [TestMethod]
    public void Addition_Retourne5_Si2Plus3()
    {
        Calculatrice calc = new Calculatrice();

        int resultat = calc.Addition(2, 3);

        Assert.AreEqual(5, resultat);
    }
    // 1 test effectue ; 0 test echoue ; 1 test reussi  

    //Part 5 Ex1 
    [TestMethod]
    public void Soutraction_5Moins3()
    {
        Calculatrice c2 = new Calculatrice();
        int res2 = c2.Soustraction(5, 3);
        Assert.AreEqual(2, res2);
    }

    //Part 5 Ex2 
    [TestMethod]
    public void Multiplication_4x3()
    {
        Calculatrice c3 = new Calculatrice();
        int res3 = c3.Multiplication(4, 3);
        Assert.AreEqual(12, res3);
    }

    //Part 5 Ex3 
    [TestMethod]
    public void Division_10Par2()
    {
        Calculatrice c4 = new Calculatrice();
        double res4 = c4.Division(10, 2);
        Assert.AreEqual(5, res4);
    }

    //Part 6 
    [TestMethod]
    public void Division_10Par0()
    {
        Calculatrice c5 = new Calculatrice();

        Assert.Throws<Exception>(() => c5.Division(10, 0));
    }

    //Part 7 True 
    [TestMethod]
    public void Test_booleenTrue()
    {
        Calculatrice c6 = new Calculatrice();
        bool r6 = c6.EstPair(4);

        Assert.IsTrue(r6);
        
    }

    //Part 7 False
    [TestMethod]
    public void Test_booleenfalse()
    {
        Calculatrice c7 = new Calculatrice();
        bool r7 = c7.EstPair(5);

        Assert.IsFalse(r7);
    }

    // Part 8 Addition 1
    [TestMethod]
    public void Addition_1()
    {
        Calculatrice a1 = new Calculatrice();

        int resultat = a1.Addition(0, 0);

        Assert.AreEqual(0, resultat);
    }

    // Part 8 Addition 2
    [TestMethod]
    public void Addition_2()
    {
        Calculatrice a2 = new Calculatrice();

        int resultat = a2.Addition(-1, 1);

        Assert.AreEqual(0, resultat);
    }

    // Part 8 Addition 3
    [TestMethod]
    public void Addition_3()
    {
        Calculatrice a2 = new Calculatrice();

        int resultat = a2.Addition(100, 200);

        Assert.AreEqual(300, resultat);
    }
}