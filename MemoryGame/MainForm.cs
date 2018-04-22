using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoryGame
{
    public partial class MainForm : Form
    {
        private Game gm = new Game();
        private int uncoveredCardsCounter = 0;
        private object oldSender;
        private int cardsFound = 0;
        private bool playersTurn = true;
        private Random rnd;
        private List<Button> buttonHistory;
        private Button[] buttons;
        private Button lastButton;
        private Button secondToLastButton;
        private int playersScore;
        private int computersScore;

        public MainForm()
        {
            InitializeComponent();
            InitializeGUI();
        }

        private void InitializeGUI()
        {
            button1.BackgroundImage = null;
            button2.BackgroundImage = null;
            button3.BackgroundImage = null;
            button4.BackgroundImage = null;
            button5.BackgroundImage = null;
            button6.BackgroundImage = null;
            button7.BackgroundImage = null;
            button8.BackgroundImage = null;
            button9.BackgroundImage = null;
            button10.BackgroundImage = null;
            button11.BackgroundImage = null;
            button12.BackgroundImage = null;
            button13.BackgroundImage = null;
            button14.BackgroundImage = null;
            button15.BackgroundImage = null;
            button16.BackgroundImage = null;
            button17.BackgroundImage = null;
            button18.BackgroundImage = null;
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            button10.Enabled = true;
            button11.Enabled = true;
            button12.Enabled = true;
            button13.Enabled = true;
            button14.Enabled = true;
            button15.Enabled = true;
            button16.Enabled = true;
            button17.Enabled = true;
            button18.Enabled = true;
            gm.Shuffle();
            uncoveredCardsCounter = 0;
            cardsFound = 0;
            buttonHistory = new List<Button>();
            rnd = new Random();
            playersTurn = true;
            lastButton = null;
            secondToLastButton = null;
            playersScore = 0;
            computersScore = 0;
            label2.Text = "Computer's score: " + computersScore.ToString();
            label1.Text = "Player's score: " + playersScore.ToString();
            buttons = new Button[] {button1, button2, button3, button4, button5, button6, button7, button8, button9,
            button10, button11, button12, button13, button14, button15, button16, button17, button18};
        }
       
      private void button6_Click(object sender, EventArgs e)
      {
          TurnCard(button6, 5, sender);
      }

       private int ReturnNumberFromOldCard()
      {
           int number = 0;
           if (oldSender == button1)
           {
               number = gm.CardArray[0];
           } else if (oldSender == button2)
           {
               number = gm.CardArray[1];
           }
           else if (oldSender == button3)
           {
               number = gm.CardArray[2];
           }
           else if (oldSender == button4)
           {
               number = gm.CardArray[3];
           }
           else if (oldSender == button5)
           {
               number = gm.CardArray[4];
           }
           else if (oldSender == button6)
           {
               number = gm.CardArray[5];
           } else if (oldSender == button7)
           {
               number = gm.CardArray[6];
           } else if (oldSender == button8)
           {
               number = gm.CardArray[7];
           }
           else if (oldSender == button9)
           {
               number = gm.CardArray[8];
           }
           else if (oldSender == button10)
           {
               number = gm.CardArray[9];
           }
           else if (oldSender == button11)
           {
               number = gm.CardArray[10];
           }
           else if (oldSender == button12)
           {
               number = gm.CardArray[11];
           }
           else if (oldSender == button13)
           {
               number = gm.CardArray[12];
           }
           else if (oldSender == button14)
           {
               number = gm.CardArray[13];
           }
           else if (oldSender == button15)
           {
               number = gm.CardArray[14];
           }
           else if (oldSender == button16)
           {
               number = gm.CardArray[15];
           }
           else if (oldSender == button17)
           {
               number = gm.CardArray[16];
           }
           else if (oldSender == button18)
           {
               number = gm.CardArray[17];
           }

           return number;
      }

        private bool CheckIfSameCards(int num1, int num2)
       {
           bool same = false;
           if (num1 == num2)
               same = true;
           else
               same = false;
           return same;
       }

      private void button1_Click(object sender, EventArgs e)
      {
          TurnCard(button1, 0, sender);
      }

      private void button2_Click(object sender, EventArgs e)
      {
          TurnCard(button2, 1, sender);
      }

      private void button3_Click(object sender, EventArgs e)
      {
          TurnCard(button3, 2, sender);
      }

      private void button4_Click(object sender, EventArgs e)
      {
          TurnCard(button4, 3, sender);
      }

      

       private void button5_Click(object sender, EventArgs e)
       {
           TurnCard(button5, 4, sender);          
       }

       private void ShowImage(Button button, int number)
       {
           switch (number)
           {
               case 0:
                   button.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.monkey_uff));
                   button.BackgroundImageLayout = ImageLayout.Center;
                   break;
               case 1:
                   button.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.buttonMastermindViolet));
                   button.BackgroundImageLayout = ImageLayout.Zoom;
                   break;
               case 2:
                   button.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.buttonMastermindGreen));
                   button.BackgroundImageLayout = ImageLayout.Zoom;
                   break;
               case 3:
                   button.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Chikorita_full_1428419));
                   button.BackgroundImageLayout = ImageLayout.Zoom;
                   break;
               case 4:
                   button.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.buttonMastermindYellow));
                   button.BackgroundImageLayout = ImageLayout.Zoom;
                   break;
               case 5:
                   button.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.buttonMastermindBlack));
                   button.BackgroundImageLayout = ImageLayout.Zoom;
                   break;
               case 6:
                   button.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.buttonMastermindOrange));
                   button.BackgroundImageLayout = ImageLayout.Zoom;
                   break;
               case 7:
                   button.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.buttonMastermindBlue));
                   button.BackgroundImageLayout = ImageLayout.Zoom;
                   break;
               case 8:
                   button.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.snake));
                   button.BackgroundImageLayout = ImageLayout.Zoom;
                   break;
           }
       }

       private void button7_Click(object sender, EventArgs e)
       {
           TurnCard(button7, 6, sender);
       }

       private void button8_Click(object sender, EventArgs e)
       {
           TurnCard(button8, 7, sender);
       }

       private void button9_Click(object sender, EventArgs e)
       {
           TurnCard(button9, 8, sender);
       }

       private void button10_Click(object sender, EventArgs e)
       {
           TurnCard(button10, 9, sender);
       }

       private void button11_Click(object sender, EventArgs e)
       {
           TurnCard(button11, 10, sender);
       }

       private void button12_Click(object sender, EventArgs e)
       {
           TurnCard(button12, 11, sender);
       }

       private void button13_Click(object sender, EventArgs e)
       {
           TurnCard(button13, 12, sender);
       }

       private void button14_Click(object sender, EventArgs e)
       {
           TurnCard(button14, 13, sender);
       }

       private void button15_Click(object sender, EventArgs e)
       {
           TurnCard(button15, 14, sender);
       }

       private void button16_Click(object sender, EventArgs e)
       {
           TurnCard(button16, 15, sender);
       }

       private void button17_Click(object sender, EventArgs e)
       {
           TurnCard(button17, 16, sender);
       }

       private void button18_Click(object sender, EventArgs e)
       {
           TurnCard(button18, 17, sender);
       }

        private void TurnCard(Button button, int cardInArray, object sender)
       {
           if (playersTurn)
           {
               if (uncoveredCardsCounter == 1 || uncoveredCardsCounter == 0) //if there is only one or 0 cards uncovered
               {
                   ShowImage(button, gm.CardArray[cardInArray]);
                   if (!buttonHistory.Contains(button))
                       buttonHistory.Add(button);
               }
               if (uncoveredCardsCounter == 0 && oldSender != sender)
               {
                   uncoveredCardsCounter++;
                   oldSender = sender;
               }
               else if (uncoveredCardsCounter == 1 && oldSender != sender)
               {
                   uncoveredCardsCounter++;
                   playersTurn = false;
                   if (CheckIfSameCards(gm.CardArray[cardInArray], ReturnNumberFromOldCard()))
                   {
                       uncoveredCardsCounter = 0;
                       button.Enabled = false;
                       ((Button)oldSender).Enabled = false;
                       cardsFound += 2;
                       playersScore++;
                       label1.Text = "Player's score: " + playersScore.ToString();
                   }
                   else
                   {
                       DateTime now = DateTime.Now;
                       do
                       {
                           Application.DoEvents();

                       } while (now.AddSeconds(1) > DateTime.Now);
                       uncoveredCardsCounter = 0;
                       button.BackgroundImage = null;
                       ((Button)oldSender).BackgroundImage = null;
                   }
                   oldSender = sender;
                   if (cardsFound == 18)
                   {
                       DialogResult dialogResult = System.Windows.Forms.DialogResult.Yes;

                       if (playersScore > computersScore)
                           dialogResult = MessageBox.Show("Congratulations, you win! Your score: " + playersScore + " Computer's score: " + computersScore + " Play again?", "You win", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                       else if (playersScore < computersScore)
                           dialogResult = MessageBox.Show("The computer wins! Your score: " + playersScore + " Computer's score: " + computersScore + " Play again?", "You lose", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                       else
                           dialogResult = MessageBox.Show("Draw! Your score: " + playersScore + " Computer's score: " + computersScore + " Play again?", "Draw", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                       if (dialogResult == System.Windows.Forms.DialogResult.Yes)
                       {
                           InitializeGUI();
                       }
                       else
                       {
                           Application.Exit();
                       }
                   }
               }
           } 
            if (!playersTurn)
            {
                DateTime now = DateTime.Now;
                do
                {
                    Application.DoEvents();

                } while (now.AddSeconds(1) > DateTime.Now);

                int check = 0;

                for (int i = 0; i < buttonHistory.Count; i++)
                {
                    for (int j = 0; j < buttonHistory.Count; j++)
                    {
                        int k = 0;
                        int l = 0;
                        if (buttonHistory[i].Name.Length == 8)
                            k = int.Parse(buttonHistory[i].Name.Substring(buttonHistory[i].Name.Length - 2, 2));
                        else if (buttonHistory[i].Name.Length == 7)
                            k = int.Parse(buttonHistory[i].Name.Substring(buttonHistory[i].Name.Length - 1, 1));
                        if (buttonHistory[j].Name.Length == 8)
                            l = int.Parse(buttonHistory[j].Name.Substring(buttonHistory[j].Name.Length - 2, 2));
                        else if (buttonHistory[j].Name.Length == 7)
                            l = int.Parse(buttonHistory[j].Name.Substring(buttonHistory[j].Name.Length - 1, 1));
                        if (gm.CardArray[l - 1] == gm.CardArray[k - 1] && i != j && buttonHistory[i] != null && buttonHistory[j] != null && buttonHistory[i].Enabled && buttonHistory[j].Enabled)
                        {
                            
                            Button b1 = buttonHistory[i];
                            Button b2 = buttonHistory[j];
                            if (b1.Enabled && b2.Enabled)
                            {
                                check++;
                                if (check == 1)
                                {

                                    ShowImage(b1, gm.CardArray[k - 1]);
                                    DateTime now2 = DateTime.Now;
                                    do
                                    {
                                        Application.DoEvents();

                                    } while (now2.AddSeconds(1) > DateTime.Now);
                                    ShowImage(b2, gm.CardArray[l - 1]);
                                    cardsFound += 2;
                                    computersScore++;
                                    label2.Text = "Computer's score: " + computersScore.ToString();
                                    b1.Enabled = false;
                                    b2.Enabled = false;
                                    break;
                                }
                            }
                        }
                    }
                }

                if (check == 0)
                {
                   int cardToTurn = rnd.Next(1, 19);
                restart:
                   foreach (Button b in buttons)
                   {
                       if (b.Name == "button" + cardToTurn.ToString())
                       {
                           if (b.Enabled)
                           {
                               ShowImage(b, gm.CardArray[cardToTurn - 1]);
                               secondToLastButton = b;
                               if (!buttonHistory.Contains(b))
                                   buttonHistory.Add(b);
                               break;
                           }
                           else
                           {
                               cardToTurn = rnd.Next(1, 19);
                               goto restart;
                           }
                        }
                   }
                    DateTime now2 = DateTime.Now;
                    do
                    {
                        Application.DoEvents();

                    } while (now2.AddSeconds(1) > DateTime.Now);
                    int cardToTurn1 = cardToTurn;
                    while (cardToTurn1 == cardToTurn)
                        cardToTurn1 = rnd.Next(1, 19);
                    int check2 = 0;
                    for (int i = 0; i < buttonHistory.Count; i++)
                    {
                        int k = 0;
                        if (buttonHistory[i].Name.Length == 8)
                            k = int.Parse(buttonHistory[i].Name.Substring(buttonHistory[i].Name.Length - 2, 2));
                        else if (buttonHistory[i].Name.Length == 7)
                            k = int.Parse(buttonHistory[i].Name.Substring(buttonHistory[i].Name.Length - 1, 1));

                        Button previousButton = null;

                        int l = 0;

                        foreach (Button b in buttons)
                        {
                            if (b.BackgroundImage != null && b.Enabled)
                            {
                                previousButton = b;
                                if (previousButton.Name.Length == 8)
                                    l = int.Parse(previousButton.Name.Substring(previousButton.Name.Length - 2, 2));
                                else if (previousButton.Name.Length == 7)
                                    l = int.Parse(previousButton.Name.Substring(previousButton.Name.Length - 1, 1));
                            }
                        }
                        if (gm.CardArray[k - 1] == gm.CardArray[l - 1] && previousButton != buttonHistory[i])
                        {
                            if (buttonHistory[i].Enabled && previousButton.Enabled)
                            {
                                check2 = 1;
                                ShowImage(buttonHistory[i], gm.CardArray[cardToTurn - 1]);
                                lastButton = buttonHistory[i];
                                break;
                            }
                        }
                    }
                    if (check2 == 0)
                    {
                    restart1:
                        foreach (Button b in buttons)
                        {
                            if (b.Name == "button" + cardToTurn1.ToString())
                            {
                                if (b.Enabled)
                                {
                                    ShowImage(b, gm.CardArray[cardToTurn1 - 1]);
                                    lastButton = b;
                                    if (!buttonHistory.Contains(b))
                                        buttonHistory.Add(b);
                                    break;
                                }
                                else
                                {
                                    do
                                    {
                                        cardToTurn1 = rnd.Next(1, 19);
                                    } while (cardToTurn1 == cardToTurn);
                                    goto restart1;
                                }
                            }
                        }
                    }
                    DateTime now3 = DateTime.Now;
                    do
                    {
                        Application.DoEvents();

                    } while (now3.AddSeconds(1) > DateTime.Now);

                    int m = 0;
                    int n = 0;
                    if (lastButton.Name.Length == 8)
                        m = int.Parse(lastButton.Name.Substring(lastButton.Name.Length - 2, 2));
                    else if (lastButton.Name.Length == 7)
                        m = int.Parse(lastButton.Name.Substring(lastButton.Name.Length - 1, 1));

                    if (secondToLastButton.Name.Length == 8)
                        n = int.Parse(secondToLastButton.Name.Substring(secondToLastButton.Name.Length - 2, 2));
                    else if (secondToLastButton.Name.Length == 7)
                        n = int.Parse(secondToLastButton.Name.Substring(secondToLastButton.Name.Length - 1, 1));
                    if (gm.CardArray[m - 1] == gm.CardArray[n - 1])
                    {
                        secondToLastButton.Enabled = false;
                        lastButton.Enabled = false;
                        computersScore++;
                        label2.Text = "Computer's score: " + computersScore.ToString();
                        cardsFound += 2;
                    }
                    else
                    {
                        secondToLastButton.BackgroundImage = null;
                        lastButton.BackgroundImage = null;
                    }
                }
                if (cardsFound == 18)
                {
                    DialogResult dialogResult = System.Windows.Forms.DialogResult.Yes;

                    if (playersScore > computersScore)
                        dialogResult = MessageBox.Show("Congratulations, you win! Your score: " + playersScore + " Computer's score: " + computersScore + " Play again?", "You win", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    else if (playersScore < computersScore)
                        dialogResult = MessageBox.Show("The computer wins! Your score: " + playersScore + " Computer's score: " + computersScore + " Play again?", "You lose", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    else
                        dialogResult = MessageBox.Show("Draw! Your score: " + playersScore + " Computer's score: " + computersScore + " Play again?", "Draw", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (dialogResult == System.Windows.Forms.DialogResult.Yes)
                    {
                        InitializeGUI();
                    }
                    else
                    {
                        Application.Exit();
                    }
                }
                playersTurn = true;
            }
       }

    }
}
