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
        Calculatrice c2 = new Calculatrice ();
        int res2 = c2.Soustraction(5, 3);
        Assert.AreEqual(2, res2);
    }

    //Part 5 Ex2 
    [TestMethod]
    public void Multiplication_4x3()
    {
        Calculatrice c3 = new Calculatrice ();
        int res3 = c3.Multiplication(4, 3);
        Assert.AreEqual(12, res3);
    }
}