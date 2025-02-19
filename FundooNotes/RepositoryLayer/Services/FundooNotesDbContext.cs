﻿using RepositoryLayer.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;



namespace RepositoryLayer.Services
{
    public class FundooNotesDbContext : DbContext
    {


        public FundooNotesDbContext(DbContextOptions db) : base(db)
        {

        }

        public DbSet<User> users { get; set; }
        public DbSet<Notes> notes { get; set; }
        public  DbSet<Label> label { get; set; }
        public DbSet<UserAddress> Address { get; set; }
        public DbSet<Collabarator> collabarators { get; set; }

        protected override void

       OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
            .HasIndex(u => u.email)
            .IsUnique();
            modelBuilder.Entity<UserAddress>()
            .Property(b => b.Type)
            .HasDefaultValue("Home");
            /*modelBuilder.Entity<UserAddress>()
                .HasOne(u => u.User)
                .WithMany()
                .HasForeignKey(u => u.Userid)
                .OnDelete(DeleteBehavior.Cascade); //Cascade behaviour*/
        }                                         

        




    }



}

