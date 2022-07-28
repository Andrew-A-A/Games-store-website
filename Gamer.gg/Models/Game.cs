using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.EntitySql;
using System.Linq;
using System.Web;

namespace Gamer.gg.Models
{
    public class Game
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Image { get; set; }
        public string Trailer { get; set; }
        public string Description { get; set; }
        public int genre { get; set; }
        public string Requirements { get; set; }
        public int Price { get; set; }

        public String getGenre()
        {
            String Genre;
            switch (genre)
            {
                case 0:
                    Genre = "Action";
                    break;
                case 1:
                    Genre = "Puzzle";
                    break;
                case 2:
                    Genre = "Simulation";
                    break;
                case 3:
                    Genre = "Racing";
                    break;
                case 4:
                    Genre = "Shooting";
                    break;
                case 5:
                    Genre = "Horror";
                    break;
                case 6:
                    Genre = "Strategy";
                    break;
                default:
                    Genre = "List";
                    break;
            }

                return Genre;
        }
    }
    
}