// Project:         MeanerMonsters mod for Daggerfall Unity (http://www.dfworkshop.net)
// Copyright:       Copyright (C) 2019 Ralzar
// License:         MIT License (http://www.opensource.org/licenses/mit-license.php)
// Author:          Hazelnut & Ralzar

using DaggerfallWorkshop;
using DaggerfallWorkshop.Game;
using DaggerfallWorkshop.Game.Utility.ModSupport;
using DaggerfallWorkshop.Utility;
using UnityEngine;

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
            foreach (EnemyData mobData in mobEnemyDataArray)
            {
                // Log a message indicating the enemy mob being updated.
                Debug.LogFormat("Updating enemy data for {0}.", EnemyBasics.Enemies[mobData.ID].Name);

                if (mobData.Level != -1)
                    EnemyBasics.Enemies[mobData.ID].Level = mobData.Level;
                if (mobData.MinHp != -1)
                    EnemyBasics.Enemies[mobData.ID].MinHealth = mobData.MinHp;
                if (mobData.MaxHp != -1)
                    EnemyBasics.Enemies[mobData.ID].MaxHealth = mobData.MaxHp;
                if (mobData.Armor != -1)
                    EnemyBasics.Enemies[mobData.ID].ArmorValue = mobData.Armor;
                if (mobData.MinDmg != -1)
                    EnemyBasics.Enemies[mobData.ID].MinDamage = mobData.MinDmg;
                if (mobData.MaxDmg != -1)
                    EnemyBasics.Enemies[mobData.ID].MaxDamage = mobData.MaxDmg;
                if (mobData.MinDmg2 != -1)
                    EnemyBasics.Enemies[mobData.ID].MinDamage2 = mobData.MinDmg2;
                if (mobData.MaxDmg2 != -1)
                    EnemyBasics.Enemies[mobData.ID].MaxDamage2 = mobData.MaxDmg2;
                if (mobData.MinDmg3 != -1)
                    EnemyBasics.Enemies[mobData.ID].MinDamage3 = mobData.MinDmg3;
                if (mobData.MaxDmg3 != -1)
                    EnemyBasics.Enemies[mobData.ID].MaxDamage3 = mobData.MaxDmg3;
                if (mobData.MoveSnd != -1)
                    EnemyBasics.Enemies[mobData.ID].MoveSound = mobData.MoveSnd;
                if (mobData.BarkSnd != -1)
                    EnemyBasics.Enemies[mobData.ID].BarkSound = mobData.BarkSnd;
                if (mobData.AttackSnd != -1)
                    EnemyBasics.Enemies[mobData.ID].AttackSound = mobData.AttackSnd;
            }

            Debug.Log("Finished mod init: MeanerMonsters");
        }

        private class EnemyData
        {
            public int ID       { get { return id; } }          // ID of this mobile
            public int Level    { get { return level; } }       // Monster Level
            public int MinHp    { get { return minHp; } }       // Minimum health
            public int MaxHp    { get { return maxHp; } }       // Maximum health
            public int Armor    { get { return armor; } }       // Armor value
            public int MinDmg   { get { return minDmg; } }      // Minimum damage per first hit of attack
            public int MaxDmg   { get { return maxDmg; } }      // Maximum damage per first hit of attack
            public int MinDmg2  { get { return minDmg2; } }     // Minimum damage per second hit of attack
            public int MaxDmg2  { get { return maxDmg2; } }     // Maximum damage per second hit of attack
            public int MinDmg3  { get { return minDmg3; } }     // Minimum damage per third hit of attack
            public int MaxDmg3  { get { return maxDmg3; } }     // Maximum damage per third hit of attack
            public int MoveSnd  { get { return moveSnd; } }     // Movement sound file
            public int BarkSnd  { get { return barkSnd; } }     // Bark sound file
            public int AttackSnd{ get { return attackSnd; } }   // Attack sound file

            private readonly int id, level, minHp, maxHp, armor;
            private readonly int minDmg, maxDmg, minDmg2, maxDmg2, minDmg3, maxDmg3;
            private readonly int moveSnd, barkSnd, attackSnd;  

            public EnemyData(int id = -1, int level = -1, int minHp = -1, int maxHp = -1, int armor = -1,
                            int minDmg = -1, int maxDmg = -1, int minDmg2 = -1, int maxDmg2 = -1, int minDmg3 = -1, int maxDmg3 = -1,
                            int moveSnd = -1, int barkSnd = -1, int attackSnd = -1)
            {
                this.id = id;
                this.level = level;
                this.minHp = minHp;
                this.maxHp = maxHp;
                this.armor = armor;
                this.minDmg = minDmg;
                this.maxDmg = maxDmg;
                this.minDmg2 = minDmg2;
                this.maxDmg2 = maxDmg2;
                this.minDmg3 = minDmg3;
                this.maxDmg3 = maxDmg3;
                this.moveSnd = moveSnd;
                this.barkSnd = barkSnd;
                this.attackSnd = attackSnd;
            }

        }

        private static EnemyData[] mobEnemyDataArray = new EnemyData[]
        {
            new EnemyData(id: 0, minHp:15, maxHp: 25, armor: 8, minDmg: 1, maxDmg: 2),                                                  // Rat
            new EnemyData(id: 3, minHp: 5, maxHp: 15, armor: 4, minDmg: 1, maxDmg: 2,                                                   // Giant Bat
                            level:2, moveSnd: (int)SoundClips.EnemyGiantMove),  // <- example of setting a level and a sound clip.
            new EnemyData(id: 4, minHp:50, maxHp:100, armor: 7, minDmg: 1, maxDmg: 2, minDmg2: 8, maxDmg2:12, minDmg3:10, maxDmg3:20),  // Grizzly Bear
            new EnemyData(id: 5, minHp:20, maxHp: 60, armor: 2, minDmg: 8, maxDmg:15, minDmg2: 8, maxDmg2:20, minDmg3:10, maxDmg3:25),  // Sabertooth Tiger
        };
        /*
            {   // Rat
                id = 0,
                MinDamage = 1, MaxDamage = 2,
                MinHealth = 15, MaxHealth = 25,
                ArmorValue = 8
            },
            new EnemyData()
            {   // Giant Bat
                id = 3,
                MinDamage = 1, MaxDamage = 2,
                MinHealth = 5, MaxHealth = 15,
                Level= 2,
                ArmorValue = 4
            },
            new EnemyData()
            {   // Grizzly Bear
                id = 4,
                MinDamage = 5, MaxDamage = 10,
                MinDamage2 = 8, MaxDamage2 = 12,
                MinDamage3 = 10, MaxDamage3 = 20,
                MinHealth = 50, MaxHealth = 100,
                Level = 4,
                ArmorValue = 7
            },
            new EnemyData()
            {   // Sabertooth Tiger
                id = 5,
                MinDamage = 8, MaxDamage = 15,
                MinDamage2 = 8, MaxDamage2 = 20,
                MinDamage3 = 10, MaxDamage3 = 25,
                MinHealth = 20, MaxHealth = 60,
                Level = 4,
                ArmorValue = 2
            },
            new EnemyData()
            {   // Spider
                id = 6,
                MinDamage = 4, MaxDamage = 10,
                MinHealth = 15, MaxHealth = 38,
                Level = 2,
                ArmorValue = 6
            },
            new EnemyData()
            {   // Werewolf
                id = 9,
                MinDamage  = 8, MaxDamage = 10,
                MinDamage2 = 8, MaxDamage2 = 10,
                MinDamage3 = 15, MaxDamage3 = 30,
                MinHealth = 25, MaxHealth = 50,
                Level = 8,
                ArmorValue = 1
            },
            new EnemyData()
            {   // Wereboar
                id = 14,
                MinDamage = 5, MaxDamage = 8,
                MinDamage2 = 5, MaxDamage2 = 8,
                MinDamage3 = 10, MaxDamage3 = 25,
                MinHealth = 80, MaxHealth = 120,
                Level = 8,
                ArmorValue = 7
            },
            new EnemyData()
            {   // Giant
                id = 16,
                MinDamage = 10, MaxDamage = 30,
                MinHealth = 80, MaxHealth = 110,
                Level = 10,
                ArmorValue = 5
            },
            new EnemyData()
            {   // Zombie
                id = 17,
                MinDamage = 1, MaxDamage = 5,
                MinHealth = 60, MaxHealth = 100,
                Level = 5,
                ArmorValue = 7
            },
            new EnemyData()
            {   // Mummy
                id = 19,
                MinDamage = 5, MaxDamage = 15,
                MinHealth = 100, MaxHealth = 150,
                Level = 15,
                ArmorValue = -8
            },
            new EnemyData()
            {   // Giant Scorpion
                id = 20,
                MinDamage = 10, MaxDamage = 15,
                MinHealth = 15, MaxHealth = 70,
                Level = 7,
                ArmorValue = 2
            },
            new EnemyData()
            {   // Vampire Ancient
                id = 30,
                MinDamage = 25, MaxDamage = 60,
                MinHealth = 80, MaxHealth = 200,
                Level = 20,
                ArmorValue = -5
            },
            new EnemyData()
            {   // Daedra Lord
                id = 31,
                MinDamage = 40, MaxDamage = 100,
                MinHealth = 100, MaxHealth = 240,
                Level = 21,
                ArmorValue = -10
            },
            new EnemyData()
            {   // Lich
                id = 32,
                MinDamage = 80, MaxDamage = 110,
                MinHealth = 60, MaxHealth = 200,
                Level = 20,
                ArmorValue = -8
            },
            new EnemyData()
            {   // Ancient Lich
                id = 33,
                MinDamage = 100, MaxDamage = 130,
                MinHealth = 80, MaxHealth = 210,
                Level = 21,
                ArmorValue = -12
            },
            new EnemyData()
            {   // Orc
                id = 7,
                MinDamage = 8, MaxDamage = 20,
                MinHealth = 20, MaxHealth = 50,
                Level = 6,
                ArmorValue = 5
            },
            new EnemyData()
            {   // Orc Sargeant
                id = 12,
                MinDamage = 10, MaxDamage = 30,
                MinHealth = 40, MaxHealth = 100,
                Level = 9,
                ArmorValue = 2
            },
            new EnemyData()
            {   // Orc Shaman
                id = 21,
                MinDamage = 8, MaxDamage = 30,
                MinHealth = 50, MaxHealth = 110,
                Level = 15,
                ArmorValue = 6
            },
            new EnemyData()
            {   // Orc Warlord
                id = 24,
                MinDamage = 15, MaxDamage = 50,
                MinHealth = 60, MaxHealth = 150,
                Level = 19,
                ArmorValue = -1
            },
        };*/
    }
}
