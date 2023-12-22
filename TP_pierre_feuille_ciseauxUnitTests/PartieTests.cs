using System.ComponentModel.DataAnnotations;
using TP_pierre_feuille_ciseaux;

namespace TP_pierre_feuille_ciseauxUnitTests
{
    [TestClass]
    public class PartieTests
    {
        [TestMethod]
        [DataRow(Signe.Pierre, Signe.Ciseaux, "Le joueur 1 gagne")]
        [DataRow(Signe.Feuille, Signe.Pierre, "Le joueur 1 gagne")]
        [DataRow(Signe.Ciseaux, Signe.Feuille, "Le joueur 1 gagne")]
        public void PlayRound_Player1Wins_ReturnsCorrectResult(Signe joueurUn, Signe joueurDeux, string expectedResult)
        {
            var result = Partie.PlayRound(joueurUn, joueurDeux);
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void PlayRound_Player2Wins_ReturnsCorrectResult()
        {
            var result = Partie.PlayRound(Signe.Feuille, Signe.Ciseaux);
            Assert.AreEqual("Le joueur 2 gagne", result);
        }

        [TestMethod]
        public void PlayRound_Tie_ReturnsCorrectResult()
        {
            var result = Partie.PlayRound(Signe.Pierre, Signe.Pierre);
            Assert.AreEqual("Egalité", result);
        }

        [TestMethod]
        public void GetRandomSign_ReturnsValidSign()
        {
            var sign = Partie.GetRandomSign();
            Assert.IsTrue(Enum.IsDefined(typeof(Signe), sign));
        }
    }
}