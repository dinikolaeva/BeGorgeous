namespace BeGorgeous.Common
{
    public static class GlobalConstants
    {
        public const string SystemName = "BeGorgeous";

        public const string AdministratorRoleName = "Administrator";

        public const string CloudName = "be-gorgeous";

        public static class StringLengthValidations
        {
            public const int NameMinLength = 3;
            public const int NameMaxLength = 40;
            public const int DescriptionMinLength = 50;
            public const int DescriptionMaxLength = 700;
            public const int AddressMinLength = 5;
            public const int AddressMaxLength = 100;
            public const int ShortAutobiographyMixLength = 20;
            public const int ShortAutobiographyMaxLength = 300;
        }

        public static class Images
        {
            // Main
            public const string Background = "https://res.cloudinary.com/be-gorgeous/image/upload/v1646932729/images/maxresdefault_nmgzv2.jpg";

            // Categories
            public const string Hairdressing = "https://res.cloudinary.com/be-gorgeous/image/upload/v1646671723/images/2892083_wzhfzc.jpg";

            public const string Nails = "https://res.cloudinary.com/be-gorgeous/image/upload/v1646673036/images/3276318_eetz2l.jpg";

            public const string Waxing = "https://res.cloudinary.com/be-gorgeous/image/upload/v1646673482/images/Some-things-every-woman-should-know-about-waxing_z2euvc.jpg";

            public const string Makeup = "https://res.cloudinary.com/be-gorgeous/image/upload/v1646672962/images/2090351_uc7sdt.jpg";

            public const string CosmeticТreatments = "https://res.cloudinary.com/be-gorgeous/image/upload/v1646674012/images/image-asset_h2kh09.jpg";

            // Treatments
            // 1.Hairdressing
            public const string LadiessHaircuts = "https://res.cloudinary.com/be-gorgeous/image/upload/v1646686839/images/360_F_164454647_iqlaGlhYFP8RL5JbC3NOUJoQWrow3J4b_gksovd.jpg";

            public const string MansHaircuts = "https://res.cloudinary.com/be-gorgeous/image/upload/v1646686644/images/istockphoto-640274128-170667a_anf50y.jpg";

            public const string ChildrensHaircuts = "https://res.cloudinary.com/be-gorgeous/image/upload/v1646687011/images/istockphoto-680907176-612x612_zi4ju6.jpg";

            public const string BlowDry = "https://res.cloudinary.com/be-gorgeous/image/upload/v1646687498/images/istockphoto-622521378-612x612_xyknx1.jpg";

            public const string PressStraightening = "https://res.cloudinary.com/be-gorgeous/image/upload/v1646831609/images/istockphoto-851008048-612x612_ga8fqb.jpg";

            public const string LadiesHairColoring = "https://res.cloudinary.com/be-gorgeous/image/upload/v1646687638/images/depositphotos_10685520-stock-photo-hair-colors-palette_df78bi.jpg";

            public const string BalayageHairColoring = "https://res.cloudinary.com/be-gorgeous/image/upload/v1646831879/images/istockphoto-1139145310-612x612_eikrs1.jpg";

            public const string BotoxTherapy = "https://res.cloudinary.com/be-gorgeous/image/upload/v1646832698/images/istockphoto-538196170-612x612_a7ubsr.jpg";

            public const string Braids = "https://res.cloudinary.com/be-gorgeous/image/upload/v1646833194/images/istockphoto-802291322-612x612_kn7lqj.jpg";

            // 2.Nails
            public const string Manicure = "https://res.cloudinary.com/be-gorgeous/image/upload/v1646834137/images/istockphoto-153425390-612x612_r8xbd9.jpg";

            public const string Pedicure = "https://res.cloudinary.com/be-gorgeous/image/upload/v1646834317/images/istockphoto-545984710-612x612_kobyzn.jpg";

            public const string NailArt = "https://res.cloudinary.com/be-gorgeous/image/upload/v1646834567/images/istockphoto-624626098-612x612_srmyom.jpg";

            // 3.Wax
            public const string FullBodyWaxing = "https://res.cloudinary.com/be-gorgeous/image/upload/v1646834901/images/istockphoto-465356691-612x612_omkinj.jpg";

            public const string BrazilianWaxing = "https://res.cloudinary.com/be-gorgeous/image/upload/v1646835203/images/brazilian-bikini-wax-1170x658_p7eaz7.jpg";

            // 4.Makeup
            public const string ProfessionalMakeup = "https://res.cloudinary.com/be-gorgeous/image/upload/v1646835703/images/istockphoto-1331637318-170667a_rllema.jpg";

            public const string PermanentMakeup = "https://res.cloudinary.com/be-gorgeous/image/upload/v1646840659/images/istockphoto-1184644734-612x612_vvxk2t.jpg";

            public const string EyelashesExtension = "https://res.cloudinary.com/be-gorgeous/image/upload/v1646840970/images/istockphoto-845706294-612x612_ddm3hq.jpg";

            // 5. Facial
            public const string FacialCleaning = "https://res.cloudinary.com/be-gorgeous/image/upload/v1646841460/images/Face-Ritual-2_bngwxw.jpg";

            public const string AntiAgeCareFacial = "https://res.cloudinary.com/be-gorgeous/image/upload/v1646841834/images/istockphoto-921677406-612x612_ydhpit.jpg";

            public const string AntiAcneFacial = "https://res.cloudinary.com/be-gorgeous/image/upload/v1646842061/images/istockphoto-1140170080-612x612_ox5xxd.jpg";

            public const string DiamondDermabrasion = "https://res.cloudinary.com/be-gorgeous/image/upload/v1646843598/images/istockphoto-803164436-612x612_vhp3th.jpg";

            // Salons
            public const string BeGorgeousInSofia = "https://res.cloudinary.com/be-gorgeous/image/upload/v1646846412/images/photo-1633681926022-84c23e8cb2d6_iztazu.jpg";

            public const string BeGorgeousInPlovdiv = "https://res.cloudinary.com/be-gorgeous/image/upload/v1646846166/images/d40be0_0b71b6a562334139b030947914befa5d_mv2_zjtcsx.jpg";

            public const string BeGorgeousInLondon = "https://res.cloudinary.com/be-gorgeous/image/upload/v1646847898/images/photo-1521590832167-7bcbfaa6381f_ztk2ub.jpg";

            public const string BeGorgeousInBirmingham = "https://res.cloudinary.com/be-gorgeous/image/upload/v1646846674/images/FREE-Thuy-Be-Hair-Salon-3D-Model_Doan_3dteamz_jvnamv.jpg";

            public const string BeGorgeousInMadrid = "https://res.cloudinary.com/be-gorgeous/image/upload/v1646847194/images/2867-Beauty-Salon-Sketchup-Model-By-DiepVinh-Free-Download-1_k3c47w.jpg";

            public const string BeGorgeousInBarcelona = "https://res.cloudinary.com/be-gorgeous/image/upload/v1646847618/images/salon1_gywyc9.jpg";

            // Stylists
            // Hair
            // Sofia
            public const string MilaUzunova = "https://res.cloudinary.com/be-gorgeous/image/upload/v1646905533/images/Depositphotos_11884169_original_dlzxah.jpg";

            public const string SvilenDimitrov = "https://res.cloudinary.com/be-gorgeous/image/upload/v1646906610/images/barber_barbershop_hair_stylist_haircut_hairdo_hairdresser_hairstylist_men-994115_cpxoe2.jpg";

            // Plovdiv
            public const string EvaIvanova = "https://res.cloudinary.com/be-gorgeous/image/upload/v1646857820/images/photo-1562322140-8baeececf3df_y2ijnl.jpg";

            public const string AnnaNikolova = "https://res.cloudinary.com/be-gorgeous/image/upload/v1646857657/images/istockphoto-853924196-170667a_khqvaz.jpg";

            // London, UK
            public const string EmilBern = "https://res.cloudinary.com/be-gorgeous/image/upload/v1646914901/images/8e6f29eb0089434ab338_me11qr.jpg";

            public const string JessieWallis = "https://res.cloudinary.com/be-gorgeous/image/upload/v1646915068/images/istockphoto-1321545990-170667a_zkjdyo.jpg";

            // Birmingham, UK
            public const string AnthonyLouis = "https://res.cloudinary.com/be-gorgeous/image/upload/v1646916089/images/istockphoto-1270950948-170667a_qklqe6.jpg";

            public const string VivianHaris = "https://res.cloudinary.com/be-gorgeous/image/upload/v1646916017/images/25d41b6d8357fdf512e8665c3571f982_lxl9u4.jpg";

            // Madrid, Spain
            public const string OliviaPerez = "https://res.cloudinary.com/be-gorgeous/image/upload/v1646917323/images/istockphoto-1271712634-612x612_v71eny.jpg";

            public const string RenataLopez = "https://res.cloudinary.com/be-gorgeous/image/upload/v1646917480/images/stock-photo-beautiful-young-hairstylist-looking-handsome_zxrjsj.jpg";

            // Barcelona, Spain
            public const string ZoeDeLeon = "https://res.cloudinary.com/be-gorgeous/image/upload/v1646918735/images/istockphoto-1136599956-612x612_lykikh.jpg";

            public const string AlanaRodriguez = "https://res.cloudinary.com/be-gorgeous/image/upload/v1646918958/images/bigstock-Beautiful-woman-in-hair-salon-83907503-837x558_o2etne.jpg";

            // Nails
            // Sofia
            public const string TanyaDimova = "https://res.cloudinary.com/be-gorgeous/image/upload/v1646906558/images/istockphoto-1167657805-612x612_kbypvb.jpg";

            public const string VanyaPapazova = "https://res.cloudinary.com/be-gorgeous/image/upload/v1646906531/images/istockphoto-1296156275-170667a_udhkbi.jpg";

            // Plovdiv
            public const string DarinaVaseva = "https://res.cloudinary.com/be-gorgeous/image/upload/v1646903192/images/istockphoto-519546165-612x612_siusfm.jpg";

            public const string EmiMarinova = "https://res.cloudinary.com/be-gorgeous/image/upload/v1646903359/images/www.usnews_h8qlys.jpg";

            // London, UK
            public const string KatieAddyson = "https://res.cloudinary.com/be-gorgeous/image/upload/v1646915446/images/istockphoto-1167657829-170667a_zfjf2i.jpg";

            // Birmingham, UK
            public const string TanyaGoody = "https://res.cloudinary.com/be-gorgeous/image/upload/v1646916496/images/Jessica-Harris-Nails-by-Jessica-1200_cadoom.jpg";

            // Madrid, Spain
            public const string JulietaGarcia = "https://res.cloudinary.com/be-gorgeous/image/upload/v1646917692/images/bigstock-Friendly-Nail-Technician-Apply-367193176_zbjxbu.jpg";

            // Barcelona, Spain
            public const string RomaRomero = "https://res.cloudinary.com/be-gorgeous/image/upload/v1646919117/images/13439816-0-image-a-96_1557752886858_cf06yg.jpg";

            // Wax
            // Sofia
            public const string MariaYordanova = "https://res.cloudinary.com/be-gorgeous/image/upload/v1646903665/images/istockphoto-937117716-612x612_nxqtaw.jpg";

            // Plovdiv
            public const string PepiHristova = "https://res.cloudinary.com/be-gorgeous/image/upload/v1646906968/images/waxing-hair-removal-1024x681_qplupo.jpg";

            // Birmingham, UK
            public const string MariaGutenberg = "https://res.cloudinary.com/be-gorgeous/image/upload/v1646916799/images/images1858-5c7e6ec1b0326-1024x683_km7mnq.jpg";

            // Barcelona, Spain
            public const string ClaraMartin = "https://res.cloudinary.com/be-gorgeous/image/upload/v1646919246/images/Waxing-Vs-Laser-Hair-Removal-Treatment-MedLinks_r0sfi4.jpg";

            // Makeup
            // Sofia
            public const string SlavaNaidenova = "https://res.cloudinary.com/be-gorgeous/image/upload/v1646914126/images/istockphoto-681346362-612x612_mvlygq.jpg";

            // Plovdiv
            public const string IvanSlavov = "https://res.cloudinary.com/be-gorgeous/image/upload/v1646904971/images/istockphoto-970023818-612x612_wn3nji.jpg";

            // London, UK
            public const string AlexLogan = "https://res.cloudinary.com/be-gorgeous/image/upload/v1646915758/images/maxresdefault_au3pho.jpg";

            // Madrid, Spain
            public const string SaraMorales = "https://res.cloudinary.com/be-gorgeous/image/upload/v1646917874/images/06_14_MakeupArtist_aufmacher_1200x672_acf_cropped_v1mnjj.jpg";

            // Barcelona, Spain
            public const string PaulinaDiaz = "https://res.cloudinary.com/be-gorgeous/image/upload/v1646919411/images/1_ausbildung_makeup_artist_wissenswertes_mfj7ze.jpg";

            // Facial
            // Sofia
            public const string GerganaKostova = "https://res.cloudinary.com/be-gorgeous/image/upload/v1646905251/images/istockphoto-1280387268-612x612_ltf8fc.jpg";

            // Plovdiv
            public const string ZuziTomova = "https://res.cloudinary.com/be-gorgeous/image/upload/v1646914452/images/istockphoto-1181270504-612x612_h8szh9.jpg";

            // Birmingham, UK
            public const string SvetlanaStoke = "https://res.cloudinary.com/be-gorgeous/image/upload/v1646917119/images/cosmetic-dermatologist-botox-600x400_x3bfyb.jpg";

            // Madrid, Spain
            public const string AlmaHernandez = "https://res.cloudinary.com/be-gorgeous/image/upload/v1646917969/images/laser-skin-treatments_v2kzsk.jpg";
        }

        public static class Icons
        {
            public const string LadyHaircut = "https://res.cloudinary.com/be-gorgeous/image/upload/v1648216407/images/woman-hair-cut_zpqf1g.png";

            public const string MenHaircut = "https://res.cloudinary.com/be-gorgeous/image/upload/v1648302356/images/a6572ee377d50e776ba1ab661808338b_yqutqg.png";

            public const string ChildrenHaircut = "https://res.cloudinary.com/be-gorgeous/image/upload/v1648216870/images/57172_zqostb.png";

            public const string BlowDry = "https://res.cloudinary.com/be-gorgeous/image/upload/v1648216996/images/blow-dryer-icon-28_wyt9kj.png";

            public const string PressStraightening = "https://res.cloudinary.com/be-gorgeous/image/upload/v1648217115/images/img_15281_qkojxd.png";

            public const string LadiesHairColoring = "https://res.cloudinary.com/be-gorgeous/image/upload/v1648217216/images/40587_q2efqj.png";

            public const string BalayageHairColoring = "https://res.cloudinary.com/be-gorgeous/image/upload/v1648217355/images/126-1268835_woman-with-long-hair-hair-icon-png-free_e5tgqh.png";

            public const string BotoxTherapy = "https://res.cloudinary.com/be-gorgeous/image/upload/v1648217437/images/Untitled-1-45-512_xlbzug.webp";

            public const string Braids = "https://res.cloudinary.com/be-gorgeous/image/upload/v1648300693/images/14-512_t4ke7i.webp";

            public const string Manicure = "https://res.cloudinary.com/be-gorgeous/image/upload/v1648302554/images/download_eblde7.jpg";

            public const string Pedicure = "https://res.cloudinary.com/be-gorgeous/image/upload/v1648217681/images/pedicure-icon-0_lhw3in.png";

            public const string NailArt = "https://res.cloudinary.com/be-gorgeous/image/upload/v1648217769/images/65-650778_nail-art-painting-polish-beauty-manicure-cosmetics-icon_sqpszd.png";

            public const string FullBodyWax = "https://res.cloudinary.com/be-gorgeous/image/upload/v1648217901/images/6599843_pvm1n6.png";

            public const string BrazilianWax = "https://res.cloudinary.com/be-gorgeous/image/upload/v1648217860/images/istockphoto-1217751669-612x612_yfnti1.jpg";

            public const string ProfessionalMakeup = "https://res.cloudinary.com/be-gorgeous/image/upload/v1648218034/images/images_zlw68f.png";

            public const string PermanentMakeup = "https://res.cloudinary.com/be-gorgeous/image/upload/v1648218117/images/233012727Untitled-3-512_mt8mmb.webp";

            public const string EyelashesExtension = "https://res.cloudinary.com/be-gorgeous/image/upload/v1648218192/images/pngtree-eyelashes-logo-icon-design-template-vector-png-image_559600_ouq8ra.jpg";

            public const string FacialCleaning = "https://res.cloudinary.com/be-gorgeous/image/upload/v1648218340/images/828391_teyk1d.png";

            public const string AntiAgeCareFacial = "https://res.cloudinary.com/be-gorgeous/image/upload/v1648218422/images/cosmetic-surgery-beauty-clinic_16-512_2706_o51ar9.png";

            public const string AntiAcneFacial = "https://res.cloudinary.com/be-gorgeous/image/upload/v1648218496/images/woman-with-acne-clean-face-skin-line-icon-girl-before-after-skin-treatment-linear-pictogram_541122-284_essctw.webp";

            public const string DiamondDermabrasion = "https://res.cloudinary.com/be-gorgeous/image/upload/v1648218565/images/1005683_qgl6l5.png";
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
        }
    }
}
