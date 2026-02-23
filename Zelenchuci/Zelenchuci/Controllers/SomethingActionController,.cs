using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Zelenchuci.Models;
using Zelenchuci.Views;

namespace Zelenchuci.Controllers
{
    public class SomethingActionController
    {
        public Something something;
        public Display display;

        public SomethingActionController()
        {
            display = new Display();
            something = new Something(display.zPrice, display.pPrice, display.zKg, display.pKg);
            display.result = something.Calculate();
            display.ShowResult();
        }
    }
}
