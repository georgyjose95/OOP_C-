using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerManagement.BL
{
    public enum EntityStateOption
    {
        Active,
        Disabled
    };

    public abstract  class EntityBase
    {
        public EntityStateOption EntityState { get; set; }
        public bool IsNew { get; private set; }
        public bool HasChanges { get;  set; }
        public bool IsValid
        {
            get
            {
                return Validate();
            }

        }

        public abstract bool Validate();
    }
}
