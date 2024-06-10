using System.Diagnostics.CodeAnalysis;
using CodeTest.Chess;
using CodeTest.Interface;

namespace CodeTest
{
    internal class Program
    {
        [ExcludeFromCodeCoverage]
        static void Main(string[] args)
        {
            var keypad = new StandardTelephoneKeypad();
            var phoneNumberValidator = new PhoneNumberValidator();

            Console.WriteLine(@"Select a number for a Chess Piece from below to get the valid phone numbers Count
                                1. Rook
                                2. Bishop
                                3. Knight
                                4. King
                                5. Queen
                                6. White Pawn
                                7. Black Pawn
                                0. Press 0 to Close");
            var chessPieceSelected = Console.ReadLine();
            do
            {
                switch (chessPieceSelected)
                {
                    case "1":
                        Console.WriteLine("\nRook");
                        var rookCount = new ChessPieceCounter(keypad, phoneNumberValidator, new Rook()).GetCount();
                        Console.WriteLine($"Rook count is {rookCount}");
                        break;
                    case "2":
                        Console.WriteLine("\nBishop");
                        var bishopCount = new ChessPieceCounter(keypad, phoneNumberValidator, new Bishop()).GetCount();
                        Console.WriteLine($"Bishop count is {bishopCount}");
                        break;
                    case "3":
                        Console.WriteLine("\nKnight");
                        var knightCount = new ChessPieceCounter(keypad, phoneNumberValidator, new Knight()).GetCount();
                        Console.WriteLine($"Knight count is {knightCount}");
                        break;
                    case "4":
                        Console.WriteLine("\nKing");
                        var kingCount = new ChessPieceCounter(keypad, phoneNumberValidator, new King()).GetCount();
                        Console.WriteLine($"King count is {kingCount}");
                        break;
                    case "5":
                        Console.WriteLine("\nQueen");
                        var queenCount = new ChessPieceCounter(keypad, phoneNumberValidator, new Queen()).GetCount();
                        Console.WriteLine($"Queen count is {queenCount}");
                        break;
                    case "6":
                        Console.WriteLine("\nWhite Pawn");
                        var whitePawn = new ChessPieceCounter(keypad, phoneNumberValidator, new Pawn()).GetCount();
                        Console.WriteLine($"White Pawn count is {whitePawn}");
                        break;
                    case "7":
                        Console.WriteLine("\nBlack Pawn");
                        var blackPawn = new ChessPieceCounter(keypad, phoneNumberValidator, new Pawn(), false).GetCount();
                        Console.WriteLine($"Black Pawn count is {blackPawn}");
                        break;
                    case "0":
                        return;
                    default:
                        Console.WriteLine("\nNot a valid input select a number between 0 - 6");
                        break;

                }
                Console.WriteLine(@"***********************************************************************************************************************
                                Select a number for a Chess Piece from below to get the valid phone numbers Count
                                1. Rook
                                2. Bishop
                                3. Knight
                                4. King
                                5. Queen
                                6. White Pawn
                                7. Black Pawn
                                0. Press 0 to Close");
                chessPieceSelected = Console.ReadLine();
            } while (chessPieceSelected != "0");


        }
    }
}

