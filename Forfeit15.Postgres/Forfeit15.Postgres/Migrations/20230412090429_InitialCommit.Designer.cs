﻿// <auto-generated />
using System;
using Forfeit15.Postgres.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Forfeit15.Postgres.Migrations
{
    [DbContext(typeof(PatchNoteDbContext))]
    [Migration("20230412090429_InitialCommit")]
    partial class InitialCommit
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Forfeit15.Postgres.Models.Nodes.InfoNode", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("NodeType")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid?>("PatchNoteId")
                        .HasColumnType("uuid");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("PatchNoteId");

                    b.ToTable("InfoNodes", (string)null);

                    b.HasDiscriminator<string>("NodeType").HasValue("InfoNode");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("Forfeit15.Postgres.Models.PatchNote", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("PatchNotes");
                });

            modelBuilder.Entity("Forfeit15.Postgres.Models.Nodes.ImageNode", b =>
                {
                    b.HasBaseType("Forfeit15.Postgres.Models.Nodes.InfoNode");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasDiscriminator().HasValue("Image");
                });

            modelBuilder.Entity("Forfeit15.Postgres.Models.Nodes.TextNode", b =>
                {
                    b.HasBaseType("Forfeit15.Postgres.Models.Nodes.InfoNode");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasDiscriminator().HasValue("Text");
                });

            modelBuilder.Entity("Forfeit15.Postgres.Models.Nodes.InfoNode", b =>
                {
                    b.HasOne("Forfeit15.Postgres.Models.PatchNote", null)
                        .WithMany("InfoNodes")
                        .HasForeignKey("Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Forfeit15.Postgres.Models.PatchNote", "PatchNote")
                        .WithMany()
                        .HasForeignKey("PatchNoteId");

                    b.Navigation("PatchNote");
                });

            modelBuilder.Entity("Forfeit15.Postgres.Models.PatchNote", b =>
                {
                    b.Navigation("InfoNodes");
                });
#pragma warning restore 612, 618
        }
    }
}
