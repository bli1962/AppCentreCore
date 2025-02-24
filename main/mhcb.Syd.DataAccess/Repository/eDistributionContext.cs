using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using mhcb.Syd.DataAccess.Models.EDistribution;

namespace mhcb.Syd.DataAccess.Repository
{
    public partial class eDistributionContext : DbContext
    {
        public eDistributionContext()
        {
        }

        public eDistributionContext(DbContextOptions<eDistributionContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Channel> Channels { get; set; }
        public virtual DbSet<Distribution> Distributions { get; set; }
        public virtual DbSet<DistributionStatus> DistributionStatuses { get; set; }
        public virtual DbSet<GenericFtpConfig> GenericFtpConfigs { get; set; }
        public virtual DbSet<GenericFtpDirection> GenericFtpDirections { get; set; }
        public virtual DbSet<GenericFtpLog> GenericFtpLogs { get; set; }
        public virtual DbSet<NetWrixAuditError> NetWrixAuditErrors { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //To protect potentially sensitive information in your connection string, 
                //you should move it out of source code. 
                //You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration 
                //- see https://go.microsoft.com/fwlink/?linkid=2131148. 
                //For more guidance on storing connection strings, 
                //see http://go.microsoft.com/fwlink/?LinkId=723263.

                //optionsBuilder.UseSqlServer("Data Source=MIZSQLP06;Initial Catalog=eDistribution;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Channel>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<Distribution>(entity =>
            {
                entity.Property(e => e.CustomerCode).IsFixedLength();

                entity.Property(e => e.DateAdded).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Status).IsFixedLength();

                entity.HasOne(d => d.Channel)
                    .WithMany(p => p.Distributions)
                    .HasForeignKey(d => d.ChannelId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Distributions_Channel");

                entity.HasOne(d => d.StatusNavigation)
                    .WithMany(p => p.Distributions)
                    .HasForeignKey(d => d.Status)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Distributions_DistributionStatus");
            });

            modelBuilder.Entity<DistributionStatus>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasDefaultValueSql("('P')")
                    .IsFixedLength();
            });

            modelBuilder.Entity<GenericFtpConfig>(entity =>
            {
                entity.HasOne(d => d.Direction)
                    .WithMany(p => p.GenericFtpConfigs)
                    .HasForeignKey(d => d.DirectionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GenericFtpConfig_GenericFtpConfig");
            });

            modelBuilder.Entity<GenericFtpDirection>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<GenericFtpLog>(entity =>
            {
                entity.Property(e => e.DateAdded).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.Direction)
                    .WithMany(p => p.GenericFtpLogs)
                    .HasForeignKey(d => d.DirectionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GenericFtpLog_GenericFtpDirection");
            });

            modelBuilder.Entity<NetWrixAuditError>(entity =>
            {
                entity.HasKey(e => e.ErrorId)
                    .HasName("PK_NetWrix_ErrorID")
                    .IsClustered(false);

                entity.HasIndex(e => e.ErrorTime, "NetWrixErrorTimeClustered")
                    .IsClustered();

                entity.Property(e => e.ErrorId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Application).HasDefaultValueSql("(app_name())");

                entity.Property(e => e.DataBaseName).HasDefaultValueSql("(db_name())");

                entity.Property(e => e.ErrorTime).HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.Workstation).HasDefaultValueSql("(host_name())");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
