using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            try     //Kivétel keletkezése
            {
                int z = 0;
                int a = 5 / z;
                int.Parse("asda");
            }
            catch (DivideByZeroException ex) //Kivétel esetén fut le
            {
                MessageBox.Show(ex.Message + '\n' + ex.StackTrace);
            }
            catch (FormatException ex) //Kivétel esetén fut le
            {
                MessageBox.Show(ex.Message + '\n' + ex.StackTrace);
            }
            finally             //Try vagy catch után mindig lefut
            {
                MessageBox.Show("Fucker");
            }
        }
    }
}
