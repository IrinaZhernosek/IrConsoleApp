using ClassLibraryHW5;
using IrynaZharnasek.Lecture4;
using IrynaZharnasek.Lecture5;
using IrynaZharnasek.Lecture7.task1;
using System.Linq.Expressions;
using System.Xml.Linq;
namespace IrynaZharnasek
{
    public class Program
    {
        public static void Main()
        {
            Entertainments puzzle = new Puzzles("Paris", "3 hours", 10, 3500, "1*1");
            Entertainments boardgame= new Boardgames("Double", "10 min",18, 5, "for a newcomer");

            puzzle.typeOfGame();
            puzzle.gameInfo();
            boardgame.typeOfGame();
            boardgame.gameInfo();
        }
    }
}