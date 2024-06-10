
namespace CodeTest.Tests
{
    public class StandardPhoneKeypadTests
    {
        [Fact]
        public void StandardPhoneKeypad_IsStandardPhoneKeypad()
        {
            var sut = new StandardTelephoneKeypad();
            var expectedButtons = new string[]
            {
                "123",
                "456",
                "789",
                "*0#",
            };
            
            Assert.Equal(3, sut.Width);
            Assert.Equal(4, sut.Height);            
            for (var x = 0; x < expectedButtons.Length - 1; x++)
            {
                for (var y = 0; y < expectedButtons[x].Length - 1; y++)
                {
                    
                    Assert.Equal(expectedButtons[y][x], sut.GetButton(x, y));
                }
            }
        }
    }
}

