using System;
using System.Collections.Generic;
using System.Text;

namespace WInRAR
{
    class ApplicationLicense
    {
        public void AllowTrial()
        {
            Console.WriteLine("Ви вибрали Триальную версию");
        }

        public void AllowCommon()
        {
            Console.WriteLine("Ви вибрали Бесплатьную версию");
        }

        public void AllowPro()
        {
            Console.WriteLine("Ви вибрали Профессиональную версию");
        }
    }
}
