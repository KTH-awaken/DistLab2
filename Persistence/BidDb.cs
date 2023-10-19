﻿using DistLab2.Core;

namespace DistLab2.Persistence
{
    public class BidDb
    {
        public int Id { get; set; }
        public decimal Amount { get; set; }
        public DateTime CreatedTime { get; set; }

        //forign key för användren som placeade budet
        public int UserId { get; set; }
        public User User { get; set; }

        //forign key för auctionen
        public int AuctionId { get; set; }
        public AuctionDb AuctionDb { get; set; }
    }

}