using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Facebook;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using A18_Ex02_LiorBaraban_YuvalGur_BeSocial_Logic;

namespace A18_Ex02_Lior_Yuval
{
    public partial class MainForm : Form
    {
        private BeSocialGameController m_GameController;
        private ActivitiesController m_ActivitiesController;
        private Action m_Publish;
        private LoginResult m_Result;
        private User m_User;
        private List<Control> m_ListOfVisibilityControls;
        private bool m_IsLoggedIn = false;

        public MainForm()
        {
            InitializeComponent();
            FacebookService.s_CollectionLimit = 1000;
            m_ActivitiesController = new ActivitiesController();
            pictureBoxViralPic.BackgroundImageLayout = ImageLayout.Stretch;
            m_Publish = postStatus;
            updateMissionControls();
            createListOfVisibleControls();
        }

        private void createListOfVisibleControls()
        {
            m_ListOfVisibilityControls = new List<Control>();
            m_ListOfVisibilityControls.Add(pictureBoxProfile);
            m_ListOfVisibilityControls.Add(labeUserName);
            m_ListOfVisibilityControls.Add(labelTagAFriend);
            m_ListOfVisibilityControls.Add(listBoxFriends);
            m_ListOfVisibilityControls.Add(buttonUnselectFriend);
            m_ListOfVisibilityControls.Add(pictureBoxSelectedFriend);
            m_ListOfVisibilityControls.Add(labelSelectedFriendName);
            m_ListOfVisibilityControls.Add(radioButtonLink);
            m_ListOfVisibilityControls.Add(radioButtonPicture);
            m_ListOfVisibilityControls.Add(radioButtonPostText);
            m_ListOfVisibilityControls.Add(buttonSelectPicture);
            m_ListOfVisibilityControls.Add(textBoxURL);
            m_ListOfVisibilityControls.Add(labelAddress);
            m_ListOfVisibilityControls.Add(labelPostText);
            m_ListOfVisibilityControls.Add(textBoxPost);
            m_ListOfVisibilityControls.Add(labelCharCount);
            m_ListOfVisibilityControls.Add(labelCounter);
            m_ListOfVisibilityControls.Add(buttonPublish);
            m_ListOfVisibilityControls.Add(labelScore);
            m_ListOfVisibilityControls.Add(buttonFetchViralPhoto);
            m_ListOfVisibilityControls.Add(pictureBoxViralPic);
            m_ListOfVisibilityControls.Add(labelViralLikes);
            m_ListOfVisibilityControls.Add(listBoxAlbums);
            foreach (Control control in m_ListOfVisibilityControls)
            {
                control.Visible = false;
            }
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            try
            {
                bool isWantToBeVisible = false;

                if (m_IsLoggedIn == false)
                {
                    login();
                    m_IsLoggedIn = true;
                    isWantToBeVisible = true;
                    updateVisibilityOfControls(isWantToBeVisible);
                    buttonLogin.Text = "Log Out";
                    MessageBox.Show("Logged in successfully");
                }
                else
                {
                    bool isGameStillRunning = false;
                    if (m_GameController != null)
                    {
                        isGameStillRunning = true;
                    }

                    if (!isGameStillRunning || (isGameStillRunning && isWantToLeaveGame()))
                    {
                        FacebookWrapper.FacebookService.Logout(null);
                        m_IsLoggedIn = false;
                        updateVisibilityOfControls(isWantToBeVisible);
                        clearControls();
                        buttonLogin.Text = "Log In";
                        MessageBox.Show("Logged out successfully");
                    }
                    else
                    {
                        MessageBox.Show("You did not log out. Now you can finish your game");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Oops! something went wrong.");
            }
        }

        private bool isWantToLeaveGame()
        {
            bool isWantToLeave = false;
            DialogResult dialogRes = MessageBox.Show("A game is still running. Are you sure you want to log out?", "Wait", MessageBoxButtons.YesNo);
            if (dialogRes == DialogResult.Yes)
            {
                isWantToLeave = true;
            }

            return isWantToLeave;
        }

        private void clearControls()
        {
            listBoxFriends.Items.Clear();
            labelCounter.Text = null;
            textBoxPost.Text = null;
            textBoxURL.Text = null;
            listBoxAlbums.Items.Clear();
            pictureBoxViralPic.BackgroundImage = null;
            labelViralLikes.Text = null;
        }

        private void updateVisibilityOfControls(bool i_IsWantToBeVisible)
        {
            if (i_IsWantToBeVisible)
            {
                foreach (Control control in m_ListOfVisibilityControls)
                {
                    control.Visible = true;
                }
            }
            else
            {
                foreach (Control control in m_ListOfVisibilityControls)
                {
                    control.Visible = false;
                }
            }
        }

        private void login()
        {
            m_Result = FacebookWrapper.FacebookService.Login(
                "495677157474019",
                "user_education_history",
                "user_birthday",
                "user_actions.video",
                "user_actions.news",
                "user_actions.music",
                "user_actions.fitness",
                "user_actions.books",
                "user_about_me",
                "user_friends",
                "publish_actions",
                "user_events",
                "user_games_activity",
                "user_hometown",
                "user_likes",
                "user_location",
                "user_managed_groups",
                "user_photos",
                "user_posts",
                "user_relationships",
                "user_relationship_details",
                "user_religion_politics",
                "user_tagged_places",
                "user_videos",
                "user_website",
                "user_work_history",
                "read_custom_friendlists",
                "read_page_mailboxes",
                "manage_pages",
                "publish_pages",
                "publish_actions",
                "rsvp_event");

            m_User = m_Result.LoggedInUser;
            updateLoginProfile();
        }

        private void updateLoginProfile()
        {
            pictureBoxProfile.Image = m_User.ImageNormal;
            labeUserName.Text = string.Format("{0},{1}", m_User.FirstName, m_User.LastName);
            updateLists();
        }

        private void updateLists()
        {
            listBoxFriends.DisplayMember = "Name";
            foreach (User friend in m_User.Friends)
            {
                listBoxFriends.Items.Add(friend);
            }

            if (m_User.Friends.Count == 0)
            {
                MessageBox.Show("No Friends to display");
            }

            listBoxAlbums.DisplayMember = "Name";
            foreach (Album album in m_User.Albums)
            {
                listBoxAlbums.Items.Add(album);
            }

            if (m_User.Albums.Count == 0)
            {
                MessageBox.Show("No Albums to display");
            }
        }

        private void listBoxFriends_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (m_GameController != null)
            {
                m_GameController.Model.SelectedFriend = (sender as ListBox).SelectedItem as User;
            }

            displaySelectedFriend();
        }

        private void buttonUnselectFriend_Click(object sender, EventArgs e)
        {
            try
            {
                if (m_User == null)
                {
                    throw new Exception("You must be logged in first");
                }

                listBoxFriends.ClearSelected();
                if (m_GameController != null)
                {
                    m_GameController.Model.SelectedFriend = null;
                }

                displaySelectedFriend();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Oops! Something went wrong");
            }
        }

        private void displaySelectedFriend()
        {
            if (listBoxFriends.SelectedItems.Count == 1)
            {
                User selectedFriend = listBoxFriends.SelectedItem as User;
                if (selectedFriend.PictureNormalURL != null)
                {
                    pictureBoxSelectedFriend.LoadAsync(selectedFriend.PictureNormalURL);
                    labelSelectedFriendName.Text = selectedFriend.Name;
                }
                else
                {
                    pictureBoxSelectedFriend.Image = pictureBoxSelectedFriend.ErrorImage;
                }
            }
            else
            {
                pictureBoxSelectedFriend.Image = null;
                labelSelectedFriendName.Text = null;
            }
        }

        private void buttonStartGame_Click(object sender, EventArgs e)
        {
            try
            {
                if (m_User == null)
                {
                    throw new Exception("You must log in first!");
                }

                startGame();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Something went wrong");
            }
        }

        private void startGame()
        {
            createANewGameController();
            updateMissionControls();
        }

        private void createANewGameController()
        {
            m_GameController = new BeSocialGameController(
                new GameModel
                {
                    PostText = textBoxPost.Text,
                    SelectedFriend = listBoxFriends.SelectedItem as User,
                    PictureUrl = null,
                    LinkUrl = null
                });
            if (!string.IsNullOrEmpty(textBoxURL.Text))
            {
                if (radioButtonLink.Checked == true)
                {
                    m_GameController.Model.LinkUrl = textBoxURL.Text;
                }
                else if (radioButtonPicture.Checked == true)
                {
                    m_GameController.Model.PictureUrl = textBoxURL.Text;
                }
            }
        }

        private void buttonEndGame_Click(object sender, EventArgs e)
        {
            try
            {
                if (m_GameController == null)
                {
                    throw new Exception("The game must be started first");
                }

                bool isVictory = false;
                string message = string.Format(
@"You've decided to end the game.
Your score is {0}.
See you next time",
m_GameController.PlayerScore);
finishGame(isVictory, message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Oops, something went wrong");
            }
        }

        private void buttonSkipMission_Click(object sender, EventArgs e)
        {
            try
            {
                if (m_GameController == null)
                {
                    throw new Exception("The game must be started first");
                }

                string msgBody = @"Are you sure you want to skip this mission?
You won't get any points!";
                DialogResult msgResult = MessageBox.Show(msgBody, "Wait", MessageBoxButtons.YesNo);
                if (msgResult == DialogResult.Yes)
                {
                    startNextRound(false);
                    updateMissionControls();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Oops, something went wrong");
            }
        }

        private void startNextRound(bool i_IsFulfilled)
        {
            if (i_IsFulfilled)
            {
                m_GameController.RewardPoints();
            }

            if (m_GameController.IsReachedMaxPoints() || m_GameController.CurrentMissionNode.Next == null)
            {
                bool isVictory;
                string finishMessage = null;
                if (m_GameController.IsReachedMaxPoints())
                {
                    isVictory = true;
                    finishMessage = string.Format(@"Congrats! you have beaten the game with the score: {0}", m_GameController.PlayerScore);
                }
                else
                {
                    isVictory = false;
                    string.Format(
@"Sorry, you've reached the end of the game but didn't beat it.
You only needed {0} nore points.",
m_GameController.MaxScore - m_GameController.PlayerScore);
                }

                finishGame(isVictory, finishMessage);
            }
            else
            {
                m_GameController.SkipToNextMission();
            }
        }

        private void finishGame(bool i_IsVictory, string i_FinishMessage)
        {
            updateMissionControls();
            MessageBox.Show(i_FinishMessage);
            if (i_IsVictory)
            {
                shareScore();
            }

            m_GameController = null;
            updateMissionControls();
        }

        private void shareScore()
        {
            string message = "Do you want to share your final score in BeMoreSocial?";
            DialogResult messageResult = MessageBox.Show(message, null, MessageBoxButtons.YesNo);
            if (messageResult == DialogResult.Yes)
            {
                string post = string.Format(@"I Finished BeMoreSocial and scored {0} Points!", m_GameController.PlayerScore);
                m_User.PostStatus(post);
                MessageBox.Show(@"Your BeMoreSocial score was shared! 
See you next time!");
            }
            else
            {
                MessageBox.Show(@"Okay, See you next time!");
            }
        }

        private void updateMissionControls()
        {
            string strMessage = null;
            if (m_GameController == null)
            {
                labelMissionDescription.Text = @"Welcome to BeMoreSocial!
The game that will make you more social and viral in your social network.

Your goal is to reach a total of 10 or more social points per game.
You earn points by doing social 'missions' that the app tells you to do.

Press 'Start Game' whenever You're ready to play. Good Luck!";
                labelScore.Text = null;
            }
            else
            {
                if (m_GameController.CurrentMissionNode != null)
                {
                    strMessage = m_GameController.CurrentMission.Description;
                }
                else
                {
                    strMessage = string.Format("The game has ended. your score is {0}", m_GameController.PlayerScore);
                }

                labelScore.Text = string.Format("Current Game Score: {0}", m_GameController.PlayerScore.ToString());
                labelMissionDescription.Text = strMessage;
                textBoxPost.Text = null;
                textBoxURL.Text = null;
                listBoxFriends.ClearSelected();
                displaySelectedFriend();
            }
        }

        private void radioButtonPostText_CheckedChanged(object sender, EventArgs e)
        {
            labelAddress.Text = string.Empty;
            textBoxURL.Enabled = false;
            textBoxURL.Text = string.Empty;
            buttonSelectPicture.Enabled = false;
            labelPostText.Text = "Post Text:";
            m_Publish = postStatus;
        }

        private void radioButtonLink_CheckedChanged(object sender, EventArgs e)
        {
            labelAddress.Text = "Online Picture / Link Address:";
            textBoxURL.Enabled = true;
            textBoxURL.Text = string.Empty;
            buttonSelectPicture.Enabled = false;
            buttonSelectPicture.Enabled = false;
            labelPostText.Text = "Additional Text:";
            m_Publish = postStatus;
        }

        private void radioButtonPicture_CheckedChanged(object sender, EventArgs e)
        {
            labelAddress.Text = "Local Picture Address:";
            textBoxURL.Enabled = true;
            textBoxURL.Text = string.Empty;
            buttonSelectPicture.Enabled = true;
            labelPostText.Text = "Picture Title:";
            m_Publish = postPicture;
        }

        private void buttonSelectPicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Image files (*.jpg, *.jpeg, *.png, *.gif) | *.jpg; *.jpeg; *.png; *.gif;";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                textBoxURL.Text = openFile.FileName;
            }
        }

        private void textBoxURL_TextChanged(object sender, EventArgs e)
        {
            if (m_GameController != null)
            {
                if (radioButtonLink.Checked == true)
                {
                    m_GameController.Model.LinkUrl = textBoxURL.Text;
                    m_GameController.Model.PictureUrl = null;
                }
                else if (radioButtonPicture.Checked == true)
                {
                    m_GameController.Model.LinkUrl = null;
                    m_GameController.Model.PictureUrl = textBoxURL.Text;
                }
                else if (radioButtonPostText.Checked == true)
                {
                    m_GameController.Model.LinkUrl = null;
                    m_GameController.Model.PictureUrl = null;
                }
            }
        }

        private void textBoxPost_TextChanged(object sender, EventArgs e)
        {
            if (m_GameController != null)
            {
                m_GameController.Model.PostText = textBoxPost.Text;
            }

            labelCounter.Text = textBoxPost.TextLength.ToString();
        }

        private void postStatus()
        {
            StringBuilder statusText = new StringBuilder();
            statusText.Append(m_GameController.Model.PostText);
            if (m_GameController.IsCurrentMissionFullfilled())
            {
                statusText.Append(Environment.NewLine);
                statusText.Append(string.Format("I Won {0} points in BeMoreSocial", m_GameController.CurrentMission.ScoreValue));
            }

            string taggedFriendId = null;
            if (m_GameController.Model.SelectedFriend != null)
            {
                taggedFriendId = m_GameController.Model.SelectedFriend.Id;
            }

            string linkURL = m_GameController.Model.LinkUrl;
            try
            {
                if (string.IsNullOrEmpty(statusText.ToString()) && string.IsNullOrEmpty(taggedFriendId) && string.IsNullOrEmpty(linkURL))
                {
                    throw new Exception("Not enough parameters to publish any kind of post!");
                }

                m_User.PostStatus(statusText.ToString(), null, null, taggedFriendId, linkURL);
                MessageBox.Show("Posted a status to facebook");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Oops, Something went wrong!");
            }
        }

        private void postPicture()
        {
            string photoURL = m_GameController.Model.PictureUrl;
            string photoDescription = m_GameController.Model.PostText;
            try
            {
                m_User.PostPhoto(photoURL, photoDescription, null);
                MessageBox.Show("Posted a photo to facebook");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonPublish_Click(object sender, EventArgs e)
        {
            try
            {
                if (m_User == null)
                {
                    throw new Exception("You have to be logged in first!");
                }

                if (m_GameController == null)
                {
                    throw new Exception("You have to Start the game first!");
                }

                if (isWantToUploadToFacebook())
                {
                    m_Publish();
                    startNextRound(m_GameController.IsCurrentMissionFullfilled());
                    updateMissionControls();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Oops! something went wrong...");
            }
        }

        private bool isWantToUploadToFacebook()
        {
            bool isWantToUpload = false;
            string inner, title;
            if (m_GameController.IsCurrentMissionFullfilled())
            {
                title = "Good Work!";
                inner = string.Format(
@"Good work! Mission is about to complete!

If you upload it to facebook you will get {0} points!

Do you wish to upload to Facebook and get the points?",
m_GameController.CurrentMission.ScoreValue);
            }
            else
            {
                title = "Not good...";
                inner = @"Sorry, You didn't follow the instructions.

If you decide to publish to Facebook you won't get any points. 

Do you still wish to continue and upload to facebook?";
            }

            DialogResult msgResult = MessageBox.Show(inner, title, MessageBoxButtons.YesNo);
            if (msgResult == DialogResult.Yes)
            {
                isWantToUpload = true;
            }

            return isWantToUpload;
        }

        private void buttonFetchViralActivity_Click(object sender, EventArgs e)
        {
            try
            {
                if (listBoxAlbums.SelectedIndex < 0)
                {
                    throw new Exception("You must choose an album first");
                }

                if (m_User == null)
                {
                    throw new Exception("You must be logged in first");
                }

                if ((listBoxAlbums.SelectedItem as Album).Photos.Count == 0)
                {
                    throw new Exception("No photos in this album. Please select another one");
                }

                m_ActivitiesController.ActivityCollection = ((listBoxAlbums.SelectedItem as Album).Photos as IEnumerable<PostedItem>).ToList();

                // activity collection is of type posted item to support other "most liked" facebook types in the future besides posts.
                PostedItem mostViralItem = m_ActivitiesController.GetViralActivity();
                if (mostViralItem is Photo)
                {
                    pictureBoxViralPic.BackgroundImage = (mostViralItem as Photo).ImageNormal;
                    if ((mostViralItem as Photo).LikedBy.Count > 0)
                    {
                        labelViralLikes.Text = string.Format("Likes: {0}", (mostViralItem as Photo).LikedBy.Count.ToString());
                    }
                    else
                    {
                        labelViralLikes.Text = "No likes";
                    }
                }

                checkIfWantToShareMostViral(mostViralItem);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void checkIfWantToShareMostViral(PostedItem i_MostViralItem)
        {
            DialogResult messageResult = MessageBox.Show("Do you want to share this on facebook?", string.Empty, MessageBoxButtons.YesNo);
            if (messageResult == DialogResult.Yes)
            {
                try
                {
                    string msg = string.Format(
@"This was my most viral photo in '{0}' album.
It got {1} Likes!",
(i_MostViralItem as Photo).Album.Name,
(i_MostViralItem as Photo).LikedBy.Count.ToString());
                    string linkUrl = (i_MostViralItem as Photo).Link;
                    m_User.PostStatus(msg, null, null, null, linkUrl);
                    MessageBox.Show("Posted to facebook!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Oops, Something went wrong!");
                }
            }
            else
            {
                MessageBox.Show("Okay, did not post");
            }
        }
    }
}
