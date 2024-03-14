﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Restourant.DataAccess.Postgres;

#nullable disable

namespace Restourant.DataAccess.Postgres.Migrations
{
    [DbContext(typeof(RestourantDbContext))]
    partial class RestourantDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Restourant.DataAccess.Postgres.Models.CategoryDish", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("CategoryDishes");
                });

            modelBuilder.Entity("Restourant.DataAccess.Postgres.Models.Check", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.HasKey("Id");

                    b.ToTable("Checks");
                });

            modelBuilder.Entity("Restourant.DataAccess.Postgres.Models.Client", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("FIO")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("Restourant.DataAccess.Postgres.Models.Dish", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryDishId")
                        .HasColumnType("integer");

                    b.Property<int>("CheckId")
                        .HasColumnType("integer");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Recipe")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("CategoryDishId");

                    b.HasIndex("CheckId");

                    b.ToTable("Dishes");
                });

            modelBuilder.Entity("Restourant.DataAccess.Postgres.Models.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("FIO")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("RoleId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("Restourant.DataAccess.Postgres.Models.Ingridient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("DishId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("DishId");

                    b.ToTable("Ingridients");
                });

            modelBuilder.Entity("Restourant.DataAccess.Postgres.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("CheckId")
                        .HasColumnType("integer");

                    b.Property<int>("ClientId")
                        .HasColumnType("integer");

                    b.Property<string>("Date")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("EmployeeId")
                        .HasColumnType("integer");

                    b.Property<double>("Price")
                        .HasColumnType("double precision");

                    b.HasKey("Id");

                    b.HasIndex("CheckId");

                    b.HasIndex("ClientId");

                    b.HasIndex("EmployeeId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("Restourant.DataAccess.Postgres.Models.RoleEmployee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("Restourant.DataAccess.Postgres.Models.Dish", b =>
                {
                    b.HasOne("Restourant.DataAccess.Postgres.Models.CategoryDish", "CategoryDish")
                        .WithMany("Dishes")
                        .HasForeignKey("CategoryDishId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Restourant.DataAccess.Postgres.Models.Check", "Check")
                        .WithMany("Dishes")
                        .HasForeignKey("CheckId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CategoryDish");

                    b.Navigation("Check");
                });

            modelBuilder.Entity("Restourant.DataAccess.Postgres.Models.Employee", b =>
                {
                    b.HasOne("Restourant.DataAccess.Postgres.Models.RoleEmployee", "Role")
                        .WithMany("Employees")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");
                });

            modelBuilder.Entity("Restourant.DataAccess.Postgres.Models.Ingridient", b =>
                {
                    b.HasOne("Restourant.DataAccess.Postgres.Models.Dish", "Dish")
                        .WithMany("Ingridients")
                        .HasForeignKey("DishId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Dish");
                });

            modelBuilder.Entity("Restourant.DataAccess.Postgres.Models.Order", b =>
                {
                    b.HasOne("Restourant.DataAccess.Postgres.Models.Check", "Check")
                        .WithMany("Orders")
                        .HasForeignKey("CheckId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Restourant.DataAccess.Postgres.Models.Client", "Client")
                        .WithMany("Orders")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Restourant.DataAccess.Postgres.Models.Employee", "Employee")
                        .WithMany("Orders")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Check");

                    b.Navigation("Client");

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("Restourant.DataAccess.Postgres.Models.CategoryDish", b =>
                {
                    b.Navigation("Dishes");
                });

            modelBuilder.Entity("Restourant.DataAccess.Postgres.Models.Check", b =>
                {
                    b.Navigation("Dishes");

                    b.Navigation("Orders");
                });

            modelBuilder.Entity("Restourant.DataAccess.Postgres.Models.Client", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("Restourant.DataAccess.Postgres.Models.Dish", b =>
                {
                    b.Navigation("Ingridients");
                });

            modelBuilder.Entity("Restourant.DataAccess.Postgres.Models.Employee", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("Restourant.DataAccess.Postgres.Models.RoleEmployee", b =>
                {
                    b.Navigation("Employees");
                });
#pragma warning restore 612, 618
        }
    }
}
