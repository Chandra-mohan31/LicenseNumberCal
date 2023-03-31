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


        public static void OptimisedCalculateTimeForLicenseProcessing(string your_name, int agents_available, string people_arrived_for_license)
        {
            List<string> peopleList = people_arrived_for_license.Split(" ").ToList();
            peopleList.Add(your_name);
            peopleList.Sort();
            int resultTime = 0;

            int i = 0;
            bool found = false;
            
            while (i < peopleList.Count && found == false)
            {
                
                //Console.WriteLine("Group :");
                int a = agents_available;
                //Console.Write(peopleList[i]);
                if (peopleList[i] == your_name)
                {
                    found = true;
                }
                resultTime += 20;
                i++;
                a--;




                while (a > 0 && i < peopleList.Count && found == false)
                {
                    //Console.Write($" {peopleList[i]}");
                    if (peopleList[i] == your_name)
                    {
                        resultTime += 20;
                        found = true;
                    }
                    a -= 1;
                    i += 1;
                }
                
               
            }
            Console.WriteLine(resultTime);
        }
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            OptimisedCalculateTimeForLicenseProcessing("Eric", 2, "Adam Caroline Rebecca Frank");
            OptimisedCalculateTimeForLicenseProcessing("Zebediah", 1, "Bob Jim Becky Pat");
            OptimisedCalculateTimeForLicenseProcessing("Aaron", 3, "Jane Max Olivia Sam");
        }
    }
}