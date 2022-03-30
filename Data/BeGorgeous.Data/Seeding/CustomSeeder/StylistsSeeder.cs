namespace BeGorgeous.Data.Seeding.CustomSeeder
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    using BeGorgeous.Common;
    using BeGorgeous.Data.Models;

    public class StylistsSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.Stylists.Any())
            {
                return;
            }

            var stylists = new Stylist[]
            {
                // Hair
                // Sofia
                new Stylist
                {
                    FullName = "Mila Uzunova",
                    CategoryId = 1,
                    SalonId = 1,
                    ImageUrl = GlobalConstants.Images.MilaUzunova,
                    ShortAutobiography = "I have had a passion for the hair and beauty industry my whole life! With over 15 years of experience, I have mastered a wide range of hair techniques.",
                },
                new Stylist
                {
                    FullName = "Svilen Dimitrov",
                    CategoryId = 1,
                    SalonId = 1,
                    ImageUrl = GlobalConstants.Images.SvilenDimitrov,
                    ShortAutobiography = "Svilen is very enthusiastic and dedicated about his work on the entire team. His priority is to ensure the clients journey in our salon is a truly memorable and everything he has follow to the highest standards.",
                },

                // Plovdiv
                new Stylist
                {
                    FullName = "Eva Ivanova",
                    CategoryId = 1,
                    SalonId = 2,
                    ImageUrl = GlobalConstants.Images.EvaIvanova,
                    ShortAutobiography = "Hi, I’m Eva and I’ve been a stylist and colorist for the past 10 years. I love to modernize classic looks to make them fun and wearable for the woman-on-the-go. I attend numerous continuing-ed classes each year so as to always be knowledgeable of the best and healthiest techniques to use.",
                },
                new Stylist
                {
                    FullName = "Anna Nikolova",
                    CategoryId = 1,
                    SalonId = 2,
                    ImageUrl = GlobalConstants.Images.AnnaNikolova,
                    ShortAutobiography = "Anna Nikolova is Master Hair Stylist at Be Gorgeous. Her unique approach to balayage hair coloring earned her the prestigious International Hairdressing Award 2022.",
                },

                // London, UK
                new Stylist
                {
                    FullName = "Emil Bern",
                    CategoryId = 1,
                    SalonId = 3,
                    ImageUrl = GlobalConstants.Images.EmilBern,
                    ShortAutobiography = "Emil Bern is hair specialist and has been trained on all haircare products and is able to advise clients on the best products for their hair for any treatment.",
                },
                new Stylist
                {
                    FullName = "Jessie Wallis",
                    CategoryId = 1,
                    SalonId = 3,
                    ImageUrl = GlobalConstants.Images.JessieWallis,
                    ShortAutobiography = "I have a passion for hair styling. I love what I do. I have been educated over the years at courses with the ever-changing trends. I have had a always passion for the hair and beauty industry.",
                },

                // Birmingham, UK
                new Stylist
                {
                    FullName = "Anthony Louis",
                    CategoryId = 1,
                    SalonId = 4,
                    ImageUrl = GlobalConstants.Images.AnthonyLouis,
                    ShortAutobiography = "Anthony is very enthusiastic and dedicated about his work on the entire team. His priority is to ensure the clients journey in our salon is a truly memorable and everything he has follow to the highest standards.",
                },
                new Stylist
                {
                    FullName = "Vivian Haris",
                    CategoryId = 1,
                    SalonId = 4,
                    ImageUrl = GlobalConstants.Images.VivianHaris,
                    ShortAutobiography = "Vivian Haris will give great advice about hairs and as well as makeup, eyebrows, achieving that smoky look.",
                },

                // Madrid, Spain
                new Stylist
                {
                    FullName = "Olivia Perez",
                    CategoryId = 1,
                    SalonId = 5,
                    ImageUrl = GlobalConstants.Images.OliviaPerez,
                    ShortAutobiography = "Olivia will always great you with a warm, welcoming smile!",
                },
                new Stylist
                {
                    FullName = "Renata Lopez",
                    CategoryId = 1,
                    SalonId = 5,
                    ImageUrl = GlobalConstants.Images.RenataLopez,
                    ShortAutobiography = "I have had a passion for the hair and beauty industry my whole life! With over 10 years of experience, I have mastered a wide range of hair techniques including short and long hair cutting, coloring, and Treatments.",
                },

                // Barcelona, Spain
                new Stylist
                {
                    FullName = "Zoe De León",
                    CategoryId = 1,
                    SalonId = 6,
                    ImageUrl = GlobalConstants.Images.ZoeDeLeon,
                    ShortAutobiography = "Zoe is a master in long hair, smoothing hair treatment for all varieties of hair.",
                },
                new Stylist
                {
                    FullName = "Alana Rodriguez",
                    CategoryId = 1,
                    SalonId = 6,
                    ImageUrl = GlobalConstants.Images.AlanaRodriguez,
                    ShortAutobiography = "Passionate about hairs, she is responsible for hair styles which is in trend, giving expert tips and advice to clients.",
                },

                // 2. Nails
                // Sofia
                new Stylist
                {
                    FullName = "Tanya Dimova",
                    CategoryId = 2,
                    SalonId = 1,
                    ImageUrl = GlobalConstants.Images.TanyaDimova,
                    ShortAutobiography = "Tanya Dimova is our nail technician including the skill of reliability and leadership provide various nail treatments based on clients nail care needs and preferences with maintaining high-quality work.",
                },
                new Stylist
                {
                    FullName = "Vanya Papazova",
                    CategoryId = 2,
                    SalonId = 1,
                    ImageUrl = GlobalConstants.Images.VanyaPapazova,
                    ShortAutobiography = "Vanya Papazova is master in nail design and artistry. She is very creative, artistic and passionate artist.",
                },

                // Plovdiv
                new Stylist
                {
                    FullName = "Darina Vaseva",
                    CategoryId = 2,
                    SalonId = 2,
                    ImageUrl = GlobalConstants.Images.DarinaVaseva,
                    ShortAutobiography = "Darina Vaseva nail technician being part of our team making your nails look beautiful and feel your personal best.",
                },
                new Stylist
                {
                    FullName = "Emi Marinova",
                    CategoryId = 2,
                    SalonId = 2,
                    ImageUrl = GlobalConstants.Images.EmiMarinova,
                    ShortAutobiography = "Emi Marinova always continues to lead our nail team to make sure our guests look fabulous and enjoy a little relaxing serenity and satisfied.",
                },

                // London, UK
                new Stylist
                {
                    FullName = "Katie Addyson",
                    CategoryId = 2,
                    SalonId = 3,
                    ImageUrl = GlobalConstants.Images.KatieAddyson,
                    ShortAutobiography = "Katie is easy going, joyful personality and deep attention to detail client requirement. Her clients will always say about her \"WOW\" she is!",
                },

                // Birmingham, UK
                new Stylist
                {
                    FullName = "Tanya Goody",
                    CategoryId = 2,
                    SalonId = 4,
                    ImageUrl = GlobalConstants.Images.TanyaGoody,
                    ShortAutobiography = "Tanya has created a very good relations with our clients by making clients feel special and she is very attentive to their individual details requirement.",
                },

                // Madrid, Spain
                new Stylist
                {
                    FullName = "Julieta Garcia",
                    CategoryId = 2,
                    SalonId = 5,
                    ImageUrl = GlobalConstants.Images.JulietaGarcia,
                    ShortAutobiography = "Julieta is very creative, artistic and passionate artist.",
                },

                // Barcelona, Spain
                new Stylist
                {
                    FullName = "Roma Romero",
                    CategoryId = 2,
                    SalonId = 6,
                    ImageUrl = GlobalConstants.Images.RomaRomero,
                    ShortAutobiography = "Roma always continues to lead our nail team to make sure our guests look fabulous and enjoy a little relaxing serenity and satisfied.",
                },

                // 3. Wax
                // Sofia
                new Stylist
                {
                    FullName = "Mei Vu",
                    CategoryId = 3,
                    SalonId = 1,
                    ImageUrl = GlobalConstants.Images.MeiVu,
                    ShortAutobiography = "Mei Vu has a very loyal clientele and they book in advance to guarantee their appointments.",
                },

                // Plovdiv
                new Stylist
                {
                    FullName = "Maria Yordanova",
                    CategoryId = 3,
                    SalonId = 2,
                    ImageUrl = GlobalConstants.Images.MariaYordanova,
                    ShortAutobiography = "Maria Yordanova has a very loyal clientele and they book in advance to guarantee their appointments.",
                },

                // Birmingham, UK
                new Stylist
                {
                    FullName = "Maria Gutenberg",
                    CategoryId = 3,
                    SalonId = 4,
                    ImageUrl = GlobalConstants.Images.MariaGutenberg,
                    ShortAutobiography = "I have been in the beauty industry for over 12 years. We all deserve a little love and self-care!",
                },

                // Barcelona, Spain
                new Stylist
                {
                    FullName = "Clara Martin",
                    CategoryId = 3,
                    SalonId = 6,
                    ImageUrl = GlobalConstants.Images.ClaraMartin,
                    ShortAutobiography = "I am the one who can enhance your beauty.",
                },

                // 4. Makeup
                // Sofia
                new Stylist
                {
                    FullName = "Slava Naidenova",
                    CategoryId = 4,
                    SalonId = 1,
                    ImageUrl = GlobalConstants.Images.SlavaNaidenova,
                    ShortAutobiography = "Want to have a completely new look? I am here to make your dream come true.",
                },

                // Plovdiv
                new Stylist
                {
                    FullName = "Ivan Slavov",
                    CategoryId = 4,
                    SalonId = 2,
                    ImageUrl = GlobalConstants.Images.IvanSlavov,
                    ShortAutobiography = "Ivan Slavov loves the variation the job brings and is truly passionate about the art of makeup.",
                },

                // London, UK
                new Stylist
                {
                    FullName = "Alex Logan",
                    CategoryId = 4,
                    SalonId = 3,
                    ImageUrl = GlobalConstants.Images.AlexLogan,
                    ShortAutobiography = "Make-up is all about bringing out the beautiful person hidden inside you.",
                },

                // Madrid, Spain
                new Stylist
                {
                    FullName = "Sara Morales",
                    CategoryId = 4,
                    SalonId = 5,
                    ImageUrl = GlobalConstants.Images.SaraMorales,
                    ShortAutobiography = "I can make you believe that minimal makeup will make you look so beautiful.",
                },

                // Barcelona, Spain
                new Stylist
                {
                    FullName = "Paulina Diaz",
                    CategoryId = 4,
                    SalonId = 6,
                    ImageUrl = GlobalConstants.Images.PaulinaDiaz,
                    ShortAutobiography = "Trust me – eyeliner mascara and lipstick will boost your confidence on another level.",
                },

                // 5. Facial
                // Sofia
                new Stylist
                {
                    FullName = "Zuzi Tomova",
                    CategoryId = 5,
                    SalonId = 1,
                    ImageUrl = GlobalConstants.Images.ZuziTomova,
                    ShortAutobiography = "Having worked with top facial brands Zuzi is perfect facialist who can tell just looking the skin which facial and brand work for particular skin.",
                },

                // Plovdiv
                new Stylist
                {
                    FullName = "Gergana Kostova",
                    CategoryId = 5,
                    SalonId = 2,
                    ImageUrl = GlobalConstants.Images.GerganaKostova,
                    ShortAutobiography = "My strong suit is definitely specialized facials, I love addressing skin care concerns and helping people feel and look their absolute best!",
                },

                // Birmingham, UK
                new Stylist
                {
                    FullName = "Svetlana Stoke",
                    CategoryId = 5,
                    SalonId = 4,
                    ImageUrl = GlobalConstants.Images.SvetlanaStoke,
                    ShortAutobiography = "My strong suit is definitely specialized facials, I love addressing skin care concerns and helping people feel and look their absolute best!",
                },

                // Madrid, Spain
                new Stylist
                {
                    FullName = "Alma Hernández",
                    CategoryId = 5,
                    SalonId = 5,
                    ImageUrl = GlobalConstants.Images.AlmaHernandez,
                    ShortAutobiography = "I love addressing skin care concerns and helping people feel and look their absolute best! We all deserve a little love and self-care!",
                },
            };

            foreach (var stylist in stylists)
            {
                await dbContext.Stylists.AddAsync(stylist);
                await dbContext.SaveChangesAsync();
            }
        }
    }
}
