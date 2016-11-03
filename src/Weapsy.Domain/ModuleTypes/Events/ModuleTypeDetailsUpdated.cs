﻿using Weapsy.Infrastructure.Domain;

namespace Weapsy.Domain.ModuleTypes.Events
{
    public class ModuleTypeDetailsUpdated : Event
    {
        public string Name { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public ViewType ViewType { get; set; }
        public string ViewName { get; set; }
        public EditType EditType { get; set; }
        public string EditUrl { get; set; }
    }
}
