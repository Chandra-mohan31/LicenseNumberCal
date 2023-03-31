using System;

namespace LicenseProcessingTime
{
    public class Program
    {
        public static int CalculateTimeForLicenseProcessing(string your_name,int agents_available,string people_arrived_for_license)
        {
            int resultTime = 0;
            List<string> peopleList = people_arrived_for_license.Split(" ").ToList();
            peopleList.Add(your_name);
            peopleList.Sort();
            List<string> peopleListGrouped = new List<string>();
            for(int j=0;j<peopleList.Count;j++)
            {
                string grp = "";
                grp += peopleList[j] + " ";
                int a = 1;
                while(j + a < peopleList.Count && a < agents_available)
                {
                    grp += peopleList[j + a] + " ";
                    a++;
                    j++;
                }
                peopleListGrouped.Add(grp);
                
                

            }
            foreach (var item in peopleListGrouped)
            {
                if (item.Contains(your_name))
                {
                    resultTime += 20;
                    break;
                }
                else
                {
                    resultTime += 20;
                }
            }
            Console.WriteLine(resultTime);
            return resultTime;
        }
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            CalculateTimeForLicenseProcessing("Eric", 2, "Adam Caroline Rebecca Frank");
            CalculateTimeForLicenseProcessing("Zebediah", 1, "Bob Jim Becky Pat");
            CalculateTimeForLicenseProcessing("Aaron", 3, "Jane Max Olivia Sam");
        }
    }
}