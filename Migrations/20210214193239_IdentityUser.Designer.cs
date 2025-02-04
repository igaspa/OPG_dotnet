﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OPG.Models;

namespace OPG.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20210214193239_IdentityUser")]
    partial class IdentityUser
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.3")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("OPG.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            Name = "Fruit"
                        },
                        new
                        {
                            CategoryId = 2,
                            Name = "Vegetables"
                        },
                        new
                        {
                            CategoryId = 3,
                            Name = "Dairy products and eggs"
                        },
                        new
                        {
                            CategoryId = 4,
                            Name = "Animal products"
                        });
                });

            modelBuilder.Entity("OPG.Models.OrderForm", b =>
                {
                    b.Property<int>("OrderFormId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address1")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Address2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("OrderPlaced")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("OrderTotal")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("ZipCode")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("OrderFormId");

                    b.ToTable("OrderForms");
                });

            modelBuilder.Entity("OPG.Models.OrderFormDetail", b =>
                {
                    b.Property<int>("OrderFormDetailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<int>("OrderFormId")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.HasKey("OrderFormDetailId");

                    b.HasIndex("OrderFormId");

                    b.HasIndex("ProductId");

                    b.ToTable("OrderFormDetails");
                });

            modelBuilder.Entity("OPG.Models.OrderItem", b =>
                {
                    b.Property<int>("OrderItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<string>("OrderId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ProductId")
                        .HasColumnType("int");

                    b.HasKey("OrderItemId");

                    b.HasIndex("ProductId");

                    b.ToTable("OrderItems");
                });

            modelBuilder.Entity("OPG.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<float>("Discount")
                        .HasColumnType("real");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("ProductDescription")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProductId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            CategoryId = 1,
                            Discount = 0f,
                            ImageUrl = "/images/apple.jpg",
                            Name = "Apple",
                            Price = 10m,
                            ProductDescription = "Apples are the ideal fruit to eat at any time, having a positive role in the achievement of nourish balance. Their skin may be green, yellow or reddish, and the meat taste ranges from a bitter to sweet flavour. It is one of the most consumed fruit in the world"
                        },
                        new
                        {
                            ProductId = 2,
                            CategoryId = 1,
                            Discount = 0f,
                            ImageUrl = "/images/pear.jpg",
                            Name = "Pear ",
                            Price = 10m,
                            ProductDescription = "The pear is a fruit that has expanded all over the world; it is consumed both fresh as cooked, and that is available all throughout the year. There are multiple varieties cultivated, ranging in shape, size and colour."
                        },
                        new
                        {
                            ProductId = 3,
                            CategoryId = 1,
                            Discount = 0f,
                            ImageUrl = "/images/lemon.jpg",
                            Name = "Lemon ",
                            Price = 14m,
                            ProductDescription = "The lemon is rounded and slightly elongated, it belongs to the family of citrus fruit and therefore it shares many of the characteristics of other species of citruses. The skin is yellow. It is used fresh for cooking, and its juice is used in the industry for processed foodstuffs."
                        },
                        new
                        {
                            ProductId = 4,
                            CategoryId = 1,
                            Discount = 0f,
                            ImageUrl = "/images/orange.jpg",
                            Name = "Orange ",
                            Price = 9m,
                            ProductDescription = "Oranges are highly valued for their vitamin C content. This wonderful fruit has more to offer nutritionally than just this one nutrient. Most of the consumption of oranges is in the form of juice. "
                        },
                        new
                        {
                            ProductId = 5,
                            CategoryId = 1,
                            Discount = 0f,
                            ImageUrl = "/images/plum.jpg",
                            Name = "Plum ",
                            Price = 5m,
                            ProductDescription = "The plum is a stone fruit, rounded or elongated that can be yellow, green, red or purple. In general, it is very nutritious and rich in vitamins, specially vitamin C. It is more or less juicy depending on its water content."
                        },
                        new
                        {
                            ProductId = 6,
                            CategoryId = 1,
                            Discount = 0f,
                            ImageUrl = "/images/strawberry.jpg",
                            Name = "Strawberry ",
                            Price = 20m,
                            ProductDescription = "Strawberries are highly appreciated for their pleasant aroma and as an appetite stimulator. It is rich in basic minerals, which confers it the property to stimulate the metabolism. It is eaten raw and used to make jam."
                        },
                        new
                        {
                            ProductId = 7,
                            CategoryId = 1,
                            Discount = 0f,
                            ImageUrl = "/images/blackberry.jpg",
                            Name = "Blackberry ",
                            Price = 25m,
                            ProductDescription = "Blackberries contain a wide array of important nutrients including potassium, magnesium and calcium, as well as vitamins A, C, E and most of our B vitamins. They are also a rich source of anthocyanins, powerful antioxidants that give blackberries their deep purple colour."
                        },
                        new
                        {
                            ProductId = 8,
                            CategoryId = 1,
                            Discount = 0f,
                            ImageUrl = "/images/raspberry.jpg",
                            Name = "Raspberry ",
                            Price = 28m,
                            ProductDescription = "Raspberries are a delicious fruit that are often described as being both tart and sweet. The riper that they are, the sweeter they will taste and the more intense their flavor will be."
                        },
                        new
                        {
                            ProductId = 9,
                            CategoryId = 1,
                            Discount = 0f,
                            ImageUrl = "/images/blueberry.jpg",
                            Name = "Blueberry ",
                            Price = 28m,
                            ProductDescription = "The blueberry pulp is aromatic, juicy and somewhat acid. It contains multiple small brown seeds. In the upper part, this fruit has a small crown that differentiates it from the black currant."
                        },
                        new
                        {
                            ProductId = 10,
                            CategoryId = 1,
                            Discount = 0f,
                            ImageUrl = "/images/grape.jpg",
                            Name = "Grape ",
                            Price = 5m,
                            ProductDescription = "The grape is a fruit that grows in tight clusters. It has a white or purple flesh of sweet taste, eaten raw or in juice, although it is chiefly used for making wine. It contains various minerals and vitamins, and it is considered to be antioxidant and anti-carcinogenic."
                        },
                        new
                        {
                            ProductId = 11,
                            CategoryId = 1,
                            Discount = 0f,
                            ImageUrl = "/images/watermelon.jpg",
                            Name = "Watermelon ",
                            Price = 5m,
                            ProductDescription = "The watermelon is a large fruit of a more or less spherical shape. It is usually eaten raw as table dessert. It has a sweet reddish or yellowish flesh. It is a very refreshing food that supplies very few calories. It also provides some vitamins and minerals."
                        },
                        new
                        {
                            ProductId = 12,
                            CategoryId = 1,
                            Discount = 0f,
                            ImageUrl = "/images/cherryy.jpg",
                            Name = "Cherry",
                            Price = 20m,
                            ProductDescription = "The cherry is a fruit that is consumed fresh or in cakes, mousses, jams and fruit stews. The larger cherries are usually the ones with better taste and texture."
                        },
                        new
                        {
                            ProductId = 13,
                            CategoryId = 2,
                            Discount = 0f,
                            ImageUrl = "/images/potato.jpg",
                            Name = "Potato",
                            Price = 6m,
                            ProductDescription = "The potato is one of the most cultivated products in the world. Its consumption is intended for human feeding in fresh, for cattle feeding and as raw material for the food and agriculture processing industries, such as chips, potato flakes, frozen potatoes, etc"
                        },
                        new
                        {
                            ProductId = 14,
                            CategoryId = 2,
                            Discount = 0f,
                            ImageUrl = "/images/tomato.jpg",
                            Name = "Tomato ",
                            Price = 8m,
                            ProductDescription = "The tomato cultivated everywhere in the world. It is consumed in multiple ways, both raw as processed for the industry. At present there exists a great range of varieties, cultivated all the year round, with fruits of different sizes, shapes and colours. Besides, it is rich in fibre and low in calories, supplying vitamins and minerals."
                        },
                        new
                        {
                            ProductId = 15,
                            CategoryId = 2,
                            Discount = 0f,
                            ImageUrl = "/images/salad.jpg",
                            Name = "Salad ",
                            Price = 5m,
                            ProductDescription = "Green Leaf lettuce is best suited for fresh applications and is most commonly used as a wrap, garnish, in salads, or as a layer in a sandwich. It is crisp and has a sweet or bitter smell when the stalk is scratched, depending on the specific variety"
                        },
                        new
                        {
                            ProductId = 16,
                            CategoryId = 2,
                            Discount = 0f,
                            ImageUrl = "/images/onion.jpg",
                            Name = "Onion",
                            Price = 6m,
                            ProductDescription = "The onion is an underground, eadible bulb that grows in the plant that bears the same name. There is a wide range of varieties, that can be classified according to the colour of the bulb, the shape, size, use, origin and earliness. It is used in many ways for cooking, both raw and cooked. Moreover, it has various medicinal properties."
                        },
                        new
                        {
                            ProductId = 17,
                            CategoryId = 2,
                            Discount = 0f,
                            ImageUrl = "/images/broccoli.jpg",
                            Name = "Broccoli ",
                            Price = 20m,
                            ProductDescription = "The broccoli is a vegetable that belongs the cabbage family. Its consumption increases constantly, since it is a healthy food with multiple culinary uses. It has a pleasant taste and it is rich in mineral and vitamins. It is also low in calories."
                        },
                        new
                        {
                            ProductId = 18,
                            CategoryId = 2,
                            Discount = 0f,
                            ImageUrl = "/images/cauliflower.jpg",
                            Name = "Cauliflower ",
                            Price = 12m,
                            ProductDescription = "The cauliflower is a vegetable that belongs to the cabbage family. The part that one consumes is the flower or inflorescence, highly appreciated for its taste. It can be presented in many ways, both raw and cooked. It is an important source of vitamins and minerals. In addition, it contributes with fibber and it is low in calories."
                        },
                        new
                        {
                            ProductId = 19,
                            CategoryId = 2,
                            Discount = 0f,
                            ImageUrl = "/images/cucumbers.jpg",
                            Name = "Cucumber",
                            Price = 7m,
                            ProductDescription = "Cucumber is a summer vegetable with elongate shape. Its skin is of a green colour, turning into yellow in maturation. At present, it is found in the European markets all over the year. Fresh or pickled cucumbers are also available"
                        },
                        new
                        {
                            ProductId = 20,
                            CategoryId = 2,
                            Discount = 0f,
                            ImageUrl = "/images/spinach.jpeg",
                            Name = "Spinach ",
                            Price = 30m,
                            ProductDescription = "Spinach is a herbaceous plant whose leaves, green and arranged in rosette, are eaten raw or cooked. The leaves have an oval shape and are wrinkled. It is a very nutritious, tasteful and easy-to-digest plant. Like most of the leafy vegetables, it has a great content of water and a low percentage of proteins, carbohydrates and lipids. It stands out for its high nutritional richness, since its vitamin and mineral content is higher than the rest of vegetables."
                        },
                        new
                        {
                            ProductId = 21,
                            CategoryId = 2,
                            Discount = 0f,
                            ImageUrl = "/images/radish.jpg",
                            Name = "Radish ",
                            Price = 30m,
                            ProductDescription = "Radish is the fleshy root that is obtained from the plant with the same name. It has a pungent taste and it is consumed as a vegetable. There are varieties of spherical, conical, cylindrical and oval shape. They are covered by a rind of diverse colours; red, white, purple, black or red and white, although the most frequent varieties are red. "
                        },
                        new
                        {
                            ProductId = 22,
                            CategoryId = 2,
                            Discount = 0f,
                            ImageUrl = "/images/celery.jpg",
                            Name = "Celery ",
                            Price = 30m,
                            ProductDescription = "Celery is a vegetable with long petioles, meaty and succulent that are known by the name of stalks. They may be eaten raw in salads or alone, fried, boiled, with sauces and as a condiment for soups, stews, etc. It can also be used as an aromatic and besides the stalks, the leaves and seeds of the plant are used. "
                        },
                        new
                        {
                            ProductId = 23,
                            CategoryId = 2,
                            Discount = 0f,
                            ImageUrl = "/images/beans.jpg",
                            Name = "Beans ",
                            Price = 30m,
                            ProductDescription = "Beans are a great source of fiber. They can be cooked in many different ways, including boiling, frying, and baking. Beans are a summer crop that needs warm temperatures to grow and one of the longest-cultivated plants."
                        },
                        new
                        {
                            ProductId = 24,
                            CategoryId = 2,
                            Discount = 0f,
                            ImageUrl = "/images/carrot.jpg",
                            Name = "Carrot",
                            Price = 8m,
                            ProductDescription = "The carrot is one of the most cultivated vegetables in the world. Its consumption has spreaded widely, since at present it is available all the year round. The part of the carrot that we consume is its root, of which there are various shapes and tastes. It stands out for its carotene and vitamin A, B and C content"
                        },
                        new
                        {
                            ProductId = 25,
                            CategoryId = 2,
                            Discount = 0f,
                            ImageUrl = "/images/eggplant.jpg",
                            Name = "Eggplant ",
                            Price = 20m,
                            ProductDescription = "Eggplant are members of the same plant family as tomatoes and peppers, but more vunerable to cold temperatures than tomatoes. A large selection of varieties makes eggplants available in several colors and shape, but they are usually purplish black and oval shape."
                        },
                        new
                        {
                            ProductId = 26,
                            CategoryId = 3,
                            Discount = 0f,
                            ImageUrl = "/images/cheese.jpg",
                            Name = "Cheese ",
                            Price = 60m,
                            ProductDescription = "Cheese is a preserved form of milk made by the coagulation, draining or pressing, and salting of the milk proteins and fats. It is popular for its longevity and nutritional value. Cheese is a stable food with a longer shelf life than milk, and it is an affordable food for any budget. There are numerous styles, shapes, tastes, and textures of cheese."
                        },
                        new
                        {
                            ProductId = 27,
                            CategoryId = 3,
                            Discount = 0f,
                            ImageUrl = "/images/yogurt.jpg",
                            Name = "Yogurt ",
                            Price = 20m,
                            ProductDescription = "The basic production of homemade yogurt is fairly simple: milk is heated and combined with a starter yogurt culture, most often spoonfuls of a batch of yogurt that is already made. The milk mixture is kept at a warm temperature for at least eight hours, letting those cultures bloom, resulting in creamy tasty yogurt."
                        },
                        new
                        {
                            ProductId = 28,
                            CategoryId = 3,
                            Discount = 0f,
                            ImageUrl = "/images/milk.jpg",
                            Name = "Milk ",
                            Price = 8m,
                            ProductDescription = "Liquid milk is the most consumed, processed and marketed dairy product. Worldwide, less and less liquid milk is consumed in its raw form."
                        },
                        new
                        {
                            ProductId = 29,
                            CategoryId = 3,
                            Discount = 0f,
                            ImageUrl = "/images/eggs.jpg",
                            Name = "Eggs",
                            Price = 2m,
                            ProductDescription = "Chicken eggs are the most commonly eaten egg, which are typically classified and sold in four standard sizes. Eggs contain the highest quality protein you can buy."
                        },
                        new
                        {
                            ProductId = 30,
                            CategoryId = 4,
                            Discount = 0f,
                            ImageUrl = "/images/tuna.jpg",
                            Name = "Tuna",
                            Price = 70m,
                            ProductDescription = "Tuna is a good source of essential nutrients, such as omega-3 fatty acids, high quality protein, selenium and Vitamin D."
                        });
                });

            modelBuilder.Entity("OPG.Models.StoreUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("OPG.Models.StoreUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("OPG.Models.StoreUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OPG.Models.StoreUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("OPG.Models.StoreUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("OPG.Models.OrderFormDetail", b =>
                {
                    b.HasOne("OPG.Models.OrderForm", "OrderForm")
                        .WithMany("OrderFormDetails")
                        .HasForeignKey("OrderFormId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OPG.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("OrderForm");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("OPG.Models.OrderItem", b =>
                {
                    b.HasOne("OPG.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("OPG.Models.Product", b =>
                {
                    b.HasOne("OPG.Models.Category", "Category")
                        .WithMany("Product")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("OPG.Models.Category", b =>
                {
                    b.Navigation("Product");
                });

            modelBuilder.Entity("OPG.Models.OrderForm", b =>
                {
                    b.Navigation("OrderFormDetails");
                });
#pragma warning restore 612, 618
        }
    }
}
