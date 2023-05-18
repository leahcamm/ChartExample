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
            YearCmboBox.Items.AddRange(years);
            
            YearCmboBox.SelectedIndex = 0;
         
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //get user input
            string userInput = NameTxt.Text;
            //search for user input in CSV file

            using (var reader = new StreamReader(String.Format(CsvFilePath, years[YearCmboBox.SelectedIndex])))
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

                    outputLabel.Text = output;
                }
                else
                {
                    outputLabel.Text = "Player not found.";
                }
            }
        }

        private void NameTxt_TextChanged(object sender, EventArgs e)
        {
            
        }
        
        private void YearCmboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }
        
    }

}
    
