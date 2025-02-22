﻿namespace CourseApp
{
    public abstract class Weapon
    {
        private ushort shoot;
        private float caliber;
        private ushort year;

        public float Caliber
        {
            get
            {
                return caliber;
            }

            set
            {
                if (value > 0 && value < 20)
                {
                    caliber = value;
                }
            }
        }

        public ushort Year
        {
            get
            {
                return year;
            }

            set
            {
                if (value > 1600)
                {
                    year = value;
                }
            }
        }

        public string Model { get; set; }

        public string Owner { get; set; }

        public void Shoot()
        {
            shoot++;
        }

        public override string ToString()
        {
            return $"Shoots: {shoot}";
        }
    }
}
