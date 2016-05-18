using MVC5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC5.Controllers
{
    class BaseController
    {
        public FabricsEntities db = new FabricsEntities();
    }
}
