﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using products.Infrustructure;

#nullable disable

namespace products.Infrustructure.Migrations
{
    [DbContext(typeof(ProductDBContext))]
    partial class ProductDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("products.Domain.Base.Categories.Category", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<bool>("Active")
                        .HasColumnType("boolean");

                    b.Property<string>("BannerUrl")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasDefaultValue("https://via.placeholder.com/500x100.png");

                    b.Property<DateTime>("CreationDateTime")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValue(new DateTime(2022, 3, 6, 10, 53, 52, 760, DateTimeKind.Utc).AddTicks(7950));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(5000)
                        .HasColumnType("character varying(5000)");

                    b.Property<string>("IconUrl")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasDefaultValue("https://via.placeholder.com/85.png");

                    b.Property<DateTime>("ModificationDateTime")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValue(new DateTime(2022, 3, 6, 10, 53, 52, 760, DateTimeKind.Utc).AddTicks(8190));

                    b.Property<int?>("ParentCategoryId")
                        .HasColumnType("integer");

                    b.Property<string>("Permalink")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)");

                    b.Property<int>("Priority")
                        .HasColumnType("integer");

                    b.Property<string>("ThumbnailUrl")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasDefaultValue("https://via.placeholder.com/150x150.png");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)");

                    b.HasKey("id");

                    b.HasIndex("ParentCategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            id = 1,
                            Active = false,
                            CreationDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Aliquip Lorem deserunt cupidatat deserunt sit qui excepteur. Ea aliquip eu irure et fugiat esse sit duis ad cillum mollit. Consectetur exercitation qui ea mollit enim ipsum excepteur. In velit aliqua adipisicing velit non in nisi commodo cupidatat Lorem voluptate labore. Enim cillum do ullamco proident ullamco ex Lorem consequat elit veniam sunt minim Lorem.\r\n",
                            ModificationDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Permalink = "Lancaster-Greene",
                            Priority = 4,
                            Title = "Baird Moreno"
                        },
                        new
                        {
                            id = 2,
                            Active = false,
                            CreationDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Adipisicing in aliquip duis excepteur laborum ullamco commodo duis consectetur elit labore sint. Eiusmod duis esse ex deserunt ipsum id adipisicing occaecat veniam proident ad. Occaecat officia enim eu laboris et in nulla nulla voluptate ad. Ullamco eiusmod reprehenderit amet ad enim. Sit Lorem cillum consectetur amet minim officia nulla. Ex ipsum Lorem consequat adipisicing.\r\n",
                            ModificationDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Permalink = "Bullock-Odonnell",
                            Priority = 1,
                            Title = "Carr Simmons"
                        },
                        new
                        {
                            id = 3,
                            Active = false,
                            CreationDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Reprehenderit nisi anim irure irure officia laborum incididunt anim. Laborum laborum adipisicing adipisicing incididunt velit labore dolor ut. Consectetur culpa ut nisi officia excepteur reprehenderit ad eu consequat voluptate sint.\r\n",
                            ModificationDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Permalink = "Walker-Rose",
                            Priority = 3,
                            Title = "Barrera Hogan"
                        },
                        new
                        {
                            id = 4,
                            Active = false,
                            CreationDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Ullamco est eiusmod sint laboris elit esse. Adipisicing minim dolore irure ut tempor culpa non consequat nostrud Lorem mollit aliquip. Aliquip nisi Lorem laborum nostrud eiusmod nisi anim officia eiusmod anim culpa. Qui elit cillum id eiusmod.\r\n",
                            ModificationDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Permalink = "Karyn-Mccullough",
                            Priority = 2,
                            Title = "Carrillo Maddox"
                        },
                        new
                        {
                            id = 5,
                            Active = true,
                            CreationDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Pariatur proident eu velit consectetur ullamco. Velit do esse magna esse proident incididunt laborum elit enim occaecat incididunt anim fugiat. Lorem deserunt adipisicing excepteur et. Dolor officia et in ex id fugiat. Culpa elit ullamco enim eu amet pariatur eiusmod do.\r\n",
                            ModificationDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Permalink = "Keith-Underwood",
                            Priority = 1,
                            Title = "Mccray Hoover"
                        },
                        new
                        {
                            id = 6,
                            Active = true,
                            CreationDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "In culpa commodo Lorem reprehenderit consectetur consectetur. Esse elit exercitation enim non mollit ea deserunt nisi nostrud consequat labore duis proident. Fugiat sint mollit Lorem quis voluptate reprehenderit tempor ut velit elit amet. Deserunt veniam officia incididunt reprehenderit.\r\n",
                            ModificationDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ParentCategoryId = 1,
                            Permalink = "Kris-Schultz",
                            Priority = 5,
                            Title = "Nelson Mckinney"
                        },
                        new
                        {
                            id = 7,
                            Active = true,
                            CreationDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Dolor qui ad exercitation in anim proident aliquip consectetur. Eu eiusmod laboris proident reprehenderit reprehenderit anim exercitation dolore culpa occaecat eu nostrud eiusmod sunt. Occaecat deserunt ullamco occaecat non cillum tempor. Cupidatat sint ad ipsum elit ad mollit exercitation. Esse aliquip sunt proident laborum cillum esse nulla do mollit. Laborum est veniam veniam occaecat tempor laboris qui do elit incididunt. Nulla aliquip cupidatat ex voluptate eu id sint aliquip incididunt enim.\r\n",
                            ModificationDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ParentCategoryId = 2,
                            Permalink = "Mays-Dennis",
                            Priority = 4,
                            Title = "Violet Clarke"
                        },
                        new
                        {
                            id = 8,
                            Active = true,
                            CreationDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Deserunt nisi sint magna magna ad fugiat esse culpa ipsum cillum ullamco. Minim fugiat duis reprehenderit sint nisi exercitation qui cupidatat duis velit ut in cillum eiusmod. Ea aliquip sunt et qui ea ipsum aliqua minim ex ad culpa ea. Labore qui in tempor eu voluptate duis cupidatat aliqua do veniam dolore Lorem. Labore cupidatat Lorem sunt ad aliquip eiusmod non culpa pariatur ullamco do exercitation sunt minim.\r\n",
                            ModificationDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ParentCategoryId = 3,
                            Permalink = "Lewis-Avila",
                            Priority = 2,
                            Title = "Krystal Johnson"
                        },
                        new
                        {
                            id = 9,
                            Active = false,
                            CreationDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Magna aute adipisicing amet deserunt sint quis dolor mollit nisi officia qui reprehenderit duis occaecat. Consequat sit sit quis dolore sunt nulla cupidatat et tempor consectetur duis labore elit. Aute adipisicing ullamco incididunt fugiat esse aliqua elit velit. Culpa amet aute do velit anim pariatur. Pariatur ex quis ex dolor est qui. Non velit anim et laboris adipisicing nostrud proident do proident mollit elit minim. Occaecat mollit proident nostrud nisi irure ipsum amet incididunt dolore magna ex.\r\n",
                            ModificationDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ParentCategoryId = 4,
                            Permalink = "Kirk-Spence",
                            Priority = 1,
                            Title = "Mack Ross"
                        },
                        new
                        {
                            id = 10,
                            Active = false,
                            CreationDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Ullamco cupidatat tempor proident deserunt elit occaecat magna est aute. Aliqua excepteur aliquip anim dolore deserunt irure. Ullamco ex nulla ipsum mollit velit aliqua mollit. Deserunt enim quis tempor est esse pariatur aliquip nulla proident officia ullamco commodo. Fugiat qui ipsum officia non sint. Sit reprehenderit aute Lorem nisi quis aliquip culpa sunt cupidatat.\r\n",
                            ModificationDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ParentCategoryId = 9,
                            Permalink = "Dona-Soto",
                            Priority = 1,
                            Title = "Patel Castaneda"
                        });
                });

            modelBuilder.Entity("products.Domain.Base.Products.Product", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<bool>("Active")
                        .HasColumnType("boolean");

                    b.Property<int>("CategoryId")
                        .HasColumnType("integer");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<string>("CoverImageUrl")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasDefaultValue("https://via.placeholder.com/150x150.png");

                    b.Property<DateTime>("CreationDateTime")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValue(new DateTime(2022, 3, 6, 10, 53, 52, 761, DateTimeKind.Utc).AddTicks(2985));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(5000)
                        .HasColumnType("character varying(5000)");

                    b.Property<DateTime>("ModificationDateTime")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValue(new DateTime(2022, 3, 6, 10, 53, 52, 761, DateTimeKind.Utc).AddTicks(3230));

                    b.Property<string>("Permalink")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<decimal>("Price")
                        .HasColumnType("numeric");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)");

                    b.HasKey("id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            id = 1,
                            Active = true,
                            CategoryId = 10,
                            Code = "James",
                            CreationDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Quis consequat eiusmod qui aliqua. Mollit nisi minim non eu et fugiat minim sunt dolor deserunt reprehenderit. Cillum velit aliqua aute ipsum. Non commodo voluptate enim eiusmod. Magna pariatur reprehenderit aliqua officia incididunt in.\r\n",
                            ModificationDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Permalink = "Myers-Pierce",
                            Price = 0m,
                            Title = "Lilia Greer"
                        },
                        new
                        {
                            id = 2,
                            Active = false,
                            CategoryId = 10,
                            Code = "Nielsen",
                            CreationDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Irure exercitation duis magna adipisicing labore ullamco reprehenderit enim ut id excepteur tempor veniam incididunt. Nostrud dolor incididunt enim aute nulla est exercitation enim. Elit officia magna est aliquip pariatur ex sit sint id.\r\n",
                            ModificationDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Permalink = "Colette-Barker",
                            Price = 0m,
                            Title = "Mcintosh Rhodes"
                        },
                        new
                        {
                            id = 3,
                            Active = true,
                            CategoryId = 7,
                            Code = "Avis",
                            CreationDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Sint nostrud velit voluptate aute laboris proident Lorem ea. Laboris nulla officia voluptate do enim mollit mollit quis nostrud. Sint fugiat deserunt voluptate consectetur commodo officia eiusmod ut laborum. Lorem cillum laborum cillum voluptate in ullamco anim ad sint nulla consectetur irure.\r\n",
                            ModificationDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Permalink = "Buck-Espinoza",
                            Price = 0m,
                            Title = "Joni Gross"
                        },
                        new
                        {
                            id = 4,
                            Active = false,
                            CategoryId = 8,
                            Code = "Juliet",
                            CreationDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Tempor officia aliquip ea reprehenderit pariatur amet. Ut aliquip anim excepteur magna ea eiusmod eiusmod occaecat laboris. Ipsum voluptate pariatur amet cillum esse nulla occaecat reprehenderit id officia qui. Occaecat laboris adipisicing proident et labore nisi cillum in nostrud irure ipsum aute sunt nostrud. Non ea voluptate irure eu velit veniam. Incididunt cupidatat mollit consectetur eiusmod aute in reprehenderit enim duis esse occaecat excepteur cillum. Eiusmod enim ipsum eiusmod tempor Lorem est qui aute voluptate consectetur irure in.\r\n",
                            ModificationDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Permalink = "Perkins-Jarvis",
                            Price = 0m,
                            Title = "Campbell Foster"
                        },
                        new
                        {
                            id = 5,
                            Active = false,
                            CategoryId = 5,
                            Code = "Alisha",
                            CreationDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Adipisicing in irure eiusmod aliqua labore. Velit dolore qui ut consectetur qui amet aute commodo incididunt. Velit veniam adipisicing nisi laborum ea id. Esse sint consequat irure ipsum non labore.\r\n",
                            ModificationDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Permalink = "Deirdre-Dale",
                            Price = 0m,
                            Title = "Ruth Hobbs"
                        },
                        new
                        {
                            id = 6,
                            Active = false,
                            CategoryId = 4,
                            Code = "Margo",
                            CreationDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Laboris fugiat commodo laborum esse non tempor nostrud tempor occaecat velit. Aliqua voluptate sit dolor consectetur ut commodo labore irure dolor in consequat. Sint cillum non eu commodo. Proident anim minim eu nulla labore incididunt in aliquip magna deserunt irure quis culpa. Velit qui consequat veniam id minim. Cillum commodo nostrud cupidatat eu pariatur in Lorem velit minim.\r\n",
                            ModificationDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Permalink = "Nellie-Wallace",
                            Price = 0m,
                            Title = "Dianne Simon"
                        },
                        new
                        {
                            id = 7,
                            Active = false,
                            CategoryId = 2,
                            Code = "Tina",
                            CreationDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Laboris in Lorem veniam commodo dolor esse mollit quis amet id reprehenderit labore duis ex. Non proident cupidatat duis occaecat dolore. Non deserunt deserunt adipisicing sint dolor reprehenderit reprehenderit Lorem excepteur anim. Dolor esse minim velit aute anim nostrud et sunt quis labore. Non incididunt culpa amet sit veniam magna nulla proident adipisicing exercitation ipsum nostrud.\r\n",
                            ModificationDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Permalink = "Carmen-Garrett",
                            Price = 0m,
                            Title = "Trisha Mathews"
                        },
                        new
                        {
                            id = 8,
                            Active = false,
                            CategoryId = 7,
                            Code = "Becker",
                            CreationDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Enim duis ea labore fugiat minim amet ullamco. Deserunt exercitation duis dolore commodo velit. Officia nisi laboris cupidatat amet laboris exercitation esse sunt. Commodo enim consequat in adipisicing eiusmod nulla laboris.\r\n",
                            ModificationDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Permalink = "Tia-Fitzgerald",
                            Price = 0m,
                            Title = "Lacey Good"
                        });
                });

            modelBuilder.Entity("products.Domain.Base.Categories.Category", b =>
                {
                    b.HasOne("products.Domain.Base.Categories.Category", "ParentCategory")
                        .WithMany()
                        .HasForeignKey("ParentCategoryId");

                    b.Navigation("ParentCategory");
                });

            modelBuilder.Entity("products.Domain.Base.Products.Product", b =>
                {
                    b.HasOne("products.Domain.Base.Categories.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("products.Domain.Base.Categories.Category", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
