using CodeTest.Chess;


namespace CodeTest.Tests
{
    public class ChessPieceCounterTests
    {
        [Fact]
        public void ChessPieceCounter_ReturnsCorrectCount()
        {
            var keypad = new StandardTelephoneKeypad();
            var phoneNumberValidator = new PhoneNumberValidator();

            var rookCount = new ChessPieceCounter(keypad, phoneNumberValidator, new Rook()).GetCount();
            Assert.Equal(49326, rookCount);
           

            var bishopCount = new ChessPieceCounter(keypad, phoneNumberValidator, new Bishop()).GetCount();
            Assert.Equal(2341, bishopCount);
            

            var knightCount = new ChessPieceCounter(keypad, phoneNumberValidator, new Knight()).GetCount();
            Assert.Equal(952, knightCount);
            

            var kingCount = new ChessPieceCounter(keypad, phoneNumberValidator, new King()).GetCount();
            Assert.Equal(124908, kingCount);
           

            var queenCount = new ChessPieceCounter(keypad, phoneNumberValidator, new Queen()).GetCount();
            Assert.Equal(751503, queenCount);
            

            var whitePawnCount = new ChessPieceCounter(keypad, phoneNumberValidator, new Pawn()).GetCount();
            Assert.Equal(0, whitePawnCount);
            

            var blackPawnCount = new ChessPieceCounter(keypad, phoneNumberValidator, new Pawn(), false).GetCount();
            Assert.Equal(0, blackPawnCount);
            
        }
    }
}