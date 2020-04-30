﻿using System;
using System.Numerics;
using Dalamud.Configuration;
using Dalamud.Plugin;

namespace PingPlugin
{
    public class PingConfiguration : IPluginConfiguration
    {
        public int Version { get; set; }
        
        public Vector2 GraphPosition { get; set; }
        public Vector2 MonitorPosition { get; set; }

        public bool ClickThrough { get; set; }
        public bool GraphIsVisible { get; set; }
        public bool MonitorIsVisible { get; set; }
        public bool LockWindows { get; set; }

        public int PingQueueSize { get; set; }

        public PingConfiguration()
        {
            GraphPosition = new Vector2(600, 150);
            MonitorPosition = new Vector2(300, 150);

            MonitorIsVisible = true;

            PingQueueSize = 20;
        }

        [NonSerialized]
        private DalamudPluginInterface pluginInterface;

        public void Initialize(DalamudPluginInterface pluginInterface)
        {
            this.pluginInterface = pluginInterface;
        }

        public void Save()
        {
            this.pluginInterface.SavePluginConfig(this);
        }
    }
}
