﻿namespace CRUDBasicoDotNet.Controllers.PackControllerExample
{
    public class ControllerExampleResponse
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; }
        public bool Active { get; set; }
    }
}
