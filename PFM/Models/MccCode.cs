using System.ComponentModel;
using Newtonsoft.Json;

namespace PFM.Models
{
    public enum MccCode
    {
        [Description("Telecommunication service including local and long distance calls, credit card calls, calls through use of magneticstrip reading telephones and fax services")]
        [JsonProperty("4814")]
        MCC1 = 4814,

        [Description("VisaPhone")]
        [JsonProperty("4815")]
        MCC2 = 4815,

        [Description("Telegraph services")]
        [JsonProperty("4821")]
        MCC3 = 4821,

        [Description("Money Orders - Wire Transfer")]
        [JsonProperty("4829")]
        MCC4 = 4829,

        [Description("Cable and other pay television (previously Cable Services)")]
        [JsonProperty("4899")]
        MCC5 = 4899,

        [Description("Electric, Gas, Sanitary and Water Utilities")]
        [JsonProperty("4900")]
        MCC6 = 4900,

        [Description("Motor vehicle supplies and new parts")]
        [JsonProperty("5013")]
        MCC7 = 5013,

        [Description("Office and Commercial Furniture")]
        [JsonProperty("5021")]
        MCC8 = 5021,

        [Description("Construction Materials, Not Elsewhere Classified")]
        [JsonProperty("5039")]
        MCC9 = 5039,

        [Description("Office, Photographic, Photocopy, and Microfilm Equipment")]
        [JsonProperty("5044")]
        MCC10 = 5044,

        [Description("Computers, Computer Peripheral Equipment, Software")]
        [JsonProperty("5045")]
        MCC11 = 5045,

        [Description("Commercial Equipment, Not Elsewhere Classified")]
        [JsonProperty("5046")]
        MCC12 = 5046,

        [Description("Medical, Dental Ophthalmic, Hospital Equipment and Supplies")]
        [JsonProperty("5047")]
        MCC13 = 5047,

        [Description("Metal Service Centers and Offices")]
        [JsonProperty("5051")]
        MCC14 = 5051,

        [Description("Electrical Parts and Equipment")]
        [JsonProperty("5065")]
        MCC15 = 5065,

        [Description("Hardware Equipment and Supplies")]
        [JsonProperty("5072")]
        MCC16 = 5072,

        [Description("Plumbing and Heating Equipment and Supplies")]
        [JsonProperty("5074")]
        MCC17 = 5074,

        [Description("Industrial Supplies, Not Elsewhere Classified")]
        [JsonProperty("5085")]
        MCC18 = 5085,

        [Description("Precious Stones and Metals, Watches and Jewelry")]
        [JsonProperty("5094")]
        MCC19 = 5094,

        [Description("Durable Goods, Not Elsewhere Classified")]
        [JsonProperty("5099")]
        MCC20 = 5099,

        [Description("Stationery, Office Supplies, Printing, and Writing Paper")]
        [JsonProperty("5111")]
        MCC21 = 5111,

        [Description("Drugs, Drug Proprietors, and Druggistâ€™s Sundries")]
        [JsonProperty("5122")]
        MCC22 = 5122,

        [Description("Piece Goods, Notions, and Other Dry Goods")]
        [JsonProperty("5131")]
        MCC23 = 5131,

        [Description("Menâ€™s Womenâ€™s and Childrenâ€™s Uniforms and Commercial Clothing")]
        [JsonProperty("5137")]
        MCC24 = 5137,

        [Description("Commercial Footwear")]
        [JsonProperty("5139")]
        MCC25 = 5139,

        [Description("Chemicals and Allied Products, Not Elsewhere Classified")]
        [JsonProperty("5169")]
        MCC26 = 5169,

        [Description("Petroleum and Petroleum Products")]
        [JsonProperty("5172")]
        MCC27 = 5172,

        [Description("Books, Periodicals, and Newspapers")]
        [JsonProperty("5192")]
        MCC28 = 5192,

        [Description("Floristsâ€™ Supplies, Nursery Stock and Flowers")]
        [JsonProperty("5193")]
        MCC29 = 5193,

        [Description("Paints, Varnishes, and Supplies")]
        [JsonProperty("5198")]
        MCC30 = 5198,

        [Description("Non-durable Goods, Not Elsewhere Classified")]
        [JsonProperty("5199")]
        MCC31 = 5199,

        [Description("Home Supply Warehouse Stores")]
        [JsonProperty("5200")]
        MCC32 = 5200,

        [Description("Lumber and Building Materials Stores")]
        [JsonProperty("5211")]
        MCC33 = 5211,

        [Description("Glass Stores")]
        [JsonProperty("5231")]
        MCC34 = 5231,

        [Description("Paint and Wallpaper Stores")]
        [JsonProperty("5231")]
        MCC35 = 5231,

        [Description("Wallpaper Stores")]
        [JsonProperty("5231")]
        MCC36 = 5231,

        [Description("Hardware Stores")]
        [JsonProperty("5251")]
        MCC37 = 5251,

        [Description("Nurseries â€“ Lawn and Garden Supply Store")]
        [JsonProperty("5261")]
        MCC38 = 5261,

        [Description("Mobile Home Dealers")]
        [JsonProperty("5271")]
        MCC39 = 5271,

        [Description("Wholesale Clubs")]
        [JsonProperty("5300")]
        MCC40 = 5300,

        [Description("Duty Free Store")]
        [JsonProperty("5309")]
        MCC41 = 5309,

        [Description("Discount Stores")]
        [JsonProperty("5310")]
        MCC42 = 5310,

        [Description("Department Stores")]
        [JsonProperty("5311")]
        MCC43 = 5311,

        [Description("Variety Stores")]
        [JsonProperty("5331")]
        MCC44 = 5331,

        [Description("Misc. General Merchandise")]
        [JsonProperty("5399")]
        MCC45 = 5399,

        [Description("Grocery Stores")]
        [JsonProperty("5411")]
        MCC46 = 5411,

        [Description("Supermarkets")]
        [JsonProperty("5411")]
        MCC47 = 5411,

        [Description("Freezer and Locker Meat Provisioners")]
        [JsonProperty("5422")]
        MCC48 = 5422,

        [Description("Meat Provisioners â€“ Freezer and Locker")]
        [JsonProperty("5422")]
        MCC49 = 5422,

        [Description("Candy Stores")]
        [JsonProperty("5441")]
        MCC50 = 5441,

        [Description("Confectionery Stores")]
        [JsonProperty("5441")]
        MCC51 = 5441,

        [Description("Nut Stores")]
        [JsonProperty("5441")]
        MCC52 = 5441,

        [Description("Dairy Products Stores")]
        [JsonProperty("5451")]
        MCC53 = 5451,

        [Description("Bakeries")]
        [JsonProperty("5462")]
        MCC54 = 5462,

        [Description("Misc. Food Stores â€“ Convenience Stores and Specialty Markets")]
        [JsonProperty("5499")]
        MCC55 = 5499,

        [Description("Car and Truck Dealers (New and Used) Sales, Service, Repairs, Parts, and Leasing")]
        [JsonProperty("5511")]
        MCC56 = 5511,

        [Description("Automobile and Truck Dealers (Used Only)")]
        [JsonProperty("5521")]
        MCC57 = 5521,

        [Description("Automobile Supply Stores")]
        [JsonProperty("5531")]
        MCC58 = 5531,

        [Description("Automotive Tire Stores")]
        [JsonProperty("5532")]
        MCC59 = 5532,

        [Description("Automotive Parts, Accessories Stores")]
        [JsonProperty("5533")]
        MCC60 = 5533,

        [Description("Service Stations (with or without ancillary services)")]
        [JsonProperty("5541")]
        MCC61 = 5541,

        [Description("Automated Fuel Dispensers")]
        [JsonProperty("5542")]
        MCC62 = 5542,

        [Description("Boat Dealers")]
        [JsonProperty("5551")]
        MCC63 = 5551,

        [Description("Recreational and Utility Trailers, Camp Dealers")]
        [JsonProperty("5561")]
        MCC64 = 5561,

        [Description("Motorcycle Dealers")]
        [JsonProperty("5571")]
        MCC65 = 5571,

        [Description("Motor Home Dealers")]
        [JsonProperty("5592")]
        MCC66 = 5592,

        [Description("Snowmobile Dealers")]
        [JsonProperty("5598")]
        MCC67 = 5598,

        [Description("Menâ€™s and Boyâ€™s Clothing and Accessories Stores")]
        [JsonProperty("5611")]
        MCC68 = 5611,

        [Description("Womenâ€™s Ready - to - Wear Stores")]
        [JsonProperty("5621")]
        MCC69 = 5621,

        [Description("Womenâ€™s Accessory and Specialty Shops")]
        [JsonProperty("5631")]
        MCC70 = 5631,

        [Description("Childrenâ€™s and Infantâ€™s Wear Stores")]
        [JsonProperty("5641")]
        MCC71 = 5641,

        [Description("Family Clothing Stores")]
        [JsonProperty("5651")]
        MCC72 = 5651,

        [Description("Sports Apparel, Riding Apparel Stores")]
        [JsonProperty("5655")]
        MCC73 = 5655,

        [Description("Shoe Stores")]
        [JsonProperty("5661")]
        MCC74 = 5661,

        [Description("Furriers and Fur Shops")]
        [JsonProperty("5681")]
        MCC75 = 5681,

        [Description("Menâ€™s and Womenâ€™s Clothing Stores")]
        [JsonProperty("5691")]
        MCC76 = 5691,

        [Description("Tailors, Seamstress, Mending, and Alterations")]
        [JsonProperty("5697")]
        MCC77 = 5697,

        [Description("Wig and Toupee Stores")]
        [JsonProperty("5698")]
        MCC78 = 5698,

        [Description("Miscellaneous Apparel and Accessory Shops")]
        [JsonProperty("5699")]
        MCC79 = 5699,

        [Description("Furniture, Home Furnishings, and Equipment Stores, Except Appliances")]
        [JsonProperty("5712")]
        MCC80 = 5712,

        [Description("Floor Covering Stores")]
        [JsonProperty("5713")]
        MCC81 = 5713,

        [Description("Drapery, Window Covering and Upholstery Stores")]
        [JsonProperty("5714")]
        MCC82 = 5714,

        [Description("Fireplace, Fireplace Screens, and Accessories Stores")]
        [JsonProperty("5718")]
        MCC83 = 5718,

        [Description("Miscellaneous Home Furnishing Specialty Stores")]
        [JsonProperty("5719")]
        MCC84 = 5719,

        [Description("Household Appliance Stores")]
        [JsonProperty("5722")]
        MCC85 = 5722,

        [Description("Electronic Sales")]
        [JsonProperty("5732")]
        MCC86 = 5732,

        [Description("Music Stores, Musical Instruments, Piano Sheet Music")]
        [JsonProperty("5733")]
        MCC87 = 5733,

        [Description("Computer Software Stores")]
        [JsonProperty("5734")]
        MCC88 = 5734,

        [Description("Record Shops")]
        [JsonProperty("5735")]
        MCC89 = 5735,

        [Description("Caterers")]
        [JsonProperty("5811")]
        MCC90 = 5811,

        [Description("Eating places and Restaurants")]
        [JsonProperty("5812")]
        MCC91 = 5812,

        [Description("Drinking Places (Alcoholic Beverages), Bars, Taverns, Cocktail lounges, Nightclubs and Discotheques")]
        [JsonProperty("5813")]
        MCC92 = 5813,

        [Description("Fast Food Restaurants")]
        [JsonProperty("5814")]
        MCC93 = 5814,

        [Description("Drug Stores and Pharmacies")]
        [JsonProperty("5912")]
        MCC94 = 5912,

        [Description("Package Stores - Beer, Wine, and Liquor")]
        [JsonProperty("5921")]
        MCC95 = 5921,

        [Description("Used Merchandise and Secondhand Stores")]
        [JsonProperty("5931")]
        MCC96 = 5931,

        [Description("Antique Shops - Sales, Repairs, and Restoration Services")]
        [JsonProperty("5832")]
        MCC97 = 5832,

        [Description("Pawn Shops and Salvage Yards")]
        [JsonProperty("5933")]
        MCC98 = 5933,

        [Description("Wrecking and Salvage Yards")]
        [JsonProperty("5935")]
        MCC99 = 5935,

        [Description("Antique Reproductions")]
        [JsonProperty("5937")]
        MCC100 = 5937,

        [Description("Bicycle Shops - Sales and Service")]
        [JsonProperty("5940")]
        MCC101 = 5940,

        [Description("Sporting Goods Stores")]
        [JsonProperty("5941")]
        MCC102 = 5941,

        [Description("Book Stores")]
        [JsonProperty("5942")]
        MCC103 = 5942,

        [Description("Stationery Stores, Office and School Supply Stores")]
        [JsonProperty("5943")]
        MCC104 = 5943,

        [Description("Watch, Clock, Jewelry, and Silverware Stores")]
        [JsonProperty("5944")]
        MCC105 = 5944,

        [Description("Hobby, Toy, and Game Shops")]
        [JsonProperty("5945")]
        MCC106 = 5945,

        [Description("Camera and Photographic Supply Stores")]
        [JsonProperty("5946")]
        MCC107 = 5946,

        [Description("Card Shops, Gift, Novelty, and Souvenir Shops")]
        [JsonProperty("5947")]
        MCC108 = 5947,

        [Description("Leather Foods Stores")]
        [JsonProperty("5948")]
        MCC109 = 5948,

        [Description("Sewing, Needle, Fabric, and Price Goods Stores")]
        [JsonProperty("5949")]
        MCC110 = 5949,

        [Description("Glassware/Crystal Stores")]
        [JsonProperty("5950")]
        MCC111 = 5950,

        [Description("Direct Marketing - Insurance Service")]
        [JsonProperty("5960")]
        MCC112 = 5960,

        [Description("Mail Order Houses Including Catalog Order Stores, Book/Record Clubs (No longer permitted for .S. original presentments)")]
        [JsonProperty("5961")]
        MCC113 = 5961,

        [Description("Direct Marketing - Travel Related Arrangements Services")]
        [JsonProperty("5962")]
        MCC114 = 5962,

        [Description("Door - to - Door Sales")]
        [JsonProperty("5963")]
        MCC115 = 5963,

        [Description("Direct Marketing - Catalog Merchant")]
        [JsonProperty("5964")]
        MCC116 = 5964,

        [Description("Direct Marketing - Catalog and Catalog and Retail Merchant Direct Marketing - Outbound Telemarketing Merchant")]
        [JsonProperty("5965")]
        MCC117 = 5965,

        [Description("Direct Marketing -Inbound Teleservices Merchant")]
        [JsonProperty("5967")]
        MCC118 = 5967,

        [Description("Direct Marketing - Continuity/Subscription Merchant")]
        [JsonProperty("5968")]
        MCC119 = 5968,

        [Description("Direct Marketing - Not Elsewhere Classified")]
        [JsonProperty("5969")]
        MCC120 = 5969,

        [Description("Artistâ€™s Supply and Craft Shops")]
        [JsonProperty("5970")]
        MCC121 = 5970,

        [Description("Art Dealers and Galleries")]
        [JsonProperty("5971")]
        MCC122 = 5971,

        [Description("Stamp and Coin Stores - Philatelic and Numismatic Supplies")]
        [JsonProperty("5972")]
        MCC123 = 5972,

        [Description("Religious Goods Stores")]
        [JsonProperty("5973")]
        MCC124 = 5973,

        [Description("Hearing Aids - Sales, Service, and Supply Stores")]
        [JsonProperty("5975")]
        MCC125 = 5975,

        [Description("Orthopedic Goods Prosthetic Devices")]
        [JsonProperty("5976")]
        MCC126 = 5976,

        [Description("Cosmetic Stores")]
        [JsonProperty("5977")]
        MCC127 = 5977,

        [Description("Typewriter Stores - Sales, Rental, Service")]
        [JsonProperty("5978")]
        MCC128 = 5978,

        [Description("Fuel - Fuel Oil, Wood, Coal, Liquefied Petroleum")]
        [JsonProperty("5983")]
        MCC129 = 5983,

        [Description("Florists")]
        [JsonProperty("5992")]
        MCC130 = 5992,

        [Description("Cigar Stores and Stands")]
        [JsonProperty("5993")]
        MCC131 = 5993,

        [Description("News Dealers and Newsstands")]
        [JsonProperty("5994")]
        MCC132 = 5994,

        [Description("Pet Shops, Pet Foods, and Supplies Stores")]
        [JsonProperty("5995")]
        MCC133 = 5995,

        [Description("Swimming Pools - Sales, Service, and Supplies")]
        [JsonProperty("5996")]
        MCC134 = 5996,

        [Description("Electric Razor Stores - Sales and Service")]
        [JsonProperty("5997")]
        MCC135 = 5997,

        [Description("Tent and Awning Shops")]
        [JsonProperty("5998")]
        MCC136 = 5998,

        [Description("Miscellaneous and Specialty Retail Stores")]
        [JsonProperty("5999")]
        MCC137 = 5999,

        [Description("Financial Institutions - Manual Cash Disbursements")]
        [JsonProperty("6010")]
        MCC138 = 6010,

        [Description("Financial Institutions - Manual Cash Disbursements")]
        [JsonProperty("6011")]
        MCC139 = 6011,

        [Description("Financial Institutions - Merchandise and Services")]
        [JsonProperty("6012")]
        MCC140 = 6012,

        [Description("Non - Financial Institutions - Foreign Currency, Money Orders (not wire transfer) and Travelers Cheques")]
        [JsonProperty("6051")]
        MCC141 = 6051,

        [Description("Security Brokers/Dealers")]
        [JsonProperty("6211")]
        MCC142 = 6211,

        [Description("Insurance Sales, Underwriting, and Premiums")]
        [JsonProperty("6300")]
        MCC143 = 6300,

        [Description("Insurance Premiums, (no longer valid for first presentment work)")]
        [JsonProperty("6381")]
        MCC144 = 6381,

        [Description("Insurance, Not Elsewhere Classified (no longer valid for first presentment work)")]
        [JsonProperty("6399")]
        MCC145 = 6399,

        [Description("Lodging - Hotels, Motels, Resorts, Central Reservation Services (not elsewhere classified)")]
        [JsonProperty("7011")]
        MCC146 = 7011,

        [Description("Timeshares")]
        [JsonProperty("7012")]
        MCC147 = 7012,

        [Description("Sporting and Recreational Camps")]
        [JsonProperty("7032")]
        MCC148 = 7032,

        [Description("Trailer Parks and Camp Grounds")]
        [JsonProperty("7033")]
        MCC149 = 7033,

        [Description("Laundry, Cleaning, and Garment Services")]
        [JsonProperty("7210")]
        MCC150 = 7210,

        [Description("Laundry - Family and Commercial")]
        [JsonProperty("7211")]
        MCC151 = 7211,

        [Description("Dry Cleaners")]
        [JsonProperty("7216")]
        MCC152 = 7216,

        [Description("Carpet and Upholstery Cleaning")]
        [JsonProperty("7217")]
        MCC153 = 7217,

        [Description("Photographic Studios")]
        [JsonProperty("7221")]
        MCC154 = 7221,

        [Description("Barber and Beauty Shops")]
        [JsonProperty("7230")]
        MCC155 = 7230,

        [Description("Shop Repair Shops and Shoe Shine Parlors, and Hat Cleaning Shops")]
        [JsonProperty("7251")]
        MCC156 = 7251,

        [Description("Funeral Service and Crematories")]
        [JsonProperty("7261")]
        MCC157 = 7261,

        [Description("Dating and Escort Services")]
        [JsonProperty("7273")]
        MCC158 = 7273,

        [Description("Tax Preparation Service")]
        [JsonProperty("7276")]
        MCC159 = 7276,

        [Description("Counseling Service - Debt, Marriage, Personal")]
        [JsonProperty("7277")]
        MCC160 = 7277,

        [Description("Buying/Shopping Services, Clubs")]
        [JsonProperty("7278")]
        MCC161 = 7278,

        [Description("Clothing Rental - Costumes, Formal Wear, Uniforms")]
        [JsonProperty("7296")]
        MCC162 = 7296,

        [Description("Massage Parlors")]
        [JsonProperty("7297")]
        MCC163 = 7297,

        [Description("Health and Beauty Shops")]
        [JsonProperty("7298")]
        MCC164 = 7298,

        [Description("Miscellaneous Personal Services (not elsewhere classifies)")]
        [JsonProperty("7299")]
        MCC165 = 7299,

        [Description("Advertising Services")]
        [JsonProperty("7311")]
        MCC166 = 7311,

        [Description("Consumer Credit Reporting Agencies")]
        [JsonProperty("7321")]
        MCC167 = 7321,

        [Description("Blueprinting and Photocopying Services")]
        [JsonProperty("7332")]
        MCC168 = 7332,

        [Description("Commercial Photography, Art and Graphics")]
        [JsonProperty("7333")]
        MCC169 = 7333,

        [Description("Quick Copy, Reproduction and Blueprinting Services")]
        [JsonProperty("7338")]
        MCC170 = 7338,

        [Description("Stenographic and Secretarial Support Services")]
        [JsonProperty("7339")]
        MCC171 = 7339,

        [Description("Disinfecting Services")]
        [JsonProperty("7342")]
        MCC172 = 7342,

        [Description("Exterminating and Disinfecting Services")]
        [JsonProperty("7342")]
        MCC173 = 7342,

        [Description("Cleaning and Maintenance, Janitorial Services")]
        [JsonProperty("7349")]
        MCC174 = 7349,

        [Description("Employment Agencies, Temporary Help Services")]
        [JsonProperty("7361")]
        MCC175 = 7361,

        [Description("Computer Programming, Integrated Systems Design and Data Processing Services")]
        [JsonProperty("7372")]
        MCC176 = 7372,

        [Description("Information Retrieval Services")]
        [JsonProperty("7375")]
        MCC177 = 7375,

        [Description("Computer Maintenance and Repair Services, Not Elsewhere Classified")]
        [JsonProperty("7379")]
        MCC178 = 7379,

        [Description("Management, Consulting, and Public Relations Services")]
        [JsonProperty("7392")]
        MCC179 = 7392,

        [Description("Protective and Security Services - Including Armored Cars and Guard Dogs")]
        [JsonProperty("7393")]
        MCC180 = 7393,

        [Description("Equipment Rental and Leasing Services, Tool Rental, Furniture Rental, and Appliance Rental")]
        [JsonProperty("7394")]
        MCC181 = 7394,

        [Description("Photofinishing Laboratories, Photo Developing")]
        [JsonProperty("7395")]
        MCC182 = 7395,

        [Description("Business Services, Not Elsewhere Classified")]
        [JsonProperty("7399")]
        MCC183 = 7399,

        [Description("Car Rental Companies (Not Listed Below)")]
        [JsonProperty("7512")]
        MCC184 = 7512,

        [Description("Truck and Utility Trailer Rentals")]
        [JsonProperty("7513")]
        MCC185 = 7513,

        [Description("Motor Home and Recreational Vehicle Rentals")]
        [JsonProperty("7519")]
        MCC186 = 7519,

        [Description("Automobile Parking Lots and Garages")]
        [JsonProperty("7523")]
        MCC187 = 7523,

        [Description("Automotive Body Repair Shops")]
        [JsonProperty("7531")]
        MCC188 = 7531,

        [Description("Tire Re - treading and Repair Shops")]
        [JsonProperty("7534")]
        MCC189 = 7534,

        [Description("Paint Shops - Automotive")]
        [JsonProperty("7535")]
        MCC190 = 7535,

        [Description("Automotive Service Shops")]
        [JsonProperty("7538")]
        MCC191 = 7538,

        [Description("Car Washes")]
        [JsonProperty("7542")]
        MCC192 = 7542,

        [Description("Towing Services")]
        [JsonProperty("7549")]
        MCC193 = 7549,

        [Description("Radio Repair Shops")]
        [JsonProperty("7622")]
        MCC194 = 7622,

        [Description("Air Conditioning and Refrigeration Repair Shops")]
        [JsonProperty("7623")]
        MCC195 = 7623,

        [Description("Electrical And Small Appliance Repair Shops")]
        [JsonProperty("7629")]
        MCC196 = 7629,

        [Description("Watch, Clock, and Jewelry Repair")]
        [JsonProperty("7631")]
        MCC197 = 7631,

        [Description("Furniture, Furniture Repair, and Furniture Refinishing")]
        [JsonProperty("7641")]
        MCC198 = 7641,

        [Description("Welding Repair")]
        [JsonProperty("7692")]
        MCC199 = 7692,

        [Description("Repair Shops and Related Services - Miscellaneous")]
        [JsonProperty("7699")]
        MCC200 = 7699,

        [Description("Motion Pictures and Video Tape Production and Distribution")]
        [JsonProperty("7829")]
        MCC201 = 7829,

        [Description("Motion Picture Theaters")]
        [JsonProperty("7832")]
        MCC202 = 7832,

        [Description("Video Tape Rental Stores")]
        [JsonProperty("7841")]
        MCC203 = 7841,

        [Description("Dance Halls, Studios and Schools")]
        [JsonProperty("7911")]
        MCC204 = 7911,

        [Description("Theatrical Producers (Except Motion Pictures), Ticket Agencies")]
        [JsonProperty("7922")]
        MCC205 = 7922,

        [Description("Bands. Orchestras, and Miscellaneous Entertainers (Not Elsewhere Classified)")]
        [JsonProperty("7929")]
        MCC206 = 7929,

        [Description("Billiard and Pool Establishments")]
        [JsonProperty("7932")]
        MCC207 = 7932,

        [Description("Bowling Alleys")]
        [JsonProperty("7933")]
        MCC208 = 7933,

        [Description("Commercial Sports, Athletic Fields, Professional Sport Clubs, and Sport Promoters")]
        [JsonProperty("7941")]
        MCC209 = 7941,

        [Description("Tourist Attractions and Exhibits")]
        [JsonProperty("7991")]
        MCC210 = 7991,

        [Description("Golf Courses - Public")]
        [JsonProperty("7992")]
        MCC211 = 7992,

        [Description("Video Amusement Game Supplies")]
        [JsonProperty("7993")]
        MCC212 = 7993,

        [Description("Video Game Arcades/Establishments")]
        [JsonProperty("7994")]
        MCC213 = 7994,

        [Description("Betting (including Lottery Tickets, Casino Gaming Chips, Off - track Betting and Wagers)")]
        [JsonProperty("7995")]
        MCC214 = 7995,

        [Description("Amusement Parks, Carnivals, Circuses, Fortune Tellers")]
        [JsonProperty("7996")]
        MCC215 = 7996,

        [Description("Membership Clubs (Sports, Recreation, Athletic), Country Clubs, and Private Golf Courses")]
        [JsonProperty("7997")]
        MCC216 = 7997,

        [Description("Aquariums, Sea - aquariums, Dolphinariums")]
        [JsonProperty("7998")]
        MCC217 = 7998,

        [Description("Recreation Services (Not Elsewhere Classified)")]
        [JsonProperty("7999")]
        MCC218 = 7999,

        [Description("Doctors and Physicians (Not Elsewhere Classified)")]
        [JsonProperty("8011")]
        MCC219 = 8011,

        [Description("Dentists and Orthodontists")]
        [JsonProperty("8021")]
        MCC220 = 8021,

        [Description("Osteopaths")]
        [JsonProperty("8031")]
        MCC221 = 8031,

        [Description("Chiropractors")]
        [JsonProperty("8041")]
        MCC222 = 8041,

        [Description("Optometrists and Ophthalmologists")]
        [JsonProperty("8042")]
        MCC223 = 8042,

        [Description("Opticians, Opticians Goods and Eyeglasses")]
        [JsonProperty("8043")]
        MCC224 = 8043,

        [Description("Opticians, Optical Goods, and Eyeglasses (no longer valid for first presentments)")]
        [JsonProperty("8044")]
        MCC225 = 8044,

        [Description("Podiatrists and Chiropodists")]
        [JsonProperty("8049")]
        MCC226 = 8049,

        [Description("Nursing and Personal Care Facilities")]
        [JsonProperty("8050")]
        MCC227 = 8050,

        [Description("Hospitals")]
        [JsonProperty("8062")]
        MCC228 = 8062,

        [Description("Medical and Dental Laboratories")]
        [JsonProperty("8071")]
        MCC229 = 8071,

        [Description("Medical Services and Health Practitioners (Not Elsewhere Classified)")]
        [JsonProperty("8099")]
        MCC230 = 8099,

        [Description("Legal Services and Attorneys")]
        [JsonProperty("8111")]
        MCC231 = 8111,

        [Description("Elementary and Secondary Schools")]
        [JsonProperty("8211")]
        MCC232 = 8211,

        [Description("Colleges, Junior Colleges, Universities, and Professional Schools")]
        [JsonProperty("8220")]
        MCC233 = 8220,

        [Description("Correspondence Schools")]
        [JsonProperty("8241")]
        MCC234 = 8241,

        [Description("Business and Secretarial Schools")]
        [JsonProperty("8244")]
        MCC235 = 8244,

        [Description("Vocational Schools and Trade Schools")]
        [JsonProperty("8249")]
        MCC236 = 8249,

        [Description("Schools and Educational Services (Not Elsewhere Classified)")]
        [JsonProperty("8299")]
        MCC237 = 8299,

        [Description("Child Care Services")]
        [JsonProperty("8351")]
        MCC238 = 8351,

        [Description("Charitable and Social Service Organizations")]
        [JsonProperty("8398")]
        MCC239 = 8398,

        [Description("Civic, Fraternal, and Social Associations")]
        [JsonProperty("8641")]
        MCC240 = 8641,

        [Description("Political Organizations")]
        [JsonProperty("8651")]
        MCC241 = 8651,

        [Description("Religious Organizations")]
        [JsonProperty("8661")]
        MCC242 = 8661,

        [Description("Automobile Associations")]
        [JsonProperty("8675")]
        MCC243 = 8675,

        [Description("Membership Organizations (Not Elsewhere Classified)")]
        [JsonProperty("8699")]
        MCC244 = 8699,

        [Description("Testing Laboratories (non - medical)")]
        [JsonProperty("8734")]
        MCC245 = 8734,

        [Description("Architectural - Engineering and Surveying Services")]
        [JsonProperty("8911")]
        MCC246 = 8911,

        [Description("Accounting, Auditing, and Bookkeeping Services")]
        [JsonProperty("8931")]
        MCC247 = 8931,

        [Description("Professional Services (Not Elsewhere Defined)")]
        [JsonProperty("8999")]
        MCC248 = 8999,

        [Description("Court Costs, including Alimony and Child Support")]
        [JsonProperty("9211")]
        MCC249 = 9211,

        [Description("Fines")]
        [JsonProperty("9222")]
        MCC250 = 9222,

        [Description("Bail and Bond Payments")]
        [JsonProperty("9223")]
        MCC251 = 9223,

        [Description("Tax Payments")]
        [JsonProperty("9311")]
        MCC252 = 9311,

        [Description("Government Services (Not Elsewhere Classified)")]
        [JsonProperty("9399")]
        MCC253 = 9399,

        [Description("Postal Services - Government Only")]
        [JsonProperty("9402")]
        MCC254 = 9402,

        [Description("Intra - Government Transactions")]
        [JsonProperty("9405")]
        MCC255 = 9405,

        [Description("Automated Referral Service (For Visa Only)")]
        [JsonProperty("9700")]
        MCC256 = 9700,

        [Description("Visa Credential Service (For Visa Only)")]
        [JsonProperty("9701")]
        MCC257 = 9701,

        [Description("GCAS Emergency Services (For Visa Only)")]
        [JsonProperty("9702")]
        MCC258 = 9702,

        [Description("Intra - Company Purchases (For Visa Only)")]
        [JsonProperty("9950")]
        MCC259 = 9950,
    }
}
