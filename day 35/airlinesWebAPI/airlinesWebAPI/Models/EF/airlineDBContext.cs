using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace airlinesWebAPI.Models.EF
{
    public partial class airlineDBContext : DbContext
    {
        public airlineDBContext()
        {
        }

        public airlineDBContext(DbContextOptions<airlineDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Car> Cars { get; set; } = null!;
        public virtual DbSet<CarReservation> CarReservations { get; set; } = null!;
        public virtual DbSet<Customer> Customers { get; set; } = null!;
        public virtual DbSet<Flight> Flights { get; set; } = null!;
        public virtual DbSet<Hotel> Hotels { get; set; } = null!;
        public virtual DbSet<HotelReservation> HotelReservations { get; set; } = null!;
        public virtual DbSet<HotelRoom> HotelRooms { get; set; } = null!;
        public virtual DbSet<RentalAgency> RentalAgencies { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=tcp:nikhils-p2.database.windows.net,1433;Initial Catalog=airlineDB;Persist Security Info=False;User ID=trainer;Password=Password@1234;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Car>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AgencyId).HasColumnName("agency_id");

                entity.Property(e => e.CarId).HasColumnName("car_id");

                entity.Property(e => e.CarModel).HasColumnName("car_model");

                entity.Property(e => e.CarPrice).HasColumnName("car_price");

                entity.HasOne(d => d.Agency)
                    .WithMany()
                    .HasForeignKey(d => d.AgencyId)
                    .HasConstraintName("FK__Cars__agency_id__1BC821DD");
            });

            modelBuilder.Entity<CarReservation>(entity =>
            {
                entity.HasKey(e => e.ReservationId)
                    .HasName("PK__carReser__31384C29311D783D");

                entity.ToTable("carReservation");

                entity.Property(e => e.ReservationId)
                    .ValueGeneratedNever()
                    .HasColumnName("reservation_id");

                entity.Property(e => e.AgencyId).HasColumnName("agency_id");

                entity.Property(e => e.CarId).HasColumnName("car_id");

                entity.Property(e => e.CheckIn)
                    .HasColumnType("date")
                    .HasColumnName("check_in");

                entity.Property(e => e.CheckOut)
                    .HasColumnType("date")
                    .HasColumnName("check_out");

                entity.HasOne(d => d.Agency)
                    .WithMany(p => p.CarReservations)
                    .HasForeignKey(d => d.AgencyId)
                    .HasConstraintName("FK__carReserv__agenc__29221CFB");
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.HasKey(e => e.CustId)
                    .HasName("PK__customer__9725F2C62A8CFA3A");

                entity.ToTable("customers");

                entity.Property(e => e.CustId).HasColumnName("custId");

                entity.Property(e => e.Balance).HasColumnName("balance");

                entity.Property(e => e.City)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("city");

                entity.Property(e => e.ContactNo).HasColumnName("contactNo");

                entity.Property(e => e.Country)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("country");

                entity.Property(e => e.EmailAdress)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("emailAdress");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("firstName");

                entity.Property(e => e.Flightid).HasColumnName("flightid");

                entity.Property(e => e.LastName)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("lastName");

                entity.HasOne(d => d.Flight)
                    .WithMany(p => p.Customers)
                    .HasForeignKey(d => d.Flightid)
                    .HasConstraintName("FK__customers__fligh__531856C7");
            });

            modelBuilder.Entity<Flight>(entity =>
            {
                entity.ToTable("flights");

                entity.Property(e => e.FlightId).HasColumnName("flightId");

                entity.Property(e => e.FromCity)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("fromCity");

                entity.Property(e => e.Landingtime)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("landingtime")
                    .HasDefaultValueSql("('08/10/2022 12:00 PM')");

                entity.Property(e => e.Price)
                    .HasColumnName("price")
                    .HasDefaultValueSql("((200))");

                entity.Property(e => e.Takeoff)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("takeoff")
                    .HasDefaultValueSql("('08/10/2022 10:00 AM')");

                entity.Property(e => e.ToCity)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("toCity");
            });

            modelBuilder.Entity<Hotel>(entity =>
            {
                entity.Property(e => e.HotelId)
                    .ValueGeneratedNever()
                    .HasColumnName("hotelId");

                entity.Property(e => e.HotelCity)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("hotelCity");

                entity.Property(e => e.HotelName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("hotelName");
            });

            modelBuilder.Entity<HotelReservation>(entity =>
            {
                entity.HasKey(e => e.ReservationId)
                    .HasName("PK__hotelRes__31384C2985522EBF");

                entity.ToTable("hotelReservation");

                entity.Property(e => e.ReservationId)
                    .ValueGeneratedNever()
                    .HasColumnName("reservation_id");

                entity.Property(e => e.CheckIn)
                    .HasColumnType("date")
                    .HasColumnName("check_in");

                entity.Property(e => e.CheckOut)
                    .HasColumnType("date")
                    .HasColumnName("check_out");

                entity.Property(e => e.HotelId).HasColumnName("hotel_id");

                entity.Property(e => e.RoomId).HasColumnName("room_id");

                entity.HasOne(d => d.Hotel)
                    .WithMany(p => p.HotelReservations)
                    .HasForeignKey(d => d.HotelId)
                    .HasConstraintName("FK__hotelRese__hotel__2645B050");
            });

            modelBuilder.Entity<HotelRoom>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("hotelRoom");

                entity.Property(e => e.HotelId).HasColumnName("hotel_id");

                entity.Property(e => e.RoomId).HasColumnName("room_id");

                entity.Property(e => e.RoomNum).HasColumnName("room_num");

                entity.Property(e => e.RoomPrice).HasColumnName("room_price");

                entity.HasOne(d => d.Hotel)
                    .WithMany()
                    .HasForeignKey(d => d.HotelId)
                    .HasConstraintName("FK__hotelRoom__hotel__1DB06A4F");
            });

            modelBuilder.Entity<RentalAgency>(entity =>
            {
                entity.HasKey(e => e.AgencyId)
                    .HasName("PK__RentalAg__0ED10D1E9BC66F76");

                entity.ToTable("RentalAgency");

                entity.Property(e => e.AgencyId)
                    .ValueGeneratedNever()
                    .HasColumnName("agencyId");

                entity.Property(e => e.AgencyLocation)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("agencyLocation");

                entity.Property(e => e.AgencyName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("agencyName");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
