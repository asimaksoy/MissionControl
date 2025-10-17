using MissionControl.Domain;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MissionControl.Data
{
    public static class Repository
    {
        public static string filePath = "../../Works.txt";
        public static string[,] allDataArray;

        public static string[,] LoadAllDataFromFile(string filePath)
        {
            string[] fileReadDizi = File.ReadAllLines(filePath);
            int rowCount = fileReadDizi.Length;
            int columnCount = fileReadDizi[0].Split(',').Length;
            string[,] fileData = new string[rowCount, columnCount];
            if (rowCount > 0)
            {
                for (int i = 0; i < rowCount; i++)
                {
                    string[] rowDizi = fileReadDizi[i].Split(',');

                    for (int j = 0; j < columnCount; j++)
                    {

                        fileData[i, j] = rowDizi[j];
                    }
                }
                WorkItem.WorkItemCount = Convert.ToInt32(fileData[fileData.GetLength(0) - 1, 0]);
            }
            allDataArray = fileData;
            return allDataArray;
        }

        public static void SaveAllDataToFile(bool isAppend)
        {
            string[] rows = new string[allDataArray.GetLength(0)];
            for (int i = 0; i < allDataArray.GetLength(0); i++)
            {
                for (int j = 0; j < allDataArray.GetLength(1); j++)
                {
                    rows[i] += allDataArray[i, j].ToString();
                    if (j < (allDataArray.GetLength(1) - 1))
                    {
                        rows[i] += ",";
                    }
                }
            }
            if (!isAppend)
            {
                File.Delete(filePath);
            }
            File.AppendAllLines(filePath, rows);
        }



    }
}
