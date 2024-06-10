namespace CodeTest.Interface
{
    public  interface IKeyPad
    {
        public int Width { get; }
        public int Height { get; }
        public char GetButton(int x, int y);
    }
}
