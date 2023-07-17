﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Visitor
{
    public class Score
    {
        public int Value => _enemyVisiter.Score;

        private IEnemyDeathNotifier _enemyDeathNotifier;

        private EnemyVisiter _enemyVisiter;

        public Score(IEnemyDeathNotifier enemyDeathNotifier)
        {
            _enemyDeathNotifier = enemyDeathNotifier;
            _enemyDeathNotifier.Notified += OnEnemyDied;

            _enemyVisiter = new EnemyVisiter();
        }

        ~Score() => _enemyDeathNotifier.Notified -= OnEnemyDied;

        private void OnEnemyDied(Enemy enemy)
        {
            _enemyVisiter.Visit(enemy);
            Debug.Log($"СЧет: {Value}");
        }

        private class EnemyVisiter : IEnemyVisitor
        {
            public int Score { get; private set; }

            public void Visit(Ork ork) => Score += 20;

            public void Visit(Human human) => Score += 5;

            public void Visit(Elf elf) => Score += 10;
            public void Visit(Robot robot) => Score += 20;

            public void Visit(Enemy enemy) => Visit((dynamic)enemy);
        }
    }
}
