
namespace ChallengeApp.Tests
{
    public class Tests
    {
    
       [Test]
        public void WhenEmployyeCollectPoints_ShouldReturnCorrectSum()
        {
            //arrange
            var employee1 = new Employee("Jaros³aw","Jareczek", 45);
           
            employee1.AddScore(1);
            employee1.AddScore(5);
            employee1.AddScore(6);
            //act
            var result = employee1.Result;
            //assert
            Assert.AreEqual(12, result);
                      
        }
        [Test]
        public void WhenEmployye2CollectPoints_ShouldReturnCorrectSum()
        {
            var employee2 = new Employee("Marysia", "Ktosiowa", 23);

            employee2.AddScore(-1);
            employee2.AddScore(15);
            employee2.AddScore(20);


            var result = employee2.Result;


            Assert.AreEqual(34, result);
        }
       [Test]
        public void WhenEmployye3CollectPoints_ShouldReturnCorrectSum()
        {
            var employee3 = new Employee("Dionizy", "Izydor", 63);

            employee3.AddScore(-25);
            employee3.AddScore(-3);
            employee3.AddScore(-2);


            var result = employee3.Result;


            Assert.AreEqual(-30,result);
        }
    }

    
}

