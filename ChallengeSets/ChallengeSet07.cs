using System;
using System.Collections.Generic;

namespace ChallengeSets
{
    public class ChallengeSet07
    {
        public int CountOfBusinessesWithNegativeNetProfit(List<Business> businesses)
        {
            if (businesses.Count == 0)
            {
                return 0;
            }
            if (businesses == null)
            {
                return 0;
            }
            int count = 0;
            


            for (int i = 0; i < businesses.Count; i++)
            {
                Business business = businesses[i];
                if (business.IsNotProfitable())
                {
                    count++;
                }
                if (business.TotalRevenue == null || business.TotalExpenses == null)
                {
                    return 0;
                }
               
                // if the total revenue minus expenses is negative
                //add one to the count.
            }
            return count;
        }

        public string GetCommaSeparatedListOfProfitableBusinesses(List<Business> businesses)
        {
            string names = "";
            int i = 0;

            foreach(var business in businesses)
            {
                
                if (business.IsProfitable())
                {
                    if (businesses.Count == 1)
                    {
                        names += business.Name.TrimEnd();
                    }
                    else if (i == businesses.Count - 1)
                    {
                        names += business.Name;
                    }
                    else
                    {
                        names += business.Name + ",";
                    }
                }
                    i++;
            }
            //if the business is profitable
            //add name to list


            return names.Trim(','); 



        }

        public string GetNameOfHighestParentCompany(Business business)
        {
            // If there is Company A, whose parent is Company B, whose parent is Company C, then given Company A return Company C
            throw new NotImplementedException();
        }

        public enum TicTacToeResult { X, O, Draw }
        public TicTacToeResult GetTicTacToeWinner(char[,] finalBoard)
        {
            throw new NotImplementedException();
        }

        public bool EachArrayInJaggedArrayContainsTargetNumber(int[][] numbers, int targetNumber)
        {
            throw new NotImplementedException();
        }
    }
}
