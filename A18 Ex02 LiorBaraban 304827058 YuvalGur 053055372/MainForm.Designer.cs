namespace A18_Ex02_Lior_Yuval
{
    public partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.labelCharCount = new System.Windows.Forms.Label();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.pictureBoxProfile = new System.Windows.Forms.PictureBox();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labeUserName = new System.Windows.Forms.Label();
            this.panelUpLeft = new System.Windows.Forms.Panel();
            this.labelTagAFriend = new System.Windows.Forms.Label();
            this.buttonUnselectFriend = new System.Windows.Forms.Button();
            this.pictureBoxSelectedFriend = new System.Windows.Forms.PictureBox();
            this.friendListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listBoxFriends = new System.Windows.Forms.ListBox();
            this.labelSelectedFriendName = new System.Windows.Forms.TextBox();
            this.buttonStartGame = new System.Windows.Forms.Button();
            this.buttonEndGame = new System.Windows.Forms.Button();
            this.labelMissionDescription = new System.Windows.Forms.Label();
            this.labelScore = new System.Windows.Forms.Label();
            this.buttonSkipMission = new System.Windows.Forms.Button();
            this.panelFeature1 = new System.Windows.Forms.Panel();
            this.labelFeature1 = new System.Windows.Forms.Label();
            this.labelPostText = new System.Windows.Forms.Label();
            this.radioButtonPostText = new System.Windows.Forms.RadioButton();
            this.labelAddress = new System.Windows.Forms.Label();
            this.radioButtonPicture = new System.Windows.Forms.RadioButton();
            this.radioButtonLink = new System.Windows.Forms.RadioButton();
            this.labelCounter = new System.Windows.Forms.TextBox();
            this.textBoxPost = new System.Windows.Forms.RichTextBox();
            this.buttonPublish = new System.Windows.Forms.Button();
            this.textBoxURL = new System.Windows.Forms.TextBox();
            this.buttonSelectPicture = new System.Windows.Forms.Button();
            this.panelFeature2 = new System.Windows.Forms.Panel();
            this.listBoxAlbums = new System.Windows.Forms.ListBox();
            this.albumsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.labelViralLikes = new System.Windows.Forms.Label();
            this.pictureBoxViralPic = new System.Windows.Forms.PictureBox();
            this.labelFeature2 = new System.Windows.Forms.Label();
            this.buttonFetchViralPhoto = new System.Windows.Forms.Button();
            this.albumsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            this.panelUpLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSelectedFriend)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.friendListBindingSource)).BeginInit();
            this.panelFeature1.SuspendLayout();
            this.panelFeature2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.albumsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxViralPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // labelCharCount
            // 
            this.labelCharCount.AutoSize = true;
            this.labelCharCount.Location = new System.Drawing.Point(635, 536);
            this.labelCharCount.Name = "labelCharCount";
            this.labelCharCount.Size = new System.Drawing.Size(62, 13);
            this.labelCharCount.TabIndex = 13;
            this.labelCharCount.Text = "Char count:";
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(14, 20);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(1);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(81, 30);
            this.buttonLogin.TabIndex = 0;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // pictureBoxProfile
            // 
            this.pictureBoxProfile.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.userBindingSource, "ImageNormal", true));
            this.pictureBoxProfile.Location = new System.Drawing.Point(131, 20);
            this.pictureBoxProfile.Margin = new System.Windows.Forms.Padding(1);
            this.pictureBoxProfile.Name = "pictureBoxProfile";
            this.pictureBoxProfile.Size = new System.Drawing.Size(86, 96);
            this.pictureBoxProfile.TabIndex = 1;
            this.pictureBoxProfile.TabStop = false;
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.User);
            // 
            // labeUserName
            // 
            this.labeUserName.AutoSize = true;
            this.labeUserName.Location = new System.Drawing.Point(255, 93);
            this.labeUserName.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labeUserName.Name = "labeUserName";
            this.labeUserName.Size = new System.Drawing.Size(57, 13);
            this.labeUserName.TabIndex = 3;
            this.labeUserName.Text = "UserName";
            // 
            // panelUpLeft
            // 
            this.panelUpLeft.Controls.Add(this.buttonLogin);
            this.panelUpLeft.Controls.Add(this.labeUserName);
            this.panelUpLeft.Controls.Add(this.pictureBoxProfile);
            this.panelUpLeft.Location = new System.Drawing.Point(0, 0);
            this.panelUpLeft.Margin = new System.Windows.Forms.Padding(1);
            this.panelUpLeft.Name = "panelUpLeft";
            this.panelUpLeft.Size = new System.Drawing.Size(487, 130);
            this.panelUpLeft.TabIndex = 4;
            // 
            // labelTagAFriend
            // 
            this.labelTagAFriend.AutoSize = true;
            this.labelTagAFriend.Location = new System.Drawing.Point(38, 234);
            this.labelTagAFriend.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelTagAFriend.Name = "labelTagAFriend";
            this.labelTagAFriend.Size = new System.Drawing.Size(108, 13);
            this.labelTagAFriend.TabIndex = 4;
            this.labelTagAFriend.Text = "Select a friend to tag:";
            // 
            // buttonUnselectFriend
            // 
            this.buttonUnselectFriend.Location = new System.Drawing.Point(40, 421);
            this.buttonUnselectFriend.Margin = new System.Windows.Forms.Padding(1);
            this.buttonUnselectFriend.Name = "buttonUnselectFriend";
            this.buttonUnselectFriend.Size = new System.Drawing.Size(98, 30);
            this.buttonUnselectFriend.TabIndex = 4;
            this.buttonUnselectFriend.Text = "Unselect Friend";
            this.buttonUnselectFriend.UseVisualStyleBackColor = true;
            this.buttonUnselectFriend.Click += new System.EventHandler(this.buttonUnselectFriend_Click);
            // 
            // pictureBoxSelectedFriend
            // 
            this.pictureBoxSelectedFriend.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.friendListBindingSource, "ImageNormal", true));
            this.pictureBoxSelectedFriend.Location = new System.Drawing.Point(283, 260);
            this.pictureBoxSelectedFriend.Name = "pictureBoxSelectedFriend";
            this.pictureBoxSelectedFriend.Size = new System.Drawing.Size(150, 150);
            this.pictureBoxSelectedFriend.TabIndex = 6;
            this.pictureBoxSelectedFriend.TabStop = false;
            // 
            // friendListBindingSource
            // 
            this.friendListBindingSource.DataMember = "Members";
            this.friendListBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.FriendList);
            // 
            // listBoxFriends
            // 
            this.listBoxFriends.DataSource = this.friendListBindingSource;
            this.listBoxFriends.DisplayMember = "Name";
            this.listBoxFriends.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.listBoxFriends.FormattingEnabled = true;
            this.listBoxFriends.ItemHeight = 16;
            this.listBoxFriends.Location = new System.Drawing.Point(40, 260);
            this.listBoxFriends.Name = "listBoxFriends";
            this.listBoxFriends.Size = new System.Drawing.Size(232, 148);
            this.listBoxFriends.TabIndex = 4;
            this.listBoxFriends.ValueMember = "Id";
            // 
            // labelSelectedFriendName
            // 
            this.labelSelectedFriendName.BackColor = System.Drawing.SystemColors.Control;
            this.labelSelectedFriendName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.labelSelectedFriendName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.friendListBindingSource, "Name", true));
            this.labelSelectedFriendName.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.friendListBindingSource, "Name", true));
            this.labelSelectedFriendName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelSelectedFriendName.Location = new System.Drawing.Point(283, 416);
            this.labelSelectedFriendName.Name = "labelSelectedFriendName";
            this.labelSelectedFriendName.Size = new System.Drawing.Size(150, 15);
            this.labelSelectedFriendName.TabIndex = 3;
            // 
            // buttonStartGame
            // 
            this.buttonStartGame.Location = new System.Drawing.Point(704, 13);
            this.buttonStartGame.Name = "buttonStartGame";
            this.buttonStartGame.Size = new System.Drawing.Size(111, 23);
            this.buttonStartGame.TabIndex = 5;
            this.buttonStartGame.Text = "Start Game";
            this.buttonStartGame.UseVisualStyleBackColor = true;
            this.buttonStartGame.Click += new System.EventHandler(this.buttonStartGame_Click);
            // 
            // buttonEndGame
            // 
            this.buttonEndGame.Location = new System.Drawing.Point(704, 93);
            this.buttonEndGame.Name = "buttonEndGame";
            this.buttonEndGame.Size = new System.Drawing.Size(111, 23);
            this.buttonEndGame.TabIndex = 4;
            this.buttonEndGame.Text = "End Game";
            this.buttonEndGame.UseVisualStyleBackColor = true;
            this.buttonEndGame.Click += new System.EventHandler(this.buttonEndGame_Click);
            // 
            // labelMissionDescription
            // 
            this.labelMissionDescription.AutoSize = true;
            this.labelMissionDescription.Location = new System.Drawing.Point(12, 43);
            this.labelMissionDescription.Name = "labelMissionDescription";
            this.labelMissionDescription.Size = new System.Drawing.Size(95, 13);
            this.labelMissionDescription.TabIndex = 3;
            this.labelMissionDescription.Text = "MissionDescription";
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.Location = new System.Drawing.Point(516, 60);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(0, 13);
            this.labelScore.TabIndex = 2;
            // 
            // buttonSkipMission
            // 
            this.buttonSkipMission.Location = new System.Drawing.Point(704, 52);
            this.buttonSkipMission.Name = "buttonSkipMission";
            this.buttonSkipMission.Size = new System.Drawing.Size(111, 23);
            this.buttonSkipMission.TabIndex = 1;
            this.buttonSkipMission.Text = "Skip Mission";
            this.buttonSkipMission.UseVisualStyleBackColor = true;
            this.buttonSkipMission.Click += new System.EventHandler(this.buttonSkipMission_Click);
            // 
            // panelFeature1
            // 
            this.panelFeature1.Controls.Add(this.labelFeature1);
            this.panelFeature1.Controls.Add(this.buttonStartGame);
            this.panelFeature1.Controls.Add(this.labelTagAFriend);
            this.panelFeature1.Controls.Add(this.buttonEndGame);
            this.panelFeature1.Controls.Add(this.labelPostText);
            this.panelFeature1.Controls.Add(this.labelMissionDescription);
            this.panelFeature1.Controls.Add(this.buttonUnselectFriend);
            this.panelFeature1.Controls.Add(this.labelScore);
            this.panelFeature1.Controls.Add(this.radioButtonPostText);
            this.panelFeature1.Controls.Add(this.buttonSkipMission);
            this.panelFeature1.Controls.Add(this.pictureBoxSelectedFriend);
            this.panelFeature1.Controls.Add(this.labelAddress);
            this.panelFeature1.Controls.Add(this.listBoxFriends);
            this.panelFeature1.Controls.Add(this.labelSelectedFriendName);
            this.panelFeature1.Controls.Add(this.radioButtonPicture);
            this.panelFeature1.Controls.Add(this.radioButtonLink);
            this.panelFeature1.Controls.Add(this.labelCounter);
            this.panelFeature1.Controls.Add(this.labelCharCount);
            this.panelFeature1.Controls.Add(this.textBoxPost);
            this.panelFeature1.Controls.Add(this.buttonPublish);
            this.panelFeature1.Controls.Add(this.textBoxURL);
            this.panelFeature1.Controls.Add(this.buttonSelectPicture);
            this.panelFeature1.Location = new System.Drawing.Point(489, 0);
            this.panelFeature1.Name = "panelFeature1";
            this.panelFeature1.Size = new System.Drawing.Size(827, 679);
            this.panelFeature1.TabIndex = 11;
            // 
            // labelFeature1
            // 
            this.labelFeature1.AutoSize = true;
            this.labelFeature1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelFeature1.Location = new System.Drawing.Point(12, 12);
            this.labelFeature1.Name = "labelFeature1";
            this.labelFeature1.Size = new System.Drawing.Size(277, 20);
            this.labelFeature1.TabIndex = 6;
            this.labelFeature1.Text = "Feature #1 - BeMoreSocial Game";
            // 
            // labelPostText
            // 
            this.labelPostText.AutoSize = true;
            this.labelPostText.Location = new System.Drawing.Point(38, 471);
            this.labelPostText.Name = "labelPostText";
            this.labelPostText.Size = new System.Drawing.Size(55, 13);
            this.labelPostText.TabIndex = 18;
            this.labelPostText.Text = "Post Text:";
            // 
            // radioButtonPostText
            // 
            this.radioButtonPostText.AutoSize = true;
            this.radioButtonPostText.Checked = true;
            this.radioButtonPostText.Location = new System.Drawing.Point(40, 143);
            this.radioButtonPostText.Margin = new System.Windows.Forms.Padding(1);
            this.radioButtonPostText.Name = "radioButtonPostText";
            this.radioButtonPostText.Size = new System.Drawing.Size(94, 17);
            this.radioButtonPostText.TabIndex = 17;
            this.radioButtonPostText.TabStop = true;
            this.radioButtonPostText.Text = "Post Text Only";
            this.radioButtonPostText.UseVisualStyleBackColor = true;
            this.radioButtonPostText.CheckedChanged += new System.EventHandler(this.radioButtonPostText_CheckedChanged);
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new System.Drawing.Point(295, 138);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(0, 13);
            this.labelAddress.TabIndex = 6;
            // 
            // radioButtonPicture
            // 
            this.radioButtonPicture.AutoSize = true;
            this.radioButtonPicture.Location = new System.Drawing.Point(40, 192);
            this.radioButtonPicture.Margin = new System.Windows.Forms.Padding(1);
            this.radioButtonPicture.Name = "radioButtonPicture";
            this.radioButtonPicture.Size = new System.Drawing.Size(124, 17);
            this.radioButtonPicture.TabIndex = 16;
            this.radioButtonPicture.Text = "Upload Local Picture";
            this.radioButtonPicture.UseVisualStyleBackColor = true;
            this.radioButtonPicture.CheckedChanged += new System.EventHandler(this.radioButtonPicture_CheckedChanged);
            // 
            // radioButtonLink
            // 
            this.radioButtonLink.AutoSize = true;
            this.radioButtonLink.Location = new System.Drawing.Point(40, 168);
            this.radioButtonLink.Margin = new System.Windows.Forms.Padding(1);
            this.radioButtonLink.Name = "radioButtonLink";
            this.radioButtonLink.Size = new System.Drawing.Size(153, 17);
            this.radioButtonLink.TabIndex = 15;
            this.radioButtonLink.Text = "Share Online Picture / Link";
            this.radioButtonLink.UseVisualStyleBackColor = true;
            this.radioButtonLink.CheckedChanged += new System.EventHandler(this.radioButtonLink_CheckedChanged);
            // 
            // labelCounter
            // 
            this.labelCounter.BackColor = System.Drawing.SystemColors.Control;
            this.labelCounter.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.labelCounter.Location = new System.Drawing.Point(708, 536);
            this.labelCounter.Name = "labelCounter";
            this.labelCounter.Size = new System.Drawing.Size(41, 13);
            this.labelCounter.TabIndex = 14;
            // 
            // textBoxPost
            // 
            this.textBoxPost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.textBoxPost.Location = new System.Drawing.Point(40, 492);
            this.textBoxPost.Name = "textBoxPost";
            this.textBoxPost.Size = new System.Drawing.Size(541, 132);
            this.textBoxPost.TabIndex = 4;
            this.textBoxPost.Text = "";
            this.textBoxPost.TextChanged += new System.EventHandler(this.textBoxPost_TextChanged);
            // 
            // buttonPublish
            // 
            this.buttonPublish.Location = new System.Drawing.Point(638, 562);
            this.buttonPublish.Name = "buttonPublish";
            this.buttonPublish.Size = new System.Drawing.Size(111, 23);
            this.buttonPublish.TabIndex = 3;
            this.buttonPublish.Text = "Publish";
            this.buttonPublish.UseVisualStyleBackColor = true;
            this.buttonPublish.Click += new System.EventHandler(this.buttonPublish_Click);
            // 
            // textBoxURL
            // 
            this.textBoxURL.Enabled = false;
            this.textBoxURL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.textBoxURL.Location = new System.Drawing.Point(297, 158);
            this.textBoxURL.Name = "textBoxURL";
            this.textBoxURL.Size = new System.Drawing.Size(454, 22);
            this.textBoxURL.TabIndex = 7;
            this.textBoxURL.TextChanged += new System.EventHandler(this.textBoxURL_TextChanged);
            // 
            // buttonSelectPicture
            // 
            this.buttonSelectPicture.Enabled = false;
            this.buttonSelectPicture.Location = new System.Drawing.Point(638, 186);
            this.buttonSelectPicture.Name = "buttonSelectPicture";
            this.buttonSelectPicture.Size = new System.Drawing.Size(111, 23);
            this.buttonSelectPicture.TabIndex = 4;
            this.buttonSelectPicture.Text = "Select Picture";
            this.buttonSelectPicture.UseVisualStyleBackColor = true;
            this.buttonSelectPicture.Click += new System.EventHandler(this.buttonSelectPicture_Click);
            // 
            // panelFeature2
            // 
            this.panelFeature2.Controls.Add(this.listBoxAlbums);
            this.panelFeature2.Controls.Add(this.labelViralLikes);
            this.panelFeature2.Controls.Add(this.pictureBoxViralPic);
            this.panelFeature2.Controls.Add(this.labelFeature2);
            this.panelFeature2.Controls.Add(this.buttonFetchViralPhoto);
            this.panelFeature2.Location = new System.Drawing.Point(0, 249);
            this.panelFeature2.Name = "panelFeature2";
            this.panelFeature2.Size = new System.Drawing.Size(487, 918);
            this.panelFeature2.TabIndex = 10;
            // 
            // listBoxAlbums
            // 
            this.listBoxAlbums.DataSource = this.albumsBindingSource1;
            this.listBoxAlbums.DisplayMember = "Name";
            this.listBoxAlbums.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.listBoxAlbums.FormattingEnabled = true;
            this.listBoxAlbums.ItemHeight = 16;
            this.listBoxAlbums.Location = new System.Drawing.Point(14, 102);
            this.listBoxAlbums.Name = "listBoxAlbums";
            this.listBoxAlbums.Size = new System.Drawing.Size(149, 100);
            this.listBoxAlbums.TabIndex = 19;
            this.listBoxAlbums.ValueMember = "Albums";
            // 
            // albumsBindingSource1
            // 
            this.albumsBindingSource1.DataMember = "Albums";
            this.albumsBindingSource1.DataSource = this.userBindingSource;
            // 
            // labelViralLikes
            // 
            this.labelViralLikes.AutoSize = true;
            this.labelViralLikes.Location = new System.Drawing.Point(184, 236);
            this.labelViralLikes.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelViralLikes.Name = "labelViralLikes";
            this.labelViralLikes.Size = new System.Drawing.Size(0, 13);
            this.labelViralLikes.TabIndex = 4;
            // 
            // pictureBoxViralPic
            // 
            this.pictureBoxViralPic.Location = new System.Drawing.Point(186, 102);
            this.pictureBoxViralPic.Margin = new System.Windows.Forms.Padding(1);
            this.pictureBoxViralPic.Name = "pictureBoxViralPic";
            this.pictureBoxViralPic.Size = new System.Drawing.Size(125, 119);
            this.pictureBoxViralPic.TabIndex = 4;
            this.pictureBoxViralPic.TabStop = false;
            // 
            // labelFeature2
            // 
            this.labelFeature2.AutoSize = true;
            this.labelFeature2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelFeature2.Location = new System.Drawing.Point(10, 59);
            this.labelFeature2.Name = "labelFeature2";
            this.labelFeature2.Size = new System.Drawing.Size(404, 20);
            this.labelFeature2.TabIndex = 20;
            this.labelFeature2.Text = "Feature #2 - Find and Share my most viral picture";
            // 
            // buttonFetchViralPhoto
            // 
            this.buttonFetchViralPhoto.Location = new System.Drawing.Point(14, 240);
            this.buttonFetchViralPhoto.Margin = new System.Windows.Forms.Padding(1);
            this.buttonFetchViralPhoto.Name = "buttonFetchViralPhoto";
            this.buttonFetchViralPhoto.Size = new System.Drawing.Size(147, 30);
            this.buttonFetchViralPhoto.TabIndex = 25;
            this.buttonFetchViralPhoto.Text = "Get my viral picture";
            this.buttonFetchViralPhoto.UseVisualStyleBackColor = true;
            this.buttonFetchViralPhoto.Click += new System.EventHandler(this.buttonFetchViralActivity_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1082, 460);
            this.Controls.Add(this.panelFeature2);
            this.Controls.Add(this.panelFeature1);
            this.Controls.Add(this.panelUpLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            this.panelUpLeft.ResumeLayout(false);
            this.panelUpLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSelectedFriend)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.friendListBindingSource)).EndInit();
            this.panelFeature1.ResumeLayout(false);
            this.panelFeature1.PerformLayout();
            this.panelFeature2.ResumeLayout(false);
            this.panelFeature2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.albumsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxViralPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.PictureBox pictureBoxProfile;
        private System.Windows.Forms.Label labeUserName;
        private System.Windows.Forms.Panel panelUpLeft;
        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.Button buttonSkipMission;
        private System.Windows.Forms.PictureBox pictureBoxSelectedFriend;
        private System.Windows.Forms.ListBox listBoxFriends;
        private System.Windows.Forms.TextBox labelSelectedFriendName;
        private System.Windows.Forms.Panel panelFeature1;
        private System.Windows.Forms.Button buttonPublish;
        private System.Windows.Forms.Panel panelFeature2;
        private System.Windows.Forms.Button buttonSelectPicture;
        private System.Windows.Forms.TextBox textBoxURL;
        private System.Windows.Forms.RichTextBox textBoxPost;
        private System.Windows.Forms.TextBox labelCounter;
        private System.Windows.Forms.Label labelMissionDescription;
        private System.Windows.Forms.Button buttonEndGame;
        private System.Windows.Forms.Button buttonStartGame;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.RadioButton radioButtonPicture;
        private System.Windows.Forms.RadioButton radioButtonLink;
        private System.Windows.Forms.RadioButton radioButtonPostText;
        private System.Windows.Forms.Label labelPostText;
        private System.Windows.Forms.Button buttonUnselectFriend;
        private System.Windows.Forms.Label labelCharCount;
        private System.Windows.Forms.Label labelTagAFriend;
        private System.Windows.Forms.Button buttonFetchViralPhoto;
        private System.Windows.Forms.Label labelFeature1;
        private System.Windows.Forms.Label labelFeature2;
        private System.Windows.Forms.BindingSource albumsBindingSource;
        private System.Windows.Forms.Label labelViralLikes;
        private System.Windows.Forms.PictureBox pictureBoxViralPic;
        private System.Windows.Forms.ListBox listBoxAlbums;
        private System.Windows.Forms.BindingSource friendListBindingSource;
        private System.Windows.Forms.BindingSource albumsBindingSource1;
        private System.Windows.Forms.BindingSource userBindingSource;
    }
}