using System.Diagnostics;

namespace TelltaleEXTGUI
{
    public class TelltaleEXTMain
    {
        public static List<String> GAMES = new()
        {
            "Wallace & Gromit: Episode 1: Fright of the Bumblebees",
            "Wallace & Gromit: Episode 2: The Last Resort",
            "Wallace & Gromit: Episode 3: Muzzled",
            "Telltale Texas Hold'em",
            "Bone: Out From Boneville",
            "Bone: The Great Cow Race",
            "Sam & Max: Episode 101 - Culture Shock",
            "Sam & Max: Episode 102 - Situation: Comedy",
            "Sam & Max: Episode 103 - The Mole, The Mob, and the Meatball",
            "Sam & Max: Episode 104 - Abe Lincoln Must Die!",
            "Sam & Max: Episode 105 - Reality 2.0",
            "Sam & Max: Episode 106 - Bright Side of the Moon",
            "Sam & Max: Episode 201 - Ice Station Santa",
            "Sam & Max: Episode 202 - Moai Better Blues",
            "Sam & Max: Episode 203 - Night of the Raving Dead",
            "Sam & Max: Episode 204 - Chariots of the Dogs",
            "Sam & Max: Episode 205 - What's New, Beelzebub",
            "Strong Bad: Episode 1 - Homestar Ruiner",
            "Strong Bad: Episode 2 - Strong Badia the Free",
            "Strong Bad: Episode 3 - Baddest of the Bands",
            "Strong Bad: Episode 4 - Daneresque 3",
            "Strong Bad: Episode 5 - 8-Bit Is Enough",
            "CSI 3 - Dimensions of Murder / Bone demo",
            "CSI 4 - Hard Evidence (demo)",
            "Tales of Monkey Island 101: Launch of the Screaming Narwhal",
            "Wallace & Gromit: Episode 4: The Bogey Man",
            "Tales of Monkey Island 102: The Siege of Spinner Cay",
            "Tales of Monkey Island 103: Lair of the Leviathan",
            "CSI 5 - Deadly Intent",
            "Tales of Monkey Island 104: The Trial and Execution of Guybrush Threepwood",
            "CSI 4 - Hard Evidence",
            "Tales of Monkey Island 105: Rise of the Pirate God",
            "CSI 5 - Deadly Intent (demo)",
            "Sam & Max: Episode 301 - The Penal Zone",
            "Sam & Max: Episode 302 - The Tomb of Sammun-Mak",
            "Sam & Max: Episode 303 - They Stole Max's Brain!",
            "Puzzle Agent - The Mystery of Scoggins",
            "Sam & Max: Episode 304 - Beyond the Alley of the Dolls",
            "Sam & Max: Episode 305 - The City That Dares Not Sleep",
            "Poker Night at the Inventory",
            "CSI 6 - Fatal Conspiracy",
            "Back To The Future: Episode 1 - It's About Time",
            "Back To The Future: Episode 2 - Get Tannen!",
            "Back To The Future: Episode 3 - Citizen Brown",
            "Hector: Episode 1 - We Negotiate with Terrorists",
            "Back To The Future: Episode 4 - Double Visions",
            "Back To The Future: Episode 5 - OUTATIME",
            "Puzzle Agent 2",
            "Jurassik Park: The Game",
            "Hector: Episode 2 - Senseless Act of Justice",
            "Hector: Episode 3 - Beyond Reasonable Doom",
            "Law and Order: Legacies",
            "Walking Dead: A New Day",
            "Poker Night 2",
            "The Wolf Among Us",
            "The Walking Dead: Season 2",
            "Tales from the Borderlands (all episodes)",
            "Game of Thrones (all episodes)",
            "Minecraft: Story Mode",
            "The Walking Dead: Michonne",
            "Batman: The Telltale Series",
            "The Walking Dead: A New Frontier",
            "Marvel's Guardians of the Galaxy",
            "Minecraft: Story Mode - Season Two",
            "Batman: The Enemy Within",
            "Bone: Out From Boneville 2.0",
            "Bone: The Great Cow Race 2.0",
            "The Walking Dead: The Telltale Definitive Series"
        };


        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new TelltaleEXTForm());

            Console.WriteLine(Directory.GetCurrentDirectory() + "\\ttarchext\\ttarchext.exe");
        }
    }
}