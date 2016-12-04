using System;
using System.Linq;

namespace Triangle
{
    class Program
    {
        public static void Main(string[] args)
        {
            var triangle = new Triangle();

            int result; //結果を格納する変数

            try
            {
                //引数チェック
                triangle.CheckArgs(args);

                //引数を整数値に変換
                int a = int.Parse(args[0]);
                int b = int.Parse(args[1]);
                int c = int.Parse(args[2]);

                //三角形判定
                result = triangle.TriangleType(a, b, c);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            //結果出力
            Console.WriteLine(result);
        }
    }

    public class Triangle
    {
        /// <summary>
        /// 引数に整数値が3個指定されていることをチェック
        /// 条件を満たさない場合はExceptionをThrowする
        /// </summary>
        /// <param name="args">引数の配列</param>
        public void CheckArgs(string[] args)
        {
            //引数リスト
            int[] edges = new int[3];

            //個数チェック
            if (args == null)
            {
                throw new IndexOutOfRangeException("引数の個数が不正です");
            }

            if (args.Count() != 3)
            {
                throw new IndexOutOfRangeException("引数の個数が不正です");
            }

            //整数チェック
            if (!(int.TryParse(args[0], out edges[0])))
            {
                throw new ArgumentException("引数の型が不正です", "a");
            }
            else if (!(int.TryParse(args[1], out edges[1])))
            {
                throw new ArgumentException("引数の型が不正です", "b");
            }
            else if (!(int.TryParse(args[2], out edges[2])))
            {
                throw new ArgumentException("引数の型が不正です", "c");
            }

            //値範囲チェック
            if (edges[0] < 1)
            {
                throw new ArgumentOutOfRangeException("a", "引数の値範囲が不正です");
            }
            else if (edges[1] < 1)
            {
                throw new ArgumentOutOfRangeException("b", "引数の値範囲が不正です");
            }
            else if (edges[2] < 1)
            {
                throw new ArgumentOutOfRangeException("c", "引数の値範囲が不正です");
            }
        }

        /// <summary>
        /// 引数に指定された3つの整数値でできる三角形の種類を1～3の値で返す
        /// </summary>
        /// <param name="a">辺a</param>
        /// <param name="b">辺b</param>
        /// <param name="c">辺c</param>
        /// <returns>三角形の種類(1:不等辺三角形，2:二等辺三角形，3:正三角形)</returns>
        public int TriangleType(int a, int b, int c)
        {
            //辺の配列
            var edges = new int[] { a, b, c };

            //長い順に辺をソート
            edges = edges.OrderByDescending(i => i).ToArray();

            //三角形が成立するかチェック 
            if ((edges[0] >= edges[1] + edges[2]))
            {
                throw new ArgumentException("長辺の長さが他の2辺の長さの和以下のため，三角形が成立しません");
            }

            //すべての辺が同じ長さかチェック
            if ((edges[0] == edges[1]) && (edges[0] == edges[2]))
            {
                //正三角形
                return 3;
            }

            //二等辺三角形かチェック
            if ((edges[0] == edges[1]) || (edges[0] == edges[2]) || (edges[1] == edges[2]))
            {
                //二等辺三角形
                return 2;
            }

            //不等辺三角形
            return 1;
        }
    }
}