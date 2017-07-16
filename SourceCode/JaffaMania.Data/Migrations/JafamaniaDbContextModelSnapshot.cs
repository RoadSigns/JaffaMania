using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using JaffaMania.Data;

namespace JaffaMania.Data.Migrations
{
    [DbContext(typeof(JafamaniaDbContext))]
    partial class JafamaniaDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("JaffaMania.Data.DataModel.AttemptDto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("ContestantDtoId");

                    b.Property<DateTime>("HappenedOn");

                    b.Property<string>("PublicId");

                    b.Property<TimeSpan>("TimeTaken");

                    b.HasKey("Id");

                    b.HasIndex("ContestantDtoId");

                    b.ToTable("Attempt");
                });

            modelBuilder.Entity("JaffaMania.Data.DataModel.ContestantDto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("FamilyName");

                    b.Property<string>("GivenName");

                    b.Property<string>("PublicId");

                    b.Property<string>("StageName");

                    b.HasKey("Id");

                    b.ToTable("Contestant");
                });

            modelBuilder.Entity("JaffaMania.Data.DataModel.AttemptDto", b =>
                {
                    b.HasOne("JaffaMania.Data.DataModel.ContestantDto")
                        .WithMany("AttemptsMade")
                        .HasForeignKey("ContestantDtoId");
                });
        }
    }
}
