using _20101_SAVRIKOV_1.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20101_SAVRIKOV_1.Core
{
    internal class DataBaseHelper
    {
        private static DataBaseEntities _context;

        public static DataBaseEntities GetContext()
        {
            if(_context == null)
            {
                _context = new DataBaseEntities();
            }
            return _context;
        }
    }
}
