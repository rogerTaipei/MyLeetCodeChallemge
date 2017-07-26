using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LeetCodeChallenge
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        LeetCodeEasy.Entry ChallengeEasy;
        public MainWindow()
        {
            InitializeComponent();

            ChallengeEasy = new LeetCodeEasy.Entry();

            List<string> titles = ChallengeEasy.GetAllFuncTitle();


            // you might transfer the return type default by yourself
            //int ret = (int)ChallengeEasy.ExecuteCommand(1234, LeetCodeEasy.FunctionIndex.IntegerReverse);
            //bool isPalindrome = (bool)ChallengeEasy.ExecuteCommand(34143, LeetCodeEasy.FunctionIndex.PalindromeNumber);
            
            //MMMCMXCIX = 3999
            int r = (int)ChallengeEasy.ExecuteCommand("DCXXI", LeetCodeEasy.FunctionIndex.RomanToInteger);
        }
    }
}
