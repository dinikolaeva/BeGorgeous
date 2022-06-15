namespace BeGorgeous.Common
{
    public static class GlobalConstants
    {
        public const string SystemName = "BeGorgeous";

        public const string UserRoleName = "User";

        public const string AdministratorRoleName = "Administrator";

        public const string ManagerRoleName = "Manager";

        public const string CloudName = "be-gorgeous";

        public static class AccountsSeeding
        {
            public const string Password = "123456";

            public const string AdminEmail = "admin@begorgeous.com";

            public const string ManagerEmail = "manager@begorgeous.com";

            public const string UserEmail = "user@begorgeous.com";
        }

        public static class RegularExpretions
        {
            public const string PhoneNUmber = @"^\+?[0-9]{9,13}$";

            public const string Duration = @"^(0[0-9]|1[0-9]|2[0-3]|[0-9]):[0-5][0-9]:[0-0][0-0]$";

            public const string Price = @"^\d+.\d{0,2}$";
        }

        public static class StringLengthValidations
        {
            public const int NameMinLength = 3;
            public const int NameMaxLength = 40;
            public const int Name = 100;
            public const int DescriptionMinLength = 50;
            public const int DescriptionMaxLength = 700;
            public const int AddressMinLength = 5;
            public const int AddressMaxLength = 100;
            public const int ShortAutobiographyMinLength = 20;
            public const int ShortAutobiographyMaxLength = 300;
        }

        public static class DateTimeFormats
        {
            public const string DateFormat = "dd-MM-yyyy";

            public const string TimeFormat = "h:mmtt";

            public const string DateTimeFormat = "dd-MM-yyyy h:mmtt";
        }

        public static class ErrorMessages
        {
            public const string DateTime = "Please select a valid DATE and TIME from the datepicker calendar on the left.";

            public const string Rating = "Please choose a valid number of stars from 1 to 5.";

            public const string Name = "Name must be between 3 and 100 characters.";

            public const string StylistName = "Name must be between 3 and 40 characters.";

            public const string Address = "Address must be between 5 and 100 characters.";

            public const string Image = "Please select a JPG, JPEG or PNG image smaller than 1MB.";

            public const string Description = "Description must be between 50 and 700 characters.";

            public const string PhoneNumber = "Please enter valid phone number!";

            public const string Url = "Please enter valid URL from Google Map!";

            public const string Duration = "Invalid time format and hh:mm:ss values.";

            public const string Price = "Invalid price";

            public const string ShortAutobiography = "Short autobiography must be between 20 and 300 characters.";
        }

        public static class Images
        {
            // Main
            public const string Background = "https://res.cloudinary.com/be-gorgeous/image/upload/v1647259764/images/BeGorgeous/cover-bg_nnwh6d_cui4dr.jpg";

            public const string AboutUs = "https://res.cloudinary.com/be-gorgeous/image/upload/v1649422121/images/BeGorgeous/istockphoto-169951897-612x612_sctkr5.jpg";

            public const string MissionsAndGoals = "https://res.cloudinary.com/be-gorgeous/image/upload/v1649422794/images/BeGorgeous/52419339-beauty-salon-workers-with-professional-tools_x3wwfo.webp";

            // Missing image
            public const string MissingUploadImage = "https://res.cloudinary.com/be-gorgeous/image/upload/v1649187840/images/BeGorgeous/download_xp6r8o.png";

            // Error 404
            public const string Error404 = "https://res.cloudinary.com/be-gorgeous/image/upload/v1648541025/images/BeGorgeous/17305_97cf242d-e3e6-4056-ac0a-d12453a90b520_fdzbyv.jpg";

            // No appointments
            public const string NoAppointments = "https://res.cloudinary.com/be-gorgeous/image/upload/v1648541050/images/BeGorgeous/dubai-salon-1_tsby04.jpg";

            // Categories
            public const string Hairdressing = "https://res.cloudinary.com/be-gorgeous/image/upload/v1646671723/images/BeGorgeous/2892083_wzhfzc.jpg";

            public const string Nails = "https://res.cloudinary.com/be-gorgeous/image/upload/v1646673036/images/BeGorgeous/3276318_eetz2l.jpg";

            public const string Waxing = "https://res.cloudinary.com/be-gorgeous/image/upload/v1646673482/images/BeGorgeous/Some-things-every-woman-should-know-about-waxing_z2euvc.jpg";

            public const string Makeup = "https://res.cloudinary.com/be-gorgeous/image/upload/v1646672962/images/BeGorgeous/2090351_uc7sdt.jpg";

            public const string CosmeticТreatments = "https://res.cloudinary.com/be-gorgeous/image/upload/v1646674012/images/BeGorgeous/image-asset_h2kh09.jpg";

            // Treatments
            // 1.Hairdressing
            public const string LadiessHaircuts = "https://res.cloudinary.com/be-gorgeous/image/upload/v1646686839/images/BeGorgeous/360_F_164454647_iqlaGlhYFP8RL5JbC3NOUJoQWrow3J4b_gksovd.jpg";

            public const string MansHaircuts = "https://res.cloudinary.com/be-gorgeous/image/upload/v1646686644/images/BeGorgeous/istockphoto-640274128-170667a_anf50y.jpg";

            public const string ChildrensHaircuts = "https://res.cloudinary.com/be-gorgeous/image/upload/v1646687011/images/BeGorgeous/istockphoto-680907176-612x612_zi4ju6.jpg";

            public const string BlowDry = "https://res.cloudinary.com/be-gorgeous/image/upload/v1646687498/images/BeGorgeous/istockphoto-622521378-612x612_xyknx1.jpg";

            public const string PressStraightening = "https://res.cloudinary.com/be-gorgeous/image/upload/v1646831609/images/BeGorgeous/istockphoto-851008048-612x612_ga8fqb.jpg";

            public const string LadiesHairColoring = "https://res.cloudinary.com/be-gorgeous/image/upload/v1646687638/images/BeGorgeous/depositphotos_10685520-stock-photo-hair-colors-palette_df78bi.jpg";

            public const string BalayageHairColoring = "https://res.cloudinary.com/be-gorgeous/image/upload/v1646831879/images/BeGorgeous/istockphoto-1139145310-612x612_eikrs1.jpg";

            public const string BotoxTherapy = "https://res.cloudinary.com/be-gorgeous/image/upload/v1646832698/images/BeGorgeous/istockphoto-538196170-612x612_a7ubsr.jpg";

            public const string Braids = "https://res.cloudinary.com/be-gorgeous/image/upload/v1646833194/images/BeGorgeous/istockphoto-802291322-612x612_kn7lqj.jpg";

            // 2.Nails
            public const string Manicure = "https://res.cloudinary.com/be-gorgeous/image/upload/v1646833194/images/BeGorgeous/istockphoto-802291322-612x612_kn7lqj.jpg";

            public const string Pedicure = "https://res.cloudinary.com/be-gorgeous/image/upload/v1646834317/images/BeGorgeous/istockphoto-545984710-612x612_kobyzn.jpg";

            public const string NailArt = "https://res.cloudinary.com/be-gorgeous/image/upload/v1646834567/images/BeGorgeous/istockphoto-624626098-612x612_srmyom.jpg";

            // 3.Wax
            public const string FullBodyWaxing = "https://res.cloudinary.com/be-gorgeous/image/upload/v1646834901/images/BeGorgeous/istockphoto-465356691-612x612_omkinj.jpg";

            public const string BrazilianWaxing = "https://res.cloudinary.com/be-gorgeous/image/upload/v1646835203/images/BeGorgeous/brazilian-bikini-wax-1170x658_p7eaz7.jpg";

            // 4.Makeup
            public const string ProfessionalMakeup = "https://res.cloudinary.com/be-gorgeous/image/upload/v1646835703/images/BeGorgeous/istockphoto-1331637318-170667a_rllema.jpg";

            public const string PermanentMakeup = "https://res.cloudinary.com/be-gorgeous/image/upload/v1646840659/images/BeGorgeous/istockphoto-1184644734-612x612_vvxk2t.jpg";

            public const string EyelashesExtension = "https://res.cloudinary.com/be-gorgeous/image/upload/v1646840970/images/BeGorgeous/istockphoto-845706294-612x612_ddm3hq.jpg";

            // 5. Facial
            public const string FacialCleaning = "https://res.cloudinary.com/be-gorgeous/image/upload/v1646841460/images/BeGorgeous/Face-Ritual-2_bngwxw.jpg";

            public const string AntiAgeCareFacial = "https://res.cloudinary.com/be-gorgeous/image/upload/v1646841834/images/BeGorgeous/istockphoto-921677406-612x612_ydhpit.jpg";

            public const string AntiAcneFacial = "https://res.cloudinary.com/be-gorgeous/image/upload/v1646842061/images/BeGorgeous/istockphoto-1140170080-612x612_ox5xxd.jpg";

            public const string DiamondDermabrasion = "https://res.cloudinary.com/be-gorgeous/image/upload/v1646843598/images/BeGorgeous/istockphoto-803164436-612x612_vhp3th.jpg";

            // Salons
            public const string BeGorgeousInSofia = "https://res.cloudinary.com/be-gorgeous/image/upload/v1646846166/images/BeGorgeous/d40be0_0b71b6a562334139b030947914befa5d_mv2_zjtcsx.jpg";

            public const string BeGorgeousInPlovdiv = "https://res.cloudinary.com/be-gorgeous/image/upload/v1646846412/images/BeGorgeous/photo-1633681926022-84c23e8cb2d6_iztazu.jpg";

            public const string BeGorgeousInLondon = "https://res.cloudinary.com/be-gorgeous/image/upload/v1646846674/images/BeGorgeous/FREE-Thuy-Be-Hair-Salon-3D-Model_Doan_3dteamz_jvnamv.jpg";

            public const string BeGorgeousInBirmingham = "https://res.cloudinary.com/be-gorgeous/image/upload/v1646847194/images/BeGorgeous/2867-Beauty-Salon-Sketchup-Model-By-DiepVinh-Free-Download-1_k3c47w.jpg";

            public const string BeGorgeousInMadrid = "https://res.cloudinary.com/be-gorgeous/image/upload/v1646847618/images/BeGorgeous/salon1_gywyc9.jpg";

            public const string BeGorgeousInBarcelona = "https://res.cloudinary.com/be-gorgeous/image/upload/v1646847898/images/BeGorgeous/photo-1521590832167-7bcbfaa6381f_ztk2ub.jpg";

            // Stylists
            // Hair
            // Sofia
            public const string MilaUzunova = "https://res.cloudinary.com/be-gorgeous/image/upload/v1646905533/images/BeGorgeous/Depositphotos_11884169_original_dlzxah.jpg";

            public const string SvilenDimitrov = "https://res.cloudinary.com/be-gorgeous/image/upload/v1646914901/images/BeGorgeous/8e6f29eb0089434ab338_me11qr.jpg";

            // Plovdiv
            public const string EvaIvanova = "https://res.cloudinary.com/be-gorgeous/image/upload/v1646857657/images/BeGorgeous/istockphoto-853924196-170667a_khqvaz.jpg";

            public const string AnnaNikolova = "https://res.cloudinary.com/be-gorgeous/image/upload/v1646857820/images/BeGorgeous/photo-1562322140-8baeececf3df_y2ijnl.jpg";

            // London, UK
            public const string EmilBern = "https://res.cloudinary.com/be-gorgeous/image/upload/v1646906610/images/BeGorgeous/barber_barbershop_hair_stylist_haircut_hairdo_hairdresser_hairstylist_men-994115_cpxoe2.jpg";

            public const string JessieWallis = "https://res.cloudinary.com/be-gorgeous/image/upload/v1646915068/images/BeGorgeous/istockphoto-1321545990-170667a_zkjdyo.jpg";

            // Birmingham, UK
            public const string AnthonyLouis = "https://res.cloudinary.com/be-gorgeous/image/upload/v1646916089/images/BeGorgeous/istockphoto-1270950948-170667a_qklqe6.jpg";

            public const string VivianHaris = "https://res.cloudinary.com/be-gorgeous/image/upload/v1646916017/images/BeGorgeous/25d41b6d8357fdf512e8665c3571f982_lxl9u4.jpg";

            // Madrid, Spain
            public const string OliviaPerez = "https://res.cloudinary.com/be-gorgeous/image/upload/v1646917480/images/BeGorgeous/stock-photo-beautiful-young-hairstylist-looking-handsome_zxrjsj.jpg";

            public const string RenataLopez = "https://res.cloudinary.com/be-gorgeous/image/upload/v1646917323/images/BeGorgeous/istockphoto-1271712634-612x612_v71eny.jpg";

            // Barcelona, Spain
            public const string ZoeDeLeon = "https://res.cloudinary.com/be-gorgeous/image/upload/v1646918958/images/BeGorgeous/bigstock-Beautiful-woman-in-hair-salon-83907503-837x558_o2etne.jpg";

            public const string AlanaRodriguez = "https://res.cloudinary.com/be-gorgeous/image/upload/v1646918735/images/BeGorgeous/istockphoto-1136599956-612x612_lykikh.jpg";

            // Nails
            // Sofia
            public const string TanyaDimova = "https://res.cloudinary.com/be-gorgeous/image/upload/v1646903192/images/BeGorgeous/istockphoto-519546165-612x612_siusfm.jpg";

            public const string VanyaPapazova = "https://res.cloudinary.com/be-gorgeous/image/upload/v1646903359/images/BeGorgeous/www.usnews_h8qlys.jpg";

            // Plovdiv
            public const string DarinaVaseva = "https://res.cloudinary.com/be-gorgeous/image/upload/v1646906531/images/BeGorgeous/istockphoto-1296156275-170667a_udhkbi.jpg";

            public const string EmiMarinova = "https://res.cloudinary.com/be-gorgeous/image/upload/v1646906558/images/BeGorgeous/istockphoto-1167657805-612x612_kbypvb.jpg";

            // London, UK
            public const string KatieAddyson = "https://res.cloudinary.com/be-gorgeous/image/upload/v1646916496/images/BeGorgeous/Jessica-Harris-Nails-by-Jessica-1200_cadoom.jpg";

            // Birmingham, UK
            public const string TanyaGoody = "https://res.cloudinary.com/be-gorgeous/image/upload/v1646917692/images/BeGorgeous/bigstock-Friendly-Nail-Technician-Apply-367193176_zbjxbu.jpg";

            // Madrid, Spain
            public const string JulietaGarcia = "https://res.cloudinary.com/be-gorgeous/image/upload/v1646919117/images/BeGorgeous/13439816-0-image-a-96_1557752886858_cf06yg.jpg";

            // Barcelona, Spain
            public const string RomaRomero = "https://res.cloudinary.com/be-gorgeous/image/upload/v1646915446/images/BeGorgeous/istockphoto-1167657829-170667a_zfjf2i.jpg";

            // Wax
            // Sofia
            public const string MariaYordanova = "https://res.cloudinary.com/be-gorgeous/image/upload/v1646903665/images/BeGorgeous/istockphoto-937117716-612x612_nxqtaw.jpg";

            // Plovdiv
            public const string MeiVu = "https://res.cloudinary.com/be-gorgeous/image/upload/v1646906968/images/BeGorgeous/waxing-hair-removal-1024x681_qplupo.jpg";

            // Birmingham, UK
            public const string MariaGutenberg = "https://res.cloudinary.com/be-gorgeous/image/upload/v1646919246/images/BeGorgeous/Waxing-Vs-Laser-Hair-Removal-Treatment-MedLinks_r0sfi4.jpg";

            // Barcelona, Spain
            public const string ClaraMartin = "https://res.cloudinary.com/be-gorgeous/image/upload/v1646916799/images/BeGorgeous/images1858-5c7e6ec1b0326-1024x683_km7mnq.jpg";

            // Makeup
            // Sofia
            public const string SlavaNaidenova = "https://res.cloudinary.com/be-gorgeous/image/upload/v1646914126/images/BeGorgeous/istockphoto-681346362-612x612_mvlygq.jpg";

            // Plovdiv
            public const string IvanSlavov = "https://res.cloudinary.com/be-gorgeous/image/upload/v1646904971/images/BeGorgeous/istockphoto-970023818-612x612_wn3nji.jpg";

            // London, UK
            public const string AlexLogan = "https://res.cloudinary.com/be-gorgeous/image/upload/v1646915758/images/BeGorgeous/maxresdefault_au3pho.jpg";

            // Madrid, Spain
            public const string SaraMorales = "https://res.cloudinary.com/be-gorgeous/image/upload/v1646917874/images/BeGorgeous/06_14_MakeupArtist_aufmacher_1200x672_acf_cropped_v1mnjj.jpg";

            // Barcelona, Spain
            public const string PaulinaDiaz = "https://res.cloudinary.com/be-gorgeous/image/upload/v1646919411/images/BeGorgeous/1_ausbildung_makeup_artist_wissenswertes_mfj7ze.jpg";

            // Facial
            // Sofia
            public const string GerganaKostova = "https://res.cloudinary.com/be-gorgeous/image/upload/v1646905251/images/BeGorgeous/istockphoto-1280387268-612x612_ltf8fc.jpg";

            // Plovdiv
            public const string ZuziTomova = "https://res.cloudinary.com/be-gorgeous/image/upload/v1646914452/images/BeGorgeous/istockphoto-1181270504-612x612_h8szh9.jpg";

            // Birmingham, UK
            public const string SvetlanaStoke = "https://res.cloudinary.com/be-gorgeous/image/upload/v1646917119/images/BeGorgeous/cosmetic-dermatologist-botox-600x400_x3bfyb.jpg";

            // Madrid, Spain
            public const string AlmaHernandez = "https://res.cloudinary.com/be-gorgeous/image/upload/v1646917969/images/BeGorgeous/laser-skin-treatments_v2kzsk.jpg";
        }

        public static class Icons
        {
            public const string LadyHaircut = "https://res.cloudinary.com/be-gorgeous/image/upload/v1648216407/images/BeGorgeous/woman-hair-cut_zpqf1g.png";

            public const string MenHaircut = "https://res.cloudinary.com/be-gorgeous/image/upload/v1648302356/images/BeGorgeous/a6572ee377d50e776ba1ab661808338b_yqutqg.png";

            public const string ChildrenHaircut = "https://res.cloudinary.com/be-gorgeous/image/upload/v1648216870/images/BeGorgeous/57172_zqostb.png";

            public const string BlowDry = "https://res.cloudinary.com/be-gorgeous/image/upload/v1648216996/images/BeGorgeous/blow-dryer-icon-28_wyt9kj.png";

            public const string PressStraightening = "https://res.cloudinary.com/be-gorgeous/image/upload/v1648217115/images/BeGorgeous/img_15281_qkojxd.png";

            public const string LadiesHairColoring = "https://res.cloudinary.com/be-gorgeous/image/upload/v1648217216/images/BeGorgeous/40587_q2efqj.png";

            public const string BalayageHairColoring = "https://res.cloudinary.com/be-gorgeous/image/upload/v1648217355/images/BeGorgeous/126-1268835_woman-with-long-hair-hair-icon-png-free_e5tgqh.png";

            public const string BotoxTherapy = "https://res.cloudinary.com/be-gorgeous/image/upload/v1648217437/images/BeGorgeous/Untitled-1-45-512_xlbzug.webp";

            public const string Braids = "https://res.cloudinary.com/be-gorgeous/image/upload/v1648300693/images/BeGorgeous/14-512_t4ke7i.webp";

            public const string Manicure = "https://res.cloudinary.com/be-gorgeous/image/upload/v1648302554/images/BeGorgeous/download_eblde7.jpg";

            public const string Pedicure = "https://res.cloudinary.com/be-gorgeous/image/upload/v1648217681/images/BeGorgeous/pedicure-icon-0_lhw3in.png";

            public const string NailArt = "https://res.cloudinary.com/be-gorgeous/image/upload/v1648217769/images/BeGorgeous/65-650778_nail-art-painting-polish-beauty-manicure-cosmetics-icon_sqpszd.png";

            public const string FullBodyWax = "https://res.cloudinary.com/be-gorgeous/image/upload/v1648217901/images/BeGorgeous/6599843_pvm1n6.png";

            public const string BrazilianWax = "https://res.cloudinary.com/be-gorgeous/image/upload/v1648217860/images/BeGorgeous/istockphoto-1217751669-612x612_yfnti1.jpg";

            public const string ProfessionalMakeup = "https://res.cloudinary.com/be-gorgeous/image/upload/v1648218034/images/BeGorgeous/images_zlw68f.png";

            public const string PermanentMakeup = "https://res.cloudinary.com/be-gorgeous/image/upload/v1648218117/images/BeGorgeous/233012727Untitled-3-512_mt8mmb.webp";

            public const string EyelashesExtension = "https://res.cloudinary.com/be-gorgeous/image/upload/v1648218192/images/BeGorgeous/pngtree-eyelashes-logo-icon-design-template-vector-png-image_559600_ouq8ra.jpg";

            public const string FacialCleaning = "https://res.cloudinary.com/be-gorgeous/image/upload/v1648218340/images/BeGorgeous/828391_teyk1d.png";

            public const string AntiAgeCareFacial = "https://res.cloudinary.com/be-gorgeous/image/upload/v1648218422/images/BeGorgeous/cosmetic-surgery-beauty-clinic_16-512_2706_o51ar9.png";

            public const string AntiAcneFacial = "https://res.cloudinary.com/be-gorgeous/image/upload/v1648218496/images/BeGorgeous/woman-with-acne-clean-face-skin-line-icon-girl-before-after-skin-treatment-linear-pictogram_541122-284_essctw.webp";

            public const string DiamondDermabrasion = "https://res.cloudinary.com/be-gorgeous/image/upload/v1648218565/images/BeGorgeous/1005683_qgl6l5.png";
        }

        public static class StreetMapUrl
        {
            public const string Sofia = "https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d2932.8959906402165!2d23.31145021533323!3d42.68474547916646!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x40aa8510675b310d%3A0xf75472294d673f60!2sul.%20%22Tsar%20Asen%22%20125%2C%201463%20Sofia%20Center%2C%20Sofia!5e0!3m2!1sen!2sbg!4v1648110830864!5m2!1sen!2sbg";

            public const string Plovdiv = "https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d2958.1913474849853!2d24.75862181531497!3d42.14619197920188!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x14acd1a089cf86d7%3A0xf95946d42239d3df!2sboulevard%20%22Knyaginya%20Maria%20Luiza%22%2040%2C%204000%20Kamenitsa%201%2C%20Plovdiv!5e0!3m2!1sen!2sbg!4v1648111028934!5m2!1sen!2sbg";

            public const string London = "https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d2483.2404905422018!2d-0.15062588434289256!3d51.50880377963535!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x4876052e973daecb%3A0xe01e4853680233fd!2s20%20Hill%20St%2C%20London%20W1J%205NJ%2C%20UK!5e0!3m2!1sen!2sbg!4v1648113793249!5m2!1sen!2sbg";

            public const string Birmingham = "https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d2429.7156948432184!2d-1.9050480843043371!3d52.48428317980745!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x4870bc8d8103d94f%3A0x51d0d45c0412b6f9!2s40%20Lionel%20St%2C%20Birmingham%2C%20UK!5e0!3m2!1sen!2sbg!4v1648111288148!5m2!1sen!2sbg";

            public const string Madrid = "https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3038.775112705588!2d-3.7064513847430343!3d40.391676579368!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0xd4227b569b45e3d%3A0x82fca4c657bc5d95!2sC.%20Mariblanca%2C%205%2C%2028026%20Madrid%2C%20Spain!5e0!3m2!1sen!2sbg!4v1648111402107!5m2!1sen!2sbg";

            public const string Barcelona = "https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d2993.2069020153062!2d2.1715777152898212!3d41.39131287926379!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x12a4a2efe50971f9%3A0x6a4a6d7e86463c5e!2sCarrer%20del%20Bruc%2C%2038%2C%2008010%20Barcelona%2C%20Spain!5e0!3m2!1sen!2sbg!4v1648114077550!5m2!1sen!2sbg";
        }

        public static class Prices
        {
            // Treatments
            // 1.Hairdressing
            public const decimal LadiesHaircuts = 16.00M;
            public const decimal MansHaircuts = 12.00M;
            public const decimal ChildrensHaircuts = 10.00M;
            public const decimal BlowDry = 15.00M;
            public const decimal PressStraightening = 5.00M;
            public const decimal LadiesHairColoring = 20.00M;
            public const decimal BalayageHairColoring = 20.00M;
            public const decimal BotoxTherapy = 30.00M;
            public const decimal Braids = 10.00M;

            // 2.Nails
            public const decimal Manicure = 15.00M;
            public const decimal Pedicure = 25.00M;
            public const decimal NailArt = 30.00M;

            // 3.Wax
            public const decimal FullBodyWaxing = 50.00M;
            public const decimal BrazilianWaxing = 10.00M;

            // 4. Makeup
            public const decimal ProfessionalMakeup = 30.00M;
            public const decimal PermanentMakeup = 60.00M;
            public const decimal EyelashesExtension = 45.00M;

            // 5. Facial
            public const decimal FacialCleaning = 40.00M;
            public const decimal AntiAgeCareFacial = 60.00M;
            public const decimal AntiAcneFacial = 50.00M;
            public const decimal DiamondDermabrasion = 70.00M;
        }

        public static class SeededDataCounts
        {
            public const int Countries = 3;

            public const int Cities = 6;

            public const int Categories = 5;

            public const int Treatments = 21;

            public const int Salons = 6;

            public const int Stylists = 33;
        }
    }
}
