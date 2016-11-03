﻿using System;
using System.Collections.Generic;

namespace Weapsy.Infrastructure.Domain
{
    public interface IAggregateRoot
    {
        Guid Id { get; }
        ICollection<IEvent> Events { get; }
    }
}
