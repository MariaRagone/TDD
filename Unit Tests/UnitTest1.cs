using Day_17_Unit_Testing_Lecture;

namespace Unit_Tests
{
    public class UnitTest1
    {
        //Fact = single test
        [Fact]
        public void TwoNumbersAddedWillSum()
        {
            //where to write the code for the test
            //ARRANGE
            //set up variables and anything you need to set up your class
            Arithmetic sut = new Arithmetic(); //system under test

            //ACT
            //run the methods and store the variable
            int result = sut.Adder(2, 3);


            //ASSERT

            Assert.Equal(5, result); //expect to get a 5, call the result variable to see the 
                                     //actual result
        }
        //Theory is multiple tests, use cases
        //can pass in multiple values to test multiple things in at one time
        [Theory]
        [InlineData(1, 1, 0)]//the amount of numbers you want to pass
        [InlineData(4, 2, 2)]
        [InlineData(10, -2, 12)]
        [InlineData(-4, -5, 1)]

        public void TwoNumbersSubbedWillDifference(int num1, int num2, int difference)

        { //ARRANGE
            //set original variable
            Arithmetic sut = new Arithmetic();

            //ACT
            int result = sut.Subber(num1, num2);

            //ASSERT
            Assert.Equal(difference, result); //result is the actual result
        }

        //set up test for multiply and divide (2 tests)
        //multiple use cases (use a theory)
        //account for zero in these as well
        //once all tests are set up then create the actual methods

        [Theory]
        [InlineData(1, 1, 2, 2)]//multiply 2 positive = positive
        [InlineData(1, 1, 0, 0)]//multiply number with 0 = =
        [InlineData(1, 1, -2, -2)]//multiply 1 negative and the rest positive = negative
        [InlineData(1, -1, -2, 2)]//multiply 2 negative numbers = positive
        [InlineData(-1, -2, -2, -4)]//pultiply odd number of negative numbers = positive
        [InlineData(0, 0, 0, 0)]//multiply 2 zeros = 0

        public void ThreeNumbersMultiplyToGetProduct(int num1, int num2, int num3, int product)
        { //ARRANGE
            //set original variable
            Arithmetic sut = new Arithmetic();

            //ACT
            int result = sut.Multiply(num1, num2, num3);

            //ASSERT
            Assert.Equal(product, result); //result is the actual result

        }

        [Theory]
        [InlineData(1, 1, 1)]//divide 2 positive = positive
        [InlineData(1, 0, 0)]//divide number with 0 = 
        [InlineData(-5, 5,-1)]//divide neg with pos = negative
        [InlineData(-1, -1, 1)]//divide neg with neg = positive
        [InlineData(0, 0, 0)]//divide 0 with 0 = 0

        public void TwoNumbersDivideToGetQuotient(int num1, int num2, int divide)
        { //ARRANGE
            //set original variable
            Arithmetic sut = new Arithmetic();

            //ACT
            int result = sut.Divider(num1, num2);

            //ASSERT
            Assert.Equal(divide, result); //result is the actual result

        }

    }
}