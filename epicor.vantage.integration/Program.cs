using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace epicor.vantage.integration
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var epicorSession = new Epicor.Mfg.Core.Session("manager", "manager", "AppServerDC://EPICORVA803400:8311");
                var epicorPartClass = new Epicor.Mfg.BO.PartClass(epicorSession.ConnectionPool);

                bool morePages = false;
                var datapartClasses = epicorPartClass.GetRows("", "", 1000, 0, out morePages);

                Console.WriteLine("Press enter to close...");
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                Console.WriteLine("Press enter to close...");
                Console.ReadLine();
            }
        }
    }
}
