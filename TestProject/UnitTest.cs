using FabryExanProjectTesting;

namespace TestProject
{
    public class Tests
    {
        //Beslissingsmodule

        //Als er een juist genre gekozen wordt dan wordt er gecontroleerd of het genre in de enum staat.
        [Test]
        public void CheckIfGenreExists()
        {
            if (FabryExanProjectTesting.Services.FilmServices.ChooseGenre("action") == true)
            {
                Assert.Pass();
            }
            Assert.Fail();
        }

        //Als er een fout genre gekozen wordt dan wordt er gecontroleerd of false word meegestuurt.
        [Test]
        public void CheckIfGenreDoesNotExist()
        {
            if (FabryExanProjectTesting.Services.FilmServices.ChooseGenre("fout genre") == false)
            {
                Assert.Pass();
            }
            Assert.Fail();
        }
    }
}