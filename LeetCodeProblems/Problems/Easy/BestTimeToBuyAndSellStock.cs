﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Problems.Easy
{
    /*
     * You are given an array prices where prices[i] is the price of a given stock on the ith day.
     * You want to maximize your profit by choosing a single day to buy one stock and choosing a different day in the future to sell that stock.
     * Return the maximum profit you can achieve from this transaction.
     * If you cannot achieve any profit, return 0.
     */
    internal class BestTimeToBuyAndSellStock
    {
        public static int SolveProblem(int[] prices)
        {
            int minPrice = prices[0];
            int maxPrice = 0;

            for (int i = 0; i < prices.Length; i++)
            {
                if (prices[i] < minPrice)
                {
                    minPrice = prices[i];
                }

                if (prices[i] - minPrice > maxPrice)
                {
                    maxPrice = prices[i] - minPrice;
                }
            }

            return maxPrice;
        }
    }
}
