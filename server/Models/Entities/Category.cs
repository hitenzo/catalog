

using System;

namespace server.Models.Entities
{
    [Flags]
    public enum Category
    {
        Toys = 1,
        Sport = 2,
        Electronics = 4,
        Other = 8
    }
}