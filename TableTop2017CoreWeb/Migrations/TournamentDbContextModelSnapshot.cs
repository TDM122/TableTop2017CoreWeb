﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;
using TableTop2017CoreWeb.Data;

namespace TableTop2017CoreWeb.Migrations
{
    [DbContext(typeof(TournamentDbContext))]
    partial class TournamentDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.2-rtm-10011")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TableTop2017CoreWeb.Models.Player", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Active");

                    b.Property<string>("Army");

                    b.Property<int>("BattleScore");

                    b.Property<int?>("CurrentOpponentId");

                    b.Property<string>("EmailAddress");

                    b.Property<string>("Name");

                    b.Property<string>("Notes");

                    b.Property<bool>("Paid");

                    b.Property<int>("SportsmanshipScore");

                    b.HasKey("Id");

                    b.HasIndex("CurrentOpponentId");

                    b.ToTable("Players");
                });

            modelBuilder.Entity("TableTop2017CoreWeb.Models.RoundMatchups", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("PlayerOneBattleScore");

                    b.Property<int?>("PlayerOneId");

                    b.Property<string>("PlayerOneSportsmanshipScore");

                    b.Property<int>("PlayerTwoBattleScore");

                    b.Property<int?>("PlayerTwoId");

                    b.Property<string>("PlayerTwoSportsmanshipScore");

                    b.Property<int>("RoundNo");

                    b.Property<int>("Table");

                    b.HasKey("Id");

                    b.HasIndex("PlayerOneId");

                    b.HasIndex("PlayerTwoId");

                    b.ToTable("RoundMatchups");
                });

            modelBuilder.Entity("TableTop2017CoreWeb.Models.Player", b =>
                {
                    b.HasOne("TableTop2017CoreWeb.Models.Player", "CurrentOpponent")
                        .WithMany()
                        .HasForeignKey("CurrentOpponentId");
                });

            modelBuilder.Entity("TableTop2017CoreWeb.Models.RoundMatchups", b =>
                {
                    b.HasOne("TableTop2017CoreWeb.Models.Player", "PlayerOne")
                        .WithMany()
                        .HasForeignKey("PlayerOneId");

                    b.HasOne("TableTop2017CoreWeb.Models.Player", "PlayerTwo")
                        .WithMany()
                        .HasForeignKey("PlayerTwoId");
                });
#pragma warning restore 612, 618
        }
    }
}