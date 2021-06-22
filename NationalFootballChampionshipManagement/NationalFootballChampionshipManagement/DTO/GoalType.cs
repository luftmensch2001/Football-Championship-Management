using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NationalFootballChampionshipManagement.DTO
{
    class GoalType
    {
        int id;
        string name;

        public int ID { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }

        public GoalType(int id,string name)
        {
            this.id = id;
            this.name = name;
        }
    }
}
