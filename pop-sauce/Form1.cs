using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;
using System.Reflection;

namespace pop_sauce
{
    public partial class Form1 : Form
    {
        //borderless movable
        private bool _dragging = false;
        private Point _start_point = new Point(0, 0);

        //tmp vars
        public int it_question = 0;
        public int it_lyrics = 0;
        public int it_images = 0;

        public int current_gamemode = -1;
        public bool first_launch = true;

        public int random_value;
        public Random rnd = new Random();

        public int points_to_win;

        public List<String> question_all = new List<String>();
        public string answer_A;

        //list of all the images names
        public List<Bitmap> img_Bitmap = new List<Bitmap>() {
            pop_sauce.Properties.Resources.Al,
            pop_sauce.Properties.Resources.Aladdin,
            pop_sauce.Properties.Resources.Alice,
            pop_sauce.Properties.Resources.Angel,
            pop_sauce.Properties.Resources.Anna,
            pop_sauce.Properties.Resources.Ant_Man,
            pop_sauce.Properties.Resources.Ariel,
            pop_sauce.Properties.Resources.Arlo,
            pop_sauce.Properties.Resources.Astrid,
            pop_sauce.Properties.Resources.Atta,
            pop_sauce.Properties.Resources.Aurore,
            pop_sauce.Properties.Resources.Bambi,
            pop_sauce.Properties.Resources.Baymax,
            pop_sauce.Properties.Resources.BB_8,
            pop_sauce.Properties.Resources.Belle,
            pop_sauce.Properties.Resources.Black_Panther,
            pop_sauce.Properties.Resources.Black_Widow,
            pop_sauce.Properties.Resources.Blanche_Neige,
            pop_sauce.Properties.Resources.Bob,
            pop_sauce.Properties.Resources.Bonnie,
            pop_sauce.Properties.Resources.Bourriquet,
            pop_sauce.Properties.Resources.Buzz,
            pop_sauce.Properties.Resources.Captain_America,
            pop_sauce.Properties.Resources.Captain_Marvel,
            pop_sauce.Properties.Resources.Carl_Fredricksen,
            pop_sauce.Properties.Resources.Cendrillon,
            pop_sauce.Properties.Resources.Chat_Du_Cheshire,
            pop_sauce.Properties.Resources.Clochette,
            pop_sauce.Properties.Resources.Daisy,
            pop_sauce.Properties.Resources.Dark_Vador,
            pop_sauce.Properties.Resources.Darla,
            pop_sauce.Properties.Resources.Dingo,
            pop_sauce.Properties.Resources.Docteur_La_Peluche,
            pop_sauce.Properties.Resources.Donald,
            pop_sauce.Properties.Resources.Doug,
            pop_sauce.Properties.Resources.Dumbo,
            pop_sauce.Properties.Resources.Edna,
            pop_sauce.Properties.Resources.Elena,
            pop_sauce.Properties.Resources.Ellie_Fredricksen,
            pop_sauce.Properties.Resources.Ellinor,
            pop_sauce.Properties.Resources.Elsa,
            pop_sauce.Properties.Resources.Eve,
            pop_sauce.Properties.Resources.Flash_McQueen,
            pop_sauce.Properties.Resources.Fourchette,
            pop_sauce.Properties.Resources.Francesco_Bernoulli,
            pop_sauce.Properties.Resources.Germaine,
            pop_sauce.Properties.Resources.Gill,
            pop_sauce.Properties.Resources.Grincheux,
            pop_sauce.Properties.Resources.Groot,
            pop_sauce.Properties.Resources.Han_Solo,
            pop_sauce.Properties.Resources.Hercules,
            pop_sauce.Properties.Resources.Hulk,
            pop_sauce.Properties.Resources.IronMan,
            pop_sauce.Properties.Resources.Jack_Skellington,
            pop_sauce.Properties.Resources.Jasmine,
            pop_sauce.Properties.Resources.Jessie,
            pop_sauce.Properties.Resources.Joie,
            pop_sauce.Properties.Resources.La_Bergere,
            pop_sauce.Properties.Resources.La_Bete,
            pop_sauce.Properties.Resources.Lenny,
            pop_sauce.Properties.Resources.Leon,
            pop_sauce.Properties.Resources.Lotso,
            pop_sauce.Properties.Resources.Luigi,
            pop_sauce.Properties.Resources.Marie,
            pop_sauce.Properties.Resources.Marteau,
            pop_sauce.Properties.Resources.Martin,
            pop_sauce.Properties.Resources.Mary_Poppins,
            pop_sauce.Properties.Resources.Maui,
            pop_sauce.Properties.Resources.Meeko,
            pop_sauce.Properties.Resources.Merida,
            pop_sauce.Properties.Resources.Mickey,
            pop_sauce.Properties.Resources.Miguel,
            pop_sauce.Properties.Resources.Minnie,
            pop_sauce.Properties.Resources.Mirage,
            pop_sauce.Properties.Resources.Mulan,
            pop_sauce.Properties.Resources.Olaf,
            pop_sauce.Properties.Resources.Panpan,
            pop_sauce.Properties.Resources.Peter_Pan,
            pop_sauce.Properties.Resources.Pinocchio,
            pop_sauce.Properties.Resources.Pluto,
            pop_sauce.Properties.Resources.Pocahontas,
            pop_sauce.Properties.Resources.Porcinet,
            pop_sauce.Properties.Resources.R2_D2,
            pop_sauce.Properties.Resources.Raiponec,
            pop_sauce.Properties.Resources.Rex,
            pop_sauce.Properties.Resources.Russell,
            pop_sauce.Properties.Resources.Sally,
            pop_sauce.Properties.Resources.Siffli,
            pop_sauce.Properties.Resources.Simba,
            pop_sauce.Properties.Resources.Spiderman,
            pop_sauce.Properties.Resources.Spot,
            pop_sauce.Properties.Resources.Stitch,
            pop_sauce.Properties.Resources.Sully,
            pop_sauce.Properties.Resources.Syndrome,
            pop_sauce.Properties.Resources.Thanos,
            pop_sauce.Properties.Resources.Thor,
            pop_sauce.Properties.Resources.Tiana,
            pop_sauce.Properties.Resources.Tic_Et_Tac,
            pop_sauce.Properties.Resources.Tigrou,
            pop_sauce.Properties.Resources.Tilt,
            pop_sauce.Properties.Resources.Tristesse,
            pop_sauce.Properties.Resources.Vaiana,
            pop_sauce.Properties.Resources.Vampirina,
            pop_sauce.Properties.Resources.WALL_E,
            pop_sauce.Properties.Resources.Winnie_L_Ourson,
            pop_sauce.Properties.Resources.Woody,
            pop_sauce.Properties.Resources.Yeti,
            pop_sauce.Properties.Resources.Zig_Zag,
            pop_sauce.Properties.Resources.Zip
        };

        //list of all questions
        static public String questions = pop_sauce.Properties.Resources.question;
        public List<String> questions_split = questions.Split('\n').ToList();

        //list of all lyrics
        static public String lyrics = pop_sauce.Properties.Resources.lyrics;
        public List<String> lyrics_split = lyrics.Split('$').ToList();

        public Form1()
        {
            InitializeComponent();
            label_score.Hide();
            label_score_fix.Hide();
            label_player_name.Hide();
            textBox_game.Hide();
            button_q_validate.Hide();
            panel_name.Hide();
            panel_lyrics.Hide();
            panel_questions.Hide();
            this.Width = 211;
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //setup files
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBoxExt1_TextChanged(object sender, EventArgs e)
        {

        }

        private void sfButton1_Click(object sender, EventArgs e)
        {
            //Button Exit
            this.Close();
        }

        private void sfButton1_Click_1(object sender, EventArgs e)
        {
            //Button Minimize
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel_top_MouseDown(object sender, MouseEventArgs e)
        {
            //borderless movable
            _dragging = true;
            _start_point = new Point(e.X, e.Y);
        }

        private void panel_top_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragging)
            {
                //borderless movable
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this._start_point.X, p.Y - this._start_point.Y);
            }
        }

        private void panel_top_MouseUp(object sender, MouseEventArgs e)
        {
            //borderless movable
            _dragging = false;
        }

        private void panel_top_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Width = 801;
            panel_name.Show();
            panel_name.BringToFront();

            if (first_launch)
            {
                // Mélange de la liste img_bitamp
                List<Bitmap> random_img = new List<Bitmap>();
                Random r = new Random();
                int randomIndex = 0;
                while (img_Bitmap.Count > 0)
                {
                    randomIndex = r.Next(0, img_Bitmap.Count); //Choose a random object in the list
                    random_img.Add(img_Bitmap[randomIndex]); //add it to the new, random list
                    img_Bitmap.RemoveAt(randomIndex); //remove to avoid duplicates
                }
                img_Bitmap = random_img;

                // Mélange de la liste des questions
                List<String> random_questions = new List<String>();
                r = new Random();
                randomIndex = 0;
                while (questions_split.Count > 0)
                {
                    randomIndex = r.Next(0, questions_split.Count); //Choose a random object in the list
                    random_questions.Add(questions_split[randomIndex]); //add it to the new, random list
                    questions_split.RemoveAt(randomIndex); //remove to avoid duplicates
                }
                questions_split = random_questions;

                //Mélange des lyrics
                List<String> random_lyrics = new List<String>();
                r = new Random();
                randomIndex = 0;
                while (lyrics_split.Count > 0)
                {
                    randomIndex = r.Next(0, lyrics_split.Count); //Choose a random object in the list
                    random_lyrics.Add(lyrics_split[randomIndex]); //add it to the new, random list
                    lyrics_split.RemoveAt(randomIndex); //remove to avoid duplicates
                }
                lyrics_split = random_lyrics;
                first_launch = false;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void sfButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clock1_Click(object sender, EventArgs e)
        {

        }


        private void label_score_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label_score_fix_MouseDown(object sender, MouseEventArgs e)
        {
            //borderless movable
            _dragging = true;
            _start_point = new Point(e.X, e.Y);
        }

        private void label_score_fix_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragging)
            {
                //borderless movable
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this._start_point.X, p.Y - this._start_point.Y);
            }
        }

        private void label_score_fix_MouseUp(object sender, MouseEventArgs e)
        {
            //borderless movable
            _dragging = false;
        }

        private void label_score_MouseDown(object sender, MouseEventArgs e)
        {
            //borderless movable
            _dragging = true;
            _start_point = new Point(e.X, e.Y);
        }

        private void label_score_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragging)
            {
                //borderless movable
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this._start_point.X, p.Y - this._start_point.Y);
            }
        }

        private void label_score_MouseUp(object sender, MouseEventArgs e)
        {
            //borderless movable
            _dragging = false;
        }

        private void label3_MouseUp(object sender, MouseEventArgs e)
        {
            //borderless movable
            _dragging = false;
        }
        private void label3_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragging)
            {
                //borderless movable
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this._start_point.X, p.Y - this._start_point.Y);
            }
        }

        private void label3_MouseDown(object sender, MouseEventArgs e)
        {
            //borderless movable
            _dragging = true;
            _start_point = new Point(e.X, e.Y);
        }

        private void panel_side_MouseDown(object sender, MouseEventArgs e)
        {
            //borderless movable
            _dragging = true;
            _start_point = new Point(e.X, e.Y);
        }

        private void panel_side_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragging)
            {
                //borderless movable
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this._start_point.X, p.Y - this._start_point.Y);
            }
        }

        private void panel_side_MouseUp(object sender, MouseEventArgs e)
        {
            //borderless movable
            _dragging = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            //borderless movable
            _dragging = true;
            _start_point = new Point(e.X, e.Y);
        }

        private void pictureBox2_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragging)
            {
                //borderless movable
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this._start_point.X, p.Y - this._start_point.Y);
            }
        }

        private void pictureBox2_MouseUp(object sender, MouseEventArgs e)
        {
            //borderless movable
            _dragging = false;
        }

        private void label_lyrics_Click(object sender, EventArgs e)
        {

        }

        private void label_score_fix_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            // 1 char max
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            //borderless movable
            _dragging = true;
            _start_point = new Point(e.X, e.Y);
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragging)
            {
                //borderless movable
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this._start_point.X, p.Y - this._start_point.Y);
            }
        }

        private void label1_MouseUp(object sender, MouseEventArgs e)
        {
            //borderless movable
            _dragging = false;
        }

        private void button_q_duo_Click(object sender, EventArgs e)
        {
            points_to_win = 1;
            button_q_duo.Hide();
            button_q_carre.Hide();
            button_q_cash.Hide();
            button_RC.Hide();
            button_RD.Hide();

            answer_A = question_all[1];
            String answer_B = question_all[2];

            List<String> random_answers = new List<String>();
            random_answers.Add(answer_A);
            random_answers.Add(answer_B);

            List<String> new_random_answers = new List<String>();
            Random r = new Random();
            int randomIndex = 0;
            while (random_answers.Count > 0)
            {
                randomIndex = r.Next(0, random_answers.Count); //Choose a random object in the list
                new_random_answers.Add(random_answers[randomIndex]); //add it to the new, random list
                random_answers.RemoveAt(randomIndex); //remove to avoid duplicates
            }

            answer_A = new_random_answers[0];
            answer_B = new_random_answers[1];

            button_RA.Text = answer_A;
            button_RB.Text = answer_B;

            button_RA.Show();
            button_RB.Show();
            button_RA.BringToFront();
            button_RB.BringToFront();
        }

        private void button_name_validate_Click(object sender, EventArgs e)
        {
            label_player_name.Text = richTextBox1.Text;
            label_player_name.Show();
            label_score.Show();
            label_score_fix.Show();
            richTextBox1.Hide();
            button_name_validate.Hide();
            
            random_value = rnd.Next(0, questions.Count());

            //partie questions
            panel_questions.Show();
            panel_questions.BringToFront();
            button_RA.Hide();
            button_RB.Hide();
            button_RC.Hide();
            button_RD.Hide();

            question_all = questions_split[0].Split(';').ToList();
            String question = question_all[0];
            questions_split.RemoveAt(0);
            label_question.Text = question;
            button_q_duo.Show();
            button_q_carre.Show();
            button_q_cash.Show();
            button_q_duo.BringToFront();
            button_q_carre.BringToFront();
            button_q_cash.BringToFront();
        }


        private void button_cycle_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {

        }

        private void textBox_game_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click_1(this, new EventArgs());
            }
        }

        private void richTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button_name_validate_Click(this, new EventArgs());
            }
        }

        private void button_parametres_Click(object sender, EventArgs e)
        {
            var formPopup = new Form();
            formPopup.Show(this); // if you need non-modal window
        }

        private void button_classement_Click(object sender, EventArgs e)
        {
            var formPopup = new Form();
            formPopup.Show(this); // if you need non-modal window
        }
        
        private void button_about_Click(object sender, EventArgs e)
        {
            var formPopup = new Form();
            formPopup.Show(this); // if you need non-modal window
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (button_RA.Text == answer_A)
            {
                
                int score = int.Parse(label_score.Text);
                score += points_to_win;
                string updated_score = score.ToString();
                label_score.Text = updated_score;
                //score += 1 
            }
            else
            {
                //vie -= 1
            }
            button_name_validate_Click(sender, e);
        }
        
        private void button_RB_Click(object sender, EventArgs e)
        {
            if (button_RB.Text == answer_A)
            {

                int score = int.Parse(label_score.Text);
                score += points_to_win;
                string updated_score = score.ToString();
                label_score.Text = updated_score;
                //score += 1 
            }
            else
            {
                //vie -= 1
            }
            button_name_validate_Click(sender, e);
        }

        private void button_RC_Click(object sender, EventArgs e)
        {
            if (button_RC.Text == answer_A)
            {

                int score = int.Parse(label_score.Text);
                score += points_to_win;
                string updated_score = score.ToString();
                label_score.Text = updated_score;
                //score += 1 
            }
            else
            {
                //vie -= 1
            }
            button_name_validate_Click(sender, e);
        }

        private void button_RD_Click(object sender, EventArgs e)
        {
            if (button_RD.Text == answer_A)
            {

                int score = int.Parse(label_score.Text);
                score += points_to_win;
                string updated_score = score.ToString();
                label_score.Text = updated_score;
                //score += 1 
            }
            else
            {
                //vie -= 1
            }
            button_name_validate_Click(sender, e);
        }

        private void button_q_carre_Click(object sender, EventArgs e)
        {
            points_to_win = 3;
            button_q_duo.Hide();
            button_q_carre.Hide();
            button_q_cash.Hide();
            button_RC.Hide();
            button_RD.Hide();

            answer_A = question_all[1];
            String answer_B = question_all[2];
            String answer_C = question_all[3];
            String answer_D = question_all[4];

            List<String> random_answers = new List<String>();
            random_answers.Add(answer_A);
            random_answers.Add(answer_B);
            random_answers.Add(answer_C);
            random_answers.Add(answer_D);

            List<String> new_random_answers = new List<String>();
            Random r = new Random();
            int randomIndex = 0;
            while (random_answers.Count > 0)
            {
                randomIndex = r.Next(0, random_answers.Count); //Choose a random object in the list
                new_random_answers.Add(random_answers[randomIndex]); //add it to the new, random list
                random_answers.RemoveAt(randomIndex); //remove to avoid duplicates
            }

            answer_A = new_random_answers[0];
            answer_B = new_random_answers[1];
            answer_C = new_random_answers[2];
            answer_D = new_random_answers[3];

            button_RA.Text = answer_A;
            button_RB.Text = answer_B;
            button_RC.Text = answer_C;
            button_RD.Text = answer_D;

            button_RA.Show();
            button_RB.Show();
            button_RC.Show();
            button_RD.Show();
            button_RA.BringToFront();
            button_RB.BringToFront();
            button_RC.BringToFront();
            button_RD.BringToFront();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            button_q_cash_Click(this, null);
        }
        private void button_q_cash_Click(object sender, EventArgs e)
        {
            switch (e)
            {
                case null:
                    string answer = textBox_game.Text;
                    if (LevenshteinDistance.Compute(answer, answer_A) <= 4)
                    {
                        
                        int score = int.Parse(label_score.Text);
                        score += 5;
                        string updated_score = score.ToString();
                        label_score.Text = updated_score;
                        /////score += 5 
                    }
                    else
                    {
                        //vie -= 1
                    }
                    textBox_game.Hide();
                    button_q_validate.Hide();
                    button_name_validate_Click(sender, e);

                    break;

                default:

                    button_q_duo.Hide();
                    button_q_carre.Hide();
                    button_q_cash.Hide();

                    button_RA.Hide();
                    button_RB.Hide();
                    button_RC.Hide();
                    button_RD.Hide();

                    textBox_game.Show();
                    textBox_game.BringToFront();
                    button_q_validate.Show();
                    button_q_validate.BringToFront();
                    break;
            }


        }

        private void textBox_game_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox_logo_Click(object sender, EventArgs e)
        {

        }
    }


    static class LevenshteinDistance
    {
        /// Algorithme de Levenshtein
        /// Compute the distance between two strings,
        /// the number of edits needed to transform one string into the other.
        public static int Compute(string s, string t)
        {
            int n = s.Length;
            int m = t.Length;
            int[,] d = new int[n + 1, m + 1];

            // Step 1
            if (n == 0)
            {
                return m;
            }

            if (m == 0)
            {
                return n;
            }

            // Step 2
            for (int i = 0; i <= n; d[i, 0] = i++)
            {
            }

            for (int j = 0; j <= m; d[0, j] = j++)
            {
            }

            // Step 3
            for (int i = 1; i <= n; i++)
            {
                //Step 4
                for (int j = 1; j <= m; j++)
                {
                    // Step 5
                    int cost = (t[j - 1] == s[i - 1]) ? 0 : 1;

                    // Step 6
                    d[i, j] = Math.Min(
                        Math.Min(d[i - 1, j] + 1, d[i, j - 1] + 1),
                        d[i - 1, j - 1] + cost);
                }
            }
            // Step 7
            return d[n, m];
        }
    }
}