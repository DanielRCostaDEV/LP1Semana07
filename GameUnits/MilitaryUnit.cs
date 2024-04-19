using System;

namespace GameUnits
{
    public class MilitaryUnit : Unit
    {
        public int AttackPower { get; }
        public int XP { get; private set; }

        public MilitaryUnit(int mov, int health, int attackPower) : base(mov, health)
        {
            AttackPower = attackPower;
            XP = 0;
        }

        public override int Health
        {
            get { return base.Health + XP; }
            set { base.Health = value; }
        }

        public override float Cost => AttackPower + XP;

        public void Attack(Unit u)
        {
            XP++;
            u.Health -= AttackPower;
        }
    }
}
