using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UC8
{
    public class UC8EMP
    {
    
            public const int IS_PART_TIME = 1;
            public const int IS_FULL_TIME = 2;

            public static int computeEmpWage(string company,int empRateperHour,int numOfWorkingDays,int maxHoursOerMonth)
            {
                //Variables
                int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;
                //Computation
                while (totalEmpHrs <= maxHoursOerMonth && totalWorkingDays < numOfWorkingDays)
                {
                    totalWorkingDays++;
                    Random random = new Random();
                    int empcheck = random.Next(0, 3);
                    switch (empcheck)
                    {
                        case IS_PART_TIME:
                            empHrs = 4;
                            break;
                        case IS_FULL_TIME:
                            empHrs = 8;
                            break;
                        default:
                            empHrs = 0;
                            break;
                    }
                    totalEmpHrs += empHrs;
                    Console.WriteLine("DAY#:" + totalWorkingDays + " Emp Hrs" + empHrs);

                }
                int totalEmpWage = totalEmpHrs * empRateperHour;
                Console.WriteLine("Total Emp Wage : " + totalEmpWage);
                return totalEmpWage;
            }


      
    }
}

