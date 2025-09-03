using System;
using EX16.Entities.EntitiesEnum;

namespace EX16.Entities
{
    internal class Department
    {
        public AvailabeDepartments Name{ get; set; }

        public Department()
        {
        }

        public Department(AvailabeDepartments name)
        {
            Name = name;
        }
    }
}
