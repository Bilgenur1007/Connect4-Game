using Connect_Four;
using Connection4_oyunuson;
using System.Windows.Forms;


namespace Connection4_oyunuson
{
    partial class Connection4_oyunuson
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitle = new Label();
            lblPurpleScore = new Label();
            lblGreenScore = new Label();
            lblMove = new Label();
            lblTurn = new Label();
            btnRestart = new Button();
            btnEskiOyun = new Button();
            tableConnect4 = new TableLayoutPanel();
            b91 = new RoundButton();
            b81 = new RoundButton();
            b61 = new RoundButton();
            b51 = new RoundButton();
            b41 = new RoundButton();
            b31 = new RoundButton();
            b21 = new RoundButton();
            b11 = new RoundButton();
            b92 = new RoundButton();
            b82 = new RoundButton();
            b72 = new RoundButton();
            b62 = new RoundButton();
            b52 = new RoundButton();
            b42 = new RoundButton();
            b32 = new RoundButton();
            b22 = new RoundButton();
            b12 = new RoundButton();
            b93 = new RoundButton();
            b83 = new RoundButton();
            b73 = new RoundButton();
            b63 = new RoundButton();
            b53 = new RoundButton();
            b43 = new RoundButton();
            b33 = new RoundButton();
            b23 = new RoundButton();
            b13 = new RoundButton();
            b94 = new RoundButton();
            b84 = new RoundButton();
            b74 = new RoundButton();
            b64 = new RoundButton();
            b54 = new RoundButton();
            b44 = new RoundButton();
            b34 = new RoundButton();
            b24 = new RoundButton();
            b14 = new RoundButton();
            b95 = new RoundButton();
            b85 = new RoundButton();
            b75 = new RoundButton();
            b65 = new RoundButton();
            b55 = new RoundButton();
            b45 = new RoundButton();
            b35 = new RoundButton();
            b25 = new RoundButton();
            b15 = new RoundButton();
            b96 = new RoundButton();
            b86 = new RoundButton();
            b76 = new RoundButton();
            b66 = new RoundButton();
            b56 = new RoundButton();
            b46 = new RoundButton();
            b36 = new RoundButton();
            b26 = new RoundButton();
            b16 = new RoundButton();
            b97 = new RoundButton();
            b87 = new RoundButton();
            b77 = new RoundButton();
            b67 = new RoundButton();
            b57 = new RoundButton();
            b47 = new RoundButton();
            b37 = new RoundButton();
            b27 = new RoundButton();
            b17 = new RoundButton();
            b98 = new RoundButton();
            b88 = new RoundButton();
            b78 = new RoundButton();
            b68 = new RoundButton();
            b58 = new RoundButton();
            b48 = new RoundButton();
            b38 = new RoundButton();
            b28 = new RoundButton();
            b18 = new RoundButton();
            b99 = new RoundButton();
            b89 = new RoundButton();
            b79 = new RoundButton();
            b69 = new RoundButton();
            b59 = new RoundButton();
            b49 = new RoundButton();
            b39 = new RoundButton();
            b29 = new RoundButton();
            b19 = new RoundButton();
            b71 = new RoundButton();
            btnTurn = new RoundButton();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            btnDurdur = new Button();
            tableConnect4.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Cooper Black", 28.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitle.Location = new Point(53, 29);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(249, 54);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Connect4";
            // 
            // lblPurpleScore
            // 
            lblPurpleScore.AutoSize = true;
            lblPurpleScore.Font = new Font("Elephant", 16.1999989F, FontStyle.Regular, GraphicsUnit.Point);
            lblPurpleScore.ForeColor = Color.Purple;
            lblPurpleScore.Location = new Point(843, 62);
            lblPurpleScore.Name = "lblPurpleScore";
            lblPurpleScore.Size = new Size(115, 35);
            lblPurpleScore.TabIndex = 1;
            lblPurpleScore.Text = "Mor : 0";
            // 
            // lblGreenScore
            // 
            lblGreenScore.AutoSize = true;
            lblGreenScore.Font = new Font("Elephant", 16.1999989F, FontStyle.Regular, GraphicsUnit.Point);
            lblGreenScore.ForeColor = Color.Lime;
            lblGreenScore.Location = new Point(1024, 62);
            lblGreenScore.Name = "lblGreenScore";
            lblGreenScore.Size = new Size(122, 35);
            lblGreenScore.TabIndex = 2;
            lblGreenScore.Text = "Yeşil : 0";
            // 
            // lblMove
            // 
            lblMove.AutoSize = true;
            lblMove.Font = new Font("Elephant", 16.1999989F, FontStyle.Regular, GraphicsUnit.Point);
            lblMove.Location = new Point(871, 148);
            lblMove.Name = "lblMove";
            lblMove.Size = new Size(236, 35);
            lblMove.TabIndex = 3;
            lblMove.Text = "Hamle Sayısı : 0";
            // 
            // lblTurn
            // 
            lblTurn.AutoSize = true;
            lblTurn.Font = new Font("Elephant", 16.1999989F, FontStyle.Regular, GraphicsUnit.Point);
            lblTurn.Location = new Point(871, 218);
            lblTurn.Name = "lblTurn";
            lblTurn.Size = new Size(186, 35);
            lblTurn.TabIndex = 4;
            lblTurn.Text = "Sıra Kimde :";
            // 
            // btnRestart
            // 
            btnRestart.Font = new Font("Elephant", 16.1999989F, FontStyle.Regular, GraphicsUnit.Point);
            btnRestart.Location = new Point(901, 321);
            btnRestart.Name = "btnRestart";
            btnRestart.Size = new Size(177, 90);
            btnRestart.TabIndex = 5;
            btnRestart.Text = "Oyuna Başla";
            btnRestart.UseVisualStyleBackColor = true;
            btnRestart.Click += btnRestart_Click;
            // 
            // btnEskiOyun
            // 
            btnEskiOyun.Font = new Font("Elephant", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnEskiOyun.Location = new Point(901, 451);
            btnEskiOyun.Name = "btnEskiOyun";
            btnEskiOyun.Size = new Size(177, 86);
            btnEskiOyun.TabIndex = 6;
            btnEskiOyun.Text = "Eski Oyuna Devam Et";
            btnEskiOyun.UseVisualStyleBackColor = true;
            btnEskiOyun.Click += btnEskiOyun_Click;
            // 
            // tableConnect4
            // 
            tableConnect4.BackColor = Color.Blue;
            tableConnect4.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableConnect4.ColumnCount = 9;
            tableConnect4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80F));
            tableConnect4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80F));
            tableConnect4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80F));
            tableConnect4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80F));
            tableConnect4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80F));
            tableConnect4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80F));
            tableConnect4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80F));
            tableConnect4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80F));
            tableConnect4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80F));
            tableConnect4.Controls.Add(b91, 8, 8);
            tableConnect4.Controls.Add(b81, 7, 8);
            tableConnect4.Controls.Add(b61, 5, 8);
            tableConnect4.Controls.Add(b51, 4, 8);
            tableConnect4.Controls.Add(b41, 3, 8);
            tableConnect4.Controls.Add(b31, 2, 8);
            tableConnect4.Controls.Add(b21, 1, 8);
            tableConnect4.Controls.Add(b11, 0, 8);
            tableConnect4.Controls.Add(b92, 8, 7);
            tableConnect4.Controls.Add(b82, 7, 7);
            tableConnect4.Controls.Add(b72, 6, 7);
            tableConnect4.Controls.Add(b62, 5, 7);
            tableConnect4.Controls.Add(b52, 4, 7);
            tableConnect4.Controls.Add(b42, 3, 7);
            tableConnect4.Controls.Add(b32, 2, 7);
            tableConnect4.Controls.Add(b22, 1, 7);
            tableConnect4.Controls.Add(b12, 0, 7);
            tableConnect4.Controls.Add(b93, 8, 6);
            tableConnect4.Controls.Add(b83, 7, 6);
            tableConnect4.Controls.Add(b73, 6, 6);
            tableConnect4.Controls.Add(b63, 5, 6);
            tableConnect4.Controls.Add(b53, 4, 6);
            tableConnect4.Controls.Add(b43, 3, 6);
            tableConnect4.Controls.Add(b33, 2, 6);
            tableConnect4.Controls.Add(b23, 1, 6);
            tableConnect4.Controls.Add(b13, 0, 6);
            tableConnect4.Controls.Add(b94, 8, 5);
            tableConnect4.Controls.Add(b84, 7, 5);
            tableConnect4.Controls.Add(b74, 6, 5);
            tableConnect4.Controls.Add(b64, 5, 5);
            tableConnect4.Controls.Add(b54, 4, 5);
            tableConnect4.Controls.Add(b44, 3, 5);
            tableConnect4.Controls.Add(b34, 2, 5);
            tableConnect4.Controls.Add(b24, 1, 5);
            tableConnect4.Controls.Add(b14, 0, 5);
            tableConnect4.Controls.Add(b95, 8, 4);
            tableConnect4.Controls.Add(b85, 7, 4);
            tableConnect4.Controls.Add(b75, 6, 4);
            tableConnect4.Controls.Add(b65, 5, 4);
            tableConnect4.Controls.Add(b55, 4, 4);
            tableConnect4.Controls.Add(b45, 3, 4);
            tableConnect4.Controls.Add(b35, 2, 4);
            tableConnect4.Controls.Add(b25, 1, 4);
            tableConnect4.Controls.Add(b15, 0, 4);
            tableConnect4.Controls.Add(b96, 8, 3);
            tableConnect4.Controls.Add(b86, 7, 3);
            tableConnect4.Controls.Add(b76, 6, 3);
            tableConnect4.Controls.Add(b66, 5, 3);
            tableConnect4.Controls.Add(b56, 4, 3);
            tableConnect4.Controls.Add(b46, 3, 3);
            tableConnect4.Controls.Add(b36, 2, 3);
            tableConnect4.Controls.Add(b26, 1, 3);
            tableConnect4.Controls.Add(b16, 0, 3);
            tableConnect4.Controls.Add(b97, 8, 2);
            tableConnect4.Controls.Add(b87, 7, 2);
            tableConnect4.Controls.Add(b77, 6, 2);
            tableConnect4.Controls.Add(b67, 5, 2);
            tableConnect4.Controls.Add(b57, 4, 2);
            tableConnect4.Controls.Add(b47, 3, 2);
            tableConnect4.Controls.Add(b37, 2, 2);
            tableConnect4.Controls.Add(b27, 1, 2);
            tableConnect4.Controls.Add(b17, 0, 2);
            tableConnect4.Controls.Add(b98, 8, 1);
            tableConnect4.Controls.Add(b88, 7, 1);
            tableConnect4.Controls.Add(b78, 6, 1);
            tableConnect4.Controls.Add(b68, 5, 1);
            tableConnect4.Controls.Add(b58, 4, 1);
            tableConnect4.Controls.Add(b48, 3, 1);
            tableConnect4.Controls.Add(b38, 2, 1);
            tableConnect4.Controls.Add(b28, 1, 1);
            tableConnect4.Controls.Add(b18, 0, 1);
            tableConnect4.Controls.Add(b99, 8, 0);
            tableConnect4.Controls.Add(b89, 7, 0);
            tableConnect4.Controls.Add(b79, 6, 0);
            tableConnect4.Controls.Add(b69, 5, 0);
            tableConnect4.Controls.Add(b59, 4, 0);
            tableConnect4.Controls.Add(b49, 3, 0);
            tableConnect4.Controls.Add(b39, 2, 0);
            tableConnect4.Controls.Add(b29, 1, 0);
            tableConnect4.Controls.Add(b19, 0, 0);
            tableConnect4.Controls.Add(b71, 6, 8);
            tableConnect4.Location = new Point(53, 115);
            tableConnect4.Name = "tableConnect4";
            tableConnect4.RowCount = 10;
            tableConnect4.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));
            tableConnect4.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));
            tableConnect4.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));
            tableConnect4.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));
            tableConnect4.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));
            tableConnect4.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));
            tableConnect4.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));
            tableConnect4.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));
            tableConnect4.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));
            tableConnect4.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableConnect4.Size = new Size(731, 640);
            tableConnect4.TabIndex = 7;
            // 
            // b91
            // 
            b91.Location = new Point(652, 572);
            b91.Name = "b91";
            b91.Size = new Size(74, 64);
            b91.TabIndex = 79;
            b91.UseVisualStyleBackColor = true;
            b91.Click += BtnColumn9_Click;
            // 
            // b81
            // 
            b81.Location = new Point(571, 572);
            b81.Name = "b81";
            b81.Size = new Size(74, 64);
            b81.TabIndex = 78;
            b81.UseVisualStyleBackColor = true;
            b81.Click += BtnColumn8_Click;
            // 
            // b61
            // 
            b61.Location = new Point(409, 572);
            b61.Name = "b61";
            b61.Size = new Size(74, 64);
            b61.TabIndex = 77;
            b61.UseVisualStyleBackColor = true;
            b61.Click += BtnColumn6_Click;
            // 
            // b51
            // 
            b51.Location = new Point(328, 572);
            b51.Name = "b51";
            b51.Size = new Size(74, 64);
            b51.TabIndex = 75;
            b51.UseVisualStyleBackColor = true;
            b51.Click += BtnColumn5_Click;
            // 
            // b41
            // 
            b41.Location = new Point(247, 572);
            b41.Name = "b41";
            b41.Size = new Size(74, 64);
            b41.TabIndex = 74;
            b41.UseVisualStyleBackColor = true;
            b41.Click += BtnColumn4_Click;
            // 
            // b31
            // 
            b31.Location = new Point(166, 572);
            b31.Name = "b31";
            b31.Size = new Size(74, 64);
            b31.TabIndex = 73;
            b31.UseVisualStyleBackColor = true;
            b31.Click += BtnColumn3_Click;
            // 
            // b21
            // 
            b21.Location = new Point(85, 572);
            b21.Name = "b21";
            b21.Size = new Size(74, 64);
            b21.TabIndex = 72;
            b21.UseVisualStyleBackColor = true;
            b21.Click += BtnColumn2_Click;
            // 
            // b11
            // 
            b11.Location = new Point(4, 572);
            b11.Name = "b11";
            b11.Size = new Size(74, 64);
            b11.TabIndex = 71;
            b11.UseVisualStyleBackColor = true;
            b11.Click += BtnColumn1_Click;
            // 
            // b92
            // 
            b92.Location = new Point(652, 501);
            b92.Name = "b92";
            b92.Size = new Size(74, 64);
            b92.TabIndex = 70;
            b92.UseVisualStyleBackColor = true;
            b92.Click += BtnColumn9_Click;
            // 
            // b82
            // 
            b82.Location = new Point(571, 501);
            b82.Name = "b82";
            b82.Size = new Size(74, 64);
            b82.TabIndex = 69;
            b82.UseVisualStyleBackColor = true;
            b82.Click += BtnColumn8_Click;
            // 
            // b72
            // 
            b72.Location = new Point(490, 501);
            b72.Name = "b72";
            b72.Size = new Size(74, 64);
            b72.TabIndex = 68;
            b72.UseVisualStyleBackColor = true;
            b72.Click += BtnColumn7_Click;
            // 
            // b62
            // 
            b62.Location = new Point(409, 501);
            b62.Name = "b62";
            b62.Size = new Size(74, 64);
            b62.TabIndex = 67;
            b62.UseVisualStyleBackColor = true;
            b62.Click += BtnColumn6_Click;
            // 
            // b52
            // 
            b52.Location = new Point(328, 501);
            b52.Name = "b52";
            b52.Size = new Size(74, 64);
            b52.TabIndex = 66;
            b52.UseVisualStyleBackColor = true;
            b52.Click += BtnColumn5_Click;
            // 
            // b42
            // 
            b42.Location = new Point(247, 501);
            b42.Name = "b42";
            b42.Size = new Size(74, 64);
            b42.TabIndex = 65;
            b42.UseVisualStyleBackColor = true;
            b42.Click += BtnColumn4_Click;
            // 
            // b32
            // 
            b32.Location = new Point(166, 501);
            b32.Name = "b32";
            b32.Size = new Size(74, 64);
            b32.TabIndex = 64;
            b32.UseVisualStyleBackColor = true;
            b32.Click += BtnColumn3_Click;
            // 
            // b22
            // 
            b22.Location = new Point(85, 501);
            b22.Name = "b22";
            b22.Size = new Size(74, 64);
            b22.TabIndex = 63;
            b22.UseVisualStyleBackColor = true;
            b22.Click += BtnColumn2_Click;
            // 
            // b12
            // 
            b12.Location = new Point(4, 501);
            b12.Name = "b12";
            b12.Size = new Size(74, 64);
            b12.TabIndex = 62;
            b12.UseVisualStyleBackColor = true;
            b12.Click += BtnColumn1_Click;
            // 
            // b93
            // 
            b93.Location = new Point(652, 430);
            b93.Name = "b93";
            b93.Size = new Size(74, 64);
            b93.TabIndex = 61;
            b93.UseVisualStyleBackColor = true;
            b93.Click += BtnColumn9_Click;
            // 
            // b83
            // 
            b83.Location = new Point(571, 430);
            b83.Name = "b83";
            b83.Size = new Size(74, 64);
            b83.TabIndex = 60;
            b83.UseVisualStyleBackColor = true;
            b83.Click += BtnColumn8_Click;
            // 
            // b73
            // 
            b73.Location = new Point(490, 430);
            b73.Name = "b73";
            b73.Size = new Size(74, 64);
            b73.TabIndex = 59;
            b73.UseVisualStyleBackColor = true;
            b73.Click += BtnColumn7_Click;
            // 
            // b63
            // 
            b63.Location = new Point(409, 430);
            b63.Name = "b63";
            b63.Size = new Size(74, 64);
            b63.TabIndex = 8;
            b63.UseVisualStyleBackColor = true;
            b63.Click += BtnColumn6_Click;
            // 
            // b53
            // 
            b53.Location = new Point(328, 430);
            b53.Name = "b53";
            b53.Size = new Size(74, 64);
            b53.TabIndex = 58;
            b53.UseVisualStyleBackColor = true;
            b53.Click += BtnColumn5_Click;
            // 
            // b43
            // 
            b43.Location = new Point(247, 430);
            b43.Name = "b43";
            b43.Size = new Size(74, 64);
            b43.TabIndex = 57;
            b43.UseVisualStyleBackColor = true;
            b43.Click += BtnColumn4_Click;
            // 
            // b33
            // 
            b33.Location = new Point(166, 430);
            b33.Name = "b33";
            b33.Size = new Size(74, 64);
            b33.TabIndex = 56;
            b33.UseVisualStyleBackColor = true;
            b33.Click += BtnColumn3_Click;
            // 
            // b23
            // 
            b23.Location = new Point(85, 430);
            b23.Name = "b23";
            b23.Size = new Size(74, 64);
            b23.TabIndex = 55;
            b23.UseVisualStyleBackColor = true;
            b23.Click += BtnColumn2_Click;
            // 
            // b13
            // 
            b13.Location = new Point(4, 430);
            b13.Name = "b13";
            b13.Size = new Size(74, 64);
            b13.TabIndex = 54;
            b13.UseVisualStyleBackColor = true;
            b13.Click += BtnColumn1_Click;
            // 
            // b94
            // 
            b94.Location = new Point(652, 359);
            b94.Name = "b94";
            b94.Size = new Size(74, 64);
            b94.TabIndex = 53;
            b94.UseVisualStyleBackColor = true;
            b94.Click += BtnColumn9_Click;
            // 
            // b84
            // 
            b84.Location = new Point(571, 359);
            b84.Name = "b84";
            b84.Size = new Size(74, 64);
            b84.TabIndex = 52;
            b84.UseVisualStyleBackColor = true;
            b84.Click += BtnColumn8_Click;
            // 
            // b74
            // 
            b74.Location = new Point(490, 359);
            b74.Name = "b74";
            b74.Size = new Size(74, 64);
            b74.TabIndex = 51;
            b74.UseVisualStyleBackColor = true;
            b74.Click += BtnColumn7_Click;
            // 
            // b64
            // 
            b64.Location = new Point(409, 359);
            b64.Name = "b64";
            b64.Size = new Size(74, 64);
            b64.TabIndex = 50;
            b64.UseVisualStyleBackColor = true;
            b64.Click += BtnColumn6_Click;
            // 
            // b54
            // 
            b54.Location = new Point(328, 359);
            b54.Name = "b54";
            b54.Size = new Size(74, 64);
            b54.TabIndex = 49;
            b54.UseVisualStyleBackColor = true;
            b54.Click += BtnColumn5_Click;
            // 
            // b44
            // 
            b44.Location = new Point(247, 359);
            b44.Name = "b44";
            b44.Size = new Size(74, 64);
            b44.TabIndex = 48;
            b44.UseVisualStyleBackColor = true;
            b44.Click += BtnColumn4_Click;
            // 
            // b34
            // 
            b34.Location = new Point(166, 359);
            b34.Name = "b34";
            b34.Size = new Size(74, 64);
            b34.TabIndex = 47;
            b34.UseVisualStyleBackColor = true;
            b34.Click += BtnColumn3_Click;
            // 
            // b24
            // 
            b24.Location = new Point(85, 359);
            b24.Name = "b24";
            b24.Size = new Size(74, 64);
            b24.TabIndex = 46;
            b24.UseVisualStyleBackColor = true;
            b24.Click += BtnColumn2_Click;
            // 
            // b14
            // 
            b14.Location = new Point(4, 359);
            b14.Name = "b14";
            b14.Size = new Size(74, 64);
            b14.TabIndex = 45;
            b14.UseVisualStyleBackColor = true;
            b14.Click += BtnColumn1_Click;
            // 
            // b95
            // 
            b95.Location = new Point(652, 288);
            b95.Name = "b95";
            b95.Size = new Size(74, 64);
            b95.TabIndex = 44;
            b95.UseVisualStyleBackColor = true;
            b95.Click += BtnColumn9_Click;
            // 
            // b85
            // 
            b85.Location = new Point(571, 288);
            b85.Name = "b85";
            b85.Size = new Size(74, 64);
            b85.TabIndex = 43;
            b85.UseVisualStyleBackColor = true;
            b85.Click += BtnColumn8_Click;
            // 
            // b75
            // 
            b75.Location = new Point(490, 288);
            b75.Name = "b75";
            b75.Size = new Size(74, 64);
            b75.TabIndex = 42;
            b75.UseVisualStyleBackColor = true;
            b75.Click += BtnColumn7_Click;
            // 
            // b65
            // 
            b65.Location = new Point(409, 288);
            b65.Name = "b65";
            b65.Size = new Size(74, 64);
            b65.TabIndex = 41;
            b65.UseVisualStyleBackColor = true;
            b65.Click += BtnColumn6_Click;
            // 
            // b55
            // 
            b55.Location = new Point(328, 288);
            b55.Name = "b55";
            b55.Size = new Size(74, 64);
            b55.TabIndex = 40;
            b55.UseVisualStyleBackColor = true;
            b55.Click += BtnColumn5_Click;
            // 
            // b45
            // 
            b45.Location = new Point(247, 288);
            b45.Name = "b45";
            b45.Size = new Size(74, 64);
            b45.TabIndex = 39;
            b45.UseVisualStyleBackColor = true;
            b45.Click += BtnColumn4_Click;
            // 
            // b35
            // 
            b35.Location = new Point(166, 288);
            b35.Name = "b35";
            b35.Size = new Size(74, 64);
            b35.TabIndex = 38;
            b35.UseVisualStyleBackColor = true;
            b35.Click += BtnColumn3_Click;
            // 
            // b25
            // 
            b25.Location = new Point(85, 288);
            b25.Name = "b25";
            b25.Size = new Size(74, 64);
            b25.TabIndex = 37;
            b25.UseVisualStyleBackColor = true;
            b25.Click += BtnColumn2_Click;
            // 
            // b15
            // 
            b15.Location = new Point(4, 288);
            b15.Name = "b15";
            b15.Size = new Size(74, 64);
            b15.TabIndex = 36;
            b15.UseVisualStyleBackColor = true;
            b15.Click += BtnColumn1_Click;
            // 
            // b96
            // 
            b96.Location = new Point(652, 217);
            b96.Name = "b96";
            b96.Size = new Size(74, 64);
            b96.TabIndex = 35;
            b96.UseVisualStyleBackColor = true;
            b96.Click += BtnColumn9_Click;
            // 
            // b86
            // 
            b86.Location = new Point(571, 217);
            b86.Name = "b86";
            b86.Size = new Size(74, 64);
            b86.TabIndex = 34;
            b86.UseVisualStyleBackColor = true;
            b86.Click += BtnColumn8_Click;
            // 
            // b76
            // 
            b76.Location = new Point(490, 217);
            b76.Name = "b76";
            b76.Size = new Size(74, 64);
            b76.TabIndex = 33;
            b76.UseVisualStyleBackColor = true;
            b76.Click += BtnColumn7_Click;
            // 
            // b66
            // 
            b66.Location = new Point(409, 217);
            b66.Name = "b66";
            b66.Size = new Size(74, 64);
            b66.TabIndex = 32;
            b66.UseVisualStyleBackColor = true;
            b66.Click += BtnColumn6_Click;
            // 
            // b56
            // 
            b56.Location = new Point(328, 217);
            b56.Name = "b56";
            b56.Size = new Size(74, 64);
            b56.TabIndex = 31;
            b56.UseVisualStyleBackColor = true;
            b56.Click += BtnColumn5_Click;
            // 
            // b46
            // 
            b46.Location = new Point(247, 217);
            b46.Name = "b46";
            b46.Size = new Size(74, 64);
            b46.TabIndex = 30;
            b46.UseVisualStyleBackColor = true;
            b46.Click += BtnColumn4_Click;
            // 
            // b36
            // 
            b36.Location = new Point(166, 217);
            b36.Name = "b36";
            b36.Size = new Size(74, 64);
            b36.TabIndex = 29;
            b36.UseVisualStyleBackColor = true;
            b36.Click += BtnColumn3_Click;
            // 
            // b26
            // 
            b26.Location = new Point(85, 217);
            b26.Name = "b26";
            b26.Size = new Size(74, 64);
            b26.TabIndex = 28;
            b26.UseVisualStyleBackColor = true;
            b26.Click += BtnColumn2_Click;
            // 
            // b16
            // 
            b16.Location = new Point(4, 217);
            b16.Name = "b16";
            b16.Size = new Size(74, 64);
            b16.TabIndex = 27;
            b16.UseVisualStyleBackColor = true;
            b16.Click += BtnColumn1_Click;
            // 
            // b97
            // 
            b97.Location = new Point(652, 146);
            b97.Name = "b97";
            b97.Size = new Size(74, 64);
            b97.TabIndex = 26;
            b97.UseVisualStyleBackColor = true;
            b97.Click += BtnColumn9_Click;
            // 
            // b87
            // 
            b87.Location = new Point(571, 146);
            b87.Name = "b87";
            b87.Size = new Size(74, 64);
            b87.TabIndex = 25;
            b87.UseVisualStyleBackColor = true;
            b87.Click += BtnColumn8_Click;
            // 
            // b77
            // 
            b77.Location = new Point(490, 146);
            b77.Name = "b77";
            b77.Size = new Size(74, 64);
            b77.TabIndex = 24;
            b77.UseVisualStyleBackColor = true;
            b77.Click += BtnColumn7_Click;
            // 
            // b67
            // 
            b67.Location = new Point(409, 146);
            b67.Name = "b67";
            b67.Size = new Size(74, 64);
            b67.TabIndex = 23;
            b67.UseVisualStyleBackColor = true;
            b67.Click += BtnColumn6_Click;
            // 
            // b57
            // 
            b57.Location = new Point(328, 146);
            b57.Name = "b57";
            b57.Size = new Size(74, 64);
            b57.TabIndex = 22;
            b57.UseVisualStyleBackColor = true;
            b57.Click += BtnColumn5_Click;
            // 
            // b47
            // 
            b47.Location = new Point(247, 146);
            b47.Name = "b47";
            b47.Size = new Size(74, 64);
            b47.TabIndex = 21;
            b47.UseVisualStyleBackColor = true;
            b47.Click += BtnColumn4_Click;
            // 
            // b37
            // 
            b37.Location = new Point(166, 146);
            b37.Name = "b37";
            b37.Size = new Size(74, 64);
            b37.TabIndex = 20;
            b37.UseVisualStyleBackColor = true;
            b37.Click += BtnColumn3_Click;
            // 
            // b27
            // 
            b27.Location = new Point(85, 146);
            b27.Name = "b27";
            b27.Size = new Size(74, 64);
            b27.TabIndex = 19;
            b27.UseVisualStyleBackColor = true;
            b27.Click += BtnColumn2_Click;
            // 
            // b17
            // 
            b17.Location = new Point(4, 146);
            b17.Name = "b17";
            b17.Size = new Size(74, 64);
            b17.TabIndex = 18;
            b17.UseVisualStyleBackColor = true;
            b17.Click += BtnColumn1_Click;
            // 
            // b98
            // 
            b98.Location = new Point(652, 75);
            b98.Name = "b98";
            b98.Size = new Size(74, 64);
            b98.TabIndex = 17;
            b98.UseVisualStyleBackColor = true;
            b98.Click += BtnColumn9_Click;
            // 
            // b88
            // 
            b88.Location = new Point(571, 75);
            b88.Name = "b88";
            b88.Size = new Size(74, 64);
            b88.TabIndex = 16;
            b88.UseVisualStyleBackColor = true;
            b88.Click += BtnColumn8_Click;
            // 
            // b78
            // 
            b78.Location = new Point(490, 75);
            b78.Name = "b78";
            b78.Size = new Size(74, 64);
            b78.TabIndex = 15;
            b78.UseVisualStyleBackColor = true;
            b78.Click += BtnColumn7_Click;
            // 
            // b68
            // 
            b68.Location = new Point(409, 75);
            b68.Name = "b68";
            b68.Size = new Size(74, 64);
            b68.TabIndex = 14;
            b68.UseVisualStyleBackColor = true;
            b68.Click += BtnColumn6_Click;
            // 
            // b58
            // 
            b58.Location = new Point(328, 75);
            b58.Name = "b58";
            b58.Size = new Size(74, 64);
            b58.TabIndex = 13;
            b58.UseVisualStyleBackColor = true;
            b58.Click += BtnColumn5_Click;
            // 
            // b48
            // 
            b48.Location = new Point(247, 75);
            b48.Name = "b48";
            b48.Size = new Size(74, 64);
            b48.TabIndex = 12;
            b48.UseVisualStyleBackColor = true;
            b48.Click += BtnColumn4_Click;
            // 
            // b38
            // 
            b38.Location = new Point(166, 75);
            b38.Name = "b38";
            b38.Size = new Size(74, 64);
            b38.TabIndex = 11;
            b38.UseVisualStyleBackColor = true;
            b38.Click += BtnColumn3_Click;
            // 
            // b28
            // 
            b28.Location = new Point(85, 75);
            b28.Name = "b28";
            b28.Size = new Size(74, 64);
            b28.TabIndex = 10;
            b28.UseVisualStyleBackColor = true;
            b28.Click += BtnColumn2_Click;
            // 
            // b18
            // 
            b18.Location = new Point(4, 75);
            b18.Name = "b18";
            b18.Size = new Size(74, 64);
            b18.TabIndex = 9;
            b18.UseVisualStyleBackColor = true;
            b18.Click += BtnColumn1_Click;
            // 
            // b99
            // 
            b99.Location = new Point(652, 4);
            b99.Name = "b99";
            b99.Size = new Size(74, 64);
            b99.TabIndex = 8;
            b99.UseVisualStyleBackColor = true;
            b99.Click += BtnColumn9_Click;
            // 
            // b89
            // 
            b89.Location = new Point(571, 4);
            b89.Name = "b89";
            b89.Size = new Size(74, 64);
            b89.TabIndex = 7;
            b89.UseVisualStyleBackColor = true;
            b89.Click += BtnColumn8_Click;
            // 
            // b79
            // 
            b79.Location = new Point(490, 4);
            b79.Name = "b79";
            b79.Size = new Size(74, 64);
            b79.TabIndex = 6;
            b79.UseVisualStyleBackColor = true;
            b79.Click += BtnColumn7_Click;
            // 
            // b69
            // 
            b69.Location = new Point(409, 4);
            b69.Name = "b69";
            b69.Size = new Size(74, 64);
            b69.TabIndex = 5;
            b69.UseVisualStyleBackColor = true;
            b69.Click += BtnColumn6_Click;
            // 
            // b59
            // 
            b59.Location = new Point(328, 4);
            b59.Name = "b59";
            b59.Size = new Size(74, 64);
            b59.TabIndex = 4;
            b59.UseVisualStyleBackColor = true;
            b59.Click += BtnColumn5_Click;
            // 
            // b49
            // 
            b49.Location = new Point(247, 4);
            b49.Name = "b49";
            b49.Size = new Size(74, 64);
            b49.TabIndex = 3;
            b49.UseVisualStyleBackColor = true;
            b49.Click += BtnColumn4_Click;
            // 
            // b39
            // 
            b39.Location = new Point(166, 4);
            b39.Name = "b39";
            b39.Size = new Size(74, 64);
            b39.TabIndex = 2;
            b39.UseVisualStyleBackColor = true;
            b39.Click += BtnColumn3_Click;
            // 
            // b29
            // 
            b29.Location = new Point(85, 4);
            b29.Name = "b29";
            b29.Size = new Size(74, 64);
            b29.TabIndex = 1;
            b29.UseVisualStyleBackColor = true;
            b29.Click += BtnColumn2_Click;
            // 
            // b19
            // 
            b19.Location = new Point(4, 4);
            b19.Name = "b19";
            b19.Size = new Size(74, 64);
            b19.TabIndex = 0;
            b19.UseVisualStyleBackColor = true;
            b19.Click += BtnColumn1_Click;
            // 
            // b71
            // 
            b71.Location = new Point(490, 572);
            b71.Name = "b71";
            b71.Size = new Size(74, 64);
            b71.TabIndex = 76;
            b71.UseVisualStyleBackColor = true;
            b71.Click += BtnColumn7_Click;
            // 
            // btnTurn
            // 
            btnTurn.Location = new Point(1063, 217);
            btnTurn.Name = "btnTurn";
            btnTurn.Size = new Size(45, 44);
            btnTurn.TabIndex = 80;
            btnTurn.UseVisualStyleBackColor = true;
            // 
            // btnDurdur
            // 
            btnDurdur.Font = new Font("Elephant", 16.1999989F, FontStyle.Regular, GraphicsUnit.Point);
            btnDurdur.Location = new Point(901, 575);
            btnDurdur.Name = "btnDurdur";
            btnDurdur.Size = new Size(177, 83);
            btnDurdur.TabIndex = 81;
            btnDurdur.Text = "Oyunu Durdur";
            btnDurdur.UseVisualStyleBackColor = true;
            btnDurdur.Click += btnDurdur_Click;
            // 
            // Connection4_oyunuson
            // 
            ClientSize = new Size(1178, 783);
            Controls.Add(btnDurdur);
            Controls.Add(btnTurn);
            Controls.Add(tableConnect4);
            Controls.Add(btnEskiOyun);
            Controls.Add(btnRestart);
            Controls.Add(lblTurn);
            Controls.Add(lblMove);
            Controls.Add(lblGreenScore);
            Controls.Add(lblPurpleScore);
            Controls.Add(lblTitle);
            Name = "Connection4_oyunuson";
            tableConnect4.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion





        private Label lblTitle;
        private Label lblPurpleScore;
        private Label lblGreenScore;
        private Label lblMove;
        private Label lblTurn;
        private Button btnRestart;
        private Button btnEskiOyun;
        private TableLayoutPanel tableConnect4;
        private RoundButton b91;
        private RoundButton b81;
        private RoundButton b61;
        private RoundButton b51;
        private RoundButton b41;
        private RoundButton b31;
        private RoundButton b21;
        private RoundButton b11;
        private RoundButton b92;
        private RoundButton b82;
        private RoundButton b72;
        private RoundButton b62;
        private RoundButton b52;
        private RoundButton b42;
        private RoundButton b32;
        private RoundButton b22;
        private RoundButton b12;
        private RoundButton b93;
        private RoundButton b83;
        private RoundButton b73;
        private RoundButton b63;
        private RoundButton b53;
        private RoundButton b43;
        private RoundButton b33;
        private RoundButton b23;
        private RoundButton b13;
        private RoundButton b94;
        private RoundButton b84;
        private RoundButton b74;
        private RoundButton b64;
        private RoundButton b54;
        private RoundButton b44;
        private RoundButton b34;
        private RoundButton b24;
        private RoundButton b14;
        private RoundButton b95;
        private RoundButton b85;
        private RoundButton b75;
        private RoundButton b65;
        private RoundButton b55;
        private RoundButton b45;
        private RoundButton b35;
        private RoundButton b25;
        private RoundButton b15;
        private RoundButton b96;
        private RoundButton b86;
        private RoundButton b76;
        private RoundButton b66;
        private RoundButton b56;
        private RoundButton b46;
        private RoundButton b36;
        private RoundButton b26;
        private RoundButton b16;
        private RoundButton b97;
        private RoundButton b87;
        private RoundButton b77;
        private RoundButton b67;
        private RoundButton b57;
        private RoundButton b47;
        private RoundButton b37;
        private RoundButton b27;
        private RoundButton b17;
        private RoundButton b98;
        private RoundButton b88;
        private RoundButton b78;
        private RoundButton b68;
        private RoundButton b58;
        private RoundButton b48;
        private RoundButton b38;
        private RoundButton b28;
        private RoundButton b18;
        private RoundButton b99;
        private RoundButton b89;
        private RoundButton b79;
        private RoundButton b69;
        private RoundButton b59;
        private RoundButton b49;
        private RoundButton b39;
        private RoundButton b29;
        private RoundButton b19;
        private RoundButton b71;
        private RoundButton btnTurn;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button btnDurdur;
    }
}