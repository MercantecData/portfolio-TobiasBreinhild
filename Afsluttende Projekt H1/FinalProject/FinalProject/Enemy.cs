﻿using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject
{
    class Enemy
    {

        public string difficulty;
        public int enemyHP;
        public int enemyDMG;
        public int xpAmount;

        public Enemy(string difficulty, int enemyHP, int enemyDMG, int xpAmount)
        {
            this.difficulty = difficulty;
            this.enemyHP = enemyHP;
            this.enemyDMG = enemyDMG;
            this.xpAmount = xpAmount;
        }
    }
}
