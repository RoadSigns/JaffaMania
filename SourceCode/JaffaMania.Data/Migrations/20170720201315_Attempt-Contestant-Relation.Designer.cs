using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using JaffaMania.Data;

namespace JaffaMania.Data.Migrations
{
    [DbContext(typeof(JafamaniaDbContext))]
    [Migration("20170720201315_Attempt-Contestant-Relation")]
    partial class AttemptContestantRelation
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("JaffaMania.Data.DataModel.AttemptDto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("ContestantId");

                    b.Property<DateTime>("HappenedOn");

                    b.Property<string>("PublicId");

                    b.Property<TimeSpan>("TimeTaken");

                    b.HasKey("Id");

                    b.HasIndex("ContestantId");

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
                    b.HasOne("JaffaMania.Data.DataModel.ContestantDto", "Contestant")
                        .WithMany("AttemptsMade")
                        .HasForeignKey("ContestantId");
                });
        }
    }
}
