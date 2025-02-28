using Newtonsoft.Json;
using System.Collections.Generic;

namespace ACE.Common
{
    public enum Ruleset
    {
        Invalid,
        //Release,                // November 1999
        //DarkMajesty,            // October 2001
        CustomDM,
        Infiltration,           // February 2005
        //ThroneOfDestiny,        // July 2005
        //FromDarknessLight,      // November 2010 - Void Magic
        //MasterOfDesign,         // November 2011 - Innate Augmentations
        //MasterOfArms,           // February 2012 - New weapon skills
        //BalanceOfPower,         // February 2013 - Summoning
        EoR                     // May 2015
    }

    public class GameConfiguration
    {
        public string WorldName { get; set; }

        public NetworkSettings Network { get; set; }

        public AccountDefaults Accounts { get; set; }

        public string DatFilesDirectory { get; set; }

        /// <summary>
        /// The amount of seconds to wait before turning off the server. Default value is 60 (for 1 minute).
        /// </summary>
        [System.ComponentModel.DefaultValue(60)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Populate)]
        public uint ShutdownInterval { get; set; }

        [System.ComponentModel.DefaultValue(false)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Populate)]
        public bool ServerPerformanceMonitorAutoStart { get; set; }

        public ThreadConfiguration Threading { get; set; } = new ThreadConfiguration();

        /// <summary>
        /// The amount of minutes to keep a player object from shard database in memory. Default value is 31 minutes.
        /// </summary>
        [System.ComponentModel.DefaultValue(31)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Populate)]
        public uint ShardPlayerBiotaCacheTime { get; set; }

        /// <summary>
        /// The amount of minutes to keep a non player object from shard database in memory. Default value is 11 minutes.
        /// </summary>
        [System.ComponentModel.DefaultValue(11)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Populate)]
        public uint ShardNonPlayerBiotaCacheTime { get; set; }

        [System.ComponentModel.DefaultValue(false)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Populate)]
        public bool WorldDatabasePrecaching { get; set; }

        [System.ComponentModel.DefaultValue(true)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Populate)]
        public bool LandblockPreloading { get; set; }

        [System.ComponentModel.DefaultValue(false)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Populate)]
        public bool TestWorld { get; set; }


        public List<PreloadedLandblocks> PreloadedLandblocks { get; set; }

        /// <summary>
        /// Determines which era's ruleset to use.
        /// </summary>
        [System.ComponentModel.DefaultValue(Ruleset.EoR)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Populate)]
        public Ruleset WorldRuleset { get; set; }
    }
}
