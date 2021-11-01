using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05OutKeyWords
{
    class Program
    {
        static void Main(string[] args)
        {
            int s1, s2, s3, s4;
            DortIslem(10, 5, out s1, out s2, out s3, out s4);

            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine(s3);
            Console.WriteLine(s4);

            Console.ReadKey();
        }

        private static void DortIslem(int v1, int v2, out int s1, out int s2, out int s3, out int s4)
        {
            s1 = v1 + v2;
            s2 = v1 * v2;
            s3 = v1 / v2;
            s4 = v1 - s1; // yoruma alırsan hatayı görürsün, değer atamak zorundasın.

        }
    }
}

//OUT VS REF
// 1- Out parametreleriyle gelen edğişiklere metot içinde mutlaka ama mutklaka bir değer atanmaldırı.
// 2. metot çağrılırken out ile işaretli parametrelere ilk değeri  atanmış değişkenler verilebilir, ref de         verilemez,
// 3. out parametreleriyle gelene değişikenlerin değerleri metot içinde kullanılmaz(Eşittirin sağında kullanılmaz)

//özetle out değer döndürmek için kullanılır, ismi gibi sadece dışarıya veri aktarırı, içeriye veri sokulamaz.
