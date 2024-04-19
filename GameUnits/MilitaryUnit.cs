using System;

namespace GameUnits
{
    public class MilitaryUnit : XPUnit
    {
        public int AttackPower { get; }

        public MilitaryUnit(int mov, int health, int attackPower) : base(mov, health)
        {
            AttackPower = attackPower;
        }

        public override float Cost => AttackPower + XP;

        public void Attack(Unit u)
        {
            XP++;
            u.Health -= AttackPower;
        }

        public override string ToString()
        {
            return $"{base.ToString()} AP={AttackPower}";
        }
    }
}
