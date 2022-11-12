using Fall2020_CSC403_Project.code;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGameLibrary
{
    public class Reward :BattleCharacter
    {
        public Image Img { get; set; }

        public Color Color { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="initPos">this is the health</param>
        /// <param name="collider">this is the health</param>
        public Reward(Vector2 initPos, Collider collider) : base(initPos, collider)
        {
        }
    }
}
