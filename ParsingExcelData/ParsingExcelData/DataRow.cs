using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParsingExcelData
{
    public class DataRow
    {
        public object A { get; set; }
        public object B { get; set; }
        public object C { get; set; }
        public object D { get; set; }
        public object E { get; set; }
        public object F { get; set; }
        public object G { get; set; }
        public object H { get; set; }
        public object I { get; set; }
        public object J { get; set; }
        public object K { get; set; }
        public object L { get; set; }
        public object M { get; set; }
        public object N { get; set; }
        public object O { get; set; }
        public object P { get; set; }
        public object Q { get; set; }
        public object R { get; set; }
        public object S { get; set; }
        public object T { get; set; }
        public object U { get; set; }
        public object V { get; set; }
        public object W { get; set; }
        public object X { get; set; }
        public object Y { get; set; }
        public object Z { get; set; }

        public List<object> Rows { get; set; }

        public DataRow()
        {
            Rows = new List<object>();
        }

        void GetCellData(string input)
        {
            switch (input)
            {
                case "A":
                    A = input;
                    break;
                case "B":
                    B = input;
                    break;
                case "C":
                    C = input;
                    break;
                case "D":
                    D = input;
                    break;
                case "E":
                    E = input;
                    break;
                case "F":
                    F = input;
                    break;
                case "G":
                    G = input;
                    break;
                case "H":
                    H = input;
                    break;
                case "I":
                    I = input;
                    break;
                case "J":
                    J = input;
                    break;
                case "K":
                    K = input;
                    break;
                case "L":
                    L = input;
                    break;
                case "M":
                    M = input;
                    break;
                case "O":
                    O = input;
                    break;
                case "P":
                    P = input;
                    break;
                case "Q":
                    Q = input;
                    break;
                case "R":
                    R = input;
                    break;
                case "S":
                    S = input;
                    break;
                case "T":
                    A = input;
                    break;
                case "U":
                    A = input;
                    break;
                case "V":
                    A = input;
                    break;
                case "W":
                    A = input;
                    break;
                case "X":
                    X = input;
                    break;
                case "Y":
                    Y = input;
                    break;
                case "Z":
                    Z = input;
                    break;
            }
        }
    }
}
