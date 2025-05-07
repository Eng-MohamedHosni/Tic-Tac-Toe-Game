using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tic_Tac_Toe.Properties;

namespace Tic_Tac_Toe
{
    public partial class Form1 : Form
    {
        enum enWinner {  Player1,Player2,Draw};
        enum enPlayer { Player1, Player2 };

       
        enPlayer PlayerTurn = enPlayer.Player1;
        short PlayRounds = 1;
        


        public Form1()
        {
            InitializeComponent();
        }

       
        bool CheckValues(PictureBox pic1,PictureBox pic2,PictureBox pic3) 
        {
            if(pic1.Tag.ToString()!="?"&& pic1.Tag.ToString()==pic2.Tag.ToString() && pic1.Tag.ToString() ==pic3.Tag.ToString())
            {
                pic1.BackColor = Color.GreenYellow;
                pic2.BackColor = Color.GreenYellow;
                
                pic3.BackColor = Color.GreenYellow;
                
                if (pic1.Tag.ToString()=="X")
                {
                    lbWinner.Text = "Player 1";
                }
                else if(pic2.Tag.ToString()=="O") 
                {
                    lbWinner.Text = "Player 2";
                }
                
                MessageBox.Show("GameOver","",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return true;
            }
            else { return false; }
        }
        void CheckWin()
        {

            if( CheckValues(pb1,pb2,pb3)) return ;
            if( CheckValues(pb4,pb5,pb6) ) return ;
            if (CheckValues(pb7, pb8, pb9) )return;
            if( CheckValues(pb1,pb5,pb9)) return ;
            if( CheckValues(pb3,pb5,pb7)) return ;
            if( CheckValues(pb1,pb4,pb7)) return ;
            if( CheckValues(pb2,pb5,pb8)) return ;
            if( CheckValues(pb3, pb6, pb9)) return ;

            if(PlayRounds==9)
            {
                MessageBox.Show("Draw", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lbWinner.Text = "Draw";

            }

            //Check x and O
            /*bool Draw = true;
            for(int i= 0;i<8;i++)
            {
                byte XCounter=0, OCounter=0;
                int j = 0;
                for( j=0;j<3;j++)
                {
                    if (pictureBox1[i, j].Tag.ToString() == "O") OCounter++;
                    else if (pictureBox1[i, j].Tag.ToString() == "X") XCounter++;
                    else
                        Draw = false;
                    
                    
                }
                if (XCounter == 3)
                {
                    WinSequence = new PictureBox[] { pictureBox1[i, j - 3], pictureBox1[i, j - 1], pictureBox1[i, j - 2] };
                    foreach (PictureBox pb in WinSequence)
                    {
                        pb.BackColor = Color.GreenYellow;
                    }

                    return 'X';
                }
                if(OCounter == 3)
                {
                    WinSequence = new PictureBox[] { pictureBox1[i, j-3], pictureBox1[i, j - 1], pictureBox1[i, j - 2] };
                    foreach (PictureBox pb in WinSequence)
                    {
                        pb.BackColor = Color.GreenYellow;
                    }
                    return 'O';
                }
                
            }
            WinSequence= new PictureBox[] { null,null,null };
            if (Draw==true)
                return 'D';

            return 'N';*/
        }
        void GetTurn(PictureBox Pb)
        {

            if(Pb.Tag.ToString() == "X"||Pb.Tag.ToString()=="O") {
                MessageBox.Show("Wrong Choice","Note",MessageBoxButtons.OK, MessageBoxIcon.Error);
                
                return;
            }

            switch (PlayerTurn)
            {
                case enPlayer.Player1:
                    Pb.Image = Resources.X;
                    lbTurn.Text = "Player 2";
                    PlayerTurn = enPlayer.Player2;
                    Pb.Tag = "X";
                    CheckWin();
                    break;

                case enPlayer.Player2:
                    Pb.Image = Resources.O;
                    lbTurn.Text = "Player 1";
                    PlayerTurn = enPlayer.Player1;
                    Pb.Tag = "O";
                    CheckWin();
                    break;
            }
            ++PlayRounds;


            /*PictureBox[] WinSequence=new PictureBox[3];

            if(CheckWin(out WinSequence)=='X')
            {
                lbWinner.Text = "Player 1";
                MessageBox.Show("Player 1 is the Winner","Result",MessageBoxButtons.OK);
               
            }
            else if(CheckWin(out WinSequence)=='O')
            {
                lbWinner.Text = "Player 2";
                MessageBox.Show("Player 2 is the Winner","Result",  MessageBoxButtons.OK);
            }
            else if(CheckWin(out WinSequence)=='D')
            {
                lbWinner.Text = "Draw";
                MessageBox.Show("Draw", "Result", MessageBoxButtons.OK);
            }
            else
            {
                lbWinner.Text = "Game in Progress";
            }*/
           

        }
        
        
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Color White = Color.White;
            Pen Pen = new Pen(White);

            Pen.Width = 13;
            Pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            Pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
            //vertical lines
           e.Graphics.DrawLine(Pen, 480, 80, 480, 450);
           e.Graphics.DrawLine(Pen, 650, 80, 650, 450);
            // Horizontal lines
            e.Graphics.DrawLine(Pen,350, 200, 780, 200);
            e.Graphics.DrawLine(Pen, 350, 337, 780, 337);

        }

      
        private void pb_Click(object sender, EventArgs e)
        {
            GetTurn((PictureBox) sender);
        }
       

        private void Form1_Load(object sender, EventArgs e)
        {
            lbTurn.Text = "Player1";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PictureBox[] UsedPictureBoxes = { pb1, pb2,pb3,pb4,pb5,pb6,pb7,pb8,pb9 };
            foreach(PictureBox pb in UsedPictureBoxes)
            {
                pb.Image = Resources.question_mark_96;
                pb.BackColor = Color.Transparent;
                pb.Tag = "?";
            }
            
            lbTurn.Text = "Player 1";
            PlayRounds = 1;
        }
    }
}
