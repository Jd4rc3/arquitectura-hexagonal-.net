using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.models
{
    public record Category
    {
        public int Id { get; init; }

        public string Name { get; init; }

        public Status Status { get; init; }
    }

    public enum Status
    {
        Active,
        Inactive
    }
}

