using MiscUtil;
using System.Collections.Generic;
using System.Windows.Controls;

namespace WindowStoreClone.UserControls.AppDetailsTabContent
{

    public partial class Areview : UserControl
    {
        List<string> Names;
        public Areview()
        {
            InitializeComponent();
            Names = new List<string>() { "Viktoria", "Mike", "Zoltan", "Maria", "Daniel", "Emma" };
            string reviewerName = Names[StaticRandom.Next(Names.Count)];
            ReviewerNameLabel.Content = reviewerName;
            AvatarLabel.Content = reviewerName[0];
            NumOfStarsLabel.Content = GetRandomNumOfStars();
            ReivewTitle.Content = GetReviewTitleBasedOnStars(NumOfStarsLabel.Content.ToString());
        }
        private string GetRandomNumOfStars()
        {
            string content = "";
            for (int i = 0; i < StaticRandom.Next(1, 6); i++)
            {
                content += "★";
            }
            return content;
        }
        private string GetReviewTitleBasedOnStars(string inStars)
        {
            string retStr = "";
            if (inStars.Length >= 4)
            {
                retStr = "This app is really awesome";
            }
            else if (inStars.Length == 3)
            {
                retStr = "This app is all right";
            }
            else
            {
                retStr = "This app is poor";
            }
            return retStr;
        }
    }
}
