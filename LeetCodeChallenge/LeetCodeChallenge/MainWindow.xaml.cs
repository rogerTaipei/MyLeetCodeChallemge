using CommonBase;
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
        LeetCodeMedium.Entry ChallengeMedium;
        public MainWindow()
        {
            InitializeComponent();

            ChallengeEasy = new LeetCodeEasy.Entry();
            ChallengeMedium = new LeetCodeMedium.Entry();

            List<string> titles = ChallengeEasy.GetAllFuncTitle();

            InitUIElements(this.EasyList, ChallengeEasy);
            InitUIElements(this.MediumList, ChallengeMedium);

            // you might transfer the return type default by yourself
            //int ret = (int)ChallengeEasy.ExecuteCommand(1234, LeetCodeEasy.FunctionIndex.IntegerReverse);
            //bool isPalindrome = (bool)ChallengeEasy.ExecuteCommand(34143, LeetCodeEasy.FunctionIndex.PalindromeNumber);

            //MMMCMXCIX = 3999
            //int r = (int)ChallengeEasy.ExecuteCommand("DCXXI", LeetCodeEasy.FunctionIndex.RomanToInteger);
            //bool ret = (bool)ChallengeEasy.ExecuteCommand("()", LeetCodeEasy.FunctionIndex.ValidParentheses);

            //object ret2 = ChallengeMedium.ExecuteCommand(null, LeetCodeMedium.FunctionIndex.RemoveNthFromEnd);

            //object ret3 = ChallengeEasy.ExecuteCommand(null, LeetCodeEasy.FunctionIndex.MergeTwoSortedArray);
        }

        private void InitUIElements(UIElement _element, CommonBase.EntryBase _targetObj)
        {
            StackPanel tempPanel = _element as StackPanel;

            var fTable = _targetObj.GetAllFunTable();
            var fTitles = _targetObj.GetAllFuncTitle().ToArray();
            var fDescriptions = _targetObj.GetAllFuncDesc().ToArray();

            for (int i = 0;  i < fTable.Count; ++i)
            {
                ArgClass arg = new ArgClass()
                {
                    Function = fTable[i],
                    Title = fTitles[i],
                    Description = fDescriptions[i]
                };
                Button temp = new Button();
                temp.Content = fTitles[i];
                tempPanel.Children.Add(temp);
                temp.Click += DefaultBtnClick;
            }
        }

        protected void DefaultBtnClick(object sender, EventArgs e)
        {
            //TODO, need customize a new button with my own args
        }
    }

    public class ArgClass : EventArgs
    {
        public ICommonFunc Function;
        public string Title;
        public string Description;
    }
}
