using System;
using Microsoft.Office.Interop.Excel;
using System.Windows.Forms;
using Range = Microsoft.Office.Interop.Excel.Range;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Runtime.Intrinsics.X86;
using CsvHelper;
using System.Globalization;
using static System.Console;
using System.IO;
using System.Linq;
using System.Windows.Forms.DataVisualization;
using System.Drawing;




namespace Champs
{
    public partial class Form1 : Form
    {
        private string CsvFilePath = @"C:\Users\cammaranol\source\repos\Excel\NBA{0}Stats.csv";
        private const char CsvSeperator = ',';
        private string[] years = { "2019", "2020", "2021", "2022", "2023" };
        public Form1()
        {
            InitializeComponent();
            //left 
            YearCmboBox1.Items.AddRange(years);
            YearCmboBox1.SelectedIndex = 0;
            //right
            YearCmboBox2.Items.AddRange(years);
            YearCmboBox2.SelectedIndex = 0;

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //get user input
            string userInput = NameTxt1.Text;
            //search for user input in CSV file

            using (var reader = new StreamReader(String.Format(CsvFilePath, years[YearCmboBox1.SelectedIndex])))
            {
                string output = "";
                while (!reader.EndOfStream)
                {
                    //read each line in CSV file
                    string line = reader.ReadLine();
                    //split the line into an array of values
                    string[] values = line.Split(CsvSeperator);

                    //compare the value in the first column to the user input
                    if (values[1].Equals(userInput, StringComparison.OrdinalIgnoreCase))
                    {
                        output = line;
                        break;
                    }
                }
                if (output.Length > 0)
                {
                    string[] values = output.Split(CsvSeperator);
                    //output string with the stats
                    string Name = values[1];
                    string Team = values[2];
                    string Position = values[3];
                    double Age = 0.0;
                    double.TryParse(values[4], out Age);
                    int GamesPlayed = 0;
                    int.TryParse(values[5], out GamesPlayed);
                    double MinutesPG = 0.0;
                    double.TryParse(values[6], out MinutesPG);
                    double UsagePercent = 0.0;
                    double.TryParse(values[7], out UsagePercent);
                    double TurnoverPercent = 0.0;
                    double.TryParse(values[8], out TurnoverPercent);
                    int FTAttempts = 0;
                    int.TryParse(values[9], out FTAttempts);
                    double FTPercent = 0.0;
                    double.TryParse(values[10], out FTPercent);
                    int TwPtAttempts = 0;
                    int.TryParse(values[11], out TwPtAttempts);
                    double TwPtPercent = 0.0;
                    double.TryParse(values[12], out TwPtPercent);
                    int ThPtAttempts = 0;
                    int.TryParse(values[13], out ThPtAttempts);
                    double ThPtPercent = 0.0;
                    double.TryParse(values[14], out ThPtPercent);
                    double EffectiveFGPercent = 0.0;
                    double.TryParse(values[15], out EffectiveFGPercent);
                    double TrueShotPercent = 0.0;
                    double.TryParse(values[16], out TrueShotPercent);
                    double PPG = 0.0;
                    double.TryParse(values[17], out PPG);
                    double RPG = 0.0;
                    double.TryParse(values[18], out RPG);
                    double APG = 0.0;
                    double.TryParse(values[19], out APG);
                    double SPG = 0.0;
                    double.TryParse(values[20], out SPG);
                    double BPG = 0.0;
                    double.TryParse(values[21], out BPG);
                    double TPG = 0.0;
                    double.TryParse(values[22], out TPG);
                    double VersatilityIndex = 0.0;
                    double.TryParse(values[23], out VersatilityIndex);
                    double OffensiveRating = 0.0;
                    double.TryParse(values[24], out OffensiveRating);
                    double DefensiveRating = 0.0;
                    double.TryParse(values[25], out DefensiveRating);

                    output = $"{Name} \nTeam: {Team} \nPosition: {Position}" +
                        $"\nAge: {Age} \nGames Played: {GamesPlayed} \nMinutes Per Game: {MinutesPG}" +
                        $"\nUsage Percentage: {UsagePercent} \nTurnover Percentage: {TurnoverPercent}" +
                        $"\nFree Throw Attempts: {FTAttempts} \nFree Throw Percentage: {FTPercent}" +
                        $"\nTwo Point Attempts: {TwPtAttempts} \nTwo Point Percentage: {TwPtPercent}" +
                        $"\nThree Point Attempts: {ThPtAttempts} \nThree Point Percentage: {ThPtPercent}" +
                        $"\nEffective Field Goal Percentage: {EffectiveFGPercent} \nTrue Shot Percentage: {TrueShotPercent}" +
                        $"\nPoints Per Game: {PPG} \nRebounds Per Game: {RPG} \nAssists Per Game: {APG}" +
                        $"\nSteals Per Game: {SPG} \nBlocks Per Game: {BPG} \nTurnovers Per Game: {TPG}" +
                        $"\nVersatility Index: {VersatilityIndex} \nOffensive Rating: {OffensiveRating} \nDefensive Rating: {DefensiveRating}";

                    outputLabel1.Text = output;
                }
                else
                {
                    outputLabel1.Text = "Player not found.";
                }
            }
        }

        private void NameTxt_TextChanged(object sender, EventArgs e)
        {
            
        }
        
        private void YearCmboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void SearchBtn2_Click(object sender, EventArgs e)
        {
            //get user input
            string userInput = NameTxt2.Text;
            //search for user input in CSV file

            using (var reader = new StreamReader(String.Format(CsvFilePath, years[YearCmboBox2.SelectedIndex])))
            {
                string output = "";
                while (!reader.EndOfStream)
                {
                    //read each line in CSV file
                    string line = reader.ReadLine();
                    //split the line into an array of values
                    string[] values = line.Split(CsvSeperator);

                    //compare the value in the first column to the user input
                    if (values[1].Equals(userInput, StringComparison.OrdinalIgnoreCase))
                    {
                        output = line;
                        break;
                    }
                }
                if (output.Length > 0)
                {
                    string[] values = output.Split(CsvSeperator);
                    //output string with the stats
                    string Name = values[1];
                    string Team = values[2];
                    string Position = values[3];
                    double Age = 0.0;
                    double.TryParse(values[4], out Age);
                    int GamesPlayed = 0;
                    int.TryParse(values[5], out GamesPlayed);
                    double MinutesPG = 0.0;
                    double.TryParse(values[6], out MinutesPG);
                    double UsagePercent = 0.0;
                    double.TryParse(values[7], out UsagePercent);
                    double TurnoverPercent = 0.0;
                    double.TryParse(values[8], out TurnoverPercent);
                    int FTAttempts = 0;
                    int.TryParse(values[9], out FTAttempts);
                    double FTPercent = 0.0;
                    double.TryParse(values[10], out FTPercent);
                    int TwPtAttempts = 0;
                    int.TryParse(values[11], out TwPtAttempts);
                    double TwPtPercent = 0.0;
                    double.TryParse(values[12], out TwPtPercent);
                    int ThPtAttempts = 0;
                    int.TryParse(values[13], out ThPtAttempts);
                    double ThPtPercent = 0.0;
                    double.TryParse(values[14], out ThPtPercent);
                    double EffectiveFGPercent = 0.0;
                    double.TryParse(values[15], out EffectiveFGPercent);
                    double TrueShotPercent = 0.0;
                    double.TryParse(values[16], out TrueShotPercent);
                    double PPG = 0.0;
                    double.TryParse(values[17], out PPG);
                    double RPG = 0.0;
                    double.TryParse(values[18], out RPG);
                    double APG = 0.0;
                    double.TryParse(values[19], out APG);
                    double SPG = 0.0;
                    double.TryParse(values[20], out SPG);
                    double BPG = 0.0;
                    double.TryParse(values[21], out BPG);
                    double TPG = 0.0;
                    double.TryParse(values[22], out TPG);
                    double VersatilityIndex = 0.0;
                    double.TryParse(values[23], out VersatilityIndex);
                    double OffensiveRating = 0.0;
                    double.TryParse(values[24], out OffensiveRating);
                    double DefensiveRating = 0.0;
                    double.TryParse(values[25], out DefensiveRating);

                    output = $"\nTeam: {Team} \nPosition: {Position}" +
                        $"\nAge: {Age} \nGames Played: {GamesPlayed} \nMinutes Per Game: {MinutesPG}" +
                        $"\nUsage Percentage: {UsagePercent} \nTurnover Percentage: {TurnoverPercent}" +
                        $"\nFree Throw Attempts: {FTAttempts} \nFree Throw Percentage: {FTPercent}" +
                        $"\nTwo Point Attempts: {TwPtAttempts} \nTwo Point Percentage: {TwPtPercent}" +
                        $"\nThree Point Attempts: {ThPtAttempts} \nThree Point Percentage: {ThPtPercent}" +
                        $"\nEffective Field Goal Percentage: {EffectiveFGPercent} \nTrue Shot Percentage: {TrueShotPercent}" +
                        $"\nPoints Per Game: {PPG} \nRebounds Per Game: {RPG} \nAssists Per Game: {APG}" +
                        $"\nSteals Per Game: {SPG} \nBlocks Per Game: {BPG} \nTurnovers Per Game: {TPG}" +
                        $"\nVersatility Index: {VersatilityIndex} \nOffensive Rating: {OffensiveRating} \nDefensive Rating: {DefensiveRating}";

                    outputLabel2.Text = output;
                }
                else
                {
                    outputLabel2.Text = "Player not found.";
                }
            }
        }

        private void SearchBtn3_Click(object sender, EventArgs e)
        {
            //get user input
            string defInput = DefinitionTxt.Text;
            // terms and definitions 
            string Team = "Team";
            string Position = "Position";
            string MinutesPerGame = "Minutes Per Game";
            string UsagePercentage = "Usage Percentage";
            string TurnoverPercentage = "Turnover Percentage";
            string FreeThrowAttempts = "Free Throw Attempts";
            string FreeThrowPercentage = "Free Throw Percentage";
            string TwoPointAttempts = "Two Point Attempts";
            string TwoPointPercentage = "Two Point Percentage";
            string ThreePointAttempts = "Three Point Attempts";
            string ThreePointPercentage = "Three Point Percentage";
            string EffectiveFieldGoalPercentage = "Effective Field Goal Percentage";
            string TrueShotPercentage = "True Shot Percentage";
            string PointsPerGame = "Points Per Game";
            string ReboundsPerGame = "Rebounds Per Game";
            string AssistsPerGame = "Assists Per Game";
            string StealsPerGame = "Steals Per Game";
            string BlocksPerGame = "Blocks Per Game";
            string TurnoversPerGame = "Turnovers Per Game";
            string VersatilityIndex = "Versatility Index";
            string OffensiveRating = "Offensive Rating";
            string DefensiveRating = "Defensive Rating";

            if (defInput == Team)
            {
                MessageBox.Show("  ATLANTIC DIVISION" +
                    "\nBos: Boston Celtics" +
                    "\nBro: Brooklyn Nets" +
                    "\nNyk: New York Knicks" +
                    "\nPhi: Philadelphia 76ers" +
                    "\nTor: Toronto Raptors" +
                    "\n\n  CENTRAL DIVISION" +
                    "\nChi: Chicago Bulls" +
                    "\nCle: Cleveland Cavaliers" +
                    "\nDet: Detroit Pistons" +
                    "\nInd: Indians Pacers" +
                    "\nMil: Milkwaukee Bucks" +
                    "\n\n  SOUTHWEST DIVISION" +
                    "\nAtl: Atlanta Hawks" +
                    "\nCha: Charlotte Hornets" +
                    "\nMia: Miami Heat" +
                    "\nOrl: Orllando Magic" +
                    "\nWas: Washington Wizards" +
                    "\n\n  NORTHEAST DIVISION" +
                    "\nDen: Denver Nuggets" +
                    "\nMin: Minnesota Timberwolves" +
                    "\nOkl: Oklahoma City Thunder" +
                    "\nPor: Portland Trail Blazers" +
                    "\nUta: Utah Jazz" +
                    "\n\n  PACIFIC DIVISION" +
                    "\nGol: Golden State Warriors" +
                    "\nLac: Los Angeles Clippers" +
                    "\nLal: Los Angeles Lakers" +
                    "\nPho: Phoenix Suns" +
                    "\nSac: Sacramento Kings" +
                    "\n\n  SOUTHWEST DIVISION" +
                    "\nDal: Dallas Mavericks" +
                    "\nHou: Houston Rockets" +
                    "\nMem: Memphis Grizzlies" +
                    "\nNew: New Orlean Pelicans" +
                    "\nSan: San Antonio Spurs");
            }
            if (defInput == Position)
            {
                MessageBox.Show("G: Guard" +
                    "\n\tPoint Guard: tends to be the team's " +
                    "best ball handler. They are responsible for directing the plays." +
                    "\n\tShooting Guard: tends to be the team's best outside shooter." +
                    "They are skilled in dribbling quickly, passing efficiently, " +
                    "and having great court vision." +
                    "\n\nF: Forward" +
                    "\n\tPower Forward: tend to be most similar to the center" +
                    "regarding their height. they are versatile in their ability to score" +
                    "in the paint as well as shoot from midrange." +
                    "\n\tSmall Forward: tends to play the most versatile role on the inside" +
                    "and outside similar to a shooting guard. They can do practically everything" +
                    "on the court." +
                    "\n\nC: Center" +
                    "\n\tCenter: tends to be the tallest and strongest player positioned under the basket. Most of " +
                    "their points consists of offensive rebounds, being fed into the paint, and on defense" +
                    "they block shots from players driving to the basket.");
                  
            }
            if (defInput == MinutesPerGame)
            {
                MessageBox.Show("Minutes Per Game: The average number of minutes a player plays per game." +
                    "\n\tFormula: Minutes / Games Played");
            }
            if (defInput == UsagePercentage)
            {
                MessageBox.Show("Usage Percentage: The percentage of team plays used by " +
                    "a player white he was on the floor." +
                    "\n\tFormula: 100*((Player's Field Goal Attempts)+0.44*(Player's Free Throw Attempts)+(Player's Turnovers))" +
                    "*(Team's Total Minutes) / ((Team's Total Field Goal Attempts)+0.44*(Team's Total Free Throw Attempts)+" +
                    "(Team's Total Turnovers))*5*(Player's Minutes)");
            }
            if (defInput == TurnoverPercentage)
            {
                MessageBox.Show("Turnover Percentage: The percentage of the player's possessions that end in a turnover." +
                    "\n\tFormula: 100*(Player's Turnovers) / (Player's Field Goal Attempts)+0.44+(Player's Free Throw Attempts)+(Player's Turnovers)");
            }
            if (defInput == FreeThrowAttempts)
            {
                MessageBox.Show("Free Throw Attempts: Shot attempts by the plyaer from the free throw line after getting fouled.");
            }
            if (defInput == FreeThrowPercentage)
            {
                MessageBox.Show("Free Throw Percentage: The percentage of the player's free throw success." +
                    "\n\tFormula: (Player's Free Throw Attempts)/(Player's Free Throw Makes) * 100");
            }
            if (defInput == TwoPointAttempts)
            {
                MessageBox.Show("Two Point Attempts: Shot attempts by the player from anywhere within the 3-point circle.");
            }
            if (defInput == TwoPointPercentage)
            {
                MessageBox.Show("The percentage of field goals made by a player from within the 3-point line." +
                    "\n\tFormula: (Player's Two Point Attempts)/Player's Two Point Makes) * 100");
            }
            if (defInput == ThreePointAttempts)
            {
                MessageBox.Show("Three Point Attempts: Shot attempts by the player from anywehre beyond the 3-point circle.");
            }
            if (defInput == ThreePointPercentage)
            {
                MessageBox.Show("The percentage of field goals made by a player from beyond the 3-point line." +
                    "\n\tFormula: (Player's Three Point Attempts)/Player's Three Point Makes) * 100");
            }
            if (defInput == EffectiveFieldGoalPercentage)
            {
                MessageBox.Show("Effective Field Goal Percentage: the effectiveness of the player when shooting from the field." +
                    "\n\tFormula: (Player's Two Point Makes)+1.5*(Players Three Point Makes)");
            }
            if (defInput == TrueShotPercentage)
            {
                MessageBox.Show("True Shot Percentage: a metric that factors a player's performance at the free throw line while" +
                    "considering the efficiency of all types of shots. " +
                    "\n\tFormula: (Player's Points Scored) / (2*(Player's Field Goal Attempts)+0.44*(Player's Field Throw Attempts))");
            }
            if (defInput == PointsPerGame)
            {
                MessageBox.Show("Points Per Game: The average number of points scored by a player per game." +
                    "\n\tFormula: (Player's Total Points Scored) / (Games Played)");
            }
            if (defInput == ReboundsPerGame)
            {
                MessageBox.Show("Rebounds Per Game: The average number of rebounds by a player per game." +
                    "\n\tFormula: (Player's Total Rebounds) / (Games Played)");
            }
            if (defInput == AssistsPerGame)
            {
                MessageBox.Show("Assists Per Game: The average number of assists committed by a player per game." +
                    "\n\tFormula: (Player's Total Assists) / (Games Played)");
            }
            if (defInput == StealsPerGame)
            {
                MessageBox.Show("Steals Per Game: The average number of steals made by a player per game." +
                    "n\\tFormula: (Player's Total Steals) / (Games Played)");
            }
            if (defInput == BlocksPerGame)
            {
                MessageBox.Show("Blocks Per Game: The average number of blocks on an opponent made by a player per game." +
                    "\n\tFormula: (Player's Total Blocks) / (Games Played)");
            }
            if (defInput == TurnoversPerGame)
            {
                MessageBox.Show("Turnovers Per Game: The average number of turnovers committed by a player per game." +
                    "\n\tFormula: (Player's Total Turnovers) / (Games Played)");
            }
            if (defInput == VersatilityIndex)
            {
                MessageBox.Show("Versatility Index: A metric that measures the player's ability to produce in more than" +
                    "one statistic using points, assists, and rebounds. It highlights well-rounded players. " +
                    "for example, the average player will have an index of 5." +
                    "\n\tFormula: Cubed Root((Player's Points Per Game)*(Player's Rebounds Per Game)*(Player's Assists Per Game))");
            }
            if (defInput == OffensiveRating)
            {
                MessageBox.Show("Offensive Rating: A statistic used to measure the player's offensive performance and the " +
                    "player's efficiency at producing points per 100 possessions for the offense." +
                    "\n\tFormula: (Points Produced by Player) / (Player's Total Possessions)");
            }
            if (defInput == DefensiveRating)
            {
                MessageBox.Show("Defensive Rating: A statistic used to measure how many points a player allows per 100 possessions " +
                    "when he was individually faced on the court." +
                    "\n\tFormula: ((Player's Total Steals)*(Player's Total Blocks)) + " +
                    "(1/5 of possesions) - (Times Blown By) + (Deflections) * (Official Adjusted Players Defensive Withstand)");
            }

        }
    }

}
    
