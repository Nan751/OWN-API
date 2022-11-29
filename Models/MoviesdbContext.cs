using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Movieapi.Models;

public partial class MoviesdbContext : DbContext
{
    public MoviesdbContext()
    {
    }

    public MoviesdbContext(DbContextOptions<MoviesdbContext> options)
        : base(options)
    {
    }


    public virtual DbSet<Movie> Movies { get; set; }

  

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
{
    
}
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
       
        modelBuilder.Entity<Movie>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__movies__3214EC2727960AAB");

            entity.ToTable("movies");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Images).HasColumnName("IMAGES");
            entity.Property(e => e.Title)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TITLE");
            entity.Property(e => e.Year).HasColumnName("YEAR");
        });

      
        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
