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
    [Migration("20180410001838_Scores")]
    partial class Scores
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.2-rtm-10011")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TableTop2017CoreWeb.Models.Player", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("currentOpponentid");

                    b.Property<string>("emailAddress");

                    b.Property<string>("firstName");

                    b.Property<bool>("hasPaid");

                    b.Property<string>("lastName");

                    b.Property<string>("notes");

                    b.Property<int>("roundBattleScore");

                    b.Property<int>("sportsmanshipScore");

                    b.Property<int>("totalBattleScore");

                    b.HasKey("id");

                    b.HasIndex("currentOpponentid");

                    b.ToTable("Players");
                });

            modelBuilder.Entity("TableTop2017CoreWeb.Models.RoundMatchups", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("battlePoints");

                    b.Property<int?>("opponentid");

                    b.Property<int?>("playerid");

                    b.Property<int>("roundNo");

                    b.Property<string>("sportsmanshipPoints");

                    b.Property<int>("table");

                    b.HasKey("id");

                    b.HasIndex("opponentid");

                    b.HasIndex("playerid");

                    b.ToTable("RoundMatchups");
                });

            modelBuilder.Entity("TableTop2017CoreWeb.Models.Player", b =>
                {
                    b.HasOne("TableTop2017CoreWeb.Models.Player", "currentOpponent")
                        .WithMany()
                        .HasForeignKey("currentOpponentid");
                });

            modelBuilder.Entity("TableTop2017CoreWeb.Models.RoundMatchups", b =>
                {
                    b.HasOne("TableTop2017CoreWeb.Models.Player", "opponent")
                        .WithMany()
                        .HasForeignKey("opponentid");

                    b.HasOne("TableTop2017CoreWeb.Models.Player", "player")
                        .WithMany()
                        .HasForeignKey("playerid");
                });
#pragma warning restore 612, 618
        }
    }
}
