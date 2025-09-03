using System;
using EX16.Entities.EntitiesEnum;

namespace EX16.Entities
{
    internal class Department
    {
        public AvailableDepartments Name{ get; set; }

        public Department(AvailableDepartments name)
        {
            Name = name;
        }
    }
}
