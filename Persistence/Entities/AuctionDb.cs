﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DistLab2.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;

namespace DistLab2.Persistence
{
    public class AuctionDb
    {
        [Key]
        public int Id { get; set; }


        [Required]
        [MaxLength (128)]
        public string Name { get; set; }


        
        [Required]
        public string Description { get; set; }


        [Required]
        public int StartingPrice { get; set; }
       
        
        [Required]
        [DataType(DataType.DateTime)]
        public DateTime CreatedDate { get; set; }

       
        [Required]
        [DataType(DataType.DateTime)] 
        public DateTime EndDate { get; set; }
        
        public List<BidDb> Bids{ get; set; }=new List<BidDb>();//todo tog bort virtual för lazy loading


        //// Relation to UsertDb and virtuell for lazyloading
        //[ForeignKey("User")]
        ////public string UserId { get; set; }
        //public UserDb User {get;set;}

        // Foreign key for the user
        [ForeignKey("User")]
        public string UserId { get; set; }
        public virtual UserDb User { get; set; }
       
        public byte[] Image { get; set; }

           public string ToString(){
            return $"Auction = [Id: {Id}, Name: {Name}, Username:{UserId}, StartAmount: " +
            $"{StartingPrice}, CreatedDate: {CreatedDate}, EndDate: {EndDate}]";
        }

    }
}
