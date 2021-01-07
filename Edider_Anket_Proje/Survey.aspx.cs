using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Edider_Anket_Proje
{
    public partial class Survey : System.Web.UI.Page
    {
        static string display = "Yanıtlarınız başarıyla kaydedildi. Ankete katıldığınız için teşekkür ederiz!";
        static string warning = "Lütfen tüm soruları cevapladığınızdan emin olun";
        static string sent = "Zaten Anket Yanıtı Gönderdiniz, Sayfayı Kapatabilirsiniz.";

        static string[] answer1 = new string[6];
        static string[] answer2 = new string[6];
        static string[] answer3 = new string[6];
        static string[,] answer4 = new string[6,6];
        static string[] answer5 = new string[6];
        static string[] answer6 = new string[6];
        static string[,] answer7 = new string[6, 6];
        static string[] answer8 = new string[7];
        static string[,] answer9 = new string[6, 7];

        static bool flag1, flag3, flag5, flag6, flag8;

        static bool flag = false;

        static bool confirm = true;

       
           

        protected void Page_Load(object sender, EventArgs e)
        {

            if (flag == false) {   
            
                Q4_Panel1.Visible = Q4_Panel2.Visible = Q4_Panel3.Visible = Q4_Panel4.Visible = Q4_Panel5.Visible = Q4_Panel6.Visible= false;
                Q7_Panel1.Visible = Q7_Panel2.Visible = Q7_Panel3.Visible = Q7_Panel4.Visible = Q7_Panel5.Visible = Q7_Panel6.Visible = false;
                Q9_Panel1.Visible = Q9_Panel2.Visible = Q9_Panel3.Visible = Q9_Panel4.Visible = Q9_Panel5.Visible = Q9_Panel6.Visible = false;

                flag = true;
            }

        }



        // !! QUESTION ONE BEGINS !! //
        protected void Q1_Button1_Click(object sender, EventArgs e)
        {
            Q1_Button1.BackColor = Color.LemonChiffon;
            Q4_Panel1.Visible = true;
            Q7_Panel1.Visible = true;
            answer1[0] = Q1_Button1.Text;
            flag1 = true;
        }


        protected void Q1_Button2_Click(object sender, EventArgs e)
        {
            Q1_Button2.BackColor = Color.LemonChiffon;
            Q7_Panel2.Visible = true;
            Q4_Panel2.Visible = true;
            answer1[1] = Q1_Button2.Text;
            flag1 = true;
        }



        protected void Q1_Button3_Click(object sender, EventArgs e)
        {
            Q1_Button3.BackColor = Color.LemonChiffon;
            Q4_Panel3.Visible =  Q7_Panel3.Visible = true;
            answer1[2] = Q1_Button3.Text;
            flag1 = true;
        }



        protected void Q1_Button4_Click(object sender, EventArgs e)
        {
            Q1_Button4.BackColor = Color.LemonChiffon;
            Q4_Panel4.Visible = Q7_Panel4.Visible = true;
            answer1[3] = Q1_Button4.Text;
            flag1 = true;
        }


        protected void Q1_Button5_Click(object sender, EventArgs e)
        {
            Q1_Button5.BackColor = Color.LemonChiffon;
            Q4_Panel5.Visible = Q7_Panel5.Visible = true;
            answer1[4] = Q1_Button5.Text; flag1 = true;
        }


        protected void Q1_Button6_Click(object sender, EventArgs e)
        {
            Q1_Button6.BackColor = Color.LemonChiffon;
            Q4_Panel6.Visible = Q7_Panel6.Visible = true;
            answer1[5] = Q1_Button6.Text; flag1 = true;
        }






        // !! QUESTION ONE ENDS !! // 

        // --!!!!!!!!!!!!!!!!!!!-- //

        // !! QUESTION TWO BEGINS !! //

        protected void Q2_Selected1(object sender, EventArgs e)
        {
         
            answer2[0] = Q2_1.SelectedValue;
        }

        protected void Q2_Selected2(object sender, EventArgs e)
        {
   
            answer2[1] = Q2_2.SelectedValue;
        }


        protected void Q2_Selected3(object sender, EventArgs e)
        {
            answer2[2] = Q2_3.SelectedValue;
    
        }

        protected void Q2_Selected4(object sender, EventArgs e)
        {
            answer2[3] = Q2_4.SelectedValue;
        }

        protected void Q2_Selected5(object sender, EventArgs e)
        {
            answer2[4] = Q2_5.SelectedValue; 
        }

        protected void Q2_Selected6(object sender, EventArgs e)
        {
            answer2[5] = Q2_6.SelectedValue; 
        }


        // !! QUESTION TWO ENDS !! // 

        // --!!!!!!!!!!!!!!!!!!!-- //

        // !! QUESTION THREE BEGINS !! //


        protected void Q3_Button1_Click(object sender, EventArgs e)
        {
            answer3[0] = Q3_Button1.Text;
            Q3_Button1.BackColor = Color.LemonChiffon;
            flag3 = true;
        }

        protected void Q3_Button2_Click(object sender, EventArgs e)
        {
            answer3[1] = Q3_Button2.Text;
            Q3_Button2.BackColor = Color.LemonChiffon; flag3 = true;
        }
        protected void Q3_Button3_Click(object sender, EventArgs e)
        {
            answer3[2] = Q3_Button3.Text;
            Q3_Button3.BackColor = Color.LemonChiffon; flag3 = true;
        }
        protected void Q3_Button4_Click(object sender, EventArgs e)
        {
            answer3[3] = Q3_Button4.Text;
            Q3_Button4.BackColor = Color.LemonChiffon; flag3 = true;
        }

        protected void Q3_Button5_Click(object sender, EventArgs e)
        {
            answer3[4] = Q3_Button5.Text;
            Q3_Button5.BackColor = Color.LemonChiffon; flag3 = true;
        }

        protected void Q3_Button6_Click(object sender, EventArgs e)
        {
            answer3[5] = Q3_Button6.Text;
            Q3_Button6.BackColor = Color.LemonChiffon; flag3 = true;
        }


        // !! QUESTION THREE ENDS !! // 

        // --!!!!!!!!!!!!!!!!!!!-- //
        // !! QUESTION FOUR BEGINS  !! // 
        protected void Q4_Selected1(object sender, EventArgs e)
        {
           answer4[0,0] = Q4_1.SelectedValue;
            Q4_1.BackColor = Color.LemonChiffon;
        }

        protected void Q4_Selected2(object sender, EventArgs e)
        {
            answer4[0, 1] = Q4_2.SelectedValue; Q4_2.BackColor = Color.LemonChiffon;
        }

        protected void Q4_Selected3(object sender, EventArgs e)
        {
            answer4[0,2] = Q4_3.SelectedValue; Q4_3.BackColor = Color.LemonChiffon;
        }

        protected void Q4_Selected4(object sender, EventArgs e)
        {
            answer4[0,3] = Q4_4.SelectedValue; Q4_4.BackColor = Color.LemonChiffon;
        }

        protected void Q4_Selected5(object sender, EventArgs e)
        {
            answer4[0, 4] = Q4_5.SelectedValue; Q4_5.BackColor = Color.LemonChiffon;
        }

        protected void Q4_Selected6(object sender, EventArgs e)
        {
            answer4[0, 5] = Q4_6.SelectedValue; Q4_6.BackColor = Color.LemonChiffon;
        }
        protected void Q4_2_Selected1(object sender, EventArgs e)
        {
            answer4[1, 0] = Q4_2_1.SelectedValue; Q4_2_1.BackColor = Color.LemonChiffon;
        }

        protected void Q4_2_Selected2(object sender, EventArgs e)
        {
            answer4[1, 1] =  Q4_2_2.SelectedValue; Q4_2_2.BackColor = Color.LemonChiffon;
        }

        protected void Q4_2_Selected3(object sender, EventArgs e)
        {
            answer4[1, 2] = Q4_2_3.SelectedValue; Q4_2_3.BackColor = Color.LemonChiffon;
        }

        protected void Q4_2_Selected4(object sender, EventArgs e)
        {
            answer4[1, 3] = Q4_2_4.SelectedValue; Q4_2_4.BackColor = Color.LemonChiffon;
        }

        protected void Q4_2_Selected5(object sender, EventArgs e)
        {
            answer4[1,4] = Q4_2_5.SelectedValue;
            Q4_2_5.BackColor = Color.LemonChiffon;
        }

        protected void Q4_2_Selected6(object sender, EventArgs e)
        {
            answer4[1, 5] = Q4_2_6.SelectedValue;
            Q4_2_6.BackColor = Color.LemonChiffon;
        }

        protected void Q4_3_Selected1(object sender, EventArgs e)
        {
            answer4[2, 0] = Q4_3_1.SelectedValue;
            Q4_3_1.BackColor = Color.LemonChiffon;
        }

        protected void Q4_3_Selected2(object sender, EventArgs e)
        {
            answer4[2, 1] = Q4_3_2.SelectedValue;
            Q4_3_2.BackColor = Color.LemonChiffon;
        }

        protected void Q4_3_Selected3(object sender, EventArgs e)
        {
            answer4[2, 2] = Q4_3_3.SelectedValue;
            Q4_3_3.BackColor = Color.LemonChiffon;

        }

        protected void Q4_3_Selected4(object sender, EventArgs e)
        {
            answer4[2,3] = Q4_3_4.SelectedValue;
            Q4_3_4.BackColor = Color.LemonChiffon;
        }

        protected void Q4_3_Selected5(object sender, EventArgs e)
        {
            answer4[2, 4] = Q4_3_5.SelectedValue;
            Q4_3_5.BackColor = Color.LemonChiffon;
        }

        protected void Q4_3_Selected6(object sender, EventArgs e)
        {
            answer4[2,5] = Q4_3_6.SelectedValue;
            Q4_3_6.BackColor = Color.LemonChiffon;
        }
        protected void Q4_4_Selected1(object sender, EventArgs e)
        {
            answer4[3,0] = Q4_4_1.SelectedValue;
            Q4_4_1.BackColor = Color.LemonChiffon;
        }

        protected void Q4_4_Selected2(object sender, EventArgs e)
        {
            answer4[3, 1] = Q4_4_2.SelectedValue;
            Q4_4_2.BackColor = Color.LemonChiffon;
        }

        protected void Q4_4_Selected3(object sender, EventArgs e)
        {
            answer4[3, 2] = Q4_4_3.SelectedValue;
            Q4_4_3.BackColor = Color.LemonChiffon;
        }

        protected void Q4_4_Selected4(object sender, EventArgs e)
        {
            answer4[3, 3] = Q4_4_4.SelectedValue;
            Q4_4_4.BackColor = Color.LemonChiffon;
        }

        protected void Q4_4_Selected5(object sender, EventArgs e)
        {
            answer4[3, 4] = Q4_4_5.SelectedValue;
            Q4_4_5.BackColor = Color.LemonChiffon;
        }

        protected void Q4_4_Selected6(object sender, EventArgs e)
        {
            answer4[3, 5] = Q4_4_6.SelectedValue;
        }

        protected void Q4_5_Selected6(object sender, EventArgs e)
        {
            answer4[4, 5] = Q4_5_6.SelectedValue;
        }

        protected void Q4_5_Selected5(object sender, EventArgs e)
        {
            answer4[4, 4] = Q4_5_5.SelectedValue;
        }

        protected void Q4_5_Selected4(object sender, EventArgs e)
        {
            answer4[4, 3] = Q4_5_4.SelectedValue;
        }

        protected void Q4_5_Selected3(object sender, EventArgs e)
        {
            answer4[4, 2] = Q4_5_3.SelectedValue;
        }

        protected void Q4_5_Selected2(object sender, EventArgs e)
        {
            answer4[4, 1] = Q4_5_2.SelectedValue;
        }

        protected void Q4_5_Selected1(object sender, EventArgs e)
        {
            answer4[4, 0] = Q4_5_1.SelectedValue;
        }
        protected void Q4_6_Selected1(object sender, EventArgs e)
        {
            answer4[5,0] = Q4_6_1.SelectedValue;
        }
        protected void Q4_6_Selected2(object sender, EventArgs e)
        {
            answer4[5,1] = Q4_6_2.SelectedValue;
        }

        protected void Q4_6_Selected3(object sender, EventArgs e)
        {
            answer4[5,2] = Q4_6_3.SelectedValue;
        }

        protected void Q4_6_Selected4(object sender, EventArgs e)
        {
            answer4[5,3] = Q4_6_4.SelectedValue;
        }

        protected void Q4_6_Selected5(object sender, EventArgs e)
        {
            answer4[5,4] = Q4_6_5.SelectedValue;
        }

        protected void Q4_6_Selected6(object sender, EventArgs e)
        {
            answer4[5,5] = Q4_6_1.SelectedValue;
        }

        // !! QUESTION FOUR ENDS !! // 

        // --!!!!!!!!!!!!!!!!!!!-- //
        // !! QUESTION FIVE BEGINS  !! // 

        protected void Q5_Button1_Click(object sender, EventArgs e)
        {
            answer5[0] = Q5_Button1.Text;
            Q9_Panel1.Visible = true;
            Q5_Button1.BackColor = Color.LemonChiffon;
            flag5 = true;

        }

        protected void Q5_Button2_Click(object sender, EventArgs e)
        {
            answer5[1] = Q5_Button2.Text;
            Q9_Panel2.Visible = true;
            Q5_Button2.BackColor = Color.LemonChiffon;
            flag5 = true;
        }

        protected void Q5_Button3_Click(object sender, EventArgs e)
        {
            answer5[2] = Q5_Button3.Text;
            Q9_Panel3.Visible = true;
            Q5_Button3.BackColor = Color.LemonChiffon;
            flag5 = true;
        }

        protected void Q5_Button4_Click(object sender, EventArgs e)
        {
            answer5[3] = Q5_Button4.Text;
            Q9_Panel4.Visible = true;
            Q5_Button4.BackColor = Color.LemonChiffon;
            flag5 = true;
        }

        protected void Q5_Button5_Click(object sender, EventArgs e)
        {
            answer5[4] = Q5_Button5.Text;
            Q9_Panel5.Visible = true;
            Q5_Button5.BackColor = Color.LemonChiffon;
            flag5 = true;
        }

        protected void Q5_Button6_Click(object sender, EventArgs e)
        {
            answer5[5] = Q5_Button6.Text;
            Q9_Panel6.Visible = true;
            Q5_Button6.BackColor = Color.LemonChiffon; flag5 = true;
        }
        // !! QUESTION FIVE ENDS !! // 

        // --!!!!!!!!!!!!!!!!!!!-- //
        // !! QUESTION SIX BEGINS  !! // 
        protected void Q6_Button1_Click(object sender, EventArgs e)
        {
            answer6[0] = Q6_Button1.Text;
            Q6_Button1.BackColor = Color.LemonChiffon;
            flag6 = true;
        }

        protected void Q6_Button2_Click(object sender, EventArgs e)
        {
            answer6[1] = Q6_Button2.Text;
            Q6_Button2.BackColor = Color.LemonChiffon; flag6 = true;
        }

        protected void Q6_Button3_Click(object sender, EventArgs e)
        {
            answer6[2] = Q6_Button3.Text;
            Q6_Button3.BackColor = Color.LemonChiffon; flag6 = true;
        }

        protected void Q6_Button4_Click(object sender, EventArgs e)
        {
            answer6[3] = Q6_Button4.Text;
            Q6_Button4.BackColor = Color.LemonChiffon; flag6 = true;
        }

        protected void Q6_Button5_Click(object sender, EventArgs e)
        {
            answer6[4] = Q6_Button5.Text;
            Q6_Button5.BackColor = Color.LemonChiffon; flag6 = true;
        }

        protected void Q6_Button6_Click(object sender, EventArgs e)
        {
            answer6[5] = Q6_Button6.Text;
            Q6_Button6.BackColor = Color.LemonChiffon; flag6 = true;
        }
        // QUESTION SEVEN
        protected void Q7_Selected1(object sender, EventArgs e)
        {
            answer7[0,0] = Q7_1.SelectedValue;
        }

        protected void Q7_Selected2(object sender, EventArgs e)
        {
            answer7[0,1] = Q7_2.SelectedValue;
        }

        protected void Q7_Selected3(object sender, EventArgs e)
        {
            answer7[0,2] = Q7_3.SelectedValue;
        }

        protected void Q7_Selected4(object sender, EventArgs e)
        {
            answer7[0,3] = Q7_4.SelectedValue;
        }

        protected void Q7_Selected5(object sender, EventArgs e)
        {
            answer7[0,4] = Q7_5.SelectedValue;
        }

        protected void Q7_Selected6(object sender, EventArgs e)
        {
            answer7[0,5] = Q7_6.SelectedValue;
        }

        protected void Q7_2_Selected1(object sender, EventArgs e)
        {
            answer7[1,0] = Q7_2_1.SelectedValue;
        }

        protected void Q7_2_Selected2(object sender, EventArgs e)
        {
            answer7[1,1] = Q7_2_2.SelectedValue;
        }

        protected void Q7_2_Selected3(object sender, EventArgs e)
        {
            answer7[1,2] = Q7_2_3.SelectedValue;
        }

        protected void Q7_2_Selected4(object sender, EventArgs e)
        {
            answer7[1,3] = Q7_2_4.SelectedValue;
        }

        protected void Q7_2_Selected5(object sender, EventArgs e)
        {
            answer7[1,4] = Q7_2_5.SelectedValue;
        }

        protected void Q7_2_Selected6(object sender, EventArgs e)
        {
            answer7[1,5] = Q7_2_6.SelectedValue;
        }

        protected void Q7_3_Selected1(object sender, EventArgs e)
        {
            answer7[2,0] = Q7_3_1.SelectedValue;
        }

        protected void Q7_3_Selected2(object sender, EventArgs e)
        {
            answer7[2,1] = Q7_3_2.SelectedValue;
        }

        protected void Q7_3_Selected3(object sender, EventArgs e)
        {
            answer7[2,2] = Q7_3_3.SelectedValue;
        }

        protected void Q7_3_Selected4(object sender, EventArgs e)
        {
            answer7[2,3] = Q7_3_4.SelectedValue;
        }

        protected void Q7_3_Selected5(object sender, EventArgs e)
        {
            answer7[2,4] = Q7_3_5.SelectedValue;
        }

        protected void Q7_3_Selected6(object sender, EventArgs e)
        {
            answer7[2,5] = Q7_3_6.SelectedValue;
        }


        protected void Q7_4_Selected1(object sender, EventArgs e)
        {
            answer7[3,0] = Q7_4_1.SelectedValue;
        }

        protected void Q7_4_Selected2(object sender, EventArgs e)
        {
            answer7[3,1] = Q7_4_2.SelectedValue;
        }

        protected void Q7_4_Selected3(object sender, EventArgs e)
        {
            answer7[3,2] = Q7_4_3.SelectedValue;
        }

        protected void Q7_4_Selected4(object sender, EventArgs e)
        {
            answer7[3,3] = Q7_4_4.SelectedValue;
        }

        protected void Q7_4_Selected5(object sender, EventArgs e)
        {
            answer7[3,4] = Q7_4_5.SelectedValue;
        }

        protected void Q7_4_Selected6(object sender, EventArgs e)
        {
            answer7[3,5] = Q7_4_6.SelectedValue;
        }


        protected void Q7_5_Selected1(object sender, EventArgs e)
        {
            answer7[4,0] = Q7_5_1.SelectedValue;
        }

        protected void Q7_5_Selected2(object sender, EventArgs e)
        {
            answer7[4,1] = Q7_5_2.SelectedValue;
        }

        protected void Q7_5_Selected3(object sender, EventArgs e)
        {
            answer7[4,2] = Q7_5_3.SelectedValue;
        }

        protected void Q7_5_Selected4(object sender, EventArgs e)
        {
            answer7[4,3] = Q7_5_4.SelectedValue;
        }

        protected void Q7_5_Selected5(object sender, EventArgs e)
        {
            answer7[4,4] = Q7_5_5.SelectedValue;
        }

        protected void Q7_5_Selected6(object sender, EventArgs e)
        {
            answer7[4,5] = Q7_5_6.SelectedValue;
        }

        protected void Q7_6_Selected1(object sender, EventArgs e)
        {
            answer7[5,0] = Q7_6_1.SelectedValue;
        }

        protected void Q7_6_Selected2(object sender, EventArgs e)
        {
            answer7[5,1] = Q7_6_2.SelectedValue;
        }

        protected void Q7_6_Selected3(object sender, EventArgs e)
        {
            answer7[5,2] = Q7_6_3.SelectedValue;
        }

        protected void Q7_6_Selected4(object sender, EventArgs e)
        {
            answer7[5,3] = Q7_6_4.SelectedValue;
        }

        protected void Q7_6_Selected5(object sender, EventArgs e)
        {
            answer7[5,4] = Q7_6_5.SelectedValue;
        }

        protected void Q7_6_Selected6(object sender, EventArgs e)
        {
            answer7[5,5] = Q7_6_6.SelectedValue;
        }

        protected void Q8_Button1_Click(object sender, EventArgs e)
        {
            answer8[0] = Q8_Button1.Text;
            Q8_Button1.BackColor = Color.LemonChiffon; flag8 = true;
        }

        protected void Q8_Button2_Click(object sender, EventArgs e)
        {
            answer8[1] = Q8_Button2.Text;
            Q8_Button2.BackColor = Color.LemonChiffon; flag8 = true;
        }

        protected void Q8_Button3_Click(object sender, EventArgs e)
        {
            answer8[2] = Q8_Button3.Text;
            Q8_Button3.BackColor = Color.LemonChiffon; flag8 = true;
        }

        protected void Q8_Button4_Click(object sender, EventArgs e)
        {
            answer8[3] = Q8_Button4.Text;
            Q8_Button4.BackColor = Color.LemonChiffon; flag8 = true;
        }

        protected void Q8_Button5_Click(object sender, EventArgs e)
        {
            answer8[4] = Q8_Button5.Text;
            Q8_Button5.BackColor = Color.LemonChiffon; flag8 = true;
        }

        protected void Q8_Button6_Click(object sender, EventArgs e)
        {
            answer8[5] = Q8_Button6.Text;
            Q8_Button6.BackColor = Color.LemonChiffon; flag8 = true;
        }

        protected void Q8_Button7_Click(object sender, EventArgs e)
        {
            answer8[6] = Q8_Button7.Text;
            Q8_Button7.BackColor = Color.LemonChiffon; flag8 = true;
        }


        protected void Q9_Selected1(object sender, EventArgs e)
        {
            answer9[0,0] = Q9_1.SelectedValue;
        }

        protected void Q9_Selected2(object sender, EventArgs e)
        {
            answer9[0,1] = Q9_1.SelectedValue;
        }

        protected void Q9_Selected3(object sender, EventArgs e)
        {
            answer9[0,2] = Q9_3.SelectedValue;
        }

        protected void Q9_Selected4(object sender, EventArgs e)
        {
            answer9[0,3] = Q9_4.SelectedValue;
        }

        protected void Q9_Selected5(object sender, EventArgs e)
        {
            answer9[0,4] = Q9_5.SelectedValue;
        }

        protected void Q9_Selected6(object sender, EventArgs e)
        {
            answer9[0,5] = Q9_6.SelectedValue;
        }

        protected void Q9_Selected7(object sender, EventArgs e)
        {
            answer9[0,6] = Q9_7.SelectedValue;
        }
        protected void Q9_2_Selected1(object sender, EventArgs e)
        {
            answer9[1,0] = Q9_2_1.SelectedValue;
        }

        protected void Q9_2_Selected2(object sender, EventArgs e)
        {
            answer9[1,1] = Q9_2_2.SelectedValue;
        }

        protected void Q9_2_Selected3(object sender, EventArgs e)
        {
            answer9[1,2] = Q9_2_3.SelectedValue;
        }

        protected void Q9_2_Selected4(object sender, EventArgs e)
        {
            answer9[1,3] = Q9_2_4.SelectedValue;
        }

        protected void Q9_2_Selected5(object sender, EventArgs e)
        {
            answer9[1,4] = Q9_2_5.SelectedValue;
        }

        protected void Q9_2_Selected6(object sender, EventArgs e)
        {
            answer9[1,5] = Q9_2_6.SelectedValue;
        }

        protected void Q9_2_Selected7(object sender, EventArgs e)
        {
            answer9[1,6] = Q9_2_7.SelectedValue;
        }


        protected void Q9_3_Selected1(object sender, EventArgs e)
        {
            answer9[2, 0] = Q9_3_1.SelectedValue;
        }

        protected void Q9_3_Selected2(object sender, EventArgs e)
        {
            answer9[2, 1] = Q9_3_2.SelectedValue;
        }

        protected void Q9_3_Selected3(object sender, EventArgs e)
        {
            answer9[2,2 ] = Q9_3_3.SelectedValue;
        }

        protected void Q9_3_Selected4(object sender, EventArgs e)
        {
            answer9[2, 3] = Q9_3_4.SelectedValue;
        }

        protected void Q9_3_Selected5(object sender, EventArgs e)
        {
            answer9[2,4 ] = Q9_3_5.SelectedValue;
        }

        protected void Q9_3_Selected6(object sender, EventArgs e)
        {
            answer9[2,5 ] = Q9_3_6.SelectedValue;
        }

        protected void Q9_3_Selected7(object sender, EventArgs e)
        {
            answer9[2, 6] = Q9_3_7.SelectedValue;
        }
        // Q9 - 4
        protected void Q9_4_Selected1(object sender, EventArgs e)
        {
            answer9[3, 0] = Q9_4_1.SelectedValue;
        }

        protected void Q9_4_Selected2(object sender, EventArgs e)
        {
            answer9[3, 1] = Q9_4_2.SelectedValue;
        }

        protected void Q9_4_Selected3(object sender, EventArgs e)
        {
            answer9[3,2 ] = Q9_4_3.SelectedValue;
        }

        protected void Q9_4_Selected4(object sender, EventArgs e)
        {
            answer9[3,3 ] = Q9_4_4.SelectedValue;
        }

        protected void Q9_4_Selected5(object sender, EventArgs e)
        {
            answer9[3,4 ] = Q9_4_5.SelectedValue;
        }

        protected void Q9_4_Selected6(object sender, EventArgs e)
        {
            answer9[3,5 ] = Q9_4_6.SelectedValue;
        }

        protected void Q9_4_Selected7(object sender, EventArgs e)
        {
            answer9[3, 6] = Q9_4_7.SelectedValue;
        }

        protected void Q9_5_Selected1(object sender, EventArgs e)
        {
            answer9[4,0 ] = Q9_5_1.SelectedValue;
        }

        protected void Q9_5_Selected2(object sender, EventArgs e)
        {
            answer9[4, 1] = Q9_5_2.SelectedValue;
        }

        protected void Q9_5_Selected3(object sender, EventArgs e)
        {
            answer9[4,2] = Q9_5_3.SelectedValue;
        }

        protected void Q9_5_Selected4(object sender, EventArgs e)
        {
            answer9[4,3 ] = Q9_5_4.SelectedValue;
        }

        protected void Q9_5_Selected5(object sender, EventArgs e)
        {
            answer9[4,4 ] = Q9_5_5.SelectedValue;
        }

        protected void Q9_5_Selected6(object sender, EventArgs e)
        {
            answer9[4,5 ] = Q9_5_6.SelectedValue;
        }

        protected void Q9_5_Selected7(object sender, EventArgs e)
        {
            answer9[4,6 ] = Q9_5_7.SelectedValue;
        }

        protected void Q9_6_Selected1(object sender, EventArgs e)
        {
            answer9[5,0 ] = Q9_6_1.SelectedValue;
        }

        protected void Q9_6_Selected2(object sender, EventArgs e)
        {
            answer9[5, 1] = Q9_6_2.SelectedValue;
        }

        protected void Q9_6_Selected3(object sender, EventArgs e)
        {
            answer9[5,2 ] = Q9_6_3.SelectedValue;
        }

        protected void Q9_6_Selected4(object sender, EventArgs e)
        {
            answer9[5, 3] = Q9_6_4.SelectedValue;
        }

        protected void Q9_6_Selected5(object sender, EventArgs e)
        {
            answer9[5, 4] = Q9_6_5.SelectedValue;
        }

        protected void Q9_6_Selected6(object sender, EventArgs e)
        {
            answer9[5, 5] = Q9_6_6.SelectedValue;
        }

        protected void Q9_6_Selected7(object sender, EventArgs e)
        {
            answer9[5, 6] = Q9_6_7.SelectedValue;
        }

        //SUBMIT
        protected void Submit_Click(object sender, EventArgs e)
        {   if(flag1!=false && flag3!=false && flag5!=false && flag8!=false && flag6 != false )
            {
                if (confirm == true) { confirm = false;
                    // Buraya connection string yazılacak
                    SqlConnection sqlCon = new SqlConnection(@"Data Source=LAPTOP-VUTL47O8;Initial Catalog=prototype_edider;Integrated Security=True");
                    Submit.BackColor = Color.LawnGreen;
                    sqlCon.Open();
                    SqlCommand sqlCmd_c = new SqlCommand("insert into Company values('" + TextBox1.Text + "'  )", sqlCon);
                    SqlCommand sqlCmd = new SqlCommand("insert into Q1 values('" + answer1[0] + "' , '" + answer1[1] + "' , '" + answer1[2] + "' , '" + answer1[3] + "', '" + answer1[4] + "','" + answer1[5] + "' )", sqlCon);
                    SqlCommand sqlCmd2 = new SqlCommand("insert into Q2 values('" + answer2[0] + "' , '" + answer2[1] + "' , '" + answer2[2] + "' , '" + answer2[3] + "', '" + answer2[4] + "','" + answer2[5] + "' )", sqlCon);
                    SqlCommand sqlCmd3 = new SqlCommand("insert into Q3 values('" + answer3[0] + "' , '" + answer3[1] + "' , '" + answer3[2] + "' , '" + answer3[3] + "', '" + answer3[4] + "','" + answer3[5] + "' )", sqlCon);
                    SqlCommand sqlCmd4 = new SqlCommand("insert into Q4_1 values('" + answer4[0, 0] + "' , '" + answer4[0, 1] + "' , '" + answer4[0, 2] + "' , '" + answer4[0, 3] + "', '" + answer4[0, 4] + "','" + answer4[0, 5] + "' )", sqlCon);
                    SqlCommand sqlCmd5 = new SqlCommand("insert into Q4_2 values('" + answer4[1, 0] + "' , '" + answer4[1, 1] + "' , '" + answer4[1, 2] + "' , '" + answer4[1, 3] + "', '" + answer4[1, 4] + "','" + answer4[1, 5] + "' )", sqlCon);
                    SqlCommand sqlCmd6 = new SqlCommand("insert into Q4_3 values('" + answer4[2, 0] + "' , '" + answer4[2, 1] + "' , '" + answer4[2, 2] + "' , '" + answer4[2, 3] + "', '" + answer4[2, 4] + "','" + answer4[2, 5] + "' )", sqlCon);
                    SqlCommand sqlCmd7 = new SqlCommand("insert into Q4_4 values('" + answer4[3, 0] + "' , '" + answer4[3, 1] + "' , '" + answer4[3, 2] + "' , '" + answer4[3, 3] + "', '" + answer4[3, 4] + "','" + answer4[3, 5] + "' )", sqlCon);
                    SqlCommand sqlCmd8 = new SqlCommand("insert into Q4_5 values('" + answer4[4, 0] + "' , '" + answer4[4, 1] + "' , '" + answer4[4, 2] + "' , '" + answer4[4, 3] + "', '" + answer4[4, 4] + "','" + answer4[4, 5] + "' )", sqlCon);
                    SqlCommand sqlCmd9 = new SqlCommand("insert into Q4_6 values('" + answer4[5, 0] + "' , '" + answer4[5, 1] + "' , '" + answer4[5, 2] + "' , '" + answer4[5, 3] + "', '" + answer4[5, 4] + "','" + answer4[5, 5] + "' )", sqlCon);
                    SqlCommand sqlCmd10 = new SqlCommand("insert into Q5 values('" + answer5[0] + "' , '" + answer5[1] + "' , '" + answer5[2] + "' , '" + answer5[3] + "', '" + answer5[4] + "','" + answer5[5] + "' )", sqlCon);
                    SqlCommand sqlCmd11 = new SqlCommand("insert into Q6 values('" + answer6[0] + "' , '" + answer6[1] + "' , '" + answer6[2] + "' , '" + answer6[3] + "', '" + answer6[4] + "','" + answer6[5] + "' )", sqlCon);



                    SqlCommand sqlCmd12 = new SqlCommand("insert into Q7_1 values('" + answer7[0, 0] + "' , '" + answer7[0, 1] + "' , '" + answer7[0, 2] + "' , '" + answer7[0, 3] + "', '" + answer7[0, 4] + "','" + answer7[0, 5] + "' )", sqlCon);
                    SqlCommand sqlCmd13 = new SqlCommand("insert into Q7_2 values('" + answer7[1, 0] + "' , '" + answer7[1, 1] + "' , '" + answer7[1, 2] + "' , '" + answer7[1, 3] + "', '" + answer7[1, 4] + "','" + answer7[1, 5] + "' )", sqlCon);
                    SqlCommand sqlCmd14 = new SqlCommand("insert into Q7_3 values('" + answer7[2, 0] + "' , '" + answer7[2, 1] + "' , '" + answer7[2, 2] + "' , '" + answer7[2, 3] + "', '" + answer7[2, 4] + "','" + answer7[2, 5] + "' )", sqlCon);
                    SqlCommand sqlCmd15 = new SqlCommand("insert into Q7_4 values('" + answer7[3, 0] + "' , '" + answer7[3, 1] + "' , '" + answer7[3, 2] + "' , '" + answer7[3, 3] + "', '" + answer7[3, 4] + "','" + answer7[3, 5] + "' )", sqlCon);
                    SqlCommand sqlCmd16 = new SqlCommand("insert into Q7_5 values('" + answer7[4, 0] + "' , '" + answer7[4, 1] + "' , '" + answer7[4, 2] + "' , '" + answer7[4, 3] + "', '" + answer7[4, 4] + "','" + answer7[4, 5] + "' )", sqlCon);
                    SqlCommand sqlCmd17 = new SqlCommand("insert into Q7_6 values('" + answer7[5, 0] + "' , '" + answer7[5, 1] + "' , '" + answer7[5, 2] + "' , '" + answer7[5, 3] + "', '" + answer7[5, 4] + "','" + answer7[5, 5] + "' )", sqlCon);


                    SqlCommand sqlCmd18 = new SqlCommand("insert into Q8 values('" + answer8[0] + "' , '" + answer8[1] + "' , '" + answer8[2] + "' , '" + answer8[3] + "', '" + answer8[4] + "','" + answer8[5] + "' , '" + answer8[6] + "' )", sqlCon);

                    SqlCommand sqlCmd19 = new SqlCommand("insert into Q9_1 values('" + answer9[0, 0] + "' , '" + answer9[0, 1] + "' , '" + answer9[0, 2] + "' , '" + answer9[0, 3] + "', '" + answer9[0, 4] + "','" + answer9[0, 5] + "', '" + answer9[0, 6] + "' )", sqlCon);
                    SqlCommand sqlCmd20 = new SqlCommand("insert into Q9_2 values('" + answer9[1, 0] + "' , '" + answer9[1, 1] + "' , '" + answer9[1, 2] + "' , '" + answer9[1, 3] + "', '" + answer9[1, 4] + "','" + answer9[1, 5] + "' , '" + answer9[1, 6] + "' )", sqlCon);
                    SqlCommand sqlCmd21 = new SqlCommand("insert into Q9_3 values('" + answer9[2, 0] + "' , '" + answer9[2, 1] + "' , '" + answer9[2, 2] + "' , '" + answer9[2, 3] + "', '" + answer9[2, 4] + "','" + answer9[2, 5] + "' , '" + answer9[2, 6] + "' )", sqlCon);
                    SqlCommand sqlCmd22 = new SqlCommand("insert into Q9_4 values('" + answer9[3, 0] + "' , '" + answer9[3, 1] + "' , '" + answer9[3, 2] + "' , '" + answer9[3, 3] + "', '" + answer9[3, 4] + "','" + answer9[3, 5] + "' , '" + answer9[3, 6] + "')", sqlCon);
                    SqlCommand sqlCmd23 = new SqlCommand("insert into Q9_5 values('" + answer9[4, 0] + "' , '" + answer9[4, 1] + "' , '" + answer9[4, 2] + "' , '" + answer9[4, 3] + "', '" + answer9[4, 4] + "','" + answer9[4, 5] + "' , '" + answer9[4, 6] + "' )", sqlCon);
                    SqlCommand sqlCmd24 = new SqlCommand("insert into Q9_6 values('" + answer9[5, 0] + "' , '" + answer9[5, 1] + "' , '" + answer9[5, 2] + "' , '" + answer9[5, 3] + "', '" + answer9[5, 4] + "','" + answer9[5, 5] + "' ,'" + answer9[5, 6] + "' )", sqlCon);
                    sqlCmd.ExecuteNonQuery();
                    sqlCmd2.ExecuteNonQuery();
                    sqlCmd3.ExecuteNonQuery();
                    sqlCmd4.ExecuteNonQuery();
                    sqlCmd5.ExecuteNonQuery();
                    sqlCmd6.ExecuteNonQuery();
                    sqlCmd7.ExecuteNonQuery();
                    sqlCmd8.ExecuteNonQuery();
                    sqlCmd9.ExecuteNonQuery();
                    sqlCmd10.ExecuteNonQuery();
                    sqlCmd11.ExecuteNonQuery();
                    sqlCmd12.ExecuteNonQuery();
                    sqlCmd13.ExecuteNonQuery();
                    sqlCmd14.ExecuteNonQuery();
                    sqlCmd15.ExecuteNonQuery();
                    sqlCmd16.ExecuteNonQuery();
                    sqlCmd17.ExecuteNonQuery();
                    sqlCmd18.ExecuteNonQuery();
                    sqlCmd19.ExecuteNonQuery();
                    sqlCmd20.ExecuteNonQuery();
                    sqlCmd21.ExecuteNonQuery();
                    sqlCmd22.ExecuteNonQuery();
                    sqlCmd23.ExecuteNonQuery();
                    sqlCmd24.ExecuteNonQuery();
                    sqlCmd_c.ExecuteNonQuery();

                    ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + display + "');", true);
                    sqlCon.Close();



                }
                else
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + sent + "');", true);
                }
                
                
            }else {

                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + warning + "');", true);
            }
        }

    }
}