using CommonBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeMedium
{
    public class MinCoinChallenge : ICommonFunc
    {
        public object ExecuteCommand(object obj)
        {
            var coinParam = (CoinParam)obj;
            return CoinChange(coinParam.Coins, coinParam.Amount);
        }

        public string GetFuncDescription()
        {
            return CommonString.MinCoinChallengeDesc;
        }

        public string GetFuncTitle()
        {
            return CommonString.MinCoinChallenge;
        }

        public object GetUI()
        {
            return null;
        }

        public int CoinChange(int[] coins, int amount)
        {
            int[] dpAmount = new int[amount + 1];
            dpAmount[0] = 0;

            for (int i = 1; i < dpAmount.Length; i++)
            {
                var amountSet = false;
                dpAmount[i] = Int32.MaxValue;
                for (int j = 0; j < coins.Length; j++)
                {
                    if (i >= coins[j] && dpAmount[i - coins[j]] >= 0)
                    {
                        dpAmount[i] = Math.Min(dpAmount[i], 1 + dpAmount[i - coins[j]]);
                        amountSet = true;
                    }
                }
                dpAmount[i] = !amountSet ? -1 : dpAmount[i];
            }
            return dpAmount[amount];
        }

        public int CoinChange2(int[] coins, int amount)
        {
            int[] dpAmount = new int[amount + 1];
            dpAmount[0] = 0;

            //  0   1   2   3   4   5   6   7   8   9   10  11
            //  0   1

            //  0   1   2
            //  0   1   1

            //  0   1   1   3
            //  0   1   1   2

            //  0   1   1   2   4
            //  0   1   1   2   2

            //  0   1   1   2   2   3
            //  0   1   1   2   2   3
            //  0   1   1   2   2   1
            for (int currentAmout = 1; currentAmout <= amount; ++currentAmout)
            {
                dpAmount[currentAmout] = int.MaxValue;
                for (int coinIndex = 0; coinIndex < coins.Length; ++coinIndex)
                {
                    bool isHasSolution = false;
                    int coin = coins[coinIndex];
                    if (coin > currentAmout)
                    {
                        break;
                    }

                    else if (coin <= currentAmout)
                    {
                        int value1 = dpAmount[currentAmout - coin] + 1;
                        int value2 = dpAmount[currentAmout];
                        dpAmount[currentAmout] = Math.Min(value1, value2);
                        isHasSolution = true;
                    }

                    if (false == isHasSolution)
                        break;
                }
            }

            return dpAmount[amount];
        }

        public class CoinParam
        {
            public int[] Coins;
            public int Amount;
        }
    }
}
