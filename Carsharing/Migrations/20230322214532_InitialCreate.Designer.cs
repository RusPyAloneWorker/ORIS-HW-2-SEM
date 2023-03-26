﻿// <auto-generated />
using System;
using Carsharing;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Carsharing.Migrations
{
    [DbContext(typeof(CarsharingContext))]
    [Migration("20230322214532_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Carsharing.Model.CarModel", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("description");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.Property<string>("SourceImg")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("source_img");

                    b.Property<int?>("TarrifId")
                        .HasColumnType("integer")
                        .HasColumnName("tarrif_id");

                    b.HasKey("Id")
                        .HasName("car_model_pkey");

                    b.HasIndex("TarrifId");

                    b.HasIndex(new[] { "Name" }, "car_model_name_key")
                        .IsUnique();

                    b.HasIndex(new[] { "SourceImg" }, "car_model_source_img_key")
                        .IsUnique();

                    b.ToTable("car_model", (string)null);
                });

            modelBuilder.Entity("Carsharing.Model.CarPark", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    b.Property<int?>("CarModelId")
                        .HasColumnType("integer")
                        .HasColumnName("car_model_id");

                    b.Property<int>("GovermentNumber")
                        .HasColumnType("integer")
                        .HasColumnName("goverment_number");

                    b.Property<bool?>("IsOpened")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("boolean")
                        .HasColumnName("is_opened")
                        .HasDefaultValueSql("false");

                    b.Property<bool?>("IsTaken")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("boolean")
                        .HasColumnName("is_taken")
                        .HasDefaultValueSql("false");

                    b.HasKey("Id")
                        .HasName("car_park_pkey");

                    b.HasIndex("CarModelId");

                    b.HasIndex(new[] { "GovermentNumber" }, "car_park_goverment_number_key")
                        .IsUnique();

                    b.ToTable("car_park", (string)null);
                });

            modelBuilder.Entity("Carsharing.Model.Client", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("email");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("password");

                    b.Property<int>("RoleId")
                        .HasColumnType("integer")
                        .HasColumnName("role_id");

                    b.HasKey("Id")
                        .HasName("client_pkey");

                    b.HasIndex(new[] { "RoleId" }, "Role_id_unique")
                        .IsUnique();

                    b.ToTable("client", (string)null);
                });

            modelBuilder.Entity("Carsharing.Model.ClientInfo", b =>
                {
                    b.Property<string>("PassportType")
                        .HasColumnType("text")
                        .HasColumnName("passport_type");

                    b.Property<int>("PassportNum")
                        .HasColumnType("integer")
                        .HasColumnName("passport_num");

                    b.Property<int>("RiderNum")
                        .HasColumnType("integer")
                        .HasColumnName("rider_num");

                    b.Property<int>("TelephoneNum")
                        .HasColumnType("integer")
                        .HasColumnName("telephone_num");

                    b.Property<int>("Age")
                        .HasColumnType("integer")
                        .HasColumnName("age");

                    b.Property<int?>("Balance")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("balance")
                        .HasDefaultValueSql("0");

                    b.Property<int?>("CardNumber")
                        .HasColumnType("integer")
                        .HasColumnName("card_number");

                    b.Property<int>("ClientId")
                        .HasColumnType("integer")
                        .HasColumnName("client_id");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("surname");

                    b.HasKey("PassportType", "PassportNum", "RiderNum", "TelephoneNum")
                        .HasName("client_info_pkey");

                    b.HasIndex(new[] { "CardNumber" }, "client_info_card_number_key")
                        .IsUnique();

                    b.HasIndex(new[] { "ClientId" }, "client_info_client_id_key")
                        .IsUnique();

                    b.ToTable("client_info", (string)null);
                });

            modelBuilder.Entity("Carsharing.Model.Role", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    b.Property<string>("Name")
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.HasKey("Id")
                        .HasName("role_pkey");

                    b.ToTable("role", (string)null);
                });

            modelBuilder.Entity("Carsharing.Model.Subscription", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    b.Property<int?>("CarId")
                        .HasColumnType("integer")
                        .HasColumnName("car_id");

                    b.Property<int?>("ClientId")
                        .HasColumnType("integer")
                        .HasColumnName("client_id");

                    b.Property<DateOnly?>("EndDate")
                        .HasColumnType("date")
                        .HasColumnName("end_date");

                    b.Property<bool?>("IsActive")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("boolean")
                        .HasColumnName("is_active")
                        .HasDefaultValueSql("false");

                    b.Property<DateOnly?>("StartDate")
                        .HasColumnType("date")
                        .HasColumnName("start_date");

                    b.HasKey("Id")
                        .HasName("subscription_pkey");

                    b.HasIndex("CarId");

                    b.HasIndex("ClientId");

                    b.ToTable("subscription", (string)null);
                });

            modelBuilder.Entity("Carsharing.Model.Tarrif", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("description");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.Property<string>("Period")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("period");

                    b.Property<int>("Price")
                        .HasColumnType("integer")
                        .HasColumnName("price");

                    b.HasKey("Id")
                        .HasName("tarrif_pkey");

                    b.HasIndex(new[] { "Name" }, "tarrif_name_key")
                        .IsUnique();

                    b.HasIndex(new[] { "Period" }, "tarrif_period_key")
                        .IsUnique();

                    b.ToTable("tarrif", (string)null);
                });

            modelBuilder.Entity("Carsharing.Model.CarModel", b =>
                {
                    b.HasOne("Carsharing.Model.Tarrif", "Tarrif")
                        .WithMany("CarModels")
                        .HasForeignKey("TarrifId")
                        .HasConstraintName("car_model_tarrif_id_fkey");

                    b.Navigation("Tarrif");
                });

            modelBuilder.Entity("Carsharing.Model.CarPark", b =>
                {
                    b.HasOne("Carsharing.Model.CarModel", "CarModel")
                        .WithMany("CarParks")
                        .HasForeignKey("CarModelId")
                        .HasConstraintName("car_park_car_model_id_fkey");

                    b.Navigation("CarModel");
                });

            modelBuilder.Entity("Carsharing.Model.Client", b =>
                {
                    b.HasOne("Carsharing.Model.Role", "Role")
                        .WithOne("Client")
                        .HasForeignKey("Carsharing.Model.Client", "RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("client_role_id_fkey");

                    b.Navigation("Role");
                });

            modelBuilder.Entity("Carsharing.Model.ClientInfo", b =>
                {
                    b.HasOne("Carsharing.Model.Client", "Client")
                        .WithOne("ClientInfo")
                        .HasForeignKey("Carsharing.Model.ClientInfo", "ClientId")
                        .IsRequired()
                        .HasConstraintName("client_info_client_id_fkey");

                    b.Navigation("Client");
                });

            modelBuilder.Entity("Carsharing.Model.Subscription", b =>
                {
                    b.HasOne("Carsharing.Model.CarPark", "Car")
                        .WithMany("Subscriptions")
                        .HasForeignKey("CarId")
                        .HasConstraintName("subscription_car_id_fkey");

                    b.HasOne("Carsharing.Model.Client", "Client")
                        .WithMany("Subscriptions")
                        .HasForeignKey("ClientId")
                        .HasConstraintName("subscription_client_id_fkey");

                    b.Navigation("Car");

                    b.Navigation("Client");
                });

            modelBuilder.Entity("Carsharing.Model.CarModel", b =>
                {
                    b.Navigation("CarParks");
                });

            modelBuilder.Entity("Carsharing.Model.CarPark", b =>
                {
                    b.Navigation("Subscriptions");
                });

            modelBuilder.Entity("Carsharing.Model.Client", b =>
                {
                    b.Navigation("ClientInfo");

                    b.Navigation("Subscriptions");
                });

            modelBuilder.Entity("Carsharing.Model.Role", b =>
                {
                    b.Navigation("Client");
                });

            modelBuilder.Entity("Carsharing.Model.Tarrif", b =>
                {
                    b.Navigation("CarModels");
                });
#pragma warning restore 612, 618
        }
    }
}
