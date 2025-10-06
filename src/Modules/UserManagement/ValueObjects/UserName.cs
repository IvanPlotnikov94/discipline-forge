using DisciplineForge.Core.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;

namespace UserManagement.ValueObjects;

public class UserName : ValueObject
{
    public string Value { get; }

    public UserName(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            throw new ArgumentException("Name cannot be empty");
        }

        Value = value;
    }

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
}