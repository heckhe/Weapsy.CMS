﻿using System;
using System.Collections.Generic;
using Weapsy.Infrastructure.Domain;

namespace Weapsy.Domain.Menus.Commands
{
    public class SetMenuItemPermissions : ICommand
    {
        public Guid SiteId { get; set; }
        public Guid MenuId { get; set; }
        public Guid MenuItemId { get; set; }
        public IList<MenuItemPermission> MenuItemPermissions { get; set; }
    }
}
    