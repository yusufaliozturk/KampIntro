﻿using GameProject.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Entities
{
    public class Game:IEntity
    {
        public int GameId { get; set; }
        public string GameName{ get; set; }
        public float GamePrice{ get; set; }
    }
}
