using Microsoft.Office.Interop.Excel;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Champs
{
    public class PlayerDataYear
    {
        //RANK,NAME,TEAM,POS,AGE,GP,MPG,USGp,Top,FTA,FTp,TwPA,TwPp,ThPA,ThPp,eFGp,TSp,PPG,RPG,APG,SPG,BPG,TPG,VI,ORTG,DRTG

        private string year { get; }
        private string csvFilePath;
       
        public PlayerDataYear(string year, string csvFilePath)        {
            this.year=year;
            this.csvFilePath=csvFilePath;
        }
        
        public List<string[]> LoadPlayerData()
        {
            List<string[]> playerData = new List<string[]>();
            try
            {
                using (var reader = new StreamReader(csvFilePath))
                {
                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();
                        string[] data = line.Split(',');

                        playerData.Add(data);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return playerData;
        }

        internal string GetYear()
        {
            throw new NotImplementedException();
        }
    }
}
