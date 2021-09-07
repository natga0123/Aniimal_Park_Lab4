﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_Park
{
    [Serializable]
    class Horse : Mammal
    {
        private UInt32 Maxspeed;
        private FoodSchedule foodSchedule;

        public Horse(UInt32 Tail_Length, String Color) : base(Tail_Length, Color)
        {
            this.Maxspeed = 0;
            this.SetFoodSchedule();
        }
        public UInt32 maxspeed
        {
            get { return Maxspeed; }
            set { Maxspeed = value; }
        }
        public override string ToString()
        {
            String str_out = base.ToString();
            str_out += ";" +
                       "Max Speed: " + " * " + Maxspeed.ToString();
            return str_out;
        }
        public override string GetExtraInfo()
        {
            String str_out = base.GetExtraInfo();
            str_out += ";" +
                       "Max Speed: " + " * " + Maxspeed.ToString();
            return str_out;
        }
        private void SetFoodSchedule()
        {
            foodSchedule = new FoodSchedule();
            foodSchedule.EaterType = EaterType.Herbivore;
            foodSchedule.Add("Morning: Gras; ");
            foodSchedule.Add("Lunch: More gras; ");
            foodSchedule.Add("Evening: Even more gras; ");

        }

        public override FoodSchedule GetFoodSchedule()
        {
            return foodSchedule;
        }
    }
}
