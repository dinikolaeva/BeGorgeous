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
        }

        public static class Images
        {
            // Categories
            public const string Hairdressing = "https://res.cloudinary.com/be-gorgeous/image/upload/v1646671723/images/2892083_wzhfzc.jpg";

            public const string Nails = "https://res.cloudinary.com/be-gorgeous/image/upload/v1646673036/images/3276318_eetz2l.jpg";

            public const string Waxing = "https://res.cloudinary.com/be-gorgeous/image/upload/v1646673482/images/Some-things-every-woman-should-know-about-waxing_z2euvc.jpg";

            public const string Makeup = "https://res.cloudinary.com/be-gorgeous/image/upload/v1646672962/images/2090351_uc7sdt.jpg";

            public const string CosmeticТreatments = "https://res.cloudinary.com/be-gorgeous/image/upload/v1646674012/images/image-asset_h2kh09.jpg";

            // Treatments
            public const string LadiessHaircuts = "https://res.cloudinary.com/be-gorgeous/image/upload/v1646686839/images/360_F_164454647_iqlaGlhYFP8RL5JbC3NOUJoQWrow3J4b_gksovd.jpg";

            public const string MansHaircuts = "https://res.cloudinary.com/be-gorgeous/image/upload/v1646686644/images/istockphoto-640274128-170667a_anf50y.jpg";

            public const string ChildrensHaircuts = "https://res.cloudinary.com/be-gorgeous/image/upload/v1646687011/images/istockphoto-680907176-612x612_zi4ju6.jpg";

            public const string BlowDry = "https://res.cloudinary.com/be-gorgeous/image/upload/v1646687498/images/istockphoto-622521378-612x612_xyknx1.jpg";

            public const string LadiesHairColoring = "https://res.cloudinary.com/be-gorgeous/image/upload/v1646687638/images/depositphotos_10685520-stock-photo-hair-colors-palette_df78bi.jpg";


        }

        public static class Prices
        {
            public const decimal LadiesHaircuts = 16.00M;
            public const decimal MansHaircuts = 12.00M;
            public const decimal ChildrensHaircuts = 10.00M;
            public const decimal BlowDry = 15.00M;
            public const decimal LadiesHairColoring = 30.00M;
        }
    }
}
