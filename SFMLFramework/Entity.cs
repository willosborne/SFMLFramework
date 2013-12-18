using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SFMLFramework
{
    class Entity
    {
        public Dictionary<string, Component> Components;
        public Dictionary<string, System> Systems;

        public void AddComponent(Component component)
        {
            Components.Add(component.GetType().ToString(), component);
        }

        public void AddSystem(System system)
        {
            Systems.Add(system.GetType().ToString(), system);
        }

        public Component GetComponent(string name)
        {
            if (Components.ContainsKey(name))
                return Components[name];
            else
                throw new Exception("Component not attached!");
        }
        public System GetSystem(string name)
        {
            if (Systems.ContainsKey(name))
                return Systems[name];
            else
                throw new Exception("System not attached!");
        }

        public void Update()
        {
            foreach (System system in Systems.Values)
            {
                system.Update();
            }
        }
    }
}
