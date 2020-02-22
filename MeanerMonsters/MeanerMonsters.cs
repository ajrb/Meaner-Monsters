// Project:         UnleveledMobs mod for Daggerfall Unity (http://www.dfworkshop.net)
// Copyright:       Copyright (C) 2019 JayH
// License:         MIT License (http://www.opensource.org/licenses/mit-license.php)
// Author:          JayH

using DaggerfallConnect;
using DaggerfallWorkshop;
using DaggerfallWorkshop.Game;
using DaggerfallWorkshop.Game.Utility.ModSupport;
using DaggerfallWorkshop.Utility;
using UnityEngine;
using System.Collections;

namespace MeanerMonsters
{
    public class MeanerMonsters : MonoBehaviour
    {
        static Mod mod;

        [Invoke(StateManager.StateTypes.Start, 0)]
        public static void Init(InitParams initParams)
        {
            mod = initParams.Mod;
            var go = new GameObject(mod.Title);
            go.AddComponent<MeanerMonsters>();
        }

        void Awake()
        {
            InitMod();

            mod.IsReady = true;
        }

        private static void InitMod()
        {
            Debug.Log("Begin mod init: MeanerMonsters");

            //Iterate over the new mob enemy data array and load into DFU enemies data.
            foreach (MobileEnemyOverhaulData mobData in mobEnemyDataArray)
            {
                // Log a message indicating the enemy mob being updated.
                Debug.LogFormat("Updating enemy data for {0}.", EnemyBasics.Enemies[mobData.ID].Name);

                EnemyBasics.Enemies[mobData.ID].MinDamage = mobData.MinDamage;
                EnemyBasics.Enemies[mobData.ID].MaxDamage = mobData.MaxDamage;
                EnemyBasics.Enemies[mobData.ID].MinDamage2 = mobData.MinDamage2;
                EnemyBasics.Enemies[mobData.ID].MaxDamage2 = mobData.MaxDamage2;
                EnemyBasics.Enemies[mobData.ID].MinDamage3 = mobData.MinDamage3;
                EnemyBasics.Enemies[mobData.ID].MaxDamage3 = mobData.MaxDamage3;
                EnemyBasics.Enemies[mobData.ID].MinHealth = mobData.MinHealth;
                EnemyBasics.Enemies[mobData.ID].MaxHealth = mobData.MaxHealth;
                EnemyBasics.Enemies[mobData.ID].Level = mobData.Level;
                EnemyBasics.Enemies[mobData.ID].ArmorValue = mobData.ArmorValue;
            }

            //Change RuinedCastle mobs for testing.
            //RandomEncounters.EncounterTables[(int)DFRegion.DungeonTypes.RuinedCastle] = new RandomEncounterTable()
            //{ 
            //    DungeonType = DFRegion.DungeonTypes.RuinedCastle,
            //    Enemies = new MobileTypes[]
            //    {

            //        MobileTypes.GrizzlyBear,
            //        MobileTypes.Werewolf,
            //        MobileTypes.Wereboar,
            //        MobileTypes.GrizzlyBear,
            //        MobileTypes.Werewolf,
            //        MobileTypes.Wereboar,
            //        MobileTypes.GrizzlyBear,
            //        MobileTypes.Werewolf,
            //        MobileTypes.Wereboar,
            //        MobileTypes.GrizzlyBear,
            //        MobileTypes.Werewolf,
            //        MobileTypes.Wereboar,
            //        MobileTypes.GrizzlyBear,
            //        MobileTypes.Werewolf,
            //        MobileTypes.Wereboar,
            //        MobileTypes.GrizzlyBear,
            //        MobileTypes.Werewolf,
            //        MobileTypes.Wereboar,
            //        MobileTypes.GrizzlyBear,
            //        MobileTypes.Werewolf,

            //    }
            //};

            Debug.Log("Finished mod init: MeanerMonsters");
        }

        private struct MobileEnemyOverhaulData
        {
            public int ID;                              // ID of this mobile
            public int MinDamage;                       // Minimum damage per first hit of attack
            public int MaxDamage;                       // Maximum damage per first hit of attack
            public int MinDamage2;                      // Minimum damage per second hit of attack
            public int MaxDamage2;                      // Maximum damage per second hit of attack
            public int MinDamage3;                      // Minimum damage per third hit of attack
            public int MaxDamage3;                      // Maximum damage per third hit of attack
            public int MinHealth;                       // Minimum health
            public int MaxHealth;                       // Maximum health
            public int Level;                           // Monster Level
            public int ArmorValue;                      // Armor value
        }

        private static MobileEnemyOverhaulData[] mobEnemyDataArray = new MobileEnemyOverhaulData[]
        {
            new MobileEnemyOverhaulData()
            {   // Rat
                ID = 0,
                MinDamage = 1, MaxDamage = 2,
                MinHealth = 20, MaxHealth = 40,
                ArmorValue = 8
            },
            new MobileEnemyOverhaulData()
            {   // Giant Bat
                ID = 3,
                MinDamage = 1, MaxDamage = 2,
                MinHealth = 5, MaxHealth = 15,
                Level= 2,
                ArmorValue = 4
            },
            new MobileEnemyOverhaulData()
            {   // Grizzly Bear
                ID = 4,
                MinDamage = 5, MaxDamage = 10,
                MinDamage2 = 8, MaxDamage2 = 12,
                MinDamage3 = 10, MaxDamage3 = 20,
                MinHealth = 100, MaxHealth = 200,
                Level = 4,
                ArmorValue = 7
            },
            new MobileEnemyOverhaulData()
            {   // Sabertooth Tiger
                ID = 5,
                MinDamage = 8, MaxDamage = 15,
                MinDamage2 = 8, MaxDamage2 = 20,
                MinDamage3 = 10, MaxDamage3 = 25,
                MinHealth = 60, MaxHealth = 120,
                Level = 4,
                ArmorValue = 2
            },
            new MobileEnemyOverhaulData()
            {   // Spider
                ID = 6,
                MinDamage = 4, MaxDamage = 10,
                MinHealth = 15, MaxHealth = 38,
                Level = 2,
                ArmorValue = 6
            },
            new MobileEnemyOverhaulData()
            {   // Werewolf
                ID = 9,
                MinDamage  = 8, MaxDamage = 10,
                MinDamage2 = 8, MaxDamage2 = 10,
                MinDamage3 = 15, MaxDamage3 = 30,
                MinHealth = 100, MaxHealth = 150,
                Level = 8,
                ArmorValue = 1
            },
            new MobileEnemyOverhaulData()
            {   // Wereboar
                ID = 14,
                MinDamage = 5, MaxDamage = 8,
                MinDamage2 = 5, MaxDamage2 = 8,
                MinDamage3 = 10, MaxDamage3 = 25,
                MinHealth = 180, MaxHealth = 220,
                Level = 8,
                ArmorValue = 7
            },
            new MobileEnemyOverhaulData()
            {   // Giant
                ID = 16,
                MinDamage = 10, MaxDamage = 30,
                MinHealth = 200, MaxHealth = 300,
                Level = 10,
                ArmorValue = 5
            },
            new MobileEnemyOverhaulData()
            {   // Zombie
                ID = 17,
                MinDamage = 1, MaxDamage = 5,
                MinHealth = 60, MaxHealth = 100,
                Level = 5,
                ArmorValue = 7
            },
            new MobileEnemyOverhaulData()
            {   // Mummy
                ID = 19,
                MinDamage = 10, MaxDamage = 30,
                MinHealth = 150, MaxHealth = 200,
                Level = 15,
                ArmorValue = -8
            },
            new MobileEnemyOverhaulData()
            {   // Giant Scorpion
                ID = 20,
                MinDamage = 10, MaxDamage = 15,
                MinHealth = 15, MaxHealth = 70,
                Level = 4,
                ArmorValue = 2
            },
            new MobileEnemyOverhaulData()
            {   // Vampire Ancient
                ID = 30,
                MinDamage = 25, MaxDamage = 60,
                MinHealth = 80, MaxHealth = 200,
                Level = 20,
                ArmorValue = -5
            },
            new MobileEnemyOverhaulData()
            {   // Daedra Lord
                ID = 31,
                MinDamage = 40, MaxDamage = 100,
                MinHealth = 100, MaxHealth = 240,
                Level = 21,
                ArmorValue = -10
            },
            new MobileEnemyOverhaulData()
            {   // Lich
                ID = 32,
                MinDamage = 80, MaxDamage = 110,
                MinHealth = 60, MaxHealth = 200,
                Level = 20,
                ArmorValue = -8
            },
            new MobileEnemyOverhaulData()
            {   // Ancient Lich
                ID = 33,
                MinDamage = 100, MaxDamage = 130,
                MinHealth = 80, MaxHealth = 210,
                Level = 21,
                ArmorValue = -12
            },
            new MobileEnemyOverhaulData()
            {   // Orc
                ID = 7,
                MinDamage = 8, MaxDamage = 20,
                MinHealth = 40, MaxHealth = 60,
                Level = 6,
                ArmorValue = 2
            },
            new MobileEnemyOverhaulData()
            {   // Orc Sargeant
                ID = 12,
                MinDamage = 10, MaxDamage = 30,
                MinHealth = 80, MaxHealth = 120,
                Level = 10,
                ArmorValue = -3
            },
            new MobileEnemyOverhaulData()
            {   // Orc Shaman
                ID = 21,
                MinDamage = 8, MaxDamage = 30,
                MinHealth = 100, MaxHealth = 150,
                Level = 15,
                ArmorValue = 1
            },
            new MobileEnemyOverhaulData()
            {   // Orc Warlord
                ID = 24,
                MinDamage = 15, MaxDamage = 50,
                MinHealth = 60, MaxHealth = 150,
                Level = 19,
                ArmorValue = -10
            },
            new MobileEnemyOverhaulData()
            {   // Fire Atronach
                ID = 35,
                MinDamage = 15, MaxDamage = 30,
                MinHealth = 25, MaxHealth = 130,
                Level = 16,
                ArmorValue = 6
            },
            new MobileEnemyOverhaulData()
            {   // Iron Atronach
                ID = 36,
                MinDamage = 5, MaxDamage = 15,
                MinHealth = 25, MaxHealth = 130,
                Level = 21,
                ArmorValue = 6
            },
            new MobileEnemyOverhaulData()
            {   // Flesh Atronach
                ID = 37,
                MinDamage = 5, MaxDamage = 15,
                MinHealth = 100, MaxHealth = 300,
                Level = 16,
                ArmorValue = 6
            },
            new MobileEnemyOverhaulData()
            {   // Ice Atronach
                ID = 38,
                MinDamage = 5, MaxDamage = 15,
                MinHealth = 25, MaxHealth = 130,
                Level = 16,
                ArmorValue = -1
            },
        };
    }
}
