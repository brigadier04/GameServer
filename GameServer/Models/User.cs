﻿namespace GameServer.Models
{
    public class User
    {
        public required string id { get; set; }
        public required string nickName { get; set; }
        public required string sessionId { get; set; }
        
        public int numCoins {  get; set; }
        public int numStars {  get; set; }
        public int numEnergies { get; set; }
    }
}