using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class CRUD : Employee, I_CRUD
    {

        public string create(string ID, string Name)
        {
            employees.Add(ID, Name);
            return "Created sucessfuly\nName: " + employees[ID];
             
        }

        public string read(string ID)
        {
            if (employees.ContainsKey(ID))
            {
                return employees[ID];
            }
            else
            {
                return "This ID does not exist";
            }
        }

        public string update(string ID, string Name)
        {
            if (employees.ContainsKey(ID))
            {
                employees[ID] = Name;
                return "Updated Successfully\nName: " + employees[ID];
            }
            else
            {
                return "This ID does not exist";
            }
        }

        public string delete(string ID)
        {
            if (employees.ContainsKey(ID))
            {
                employees.Remove(ID);
                return "Deleted Successfully";
            }
            else
            {
                return "This ID does not exist";
            }
        }
    }
}
