using CodeTest.Interface;

namespace CodeTest
{
    public class StandardTelephoneKeypad : IKeyPad
    {
        private static readonly string[] Rows = new string[]
        {
            "123",
            "456",
            "789",
            "*0#",
        };

        public int Width => 3;
        public int Height => 4;
        public char GetButton(int x, int y) => Rows[y][x];
    }
}
