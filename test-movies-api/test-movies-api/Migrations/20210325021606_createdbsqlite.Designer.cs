// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using test_movies_api.Models;

namespace test_movies_api.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20210325021606_createdbsqlite")]
    partial class createdbsqlite
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.4");

            modelBuilder.Entity("test_movies_api.Models.MovieRating", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("idMovie")
                        .HasColumnType("INTEGER");

                    b.Property<int>("lvlCast")
                        .HasColumnType("INTEGER");

                    b.Property<int>("lvlPhotography")
                        .HasColumnType("INTEGER");

                    b.Property<int>("lvlScript")
                        .HasColumnType("INTEGER");

                    b.Property<int>("lvlSpecialEffects")
                        .HasColumnType("INTEGER");

                    b.HasKey("id");

                    b.ToTable("MovieLevels");
                });
#pragma warning restore 612, 618
        }
    }
}
