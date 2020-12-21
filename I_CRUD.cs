using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    interface I_CRUD
    {
        string create(string ID, string Name);
        string read(string ID);
        string update(string ID, string Name);
        string delete(string ID);
    }
}
