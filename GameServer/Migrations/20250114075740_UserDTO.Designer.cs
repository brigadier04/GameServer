﻿// <auto-generated />
using GameServer.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GameServer.Migrations
{
    [DbContext(typeof(GameContext))]
    [Migration("20250114075740_UserDTO")]
    partial class UserDTO
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("GameServer.Models.User", b =>
                {
                    b.Property<string>("id")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("nickName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("numCoins")
                        .HasColumnType("int");

                    b.Property<int>("numEnergies")
                        .HasColumnType("int");

                    b.Property<int>("numStars")
                        .HasColumnType("int");

                    b.Property<string>("sessionId")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("id");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
