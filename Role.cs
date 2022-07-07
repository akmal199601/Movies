using System.Collections.Generic;
using Entities.Enums;

namespace Entities.Models;

public class Role
{
    public Roles Id { get; set; }
    public string Name { get; set; }

    public virtual IEnumerable<Person> Persons { get; set; }
}