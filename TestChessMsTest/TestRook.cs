using ChessGame;
using ChessGame.Pices;
using ChessGame.Pices.Elements;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestChessMsTest
{
    [TestClass]
    public class TestRook
    {

        public TestRook()
        {

        }
        [DataTestMethod]
        [DynamicData(nameof(DataListCompareTo),DynamicDataSourceType.Method)]

        [TestMethod]
        public void TestRook_GetAllMoves(int x, int y, List<Pozition> compareTo)
        {
            Players player = new Players(1);
            List<Pice> listToPutOnBord = new List<Pice>();
            Rook rook = new Rook(x, y, player);
            listToPutOnBord.Add(rook);
            Pice[,] bord = CreateBord(8, 8, listToPutOnBord);
            CollectionAssert.AreEqual(compareTo, rook.GetAllMoves(bord));

        }

        // method used my above test method to test diferent cases
        private static IEnumerable<object[]> DataListCompareTo()
        {
            yield return new object[] { 0, 0, new List<Pozition> {new Pozition(1,0),
                                                              new Pozition(2,0),
                                                              new Pozition(3,0),
                                                              new Pozition(4,0),
                                                              new Pozition(5,0),
                                                              new Pozition(6,0),
                                                              new Pozition(7,0),
                                                              new Pozition(0,1),
                                                              new Pozition(0,2),
                                                              new Pozition(0,3),
                                                              new Pozition(0,4),
                                                              new Pozition(0,5),
                                                              new Pozition(0,6),
                                                              new Pozition(0,7), } };
            yield return new object[] { 7, 0, new List<Pozition> {
                                                              new Pozition(6,0),
                                                              new Pozition(5,0),
                                                              new Pozition(4,0),
                                                              new Pozition(3,0),
                                                              new Pozition(2,0),
                                                              new Pozition(1,0),
                                                              new Pozition(0,0),
                                                              new Pozition(7,1),
                                                              new Pozition(7,2),
                                                              new Pozition(7,3),
                                                              new Pozition(7,4),
                                                              new Pozition(7,5),
                                                              new Pozition(7,6),
                                                              new Pozition(7,7)} };
            yield return new object[] { 0, 7, new List<Pozition> {
                                                              new Pozition(1,7),
                                                              new Pozition(2,7),
                                                              new Pozition(3,7),
                                                              new Pozition(4,7),
                                                              new Pozition(5,7),
                                                              new Pozition(6,7),
                                                              new Pozition(7,7),
                                                              new Pozition(0,6),
                                                              new Pozition(0,5),
                                                              new Pozition(0,4),
                                                              new Pozition(0,3),
                                                              new Pozition(0,2),
                                                              new Pozition(0,1),
                                                              new Pozition(0,0),
                                                              } };
            yield return new object[] {7, 7, new List<Pozition> {new Pozition(6,7),
                                                              new Pozition(5,7),
                                                              new Pozition(4,7),
                                                              new Pozition(3,7),
                                                              new Pozition(2,7),
                                                              new Pozition(1,7),
                                                              new Pozition(0,7),
                                                              new Pozition(7,6),
                                                              new Pozition(7,5),
                                                              new Pozition(7,4),
                                                              new Pozition(7,3),
                                                              new Pozition(7,2),
                                                              new Pozition(7,1),
                                                              new Pozition(7,0), } };
        }


        private Pice[,] CreateBord(int x, int y, List<Pice> ListOfPices)
        {
            Pice[,] bord = new Pice[x, y];
            foreach (Pice p in ListOfPices)
            {
                bord[p.pozition.pozX, p.pozition.pozY] = p;
            }
            return bord;
        }
    }
}
