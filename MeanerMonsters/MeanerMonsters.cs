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

            // Rat
            EnemyBasics.Enemies[0].MinDamage = 1;
            EnemyBasics.Enemies[0].MaxDamage = 2;
            EnemyBasics.Enemies[0].MinHealth = 15;
            EnemyBasics.Enemies[0].MaxHealth = 25;
            EnemyBasics.Enemies[0].Level = 1;
            EnemyBasics.Enemies[0].ArmorValue = 8;

            // Giant Bat
            EnemyBasics.Enemies[3].MinDamage = 1;
            EnemyBasics.Enemies[3].MaxDamage = 2;
            EnemyBasics.Enemies[3].MinHealth = 5;
            EnemyBasics.Enemies[3].MaxHealth = 15;
            EnemyBasics.Enemies[3].Level = 2;
            EnemyBasics.Enemies[3].ArmorValue = 4;

            // Grizzly Bear
            EnemyBasics.Enemies[4].MinDamage = 5;
            EnemyBasics.Enemies[4].MaxDamage = 10;
            EnemyBasics.Enemies[4].MinDamage2 = 8;
            EnemyBasics.Enemies[4].MaxDamage2 = 12;
            EnemyBasics.Enemies[4].MinDamage3 = 10;
            EnemyBasics.Enemies[4].MaxDamage3 = 20;
            EnemyBasics.Enemies[4].MinHealth = 50;
            EnemyBasics.Enemies[4].MaxHealth = 100;
            EnemyBasics.Enemies[4].Level = 4;
            EnemyBasics.Enemies[4].ArmorValue = 7;

            // Sabertooth Tiger		
            EnemyBasics.Enemies[5].MinDamage = 8;
            EnemyBasics.Enemies[5].MaxDamage = 15;
            EnemyBasics.Enemies[5].MinDamage2 = 8;
            EnemyBasics.Enemies[5].MaxDamage2 = 20;
            EnemyBasics.Enemies[5].MinDamage3 = 10;
            EnemyBasics.Enemies[5].MaxDamage3 = 25;
            EnemyBasics.Enemies[5].MinHealth = 20;
            EnemyBasics.Enemies[5].MaxHealth = 60;
            EnemyBasics.Enemies[5].Level = 4;
            EnemyBasics.Enemies[5].ArmorValue = 2;

            // Spider		
            EnemyBasics.Enemies[6].MinDamage = 4;
            EnemyBasics.Enemies[6].MaxDamage = 10;
            EnemyBasics.Enemies[6].MinHealth = 15;
            EnemyBasics.Enemies[6].MaxHealth = 38;
            EnemyBasics.Enemies[6].Level = 2;
            EnemyBasics.Enemies[6].ArmorValue = 6;

            // Werewolf		
            EnemyBasics.Enemies[9].MinDamage = 8;
            EnemyBasics.Enemies[9].MaxDamage = 10;
            EnemyBasics.Enemies[9].MinDamage2 = 8;
            EnemyBasics.Enemies[9].MaxDamage2 = 10;
            EnemyBasics.Enemies[9].MinDamage3 = 15;
            EnemyBasics.Enemies[9].MaxDamage3 = 30;
            EnemyBasics.Enemies[9].MinHealth = 25;
            EnemyBasics.Enemies[9].MaxHealth = 50;
            EnemyBasics.Enemies[9].Level = 8;
            EnemyBasics.Enemies[9].ArmorValue = 1;

            // Wereboar		
            EnemyBasics.Enemies[14].MinDamage = 5;
            EnemyBasics.Enemies[14].MaxDamage = 8;
            EnemyBasics.Enemies[14].MinDamage2 = 5;
            EnemyBasics.Enemies[14].MaxDamage2 = 8;
            EnemyBasics.Enemies[14].MinDamage3 = 10;
            EnemyBasics.Enemies[14].MaxDamage3 = 25;
            EnemyBasics.Enemies[14].MinHealth = 80;
            EnemyBasics.Enemies[14].MaxHealth = 120;
            EnemyBasics.Enemies[14].Level = 8;
            EnemyBasics.Enemies[14].ArmorValue = 7;

            // Giant		
            EnemyBasics.Enemies[16].MinDamage = 10;
            EnemyBasics.Enemies[16].MaxDamage = 30;
            EnemyBasics.Enemies[16].MinHealth = 80;
            EnemyBasics.Enemies[16].MaxHealth = 110;
            EnemyBasics.Enemies[16].Level = 10;
            EnemyBasics.Enemies[16].ArmorValue = 5;

            // Zombie		
            EnemyBasics.Enemies[17].MinDamage = 1;
            EnemyBasics.Enemies[17].MaxDamage = 5;
            EnemyBasics.Enemies[17].MinHealth = 60;
            EnemyBasics.Enemies[17].MaxHealth = 100;
            EnemyBasics.Enemies[17].Level = 5;
            EnemyBasics.Enemies[17].ArmorValue = 7;

            // Mummy		
            EnemyBasics.Enemies[19].MinDamage = 5;
            EnemyBasics.Enemies[19].MaxDamage = 15;
            EnemyBasics.Enemies[19].MinHealth = 100;
            EnemyBasics.Enemies[19].MaxHealth = 150;
            EnemyBasics.Enemies[19].Level = 15;
            EnemyBasics.Enemies[19].ArmorValue = -8;

            // Giant Scorpion		
            EnemyBasics.Enemies[20].MinDamage = 10;
            EnemyBasics.Enemies[20].MaxDamage = 15;
            EnemyBasics.Enemies[20].MinHealth = 15;
            EnemyBasics.Enemies[20].MaxHealth = 70;
            EnemyBasics.Enemies[20].Level = 4;
            EnemyBasics.Enemies[20].ArmorValue = 2;

            // Vampire Ancient		
            EnemyBasics.Enemies[30].MinDamage = 25;
            EnemyBasics.Enemies[30].MaxDamage = 60;
            EnemyBasics.Enemies[30].MinHealth = 80;
            EnemyBasics.Enemies[30].MaxHealth = 200;
            EnemyBasics.Enemies[30].Level = 20;
            EnemyBasics.Enemies[30].ArmorValue = -5;

            // Daedra Lord		
            EnemyBasics.Enemies[31].MinDamage = 40;
            EnemyBasics.Enemies[31].MaxDamage = 100;
            EnemyBasics.Enemies[31].MinHealth = 100;
            EnemyBasics.Enemies[31].MaxHealth = 240;
            EnemyBasics.Enemies[31].Level = 21;
            EnemyBasics.Enemies[31].ArmorValue = -12;

            // Lich		
            EnemyBasics.Enemies[32].MinDamage = 80;
            EnemyBasics.Enemies[32].MaxDamage = 110;
            EnemyBasics.Enemies[32].MinHealth = 60;
            EnemyBasics.Enemies[32].MaxHealth = 200;
            EnemyBasics.Enemies[32].Level = 20;
            EnemyBasics.Enemies[32].ArmorValue = -8;

            // Ancient Lich		
            EnemyBasics.Enemies[33].MinDamage = 100;
            EnemyBasics.Enemies[33].MaxDamage = 130;
            EnemyBasics.Enemies[33].MinHealth = 80;
            EnemyBasics.Enemies[33].MaxHealth = 210;
            EnemyBasics.Enemies[33].Level = 21;
            EnemyBasics.Enemies[33].ArmorValue = -12;

            // Orc		
            EnemyBasics.Enemies[7].MinDamage = 8;
            EnemyBasics.Enemies[7].MaxDamage = 20;
            EnemyBasics.Enemies[7].MinHealth = 20;
            EnemyBasics.Enemies[7].MaxHealth = 50;
            EnemyBasics.Enemies[7].Level = 6;
            EnemyBasics.Enemies[7].ArmorValue = 5;

            // Orc Sargeant		
            EnemyBasics.Enemies[12].MinDamage = 10;
            EnemyBasics.Enemies[12].MaxDamage = 30;
            EnemyBasics.Enemies[12].MinHealth = 40;
            EnemyBasics.Enemies[12].MaxHealth = 100;
            EnemyBasics.Enemies[12].Level = 9;
            EnemyBasics.Enemies[12].ArmorValue = 2;

            // Orc Shaman		
            EnemyBasics.Enemies[21].MinDamage = 8;
            EnemyBasics.Enemies[21].MaxDamage = 30;
            EnemyBasics.Enemies[21].MinHealth = 40;
            EnemyBasics.Enemies[21].MaxHealth = 110;
            EnemyBasics.Enemies[21].Level = 15;
            EnemyBasics.Enemies[21].ArmorValue = 6;

            // Orc Warlord		
            EnemyBasics.Enemies[24].MinDamage = 15;
            EnemyBasics.Enemies[24].MaxDamage = 50;
            EnemyBasics.Enemies[24].MinHealth = 60;
            EnemyBasics.Enemies[24].MaxHealth = 150;
            EnemyBasics.Enemies[24].Level = 19;
            EnemyBasics.Enemies[24].ArmorValue = -10;

            // Fire Atronach		
            EnemyBasics.Enemies[35].MinDamage = 15;
            EnemyBasics.Enemies[35].MaxDamage = 30;
            EnemyBasics.Enemies[35].MinHealth = 25;
            EnemyBasics.Enemies[35].MaxHealth = 130;
            EnemyBasics.Enemies[35].Level = 16;
            EnemyBasics.Enemies[35].ArmorValue = 6;

            // Iron Atronach		
            EnemyBasics.Enemies[36].MinDamage = 5;
            EnemyBasics.Enemies[36].MaxDamage = 15;
            EnemyBasics.Enemies[36].MinHealth = 25;
            EnemyBasics.Enemies[36].MaxHealth = 130;
            EnemyBasics.Enemies[36].Level = 21;
            EnemyBasics.Enemies[36].ArmorValue = 6;

            // Flesh Atronach		
            EnemyBasics.Enemies[37].MinDamage = 5;
            EnemyBasics.Enemies[37].MaxDamage = 15;
            EnemyBasics.Enemies[37].MinHealth = 100;
            EnemyBasics.Enemies[37].MaxHealth = 300;
            EnemyBasics.Enemies[37].Level = 16;
            EnemyBasics.Enemies[37].ArmorValue = 6;

            // Ice Atronach		
            EnemyBasics.Enemies[38].MinDamage = 5;
            EnemyBasics.Enemies[38].MaxDamage = 15;
            EnemyBasics.Enemies[38].MinHealth = 25;
            EnemyBasics.Enemies[38].MaxHealth = 130;
            EnemyBasics.Enemies[38].Level = 16;
            EnemyBasics.Enemies[38].ArmorValue = -1;

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

       
        
    }
}
