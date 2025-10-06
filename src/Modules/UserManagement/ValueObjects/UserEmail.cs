using DisciplineForge.Core.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace UserManagement.ValueObjects;

public class UserEmail : ValueObject
{
    public string Value { get; }

    public UserEmail(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            throw new ArgumentException("Email cannot be empty");
        }

        var regex = new Regex(@"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$");
        if (!regex.IsMatch(value))
        {
            throw new ArgumentException("Invalid email format");
        }

        Value = value;
    }

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
}