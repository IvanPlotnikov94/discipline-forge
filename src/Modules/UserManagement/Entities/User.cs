using DisciplineForge.Core.Entities;
using DisciplineForge.Core.ValueObjects;
using UserManagement.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;

namespace UserManagement.Entities;

public class User : Entity
{
    public UserName Name { get; private set; }
    public UserEmail Email { get; private set; }
    public DateTime CreatedAt { get; private set; }

    public User(UserName name, UserEmail email)
    {
        Name = name;
        Email = email;
        CreatedAt = DateTime.UtcNow;
    }
}