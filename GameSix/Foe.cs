namespace GameSix
{
    public class Foe
    {
        private string name;
        private float health;
        private float shield;
        private static int count;

        public Foe(string name)
        {
            this.name = SetName(name);
            health = 100;
            shield = 0;
        }



        public string GetName()
        {
            return name;
        }
        public void TakeDamage(float damage)
        {
            shield -= damage;
            if (shield < 0)
            {
                float damageStillToInflict = -shield;
                shield = 0;
                health -= damageStillToInflict;
                if (health < 0)
                {
                    health = 0;
                }
            }
        }
        public float GetHealth()
        {
            return health;
        }

        public float GetShield()
        {
            return shield;
        }
        public string SetName(string name)
        {
            return name.Trim();
        }

        public void PickupPowerUp(PowerUp powerUp, float value)
        {
            if (powerUp == PowerUp.Health)
            {
                health += value;
                if (health > 100)
                {
                    health = 100;
                }
            }
            if (powerUp == PowerUp.Shield)
            {
                shield += value;
                if (shield > 100)
                {
                    shield = 100;
                }
            }
            count++;
        }

        static Foe()
        {
            count = 0;
        }

        public static int GetCount()
        {
            return count;
        }


    }
}