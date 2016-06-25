using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Invoicing.Common
{
    public interface ISystemSet
    {
        bool Save();
        bool Modify();
        bool Delete();
        bool AddButton { get;  }
        bool ModifyButton { get; }
        bool DeleteButton { get; }
        string SetType { get; }
    }
}
