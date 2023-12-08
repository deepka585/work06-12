(1) 
 
namespace _001 
{ 
    internal class Program 
    { 
        static void Main()  
        {  
            Console.WriteLine("Двойной факториал числа: "); 
            Console.WriteLine(f2(7)); 
        } 
            static int f2(int o) 
            {  
            int t = 1; 
            for (int i = o % 2 == 0 ? 2 : 1; i <= o; i += 2) t *= i; 
            return t; 
            } 
    } 
} 
 
---------------------------------------------------------------------- 
 
(2) 
 
namespace _002 
{ 
    internal class Program 
    { 
        static void Main() 
        { 
            Console.WriteLine("Сумм квадратов натуральных чисел."); 
            Console.WriteLine(f2(8)); 
        } 
        static int f2(int n) 
        { 
            if (n <= 1) return n; 
            else 
            { 
                int k = 0; 
                for (int i = 1; i <= n; i++) k += Convert.ToInt32(Math.Pow(i, 2)); 
                return k; 
            } 
        } 
    } 
} 
 
--------------------------------------------------------------------------- 
 
(3) 
 
using System; 
namespace _003 
{ 
    class Program  
    { 
        static S[] qe<S>(S[] fa, int n) => fa.Take(n).ToArray(); 
        static void Main(string[] args)  
        { 
            var q1 = new int[] { 1, 2, 3, 4, 5, 6, 7 }; 
            var q2 = new char[] { 'x', 'y', 'z', 'q' };  
            var q3 = qe(q1, 7);  
            Console.WriteLine(string.Join(" ", q3));  
            var q4 = qe(q2, 3);  
            Console.WriteLine(string.Join(" ", q4));  
        }  
    }  
} 
 
---------------------------------------------------------------------------- 
 
(4) 
 
namespace _004 
{ 
    class Program 
    { 
        static int[] mas(char[] L, int H) 
        { 
            int[] Q = new int[H]; 
            for (int i = 0; i < H; i++) 
            { 
                Q[i] = (int)L[i]; 
            } 
            return Q; 
        } 
        static void Main(string[] args) 
        { 
            char[] e = { 'a', 'b', 'c', 'd', 'e', 'f', 'g' }; 
            int[] b = mas(e, 2); 
            Console.Write(e); 
            Console.ReadKey(); 
 
 
            char[] s = { 'A', 'B', 'C', 'D', 'E' }; 
            int[] Q = new int[s.Length]; 
            for (int i = 0; i < s.Length; i++) 
            { 
                Q[i] = (int)s[i]; 
                Console.Write(Q[i]); 
            } 
            Console.ReadKey(); 
        } 
    } 
 
} 
 
--------------------------------------------------------------------- 
 
(7) 
 
namespace _006 
{ 
    class Program 
    { 
        static int[] ks(int[] c) 
        { 
            int[] cd = new int[c.Length]; 
            for (int i = 0; i < c.Length; i++) 
            { 
                cd[i] = c[c.Length - i - 1]; 
            } 
            return cd; 
        } 
        static void Main(string[] sa) 
        { 
            int[] ca = { 1, 2, 3, 4, 5, 6, 7, 8 }; 
            int q = 10; 
            int[] ksk = ks(ca); 
            Console.WriteLine(string.Join(", ", ca)); 
            Console.WriteLine(string.Join(", ", ksk)); 
        } 
    } 
}
