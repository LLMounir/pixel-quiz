namespace pop_sauce
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel_logo = new System.Windows.Forms.Panel();
            this.pictureBox_logo = new System.Windows.Forms.PictureBox();
            this.panel_side = new System.Windows.Forms.Panel();
            this.button_jouer = new System.Windows.Forms.Button();
            this.button_about = new System.Windows.Forms.Button();
            this.button_classement = new System.Windows.Forms.Button();
            this.button_parametres = new System.Windows.Forms.Button();
            this.sfButton1 = new Syncfusion.WinForms.Controls.SfButton();
            this.sfButton2 = new Syncfusion.WinForms.Controls.SfButton();
            this.panel_top = new System.Windows.Forms.Panel();
            this.label_player_name = new System.Windows.Forms.Label();
            this.label_score = new System.Windows.Forms.Label();
            this.label_score_fix = new System.Windows.Forms.Label();
            this.textBox_game = new System.Windows.Forms.TextBox();
            this.button_q_validate = new System.Windows.Forms.Button();
            this.panel_questions = new System.Windows.Forms.Panel();
            this.button_q_cash = new System.Windows.Forms.Button();
            this.button_q_carre = new System.Windows.Forms.Button();
            this.button_RA = new System.Windows.Forms.Button();
            this.button_RD = new System.Windows.Forms.Button();
            this.button_RC = new System.Windows.Forms.Button();
            this.button_RB = new System.Windows.Forms.Button();
            this.button_q_duo = new System.Windows.Forms.Button();
            this.label_question = new System.Windows.Forms.Label();
            this.panel_lyrics = new System.Windows.Forms.Panel();
            this.label_lyrics = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel_name = new System.Windows.Forms.Panel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button_name_validate = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel_logo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logo)).BeginInit();
            this.panel_side.SuspendLayout();
            this.panel_top.SuspendLayout();
            this.panel_questions.SuspendLayout();
            this.panel_lyrics.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel_name.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_logo
            // 
            this.panel_logo.BackColor = System.Drawing.Color.Transparent;
            this.panel_logo.Controls.Add(this.pictureBox_logo);
            this.panel_logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_logo.Location = new System.Drawing.Point(0, 0);
            this.panel_logo.Name = "panel_logo";
            this.panel_logo.Size = new System.Drawing.Size(211, 64);
            this.panel_logo.TabIndex = 2;
            // 
            // pictureBox_logo
            // 
            this.pictureBox_logo.Image = global::pop_sauce.Properties.Resources.logo_new;
            this.pictureBox_logo.Location = new System.Drawing.Point(0, -2);
            this.pictureBox_logo.Name = "pictureBox_logo";
            this.pictureBox_logo.Size = new System.Drawing.Size(211, 80);
            this.pictureBox_logo.TabIndex = 0;
            this.pictureBox_logo.TabStop = false;
            this.pictureBox_logo.Click += new System.EventHandler(this.pictureBox_logo_Click);
            this.pictureBox_logo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox2_MouseDown);
            this.pictureBox_logo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox2_MouseMove);
            this.pictureBox_logo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox2_MouseUp);
            // 
            // panel_side
            // 
            this.panel_side.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.panel_side.Controls.Add(this.button_jouer);
            this.panel_side.Controls.Add(this.button_about);
            this.panel_side.Controls.Add(this.button_classement);
            this.panel_side.Controls.Add(this.button_parametres);
            this.panel_side.Controls.Add(this.panel_logo);
            this.panel_side.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_side.Location = new System.Drawing.Point(0, 0);
            this.panel_side.Name = "panel_side";
            this.panel_side.Size = new System.Drawing.Size(211, 478);
            this.panel_side.TabIndex = 0;
            this.panel_side.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_side_MouseDown);
            this.panel_side.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_side_MouseMove);
            this.panel_side.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel_side_MouseUp);
            // 
            // button_jouer
            // 
            this.button_jouer.BackColor = System.Drawing.Color.White;
            this.button_jouer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_jouer.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_jouer.FlatAppearance.BorderSize = 0;
            this.button_jouer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_jouer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_jouer.Image = global::pop_sauce.Properties.Resources.jouer;
            this.button_jouer.Location = new System.Drawing.Point(12, 83);
            this.button_jouer.Name = "button_jouer";
            this.button_jouer.Size = new System.Drawing.Size(187, 48);
            this.button_jouer.TabIndex = 3;
            this.button_jouer.UseVisualStyleBackColor = false;
            this.button_jouer.Click += new System.EventHandler(this.button2_Click);
            // 
            // button_about
            // 
            this.button_about.BackColor = System.Drawing.Color.White;
            this.button_about.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_about.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_about.FlatAppearance.BorderSize = 0;
            this.button_about.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_about.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_about.Image = global::pop_sauce.Properties.Resources.apropos;
            this.button_about.Location = new System.Drawing.Point(12, 418);
            this.button_about.Name = "button_about";
            this.button_about.Size = new System.Drawing.Size(187, 48);
            this.button_about.TabIndex = 6;
            this.button_about.UseVisualStyleBackColor = false;
            this.button_about.Click += new System.EventHandler(this.button_about_Click);
            // 
            // button_classement
            // 
            this.button_classement.BackColor = System.Drawing.Color.White;
            this.button_classement.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_classement.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_classement.FlatAppearance.BorderSize = 0;
            this.button_classement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_classement.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_classement.Image = global::pop_sauce.Properties.Resources.classement;
            this.button_classement.Location = new System.Drawing.Point(12, 201);
            this.button_classement.Name = "button_classement";
            this.button_classement.Size = new System.Drawing.Size(187, 48);
            this.button_classement.TabIndex = 5;
            this.button_classement.UseVisualStyleBackColor = false;
            this.button_classement.Click += new System.EventHandler(this.button_classement_Click);
            // 
            // button_parametres
            // 
            this.button_parametres.BackColor = System.Drawing.Color.White;
            this.button_parametres.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_parametres.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_parametres.FlatAppearance.BorderSize = 0;
            this.button_parametres.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_parametres.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_parametres.Image = global::pop_sauce.Properties.Resources.parametres;
            this.button_parametres.Location = new System.Drawing.Point(12, 142);
            this.button_parametres.Name = "button_parametres";
            this.button_parametres.Size = new System.Drawing.Size(187, 48);
            this.button_parametres.TabIndex = 4;
            this.button_parametres.UseVisualStyleBackColor = false;
            this.button_parametres.Click += new System.EventHandler(this.button_parametres_Click);
            // 
            // sfButton1
            // 
            this.sfButton1.AccessibleName = "button_exit";
            this.sfButton1.BackColor = System.Drawing.Color.White;
            this.sfButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sfButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sfButton1.ForeColor = System.Drawing.Color.Black;
            this.sfButton1.Location = new System.Drawing.Point(508, 8);
            this.sfButton1.Name = "sfButton1";
            this.sfButton1.Size = new System.Drawing.Size(33, 44);
            this.sfButton1.Style.BackColor = System.Drawing.Color.White;
            this.sfButton1.Style.ForeColor = System.Drawing.Color.Black;
            this.sfButton1.TabIndex = 3;
            this.sfButton1.Text = "−";
            this.sfButton1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.sfButton1.UseVisualStyleBackColor = false;
            this.sfButton1.Click += new System.EventHandler(this.sfButton1_Click_1);
            // 
            // sfButton2
            // 
            this.sfButton2.AccessibleName = "button_exit";
            this.sfButton2.BackColor = System.Drawing.Color.White;
            this.sfButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sfButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sfButton2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.sfButton2.Location = new System.Drawing.Point(547, 8);
            this.sfButton2.Name = "sfButton2";
            this.sfButton2.Size = new System.Drawing.Size(33, 44);
            this.sfButton2.Style.BackColor = System.Drawing.Color.White;
            this.sfButton2.Style.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.sfButton2.TabIndex = 4;
            this.sfButton2.Text = "×";
            this.sfButton2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.sfButton2.UseVisualStyleBackColor = false;
            this.sfButton2.Click += new System.EventHandler(this.sfButton2_Click);
            // 
            // panel_top
            // 
            this.panel_top.BackColor = System.Drawing.Color.White;
            this.panel_top.Controls.Add(this.sfButton2);
            this.panel_top.Controls.Add(this.sfButton1);
            this.panel_top.Controls.Add(this.label_player_name);
            this.panel_top.Controls.Add(this.label_score);
            this.panel_top.Controls.Add(this.label_score_fix);
            this.panel_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_top.Location = new System.Drawing.Point(211, 0);
            this.panel_top.Name = "panel_top";
            this.panel_top.Size = new System.Drawing.Size(590, 64);
            this.panel_top.TabIndex = 1;
            this.panel_top.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_top_Paint);
            this.panel_top.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_top_MouseDown);
            this.panel_top.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_top_MouseMove);
            this.panel_top.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel_top_MouseUp);
            // 
            // label_player_name
            // 
            this.label_player_name.AutoSize = true;
            this.label_player_name.Font = new System.Drawing.Font("MV Boli", 23.77358F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_player_name.Location = new System.Drawing.Point(6, 10);
            this.label_player_name.Name = "label_player_name";
            this.label_player_name.Size = new System.Drawing.Size(266, 41);
            this.label_player_name.TabIndex = 6;
            this.label_player_name.Text = "PLAYER_NAME";
            this.label_player_name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label_player_name.Click += new System.EventHandler(this.label1_Click);
            this.label_player_name.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            this.label_player_name.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label1_MouseMove);
            this.label_player_name.MouseUp += new System.Windows.Forms.MouseEventHandler(this.label1_MouseUp);
            // 
            // label_score
            // 
            this.label_score.BackColor = System.Drawing.Color.Transparent;
            this.label_score.Font = new System.Drawing.Font("MV Boli", 23.77358F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_score.Location = new System.Drawing.Point(412, 10);
            this.label_score.Name = "label_score";
            this.label_score.Size = new System.Drawing.Size(82, 42);
            this.label_score.TabIndex = 5;
            this.label_score.Text = "0";
            this.label_score.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label_score.Click += new System.EventHandler(this.label_score_Click);
            this.label_score.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label_score_MouseDown);
            this.label_score.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label_score_MouseMove);
            this.label_score.MouseUp += new System.Windows.Forms.MouseEventHandler(this.label_score_MouseUp);
            // 
            // label_score_fix
            // 
            this.label_score_fix.Font = new System.Drawing.Font("MV Boli", 23.77358F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_score_fix.Location = new System.Drawing.Point(290, 10);
            this.label_score_fix.Name = "label_score_fix";
            this.label_score_fix.Size = new System.Drawing.Size(137, 44);
            this.label_score_fix.TabIndex = 2;
            this.label_score_fix.Text = "Score:";
            this.label_score_fix.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_score_fix.Click += new System.EventHandler(this.label_score_fix_Click);
            this.label_score_fix.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label_score_fix_MouseDown);
            this.label_score_fix.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label_score_fix_MouseMove);
            this.label_score_fix.MouseUp += new System.Windows.Forms.MouseEventHandler(this.label_score_fix_MouseUp);
            // 
            // textBox_game
            // 
            this.textBox_game.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_game.Location = new System.Drawing.Point(217, 431);
            this.textBox_game.Name = "textBox_game";
            this.textBox_game.Size = new System.Drawing.Size(535, 27);
            this.textBox_game.TabIndex = 2;
            this.textBox_game.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_game.TextChanged += new System.EventHandler(this.textBox_game_TextChanged);
            this.textBox_game.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_game_KeyDown);
            // 
            // button_q_validate
            // 
            this.button_q_validate.BackColor = System.Drawing.Color.White;
            this.button_q_validate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_q_validate.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_q_validate.FlatAppearance.BorderSize = 0;
            this.button_q_validate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_q_validate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_q_validate.Location = new System.Drawing.Point(758, 431);
            this.button_q_validate.Name = "button_q_validate";
            this.button_q_validate.Size = new System.Drawing.Size(37, 27);
            this.button_q_validate.TabIndex = 7;
            this.button_q_validate.Text = "✔";
            this.button_q_validate.UseVisualStyleBackColor = false;
            this.button_q_validate.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // panel_questions
            // 
            this.panel_questions.Controls.Add(this.button_q_cash);
            this.panel_questions.Controls.Add(this.button_q_carre);
            this.panel_questions.Controls.Add(this.button_RA);
            this.panel_questions.Controls.Add(this.button_RD);
            this.panel_questions.Controls.Add(this.button_RC);
            this.panel_questions.Controls.Add(this.button_RB);
            this.panel_questions.Controls.Add(this.button_q_duo);
            this.panel_questions.Controls.Add(this.label_question);
            this.panel_questions.Location = new System.Drawing.Point(217, 70);
            this.panel_questions.Name = "panel_questions";
            this.panel_questions.Size = new System.Drawing.Size(572, 355);
            this.panel_questions.TabIndex = 9;
            // 
            // button_q_cash
            // 
            this.button_q_cash.Location = new System.Drawing.Point(14, 279);
            this.button_q_cash.Name = "button_q_cash";
            this.button_q_cash.Size = new System.Drawing.Size(548, 66);
            this.button_q_cash.TabIndex = 7;
            this.button_q_cash.Text = "CASH (5 points)";
            this.button_q_cash.UseVisualStyleBackColor = true;
            this.button_q_cash.Click += new System.EventHandler(this.button_q_cash_Click);
            // 
            // button_q_carre
            // 
            this.button_q_carre.Location = new System.Drawing.Point(290, 203);
            this.button_q_carre.Name = "button_q_carre";
            this.button_q_carre.Size = new System.Drawing.Size(272, 66);
            this.button_q_carre.TabIndex = 6;
            this.button_q_carre.Text = "CARRÉ (3 points)";
            this.button_q_carre.UseVisualStyleBackColor = true;
            this.button_q_carre.Click += new System.EventHandler(this.button_q_carre_Click);
            // 
            // button_RA
            // 
            this.button_RA.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_RA.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_RA.Location = new System.Drawing.Point(14, 203);
            this.button_RA.Name = "button_RA";
            this.button_RA.Size = new System.Drawing.Size(269, 66);
            this.button_RA.TabIndex = 0;
            this.button_RA.Text = "button_RA";
            this.button_RA.UseVisualStyleBackColor = true;
            this.button_RA.Click += new System.EventHandler(this.button6_Click);
            // 
            // button_RD
            // 
            this.button_RD.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_RD.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.button_RD.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.button_RD.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.button_RD.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_RD.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_RD.Location = new System.Drawing.Point(290, 279);
            this.button_RD.Name = "button_RD";
            this.button_RD.Size = new System.Drawing.Size(272, 66);
            this.button_RD.TabIndex = 3;
            this.button_RD.Text = "button_RD";
            this.button_RD.UseVisualStyleBackColor = true;
            this.button_RD.Click += new System.EventHandler(this.button_RD_Click);
            // 
            // button_RC
            // 
            this.button_RC.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_RC.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_RC.Location = new System.Drawing.Point(14, 279);
            this.button_RC.Name = "button_RC";
            this.button_RC.Size = new System.Drawing.Size(269, 66);
            this.button_RC.TabIndex = 2;
            this.button_RC.Text = "button_RC";
            this.button_RC.UseVisualStyleBackColor = true;
            this.button_RC.Click += new System.EventHandler(this.button_RC_Click);
            // 
            // button_RB
            // 
            this.button_RB.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_RB.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.button_RB.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.button_RB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.button_RB.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_RB.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_RB.Location = new System.Drawing.Point(290, 203);
            this.button_RB.Name = "button_RB";
            this.button_RB.Size = new System.Drawing.Size(272, 66);
            this.button_RB.TabIndex = 1;
            this.button_RB.Text = "button_RB";
            this.button_RB.UseVisualStyleBackColor = true;
            this.button_RB.Click += new System.EventHandler(this.button_RB_Click);
            // 
            // button_q_duo
            // 
            this.button_q_duo.Location = new System.Drawing.Point(14, 203);
            this.button_q_duo.Name = "button_q_duo";
            this.button_q_duo.Size = new System.Drawing.Size(269, 66);
            this.button_q_duo.TabIndex = 5;
            this.button_q_duo.Text = "DUO (1 point)";
            this.button_q_duo.UseVisualStyleBackColor = true;
            this.button_q_duo.Click += new System.EventHandler(this.button_q_duo_Click);
            // 
            // label_question
            // 
            this.label_question.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_question.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_question.Location = new System.Drawing.Point(10, 15);
            this.label_question.Name = "label_question";
            this.label_question.Size = new System.Drawing.Size(559, 178);
            this.label_question.TabIndex = 4;
            this.label_question.Text = "QUESTION";
            this.label_question.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel_lyrics
            // 
            this.panel_lyrics.Controls.Add(this.label_lyrics);
            this.panel_lyrics.Location = new System.Drawing.Point(217, 70);
            this.panel_lyrics.Name = "panel_lyrics";
            this.panel_lyrics.Size = new System.Drawing.Size(572, 355);
            this.panel_lyrics.TabIndex = 5;
            // 
            // label_lyrics
            // 
            this.label_lyrics.BackColor = System.Drawing.Color.Transparent;
            this.label_lyrics.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_lyrics.Location = new System.Drawing.Point(6, 6);
            this.label_lyrics.Name = "label_lyrics";
            this.label_lyrics.Size = new System.Drawing.Size(560, 343);
            this.label_lyrics.TabIndex = 0;
            this.label_lyrics.Text = "label1";
            this.label_lyrics.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_lyrics.Click += new System.EventHandler(this.label_lyrics_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(217, 70);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(572, 355);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel_name
            // 
            this.panel_name.Controls.Add(this.richTextBox1);
            this.panel_name.Controls.Add(this.button_name_validate);
            this.panel_name.Controls.Add(this.label3);
            this.panel_name.Location = new System.Drawing.Point(217, 70);
            this.panel_name.Name = "panel_name";
            this.panel_name.Size = new System.Drawing.Size(572, 355);
            this.panel_name.TabIndex = 10;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.White;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(10, 144);
            this.richTextBox1.MaxLength = 11;
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox1.Size = new System.Drawing.Size(506, 26);
            this.richTextBox1.TabIndex = 12;
            this.richTextBox1.Text = "PLAYER_NAME";
            this.richTextBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.richTextBox1_KeyDown);
            this.richTextBox1.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.richTextBox1_PreviewKeyDown);
            // 
            // button_name_validate
            // 
            this.button_name_validate.BackColor = System.Drawing.Color.White;
            this.button_name_validate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_name_validate.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_name_validate.FlatAppearance.BorderSize = 0;
            this.button_name_validate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_name_validate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_name_validate.Location = new System.Drawing.Point(521, 144);
            this.button_name_validate.Name = "button_name_validate";
            this.button_name_validate.Size = new System.Drawing.Size(37, 26);
            this.button_name_validate.TabIndex = 11;
            this.button_name_validate.Text = "✔";
            this.button_name_validate.UseVisualStyleBackColor = false;
            this.button_name_validate.Click += new System.EventHandler(this.button_name_validate_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("MV Boli", 23.77358F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(548, 52);
            this.label3.TabIndex = 7;
            this.label3.Text = "Surnom :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(801, 478);
            this.Controls.Add(this.panel_name);
            this.Controls.Add(this.panel_questions);
            this.Controls.Add(this.panel_lyrics);
            this.Controls.Add(this.button_q_validate);
            this.Controls.Add(this.textBox_game);
            this.Controls.Add(this.panel_top);
            this.Controls.Add(this.panel_side);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "POP SAUCE";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel_logo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logo)).EndInit();
            this.panel_side.ResumeLayout(false);
            this.panel_top.ResumeLayout(false);
            this.panel_top.PerformLayout();
            this.panel_questions.ResumeLayout(false);
            this.panel_lyrics.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel_name.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel_logo;
        private System.Windows.Forms.Panel panel_side;
        private System.Windows.Forms.Button button_jouer;
        private System.Windows.Forms.Button button_about;
        private System.Windows.Forms.Button button_classement;
        private System.Windows.Forms.Button button_parametres;
        private Syncfusion.WinForms.Controls.SfButton sfButton1;
        private Syncfusion.WinForms.Controls.SfButton sfButton2;
        private System.Windows.Forms.Panel panel_top;
        private System.Windows.Forms.Label label_score_fix;
        private System.Windows.Forms.TextBox textBox_game;
        private System.Windows.Forms.Button button_q_validate;
        private System.Windows.Forms.Label label_score;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel_questions;
        private System.Windows.Forms.Button button_RD;
        private System.Windows.Forms.Button button_RC;
        private System.Windows.Forms.Button button_RB;
        private System.Windows.Forms.Button button_RA;
        private System.Windows.Forms.Label label_question;
        private System.Windows.Forms.Panel panel_lyrics;
        private System.Windows.Forms.Label label_lyrics;
        private System.Windows.Forms.PictureBox pictureBox_logo;
        private System.Windows.Forms.Label label_player_name;
        private System.Windows.Forms.Button button_q_duo;
        private System.Windows.Forms.Button button_q_carre;
        private System.Windows.Forms.Button button_q_cash;
        private System.Windows.Forms.Panel panel_name;
        private System.Windows.Forms.Button button_name_validate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

