using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp
{
    public class DemoClass
    {
        public int field;

        /// <summary>
        /// Констурктор
        /// </summary>
        /// <param name="a_field">Значение поля</param>
        public DemoClass(int a_field)
        {
            field = a_field;
        }

        /// <summary>
        /// Это мой тестовый метод
        /// </summary>
        public void my_method()
        {
            field = 33;
        }
    }
}
