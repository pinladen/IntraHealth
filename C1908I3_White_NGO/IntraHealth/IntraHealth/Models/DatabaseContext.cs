using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace IntraHealth.Models
{
    public partial class DatabaseContext : DbContext
    {
        public DatabaseContext()
        {
        }

        public DatabaseContext(DbContextOptions<DatabaseContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AccountN> AccountNs { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<ContractUsN> ContractUsNs { get; set; }
        public virtual DbSet<Donate> Donates { get; set; }
        public virtual DbSet<EventN> EventNs { get; set; }
        public virtual DbSet<NotificationN> NotificationNs { get; set; }
        public virtual DbSet<OtherNgo> OtherNgos { get; set; }
        public virtual DbSet<OtherPartner> OtherPartners { get; set; }
        public virtual DbSet<Page> Pages { get; set; }
        public virtual DbSet<Role> Roles { get; set; }

        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<AccountN>(entity =>
            {
                entity.HasKey(e => e.IdUser)
                    .HasName("PK__AccountN__3717C982091B4C86");

                entity.ToTable("AccountN");

                entity.Property(e => e.IdUser).HasColumnName("idUser");

                entity.Property(e => e.AvatarUser)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("avatarUser");

                entity.Property(e => e.BrithdayUser)
                    .HasColumnType("date")
                    .HasColumnName("brithdayUser");

                entity.Property(e => e.EmailUser)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("emailUser");

                entity.Property(e => e.FistNameUser)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("fistNameUser");

                entity.Property(e => e.IdRole).HasColumnName("idRole");

                entity.Property(e => e.LastNameUser)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("lastNameUser");

                entity.Property(e => e.NicknameUser)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("nicknameUser");

                entity.Property(e => e.PasswordUser)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("passwordUser");

                entity.Property(e => e.PhoneUser).HasColumnName("phoneUser");

                entity.Property(e => e.StatusUser).HasColumnName("statusUser");

                entity.Property(e => e.TimeCreateUser)
                    .HasColumnType("datetime")
                    .HasColumnName("timeCreateUser");

                entity.Property(e => e.UsernameUser)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("usernameUser");

                entity.HasOne(d => d.IdRoleNavigation)
                    .WithMany(p => p.AccountNs)
                    .HasForeignKey(d => d.IdRole)
                    .HasConstraintName("FK__AccountN__idRole__35BCFE0A");
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.HasKey(e => e.IdCategory)
                    .HasName("PK__Category__79D361B6235116B7");

                entity.ToTable("Category");

                entity.Property(e => e.IdCategory).HasColumnName("idCategory");

                entity.Property(e => e.NameCategory)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("nameCategory");

                entity.Property(e => e.StatusCategory).HasColumnName("statusCategory");
            });

            modelBuilder.Entity<ContractUsN>(entity =>
            {
                entity.HasKey(e => e.IdContractUs)
                    .HasName("PK__Contract__9AD82F24FC3F98A3");

                entity.ToTable("ContractUsN");

                entity.Property(e => e.IdContractUs).HasColumnName("idContractUs");

                entity.Property(e => e.DateCreate)
                    .HasColumnType("datetime")
                    .HasColumnName("dateCreate");

                entity.Property(e => e.Details)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("details");

                entity.Property(e => e.IdUser).HasColumnName("idUser");

                entity.Property(e => e.StatusContratcus).HasColumnName("statusContratcus");

                entity.HasOne(d => d.IdUserNavigation)
                    .WithMany(p => p.ContractUsNs)
                    .HasForeignKey(d => d.IdUser)
                    .HasConstraintName("FK__ContractU__idUse__398D8EEE");
            });

            modelBuilder.Entity<Donate>(entity =>
            {
                entity.HasKey(e => e.IdDonate)
                    .HasName("PK__Donate__C4D3F650D39828BF");

                entity.ToTable("Donate");

                entity.Property(e => e.IdDonate).HasColumnName("idDonate");

                entity.Property(e => e.AmoutDonate)
                    .HasColumnType("money")
                    .HasColumnName("amoutDonate");

                entity.Property(e => e.IdEvent).HasColumnName("idEvent");

                entity.Property(e => e.IdUser).HasColumnName("idUser");

                entity.Property(e => e.NoteDonate)
                    .HasMaxLength(550)
                    .IsUnicode(false)
                    .HasColumnName("noteDonate");

                entity.Property(e => e.QuantityDonate).HasColumnName("quantityDonate");

                entity.Property(e => e.StatusDonate).HasColumnName("statusDonate");

                entity.Property(e => e.TimeDonate)
                    .HasColumnType("datetime")
                    .HasColumnName("timeDonate");

                entity.HasOne(d => d.IdEventNavigation)
                    .WithMany(p => p.Donates)
                    .HasForeignKey(d => d.IdEvent)
                    .HasConstraintName("FK__Donate__idEvent__38996AB5");

                entity.HasOne(d => d.IdUserNavigation)
                    .WithMany(p => p.Donates)
                    .HasForeignKey(d => d.IdUser)
                    .HasConstraintName("FK__Donate__idUser__37A5467C");
            });

            modelBuilder.Entity<EventN>(entity =>
            {
                entity.HasKey(e => e.IdEvent)
                    .HasName("PK__EventN__B7EA7D764FDA91A2");

                entity.ToTable("EventN");

                entity.Property(e => e.IdEvent).HasColumnName("idEvent");

                entity.Property(e => e.AddressEvent)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("addressEvent");

                entity.Property(e => e.AmoutAchievedEvent)
                    .HasColumnType("money")
                    .HasColumnName("amoutAchievedEvent");

                entity.Property(e => e.AuthorEvent)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("authorEvent");

                entity.Property(e => e.ContentEvent)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("contentEvent");

                entity.Property(e => e.EndDateEvent)
                    .HasColumnType("date")
                    .HasColumnName("endDateEvent");

                entity.Property(e => e.MoutEvent)
                    .HasColumnType("money")
                    .HasColumnName("moutEvent");

                entity.Property(e => e.NameEvent)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("nameEvent");

                entity.Property(e => e.PhotoEvent)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("photoEvent");

                entity.Property(e => e.StartDateEvent)
                    .HasColumnType("date")
                    .HasColumnName("startDateEvent");

                entity.Property(e => e.StatusEvent).HasColumnName("statusEvent");

                entity.Property(e => e.TimeCreateEvent)
                    .HasColumnType("datetime")
                    .HasColumnName("timeCreateEvent");
            });

            modelBuilder.Entity<NotificationN>(entity =>
            {
                entity.HasKey(e => e.IdNotification)
                    .HasName("PK__Notifica__22C023219DAAFB5B");

                entity.ToTable("NotificationN");

                entity.Property(e => e.IdNotification).HasColumnName("idNotification");

                entity.Property(e => e.FromAdmin)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("fromAdmin");

                entity.Property(e => e.IdUser).HasColumnName("idUser");

                entity.Property(e => e.SendTimeNotification)
                    .HasColumnType("datetime")
                    .HasColumnName("sendTimeNotification");

                entity.Property(e => e.StatusNotification).HasColumnName("statusNotification");

                entity.Property(e => e.TextNotification)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("textNotification");

                entity.HasOne(d => d.IdUserNavigation)
                    .WithMany(p => p.NotificationNs)
                    .HasForeignKey(d => d.IdUser)
                    .HasConstraintName("FK__Notificat__idUse__36B12243");
            });

            modelBuilder.Entity<OtherNgo>(entity =>
            {
                entity.HasKey(e => e.IdNgo)
                    .HasName("PK__OtherNGO__3FFDD91FBC594C97");

                entity.ToTable("OtherNGO");

                entity.Property(e => e.IdNgo).HasColumnName("idNGO");

                entity.Property(e => e.InforNgo)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("inforNGO");

                entity.Property(e => e.JoinDateNgo)
                    .HasColumnType("date")
                    .HasColumnName("joinDateNGO");

                entity.Property(e => e.NameNgo)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("nameNGO");

                entity.Property(e => e.StatusNgo).HasColumnName("statusNGO");

                entity.Property(e => e.UrlNgo)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("urlNGO");
            });

            modelBuilder.Entity<OtherPartner>(entity =>
            {
                entity.HasKey(e => e.IdPartner)
                    .HasName("PK__OtherPar__4D67B84F2C9203CD");

                entity.Property(e => e.IdPartner).HasColumnName("idPartner");

                entity.Property(e => e.CompanyPt)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("companyPt");

                entity.Property(e => e.EmailPt)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("emailPt");

                entity.Property(e => e.JoinDatePt)
                    .HasColumnType("date")
                    .HasColumnName("joinDatePt");

                entity.Property(e => e.LogoPt)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("logoPt");

                entity.Property(e => e.NamePt)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("namePT");

                entity.Property(e => e.PhonePt).HasColumnName("phonePt");

                entity.Property(e => e.StatusPt).HasColumnName("statusPt");
            });

            modelBuilder.Entity<Page>(entity =>
            {
                entity.HasKey(e => e.IdPage)
                    .HasName("PK__Pages__BD2295B31F0F3300");

                entity.Property(e => e.IdPage).HasColumnName("idPage");

                entity.Property(e => e.AuthorPage)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("authorPage");

                entity.Property(e => e.ContentPage)
                    .IsUnicode(false)
                    .HasColumnName("contentPage");

                entity.Property(e => e.IdCategory).HasColumnName("idCategory");

                entity.Property(e => e.NamePage)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("namePage");

                entity.Property(e => e.PhotoPage)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("photoPage");

                entity.Property(e => e.StatusPage).HasColumnName("statusPage");

                entity.Property(e => e.TimeCreatePage)
                    .HasColumnType("datetime")
                    .HasColumnName("timeCreatePage");

                entity.Property(e => e.TitlePage)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("titlePage");

                entity.HasOne(d => d.IdCategoryNavigation)
                    .WithMany(p => p.Pages)
                    .HasForeignKey(d => d.IdCategory)
                    .HasConstraintName("FK__Pages__idCategor__3A81B327");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.HasKey(e => e.IdRole)
                    .HasName("PK__Roles__E5045C547AF450A0");

                entity.Property(e => e.IdRole).HasColumnName("idRole");

                entity.Property(e => e.NameRole)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nameRole");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
