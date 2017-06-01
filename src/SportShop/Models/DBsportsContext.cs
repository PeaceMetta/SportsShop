using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace SportShop.Models
{
    public partial class DBsportsContext : DbContext
    {
       public DBsportsContext(DbContextOptions<DBsportsContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Address>(entity =>
            {
                entity.HasKey(e => e.ObjId)
                    .HasName("PK__Address__530A638C28297F7F");

                entity.Property(e => e.ObjId)
                    .HasColumnName("objId")
                    .ValueGeneratedNever();

                entity.Property(e => e.Area)
                    .HasColumnName("area")
                    .HasColumnType("text");

                entity.Property(e => e.City)
                    .HasColumnName("city")
                    .HasColumnType("text");

                entity.Property(e => e.HouseId).HasColumnName("houseId");

                entity.Property(e => e.Road)
                    .HasColumnName("road")
                    .HasColumnType("text");

                entity.Property(e => e.Street)
                    .HasColumnName("street")
                    .HasColumnType("text");

                entity.Property(e => e.ZipCode).HasColumnName("zipCode");
            });

            modelBuilder.Entity<AspNetRoleClaims>(entity =>
            {
                entity.HasIndex(e => e.RoleId)
                    .HasName("IX_AspNetRoleClaims_RoleId");

                entity.Property(e => e.RoleId)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetRoleClaims)
                    .HasForeignKey(d => d.RoleId);
            });

            modelBuilder.Entity<AspNetRoles>(entity =>
            {
                entity.HasIndex(e => e.NormalizedName)
                    .HasName("RoleNameIndex");

                entity.Property(e => e.Id).HasMaxLength(450);

                entity.Property(e => e.Name).HasMaxLength(256);

                entity.Property(e => e.NormalizedName).HasMaxLength(256);
            });

            modelBuilder.Entity<AspNetUserClaims>(entity =>
            {
                entity.HasIndex(e => e.UserId)
                    .HasName("IX_AspNetUserClaims_UserId");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserClaims)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserLogins>(entity =>
            {
                entity.HasKey(e => new { e.LoginProvider, e.ProviderKey })
                    .HasName("PK_AspNetUserLogins");

                entity.HasIndex(e => e.UserId)
                    .HasName("IX_AspNetUserLogins_UserId");

                entity.Property(e => e.LoginProvider).HasMaxLength(450);

                entity.Property(e => e.ProviderKey).HasMaxLength(450);

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserLogins)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserRoles>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.RoleId })
                    .HasName("PK_AspNetUserRoles");

                entity.HasIndex(e => e.RoleId)
                    .HasName("IX_AspNetUserRoles_RoleId");

                entity.HasIndex(e => e.UserId)
                    .HasName("IX_AspNetUserRoles_UserId");

                entity.Property(e => e.UserId).HasMaxLength(450);

                entity.Property(e => e.RoleId).HasMaxLength(450);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.RoleId);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserTokens>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.LoginProvider, e.Name })
                    .HasName("PK_AspNetUserTokens");

                entity.Property(e => e.UserId).HasMaxLength(450);

                entity.Property(e => e.LoginProvider).HasMaxLength(450);

                entity.Property(e => e.Name).HasMaxLength(450);
            });

            modelBuilder.Entity<AspNetUsers>(entity =>
            {
                entity.HasIndex(e => e.NormalizedEmail)
                    .HasName("EmailIndex");

                entity.HasIndex(e => e.NormalizedUserName)
                    .HasName("UserNameIndex")
                    .IsUnique();

                entity.Property(e => e.Id).HasMaxLength(450);

                entity.Property(e => e.Email).HasMaxLength(256);

                entity.Property(e => e.NormalizedEmail).HasMaxLength(256);

                entity.Property(e => e.NormalizedUserName)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.UserName).HasMaxLength(256);
            });

            modelBuilder.Entity<Cart>(entity =>
            {
                entity.HasKey(e => e.ObjId)
                    .HasName("PK__Cart__530A638C8A685978");

                entity.Property(e => e.ObjId)
                    .HasColumnName("objId")
                    .ValueGeneratedNever();

                entity.Property(e => e.Amount).HasColumnName("amount");

                entity.Property(e => e.Price).HasColumnName("price");

                entity.Property(e => e.Product)
                    .IsRequired()
                    .HasColumnName("product")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<ContactMethod>(entity =>
            {
                entity.HasKey(e => e.ObjId)
                    .HasName("PK__contactM__530A638C2494CC77");

                entity.ToTable("contactMethod");

                entity.Property(e => e.ObjId)
                    .HasColumnName("objId")
                    .ValueGeneratedNever();

                entity.Property(e => e.Emial)
                    .HasColumnName("emial")
                    .HasColumnType("text");

                entity.Property(e => e.HomePhone)
                    .HasColumnName("homePhone")
                    .HasColumnType("text");

                entity.Property(e => e.MobilePhone)
                    .HasColumnName("mobilePhone")
                    .HasColumnType("text");

                entity.Property(e => e.OfficePhone)
                    .HasColumnName("officePhone")
                    .HasColumnType("text");

                entity.Property(e => e.QqNumber)
                    .HasColumnName("qqNumber")
                    .HasColumnType("text");
            });

            modelBuilder.Entity<Favor>(entity =>
            {
                entity.HasKey(e => e.ObjId)
                    .HasName("PK__Favor__530A638CC0171F8F");

                entity.Property(e => e.ObjId)
                    .HasColumnName("objId")
                    .ValueGeneratedNever();

                entity.Property(e => e.Amount).HasColumnName("amount");

                entity.Property(e => e.Price).HasColumnName("price");

                entity.Property(e => e.Product)
                    .IsRequired()
                    .HasColumnName("product")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<Payment>(entity =>
            {
                entity.HasKey(e => e.ObjId)
                    .HasName("PK__Payment__530A638C0E80E075");

                entity.Property(e => e.ObjId)
                    .HasColumnName("objId")
                    .ValueGeneratedNever();

                entity.Property(e => e.Money).HasColumnName("money");

                entity.Property(e => e.Paytime).HasColumnName("paytime");

                entity.Property(e => e.Payway)
                    .IsRequired()
                    .HasColumnName("payway")
                    .HasColumnType("text");

                entity.Property(e => e.TradeNo).HasColumnName("tradeNo");

                entity.Property(e => e.UserId).HasColumnName("userId");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasColumnName("userName")
                    .HasColumnType("text");
            });

            modelBuilder.Entity<Products>(entity =>
            {
                entity.HasKey(e => e.ObjId)
                    .HasName("PK__Products__530A638C404BE5F7");

                entity.Property(e => e.ObjId)
                    .HasColumnName("objId")
                    .ValueGeneratedNever();

                entity.Property(e => e.Code).HasColumnName("code");

                entity.Property(e => e.Intro)
                    .HasColumnName("intro")
                    .HasMaxLength(30);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(20);

                entity.Property(e => e.Price).HasColumnName("price");

                entity.Property(e => e.Spintro)
                    .HasColumnName("spintro")
                    .HasColumnType("text");
            });

            modelBuilder.Entity<Receiver>(entity =>
            {
                entity.HasKey(e => e.ObjId)
                    .HasName("PK__Receiver__530A638CBD47C1AE");

                entity.Property(e => e.ObjId)
                    .HasColumnName("objId")
                    .ValueGeneratedNever();

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasColumnName("address")
                    .HasColumnType("text");

                entity.Property(e => e.Area)
                    .IsRequired()
                    .HasColumnName("area")
                    .HasColumnType("text");

                entity.Property(e => e.ContactMehod)
                    .HasColumnName("contactMehod")
                    .HasColumnType("text");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("text");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.HasKey(e => e.ObjId)
                    .HasName("PK__Role__530A638C1578F779");

                entity.Property(e => e.ObjId)
                    .HasColumnName("objId")
                    .ValueGeneratedNever();

                entity.Property(e => e.RoleName)
                    .IsRequired()
                    .HasColumnName("roleName")
                    .HasColumnType("text");
            });

            modelBuilder.Entity<ShopOrder>(entity =>
            {
                entity.HasKey(e => e.ObjId)
                    .HasName("PK__ShopOrde__530A638C1FACDCB7");

                entity.Property(e => e.ObjId)
                    .HasColumnName("objId")
                    .ValueGeneratedNever();

                entity.Property(e => e.Money).HasColumnName("money");

                entity.Property(e => e.OrderState).HasColumnName("orderState");

                entity.Property(e => e.OrderTime)
                    .HasColumnName("orderTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.Product)
                    .HasColumnName("product")
                    .HasColumnType("text");

                entity.Property(e => e.TheClerk).HasColumnName("theClerk");

                entity.Property(e => e.ThePayment).HasColumnName("thePayment");

                entity.Property(e => e.TheReceiver)
                    .HasColumnName("theReceiver")
                    .HasColumnType("text");

                entity.Property(e => e.TheSender).HasColumnName("theSender");

                entity.Property(e => e.TheUser)
                    .IsRequired()
                    .HasColumnName("theUser")
                    .HasColumnType("text");

                entity.HasOne(d => d.TheClerkNavigation)
                    .WithMany(p => p.ShopOrderTheClerkNavigation)
                    .HasForeignKey(d => d.TheClerk)
                    .HasConstraintName("FK__ShopOrder__theCl__2D27B809");

                entity.HasOne(d => d.TheSenderNavigation)
                    .WithMany(p => p.ShopOrderTheSenderNavigation)
                    .HasForeignKey(d => d.TheSender)
                    .HasConstraintName("FK__ShopOrder__theSe__2E1BDC42");
            });

            modelBuilder.Entity<ShopUser>(entity =>
            {
                entity.HasKey(e => e.ObjId)
                    .HasName("PK__ShopUser__530A638C13B6E60F");

                entity.Property(e => e.ObjId)
                    .HasColumnName("objId")
                    .ValueGeneratedNever();

                entity.Property(e => e.ContactMethod)
                    .HasColumnName("contactMethod")
                    .HasColumnType("text");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasColumnName("password")
                    .HasColumnType("text");

                entity.Property(e => e.TheRole).HasColumnName("theRole");

                entity.Property(e => e.UserId).HasColumnName("userId");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasColumnName("userName")
                    .HasColumnType("text");

                entity.HasOne(d => d.TheRoleNavigation)
                    .WithMany(p => p.ShopUser)
                    .HasForeignKey(d => d.TheRole)
                    .HasConstraintName("FK__ShopUser__theRol__239E4DCF");
            });

            modelBuilder.Entity<ShoppingCart>(entity =>
            {
                entity.HasKey(e => e.MId)
                    .HasName("PK__Shopping__DF513ED4A8B44035");

                entity.Property(e => e.MId)
                    .HasColumnName("mId")
                    .ValueGeneratedNever();

                entity.Property(e => e.Cart)
                    .HasColumnName("cart")
                    .HasColumnType("text");
            });

            modelBuilder.Entity<Sort>(entity =>
            {
                entity.HasKey(e => e.ObjId)
                    .HasName("PK__Sort__530A638C93768D94");

                entity.Property(e => e.ObjId)
                    .HasColumnName("objId")
                    .ValueGeneratedNever();

                entity.Property(e => e.Product)
                    .IsRequired()
                    .HasColumnName("product")
                    .HasMaxLength(20);

                entity.Property(e => e.Sortproduct)
                    .IsRequired()
                    .HasColumnName("sortproduct")
                    .HasMaxLength(10);
            });
        }

        public virtual DbSet<Address> Address { get; set; }
        public virtual DbSet<AspNetRoleClaims> AspNetRoleClaims { get; set; }
        public virtual DbSet<AspNetRoles> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaims> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogins> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUserRoles> AspNetUserRoles { get; set; }
        public virtual DbSet<AspNetUserTokens> AspNetUserTokens { get; set; }
        public virtual DbSet<AspNetUsers> AspNetUsers { get; set; }
        public virtual DbSet<Cart> Cart { get; set; }
        public virtual DbSet<ContactMethod> ContactMethod { get; set; }
        public virtual DbSet<Favor> Favor { get; set; }
        public virtual DbSet<Payment> Payment { get; set; }
        public virtual DbSet<Products> Products { get; set; }
        public virtual DbSet<Receiver> Receiver { get; set; }
        public virtual DbSet<Role> Role { get; set; }
        public virtual DbSet<ShopOrder> ShopOrder { get; set; }
        public virtual DbSet<ShopUser> ShopUser { get; set; }
        public virtual DbSet<ShoppingCart> ShoppingCart { get; set; }
        public virtual DbSet<Sort> Sort { get; set; }

        // Unable to generate entity type for table 'dbo.Favorites'. Please see the warning messages.
    }
}