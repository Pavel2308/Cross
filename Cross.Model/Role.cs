using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace Cross.Model
{
    public class Role: IdentityRole<int>
    {
        public virtual ICollection<RequestAction> Actions { get; set; }
    }
}
