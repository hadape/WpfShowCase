using System;

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
