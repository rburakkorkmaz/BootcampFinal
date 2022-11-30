﻿using Castle.Core;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Reflection;
using System.Reflection.PortableExecutable;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.IO;
using System.Net.NetworkInformation;
using System.Numerics;

namespace EntityLayer
{
    public class PetMockData
    {
        public static string[] animalNames = {
            "Gray Grandpa",
            "Goldfish on a Donny",
            "Spooky Turtle",
            "Evil Leo",
            "Orange Swim E Fresh",
            "Black Voviboye",
            "Evil Goldfish",
            "Candy Man",
            "Gumdrop Man",
            "Koo Ferret",
            "City Dalmation",
            "Orange Ferret",
            "Wild Selina",
            "Koo Oscar",
            "Gray Oscar",
            "Choco Dog",
            "Spooky Dalmation",
            "White Dalmation",
            "Koo Bird",
            "Koo Man",
            "German Pip",
            "Spooky Donny",
            "Evil Leo",
            "Beach Man",
            "Snow Leopard Troy",
            "Tiger Clyde",
            "Candy Ferret",
            "Gumdrop Leo",
            "Zombie Goldfish",
            "Haunted Turtle",
            "German Dalmation",
            "Orange Oscar",
            "Spooky Selina",
            "Snow Leopard Goldfish",
            "Candy Turtle",
            "Evil Voviboye",
            "Choco Mikey",
            "Brown Oscar",
            "White Oscar",
            "Tiger Leo",
            "Haunted Turtle",
            "Dark Turtle",
            "Brown Raph",
            "German Dog",
            "Gray Selina",
            "Black Raph",
            "Choco Selina",
            "Brown Swim E Fresh",
            "Beach Turtle",
            "Brown Raph" };

        public static IDictionary<string, List<string>> speciesAndBreed = new Dictionary<string, List<string>>()
        {
            {
                "Cat", 
                new List<string>()
                {
                    "Abyssinian Cat", 
                    "American Bobtail Cat Breed",
                    "Abyssinian",
                    "British Shorthair",
                    "Burmese",
                    "Cornish Rex",
                    "Devon Rex",
                    "Himalayan",
                    "Maine Coon",
                    "Manx",
                    "Persian",
                    "Russian Blue",
                    "Scottish Fold",
                    "Siamese",
                    "Sphynx",
                    "Turkish Angora",
                    "Turkish Van",
                }
            },
            {
                "Dog",
                new List<string>()
                {
                    "affenpinscher",
                    "Afghan hound",
                    "Airedale terrier",
                    "Akita",
                    "Alaskan Malamute",
                    "American Staffordshire terrier",
                    "American water spaniel",
                    "Australian cattle dog",
                    "Australian shepherd",
                    "Australian terrier",
                    "basenji",
                    "basset hound",
                    "beagle",
                    "bearded collie",
                    "Bedlington terrier",
                    "Bernese mountain dog",
                    "bichon frise",
                    "black and tan coonhound",
                    "bloodhound",
                    "border collie",
                    "border terrier",
                    "borzoi",
                    "Boston terrier",
                    "bouvier des Flandres",
                    "boxer",
                    "briard",
                    "Brittany",
                    "Brussels griffon",
                    "bull terrier",
                    "bulldog",
                    "bullmastiff",
                    "cairn terrier",
                    "Canaan dog",
                    "Chesapeake Bay retriever",
                    "Chihuahua",
                    "Chinese crested",
                    "Chinese shar-pei",
                    "chow chow",
                    "Clumber spaniel",
                    "cocker spaniel",
                    "collie",
                    "curly-coated retriever",
                    "dachshund",
                    "Dalmatian",
                    "Doberman pinscher",
                    "English cocker spaniel",
                    "English setter",
                    "English springer spaniel",
                    "English toy spaniel",
                    "Eskimo dog",
                    "Finnish spitz",
                    "flat-coated retriever",
                    "fox terrier",
                    "foxhound",
                    "French bulldog",
                    "German shepherd",
                    "German shorthaired pointer",
                    "German wirehaired pointer",
                    "golden retriever",
                    "Gordon setter",
                    "Great Dane",
                    "greyhound",
                    "Irish setter",
                    "Irish water spaniel",
                    "Irish wolfhound",
                    "Jack Russell terrier",
                    "Japanese spaniel",
                    "keeshond",
                    "Kerry blue terrier",
                    "komondor",
                    "kuvasz",
                    "Labrador retriever",
                    "Lakeland terrier",
                    "Lhasa apso",
                    "Maltese",
                    "Manchester terrier",
                    "mastiff",
                    "Mexican hairless",
                    "Newfoundland",
                    "Norwegian elkhound",
                    "Norwich terrier",
                    "otterhound",
                    "papillon",
                    "Pekingese",
                    "pointer",
                    "Pomeranian",
                    "poodle",
                    "pug",
                    "puli",
                    "Rhodesian ridgeback",
                    "Rottweiler",
                    "Saint Bernard",
                    "saluki",
                    "Samoyed",
                    "schipperke",
                    "schnauzer",
                    "Scottish deerhound",
                    "Scottish terrier",
                    "Sealyham terrier",
                    "Shetland sheepdog",
                    "shih tzu",
                    "Siberian husky",
                    "silky terrier",
                    "Skye terrier",
                    "Staffordshire bull terrier",
                    "soft-coated wheaten terrier",
                    "Sussex spaniel",
                    "spitz",
                    "Tibetan terrier",
                    "vizsla",
                    "Weimaraner",
                    "Welsh terrier",
                    "West Highland white terrier",
                    "whippet",
                    "Yorkshire terrier",
                }
            },
            {
                "Bird",
                new List<string>()
                {
                    "African Grey parrot",
                    "African Grey Parrot",
                    "Alexandrine parakeet",
                    "Alexandrine Parakeet",
                    "yellow-naped Amazon parrot",
                    "Amazon Parrot",
                    "blue-and-gold macaw",
                    "Blue-and-Gold Macaw",
                    "blue-crowned conure",
                    "Blue-Crowned Conure",
                    "Blue-Headed Pionus",
                    "Blue-Headed Pionus",
                    "parakeet budgie",
                    "Budgie (Parakeet)",
                    "Caique, white-bellied caique",
                    "Caique",
                    "canary",
                    "Canary",
                    "cockatiel",
                    "Cockatiel",
                    "Goffin's Cockatoo",
                    "Cockatoo",
                    "green-cheeked conure",
                    "Conure",
                    "Crimson Rosella",
                    "Crimson Rosella",
                    "Diamond Dove",
                    "Diamond Dove",
                    "double yellow-headed Amazon parrot",
                    "Double Yellow-Headed Amazon Parrot",
                    "ring-necked Dove",
                    "Dove",
                    "Eclectus Parrot",
                    "Eclectus",
                    "Zebra Finch",
                    "Finch",
                    "Fischer's lovebird in profile",
                    "Fischer’s Lovebird",
                    "Goffin's Cockatoo",
                    "Goffin’s Cockatoo",
                    "Golden-Mantled Rosella",
                    "Golden-Mantled Rosella",
                    "Gouldian finch",
                    "Gouldian Finch",
                    "green-cheeked conure",
                    "Green-Cheeked Conure",
                    "green-winged macaw",
                    "Green-Winged Macaw",
                    "Hahn's Macaw",
                    "Hahn’s Macaw",
                    "hyacinth macaw",
                    "Hyacinth Macaw",
                    "Indian ring-necked parakeet",
                    "Indian Ring-Necked Parakeet",
                    "jenday conure",
                    "Jenday Conure",
                    "lilac-crowned Amazon parrot",
                    "Lilac-Crowned Amazon",
                    "Rainbow Lory",
                    "Lory",
                    "Fischer's lovebird",
                    "Lovebird",
                    "green-winged macaw",
                    "Macaw",
                    "Meyer's Parrot",
                    "Meyer’s Parrot",
                    "Moluccan cockatoo",
                    "Moluccan Cockatoo",
                    "orange-winged Amazon parrot",
                    "Orange-Winged Amazon Parrot",
                    "owl finch",
                    "Owl Finch",
                    "Pacific Parrotlet",
                    "Pacific Parrotlet",
                    "portrait of cockatiel, African grey parrot and conure",
                    "Parrot",
                    "Pacific Parrotlet",
                    "Parrotlet",
                    "peach-faced lovebird",
                    "Peach-Faced Lovebird",
                    "Blue-Headed Pionus",
                    "Pionus Parrot",
                    "Poicephalus",
                    "Poicephalus",
                    "Indian ring-necked parakeet",
                    "Psittacula",
                    "Quaker Parakeet",
                    "Quaker Parakeet",
                    "Rainbow Lory",
                    "Rainbow Lory",
                    "Red Lory",
                    "Red Lory",
                    "red-factor canary",
                    "Red-Factor Canary",
                    "Ring-Necked Dove",
                    "Ring-Necked Dove",
                    "Crimson Rosella",
                    "Rosella",
                    "scarlet macaw",
                    "Scarlet Macaw",
                    "Poicephalus",
                    "Senegal Parrot",
                    "song canary",
                    "Song Canary",
                    "sun conure",
                    "Sun Conure",
                    "Umbrella cockatoo",
                    "Umbrella Cockatoo",
                    "Vasa Parrot",
                    "Vasa Parrot",
                    "White-Capped Pionus",
                    "White-Capped Pionus",
                    "yellow-naped Amazon parrot",
                    "Yellow-Naped Amazon Parrot",
                    "Zebra Finch",
                    "Zebra Finch",
                }
            },
        };

        public static string[] animalHealths = { "Sağlıklı", "Hasta", "Yaralı", "Halsiz", "Kanaması var" };

        public static string[] animalDescription =
        {
                "Bulduğum zaman sağlıklıydı ve biraz üşümüştü evime aldım. Sahibini arıyorum.",
                "Yol kenarında buldum ve çok hasta durumdaydı. Veterinere götürdüm şuan durumu daha iyi sahibi bana ulaşırsa yardımcı olmak isterim.",
                "Yağmurda ıslanmış ve korktuğu için dükkanın köşesine saklanmış. Dükkan içerisine aldım ve sahibinin bana ulaşması için bekliyorum.",
                "İşe giderken gördüm ve yanıma aldım ancak çok müsait olmadığım için yanımda taşıyamadım. O yüzden XXXX veterinerine bıraktım."
        };
    
    }
}