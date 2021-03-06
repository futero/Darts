﻿// <auto-generated />
using Darts.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace Darts.Migrations
{
    [DbContext(typeof(DartsContext))]
    [Migration("20180129202533_AddGameType")]
    partial class AddGameType
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Darts.Models.GameType", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("ChangeDateTime");

                    b.Property<Guid>("Guid");

                    b.Property<DateTime>("InsertDateTime");

                    b.Property<string>("Name");

                    b.HasKey("ID");

                    b.ToTable("GameType");
                });

            modelBuilder.Entity("Darts.Models.Player", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Birthdate");

                    b.Property<DateTime>("ChangeDateTime");

                    b.Property<string>("FirstName")
                        .IsRequired();

                    b.Property<string>("Gender")
                        .IsRequired();

                    b.Property<Guid>("Guid");

                    b.Property<DateTime>("InsertDateTime");

                    b.Property<string>("NickName");

                    b.Property<string>("SurName")
                        .IsRequired();

                    b.HasKey("ID");

                    b.ToTable("Player");
                });
#pragma warning restore 612, 618
        }
    }
}
