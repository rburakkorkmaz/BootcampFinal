using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    public partial class mig1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Username = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    PetsFound = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<int>(type: "int", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedBy = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Pets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    Breed = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Species = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    Age = table.Column<int>(type: "int", nullable: true),
                    Health = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    IsMissing = table.Column<bool>(type: "bit", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FindingDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FoundAddress = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    MissingDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastSeenAddress = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<int>(type: "int", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedBy = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pets_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Address", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "IsDeleted", "Name", "Password", "PetsFound", "PhoneNumber", "Surname", "UpdatedAt", "UpdatedBy", "Username" },
                values: new object[,]
                {
                    { 1, "78034 Jonatan Ville, Port Jedidiah, United States of America", new DateTime(2022, 11, 24, 21, 18, 30, 908, DateTimeKind.Local).AddTicks(4696), 0, new DateTime(2022, 11, 24, 21, 18, 30, 908, DateTimeKind.Local).AddTicks(4710), 0, false, "Jaylin", "fvn3pS2GQiv6PJg", 0, "1-616-530-1220", "Nikolaus", new DateTime(2022, 11, 24, 21, 18, 30, 908, DateTimeKind.Local).AddTicks(4709), 0, "Nelson_Collins" },
                    { 2, "3704 Pollich Inlet, Rempelshire, Hong Kong", new DateTime(2022, 11, 24, 21, 18, 30, 908, DateTimeKind.Local).AddTicks(6079), 0, new DateTime(2022, 11, 24, 21, 18, 30, 908, DateTimeKind.Local).AddTicks(6081), 0, false, "Ava", "mBIT2SurVGtpEHj", 0, "537-213-7868", "Harber", new DateTime(2022, 11, 24, 21, 18, 30, 908, DateTimeKind.Local).AddTicks(6081), 0, "Maureen.Mayer27" },
                    { 3, "050 Cathryn Station, West Jordon, Andorra", new DateTime(2022, 11, 24, 21, 18, 30, 908, DateTimeKind.Local).AddTicks(6375), 0, new DateTime(2022, 11, 24, 21, 18, 30, 908, DateTimeKind.Local).AddTicks(6377), 0, false, "Rudy", "JTuk37UOkZoRYmD", 0, "(771) 382-6802 x218", "Connelly", new DateTime(2022, 11, 24, 21, 18, 30, 908, DateTimeKind.Local).AddTicks(6376), 0, "Suzanne39" },
                    { 4, "7235 Antonina Port, Macejkovicfort, Morocco", new DateTime(2022, 11, 24, 21, 18, 30, 908, DateTimeKind.Local).AddTicks(6625), 0, new DateTime(2022, 11, 24, 21, 18, 30, 908, DateTimeKind.Local).AddTicks(6627), 0, false, "Hilbert", "rnHUc8_w4vNJd7a", 0, "757-979-2883 x239", "MacGyver", new DateTime(2022, 11, 24, 21, 18, 30, 908, DateTimeKind.Local).AddTicks(6626), 0, "Vidal72" },
                    { 5, "75546 Monahan Wells, O'Connellfurt, Hong Kong", new DateTime(2022, 11, 24, 21, 18, 30, 908, DateTimeKind.Local).AddTicks(6862), 0, new DateTime(2022, 11, 24, 21, 18, 30, 908, DateTimeKind.Local).AddTicks(6863), 0, false, "Marcia", "j_C40eT7RSiKdQc", 0, "935-330-0318 x501", "Rolfson", new DateTime(2022, 11, 24, 21, 18, 30, 908, DateTimeKind.Local).AddTicks(6862), 0, "Alberta.Green" },
                    { 6, "6560 Floyd Vista, New Jamaal, Cook Islands", new DateTime(2022, 11, 24, 21, 18, 30, 908, DateTimeKind.Local).AddTicks(7174), 0, new DateTime(2022, 11, 24, 21, 18, 30, 908, DateTimeKind.Local).AddTicks(7176), 0, false, "Marian", "Wi3p8SMLkMG5ue0", 0, "(401) 215-2652 x3151", "Christiansen", new DateTime(2022, 11, 24, 21, 18, 30, 908, DateTimeKind.Local).AddTicks(7176), 0, "Ashton.Donnelly27" },
                    { 7, "375 Waldo Camp, North Juvenal, Morocco", new DateTime(2022, 11, 24, 21, 18, 30, 908, DateTimeKind.Local).AddTicks(7478), 0, new DateTime(2022, 11, 24, 21, 18, 30, 908, DateTimeKind.Local).AddTicks(7480), 0, false, "Kailey", "q3ufJjWnS917ryY", 0, "646.500.2768 x0120", "Koepp", new DateTime(2022, 11, 24, 21, 18, 30, 908, DateTimeKind.Local).AddTicks(7480), 0, "Geo_Bins64" },
                    { 8, "07578 Alisa Avenue, McCulloughport, Norfolk Island", new DateTime(2022, 11, 24, 21, 18, 30, 908, DateTimeKind.Local).AddTicks(7748), 0, new DateTime(2022, 11, 24, 21, 18, 30, 908, DateTimeKind.Local).AddTicks(7749), 0, false, "Soledad", "0P_Xz0uaTrYxyff", 0, "(972) 344-7348 x2100", "Hamill", new DateTime(2022, 11, 24, 21, 18, 30, 908, DateTimeKind.Local).AddTicks(7749), 0, "Ford_Heaney70" },
                    { 9, "41618 Lesch Plaza, Titusview, Bulgaria", new DateTime(2022, 11, 24, 21, 18, 30, 908, DateTimeKind.Local).AddTicks(8024), 0, new DateTime(2022, 11, 24, 21, 18, 30, 908, DateTimeKind.Local).AddTicks(8026), 0, false, "Johnpaul", "1_ssSrRJKSUELUC", 0, "800-498-2319 x62954", "Champlin", new DateTime(2022, 11, 24, 21, 18, 30, 908, DateTimeKind.Local).AddTicks(8025), 0, "Isaias_MacGyver19" },
                    { 10, "546 Annabelle Oval, Christiansenstad, French Southern Territories", new DateTime(2022, 11, 24, 21, 18, 30, 908, DateTimeKind.Local).AddTicks(8309), 0, new DateTime(2022, 11, 24, 21, 18, 30, 908, DateTimeKind.Local).AddTicks(8311), 0, false, "Baylee", "mphZWSC21XN5gDk", 0, "865.279.1781", "Stark", new DateTime(2022, 11, 24, 21, 18, 30, 908, DateTimeKind.Local).AddTicks(8310), 0, "Benjamin_Dicki33" },
                    { 11, "711 Welch Springs, Bednarport, Kiribati", new DateTime(2022, 11, 24, 21, 18, 30, 908, DateTimeKind.Local).AddTicks(8574), 0, new DateTime(2022, 11, 24, 21, 18, 30, 908, DateTimeKind.Local).AddTicks(8575), 0, false, "Wilfredo", "XKvh5hndWfcNIKo", 0, "(958) 771-6271 x38870", "Wolff", new DateTime(2022, 11, 24, 21, 18, 30, 908, DateTimeKind.Local).AddTicks(8575), 0, "Sterling_MacGyver45" },
                    { 12, "997 Gayle Springs, Port Ned, Belarus", new DateTime(2022, 11, 24, 21, 18, 30, 908, DateTimeKind.Local).AddTicks(8860), 0, new DateTime(2022, 11, 24, 21, 18, 30, 908, DateTimeKind.Local).AddTicks(8861), 0, false, "Lon", "9PCXPB_0j9cqs2b", 0, "567.457.2491 x8339", "Goyette", new DateTime(2022, 11, 24, 21, 18, 30, 908, DateTimeKind.Local).AddTicks(8860), 0, "Jackeline_Conroy61" },
                    { 13, "671 Borer Garden, Sigurdborough, Hong Kong", new DateTime(2022, 11, 24, 21, 18, 30, 908, DateTimeKind.Local).AddTicks(9129), 0, new DateTime(2022, 11, 24, 21, 18, 30, 908, DateTimeKind.Local).AddTicks(9131), 0, false, "Kiera", "XYGowscUa0vpqtm", 0, "535.520.4487", "McLaughlin", new DateTime(2022, 11, 24, 21, 18, 30, 908, DateTimeKind.Local).AddTicks(9130), 0, "Jonas63" },
                    { 14, "7308 Spinka Forge, Irmaburgh, Andorra", new DateTime(2022, 11, 24, 21, 18, 30, 908, DateTimeKind.Local).AddTicks(9390), 0, new DateTime(2022, 11, 24, 21, 18, 30, 908, DateTimeKind.Local).AddTicks(9392), 0, false, "Darwin", "ARX8JvnKaKSuJ3u", 0, "921.898.5626", "Barrows", new DateTime(2022, 11, 24, 21, 18, 30, 908, DateTimeKind.Local).AddTicks(9392), 0, "Garth14" },
                    { 15, "106 Joey Camp, Arvidbury, Grenada", new DateTime(2022, 11, 24, 21, 18, 30, 908, DateTimeKind.Local).AddTicks(9657), 0, new DateTime(2022, 11, 24, 21, 18, 30, 908, DateTimeKind.Local).AddTicks(9658), 0, false, "Ruben", "AjEyuoH63Gshnyw", 0, "(769) 701-9961 x96072", "Cummings", new DateTime(2022, 11, 24, 21, 18, 30, 908, DateTimeKind.Local).AddTicks(9657), 0, "Jaquan_Kemmer" },
                    { 16, "6479 Pollich Glen, South Leannamouth, Virgin Islands, British", new DateTime(2022, 11, 24, 21, 18, 30, 908, DateTimeKind.Local).AddTicks(9915), 0, new DateTime(2022, 11, 24, 21, 18, 30, 908, DateTimeKind.Local).AddTicks(9916), 0, false, "Gerda", "oMfxHYKUlQDP04F", 0, "1-393-223-3129", "Sipes", new DateTime(2022, 11, 24, 21, 18, 30, 908, DateTimeKind.Local).AddTicks(9916), 0, "Buddy76" },
                    { 17, "158 Frances Springs, New Ahmed, Ethiopia", new DateTime(2022, 11, 24, 21, 18, 30, 909, DateTimeKind.Local).AddTicks(182), 0, new DateTime(2022, 11, 24, 21, 18, 30, 909, DateTimeKind.Local).AddTicks(183), 0, false, "Kaylin", "kIHUfQVTAJsZksF", 0, "1-779-425-9049 x149", "Wisozk", new DateTime(2022, 11, 24, 21, 18, 30, 909, DateTimeKind.Local).AddTicks(183), 0, "Harvey_Kertzmann30" },
                    { 18, "526 Michael Ridge, North Mariehaven, Northern Mariana Islands", new DateTime(2022, 11, 24, 21, 18, 30, 909, DateTimeKind.Local).AddTicks(462), 0, new DateTime(2022, 11, 24, 21, 18, 30, 909, DateTimeKind.Local).AddTicks(463), 0, false, "Aleen", "5Al7UGNvarXr16h", 0, "568.976.0946 x171", "Nikolaus", new DateTime(2022, 11, 24, 21, 18, 30, 909, DateTimeKind.Local).AddTicks(463), 0, "Kathryn.Padberg56" },
                    { 19, "646 Runolfsdottir Vista, Sydneyland, Mayotte", new DateTime(2022, 11, 24, 21, 18, 30, 909, DateTimeKind.Local).AddTicks(742), 0, new DateTime(2022, 11, 24, 21, 18, 30, 909, DateTimeKind.Local).AddTicks(744), 0, false, "Rebeca", "hVa3rV66FwJOe_h", 0, "1-959-822-5919", "Wiza", new DateTime(2022, 11, 24, 21, 18, 30, 909, DateTimeKind.Local).AddTicks(743), 0, "Devyn_Hermann" },
                    { 20, "9333 Stiedemann Centers, Port Esteban, United States Minor Outlying Islands", new DateTime(2022, 11, 24, 21, 18, 30, 909, DateTimeKind.Local).AddTicks(1013), 0, new DateTime(2022, 11, 24, 21, 18, 30, 909, DateTimeKind.Local).AddTicks(1014), 0, false, "Thea", "DiRqAa8z0j0Iy5W", 0, "203-735-2749", "Emmerich", new DateTime(2022, 11, 24, 21, 18, 30, 909, DateTimeKind.Local).AddTicks(1014), 0, "Eva.Kunde" },
                    { 21, "78843 Eldred Mountain, South Teresafort, Iraq", new DateTime(2022, 11, 24, 21, 18, 30, 909, DateTimeKind.Local).AddTicks(1276), 0, new DateTime(2022, 11, 24, 21, 18, 30, 909, DateTimeKind.Local).AddTicks(1277), 0, false, "Magnus", "PYHLcN7vfiOF3mp", 0, "(428) 441-2895 x1138", "Veum", new DateTime(2022, 11, 24, 21, 18, 30, 909, DateTimeKind.Local).AddTicks(1277), 0, "Adalberto.Christiansen" },
                    { 22, "011 Anjali Islands, Port Conormouth, Democratic People's Republic of Korea", new DateTime(2022, 11, 24, 21, 18, 30, 909, DateTimeKind.Local).AddTicks(1595), 0, new DateTime(2022, 11, 24, 21, 18, 30, 909, DateTimeKind.Local).AddTicks(1596), 0, false, "Christop", "ryh3t6ZhqAYc8y8", 0, "(972) 212-4717 x63525", "Casper", new DateTime(2022, 11, 24, 21, 18, 30, 909, DateTimeKind.Local).AddTicks(1596), 0, "Meda65" },
                    { 23, "3322 White Prairie, Quincyfurt, Cote d'Ivoire", new DateTime(2022, 11, 24, 21, 18, 30, 909, DateTimeKind.Local).AddTicks(1889), 0, new DateTime(2022, 11, 24, 21, 18, 30, 909, DateTimeKind.Local).AddTicks(1890), 0, false, "Corene", "8YVsmMofqDII5l3", 0, "(697) 727-6305 x630", "Hermann", new DateTime(2022, 11, 24, 21, 18, 30, 909, DateTimeKind.Local).AddTicks(1890), 0, "Kendall91" },
                    { 24, "8529 Annalise Alley, Tristonfurt, Isle of Man", new DateTime(2022, 11, 24, 21, 18, 30, 909, DateTimeKind.Local).AddTicks(2162), 0, new DateTime(2022, 11, 24, 21, 18, 30, 909, DateTimeKind.Local).AddTicks(2163), 0, false, "Jennifer", "wQkcJhBOx8LiGWj", 0, "1-899-316-0364", "Monahan", new DateTime(2022, 11, 24, 21, 18, 30, 909, DateTimeKind.Local).AddTicks(2162), 0, "Helga14" },
                    { 25, "59913 Helmer Lake, South Clementine, Saint Helena", new DateTime(2022, 11, 24, 21, 18, 30, 909, DateTimeKind.Local).AddTicks(2414), 0, new DateTime(2022, 11, 24, 21, 18, 30, 909, DateTimeKind.Local).AddTicks(2415), 0, false, "Herta", "RAMbWZo3dD_ZziD", 0, "1-526-677-6567", "Hickle", new DateTime(2022, 11, 24, 21, 18, 30, 909, DateTimeKind.Local).AddTicks(2414), 0, "Lavonne71" },
                    { 26, "38404 Moriah Rest, Schultzfort, Svalbard & Jan Mayen Islands", new DateTime(2022, 11, 24, 21, 18, 30, 909, DateTimeKind.Local).AddTicks(2695), 0, new DateTime(2022, 11, 24, 21, 18, 30, 909, DateTimeKind.Local).AddTicks(2697), 0, false, "Afton", "zu7BRVsMpE2ExrA", 0, "1-699-898-4089 x2596", "Fritsch", new DateTime(2022, 11, 24, 21, 18, 30, 909, DateTimeKind.Local).AddTicks(2696), 0, "Syble.Glover" },
                    { 27, "48654 Smith Radial, Lake Carmel, Malta", new DateTime(2022, 11, 24, 21, 18, 30, 909, DateTimeKind.Local).AddTicks(2960), 0, new DateTime(2022, 11, 24, 21, 18, 30, 909, DateTimeKind.Local).AddTicks(2961), 0, false, "Robb", "VRoKP9g4HqbiFS7", 0, "501-583-2066", "Kirlin", new DateTime(2022, 11, 24, 21, 18, 30, 909, DateTimeKind.Local).AddTicks(2961), 0, "Mariah7" },
                    { 28, "66199 Ken Ports, East Reyton, Jamaica", new DateTime(2022, 11, 24, 21, 18, 30, 909, DateTimeKind.Local).AddTicks(3223), 0, new DateTime(2022, 11, 24, 21, 18, 30, 909, DateTimeKind.Local).AddTicks(3225), 0, false, "Carmela", "EhB496e1EYwH8la", 0, "(392) 614-5267 x309", "Heidenreich", new DateTime(2022, 11, 24, 21, 18, 30, 909, DateTimeKind.Local).AddTicks(3224), 0, "Federico_Krajcik85" },
                    { 29, "1039 Bethany Plaza, West Erling, Fiji", new DateTime(2022, 11, 24, 21, 18, 30, 909, DateTimeKind.Local).AddTicks(3505), 0, new DateTime(2022, 11, 24, 21, 18, 30, 909, DateTimeKind.Local).AddTicks(3506), 0, false, "Amara", "Ff4NFPj_KZ_RMjy", 0, "1-361-598-8909 x30602", "O'Conner", new DateTime(2022, 11, 24, 21, 18, 30, 909, DateTimeKind.Local).AddTicks(3506), 0, "Karley67" },
                    { 30, "474 Jeffery Station, Stromanmouth, Montserrat", new DateTime(2022, 11, 24, 21, 18, 30, 909, DateTimeKind.Local).AddTicks(3767), 0, new DateTime(2022, 11, 24, 21, 18, 30, 909, DateTimeKind.Local).AddTicks(3769), 0, false, "Jedediah", "n1xlap1fuDOFsS7", 0, "205.212.4218 x75455", "Thiel", new DateTime(2022, 11, 24, 21, 18, 30, 909, DateTimeKind.Local).AddTicks(3768), 0, "Barney55" }
                });

            migrationBuilder.InsertData(
                table: "Pets",
                columns: new[] { "Id", "Age", "Breed", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "Description", "Discriminator", "FindingDate", "FoundAddress", "Health", "IsDeleted", "IsMissing", "Name", "Species", "UpdatedAt", "UpdatedBy", "UserId" },
                values: new object[,]
                {
                    { 16, 5, "English setter", new DateTime(2022, 11, 24, 21, 18, 30, 909, DateTimeKind.Local).AddTicks(7337), 0, new DateTime(2022, 11, 24, 21, 18, 30, 909, DateTimeKind.Local).AddTicks(7338), 0, null, "FoundPet", new DateTime(2022, 9, 11, 6, 51, 1, 56, DateTimeKind.Local).AddTicks(8132), "13774 Arnaldo Knolls, East Peterside, Macao", "Sağlıklı", false, false, "Enos", "Dog", new DateTime(2022, 11, 24, 21, 18, 30, 909, DateTimeKind.Local).AddTicks(7338), 0, 25 },
                    { 17, 26, "Jenday Conure", new DateTime(2022, 11, 24, 21, 18, 30, 909, DateTimeKind.Local).AddTicks(8026), 0, new DateTime(2022, 11, 24, 21, 18, 30, 909, DateTimeKind.Local).AddTicks(8027), 0, null, "FoundPet", new DateTime(2021, 12, 14, 12, 53, 51, 701, DateTimeKind.Local).AddTicks(821), "3020 Hilll Camp, North Royce, Bahrain", "Kanaması var", false, false, "Bobby", "Bird", new DateTime(2022, 11, 24, 21, 18, 30, 909, DateTimeKind.Local).AddTicks(8026), 0, 9 },
                    { 18, 26, "Abyssinian", new DateTime(2022, 11, 24, 21, 18, 30, 909, DateTimeKind.Local).AddTicks(8210), 0, new DateTime(2022, 11, 24, 21, 18, 30, 909, DateTimeKind.Local).AddTicks(8211), 0, null, "FoundPet", new DateTime(2022, 5, 29, 10, 15, 33, 361, DateTimeKind.Local).AddTicks(2249), "63304 Seamus Lake, Funkstad, Bangladesh", "Sağlıklı", false, false, "Aida", "Cat", new DateTime(2022, 11, 24, 21, 18, 30, 909, DateTimeKind.Local).AddTicks(8211), 0, 19 },
                    { 19, 17, "Brussels griffon", new DateTime(2022, 11, 24, 21, 18, 30, 909, DateTimeKind.Local).AddTicks(8372), 0, new DateTime(2022, 11, 24, 21, 18, 30, 909, DateTimeKind.Local).AddTicks(8373), 0, null, "FoundPet", new DateTime(2022, 1, 31, 1, 45, 16, 269, DateTimeKind.Local).AddTicks(5231), "985 Antoinette Drives, Lake Hardyland, Belgium", "Yaralı", false, false, "Brooke", "Dog", new DateTime(2022, 11, 24, 21, 18, 30, 909, DateTimeKind.Local).AddTicks(8372), 0, 5 },
                    { 20, 27, "Canary", new DateTime(2022, 11, 24, 21, 18, 30, 909, DateTimeKind.Local).AddTicks(8547), 0, new DateTime(2022, 11, 24, 21, 18, 30, 909, DateTimeKind.Local).AddTicks(8548), 0, null, "FoundPet", new DateTime(2022, 1, 15, 23, 28, 58, 625, DateTimeKind.Local).AddTicks(5518), "88777 Patricia Center, Skylaview, Bosnia and Herzegovina", "Yaralı", false, false, "Shemar", "Bird", new DateTime(2022, 11, 24, 21, 18, 30, 909, DateTimeKind.Local).AddTicks(8548), 0, 18 },
                    { 21, 6, "Maine Coon", new DateTime(2022, 11, 24, 21, 18, 30, 909, DateTimeKind.Local).AddTicks(8708), 0, new DateTime(2022, 11, 24, 21, 18, 30, 909, DateTimeKind.Local).AddTicks(8709), 0, null, "FoundPet", new DateTime(2022, 8, 22, 9, 26, 50, 763, DateTimeKind.Local).AddTicks(9545), "470 Hyatt Cliff, Efrainborough, Christmas Island", "Halsiz", false, false, "Aracely", "Cat", new DateTime(2022, 11, 24, 21, 18, 30, 909, DateTimeKind.Local).AddTicks(8708), 0, 2 },
                    { 22, 11, "Clumber spaniel", new DateTime(2022, 11, 24, 21, 18, 30, 909, DateTimeKind.Local).AddTicks(8867), 0, new DateTime(2022, 11, 24, 21, 18, 30, 909, DateTimeKind.Local).AddTicks(8868), 0, null, "FoundPet", new DateTime(2022, 1, 4, 16, 0, 12, 607, DateTimeKind.Local).AddTicks(9923), "90151 Queen Unions, Myrtleburgh, Niue", "Hasta", false, false, "Ebony", "Dog", new DateTime(2022, 11, 24, 21, 18, 30, 909, DateTimeKind.Local).AddTicks(8868), 0, 19 },
                    { 23, 16, "Crimson Rosella", new DateTime(2022, 11, 24, 21, 18, 30, 909, DateTimeKind.Local).AddTicks(9057), 0, new DateTime(2022, 11, 24, 21, 18, 30, 909, DateTimeKind.Local).AddTicks(9058), 0, null, "FoundPet", new DateTime(2022, 7, 25, 10, 8, 49, 361, DateTimeKind.Local).AddTicks(2038), "226 Maybell Parks, East Laverne, Sierra Leone", "Hasta", false, false, "Dorthy", "Bird", new DateTime(2022, 11, 24, 21, 18, 30, 909, DateTimeKind.Local).AddTicks(9057), 0, 15 },
                    { 24, 12, "Himalayan", new DateTime(2022, 11, 24, 21, 18, 30, 909, DateTimeKind.Local).AddTicks(9219), 0, new DateTime(2022, 11, 24, 21, 18, 30, 909, DateTimeKind.Local).AddTicks(9220), 0, null, "FoundPet", new DateTime(2022, 10, 25, 15, 13, 33, 227, DateTimeKind.Local).AddTicks(612), "7089 Jerry Streets, East Jaidaport, Malta", "Hasta", false, false, "Raquel", "Cat", new DateTime(2022, 11, 24, 21, 18, 30, 909, DateTimeKind.Local).AddTicks(9220), 0, 27 },
                    { 25, 16, "pointer", new DateTime(2022, 11, 24, 21, 18, 30, 909, DateTimeKind.Local).AddTicks(9391), 0, new DateTime(2022, 11, 24, 21, 18, 30, 909, DateTimeKind.Local).AddTicks(9392), 0, null, "FoundPet", new DateTime(2022, 6, 4, 17, 55, 19, 598, DateTimeKind.Local).AddTicks(8671), "0371 Hartmann Mills, New Caseymouth, Eritrea", "Yaralı", false, false, "Greyson", "Dog", new DateTime(2022, 11, 24, 21, 18, 30, 909, DateTimeKind.Local).AddTicks(9391), 0, 17 },
                    { 26, 2, "green-cheeked conure", new DateTime(2022, 11, 24, 21, 18, 30, 909, DateTimeKind.Local).AddTicks(9558), 0, new DateTime(2022, 11, 24, 21, 18, 30, 909, DateTimeKind.Local).AddTicks(9559), 0, null, "FoundPet", new DateTime(2022, 10, 13, 7, 59, 5, 803, DateTimeKind.Local).AddTicks(2738), "730 Denesik Branch, Alanisberg, Heard Island and McDonald Islands", "Hasta", false, false, "Althea", "Bird", new DateTime(2022, 11, 24, 21, 18, 30, 909, DateTimeKind.Local).AddTicks(9559), 0, 3 },
                    { 27, 20, "Russian Blue", new DateTime(2022, 11, 24, 21, 18, 30, 909, DateTimeKind.Local).AddTicks(9719), 0, new DateTime(2022, 11, 24, 21, 18, 30, 909, DateTimeKind.Local).AddTicks(9720), 0, null, "FoundPet", new DateTime(2022, 2, 5, 12, 59, 47, 603, DateTimeKind.Local).AddTicks(57), "5078 Wilfredo Keys, Andersonshire, Brunei Darussalam", "Kanaması var", false, false, "Lilian", "Cat", new DateTime(2022, 11, 24, 21, 18, 30, 909, DateTimeKind.Local).AddTicks(9719), 0, 12 },
                    { 28, 4, "Rottweiler", new DateTime(2022, 11, 24, 21, 18, 30, 909, DateTimeKind.Local).AddTicks(9897), 0, new DateTime(2022, 11, 24, 21, 18, 30, 909, DateTimeKind.Local).AddTicks(9898), 0, null, "FoundPet", new DateTime(2022, 8, 21, 6, 6, 8, 971, DateTimeKind.Local).AddTicks(2643), "67244 Gerson Garden, North Vernice, Haiti", "Sağlıklı", false, false, "Edwina", "Dog", new DateTime(2022, 11, 24, 21, 18, 30, 909, DateTimeKind.Local).AddTicks(9898), 0, 10 },
                    { 29, 1, "Rainbow Lory", new DateTime(2022, 11, 24, 21, 18, 30, 910, DateTimeKind.Local).AddTicks(58), 0, new DateTime(2022, 11, 24, 21, 18, 30, 910, DateTimeKind.Local).AddTicks(59), 0, null, "FoundPet", new DateTime(2022, 6, 18, 0, 12, 34, 127, DateTimeKind.Local).AddTicks(5185), "93534 Freeman Corners, East Carlo, Cape Verde", "Hasta", false, false, "Avis", "Bird", new DateTime(2022, 11, 24, 21, 18, 30, 910, DateTimeKind.Local).AddTicks(58), 0, 21 },
                    { 30, 13, "Manx", new DateTime(2022, 11, 24, 21, 18, 30, 910, DateTimeKind.Local).AddTicks(219), 0, new DateTime(2022, 11, 24, 21, 18, 30, 910, DateTimeKind.Local).AddTicks(220), 0, null, "FoundPet", new DateTime(2021, 12, 11, 12, 21, 34, 49, DateTimeKind.Local).AddTicks(5088), "603 Gleichner Ferry, North Jarretstad, United States Minor Outlying Islands", "Kanaması var", false, false, "Kieran", "Cat", new DateTime(2022, 11, 24, 21, 18, 30, 910, DateTimeKind.Local).AddTicks(220), 0, 23 }
                });

            migrationBuilder.InsertData(
                table: "Pets",
                columns: new[] { "Id", "Age", "Breed", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "Description", "Discriminator", "Health", "IsDeleted", "IsMissing", "LastSeenAddress", "MissingDate", "Name", "Species", "UpdatedAt", "UpdatedBy", "UserId" },
                values: new object[,]
                {
                    { 1, 12, "Kerry blue terrier", new DateTime(2022, 11, 24, 21, 18, 30, 909, DateTimeKind.Local).AddTicks(4133), 0, new DateTime(2022, 11, 24, 21, 18, 30, 909, DateTimeKind.Local).AddTicks(4134), 0, null, "MissingPet", "Kanaması var", false, false, "511 Madyson Street, East Kasey, Georgia", new DateTime(2022, 3, 2, 11, 17, 40, 894, DateTimeKind.Local).AddTicks(4991), "Jeremie", "Dog", new DateTime(2022, 11, 24, 21, 18, 30, 909, DateTimeKind.Local).AddTicks(4133), 0, 26 },
                    { 2, 12, "Rainbow Lory", new DateTime(2022, 11, 24, 21, 18, 30, 909, DateTimeKind.Local).AddTicks(4898), 0, new DateTime(2022, 11, 24, 21, 18, 30, 909, DateTimeKind.Local).AddTicks(4899), 0, null, "MissingPet", "Kanaması var", false, false, "824 Becker Highway, Wisozkton, Dominica", new DateTime(2022, 6, 6, 3, 59, 50, 84, DateTimeKind.Local).AddTicks(2978), "Alexandre", "Bird", new DateTime(2022, 11, 24, 21, 18, 30, 909, DateTimeKind.Local).AddTicks(4899), 0, 28 },
                    { 3, 25, "Abyssinian Cat", new DateTime(2022, 11, 24, 21, 18, 30, 909, DateTimeKind.Local).AddTicks(5085), 0, new DateTime(2022, 11, 24, 21, 18, 30, 909, DateTimeKind.Local).AddTicks(5086), 0, null, "MissingPet", "Hasta", false, false, "09410 Issac Plaza, New Antonioport, Togo", new DateTime(2022, 3, 21, 16, 26, 12, 982, DateTimeKind.Local).AddTicks(3938), "Ryan", "Cat", new DateTime(2022, 11, 24, 21, 18, 30, 909, DateTimeKind.Local).AddTicks(5086), 0, 29 },
                    { 4, 9, "schnauzer", new DateTime(2022, 11, 24, 21, 18, 30, 909, DateTimeKind.Local).AddTicks(5267), 0, new DateTime(2022, 11, 24, 21, 18, 30, 909, DateTimeKind.Local).AddTicks(5268), 0, null, "MissingPet", "Yaralı", false, false, "877 Mia Divide, Francescaville, Chile", new DateTime(2022, 6, 2, 13, 22, 10, 500, DateTimeKind.Local).AddTicks(4680), "Derick", "Dog", new DateTime(2022, 11, 24, 21, 18, 30, 909, DateTimeKind.Local).AddTicks(5267), 0, 19 },
                    { 5, 2, "Quaker Parakeet", new DateTime(2022, 11, 24, 21, 18, 30, 909, DateTimeKind.Local).AddTicks(5457), 0, new DateTime(2022, 11, 24, 21, 18, 30, 909, DateTimeKind.Local).AddTicks(5458), 0, null, "MissingPet", "Sağlıklı", false, false, "085 Jesus Mill, Desireestad, Panama", new DateTime(2022, 8, 14, 13, 8, 46, 91, DateTimeKind.Local).AddTicks(1227), "Jo", "Bird", new DateTime(2022, 11, 24, 21, 18, 30, 909, DateTimeKind.Local).AddTicks(5457), 0, 26 },
                    { 6, 25, "Turkish Angora", new DateTime(2022, 11, 24, 21, 18, 30, 909, DateTimeKind.Local).AddTicks(5620), 0, new DateTime(2022, 11, 24, 21, 18, 30, 909, DateTimeKind.Local).AddTicks(5621), 0, null, "MissingPet", "Yaralı", false, false, "905 Osinski Landing, Annettaville, Maldives", new DateTime(2022, 8, 3, 1, 11, 8, 37, DateTimeKind.Local).AddTicks(2271), "Maribel", "Cat", new DateTime(2022, 11, 24, 21, 18, 30, 909, DateTimeKind.Local).AddTicks(5621), 0, 16 },
                    { 7, 21, "poodle", new DateTime(2022, 11, 24, 21, 18, 30, 909, DateTimeKind.Local).AddTicks(5786), 0, new DateTime(2022, 11, 24, 21, 18, 30, 909, DateTimeKind.Local).AddTicks(5787), 0, null, "MissingPet", "Sağlıklı", false, false, "2728 Rudy Wells, South Earlinetown, Burkina Faso", new DateTime(2022, 6, 28, 14, 37, 2, 166, DateTimeKind.Local).AddTicks(1411), "Holly", "Dog", new DateTime(2022, 11, 24, 21, 18, 30, 909, DateTimeKind.Local).AddTicks(5787), 0, 7 },
                    { 8, 18, "Blue-Crowned Conure", new DateTime(2022, 11, 24, 21, 18, 30, 909, DateTimeKind.Local).AddTicks(5958), 0, new DateTime(2022, 11, 24, 21, 18, 30, 909, DateTimeKind.Local).AddTicks(5959), 0, null, "MissingPet", "Kanaması var", false, false, "2226 Russel Square, Auerfurt, Spain", new DateTime(2022, 3, 14, 23, 2, 35, 36, DateTimeKind.Local).AddTicks(3026), "Terrance", "Bird", new DateTime(2022, 11, 24, 21, 18, 30, 909, DateTimeKind.Local).AddTicks(5958), 0, 6 },
                    { 9, 1, "British Shorthair", new DateTime(2022, 11, 24, 21, 18, 30, 909, DateTimeKind.Local).AddTicks(6108), 0, new DateTime(2022, 11, 24, 21, 18, 30, 909, DateTimeKind.Local).AddTicks(6109), 0, null, "MissingPet", "Kanaması var", false, false, "713 Jalon Haven, Amaniport, Palau", new DateTime(2022, 9, 28, 15, 8, 50, 963, DateTimeKind.Local).AddTicks(1803), "Mireille", "Cat", new DateTime(2022, 11, 24, 21, 18, 30, 909, DateTimeKind.Local).AddTicks(6109), 0, 24 },
                    { 10, 18, "Skye terrier", new DateTime(2022, 11, 24, 21, 18, 30, 909, DateTimeKind.Local).AddTicks(6264), 0, new DateTime(2022, 11, 24, 21, 18, 30, 909, DateTimeKind.Local).AddTicks(6265), 0, null, "MissingPet", "Sağlıklı", false, false, "255 Ziemann Green, Port Lenny, Paraguay", new DateTime(2022, 7, 28, 6, 16, 58, 871, DateTimeKind.Local).AddTicks(9092), "Issac", "Dog", new DateTime(2022, 11, 24, 21, 18, 30, 909, DateTimeKind.Local).AddTicks(6265), 0, 23 },
                    { 11, 0, "Psittacula", new DateTime(2022, 11, 24, 21, 18, 30, 909, DateTimeKind.Local).AddTicks(6420), 0, new DateTime(2022, 11, 24, 21, 18, 30, 909, DateTimeKind.Local).AddTicks(6421), 0, null, "MissingPet", "Yaralı", false, false, "956 Garnet Squares, Shayneborough, Liechtenstein", new DateTime(2022, 7, 10, 8, 44, 23, 321, DateTimeKind.Local).AddTicks(8019), "Fern", "Bird", new DateTime(2022, 11, 24, 21, 18, 30, 909, DateTimeKind.Local).AddTicks(6421), 0, 29 },
                    { 12, 17, "Persian", new DateTime(2022, 11, 24, 21, 18, 30, 909, DateTimeKind.Local).AddTicks(6579), 0, new DateTime(2022, 11, 24, 21, 18, 30, 909, DateTimeKind.Local).AddTicks(6580), 0, null, "MissingPet", "Kanaması var", false, false, "63074 Orie Roads, Ulisesport, Greenland", new DateTime(2022, 3, 10, 11, 48, 11, 669, DateTimeKind.Local).AddTicks(9125), "Janelle", "Cat", new DateTime(2022, 11, 24, 21, 18, 30, 909, DateTimeKind.Local).AddTicks(6580), 0, 10 },
                    { 13, 18, "bichon frise", new DateTime(2022, 11, 24, 21, 18, 30, 909, DateTimeKind.Local).AddTicks(6741), 0, new DateTime(2022, 11, 24, 21, 18, 30, 909, DateTimeKind.Local).AddTicks(6741), 0, null, "MissingPet", "Hasta", false, false, "22345 Greenholt Lodge, South Elyse, Cook Islands", new DateTime(2022, 5, 18, 9, 32, 44, 383, DateTimeKind.Local).AddTicks(4019), "Edna", "Dog", new DateTime(2022, 11, 24, 21, 18, 30, 909, DateTimeKind.Local).AddTicks(6741), 0, 10 },
                    { 14, 29, "green-winged macaw", new DateTime(2022, 11, 24, 21, 18, 30, 909, DateTimeKind.Local).AddTicks(6894), 0, new DateTime(2022, 11, 24, 21, 18, 30, 909, DateTimeKind.Local).AddTicks(6895), 0, null, "MissingPet", "Hasta", false, false, "6655 Harrison Islands, Grahamton, Holy See (Vatican City State)", new DateTime(2022, 11, 18, 16, 53, 29, 132, DateTimeKind.Local).AddTicks(3597), "Andres", "Bird", new DateTime(2022, 11, 24, 21, 18, 30, 909, DateTimeKind.Local).AddTicks(6894), 0, 10 },
                    { 15, 27, "Burmese", new DateTime(2022, 11, 24, 21, 18, 30, 909, DateTimeKind.Local).AddTicks(7107), 0, new DateTime(2022, 11, 24, 21, 18, 30, 909, DateTimeKind.Local).AddTicks(7108), 0, null, "MissingPet", "Kanaması var", false, false, "21969 Kemmer Square, Jadynside, Bangladesh", new DateTime(2022, 5, 2, 9, 23, 53, 634, DateTimeKind.Local).AddTicks(6505), "Christ", "Cat", new DateTime(2022, 11, 24, 21, 18, 30, 909, DateTimeKind.Local).AddTicks(7107), 0, 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Pets_UserId",
                table: "Pets",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pets");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
