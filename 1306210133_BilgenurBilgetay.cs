using System.Windows.Forms;
using Connect_Four;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.IO;


namespace Connection4_oyunuson
{
    public partial class Connection4_oyunuson : Form
    {
        Color turn = Color.Purple;
        int a, b, c, d, f, g, h, ý, i, R, Y, moveCounter;
        string whoWon = "Green";
        bool purpleStarts, gameEnded = false;
        private int[] columnHeights = new int[9];
        MessageBoxIcon icon = MessageBoxIcon.Error;


        private string ToBgr(Color c) => $"{c.B:X2}{c.G:X2}{c.R:X2}";

        [DllImport("DwmApi")]
        private static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, int[] attrValue, int attrSize);

        const int DWWMA_CAPTION_COLOR = 35;
        void CustomWindow(Color captionColor, IntPtr handle)
        {
            try
            {
                IntPtr hWnd = handle;
                //Change caption color
                int[] caption = new int[] { int.Parse(ToBgr(captionColor), System.Globalization.NumberStyles.HexNumber) };
                DwmSetWindowAttribute(hWnd, DWWMA_CAPTION_COLOR, caption, 4);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to set border color attribute: {ex.Message}");
            }
        }
        public Connection4_oyunuson()
        {
            InitializeComponent();

            CustomWindow(Color.Bisque, Handle);
        }

        private void BtnColumn1_Click(object sender, EventArgs e)
        {
            if (gameEnded == false && i < 9)
            {
                RoundButton button = (RoundButton)sender;
                RoundButton[] columnButtons = { b11, b12, b13, b14, b15, b16, b17, b18, b19 };

                for (int row = 0; row < 9; row++)
                {
                    if (columnButtons[row].BackColor == Color.OldLace)
                    {
                        columnButtons[row].BackColor = turn;
                        columnButtons[row].FlatAppearance.MouseOverBackColor = turn;
                        columnButtons[row].FlatAppearance.MouseDownBackColor = turn;
                        moveCounter++;

                        int column = GetColumnFromButton(sender);
                        string playerColor = (turn == Color.Purple) ? "Purple" : "Green";
                        SaveMoveToFile(row, column, playerColor);

                        changeTurn();
                        CheckForWinner();
                        break;
                    }
                }
            }
        }
        private void BtnColumn2_Click(object sender, EventArgs e)
        {
            if (gameEnded == false && i < 9)
            {
                RoundButton button = (RoundButton)sender;
                RoundButton[] columnButtons = { b21, b22, b23, b24, b25, b26, b27, b28, b29 };

                for (int row = 0; row < 9; row++)
                {
                    if (columnButtons[row].BackColor == Color.OldLace)
                    {
                        columnButtons[row].BackColor = turn;
                        columnButtons[row].FlatAppearance.MouseOverBackColor = turn;
                        columnButtons[row].FlatAppearance.MouseDownBackColor = turn;
                        moveCounter++;

                        int column = GetColumnFromButton(sender);
                        string playerColor = (turn == Color.Purple) ? "Purple" : "Green";
                        SaveMoveToFile(row, column, playerColor);

                        changeTurn();
                        CheckForWinner();
                        break;
                    }
                }
            }
        }

        private void BtnColumn3_Click(object sender, EventArgs e)
        {
            if (gameEnded == false && i < 9)
            {
                RoundButton button = (RoundButton)sender;
                RoundButton[] columnButtons = { b31, b32, b33, b34, b35, b36, b37, b38, b39 };

                for (int row = 0; row < 9; row++)
                {
                    if (columnButtons[row].BackColor == Color.OldLace)
                    {
                        columnButtons[row].BackColor = turn;
                        columnButtons[row].FlatAppearance.MouseOverBackColor = turn;
                        columnButtons[row].FlatAppearance.MouseDownBackColor = turn;
                        moveCounter++;

                        int column = GetColumnFromButton(sender);
                        string playerColor = (turn == Color.Purple) ? "Purple" : "Green";
                        SaveMoveToFile(row, column, playerColor);

                        changeTurn();
                        CheckForWinner();
                        break;
                    }
                }
            }
        }
        private void BtnColumn4_Click(object sender, EventArgs e)
        {
            if (gameEnded == false && i < 9)
            {
                RoundButton button = (RoundButton)sender;
                RoundButton[] columnButtons = { b41, b42, b43, b44, b45, b46, b47, b48, b49 };

                for (int row = 0; row < 9; row++)
                {
                    if (columnButtons[row].BackColor == Color.OldLace)
                    {
                        columnButtons[row].BackColor = turn;
                        columnButtons[row].FlatAppearance.MouseOverBackColor = turn;
                        columnButtons[row].FlatAppearance.MouseDownBackColor = turn;
                        moveCounter++;

                        int column = GetColumnFromButton(sender);
                        string playerColor = (turn == Color.Purple) ? "Purple" : "Green";
                        SaveMoveToFile(row, column, playerColor);

                        changeTurn();
                        CheckForWinner();
                        break;
                    }
                }
            }
        }
        private void BtnColumn5_Click(object sender, EventArgs e)
        {
            if (gameEnded == false && i < 9)
            {
                RoundButton button = (RoundButton)sender;
                RoundButton[] columnButtons = { b51, b52, b53, b54, b55, b56, b57, b58, b59 };

                for (int row = 0; row < 9; row++)
                {
                    if (columnButtons[row].BackColor == Color.OldLace)
                    {
                        columnButtons[row].BackColor = turn;
                        columnButtons[row].FlatAppearance.MouseOverBackColor = turn;
                        columnButtons[row].FlatAppearance.MouseDownBackColor = turn;
                        moveCounter++;

                        int column = GetColumnFromButton(sender);
                        string playerColor = (turn == Color.Purple) ? "Purple" : "Green";
                        SaveMoveToFile(row, column, playerColor);

                        changeTurn();
                        CheckForWinner();
                        break;
                    }
                }
            }
        }
        private void BtnColumn6_Click(object sender, EventArgs e)
        {
            if (gameEnded == false && i < 9)
            {
                RoundButton button = (RoundButton)sender;
                RoundButton[] columnButtons = { b61, b62, b63, b64, b65, b66, b67, b68, b69 };

                for (int row = 0; row < 9; row++)
                {
                    if (columnButtons[row].BackColor == Color.OldLace)
                    {
                        columnButtons[row].BackColor = turn;
                        columnButtons[row].FlatAppearance.MouseOverBackColor = turn;
                        columnButtons[row].FlatAppearance.MouseDownBackColor = turn;
                        moveCounter++;

                        int column = GetColumnFromButton(sender);
                        string playerColor = (turn == Color.Purple) ? "Purple" : "Green";
                        SaveMoveToFile(row, column, playerColor);

                        changeTurn();
                        CheckForWinner();
                        break;
                    }
                }
            }
        }
        private void BtnColumn7_Click(object sender, EventArgs e)
        {
            if (gameEnded == false && i < 9)
            {
                RoundButton button = (RoundButton)sender;
                RoundButton[] columnButtons = { b71, b72, b73, b74, b75, b76, b77, b78, b79 };

                for (int row = 0; row < 9; row++)
                {
                    if (columnButtons[row].BackColor == Color.OldLace)
                    {
                        columnButtons[row].BackColor = turn;
                        columnButtons[row].FlatAppearance.MouseOverBackColor = turn;
                        columnButtons[row].FlatAppearance.MouseDownBackColor = turn;
                        moveCounter++;

                        int column = GetColumnFromButton(sender);
                        string playerColor = (turn == Color.Purple) ? "Purple" : "Green";
                        SaveMoveToFile(row, column, playerColor);

                        changeTurn();
                        CheckForWinner();
                        break;
                    }
                }
            }
        }
        private void BtnColumn8_Click(object sender, EventArgs e)
        {
            if (gameEnded == false && i < 9)
            {
                RoundButton button = (RoundButton)sender;
                RoundButton[] columnButtons = { b81, b82, b83, b84, b85, b86, b87, b88, b89 };

                for (int row = 0; row < 9; row++)
                {
                    if (columnButtons[row].BackColor == Color.OldLace)
                    {
                        columnButtons[row].BackColor = turn;
                        columnButtons[row].FlatAppearance.MouseOverBackColor = turn;
                        columnButtons[row].FlatAppearance.MouseDownBackColor = turn;
                        moveCounter++;

                        int column = GetColumnFromButton(sender);

                        string playerColor = (turn == Color.Purple) ? "Purple" : "Green";
                        SaveMoveToFile(row, column, playerColor);

                        changeTurn();
                        CheckForWinner();
                        break;
                    }
                }
            }
        }
        private void BtnColumn9_Click(object sender, EventArgs e)
        {
            if (gameEnded == false && i < 9)
            {
                RoundButton button = (RoundButton)sender;
                RoundButton[] columnButtons = { b91, b92, b93, b94, b95, b96, b97, b98, b99 };

                for (int row = 0; row < 9; row++)
                {
                    if (columnButtons[row].BackColor == Color.OldLace)
                    {
                        columnButtons[row].BackColor = turn;
                        columnButtons[row].FlatAppearance.MouseOverBackColor = turn;
                        columnButtons[row].FlatAppearance.MouseDownBackColor = turn;
                        moveCounter++;

                        int column = GetColumnFromButton(sender);
                        string playerColor = (turn == Color.Purple) ? "Purple" : "Green";
                        SaveMoveToFile(row, column, playerColor);

                        changeTurn();
                        CheckForWinner();
                        break;
                    }
                }
            }
        }

        private int GetRowFromButton(object button)
        {
            string buttonName = ((Button)button).Name;
            int row = int.Parse(buttonName.Substring(2, 1));
            return row;
        }

        private int GetColumnFromButton(object button)
        {
            string buttonName = ((Button)button).Name;
            int column = int.Parse(buttonName.Substring(1, 1));
            return column;
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            foreach (Control c in tableConnect4.Controls)
            {
                c.BackColor = Color.OldLace;
                ((RoundButton)c).FlatAppearance.MouseOverBackColor = Color.OldLace;
                ((RoundButton)c).FlatAppearance.MouseDownBackColor = Color.OldLace;
            }
            a = 0; b = 0; c = 0; d = 0; f = 0; g = 0; h = 0; ý = 0; i = 0; moveCounter = 0;
            gameEnded = false;
            Array.Clear(columnHeights, 0, columnHeights.Length);

            if (purpleStarts == false)
            {
                turn = Color.Green;
                whoWon = "Purple";
                purpleStarts = true;
            }
            else
            {
                turn = Color.Purple;
                whoWon = "Green";
                purpleStarts = false;
            }
            HamleSayýsýGüncelle();
        }
        private void HamleSayýsýGüncelle()
        {
            lblMove.Text = $"Hamle Sayýsý : {moveCounter}";
            btnTurn.BackColor = turn;
            btnTurn.FlatAppearance.MouseOverBackColor = turn;
            btnTurn.FlatAppearance.MouseDownBackColor = turn;
        }


        private void changeTurn()
        {
            if (turn == Color.Purple)
                turn = Color.Green;
            else
                turn = Color.Purple;

            if (whoWon == "Purple")
                whoWon = "Green";
            else
                whoWon = "Purple";

            HamleSayýsýGüncelle();
        }
        RoundButton[,] buttons = new RoundButton[9, 9];
        private void CheckForWinner()
        {
            for (int i = 0; i < 9; i++)
            {
                for (int k = 0; k < 9; k++)
                {
                    string buttonName = "b" + (i + 1) + (k + 1);
                    buttons[i, k] = (RoundButton)Controls.Find(buttonName, true)[0];
                }
            }



            bool isWinner = false;

            // Satýrlarý kontrol ediyor
            for (int row = 0; row < 9; row++)
            {
                for (int col = 0; col < 6; col++)
                {
                    if (buttons[col, row] != null &&
                        buttons[col, row].BackColor == buttons[col + 1, row]?.BackColor &&
                        buttons[col + 1, row]?.BackColor == buttons[col + 2, row]?.BackColor &&
                        buttons[col + 2, row]?.BackColor == buttons[col + 3, row]?.BackColor &&
                        buttons[col, row].BackColor != Color.OldLace)
                    {
                        isWinner = true;
                        break;
                    }
                }
            }

            // Sütunlarý kontrol ediyor
            if (!isWinner)
            {
                for (int col = 0; col < 9; col++)
                {
                    for (int row = 0; row < 6; row++)
                    {
                        if (buttons[col, row] != null &&
                            buttons[col, row].BackColor == buttons[col, row + 1]?.BackColor &&
                            buttons[col, row + 1]?.BackColor == buttons[col, row + 2]?.BackColor &&
                            buttons[col, row + 2]?.BackColor == buttons[col, row + 3]?.BackColor &&
                            buttons[col, row].BackColor != Color.OldLace)
                        {
                            isWinner = true;
                            break;
                        }
                    }
                }
            }

            // Sað çaprazlarý kontrol ediyor
            if (!isWinner)
            {
                for (int col = 0; col < 6; col++)
                {
                    for (int row = 0; row < 6; row++)
                    {
                        if (buttons[col, row] != null &&
                            buttons[col, row].BackColor == buttons[col + 1, row + 1]?.BackColor &&
                            buttons[col + 1, row + 1]?.BackColor == buttons[col + 2, row + 2]?.BackColor &&
                            buttons[col + 2, row + 2]?.BackColor == buttons[col + 3, row + 3]?.BackColor &&
                            buttons[col, row].BackColor != Color.OldLace)
                        {
                            isWinner = true;
                            break;
                        }
                    }
                }
            }

            // Sol çaprazlarý kontrol ediyor
            if (!isWinner)
            {
                for (int col = 0; col < 6; col++)
                {
                    for (int row = 3; row < 9; row++)
                    {
                        if (buttons[col, row] != null &&
                            buttons[col, row].BackColor == buttons[col + 1, row - 1]?.BackColor &&
                            buttons[col + 1, row - 1]?.BackColor == buttons[col + 2, row - 2]?.BackColor &&
                            buttons[col + 2, row - 2]?.BackColor == buttons[col + 3, row - 3]?.BackColor &&
                            buttons[col, row].BackColor != Color.OldLace)
                        {
                            isWinner = true;
                            break;
                        }
                    }
                }
            }
            if (isWinner)
            {
                gameEnded = true;

                if (whoWon == "Purple")
                {
                    R++;
                    lblPurpleScore.Text = $"Mor: {R}";
                    icon = MessageBoxIcon.Error;
                }
                else if (whoWon == "Green")
                {
                    Y++;
                    lblGreenScore.Text = $"Yeþil: {Y}";
                    icon = MessageBoxIcon.Warning;
                }

                DialogResult result;
                result = MessageBox.Show($"{whoWon} oyunu kazandý!!!\nYeni bir oyuna baþlamak ister misin?", $"{whoWon} Kazandý", MessageBoxButtons.YesNo, icon);
                if (result == DialogResult.Yes)
                    btnRestart.PerformClick();
            }

            if (moveCounter == 80 && gameEnded == false)
            {
                DialogResult result;
                result = MessageBox.Show("Oyun berabere!!!\nYeni bir oyuna baþlamak ister misin?", "Berabere", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                    btnRestart.PerformClick();
            }
            SaveBoardToFile(buttons);
        }

        private void SaveBoardToFile(RoundButton[,] buttons)
        {
            string filePath = "Tahta.txt";

            using (StreamWriter writer = new StreamWriter(filePath))
            {
                for (int row = 0; row < 9; row++)
                {
                    for (int col = 0; col < 9; col++)
                    {

                        Color buttonColor = (Color)(buttons[col, row]?.BackColor);
                        string hücre_durumu = "Boþ";

                        if (buttonColor == Color.Purple)
                        {

                            hücre_durumu = "Mor";
                        }
                        else if (buttonColor == Color.Green)
                        {

                            hücre_durumu = "Yeþil";
                        }

                        writer.Write(hücre_durumu);

                        if (col != 8)
                        {
                            writer.Write(",");
                        }
                    }

                    writer.WriteLine();
                }
            }
        }


        // Her hamleden sonra satýr sütun þeklinde Hamle.txt dosyasýna yazdýrmak için tanýmladýðým metod
        private void SaveMoveToFile(int row, int column, string playerColor)
        {
            string move = $"{row + 1}{column - 1} - {playerColor}";
            string filePath = "Hamle.txt";


            if (!File.Exists(filePath) || !File.ReadAllLines(filePath).Contains(move))
            {

                using (StreamWriter writer = File.AppendText(filePath))
                {
                    writer.WriteLine(move);
                }
            }
        }



        //Oyunu durdurdu mu oyuncu diye bakýyorum bu evet veya hayýr olabileceði için bool tanýmladým
        private bool gamePaused = false;


        private void btnDurdur_Click(object sender, EventArgs e)
        {
            gamePaused = true;
            SaveBoardToFile(buttons);

            MessageBox.Show("Oyun durduruldu. Oyuna devam etmek için Devam Et butonuna basýn.", "Oyun Durduruldu", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }


        private void btnEskiOyun_Click(object sender, EventArgs e)
        {
            if (gamePaused)
            {
                gamePaused = false;
                LoadBoardFromFile();
                MessageBox.Show("Oyun devam ediyor.", "Oyun Devam Ediyor", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Oyun halen devam ediyor.", "Oyun Devam Ediyor", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        // Tahta durumunu Tahta.txt dosyasýndan yükleme iþi için tanýmladýðým metod
        private void LoadBoardFromFile()
        {
            string filePath = "Tahta.txt";

            if (File.Exists(filePath))
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    int row = 0;

                    while ((line = reader.ReadLine()) != null && row < 9)
                    {
                        string[] cellStatuses = line.Split(',');

                        for (int col = 0; col < Math.Min(cellStatuses.Length, 9); col++)
                        {
                            string cellStatus = cellStatuses[col];

                            if (cellStatus == "Boþ")
                            {
                                buttons[col, row].BackColor = Color.OldLace;
                            }
                            else if (cellStatus == "Mor")
                            {
                                buttons[col, row].BackColor = Color.Purple;
                            }
                            else if (cellStatus == "Yeþil")
                            {
                                buttons[col, row].BackColor = Color.Green;
                            }
                        }

                        row++;
                    }
                }
            }
            else
            {
                MessageBox.Show("Kaydedilmiþ tahta durumu bulunamadý.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }

}