using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhlPlayers.DTO.Attributes
{
    [AttributeUsage(AttributeTargets.Property)]
    public class CsvPositionAttribute : Attribute
    {
        public int Position { get; private set; }

        public CsvPositionAttribute(int position)
        {
            Position = position;
        }
    }
}
