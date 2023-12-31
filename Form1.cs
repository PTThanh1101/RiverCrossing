﻿namespace RiverCrossing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Timelabel.Text = remainingTime.ToString();
            CharactersOnForm.Add(OneSecondpictureBox);
            CharactersOnForm.Add(ThreeSecondpictureBox);
            CharactersOnForm.Add(SixSecondpictureBox1);
            CharactersOnForm.Add(EightSecondpictureBox);
            CharactersOnForm.Add(TwelveSecondpictureBox1);
        }
        public List<PictureBox> CharactersOnForm = new List<PictureBox>();
        public Point oneStartLocation = new Point(369, 436);
        public Point oneBoatStartLocation = new Point(856, 489);
        public Point oneBoatEndLocation = new Point(1205, 489);
        public Point oneEndLocation = new Point(1663, 436);

        public Point threeStartLocation = new Point(279, 436);
        public Point threeBoatStartLocation = new Point(787, 489);
        public Point threeBoatEndLocation = new Point(1136, 489);
        public Point threeEndLocation = new Point(1573, 436);

        public Point sixStartLocation = new Point(190, 436);
        public Point sixBoatStartLocation = new Point(718, 489);
        public Point sixBoatEndLocation = new Point(1067, 489);
        public Point sixEndLocation = new Point(1484, 436);

        public Point eightStartLocation = new Point(101, 436);
        public Point eightBoatStartLocation = new Point(576, 489);
        public Point eightBoatEndLocation = new Point(925, 489);
        public Point eightEndLocation = new Point(1395, 436);

        public Point twelveStartLocation = new Point(12, 436);
        public Point twelveBoatStartLocation = new Point(507, 489);
        public Point twelveBoatEndLocation = new Point(856, 489);
        public Point twelveEndLocation = new Point(1306, 436);

        public Point boatStartLocation = new Point(468, 548);
        public Point boatEndLocation = new Point(818, 548);

        public int remainingTime = 30; // Thời gian ban đầu là 30 giây
        public int ThoiGianTon = 0;
        public Point GetCharacterStartLocation(PictureBox characterPictureBox)
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

        public Point GetCharacterBoatStartLocation(PictureBox characterPictureBox)
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
        public Point GetCharacterBoatEndLocation(PictureBox characterPictureBox)
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

        public Point GetCharacterEndLocation(PictureBox characterPictureBox)
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


        public void EightSecondpictureBox_Click(object sender, EventArgs e)
        {
            HandleCharacterClick(EightSecondpictureBox);
        }

        public void ThreeSecondpictureBox_Click(object sender, EventArgs e)
        {
            HandleCharacterClick(ThreeSecondpictureBox);
        }

        public void OneSecondpictureBox_Click(object sender, EventArgs e)
        {
            HandleCharacterClick(OneSecondpictureBox);

        }

        public void SixSecondpictureBox1_Click(object sender, EventArgs e)
        {
            HandleCharacterClick(SixSecondpictureBox1);
        }

        public void TwelveSecondpictureBox1_Click(object sender, EventArgs e)
        {
            HandleCharacterClick(TwelveSecondpictureBox1);
        }

        public void HandleCharacterClick(PictureBox characterPictureBox)
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

        public void BoatpictureBox_Click_1(object sender, EventArgs e)
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
                    ThoiGianTon = TinhThoiGian();

                    // Subtract time from remainingTime
                    remainingTime -= ThoiGianTon;

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
                    ThoiGianTon = TinhThoiGian();
                    // Subtract time from remainingTime
                    remainingTime -= ThoiGianTon;
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
                    else if (TwelveSecondpictureBox1.Location == twelveBoatEndLocation)
                    {
                        TwelveSecondpictureBox1.Location = GetCharacterBoatStartLocation(TwelveSecondpictureBox1);
                    }
                    // Calculate time to subtract based on characters on the boat
                    ThoiGianTon = TinhThoiGian();
                    // Subtract time from remainingTime
                    remainingTime -= ThoiGianTon;
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
                    if (TwelveSecondpictureBox1.Location == twelveBoatEndLocation)
                    {
                        TwelveSecondpictureBox1.Location = GetCharacterBoatStartLocation(TwelveSecondpictureBox1);
                    }

                    // Calculate time to subtract based on characters on the boat
                    ThoiGianTon = TinhThoiGian();
                    // Subtract time from remainingTime
                    remainingTime -= ThoiGianTon;
                    // Update the time label
                    Timelabel.Text = remainingTime.ToString();
                }
            }

            // Kiểm tra điều kiện chiến thắng sau mỗi lần di chuyển
            CheckWin();
        }
        public int TinhThoiGian()
        {
            if (CountCharactersOnBoatStart() == 1 || CountCharactersOnBoatEnd() == 1)
            {
                if (OneSecondpictureBox.Location == oneBoatEndLocation)
                    ThoiGianTon = 1;
                else if (ThreeSecondpictureBox.Location == threeBoatEndLocation)
                    ThoiGianTon = 3;
                else if (SixSecondpictureBox1.Location == sixBoatEndLocation)
                    ThoiGianTon = 6;
                else if (EightSecondpictureBox.Location == eightBoatEndLocation)
                    ThoiGianTon = 8;
                else if (TwelveSecondpictureBox1.Location == twelveBoatEndLocation)
                    ThoiGianTon = 12;
                if (OneSecondpictureBox.Location == oneBoatStartLocation)
                    ThoiGianTon = 1;
                else if (ThreeSecondpictureBox.Location == threeBoatStartLocation)
                    ThoiGianTon = 3;
                else if (SixSecondpictureBox1.Location == sixBoatStartLocation)
                    ThoiGianTon = 6;
                else if (EightSecondpictureBox.Location == eightBoatStartLocation)
                    ThoiGianTon = 8;
                else if (TwelveSecondpictureBox1.Location == twelveBoatStartLocation)
                    ThoiGianTon = 12;

            }
            else if (CountCharactersOnBoatStart() == 2 || CountCharactersOnBoatEnd() == 2)
            {
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
                ThoiGianTon = characterTimes.Max();
            }
            return ThoiGianTon;
        }

        // Hàm để đếm số lượng nhân vật trên thuyền tại CharacterBoatStartLocation
        public int CountCharactersOnBoatStart()
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
        public int CountCharactersOnBoatEnd()
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
        public bool CheckWin()
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

        public void PlayBackbutton1_Click(object sender, EventArgs e)
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

        public void OneSecbutton_Click(object sender, EventArgs e)
        {
            // Gọi sự kiện OneSecondpictureBox_Click
            OneSecondpictureBox_Click(sender, e);
        }

        public void ThreeSecbutton_Click(object sender, EventArgs e)
        {
            ThreeSecondpictureBox_Click(sender, e);
        }

        public void SixSecbutton_Click(object sender, EventArgs e)
        {
            SixSecondpictureBox1_Click(sender, e);
        }

        public void EightSecbutton_Click(object sender, EventArgs e)
        {
            EightSecondpictureBox_Click(sender, e);
        }

        public void TwelveSecbutton_Click(object sender, EventArgs e)
        {
            TwelveSecondpictureBox1_Click(sender, e);
        }

        public async void Answerbutton_Click(object sender, EventArgs e)
        {
            PlayBackbutton1_Click(sender, e);
            List<PictureBox> charactersToMove = new List<PictureBox>();
            charactersToMove.Add(OneSecondpictureBox); // Thêm các hình ảnh của nhân vật vào danh sách
            charactersToMove.Add(ThreeSecondpictureBox);
            await CrossCharacters(charactersToMove);
            charactersToMove.Clear();
            charactersToMove.Add(OneSecondpictureBox);
            await CrossCharacters(charactersToMove);
            charactersToMove.Add(SixSecondpictureBox1);
            await CrossCharacters(charactersToMove);
            charactersToMove.Clear();
            charactersToMove.Add(OneSecondpictureBox);
            await CrossCharacters(charactersToMove);
            charactersToMove.Clear();
            charactersToMove.Add(EightSecondpictureBox);
            charactersToMove.Add(TwelveSecondpictureBox1);
            await CrossCharacters(charactersToMove);
            charactersToMove.Clear();
            charactersToMove.Add(ThreeSecondpictureBox);
            await CrossCharacters(charactersToMove);
            charactersToMove.Add(OneSecondpictureBox);
            await CrossCharacters(charactersToMove);
        }

        public void Boatbutton_Click(object sender, EventArgs e)
        {
            BoatpictureBox_Click_1(sender, e);
        }



        public async Task CrossCharacters(List<PictureBox> characters)
        {
            // Di chuyển các nhân vật lên thuyền
            foreach (var character in characters)
            {
                await Task.Delay(1000);
                HandleCharacterClick(character);
                await Task.Delay(1000);
            }

            // Di chuyển thuyền
            BoatpictureBox_Click_1(BoatpictureBox, EventArgs.Empty);


            // Di chuyển các nhân vật ra khỏi thuyền
            foreach (var character in characters)
            {
                await Task.Delay(1000);
                HandleCharacterClick(character);
                await Task.Delay(1000);
            }
        }


        //private void PerformActions(List<string> actions)
        //{
        //    foreach (string action in actions)
        //    {
        //        // Thực hiện hành động
        //        switch (action)
        //        {
        //            case "Move OneSecondPictureBox to the other side":
        //                MoveCharacter(OneSecondPictureBox, oneEndLocation);
        //                break;
        //            case "Move ThreeSecondPictureBox to the other side":
        //                MoveCharacter(ThreeSecondPictureBox, threeEndLocation);
        //                break;
        //            case "Move SixSecondPictureBox1 to the other side":
        //                MoveCharacter(SixSecondPictureBox1, sixEndLocation);
        //                break;
        //            case "Move EightSecondPictureBox to the other side":
        //                MoveCharacter(EightSecondPictureBox, eightEndLocation);
        //                break;
        //            case "Move TwelveSecondPictureBox1 to the other side":
        //                MoveCharacter(TwelveSecondPictureBox1, twelveEndLocation);
        //                break;
        //            default:
        //                // Xử lý hành động không xác định
        //                break;
        //        }
        //    }
        //}

        //private void MoveCharacter(PictureBox character, Point targetLocation)
        //{
        //    // Thực hiện di chuyển nhân vật đến vị trí đích
        //    character.Location = targetLocation;
        //    // Tạm dừng để hiển thị hoạt động (thời gian dừng có thể điều chỉnh)
        //    
        //}
        // Tạo một trạng thái ban đầu với các thông tin hiện tại
        //PathNode initialNode = new PathNode(OneSecondpictureBox.Location, BoatpictureBox.Location, remainingTime);

        // Khởi tạo lớp Pathfinding
        //Pathfinding pathfinding = new Pathfinding();

        // Gọi hàm tìm đường để lấy danh sách các hành động để di chuyển
        //List<string> actions = pathfinding.FindPathToGoal(initialNode);

        // Thực hiện các hành động bằng cách gọi phương thức PerformActions
        // PerformActions(actions);


    }
    //Xây dựng Thuật toán A*
    public class PathNode
    {
        public Point CharacterPosition { get; set; }
        public Point BoatPosition { get; set; }
        public List<string> Actions { get; set; }
        public int RemainingTime { get; set; }

        public PathNode(Point characterPosition, Point boatPosition, int remainingTime, List<string> actions)
        {
            CharacterPosition = characterPosition;
            BoatPosition = boatPosition;
            RemainingTime = remainingTime;
            Actions = new List<string>(actions);
        }
    }

    public class Pathfinding : Form1
    {
        // Hàm tìm đường đi sử dụng thuật toán A*
        public List<string> FindPath(Point startCharacterPosition, Point startBoatPosition)
        {
            // Khởi tạo các biến và cấu trúc dữ liệu
            List<string> path = new List<string>();
            Queue<PathNode> openSet = new Queue<PathNode>();
            HashSet<string> closedSet = new HashSet<string>();

            int remainingTime = 30; // Thời gian ban đầu là 30 giây
            int ThoiGianTon = 0;

            // Khởi tạo nút ban đầu
            List<string> initialActions = new List<string>();
            PathNode startNode = new PathNode(startCharacterPosition, startBoatPosition, remainingTime, initialActions);
            openSet.Enqueue(startNode);

            // Bắt đầu thuật toán A*
            while (openSet.Count > 0)
            {
                // Lấy nút hiện tại từ hàng đợi
                PathNode currentNode = openSet.Dequeue();

                // Kiểm tra điều kiện dừng
                if (IsGoalState(currentNode, remainingTime))
                {
                    path = currentNode.Actions;
                    break;
                }

                // Lặp qua các hướng di chuyển có thể
                foreach (string action in GetPossibleActions(currentNode, remainingTime, ThoiGianTon))
                {
                    // Tạo một nút mới cho hướng di chuyển này
                    PathNode neighborNode = CreateNeighborNode(currentNode, action);

                    // Kiểm tra xem nút mới có hợp lệ không
                    if (IsValidState(neighborNode, remainingTime, ThoiGianTon) && !closedSet.Contains(GetStateHash(neighborNode)))
                    {
                        openSet.Enqueue(neighborNode);
                        closedSet.Add(GetStateHash(neighborNode));
                    }
                }
            }

            return path;
        }

        // Hàm kiểm tra điều kiện dừng
        public bool IsGoalState(PathNode node, int remainingTime)
        {
            bool allCharactersAtEnd =
                OneSecondpictureBox.Location == oneEndLocation &&
                ThreeSecondpictureBox.Location == threeEndLocation &&
                SixSecondpictureBox1.Location == sixEndLocation &&
                EightSecondpictureBox.Location == eightEndLocation &&
                TwelveSecondpictureBox1.Location == twelveEndLocation;
            if (allCharactersAtEnd && remainingTime > 0)
            {
                return true;
            }
            return false;
        }

        public bool IsInitialState(PathNode node, int remainingTime)
        {
            bool allCharactersAtStart =
                OneSecondpictureBox.Location == oneEndLocation &&
                ThreeSecondpictureBox.Location == threeEndLocation &&
                SixSecondpictureBox1.Location == sixEndLocation &&
                EightSecondpictureBox.Location == eightEndLocation &&
                TwelveSecondpictureBox1.Location == twelveEndLocation &&
                BoatpictureBox.Location == boatStartLocation;
            if (allCharactersAtStart == true && remainingTime == 30)
            {
                return true;
            }
            return false;
        }

        // Hàm lấy các hướng di chuyển có thể
        public List<string> GetPossibleActions(PathNode node, int remainingTime, int ThoiGianTon)
        {
            // Thêm logic để xác định các hướng di chuyển có thể
            List<string> actions = new List<string>();

            // Lấy danh sách nhân vật trên form
            List<PictureBox> charactersOnForm = new List<PictureBox>
        {
            OneSecondpictureBox,
            ThreeSecondpictureBox,
            SixSecondpictureBox1,
            EightSecondpictureBox,
            TwelveSecondpictureBox1
        };

            // Duyệt qua từng nhân vật và kiểm tra xem nếu nhân vật có thể di chuyển thì thêm hướng di chuyển đó vào danh sách
            foreach (var character in charactersOnForm)
            {
                if (IsValidMove(node, character, remainingTime, ThoiGianTon))
                {
                    List<PictureBox> charactersToMove = new List<PictureBox> { character };
                    CrossCharacters(charactersToMove);

                    // Lấy ra hành động sau khi di chuyển
                    actions.Add($"Move {character.Name} to the other side");
                }
            }
            return actions;
        }

        public bool IsValidMove(PathNode node, PictureBox character, int remainingTime, int ThoiGianTon)
        {
            // Đảm bảo rằng nhân vật đang ở vị trí hiện tại
            if (character.Location != node.CharacterPosition)
            {
                return false;
            }
            // Đảm bảo rằng thuyền ở đúng vị trí
            if (BoatpictureBox.Location != node.BoatPosition)
            {
                return false;
            }

            if (remainingTime <= ThoiGianTon)
            {
                return false;
            }
            // Đảm bảo rằng nhân vật có thể di chuyển đến một vị trí hợp lệ trên thuyền

            if (BoatpictureBox.Location == boatStartLocation)
            {
                if (character.Location != GetCharacterStartLocation(character))
                {
                    return false;
                }
            }
            else if (BoatpictureBox.Location == boatEndLocation)
            {
                if (character.Location != GetCharacterBoatEndLocation(character))
                {
                    return false;
                }
            }
            // Nếu tất cả điều kiện đều đúng, thì bước di chuyển này là hợp lệ
            return true;
        }

        // Hàm tạo một nút cho một hướng di chuyển
        public PathNode CreateNeighborNode(PathNode node, string action)
        {
            // Sao chép thông tin từ nút gốc sang nút mới
            PathNode neighborNode = new PathNode(node.CharacterPosition, node.BoatPosition, node.RemainingTime, new List<string>(node.Actions));


            CrossCharacters(CharactersOnForm);

            // Cập nhật hành động cho nút mới
            neighborNode.Actions.Add(action);

            // Trừ thời gian di chuyển từ thời gian còn lại
            remainingTime -= ThoiGianTon;

            return neighborNode;
        }

        // Hàm kiểm tra xem nút có hợp lệ không
        public bool IsValidState(PathNode node, int remainingTime, int ThoiGianTon)
        {
            // Đảm bảo rằng thuyền ở đúng vị trí
            if (BoatpictureBox.Location != node.BoatPosition)
            {
                return false;
            }

            if (remainingTime <= ThoiGianTon)
            {
                return false;
            }

            // Đảm bảo rằng tất cả nhân vật có thể di chuyển đến vị trí hợp lệ trên thuyền
            foreach (var character in CharactersOnForm)
            {
                if (BoatpictureBox.Location == boatStartLocation &&
                    character.Location != GetCharacterStartLocation(character))
                {
                    return false;
                }
                if (BoatpictureBox.Location == boatEndLocation &&
                    character.Location != GetCharacterBoatEndLocation(character))
                {
                    return false;
                }
            }

            return true;
        }

        // Hàm lấy mã hash của trạng thái nút
        public string GetStateHash(PathNode node)
        {
            List<string> components = new List<string>();

            // Thêm vị trí của nhân vật
            components.Add($"Character_{node.CharacterPosition.X}_{node.CharacterPosition.Y}");

            // Thêm vị trí của thuyền
            components.Add($"Boat_{node.BoatPosition.X}_{node.BoatPosition.Y}");

            // Thêm thời gian còn lại
            components.Add($"Time_{remainingTime}");

            // Sắp xếp các thành phần
            components.Sort();

            // Tạo mã hash bằng cách nối các thành phần đã sắp xếp
            string hash = string.Join("_", components);

            return hash;
        }

    }



}