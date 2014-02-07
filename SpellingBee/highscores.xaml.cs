using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace SpellingBee
{
    public partial class highscores : PhoneApplicationPage
    {
        string strCodeTiers;
        public highscores()
        {
            InitializeComponent();

            sound_highscores.Play();
            



        }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
             strCodeTiers = string.Empty;

            if (NavigationContext.QueryString.TryGetValue("score", out strCodeTiers))
            {
                scoredisplayer.Text = "SCORE: " + strCodeTiers;
            }
        }

        private void submitScore(object sender, RoutedEventArgs e)
        {
            //webBrowserDisplay.NavigateToString("http://spellbee.t15.org/highscores.php?name="+playerName.Text+"&score="+strCodeTiers);
            webBrowserDisplay.Navigate(new Uri("http://spellbee.t15.org/highscores.php?name=" + playerName.Text + "&score=" + strCodeTiers, UriKind.Absolute));

            webBrowserDisplay.Visibility = Visibility.Visible;
           
                playerName.Text = "";
                strCodeTiers = null;

            
        }

        

        private void playerName_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            playerName.Text = "";
        }
        
       

    }


}