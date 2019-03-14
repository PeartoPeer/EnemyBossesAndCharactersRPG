 public static int lvl;
        public static double guard;
        public static double speech ;
        public static double illusion;
        public static double strength;
        public static string penalty;
        public static double penaltynum;
        public static string motto;
        public static int agility;






        public void NPC (string name)
        {
            switch (name)
            {
                case"Csoko":
                    lvl = 5;
                    speech=70;
                    guard = 80;
                    illusion = 20;
                    strength = 50;
                    penaltynum = illusion - 10;
                    agility = 60;
                    motto = "I hope your paying attention";
                    


                    break;
                case "Pisztolyos":
                    lvl = 3;
                    speech = 45;
                    illusion = 50;
                    strength = 40;
                    guard= 10;
                    agility = 80;
                    motto = "Cmon, its time to do some exrcise on the stairs!";



                    break;
                case "Bufesneni":
                    lvl = 1;
                    speech = 10;
                    illusion = 100;
                    strength = 0;
                    guard = 10;
                    agility = 5;
                    motto = "Watch your profanity!";



                    break;
                case "oleh":
                    lvl = 8;
                    speech = 90;
                    illusion = 80;
                    strength = 90;
                    guard = 70;
                    agility = 40;
                    motto = "I'll rip you apart, if you dont stay quiet";


                    break;
                case "Tugotutu":
                    lvl = 4;
                    speech = 20;
                    illusion = 60;
                    strength = 0;
                    guard = 20;
                    agility = 20;
                    motto = "I like me some tyunnelsz";
                    break;
                case "Vegh Chungus":
                    lvl = 1;
                    speech = 5;
                    illusion = 10;
                    strength = 10;
                    guard = 50;
                    agility = 60;
                    motto = "";


                    break;


                    
                case "keles":
                    lvl = 2;
                    speech = 20;
                    illusion = 90;
                    strength = 10; //pretty weak
                    guard = 0; // instantly attracts Csoko
                    motto = "Wanna play clash royale?";
                    agility = 45;

                    break;
                case "V":
                    lvl = 1;
                    speech = 5;
                    illusion = 10;
                    strength = 10;
                    guard = 50;
                    agility = 60;
                    motto = "Plz dont bully me.";


                    break;
                case "Feder":
                    lvl = 6;
                    speech = 65;
                    illusion = 30;
                    strength = 35;
                    guard = 40;
                    agility = 10;
                    motto = "Want some rope to hang yourself?";
                    break;
                case "lajos":
                    lvl = 7;
                    speech = 45;
                    illusion = 10;
                    strength = 65;//steel toed boots  are kinda strong on this one
                    guard = 40;
                    agility = 25;
                    motto = "Want some icecream?";
                    break;
                case "satti":
                    lvl = 7;
                    speech = 50;
                    illusion = 25;
                    strength = 60;//throws ball very stron
                    guard = 50;
                    agility = 60;
                    motto = "I can program anything for you!";
                    break;
                case "istvan":
                    lvl = 3;
                    speech = 10;
                    illusion = 10;
                    strength = 70;
                    guard = 70;
                    agility = 60;
                    motto = "";
                    break;
                case "Laci":
                    lvl = 1;
                    speech = 5;
                    illusion = 10;
                    strength = 30;
                    guard = 20;
                    agility = 50;
                    motto = "Im annoying and i dont notice it";
                    break;
                case "Szolath":
                    lvl = 5;
                    speech = 50;
                    illusion = 30;
                    strength = 25;
                    guard = 30;
                    agility = 45;
                    motto = "*tips fedora*";
                    break;



                default:
                    Console.WriteLine("Something went wrong"); 
                    break;
            }
            

            
        }