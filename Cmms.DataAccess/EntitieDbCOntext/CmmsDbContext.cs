﻿using Cmms.Domain.Entities;
using Cmms.Domain.Entities.Equipments;
using Cmms.Domain.Entities.Quest;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Cmms.DataAccess.EntitieDbCOntext
{
    public class CmmsDbContext : IdentityDbContext
    {

        public CmmsDbContext()
        {
        }

        public CmmsDbContext(DbContextOptions<CmmsDbContext> options) : base(options)
        {
        }

        public DbSet<UserProfile> UserProfileS { get; set; }


        public DbSet<Equipment> Equipments { get; set; }
        public DbSet<EquipmentSet> EquipmentSets { get; set; }
        public DbSet<EquipmentSetToEquipment> EquipmentSetToEquipments { get; set; }
        
        public DbSet<Quest> Quests { get; set; }
        public DbSet<QuestType> QuestTypes { get; set; }
        public DbSet<QuestToEquipment> QuestToEquipments { get; set; }
        public DbSet<QuestToUser> QuestToUsers { get; set; }

        



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<UserProfile>()
                .OwnsOne(up => up.UserProfileBasicInfo);

            modelBuilder.Entity<Quest>()
             .Property(a => a.Name)
             .IsRequired();


            modelBuilder.Entity<EquipmentSet>()
            .Property(a => a.Name)
            .IsRequired();





        }
    }
}
