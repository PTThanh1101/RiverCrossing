namespace RiverCrossing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Initialize selectedCharacterTime for each character



            Timelabel.Text = remainingTime.ToString();

        }


        private Point oneStartLocation = new Point(369, 436);
        private Point oneBoatStartLocation = new Point(856, 489);
        private Point oneBoatEndLocation = new Point(1205, 489);
        private Point oneEndLocation = new Point(1663, 436);

        private Point threeStartLocation = new Point(279, 436);
        private Point threeBoatStartLocation = new Point(787, 489);
        private Point threeBoatEndLocation = new Point(1136, 489);
        private Point threeEndLocation = new Point(1573, 436);

        private Point sixStartLocation = new Point(190, 436);
        private Point sixBoatStartLocation = new Point(718, 489);
        private Point sixBoatEndLocation = new Point(1067, 489);
        private Point sixEndLocation = new Point(1484, 436);

        private Point eightStartLocation = new Point(101, 436);
        private Point eightBoatStartLocation = new Point(576, 489);
        private Point eightBoatEndLocation = new Point(925, 489);
        private Point eightEndLocation = new Point(1395, 436);

        private Point twelveStartLocation = new Point(12, 436);
        private Point twelveBoatStartLocation = new Point(507, 489);
        private Point twelveBoatEndLocation = new Point(856, 489);
        private Point twelveEndLocation = new Point(1306, 436);

        private Point boatStartLocation = new Point(468, 548);
        private Point boatEndLocation = new Point(818, 548);

        private int remainingTime = 30; // Thời gian ban đầu là 30 giây







        private Point GetCharacterStartLocation(PictureBox characterPictureBox)
        {
            // Dựa vào tên của PictureBox để trả về vị trí StartLocation của nhân vật
            switch (characterPictureBox.Name)
            {
                case "OneSecondpictureBox":
                    return oneStartLocation;
                case "ThreeSecondpictureBox":
                    return threeStartLocation;
                case "SixSecondpictureBox1":
                    return sixStartLocation;
                case "EightSecondpictureBox":
                    return eightStartLocation;
                case "TwelveSecondpictureBox1":
                    return twelveStartLocation;
                default:
                    return Point.Empty; // Trường hợp không xác định
            }
        }

        private Point GetCharacterBoatStartLocation(PictureBox characterPictureBox)
        {
            // Kiểm tra xem nhân vật đó có trên thuyền khi thuyền ở vị trí ban đầu
            if (BoatpictureBox.Location == boatStartLocation)
            {
                // Dựa vào tên của PictureBox để xác định vị trí của nhân vật trên thuyền
                switch (characterPictureBox.Name)
                {
                    case "OneSecondpictureBox":
                        return oneBoatStartLocation;
                    case "ThreeSecondpictureBox":
                        return threeBoatStartLocation;
                    case "SixSecondpictureBox1":
                        return sixBoatStartLocation;
                    case "EightSecondpictureBox":
                        return eightBoatStartLocation;
                    case "TwelveSecondpictureBox1":
                        return twelveBoatStartLocation;
                    default:
                        return Point.Empty; // Trường hợp không xác định
                }
            }
            // Trường hợp không nằm trên thuyền khi thuyền ở vị trí ban đầu
            return Point.Empty;
        }
        private Point GetCharacterBoatEndLocation(PictureBox characterPictureBox)
        {
            // Kiểm tra xem nhân vật đó có trên thuyền khi thuyền ở vị trí ban đầu
            if (BoatpictureBox.Location == boatEndLocation)
            {
                // Dựa vào tên của PictureBox để xác định vị trí của nhân vật trên thuyền
                switch (characterPictureBox.Name)
                {
                    case "OneSecondpictureBox":
                        return oneBoatEndLocation;
                    case "ThreeSecondpictureBox":
                        return threeBoatEndLocation;
                    case "SixSecondpictureBox1":
                        return sixBoatEndLocation;
                    case "EightSecondpictureBox":
                        return eightBoatEndLocation;
                    case "TwelveSecondpictureBox1":
                        return twelveBoatEndLocation;
                    default:
                        return Point.Empty; // Trường hợp không xác định
                }
            }

            return Point.Empty; // Trường hợp không nằm trên thuyền khi thuyền ở vị trí ban đầu
        }

        private Point GetCharacterEndLocation(PictureBox characterPictureBox)
        {
            // Dựa vào tên của PictureBox để trả về vị trí EndLocation của nhân vật
            switch (characterPictureBox.Name)
            {
                case "OneSecondpictureBox":
                    return oneEndLocation;
                case "ThreeSecondpictureBox":
                    return threeEndLocation;
                case "SixSecondpictureBox1":
                    return sixEndLocation;
                case "EightSecondpictureBox":
                    return eightEndLocation;
                case "TwelveSecondpictureBox1":
                    return twelveEndLocation;
                default:
                    return Point.Empty; // Trường hợp không xác định
            }
        }



        private int GetCharacterTime(PictureBox characterPictureBox)
        {

            return 0; // Đây là giá trị mặc định, bạn cần thay đổi nó dựa trên logic của bạn.
        }



        private void EightSecondpictureBox_Click(object sender, EventArgs e)
        {
            HandleCharacterClick(EightSecondpictureBox);
        }

        private void ThreeSecondpictureBox_Click(object sender, EventArgs e)
        {
            HandleCharacterClick(ThreeSecondpictureBox);
        }

        private void OneSecondpictureBox_Click(object sender, EventArgs e)
        {
            HandleCharacterClick(OneSecondpictureBox);

        }

        private void SixSecondpictureBox1_Click(object sender, EventArgs e)
        {
            HandleCharacterClick(SixSecondpictureBox1);
        }

        private void TwelveSecondpictureBox1_Click(object sender, EventArgs e)
        {
            HandleCharacterClick(TwelveSecondpictureBox1);
        }

        private void HandleCharacterClick(PictureBox characterPictureBox)
        {


            // Kiểm tra xem nhân vật có thể di chuyển từ StartLocation đến BoatStartLocation hay không
            if (characterPictureBox.Location == GetCharacterStartLocation(characterPictureBox) &&
                BoatpictureBox.Location == boatStartLocation)
            {
                characterPictureBox.Location = GetCharacterBoatStartLocation(characterPictureBox);
            }
            // Kiểm tra xem nhân vật có thể di chuyển từ BoatStartLocation về StartLocation hay không
            else if (characterPictureBox.Location == GetCharacterBoatStartLocation(characterPictureBox))
            {
                characterPictureBox.Location = GetCharacterStartLocation(characterPictureBox);
            }

            // Kiểm tra xem nhân vật có thể di chuyển từ BoatEndLocation đến EndLocation hay không
            else if (characterPictureBox.Location == GetCharacterBoatEndLocation(characterPictureBox))
            {
                characterPictureBox.Location = GetCharacterEndLocation(characterPictureBox);
            }
            // Kiểm tra xem nhân vật có thể di chuyển từ EndLocation về BoatEndLocation hay không
            else if (characterPictureBox.Location == GetCharacterEndLocation(characterPictureBox) &&
                     BoatpictureBox.Location == boatEndLocation)
            {
                characterPictureBox.Location = GetCharacterBoatEndLocation(characterPictureBox);
            }

            // Kiểm tra điều kiện chiến thắng sau mỗi lần di chuyển
            CheckWin();


        }

        private void BoatpictureBox_Click_1(object sender, EventArgs e)
        {


            // Đếm số lượng nhân vật trên thuyền tại cả hai vị trí
            int numberOfCharactersOnBoatStart = CountCharactersOnBoatStart();
            int numberOfCharactersOnBoatEnd = CountCharactersOnBoatEnd();

            // Kiểm tra số lượng nhân vật trên thuyền và áp dụng logic di chuyển
            if (BoatpictureBox.Location == boatStartLocation)
            {
                if (numberOfCharactersOnBoatStart == 0)
                {
                    MessageBox.Show("Phải có ít nhất một người trên thuyền để lái thuyền.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (numberOfCharactersOnBoatStart > 2)
                {
                    MessageBox.Show("Thuyền chỉ chở được tối đa 2 người.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                else if (numberOfCharactersOnBoatStart == 1)
                {
                    // Di chuyển thuyền đến boatEndLocation
                    BoatpictureBox.Location = boatEndLocation;
                    if (OneSecondpictureBox.Location == oneBoatStartLocation)
                    {
                        OneSecondpictureBox.Location = GetCharacterBoatEndLocation(OneSecondpictureBox);
                    }
                    else if (ThreeSecondpictureBox.Location == threeBoatStartLocation)
                    {
                        ThreeSecondpictureBox.Location = GetCharacterBoatEndLocation(ThreeSecondpictureBox);
                    }
                    else if (SixSecondpictureBox1.Location == sixBoatStartLocation)
                    {
                        SixSecondpictureBox1.Location = GetCharacterBoatEndLocation(SixSecondpictureBox1);
                    }
                    else if (EightSecondpictureBox.Location == eightBoatStartLocation)
                    {
                        EightSecondpictureBox.Location = GetCharacterBoatEndLocation(EightSecondpictureBox);
                    }
                    else if (TwelveSecondpictureBox1.Location == twelveBoatStartLocation)
                    {
                        TwelveSecondpictureBox1.Location = GetCharacterBoatEndLocation(TwelveSecondpictureBox1);
                    }
                    int timeToSubtract = 0;
                    if (OneSecondpictureBox.Location == oneBoatEndLocation)
                        timeToSubtract = 1;
                    else if (ThreeSecondpictureBox.Location == threeBoatEndLocation)
                        timeToSubtract = 3;
                    else if (SixSecondpictureBox1.Location == sixBoatEndLocation)
                        timeToSubtract = 6;
                    else if (EightSecondpictureBox.Location == eightBoatEndLocation)
                        timeToSubtract = 8;
                    else if (TwelveSecondpictureBox1.Location == twelveBoatEndLocation)
                        timeToSubtract = 12;

                    // Subtract time from remainingTime
                    remainingTime -= timeToSubtract;

                    // Update the time label
                    Timelabel.Text = remainingTime.ToString();
                }

                else if (numberOfCharactersOnBoatStart == 2)
                {

                    BoatpictureBox.Location = boatEndLocation;
                    if (OneSecondpictureBox.Location == oneBoatStartLocation)
                    {
                        OneSecondpictureBox.Location = GetCharacterBoatEndLocation(OneSecondpictureBox);
                    }
                    if (ThreeSecondpictureBox.Location == threeBoatStartLocation)
                    {
                        ThreeSecondpictureBox.Location = GetCharacterBoatEndLocation(ThreeSecondpictureBox);
                    }
                    if (SixSecondpictureBox1.Location == sixBoatStartLocation)
                    {
                        SixSecondpictureBox1.Location = GetCharacterBoatEndLocation(SixSecondpictureBox1);
                    }
                    if (EightSecondpictureBox.Location == eightBoatStartLocation)
                    {
                        EightSecondpictureBox.Location = GetCharacterBoatEndLocation(EightSecondpictureBox);
                    }
                    if (TwelveSecondpictureBox1.Location == twelveBoatStartLocation)
                    {
                        TwelveSecondpictureBox1.Location = GetCharacterBoatEndLocation(TwelveSecondpictureBox1);
                    }
                    // Calculate time to subtract based on characters on the boat
                    int timeToSubtract = 0;
                    List<int> characterTimes = new List<int>();
                    if (OneSecondpictureBox.Location == oneBoatEndLocation)
                        characterTimes.Add(1);
                    if (ThreeSecondpictureBox.Location == threeBoatEndLocation)
                        characterTimes.Add(3);
                    if (SixSecondpictureBox1.Location == sixBoatEndLocation)
                        characterTimes.Add(6);
                    if (EightSecondpictureBox.Location == eightBoatEndLocation)
                        characterTimes.Add(8);
                    if (TwelveSecondpictureBox1.Location == twelveBoatEndLocation)
                        characterTimes.Add(12);

                    timeToSubtract = characterTimes.Max();

                    // Subtract time from remainingTime
                    remainingTime -= timeToSubtract;

                    // Update the time label
                    Timelabel.Text = remainingTime.ToString();
                }
            }


            else if (BoatpictureBox.Location == boatEndLocation)
            {
                if (numberOfCharactersOnBoatEnd == 0)
                {
                    MessageBox.Show("Phải có ít nhất một người trên thuyền để lái thuyền.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (numberOfCharactersOnBoatEnd > 2)
                {
                    MessageBox.Show("Thuyền chỉ chở được tối đa 2 người.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (numberOfCharactersOnBoatEnd == 1)
                {
                    // Di chuyển thuyền đến boatStartLocation
                    BoatpictureBox.Location = boatStartLocation;

                    if (OneSecondpictureBox.Location == oneBoatEndLocation)
                    {
                        OneSecondpictureBox.Location = GetCharacterBoatStartLocation(OneSecondpictureBox);
                    }
                    else if (ThreeSecondpictureBox.Location == threeBoatEndLocation)
                    {
                        ThreeSecondpictureBox.Location = GetCharacterBoatStartLocation(ThreeSecondpictureBox);
                    }
                    else if (SixSecondpictureBox1.Location == sixBoatEndLocation)
                    {
                        SixSecondpictureBox1.Location = GetCharacterBoatStartLocation(SixSecondpictureBox1);
                    }
                    else if (EightSecondpictureBox.Location == eightBoatEndLocation)
                    {
                        EightSecondpictureBox.Location = GetCharacterBoatStartLocation(EightSecondpictureBox);
                    }
                    else if (TwelveSecondpictureBox1.Location == twelveBoatStartLocation)
                    {
                        TwelveSecondpictureBox1.Location = GetCharacterBoatStartLocation(TwelveSecondpictureBox1);
                    }
                    // Calculate time to subtract based on characters on the boat
                    int timeToSubtract = 0;
                    if (OneSecondpictureBox.Location == oneBoatStartLocation)
                        timeToSubtract = 1;
                    else if (ThreeSecondpictureBox.Location == threeBoatStartLocation)
                        timeToSubtract = 3;
                    else if (SixSecondpictureBox1.Location == sixBoatStartLocation)
                        timeToSubtract = 6;
                    else if (EightSecondpictureBox.Location == eightBoatStartLocation)
                        timeToSubtract = 8;
                    else if (TwelveSecondpictureBox1.Location == twelveBoatStartLocation)
                        timeToSubtract = 12;

                    // Subtract time from remainingTime
                    remainingTime -= timeToSubtract;

                    // Update the time label
                    Timelabel.Text = remainingTime.ToString();
                }

                else if (numberOfCharactersOnBoatEnd == 2)
                {
                    // Di chuyển thuyền đến boatStartLocation
                    BoatpictureBox.Location = boatStartLocation;

                    if (OneSecondpictureBox.Location == oneBoatEndLocation)
                    {
                        OneSecondpictureBox.Location = GetCharacterBoatStartLocation(OneSecondpictureBox);
                    }
                    if (ThreeSecondpictureBox.Location == threeBoatEndLocation)
                    {
                        ThreeSecondpictureBox.Location = GetCharacterBoatStartLocation(ThreeSecondpictureBox);
                    }
                    if (SixSecondpictureBox1.Location == sixBoatEndLocation)
                    {
                        SixSecondpictureBox1.Location = GetCharacterBoatStartLocation(SixSecondpictureBox1);
                    }
                    if (EightSecondpictureBox.Location == eightBoatEndLocation)
                    {
                        EightSecondpictureBox.Location = GetCharacterBoatStartLocation(EightSecondpictureBox);
                    }
                    if (TwelveSecondpictureBox1.Location == twelveBoatStartLocation)
                    {
                        TwelveSecondpictureBox1.Location = GetCharacterBoatStartLocation(TwelveSecondpictureBox1);
                    }
                    // Calculate time to subtract based on characters on the boat
                    int timeToSubtract = 0;
                    List<int> characterTimes = new List<int>();
                    if (OneSecondpictureBox.Location == oneBoatStartLocation)
                        characterTimes.Add(1);
                    if (ThreeSecondpictureBox.Location == threeBoatStartLocation)
                        characterTimes.Add(3);
                    if (SixSecondpictureBox1.Location == sixBoatStartLocation)
                        characterTimes.Add(6);
                    if (EightSecondpictureBox.Location == eightBoatStartLocation)
                        characterTimes.Add(8);
                    if (TwelveSecondpictureBox1.Location == twelveBoatStartLocation)
                        characterTimes.Add(12);

                    timeToSubtract = characterTimes.Max();

                    // Subtract time from remainingTime
                    remainingTime -= timeToSubtract;

                    // Update the time label
                    Timelabel.Text = remainingTime.ToString();
                }
            }

            // Kiểm tra điều kiện chiến thắng sau mỗi lần di chuyển
            CheckWin();
        }

        // Hàm để đếm số lượng nhân vật trên thuyền tại CharacterBoatStartLocation
        private int CountCharactersOnBoatStart()
        {
            int count = 0;
            if (OneSecondpictureBox.Location == GetCharacterBoatStartLocation(OneSecondpictureBox))
                count++;
            if (ThreeSecondpictureBox.Location == GetCharacterBoatStartLocation(ThreeSecondpictureBox))
                count++;
            if (SixSecondpictureBox1.Location == GetCharacterBoatStartLocation(SixSecondpictureBox1))
                count++;
            if (EightSecondpictureBox.Location == GetCharacterBoatStartLocation(EightSecondpictureBox))
                count++;
            if (TwelveSecondpictureBox1.Location == GetCharacterBoatStartLocation(TwelveSecondpictureBox1))
                count++;
            return count;
        }

        // Hàm để đếm số lượng nhân vật trên thuyền tại CharacterBoatEndLocation
        private int CountCharactersOnBoatEnd()
        {
            int count = 0;
            if (OneSecondpictureBox.Location == GetCharacterBoatEndLocation(OneSecondpictureBox))
                count++;
            if (ThreeSecondpictureBox.Location == GetCharacterBoatEndLocation(ThreeSecondpictureBox))
                count++;
            if (SixSecondpictureBox1.Location == GetCharacterBoatEndLocation(SixSecondpictureBox1))
                count++;
            if (EightSecondpictureBox.Location == GetCharacterBoatEndLocation(EightSecondpictureBox))
                count++;
            if (TwelveSecondpictureBox1.Location == GetCharacterBoatEndLocation(TwelveSecondpictureBox1))
                count++;
            return count;
        }





        private bool CheckWin()
        {
            bool allCharactersAtEnd =
           OneSecondpictureBox.Location == oneEndLocation &&
           ThreeSecondpictureBox.Location == threeEndLocation &&
           SixSecondpictureBox1.Location == sixEndLocation &&
           EightSecondpictureBox.Location == eightEndLocation &&
           TwelveSecondpictureBox1.Location == twelveEndLocation;

            if (remainingTime <= 0 && !allCharactersAtEnd)
            {
                MessageBox.Show("BẠN ĐÃ THUA", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Đặt lại vị trí của tất cả các nhân vật về vị trí ban đầu
                OneSecondpictureBox.Location = oneStartLocation;
                ThreeSecondpictureBox.Location = threeStartLocation;
                SixSecondpictureBox1.Location = sixStartLocation;
                EightSecondpictureBox.Location = eightStartLocation;
                TwelveSecondpictureBox1.Location = twelveStartLocation;
                BoatpictureBox.Location = boatStartLocation;

                // Đặt lại thời gian về 30 giây
                remainingTime = 30;
                Timelabel.Text = remainingTime.ToString();

                return false;
            }

            if (allCharactersAtEnd && remainingTime > 0)
            {
                MessageBox.Show("BẠN ĐÃ CHIẾN THẮNG", "Chúc mừng", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }

            return false;
        }

        private void PlayBackbutton1_Click(object sender, EventArgs e)
        {
            // Đặt lại vị trí của tất cả các nhân vật về vị trí ban đầu
            OneSecondpictureBox.Location = oneStartLocation;
            ThreeSecondpictureBox.Location = threeStartLocation;
            SixSecondpictureBox1.Location = sixStartLocation;
            EightSecondpictureBox.Location = eightStartLocation;
            TwelveSecondpictureBox1.Location = twelveStartLocation;
            BoatpictureBox.Location = boatStartLocation;

            // Đặt lại thời gian về 30 giây
            remainingTime = 30;
            Timelabel.Text = remainingTime.ToString();
        }

        private void OneSecbutton_Click(object sender, EventArgs e)
        {
            // Gọi sự kiện OneSecondpictureBox_Click
            OneSecondpictureBox_Click(sender, e);
        }

        private void ThreeSecbutton_Click(object sender, EventArgs e)
        {
            ThreeSecondpictureBox_Click(sender, e);
        }

        private void SixSecbutton_Click(object sender, EventArgs e)
        {
            SixSecondpictureBox1_Click(sender, e);
        }

        private void EightSecbutton_Click(object sender, EventArgs e)
        {
            EightSecondpictureBox_Click(sender, e);
        }

        private void TwelveSecbutton_Click(object sender, EventArgs e)
        {
            TwelveSecondpictureBox1_Click(sender, e);
        }

        private void Answerbutton_Click(object sender, EventArgs e)
        {

        }

        private void Boatbutton_Click(object sender, EventArgs e)
        {
            BoatpictureBox_Click_1(sender, e);
        }
    }



}