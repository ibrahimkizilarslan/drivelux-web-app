using Microsoft.EntityFrameworkCore;
using DriveLux.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriveLux.Persistence.Context
{
    public class DriveLuxContext : DbContext
    {
        public DriveLuxContext()
        {
        }
        public DriveLuxContext(DbContextOptions<DriveLuxContext> options) : base(options)
        {

        }

        public DbSet<About> Abouts { get; set; }
        public DbSet<Banner> Banners { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<CarDescription> CarDescriptions { get; set; }
        public DbSet<CarFeatures> CarFeatures { get; set; }
        public DbSet<CarPricing> CarPricings { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Features> Features { get; set; }
        public DbSet<FooterAddress> FooterAddresses { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Pricing> Pricings { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<SocialMedia> SocialMedias { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<TagCloud> TagClouds { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<RentCar> RentCars { get; set; }      

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Reservation>().HasOne(r => r.PickUpLocation)
                .WithMany(l => l.PickUpReservation)
                .HasForeignKey(r => r.PickUpLocationID)
                .OnDelete(DeleteBehavior.ClientSetNull);

            modelBuilder.Entity<Reservation>().HasOne(r => r.DropOffLocation)
                .WithMany(l => l.DropOffReservation)
                .HasForeignKey(r => r.DropOffLocationID)
                .OnDelete(DeleteBehavior.ClientSetNull);
        }
    }
}
