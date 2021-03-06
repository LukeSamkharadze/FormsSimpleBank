﻿using System;

using BankPCL.Abstractions.Interfaces.Strategies;

namespace BankPCL.Abstractions.Abstract_Classes.Strategies
{
    public abstract class MembershipStrategy : IMembershipStrategy
    {
        public virtual double? Priority { get; set; }

        public virtual double? Interest { get; set; }

        public virtual double? UpperLimit { get; set; }
        public virtual double? LowerLimit { get; set; }
    }
}
