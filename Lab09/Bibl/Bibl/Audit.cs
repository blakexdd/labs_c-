using System;
using System.IO;

namespace MyClass
{
    public class Audit
    {
        /* running audit method */
        public static void RunAudit()
        {
            Magazine.Subscribe += new ProcessMagazineDelegate(Audit.MethodSubs);
        }

        /* stop audit method */
        public static void StopAudit()
        {
            Magazine.Subscribe -= new ProcessMagazineDelegate(Audit.MethodSubs);
        }

        /* handling subscriptions method */
        public static void MethodSubs(Magazine mg, DateTime dt)
        {
            try
            {
                StreamWriter sw = new StreamWriter("infoSubscribe.txt", true);
                sw.WriteLine(mg.ToString());
                sw.WriteLine($"Подписка оформлена {dt}\n");
                sw.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
